namespace 料理を記録する日記
{
    public partial class SizeInputForm : Form
    {
        public int InputWidth { get; private set; }
        public int InputHeight { get; private set; }


        private void OKbutton1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(widthBox.Text, out int w) && int.TryParse(heightBox.Text, out int h))
            {
                if (w > 0 && h > 0)
                {
                    InputWidth = w;
                    InputHeight = h;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("幅と高さは正の整数で入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("幅と高さは数値で入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
