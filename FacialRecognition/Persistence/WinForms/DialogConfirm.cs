using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Layering1.Presentation;

namespace Persistence.WinForms
{
    public partial class DialogConfirm : Form
    {
        public DialogConfirm(string state)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(ConfirmDialogFormat.imgDialog(state));
            label1.Text = ConfirmDialogFormat.textDialog(state);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DialogConfirm_Load(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
