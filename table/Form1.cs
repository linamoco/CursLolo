using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Templates;
using System.IO;

namespace table
{
    public partial class Form1 : BorderLessForm
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            //убираем рамки
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
           
            this.MinimumSize = this.MaximumSize = new Size(787, 510);
            table.Columns[0].Width = 77;
            table.Columns[1].Width = 120;
            table.Columns[2].Width = 111;
            table.Columns[3].Width = 250;
            table.Columns[4].Width = 151;
            table.BorderStyle = BorderStyle.None;
            table.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            table.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            table.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            table.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            

            table.EnableHeadersVisualStyles = false;
            table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            table.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            table.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //заполняю таблицу
            using (StreamReader sw = new StreamReader(@"C:\Users\sasha\Downloads\HW_3module\HW_3module\txtInfo.txt"))
            {
                int column = 5;
                string s = sw.ReadLine();
                while (s != ""&&s != null)
                {
                    table.Rows.Add("");
                    var arr = s.Split(':');
                    int rows = table.Rows.Count - 2;
                    for (int j = 1; j < column; j++)
                    {
                        table[j, rows].Value = arr[j-1];
                    }
                    s = sw.ReadLine();
                }
            }
            //string str = "";
            //int column = 5;
            //int rows = 10;
            //for (int i = 0; i < rows; i++)
            //{
            //    table.Rows.Add("");
            //    for (int j = 0; j < column; j++)
            //    {
            //        if(j == 0)
            //        {

            //            DataGridViewColumn col = new DataGridViewButtonColumn();

            //        }
            //        else
            //            table[j, i].Value = j;
            //    }
            //}
            //for (int i = 0; i < rows; i++)
            //{
            //    table.Rows[i].Cells[0].Style.BackColor = Color.RoyalBlue;
                
            //}
            
            ////table.BackColor
        }

        internal void OpenAndSave(List<string> list)
        {
            //FileStream f = new FileStream(@"C:\Users\sasha\Downloads\HW_3module\HW_3module\txtInfo.txt", FileMode.Create));

            //StreamWriter fs = new StreamWriter(f);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    fs.WriteLine(list[i]);
            //}

            using (StreamWriter sw = new StreamWriter(@"C:\Users\sasha\Downloads\HW_3module\HW_3module\txtInfo.txt", false))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    sw.WriteLine(list[i]);
                }
            }
            MessageBox.Show("Сохранено");
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            SaveBox f = new SaveBox(this);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {


        }
        List <string> listrows = new List<string>();
        internal void saveButtonCl()
        {
            listrows.Clear();
            string str = "";
            int column = 5;
            int rows = table.Rows.Count - 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 1; j < column; j++)
                {
                    if (table[j, i].Value == null)
                    {
                        if(j == column - 1)
                            str += "-";
                        else
                            str += "-:";
                        continue;
                    }
                    string value = table[j, i].Value.ToString();
                    if (value != "" && j != column - 1)
                        str += table[j, i].Value.ToString() + ":";
                    else if (j == 0)
                    {
                        str += "-";
                    }
                    else if (j == column - 1)
                        str += table[j, i].Value.ToString();
                }
                listrows.Add(str);
                str = "";

            }
            OpenAndSave(listrows);
        }
        internal void saveButton_Click_1(object sender, EventArgs e)
        {
            saveButtonCl();
        }

        private void table_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cell in table.SelectedCells)
            {
                try
                {
                    table.Rows.RemoveAt(cell.RowIndex);
                }
                catch(InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
