using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        #endregion

        private void Btn_1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_1.Text))
            {
                MessageBox.Show("nothing", "X");
                return;
            }
            
           


        }

    }
}
