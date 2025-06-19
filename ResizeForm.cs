using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 料理を記録する日記
{
    public partial class ResizeForm: Form
    {
        private TextBox textBoxWidth;
        private TextBox textBoxHeight;
        private Button buttonOK;
        private Label labelWidth;
        private Label labelHeight;
        public ResizeForm()
        {
            InitializeComponent1();
        }
        public int ImageWidth
        {
            get
            {
                int.TryParse(textBoxWidth.Text, out int w);
                return w;
            }
        }
        public int ImageHeight
        {
            get
            {
                int.TryParse(textBoxHeight.Text, out int h);
                return h;
            }
        }

        private void InitializeComponent1()
        {
            this.textBoxWidth = new TextBox();
            this.textBoxHeight = new TextBox();
            this.buttonOK = new Button();
            this.labelWidth = new Label();
            this.labelHeight = new Label();

            // labelWidth
            this.labelWidth.Text = "幅:";
            this.labelWidth.Location = new Point(10, 10);
            // textBoxWidth
            this.textBoxWidth.Location = new Point(50, 10);
            // labelHeight
            this.labelHeight.Text = "高さ:";
            this.labelHeight.Location = new Point(10, 40);
            // textBoxHeight
            this.textBoxHeight.Location = new Point(50, 40);
            // buttonOK
            this.buttonOK.Text = "OK";
            this.buttonOK.Location = new Point(10, 70);
            this.buttonOK.Click += buttonOK_Click;

            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.buttonOK);

            this.ClientSize = new Size(200, 110);
            this.Text = "画像サイズ変更";
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxWidth.Text, out int w) && w > 0 &&
                int.TryParse(textBoxHeight.Text, out int h) && h > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("正しい数値を入力してください。");
            }
        }
    }
}
