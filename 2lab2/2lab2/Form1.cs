using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2lab2 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      this.Hide();
      Form2 task1Form = new Form2();
      task1Form.ShowDialog();
      this.Show();
    }

    private void button1_Click_1(object sender, EventArgs e) {
      this.Hide();
      Form2 task1Form = new Form2();
      task1Form.ShowDialog();
      this.Show();
    }
  }
  }