﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persistence
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username") 
            {
                textBox1.Text = "";
                textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}