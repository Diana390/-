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
    public partial class Form7 : Form
    {
        DB dB;
        Student student;
        public Form7(DB dB)
        {
            InitializeComponent();
            this.dB = dB;
            comboBox1.DataSource = dB.otdelenies ;
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedIndex = 0;
        }
        public Form7(DB dB, Student student)
        {
            InitializeComponent();
            this.dB = dB;
            this.student = student;
            comboBox1.DataSource = dB.otdelenies ;
            comboBox1.DisplayMember = "Name";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = textBox1.Text;
            student.Fname = textBox2.Text;
            student.Oname = textBox4.Text;
            student.Assessment = new List<assessment>();
            Group group = (Group)comboBox2.SelectedItem;
            student.group = group;
            group.student.Add(student);
            dB.Save();
            Close();
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Otdelenie otdelenie = (Otdelenie)comboBox1.SelectedItem;
            comboBox2.DataSource = otdelenie.group;
            comboBox2.DisplayMember = "Name";
            comboBox2.SelectedIndex = 0;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
