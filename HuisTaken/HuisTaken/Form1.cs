using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuisTaken
{
    public partial class Form1 : Form
    {

        HuisTaken huisTaken;
        List<string> people;
        List<string> tasks;
        DateTime Date;

        public Form1()
        {
            InitializeComponent();
            people = new List<string>();
            tasks = new List<string>();
            Date = new DateTime(2020, 6, 2);

            huisTaken = new HuisTaken(people.ToArray(), tasks.ToArray(), Date);

        }

        private void FillInfo()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            huisTaken = new HuisTaken(people.ToArray(), tasks.ToArray(), Date);

            string[,] Calender = huisTaken.GetCalender();


            int height = Calender.GetLength(0);
            int width = Calender.GetLength(1);

            this.dataGridView1.ColumnCount = width;

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView1);

                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = Calender[r, c];
                }

                this.dataGridView1.Rows.Add(row);

            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPerson.Text))
            {
                people.Add(tbPerson.Text);
                tbPerson.Text = "";
                FillLists();
            }
            else
            {
                MessageBox.Show("Please enter a name");
            }

            
           
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbTask.Text))
            {
                tasks.Add(tbTask.Text);
                tbTask.Text = "";
                FillLists();
            }
            else
            {
                MessageBox.Show("Please enter a Task");
            }

            
            
        }

        private void FillLists()
        {
            lbPeople.Items.Clear();
            lbTasks.Items.Clear();

            foreach (string person in people)
            {
                lbPeople.Items.Add(person);
            }
            foreach (string task in tasks)
            {
                lbTasks.Items.Add(task);
            }

            FillInfo();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            FillInfo();
        }

        

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            Date = dtpDate.Value;
        }
    }
}
