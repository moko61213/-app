using System;
using System.Windows.Forms;

namespace 料理を記録する日記
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
        }

        private void Button1_click(object sender, EventArgs e)
        {
            // SizeInputForm を無視して固定サイズで Form1 を起動
            int w = 640;
            int h = 360;

            Form1 form1 = new Form1(); // ← 引数なしのコンストラクタを使用
            form1.Show();

            this.Hide();

            form1.FormClosed += (s, args) => this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);  // HomeForm のインスタンスを渡す
            this.Hide();
            form2.Show();
        }
    }
}
