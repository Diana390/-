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
    public partial class Form11 : Form
    {
        DB dB;
        Group group;
        
        public Form11(DB dB,Group group)
        {
            InitializeComponent();
            this.dB = dB;
            this.group = group;
            comboBox1.DataSource = group.student;
            comboBox1.DisplayMember = "Name";
            
            
            comboBox2.DataSource = dB.subiects;
            comboBox2.DisplayMember = "Name";
           
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = (Student)comboBox1.SelectedItem;
            Subiect subiect = (Subiect)comboBox2.SelectedItem;
            assessment assessment = new assessment();
            assessment.Assessment = Convert.ToInt32(textBox1.Text);
            assessment.student = student;
            assessment.subiect = subiect;
            student.Assessment.Add(assessment);
            Close();
            
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
