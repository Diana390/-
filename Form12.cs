using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Бд
{
    public partial class Form12 : Form
    {
        DB dB;
        public Form12(DB dB)
        {
            InitializeComponent();
            this.dB = dB;
            timer1.Start();
            comboBox1.DataSource = dB.otdelenies;
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedIndex = 0;
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void show()
        {
            Student student = (Student)comboBox3.SelectedItem;
            listView1.Items.Clear();
            foreach(assessment assessment in student.Assessment )
            {
                ListViewItem row = new ListViewItem(assessment.subiect.Name);
                row.SubItems.Add(assessment.Assessment.ToString());
                row.Tag = assessment;
                listView1.Items.Add(row);

            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group group = (Group)comboBox2.SelectedItem;
            comboBox3.DataSource = group.student;
            comboBox3.DisplayMember = "FName";
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Otdelenie otdelenie = (Otdelenie)comboBox1.SelectedItem;
            comboBox2.DataSource = otdelenie.group;
            comboBox2.DisplayMember = "Name";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            show();
        }
    }
}
