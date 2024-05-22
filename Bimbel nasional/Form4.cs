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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 Form = new Form5();
            Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 Form = new Form6();
            Form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 Form = new Form7();
            Form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 Form = new Form8();
            Form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 Form = new Form9();
            Form.ShowDialog();
        }
    }
}
