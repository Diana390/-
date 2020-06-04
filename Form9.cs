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
    public partial class Form9 : Form
    {
        DB dB;
        public Form9(DB dB)
        {
            InitializeComponent();
            this.dB = dB;
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Otdelenie otdelenie = new Otdelenie { Name = textBox1.Text, group = new List<Group>() };
            dB.otdelenies.Add(otdelenie);
            dB.Save();
            Close();

        }
    }
}
