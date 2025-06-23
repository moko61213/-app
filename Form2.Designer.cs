using System.Drawing;
using System.Windows.Forms;

namespace 料理を記録する日記
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 戻るToolStripMenuItem;
        private ToolStripMenuItem prevMonthMenuItem;
        private ToolStripMenuItem nextMonthMenuItem;
        private Label month;
        private Panel calendar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            戻るToolStripMenuItem = new ToolStripMenuItem();
            prevMonthMenuItem = new ToolStripMenuItem();
            nextMonthMenuItem = new ToolStripMenuItem();
            month = new Label();
            calendar = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 戻るToolStripMenuItem, prevMonthMenuItem, nextMonthMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1134, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 戻るToolStripMenuItem
            // 
            戻るToolStripMenuItem.Name = "戻るToolStripMenuItem";
            戻るToolStripMenuItem.Size = new Size(40, 20);
            戻るToolStripMenuItem.Text = "戻る";
            戻るToolStripMenuItem.Click += modoru_click;
            // 
            // prevMonthMenuItem
            // 
            prevMonthMenuItem.Name = "prevMonthMenuItem";
            prevMonthMenuItem.Size = new Size(68, 20);
            prevMonthMenuItem.Text = "◀ 前の月";
            prevMonthMenuItem.Click += prevMonthMenuItem_Click;
            // 
            // nextMonthMenuItem
            // 
            nextMonthMenuItem.Name = "nextMonthMenuItem";
            nextMonthMenuItem.Size = new Size(68, 20);
            nextMonthMenuItem.Text = "次の月 ▶";
            nextMonthMenuItem.Click += nextMonthMenuItem_Click;
            // 
            // month
            // 
            month.AutoSize = true;
            month.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            month.Location = new Point(10, 30);
            month.Name = "month";
            month.Size = new Size(116, 30);
            month.TabIndex = 1;
            month.Text = "2025年 6月";
            // 
            // calendar
            // 
            calendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            calendar.AutoScroll = true;
            calendar.Location = new Point(12, 63);
            calendar.Name = "calendar";
            calendar.Size = new Size(1110, 451);
            calendar.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 526);
            Controls.Add(calendar);
            Controls.Add(month);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "料理日記";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
