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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 Form = new Form13();
            Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 Form = new Form16();
            Form.ShowDialog();
        }
    }
}
