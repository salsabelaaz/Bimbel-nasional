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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 Form = new Form14();
            Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form13 Form = new Form13();
            Form.ShowDialog();
        }
    }
}
