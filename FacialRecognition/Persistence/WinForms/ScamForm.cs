using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FaceRecognition;
using Layering1.Domain;
using Layering1.Presentation;

namespace Persistence.WinForms
{
    public partial class ScamForm : Form
    {
        private FaceRec face = new FaceRec();

        public ScamForm()
        {
            InitializeComponent();
            lblExit.Visible = true;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            face.openCamera(pictureBox1, pictureBox2);
            face.isTrained = true;
            face.getPersonName(txtEnrollment);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            var lst = ScamFormFormat.infoFormat(txtEnrollment.Text);

            txtName.Text = lst[0];
            txtAge.Text = lst[1];
            txtEnrollment.Text = lst[2];
            txtFirstDose.Text = lst[3];
            txtSecondDose.Text = lst[4];

        }
    }
}
