namespace _2lab2 {
  partial class Form2 {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent() {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuGenerate = new System.Windows.Forms.ToolStripMenuItem();
      this.menuLoadFile = new System.Windows.Forms.ToolStripMenuItem();
      this.menuClear = new System.Windows.Forms.ToolStripMenuItem();
      this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStartSort = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStopSort = new System.Windows.Forms.ToolStripMenuItem();
      this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.chkBogo = new System.Windows.Forms.CheckBox();
      this.chkQuick = new System.Windows.Forms.CheckBox();
      this.chkShaker = new System.Windows.Forms.CheckBox();
      this.chkInsertion = new System.Windows.Forms.CheckBox();
      this.chkBubble = new System.Windows.Forms.CheckBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.rbDesc = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pbBubble = new System.Windows.Forms.PictureBox();
      this.lblBubbleTime = new System.Windows.Forms.Label();
      this.pbInsertion = new System.Windows.Forms.PictureBox();
      this.lblInsertionTime = new System.Windows.Forms.Label();
      this.pbShaker = new System.Windows.Forms.PictureBox();
      this.lblShakerTime = new System.Windows.Forms.Label();
      this.pbQuick = new System.Windows.Forms.PictureBox();
      this.lblQuickTime = new System.Windows.Forms.Label();
      this.pbBogo = new System.Windows.Forms.PictureBox();
      this.lblBogoTime = new System.Windows.Forms.Label();
      this.lblFastest = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBubble)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbInsertion)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbShaker)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbQuick)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBogo)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеToolStripMenuItem,
            this.сортировкаToolStripMenuItem,
            this.выходToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(950, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // данныеToolStripMenuItem
      // 
      this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGenerate,
            this.menuLoadFile,
            this.menuClear});
      this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
      this.данныеToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
      this.данныеToolStripMenuItem.Text = "Данные";
      // 
      // menuGenerate
      // 
      this.menuGenerate.Name = "menuGenerate";
      this.menuGenerate.Size = new System.Drawing.Size(221, 22);
      this.menuGenerate.Text = "Сгенерировать случайные";
      this.menuGenerate.Click += new System.EventHandler(this.menuGenerate_Click);
      // 
      // menuLoadFile
      // 
      this.menuLoadFile.Name = "menuLoadFile";
      this.menuLoadFile.Size = new System.Drawing.Size(221, 22);
      this.menuLoadFile.Text = "Загрузить из файла";
      this.menuLoadFile.Click += new System.EventHandler(this.menuLoadFile_Click);
      // 
      // menuClear
      // 
      this.menuClear.Name = "menuClear";
      this.menuClear.Size = new System.Drawing.Size(221, 22);
      this.menuClear.Text = "Очистить";
      this.menuClear.Click += new System.EventHandler(this.menuClear_Click);
      // 
      // сортировкаToolStripMenuItem
      // 
      this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStartSort,
            this.menuStopSort});
      this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
      this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
      this.сортировкаToolStripMenuItem.Text = "Сортировка";
      // 
      // menuStartSort
      // 
      this.menuStartSort.Name = "menuStartSort";
      this.menuStartSort.Size = new System.Drawing.Size(196, 22);
      this.menuStartSort.Text = "Запустить сортировку";
      this.menuStartSort.Click += new System.EventHandler(this.menuStartSort_Click);
      // 
      // menuStopSort
      // 
      this.menuStopSort.Name = "menuStopSort";
      this.menuStopSort.Size = new System.Drawing.Size(196, 22);
      this.menuStopSort.Text = "Остановить";
      this.menuStopSort.Click += new System.EventHandler(this.menuStopSort_Click);
      // 
      // выходToolStripMenuItem
      // 
      this.выходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
      this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
      this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
      this.выходToolStripMenuItem.Text = "Выход";
      // 
      // menuExit
      // 
      this.menuExit.Name = "menuExit";
      this.menuExit.Size = new System.Drawing.Size(163, 22);
      this.menuExit.Text = "В главное меню";
      this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.chkBogo);
      this.groupBox1.Controls.Add(this.chkQuick);
      this.groupBox1.Controls.Add(this.chkShaker);
      this.groupBox1.Controls.Add(this.chkInsertion);
      this.groupBox1.Controls.Add(this.chkBubble);
      this.groupBox1.Location = new System.Drawing.Point(12, 35);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(160, 160);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Выбор алгоритмов";
      // 
      // chkBogo
      // 
      this.chkBogo.AutoSize = true;
      this.chkBogo.Location = new System.Drawing.Point(15, 125);
      this.chkBogo.Name = "chkBogo";
      this.chkBogo.Size = new System.Drawing.Size(57, 17);
      this.chkBogo.TabIndex = 4;
      this.chkBogo.Text = "BOGO";
      this.chkBogo.UseVisualStyleBackColor = true;
      // 
      // chkQuick
      // 
      this.chkQuick.AutoSize = true;
      this.chkQuick.Location = new System.Drawing.Point(15, 99);
      this.chkQuick.Name = "chkQuick";
      this.chkQuick.Size = new System.Drawing.Size(70, 17);
      this.chkQuick.TabIndex = 3;
      this.chkQuick.Text = "Быстрая";
      this.chkQuick.UseVisualStyleBackColor = true;
      // 
      // chkShaker
      // 
      this.chkShaker.AutoSize = true;
      this.chkShaker.Location = new System.Drawing.Point(15, 73);
      this.chkShaker.Name = "chkShaker";
      this.chkShaker.Size = new System.Drawing.Size(83, 17);
      this.chkShaker.TabIndex = 2;
      this.chkShaker.Text = "Шейкерная";
      this.chkShaker.UseVisualStyleBackColor = true;
      // 
      // chkInsertion
      // 
      this.chkInsertion.AutoSize = true;
      this.chkInsertion.Location = new System.Drawing.Point(15, 47);
      this.chkInsertion.Name = "chkInsertion";
      this.chkInsertion.Size = new System.Drawing.Size(82, 17);
      this.chkInsertion.TabIndex = 1;
      this.chkInsertion.Text = "Вставками";
      this.chkInsertion.UseVisualStyleBackColor = true;
      // 
      // chkBubble
      // 
      this.chkBubble.AutoSize = true;
      this.chkBubble.Location = new System.Drawing.Point(15, 21);
      this.chkBubble.Name = "chkBubble";
      this.chkBubble.Size = new System.Drawing.Size(95, 17);
      this.chkBubble.TabIndex = 0;
      this.chkBubble.Text = "Пузырьковая";
      this.chkBubble.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.rbDesc);
      this.groupBox2.Controls.Add(this.radioButton2);
      this.groupBox2.Location = new System.Drawing.Point(180, 35);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(150, 80);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Направление";
      // 
      // rbDesc
      // 
      this.rbDesc.AutoSize = true;
      this.rbDesc.Location = new System.Drawing.Point(15, 47);
      this.rbDesc.Name = "rbDesc";
      this.rbDesc.Size = new System.Drawing.Size(93, 17);
      this.rbDesc.TabIndex = 1;
      this.rbDesc.Text = "По убыванию";
      this.rbDesc.UseVisualStyleBackColor = true;
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Checked = true;
      this.radioButton2.Location = new System.Drawing.Point(15, 21);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(109, 17);
      this.radioButton2.TabIndex = 0;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "По возрастанию";
      this.radioButton2.UseVisualStyleBackColor = true;
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colValue});
      this.dataGridView1.Location = new System.Drawing.Point(12, 205);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(266, 320);
      this.dataGridView1.TabIndex = 3;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // colValue
      // 
      this.colValue.HeaderText = "Элементы массива";
      this.colValue.Name = "colValue";
      this.colValue.Width = 250;
      // 
      // pbBubble
      // 
      this.pbBubble.BackColor = System.Drawing.Color.White;
      this.pbBubble.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbBubble.Location = new System.Drawing.Point(480, 35);
      this.pbBubble.Name = "pbBubble";
      this.pbBubble.Size = new System.Drawing.Size(440, 75);
      this.pbBubble.TabIndex = 4;
      this.pbBubble.TabStop = false;
      // 
      // lblBubbleTime
      // 
      this.lblBubbleTime.AutoSize = true;
      this.lblBubbleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
      this.lblBubbleTime.Location = new System.Drawing.Point(334, 58);
      this.lblBubbleTime.Name = "lblBubbleTime";
      this.lblBubbleTime.Size = new System.Drawing.Size(108, 15);
      this.lblBubbleTime.TabIndex = 5;
      this.lblBubbleTime.Text = "Пузырьковая: -";
      // 
      // pbInsertion
      // 
      this.pbInsertion.BackColor = System.Drawing.Color.White;
      this.pbInsertion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbInsertion.Location = new System.Drawing.Point(480, 125);
      this.pbInsertion.Name = "pbInsertion";
      this.pbInsertion.Size = new System.Drawing.Size(440, 75);
      this.pbInsertion.TabIndex = 6;
      this.pbInsertion.TabStop = false;
      // 
      // lblInsertionTime
      // 
      this.lblInsertionTime.AutoSize = true;
      this.lblInsertionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
      this.lblInsertionTime.Location = new System.Drawing.Point(334, 148);
      this.lblInsertionTime.Name = "lblInsertionTime";
      this.lblInsertionTime.Size = new System.Drawing.Size(93, 15);
      this.lblInsertionTime.TabIndex = 7;
      this.lblInsertionTime.Text = "Вставками: -";
      // 
      // pbShaker
      // 
      this.pbShaker.BackColor = System.Drawing.Color.White;
      this.pbShaker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbShaker.Location = new System.Drawing.Point(480, 215);
      this.pbShaker.Name = "pbShaker";
      this.pbShaker.Size = new System.Drawing.Size(440, 75);
      this.pbShaker.TabIndex = 8;
      this.pbShaker.TabStop = false;
      // 
      // lblShakerTime
      // 
      this.lblShakerTime.AutoSize = true;
      this.lblShakerTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
      this.lblShakerTime.Location = new System.Drawing.Point(334, 238);
      this.lblShakerTime.Name = "lblShakerTime";
      this.lblShakerTime.Size = new System.Drawing.Size(95, 15);
      this.lblShakerTime.TabIndex = 9;
      this.lblShakerTime.Text = "Шейкерная: -";
      // 
      // pbQuick
      // 
      this.pbQuick.BackColor = System.Drawing.Color.White;
      this.pbQuick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbQuick.Location = new System.Drawing.Point(480, 305);
      this.pbQuick.Name = "pbQuick";
      this.pbQuick.Size = new System.Drawing.Size(440, 75);
      this.pbQuick.TabIndex = 10;
      this.pbQuick.TabStop = false;
      // 
      // lblQuickTime
      // 
      this.lblQuickTime.AutoSize = true;
      this.lblQuickTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
      this.lblQuickTime.Location = new System.Drawing.Point(334, 328);
      this.lblQuickTime.Name = "lblQuickTime";
      this.lblQuickTime.Size = new System.Drawing.Size(78, 15);
      this.lblQuickTime.TabIndex = 11;
      this.lblQuickTime.Text = "Быстрая: -";
      // 
      // pbBogo
      // 
      this.pbBogo.BackColor = System.Drawing.Color.White;
      this.pbBogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbBogo.Location = new System.Drawing.Point(480, 395);
      this.pbBogo.Name = "pbBogo";
      this.pbBogo.Size = new System.Drawing.Size(440, 75);
      this.pbBogo.TabIndex = 12;
      this.pbBogo.TabStop = false;
      // 
      // lblBogoTime
      // 
      this.lblBogoTime.AutoSize = true;
      this.lblBogoTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
      this.lblBogoTime.Location = new System.Drawing.Point(334, 418);
      this.lblBogoTime.Name = "lblBogoTime";
      this.lblBogoTime.Size = new System.Drawing.Size(59, 15);
      this.lblBogoTime.TabIndex = 13;
      this.lblBogoTime.Text = "BOGO: -";
      // 
      // lblFastest
      // 
      this.lblFastest.AutoSize = true;
      this.lblFastest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
      this.lblFastest.ForeColor = System.Drawing.Color.DarkGreen;
      this.lblFastest.Location = new System.Drawing.Point(360, 485);
      this.lblFastest.Name = "lblFastest";
      this.lblFastest.Size = new System.Drawing.Size(235, 18);
      this.lblFastest.TabIndex = 14;
      this.lblFastest.Text = "Самый быстрый алгоритм: —";
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(950, 520);
      this.Controls.Add(this.lblFastest);
      this.Controls.Add(this.lblBogoTime);
      this.Controls.Add(this.pbBogo);
      this.Controls.Add(this.lblQuickTime);
      this.Controls.Add(this.pbQuick);
      this.Controls.Add(this.lblShakerTime);
      this.Controls.Add(this.pbShaker);
      this.Controls.Add(this.lblInsertionTime);
      this.Controls.Add(this.pbInsertion);
      this.Controls.Add(this.lblBubbleTime);
      this.Controls.Add(this.pbBubble);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form2";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Задание 1";
      this.Load += new System.EventHandler(this.Form2_Load_1);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBubble)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbInsertion)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbShaker)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbQuick)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBogo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem menuGenerate;
    private System.Windows.Forms.ToolStripMenuItem menuLoadFile;
    private System.Windows.Forms.ToolStripMenuItem menuClear;
    private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem menuStartSort;
    private System.Windows.Forms.ToolStripMenuItem menuStopSort;
    private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem menuExit;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.CheckBox chkBogo;
    private System.Windows.Forms.CheckBox chkQuick;
    private System.Windows.Forms.CheckBox chkShaker;
    private System.Windows.Forms.CheckBox chkInsertion;
    private System.Windows.Forms.CheckBox chkBubble;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.RadioButton rbDesc;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
    private System.Windows.Forms.PictureBox pbBubble;
    private System.Windows.Forms.Label lblBubbleTime;
    private System.Windows.Forms.PictureBox pbInsertion;
    private System.Windows.Forms.Label lblInsertionTime;
    private System.Windows.Forms.PictureBox pbShaker;
    private System.Windows.Forms.Label lblShakerTime;
    private System.Windows.Forms.PictureBox pbQuick;
    private System.Windows.Forms.Label lblQuickTime;
    private System.Windows.Forms.PictureBox pbBogo;
    private System.Windows.Forms.Label lblBogoTime;
    private System.Windows.Forms.Label lblFastest;
  }
}