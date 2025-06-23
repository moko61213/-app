using System;
using System.Windows.Forms;
using System.Drawing;

namespace 料理を記録する日記
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private Point mouseDownPosition;

        public Form1()
        {
            InitializeComponent();

            // デバッグ用背景色
            this.BackColor = Color.Gray;

            // フォームサイズを先に設定
            this.ClientSize = new Size(680, 420);

            // PictureBoxのサイズと初期位置（後で中央に配置するので位置は一旦0,0）
            pictureBox1.Size = new Size(640, 360); // 16:9
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BackColor = Color.Red;
            pictureBox1.BringToFront();

            // 画像の読み込み
            pictureBox1.Image = Properties.Resources.Image1;

            // ドラッグ移動イベント登録
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;

            // フォームのResizeイベント登録（サイズ変更時に中央配置）
            this.Resize += Form1_Resize;

            // フォーム表示時にも中央配置
            CenterPictureBox();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterPictureBox();
        }

        private void CenterPictureBox()
        {
            int centerX = (this.ClientSize.Width - pictureBox1.Width) / 2;
            int centerY = (this.ClientSize.Height - pictureBox1.Height) / 2;

            // マウスドラッグ中は位置を変えたくないなら下記コメントアウトを外す
            // if (isDragging) return;

            pictureBox1.Location = new Point(centerX, centerY);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseDownPosition = e.Location;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                var newX = pictureBox1.Left + (e.X - mouseDownPosition.X);
                var newY = pictureBox1.Top + (e.Y - mouseDownPosition.Y);

                // フォームのクライアント領域内に制限
                if (newX < 0) newX = 0;
                if (newY < 0) newY = 0;
                if (newX + pictureBox1.Width > this.ClientSize.Width) newX = this.ClientSize.Width - pictureBox1.Width;
                if (newY + pictureBox1.Height > this.ClientSize.Height) newY = this.ClientSize.Height - pictureBox1.Height;

                pictureBox1.Left = newX;
                pictureBox1.Top = newY;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void imageopen(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "画像ファイル|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (var tempImg = Image.FromFile(ofd.FileName))
                    {
                        pictureBox1.Image?.Dispose();
                        pictureBox1.Image = new Bitmap(tempImg);
                    }
                }
            }
        }

        private void hozon_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("保存する画像がありません。");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG画像|*.png|JPEG画像|*.jpg|BMP画像|*.bmp";
                sfd.Title = "画像を保存";
                sfd.FileName = "edited_image.png";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var ext = System.IO.Path.GetExtension(sfd.FileName).ToLower();
                    var format = System.Drawing.Imaging.ImageFormat.Png;

                    switch (ext)
                    {
                        case ".jpg":
                        case ".jpeg":
                            format = System.Drawing.Imaging.ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = System.Drawing.Imaging.ImageFormat.Bmp;
                            break;
                    }

                    pictureBox1.Image.Save(sfd.FileName, format);
                    MessageBox.Show("画像を保存しました。");
                }
            }
        }

        private void end_click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
