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
    public partial class Form8 : Form
    {
        DB dB;
     

        public Form8(DB dB)
        {
            InitializeComponent();
            this.dB = dB;
        
            comboBox1.DataSource = dB.otdelenies;
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedIndex = 0;
        }

   
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;
            Group group = new Group();
            group.Name = textBox1.Text;
            group.student = new List<Student>();
            group.otdelenie = (Otdelenie)comboBox1.SelectedItem;
            group.otdelenie.group.Add(group);
            dB.Save();
            Close();

        }
    }
}
