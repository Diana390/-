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
    public partial class Form4 : Form
    {
        DB dB;
        Group group;
        Student student = new Student();
   
        public Form4(DB dB)
        {
            InitializeComponent();
            this.dB = dB;
            timer1.Start();
            comboBox1.DataSource = dB.otdelenies;
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedIndex = 0;

        }
        void show()
        {
            Group group = (Group)comboBox2.SelectedItem;
            if (group == null)
                return;
            listView1.Items.Clear();
            foreach (Student students in group.student)
            {

                ListViewItem row = new ListViewItem(students.Fname +" "+ students.Name + " " + students.Oname);
                row.SubItems.Add(group.Name);
                row.SubItems.Add(group.otdelenie.Name);
                row.Tag = students;
                listView1.Items.Add(row);

            }
        }

        private void добавитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form7(dB).Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count != 0)
            {
                return;
            }
            show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Otdelenie otdelenie = (Otdelenie)comboBox1.SelectedItem;
            comboBox2.DataSource = otdelenie.group;
            comboBox2.DisplayMember = "Name";
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            show();
        }

   

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

   

        private void добавитьОценкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Group group = (Group)comboBox2.SelectedItem;
            new Form11(dB, group).Show();
        }

        private void редоктироватьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            Student student = (Student)listView1.SelectedItems[0].Tag;
            Form7 form7 = new Form7(dB,student);
            form7.ShowDialog();
            dB.Save();
        }

        private void удалитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Student student = (Student)listView1.SelectedItems[0].Tag;
            student.group.student.Remove(student);
            show();
        }
    }
}

