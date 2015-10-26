using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello
{
    public partial class Form1 : Form
    {
        string name = "";
        Color origColor;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmdHello.LostFocus += cmdHello_LostFocus;
            cmdHello.KeyPress += cmdHello_KeyPress;
            origColor = txtName.BackColor;
            btnHello.MouseEnter += btnHello_MouseEnter;
            btnHello.MouseLeave += btnHello_MouseLeave;
        }

        void btnHello_MouseLeave(object sender, EventArgs e)
        {
            btnHello.BackColor = origColor;
        }

        void btnHello_MouseEnter(object sender, EventArgs e)
        {
            btnHello.BackColor = Color.FromArgb(
                rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        void cmdHello_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            int len = cmdHello.Text.Length;

            if (c == 13)
            {
                name = cmdHello.Text;
                cmdHello.Text = "";
                btnHello.PerformClick();
            }
            else if (len == 0 && (c > 96 && c < 123))
            {
                e.KeyChar = (char)(c - 32);
            }
            else if (len > 0 && (c > 64 && c < 92))
            {
                e.KeyChar = (char)(c + 32);
            }
        }

        void cmdHello_LostFocus(object sender, EventArgs e)
        {
            name = cmdHello.Text;
            cmdHello.Text = "";
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            if (name.Length > 0)
            {
                lblHello.Text = "Hello " + name;
            }
            else
            {
                lblHello.Text = "Please enter your name";
            }
            cmdHello.Focus();
            
        }



    }
}
