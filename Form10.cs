using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Бд
{
    public partial class Form10 : Form
    {
        DB dB;
        Group group;
        public Form10(DB dB, Subiect subiect,Group group)
        {
            InitializeComponent();
            this.dB = dB;
            timer1.Start();

        }
        void show()
        {
            listView1.Items.Clear();
            foreach(Subiect subiect in dB.subiects)
            {
                ListViewItem row = new ListViewItem(subiect.Name);
                row.Tag = subiect;
                listView1.Items.Add(row);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new Form3(dB).Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
                return;
            show();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            Subiect subiect = (Subiect)listView1.SelectedItems[0].Tag;
            new Form4(dB).Show();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            Subiect subiect = (Subiect)listView1.SelectedItems[0].Tag;
            Form3 form2 = new Form3(dB);
            form2.ShowDialog();
            show();
            dB.Save();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            Subiect subiect = (Subiect)listView1.SelectedItems[0].Tag;
            dB.subiects.Remove(subiect);
            show();
            dB.Save();
        }
    }
}
