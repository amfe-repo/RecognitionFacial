using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Layering1.Domain;

namespace Persistence.WinForms
{
    public partial class UpdateForm : Form
    {
        public int idUser = 0;
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" || textAge.Text == "" || textEnrollment.Text == "" || textFirstDose.Text == "" || textSecondDose.Text == "")
            {
                MessageBox.Show("No se pueden insertar los datos,verifique que no hayan campos vacíos.");
            }
            else {
                DataHelpers dh = new DataHelpers();
                dh.UpdateData(this.textName.Text, int.Parse(this.textAge.Text), this.textEnrollment.Text, this.textFirstDose.Text, this.textSecondDose.Text, this.chkVaccinated.Checked, this.idUser);
                DialogConfirm dialog = new DialogConfirm("confirm");
                dialog.ShowDialog();
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
