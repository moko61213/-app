namespace 料理を記録する日記
{
    partial class SizeInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            widthBox = new TextBox();
            heightBox = new TextBox();
            OKbutton1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 74);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 0;
            label1.Text = "幅（px）";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(174, 74);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 1;
            label2.Text = "高さ(px)";
            // 
            // widthBox
            // 
            widthBox.Location = new Point(60, 98);
            widthBox.Name = "widthBox";
            widthBox.Size = new Size(76, 23);
            widthBox.TabIndex = 2;
            // 
            // heightBox
            // 
            heightBox.Location = new Point(174, 98);
            heightBox.Name = "heightBox";
            heightBox.Size = new Size(76, 23);
            heightBox.TabIndex = 3;
            // 
            // OKbutton1
            // 
            OKbutton1.Location = new Point(93, 166);
            OKbutton1.Name = "OKbutton1";
            OKbutton1.Size = new Size(124, 29);
            OKbutton1.TabIndex = 4;
            OKbutton1.Text = "入力完了";
            OKbutton1.UseVisualStyleBackColor = true;
            OKbutton1.Click += OKbutton1_Click;
            // 
            // SizeInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 218);
            Controls.Add(OKbutton1);
            Controls.Add(heightBox);
            Controls.Add(widthBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SizeInputForm";
            Text = "SizeInputForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox widthBox;
        private TextBox heightBox;
        private Button OKbutton1;

        public int ImageWidth { get; private set; }
        public int ImageHeight { get; private set; }

        public SizeInputForm()
        {
            InitializeComponent();
            // ラベル・TextBox・OKボタンを配置し、OKボタン押下で ImageWidth/Height を設定して DialogResult = OK
        }

    }
}