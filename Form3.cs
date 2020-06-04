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
    public partial class Form3 : Form
    {
        DB dB;
        public Form3(DB dB)
        {
            InitializeComponent();
            this.dB = dB;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subiect subiect = new Subiect { Name = textBox1.Text };
            dB.subiects.Add(subiect);
            dB.Save();
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
