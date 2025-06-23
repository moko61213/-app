namespace 料理を記録する日記
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }




        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            ファイルToolStripMenuItem = new ToolStripMenuItem();
            画像を開くToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            料理日記の保存ToolStripMenuItem = new ToolStripMenuItem();
            変更ToolStripMenuItem = new ToolStripMenuItem();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            編集ToolStripMenuItem = new ToolStripMenuItem();
            戻すToolStripMenuItem = new ToolStripMenuItem();
            すべての作業のリセットToolStripMenuItem = new ToolStripMenuItem();
            画像サイズの変更ToolStripMenuItem = new ToolStripMenuItem();
            画像の回転反転ToolStripMenuItem = new ToolStripMenuItem();
            画像のトリミングToolStripMenuItem = new ToolStripMenuItem();
            画像編集ToolStripMenuItem = new ToolStripMenuItem();
            ハッシュタグ挿入ToolStripMenuItem = new ToolStripMenuItem();
            テキスト挿入ToolStripMenuItem = new ToolStripMenuItem();
            スタンプアイコンToolStripMenuItem = new ToolStripMenuItem();
            額縁ToolStripMenuItem = new ToolStripMenuItem();
            色調補正ToolStripMenuItem = new ToolStripMenuItem();
            明るさToolStripMenuItem = new ToolStripMenuItem();
            コントラスト明暗ToolStripMenuItem = new ToolStripMenuItem();
            彩度ToolStripMenuItem = new ToolStripMenuItem();
            色相ToolStripMenuItem = new ToolStripMenuItem();
            ガンマ補正ToolStripMenuItem = new ToolStripMenuItem();
            ホワイトバランスToolStripMenuItem = new ToolStripMenuItem();
            カラーバランスRGBToolStripMenuItem = new ToolStripMenuItem();
            画質補正ToolStripMenuItem = new ToolStripMenuItem();
            ヘルプToolStripMenuItem = new ToolStripMenuItem();
            git公式ドキュメントToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Location = new Point(233, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ファイルToolStripMenuItem
            // 
            ファイルToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 画像を開くToolStripMenuItem, 保存ToolStripMenuItem, 料理日記の保存ToolStripMenuItem, 変更ToolStripMenuItem, 終了ToolStripMenuItem });
            ファイルToolStripMenuItem.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            ファイルToolStripMenuItem.Size = new Size(63, 24);
            ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 画像を開くToolStripMenuItem
            // 
            画像を開くToolStripMenuItem.Name = "画像を開くToolStripMenuItem";
            画像を開くToolStripMenuItem.Size = new Size(190, 24);
            画像を開くToolStripMenuItem.Text = "画像を開く";
            画像を開くToolStripMenuItem.Click += imageopen;
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(190, 24);
            保存ToolStripMenuItem.Text = "保存";
            保存ToolStripMenuItem.Click += hozon_Click;
            // 
            // 料理日記の保存ToolStripMenuItem
            // 
            料理日記の保存ToolStripMenuItem.Name = "料理日記の保存ToolStripMenuItem";
            料理日記の保存ToolStripMenuItem.Size = new Size(190, 24);
            料理日記の保存ToolStripMenuItem.Text = "料理日記の保存";
            // 
            // 変更ToolStripMenuItem
            // 
            変更ToolStripMenuItem.Name = "変更ToolStripMenuItem";
            変更ToolStripMenuItem.Size = new Size(190, 24);
            変更ToolStripMenuItem.Text = "タイトル画面に戻る";
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.Size = new Size(190, 24);
            終了ToolStripMenuItem.Text = "終了";
            終了ToolStripMenuItem.Click += end_click;
            // 
            // 編集ToolStripMenuItem
            // 
            編集ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 戻すToolStripMenuItem, すべての作業のリセットToolStripMenuItem, 画像サイズの変更ToolStripMenuItem, 画像の回転反転ToolStripMenuItem, 画像のトリミングToolStripMenuItem });
            編集ToolStripMenuItem.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
            編集ToolStripMenuItem.Size = new Size(51, 24);
            編集ToolStripMenuItem.Text = "編集";
            // 
            // 戻すToolStripMenuItem
            // 
            戻すToolStripMenuItem.Name = "戻すToolStripMenuItem";
            戻すToolStripMenuItem.Size = new Size(241, 24);
            戻すToolStripMenuItem.Text = "戻す";
            // 
            // すべての作業のリセットToolStripMenuItem
            // 
            すべての作業のリセットToolStripMenuItem.Name = "すべての作業のリセットToolStripMenuItem";
            すべての作業のリセットToolStripMenuItem.Size = new Size(241, 24);
            すべての作業のリセットToolStripMenuItem.Text = "すべての作業のリセット";
            // 
            // 画像サイズの変更ToolStripMenuItem
            // 
            画像サイズの変更ToolStripMenuItem.Name = "画像サイズの変更ToolStripMenuItem";
            画像サイズの変更ToolStripMenuItem.Size = new Size(241, 24);
            画像サイズの変更ToolStripMenuItem.Text = "画像サイズの変更";
            // 
            // 画像の回転反転ToolStripMenuItem
            // 
            画像の回転反転ToolStripMenuItem.Name = "画像の回転反転ToolStripMenuItem";
            画像の回転反転ToolStripMenuItem.Size = new Size(241, 24);
            画像の回転反転ToolStripMenuItem.Text = "画像の回転反転";
            // 
            // 画像のトリミングToolStripMenuItem
            // 
            画像のトリミングToolStripMenuItem.Name = "画像のトリミングToolStripMenuItem";
            画像のトリミングToolStripMenuItem.Size = new Size(241, 24);
            画像のトリミングToolStripMenuItem.Text = "画像トリミング（切り取り）";
            // 
            // 画像編集ToolStripMenuItem
            // 
            画像編集ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ハッシュタグ挿入ToolStripMenuItem, テキスト挿入ToolStripMenuItem, スタンプアイコンToolStripMenuItem, 額縁ToolStripMenuItem });
            画像編集ToolStripMenuItem.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            画像編集ToolStripMenuItem.Name = "画像編集ToolStripMenuItem";
            画像編集ToolStripMenuItem.Size = new Size(81, 24);
            画像編集ToolStripMenuItem.Text = "素材挿入";
            // 
            // ハッシュタグ挿入ToolStripMenuItem
            // 
            ハッシュタグ挿入ToolStripMenuItem.Name = "ハッシュタグ挿入ToolStripMenuItem";
            ハッシュタグ挿入ToolStripMenuItem.Size = new Size(174, 24);
            ハッシュタグ挿入ToolStripMenuItem.Text = "ハッシュタグロゴ";
            // 
            // テキスト挿入ToolStripMenuItem
            // 
            テキスト挿入ToolStripMenuItem.Name = "テキスト挿入ToolStripMenuItem";
            テキスト挿入ToolStripMenuItem.Size = new Size(174, 24);
            テキスト挿入ToolStripMenuItem.Text = "テキスト";
            // 
            // スタンプアイコンToolStripMenuItem
            // 
            スタンプアイコンToolStripMenuItem.Name = "スタンプアイコンToolStripMenuItem";
            スタンプアイコンToolStripMenuItem.Size = new Size(174, 24);
            スタンプアイコンToolStripMenuItem.Text = "スタンプ・アイコン";
            // 
            // 額縁ToolStripMenuItem
            // 
            額縁ToolStripMenuItem.Name = "額縁ToolStripMenuItem";
            額縁ToolStripMenuItem.Size = new Size(174, 24);
            額縁ToolStripMenuItem.Text = "額縁";
            // 
            // 色調補正ToolStripMenuItem
            // 
            色調補正ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 明るさToolStripMenuItem, コントラスト明暗ToolStripMenuItem, 彩度ToolStripMenuItem, 色相ToolStripMenuItem, ガンマ補正ToolStripMenuItem, ホワイトバランスToolStripMenuItem, カラーバランスRGBToolStripMenuItem, 画質補正ToolStripMenuItem });
            色調補正ToolStripMenuItem.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            色調補正ToolStripMenuItem.Name = "色調補正ToolStripMenuItem";
            色調補正ToolStripMenuItem.Size = new Size(81, 24);
            色調補正ToolStripMenuItem.Text = "色調補正";
            // 
            // 明るさToolStripMenuItem
            // 
            明るさToolStripMenuItem.Name = "明るさToolStripMenuItem";
            明るさToolStripMenuItem.Size = new Size(241, 24);
            明るさToolStripMenuItem.Text = "明るさ";
            // 
            // コントラスト明暗ToolStripMenuItem
            // 
            コントラスト明暗ToolStripMenuItem.Name = "コントラスト明暗ToolStripMenuItem";
            コントラスト明暗ToolStripMenuItem.Size = new Size(241, 24);
            コントラスト明暗ToolStripMenuItem.Text = "コントラスト（明暗）";
            // 
            // 彩度ToolStripMenuItem
            // 
            彩度ToolStripMenuItem.Name = "彩度ToolStripMenuItem";
            彩度ToolStripMenuItem.Size = new Size(241, 24);
            彩度ToolStripMenuItem.Text = "彩度";
            // 
            // 色相ToolStripMenuItem
            // 
            色相ToolStripMenuItem.Name = "色相ToolStripMenuItem";
            色相ToolStripMenuItem.Size = new Size(241, 24);
            色相ToolStripMenuItem.Text = "色相";
            // 
            // ガンマ補正ToolStripMenuItem
            // 
            ガンマ補正ToolStripMenuItem.Name = "ガンマ補正ToolStripMenuItem";
            ガンマ補正ToolStripMenuItem.Size = new Size(241, 24);
            ガンマ補正ToolStripMenuItem.Text = "ガンマ補正";
            // 
            // ホワイトバランスToolStripMenuItem
            // 
            ホワイトバランスToolStripMenuItem.Name = "ホワイトバランスToolStripMenuItem";
            ホワイトバランスToolStripMenuItem.Size = new Size(241, 24);
            ホワイトバランスToolStripMenuItem.Text = "ホワイトバランス（色温度）";
            // 
            // カラーバランスRGBToolStripMenuItem
            // 
            カラーバランスRGBToolStripMenuItem.Name = "カラーバランスRGBToolStripMenuItem";
            カラーバランスRGBToolStripMenuItem.Size = new Size(241, 24);
            カラーバランスRGBToolStripMenuItem.Text = "カラーバランス（RGB）";
            // 
            // 画質補正ToolStripMenuItem
            // 
            画質補正ToolStripMenuItem.Name = "画質補正ToolStripMenuItem";
            画質補正ToolStripMenuItem.Size = new Size(241, 24);
            画質補正ToolStripMenuItem.Text = "画質補正";
            // 
            // ヘルプToolStripMenuItem
            // 
            ヘルプToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { git公式ドキュメントToolStripMenuItem });
            ヘルプToolStripMenuItem.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            ヘルプToolStripMenuItem.Size = new Size(56, 24);
            ヘルプToolStripMenuItem.Text = "ヘルプ";
            // 
            // git公式ドキュメントToolStripMenuItem
            // 
            git公式ドキュメントToolStripMenuItem.Name = "git公式ドキュメントToolStripMenuItem";
            git公式ドキュメントToolStripMenuItem.Size = new Size(191, 24);
            git公式ドキュメントToolStripMenuItem.Text = "Git公式ドキュメント";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルToolStripMenuItem, 編集ToolStripMenuItem, 画像編集ToolStripMenuItem, 色調補正ToolStripMenuItem, ヘルプToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(849, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(849, 508);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "料理の画像編集";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private ToolStripMenuItem ファイルToolStripMenuItem;
        private ToolStripMenuItem 画像を開くToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripMenuItem 料理日記の保存ToolStripMenuItem;
        private ToolStripMenuItem 変更ToolStripMenuItem;
        private ToolStripMenuItem 終了ToolStripMenuItem;
        private ToolStripMenuItem 編集ToolStripMenuItem;
        private ToolStripMenuItem 戻すToolStripMenuItem;
        private ToolStripMenuItem すべての作業のリセットToolStripMenuItem;
        private ToolStripMenuItem 画像サイズの変更ToolStripMenuItem;
        private ToolStripMenuItem 画像の回転反転ToolStripMenuItem;
        private ToolStripMenuItem 画像のトリミングToolStripMenuItem;
        private ToolStripMenuItem 画像編集ToolStripMenuItem;
        private ToolStripMenuItem ハッシュタグ挿入ToolStripMenuItem;
        private ToolStripMenuItem テキスト挿入ToolStripMenuItem;
        private ToolStripMenuItem スタンプアイコンToolStripMenuItem;
        private ToolStripMenuItem 額縁ToolStripMenuItem;
        private ToolStripMenuItem 色調補正ToolStripMenuItem;
        private ToolStripMenuItem 明るさToolStripMenuItem;
        private ToolStripMenuItem コントラスト明暗ToolStripMenuItem;
        private ToolStripMenuItem 彩度ToolStripMenuItem;
        private ToolStripMenuItem 色相ToolStripMenuItem;
        private ToolStripMenuItem ガンマ補正ToolStripMenuItem;
        private ToolStripMenuItem ホワイトバランスToolStripMenuItem;
        private ToolStripMenuItem カラーバランスRGBToolStripMenuItem;
        private ToolStripMenuItem 画質補正ToolStripMenuItem;
        private ToolStripMenuItem ヘルプToolStripMenuItem;
        private ToolStripMenuItem git公式ドキュメントToolStripMenuItem;
        private MenuStrip menuStrip1;

    }
}
