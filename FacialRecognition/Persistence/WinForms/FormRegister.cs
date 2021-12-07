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

namespace Persistence.WinForms
{
    public partial class FormRegister : Form
    {

        private FaceRec face = new FaceRec();

        public FormRegister()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox3.TextLength != 11 || textBox4.Text == "" || textBox5.Text == "" || pictureBox1.Image == null)
            {
                MessageBox.Show("No se pudo registrar la información, compruebe que no haya campos vacíos o el Enrollment contenga 11 dígitos..");
            }
            else
            {
                try
                {
                    face.Save_IMAGE(textBox3.Text);

                    DataHelpers dh = new DataHelpers();
                    dh.InsertData(textBox1.Text, int.Parse(textBox2.Text), textBox3.Text, textBox4.Text, textBox5.Text, checkBox1.Checked, false);

                    DialogConfirm dialog = new DialogConfirm("confirm");
                    dialog.ShowDialog();
                    this.Close();
                }
                catch (Exception el)
                {
                    DialogConfirm dialog = new DialogConfirm("error");
                    dialog.ShowDialog();
                    this.Close();
                }

            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            face.openCamera(pictureBox1, pictureBox2);
            face.isTrained = true;
        }
    }
}
