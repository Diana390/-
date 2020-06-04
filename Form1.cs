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
    public partial class Form1 : Form
    {
        DB dB = new DB();
        Subiect subiect = new Subiect();
        Group group = new Group();
      
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        void show()
        {
            listView1.Items.Clear();
            foreach (Teacher teacher in dB.teachers)
            {
                string a = "";
                foreach(var subjects in teacher.subiect)
                {
                    a += subjects.Name + ", ";
                }
                ListViewItem row = new ListViewItem(teacher.Name +" " + teacher.FName+" " + teacher.OName);
                row.SubItems.Add(a);
                row.Tag = teacher;
                listView1.Items.Add(row);
            }
        }

        private void добавитьПреподавателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2(dB).Show();
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
                return;
            show();
        }

        private void добавитьОтделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form9(dB).Show();
        }

        private void добавитьГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form8(dB).Show();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4(dB).Show();
        }

        private void ljToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3(dB).Show();
        }

        private void списокПредметовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form10(dB, subiect,group).Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ew3rfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form12(dB).Show();
        }

        

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
                return;
            Teacher teacher = (Teacher)listView1.SelectedItems[0].Tag;
            Form2 form2 = new Form2(dB);
            form2.ShowDialog();
            show();
            dB.Save();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            Teacher teacher = (Teacher)listView1.SelectedItems[0].Tag;
            dB.teachers.Remove(teacher);
            show();
            dB.Save();
        }
    }
}
