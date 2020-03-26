using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drow
{
    public partial class Open1 : Form
    {
        private int result;
        public Open1()
        {
            InitializeComponent();
        }
        public int Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            result = 1;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = 0;
            this.Close();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            result = 0;
            this.Close();
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            result = 1;
            this.Close();
        }
    }
}
