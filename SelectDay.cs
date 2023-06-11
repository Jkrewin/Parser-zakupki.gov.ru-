using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Parser_zakupki.gov.ru_
{
    public partial class SelectDay : Form
    {
        private readonly List<int> DaySelect;

        public SelectDay(ref List<int> daySelect)
        {
            InitializeComponent();
            DaySelect = daySelect;
        }

        private void SelectDay_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < DateTime.Now.Day; i++)
            {
                CListBox1.Items.Add(i);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DaySelect.Clear();
            foreach (var   item in CListBox1.CheckedItems )
            {
                DaySelect.Add((int)item);
            }
            this.Close();
        }
    }
}
