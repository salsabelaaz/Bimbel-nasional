using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bimbel_nasional
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 Form = new Form10();
            Form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 Form = new Form4();
            Form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 Form = new Form12();
            Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 Form = new Form11();
            Form.ShowDialog();
        }

    }
}
