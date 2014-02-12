using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Train
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            processword a = new processword();
            processword b = new processword();
            a.Sex = "男";
            b.Sex = "女";
            processword c = a + b;
            lbOutput.Text = c.Sex.ToString();

        }
    }
}
