namespace 料理を記録する日記
{
    public partial class Form1 : Form
    {
        private PictureBox pictureBox1;
        private Image currentImage;
        public Form1()
        {
            InitializeComponent();
            pictureBox1 = new PictureBox();
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Controls.Add(pictureBox1);
            画像を開くToolStripMenuItem.Click += 画像を開くToolStripMenuItem_Click;
            Controls.SetChildIndex(pictureBox1, 0); // PictureBoxをメニューの下に
        }

        private void 変更ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ハッシュタグ挿入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 画像を開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "画像ファイル|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentImage = Image.FromFile(ofd.FileName);
                    pictureBox1.Image = (Image)currentImage.Clone();
                }
            }
        }
        private void 画像サイズの変更ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentImage == null) return;
            using (var input = new ResizeForm()) // 幅・高さを入力するフォームを別途作成
            {
                if (input.ShowDialog() == DialogResult.OK)
                {
                    int width = input.ImageWidth;
                    int height = input.ImageHeight;
                    Bitmap resized = new Bitmap(currentImage, width, height);
                    pictureBox1.Image = resized;
                    currentImage = resized;
                }
            }
        }
        private void 画像の回転反転ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentImage == null) return;
            currentImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = (Image)currentImage.Clone();
        }
        private void 画像のトリミングToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentImage == null) return;
            Rectangle cropRect = new Rectangle(
                currentImage.Width / 4, currentImage.Height / 4,
                currentImage.Width / 2, currentImage.Height / 2);
            Bitmap src = new Bitmap(currentImage);
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height),
                    cropRect, GraphicsUnit.Pixel);
            }
            pictureBox1.Image = target;
            currentImage = target;
        }
    }
}
