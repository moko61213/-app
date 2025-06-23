using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace 料理を記録する日記
{
    public partial class Form2 : Form
    {
        private DateTime currentDate = DateTime.Today;
        private HomeForm homeForm;

        // ラジオボタン２つも管理するため、Tupleを変更
        private Dictionary<DateTime, List<(PictureBox pic, RadioButton yes, RadioButton no)>> photoMap = new();

        public Form2(HomeForm homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
            this.Text = "料理記録カレンダー";
            this.WindowState = FormWindowState.Maximized;
            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitUI();
            DrawCalendar(currentDate);
        }

        private void InitUI()
        {
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
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Dock = DockStyle.Top,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
            };

            for (int i = 0; i < 7; i++)
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 7));

            for (int r = 0; r < 6; r++)
                table.RowStyles.Add(new RowStyle(SizeType.Absolute, 230));

            int row = 0;
            for (int day = 1; day <= daysInMonth; day++)
            {
                int col = (startDayOfWeek + day - 1) % 7;
                if (col == 0 && day != 1) row++;

                DateTime current = new DateTime(date.Year, date.Month, day);
                Panel cell = CreateDayCell(current);
                table.Controls.Add(cell, col, row);

                // 既に登録済みの写真があれば再表示する
                if (photoMap.ContainsKey(current))
                {
                    foreach (var (pic, yes, no) in photoMap[current])
                    {
                        cell.Controls.Add(pic);
                        cell.Controls.Add(yes);
                        cell.Controls.Add(no);
                    }
                    RepositionControls(current, cell);
                }
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
                AutoScroll = true,
                BackColor = Color.WhiteSmoke,
                BorderStyle = BorderStyle.FixedSingle
            };

            var label = new Label()
            {
                Text = day.Day.ToString(),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(5, 5),
                Size = new Size(40, 20)
            };
            panel.Controls.Add(label);

            var addButton = new Button()
            {
                Text = "+",
                Size = new Size(30, 30),
                Location = new Point(panel.Width - 40, 5),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
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
                        photoMap[day] = new List<(PictureBox, RadioButton, RadioButton)>();

                    foreach (string file in dialog.FileNames)
                    {
                        if (photoMap[day].Count >= 6) break;

                        RadioButton yes = new RadioButton
                        {
                            Text = "〇",
                            Location = new Point(10, 65 + photoMap[day].Count * 70),
                            AutoSize = true
                        };

                        RadioButton no = new RadioButton
                        {
                            Text = "×",
                            Location = new Point(40, 65 + photoMap[day].Count * 70),
                            AutoSize = true
                        };

                        PictureBox pic = new PictureBox()
                        {
                            Image = Image.FromFile(file),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Size = new Size(60, 60),
                            Location = new Point(10, 30 + photoMap[day].Count * 70),
                            BorderStyle = BorderStyle.FixedSingle,
                            Cursor = Cursors.Hand,
                            Tag = file
                        };

                        // 右クリック削除確認を追加
                        pic.MouseDown += (s, e) =>
                        {
                            if (e.Button == MouseButtons.Right)
                            {
                                var result = MessageBox.Show("この写真を削除しますか？", "削除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    container.Controls.Remove(pic);
                                    container.Controls.Remove(yes);
                                    container.Controls.Remove(no);
                                    photoMap[day].RemoveAll(x => x.pic == pic);
                                    pic.Dispose();
                                    yes.Dispose();
                                    no.Dispose();

                                    RepositionControls(day, container);
                                }
                            }
                        };

                        container.Controls.Add(pic);
                        container.Controls.Add(yes);
                        container.Controls.Add(no);

                        photoMap[day].Add((pic, yes, no));
                    }
                }
            }
        }

        private void RepositionControls(DateTime day, Panel container)
        {
            if (!photoMap.ContainsKey(day)) return;

            for (int i = 0; i < photoMap[day].Count; i++)
            {
                var (pic, yes, no) = photoMap[day][i];

                pic.Location = new Point(10, 30 + i * 70);
                yes.Location = new Point(10, 65 + i * 70);
                no.Location = new Point(40, 65 + i * 70);
            }
        }

        private void SaveDiary(string filepath)
        {
            var data = new Dictionary<string, List<(string path, string status)>>();

            foreach (var kvp in photoMap)
            {
                var list = new List<(string, string)>();
                foreach (var item in kvp.Value)
                {
                    string status = "";
                    if (item.yes.Checked) status = "〇";
                    else if (item.no.Checked) status = "×";

                    string path = item.pic.Tag as string ?? "";

                    list.Add((path, status));
                }
                data[kvp.Key.ToString("yyyy-MM-dd")] = list;
            }

            string json = JsonSerializer.Serialize(data);
            File.WriteAllText(filepath, json);
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

        private void nextMonthMenuItem_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(1);
            DrawCalendar(currentDate);
        }
    }
}
