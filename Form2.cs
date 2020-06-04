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
    public partial class Form2 : Form
    {
        DB dB;
        List<Subiect> subiects = new List<Subiect>();
        public Form2(DB dB)
        {
            InitializeComponent();
            timer1.Start();
            this.dB = dB;
            comboBox1.DataSource = dB.subiects;
            comboBox1.DisplayMember = "Name";
            
        }

        void show()
        {
            listView1.Items.Clear();
            foreach (Subiect subiect in subiects)
            {
                ListViewItem row = new ListViewItem(subiect.Name);
                row.Tag = subiect;
                listView1.Items.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subiect subiect = new Subiect();
            subiect = (Subiect)comboBox1.SelectedItem;
            subiects.Add(subiect);
            show();
            dB.Save();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            Teacher teacher = new Teacher();
            teacher.Name = textBox1.Text;
            teacher.FName = textBox2.Text;
            teacher.OName = textBox3.Text;
            teacher.subiect = subiects;
            dB.teachers.Add(teacher);
            dB.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
