namespace 料理を記録する日記
{
    partial class HomeForm
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
            button1 = new Button();
            button2 = new Button();
            料理を記録する日記 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(452, 163);
            button1.Name = "button1";
            button1.Size = new Size(168, 134);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_click;
            // 
            // button2
            // 
            button2.Location = new Point(188, 163);
            button2.Name = "button2";
            button2.Size = new Size(168, 134);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // 料理を記録する日記
            // 
            料理を記録する日記.AutoSize = true;
            料理を記録する日記.Font = new Font("Yu Gothic UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            料理を記録する日記.Location = new Point(334, 74);
            料理を記録する日記.Name = "料理を記録する日記";
            料理を記録する日記.Size = new Size(120, 50);
            料理を記録する日記.TabIndex = 2;
            料理を記録する日記.Text = "label1";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(料理を記録する日記);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "HomeForm";
            Text = "料理を記録する日記";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label 料理を記録する日記;
    }
}