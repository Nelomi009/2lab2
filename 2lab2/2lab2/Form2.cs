using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2lab2 // Укажи свое пространство имен (namespace проекта)
{
  public partial class Form2 : Form // Если форма называется task1, оставь имя task1
  {
    private CancellationTokenSource _cts;
    private bool _isSortingRunning = false;


    public Form2() {
      InitializeComponent();
      dataGridView1.AutoGenerateColumns = false;
    }

    // ==========================================
    // 1. СНЯТИЕ ДАННЫХ И ВАЛИДАЦИЯ
    // ==========================================
    private List<int> GetInputData() {
      List<int> data = new List<int>();
      foreach (DataGridViewRow row in dataGridView1.Rows) {
        if (row.IsNewRow) continue;
        var cell = row.Cells[0].Value;
        if (cell != null && int.TryParse(cell.ToString().Trim(), out int val)) {
          data.Add(val);
        }
        else if (cell != null && !string.IsNullOrWhiteSpace(cell.ToString())) {
          MessageBox.Show($"Некорректное значение: '{cell}'. Вводите только целые числа!",
              "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return null;
        }
      }
      return data;
    }

    // ==========================================
    // 2. ОТРИСОВКА СТОЛБИКОВ В PICTUREBOX
    // ==========================================
    private void DrawArray(PictureBox pb, int[] arr, int activeIdx1 = -1, int activeIdx2 = -1) {
      if (arr == null || arr.Length == 0 || pb.Width <= 0 || pb.Height <= 0) return;

      Bitmap bmp = new Bitmap(pb.Width, pb.Height);
      using (Graphics g = Graphics.FromImage(bmp)) {
        g.Clear(Color.White);
        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

        float barWidth = (float)pb.Width / arr.Length;
        int maxVal = arr.Max();
        if (maxVal <= 0) maxVal = 1;

        // Резервируем верхние 24 пикселя строго под цифры
        float topMargin = 22f;
        float usableHeight = pb.Height - topMargin - 4f;

        using (Font font = new Font("Arial", 8f, FontStyle.Bold))
        using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center }) {
          for (int i = 0; i < arr.Length; i++) {
            float barHeight = ((float)arr[i] / maxVal) * usableHeight;
            Brush brush = Brushes.SteelBlue;
            if (i == activeIdx1 || i == activeIdx2) brush = Brushes.Red;

            float x = i * barWidth;
            float y = pb.Height - barHeight;

            // Столбик
            g.FillRectangle(brush, x + 1, y, Math.Max(1, barWidth - 2), barHeight);

            // Число рисуем ровно над столбиком, но не выше 2 пикселей от края PictureBox
            if (arr.Length <= 25) {
              float textY = Math.Max(2f, y - 16f);
              g.DrawString(arr[i].ToString(), font, Brushes.Black, x + (barWidth / 2f), textY, sf);
            }
          }
        }
      }

      pb.Invoke(new Action(() =>
      {
        pb.Image?.Dispose();
        pb.Image = bmp;
      }));
    }

    // ==========================================
    // 3. АЛГОРИТМЫ СОРТИРОВОК
    // ==========================================

    // 1. Пузырьковая
    private async Task<long> BubbleSortAsync(int[] arr, PictureBox pb, bool asc, CancellationToken token) {
      Stopwatch sw = Stopwatch.StartNew();
      int n = arr.Length;
      for (int i = 0; i < n - 1; i++) {
        for (int j = 0; j < n - i - 1; j++) {
          token.ThrowIfCancellationRequested();
          bool needSwap = asc ? arr[j] > arr[j + 1] : arr[j] < arr[j + 1];
          if (needSwap) {
            (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
          }
          DrawArray(pb, arr, j, j + 1);
          await Task.Delay(10, token);
        }
      }
      sw.Stop();
      DrawArray(pb, arr);
      return sw.ElapsedMilliseconds;
    }

    // 2. Вставками
    private async Task<long> InsertionSortAsync(int[] arr, PictureBox pb, bool asc, CancellationToken token) {
      Stopwatch sw = Stopwatch.StartNew();
      for (int i = 1; i < arr.Length; i++) {
        int key = arr[i];
        int j = i - 1;
        while (j >= 0 && (asc ? arr[j] > key : arr[j] < key)) {
          token.ThrowIfCancellationRequested();
          arr[j + 1] = arr[j];
          j--;
          DrawArray(pb, arr, j, i);
          await Task.Delay(10, token);
        }
        arr[j + 1] = key;
      }
      sw.Stop();
      DrawArray(pb, arr);
      return sw.ElapsedMilliseconds;
    }

    // 3. Шейкерная
    private async Task<long> ShakerSortAsync(int[] arr, PictureBox pb, bool asc, CancellationToken token) {
      Stopwatch sw = Stopwatch.StartNew();
      int left = 0, right = arr.Length - 1;
      while (left < right) {
        for (int i = left; i < right; i++) {
          token.ThrowIfCancellationRequested();
          bool needSwap = asc ? arr[i] > arr[i + 1] : arr[i] < arr[i + 1];
          if (needSwap) (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
          DrawArray(pb, arr, i, i + 1);
          await Task.Delay(10, token);
        }
        right--;

        for (int i = right; i > left; i--) {
          token.ThrowIfCancellationRequested();
          bool needSwap = asc ? arr[i - 1] > arr[i] : arr[i - 1] < arr[i];
          if (needSwap) (arr[i - 1], arr[i]) = (arr[i], arr[i - 1]);
          DrawArray(pb, arr, i - 1, i);
          await Task.Delay(10, token);
        }
        left++;
      }
      sw.Stop();
      DrawArray(pb, arr);
      return sw.ElapsedMilliseconds;
    }

    // 4. Быстрая (QuickSort)
    private async Task<long> QuickSortAsync(int[] arr, PictureBox pb, bool asc, CancellationToken token) {
      Stopwatch sw = Stopwatch.StartNew();

      async Task SortRange(int left, int right) {
        if (left >= right) return;
        int pivot = arr[(left + right) / 2];
        int i = left, j = right;

        while (i <= j) {
          token.ThrowIfCancellationRequested();
          while (asc ? arr[i] < pivot : arr[i] > pivot) i++;
          while (asc ? arr[j] > pivot : arr[j] < pivot) j--;

          if (i <= j) {
            (arr[i], arr[j]) = (arr[j], arr[i]);
            DrawArray(pb, arr, i, j);
            await Task.Delay(15, token);
            i++;
            j--;
          }
        }
        await SortRange(left, j);
        await SortRange(i, right);
      }

      await SortRange(0, arr.Length - 1);
      sw.Stop();
      DrawArray(pb, arr);
      return sw.ElapsedMilliseconds;
    }

    // 5. BOGO Sort
    private async Task<long> BogoSortAsync(int[] arr, PictureBox pb, bool asc, CancellationToken token) {
      Stopwatch sw = Stopwatch.StartNew();
      Random rnd = new Random();

      bool IsSorted() {
        for (int i = 0; i < arr.Length - 1; i++)
          if (asc ? arr[i] > arr[i + 1] : arr[i] < arr[i + 1]) return false;
        return true;
      }

      while (!IsSorted()) {
        token.ThrowIfCancellationRequested();
        for (int i = arr.Length - 1; i > 0; i--) {
          int j = rnd.Next(i + 1);
          (arr[i], arr[j]) = (arr[j], arr[i]);
        }
        DrawArray(pb, arr);
        await Task.Delay(25, token);
      }

      sw.Stop();
      DrawArray(pb, arr);
      return sw.ElapsedMilliseconds;
    }

    // ==========================================
    // 4. ОБРАБОТЧИКИ МЕНЮ (MenuStrip)
    // ==========================================

    // Запуск сортировок
    private async void menuStartSort_Click(object sender, EventArgs e) {
      if (_isSortingRunning) {
        MessageBox.Show("Сортировка уже запущена!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      var rawData = GetInputData();
      if (rawData == null || rawData.Count == 0) {
        MessageBox.Show("Заполните таблицу данными!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      if (chkBogo.Checked && rawData.Count > 7) {
        MessageBox.Show("Для BOGO-сортировки рекомендуется не более 7 элементов, иначе она будет выполняться слишком долго!",
            "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

      _cts = new CancellationTokenSource();
      bool asc = radioButton2.Checked;
      List<Task> tasks = new List<Task>();

      bool hasWinner = false;
      object winnerLock = new object();

      lblFastest.Text = "Самый быстрый алгоритм: —";
      _isSortingRunning = true;

      void CheckAndSetWinner(string name, long timeMs) {
        lock (winnerLock) {
          if (!hasWinner) {
            hasWinner = true;
            Invoke(new Action(() =>
            {
              lblFastest.Text = $"Самый быстрый алгоритм: {name} ({timeMs} мс)";
            }));
          }
        }
      }

      try {
        if (chkBubble.Checked) {
          int[] arr = rawData.ToArray();
          tasks.Add(Task.Run(async () =>
          {
            long t = await BubbleSortAsync(arr, pbBubble, asc, _cts.Token);
            Invoke(new Action(() => lblBubbleTime.Text = $"Пузырьковая: {t} мс"));
            CheckAndSetWinner("Пузырьковая", t);
          }));
        }

        if (chkInsertion.Checked) {
          int[] arr = rawData.ToArray();
          tasks.Add(Task.Run(async () =>
          {
            long t = await InsertionSortAsync(arr, pbInsertion, asc, _cts.Token);
            Invoke(new Action(() => lblInsertionTime.Text = $"Вставками: {t} мс"));
            CheckAndSetWinner("Вставками", t);
          }));
        }

        if (chkShaker.Checked) {
          int[] arr = rawData.ToArray();
          tasks.Add(Task.Run(async () =>
          {
            long t = await ShakerSortAsync(arr, pbShaker, asc, _cts.Token);
            Invoke(new Action(() => lblShakerTime.Text = $"Шейкерная: {t} мс"));
            CheckAndSetWinner("Шейкерная", t);
          }));
        }

        if (chkQuick.Checked) {
          int[] arr = rawData.ToArray();
          tasks.Add(Task.Run(async () =>
          {
            long t = await QuickSortAsync(arr, pbQuick, asc, _cts.Token);
            Invoke(new Action(() => lblQuickTime.Text = $"Быстрая: {t} мс"));
            CheckAndSetWinner("Быстрая", t);
          }));
        }

        if (chkBogo.Checked) {
          int[] arr = rawData.ToArray();
          tasks.Add(Task.Run(async () =>
          {
            long t = await BogoSortAsync(arr, pbBogo, asc, _cts.Token);
            Invoke(new Action(() => lblBogoTime.Text = $"BOGO: {t} мс"));
            CheckAndSetWinner("BOGO", t);
          }));
        }

        await Task.WhenAll(tasks);
      }
      catch (OperationCanceledException) {
        // Сортировка прервана
      }
      finally {
        _isSortingRunning = false;
      }
    }

    // Остановка сортировки
    private void menuStopSort_Click(object sender, EventArgs e) {
      _cts?.Cancel();
      _isSortingRunning = false;
    }

    // Генерация случайных чисел
    private void menuGenerate_Click(object sender, EventArgs e) {
      if (_isSortingRunning) {
        MessageBox.Show("Сначала остановите сортировку, затем меняйте данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      dataGridView1.Rows.Clear();
      dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
      dataGridView1.DefaultCellStyle.BackColor = Color.White;

      Random rnd = new Random();
      int count = 15;

      for (int i = 0; i < count; i++) {
        int rowIndex = dataGridView1.Rows.Add();
        dataGridView1.Rows[rowIndex].Cells[0].Value = rnd.Next(10, 100).ToString();
      }

      dataGridView1.ClearSelection();
    }

    // Загрузка из файла
    private void menuLoadFile_Click(object sender, EventArgs e) {
      if (_isSortingRunning) {
        MessageBox.Show("Сначала остановите сортировку, затем загружайте данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      using (OpenFileDialog ofd = new OpenFileDialog()) {
        ofd.Filter = "Текстовые и CSV файлы (*.csv;*.txt)|*.csv;*.txt|Все файлы (*.*)|*.*";
        if (ofd.ShowDialog() == DialogResult.OK) {
          try {
            dataGridView1.Rows.Clear();
            string[] lines = File.ReadAllLines(ofd.FileName);
            foreach (string line in lines) {
              string[] parts = line.Split(new char[] { ',', ';', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
              foreach (string p in parts) {
                if (int.TryParse(p.Trim(), out int val)) {
                  int rowIndex = dataGridView1.Rows.Add();
                  dataGridView1.Rows[rowIndex].Cells[0].Value = val.ToString();
                }
              }
            }
          }
          catch (Exception ex) {
            MessageBox.Show($"Ошибка чтения файла: {ex.Message}");
          }
        }
      }
    }

    // Очистить
    private void menuClear_Click(object sender, EventArgs e) {
      if (_isSortingRunning) {
        MessageBox.Show("Сначала остановите сортировку перед очисткой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      // Очистка таблицы
      dataGridView1.Rows.Clear();

      // Очистка PictureBox
      pbBubble.Image = null;
      pbInsertion.Image = null;
      pbShaker.Image = null;
      pbQuick.Image = null;
      pbBogo.Image = null;

      // Очистка надписей с миллисекундами
      lblBubbleTime.Text = "Пузырьковая: —";
      lblInsertionTime.Text = "Вставками: —";
      lblShakerTime.Text = "Шейкерная: —";
      lblQuickTime.Text = "Быстрая: —";
      lblBogoTime.Text = "BOGO: —";
      lblFastest.Text = "Самый быстрый алгоритм: —";
    }

    // Выход
    private void menuExit_Click(object sender, EventArgs e) {
      _cts?.Cancel();
      this.Close();
    }

    private void Form2_Load(object sender, EventArgs e) {

    }

    private void Form2_Load_1(object sender, EventArgs e) {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

    }
  }
}