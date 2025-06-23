using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace 料理を記録する日記
{
    public partial class Form2 : Form
    {
        private DateTime currentDate = DateTime.Today;
        private HomeForm homeForm;
        private Dictionary<DateTime, List<(PictureBox pic, ComboBox status)>> photoMap = new();

        public Form2(HomeForm homeForm)
        {
            InitializeComponent();

            this.homeForm = homeForm;
            this.Text = "料理記録カレンダー";

            // フォーム起動時に最大化
            this.WindowState = FormWindowState.Maximized;

            // Loadイベントに初期化と描画処理を登録
            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitUI();
            DrawCalendar(currentDate);
        }

        private void InitUI()
        {
            // month はデザイナで追加済みラベルなのでここでの生成は不要

            // calendar はデザイナで追加済みパネル
            // サイズ調整はここで行う
            int topOffset = month.Bottom + 10;
            calendar.Location = new Point(10, topOffset);
            calendar.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - topOffset - 10);
            calendar.AutoScroll = true;
            calendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void DrawCalendar(DateTime date)
        {
            calendar.Controls.Clear();
            month.Text = $"{date.Year}年 {date.Month}月";

            DateTime firstDay = new DateTime(date.Year, date.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            int startDayOfWeek = (int)firstDay.DayOfWeek;

            var table = new TableLayoutPanel()
            {
                RowCount = 6,
                ColumnCount = 7,
                Dock = DockStyle.Fill,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
            };

            for (int i = 0; i < 7; i++)
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 7));

            for (int r = 0; r < 6; r++)
                table.RowStyles.Add(new RowStyle(SizeType.Absolute, 230));  // 行の高さ固定

            int row = 0;
            for (int day = 1; day <= daysInMonth; day++)
            {
                int col = (startDayOfWeek + day - 1) % 7;
                if (col == 0 && day != 1) row++;

                DateTime current = new DateTime(date.Year, date.Month, day);
                Panel cell = CreateDayCell(current);
                table.Controls.Add(cell, col, row);
            }

            calendar.Controls.Add(table);
        }

        private Panel CreateDayCell(DateTime day)
        {
            var panel = new Panel()
            {
                Width = 140,
                Height = 220,
                Margin = new Padding(2),
                AutoScroll = false,
            };

            var label = new Label()
            {
                Text = day.Day.ToString(),
                Dock = DockStyle.Top,
                Height = 20,
            };
            panel.Controls.Add(label);

            var addButton = new Button()
            {
                Text = "+",
                Size = new Size(30, 30),
                Location = new Point(100, 0),
            };
            addButton.Click += (s, e) => AddPhoto(day, panel);
            panel.Controls.Add(addButton);

            return panel;
        }

        private void AddPhoto(DateTime day, Panel container)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "画像ファイル|*.jpg;*.png;*.bmp";
                dialog.Multiselect = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (!photoMap.ContainsKey(day))
                        photoMap[day] = new List<(PictureBox, ComboBox)>();

                    foreach (string file in dialog.FileNames)
                    {
                        if (photoMap[day].Count >= 6) break;

                        PictureBox pic = new PictureBox()
                        {
                            Image = Image.FromFile(file),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Size = new Size(60, 60),
                            Margin = new Padding(2),
                        };

                        ComboBox statusBox = new ComboBox()
                        {
                            Width = 60,
                            DropDownStyle = ComboBoxStyle.DropDownList,
                        };
                        statusBox.Items.AddRange(new string[] { "〇 完食", "× 残した" });
                        statusBox.SelectedIndex = 0;

                        container.Controls.Add(pic);
                        container.Controls.Add(statusBox);

                        photoMap[day].Add((pic, statusBox));
                    }
                }
            }
        }

        private void modoru_click(object sender, EventArgs e)
        {
            this.Hide();
            homeForm.Show();
        }
        private void prevMonthMenuItem_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(-1);
            DrawCalendar(currentDate);
        }

        // 「次の月」クリック時
        private void nextMonthMenuItem_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(1);
            DrawCalendar(currentDate);
        }

    }
}
