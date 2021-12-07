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
using Layering1.Domain;

namespace Persistence.WinForms
{
    public partial class Administration : Form
    {
        private DataHelpers dh = new DataHelpers();
        public Administration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Administration_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void refresh_data() 
        {
            dataGridView1.Rows.Clear();

            

            foreach (var oObj in dh.ShowData())
            {
                dataGridView1.Rows.Add(new object[]
                {
                    oObj.idUser,
                    oObj.NameUser,
                    oObj.Age,
                    oObj.Enrollment,
                    oObj.FirstDose,
                    oObj.SecondDose,
                    oObj.Vaccinated,
                    oObj.RoleUser,
                    "Edit",
                    "Delete"
                });
            }
        }

        private void Administration_Load(object sender, EventArgs e)
        {
            refresh_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegister frm = new FormRegister();
            frm.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 8) 
            {
                UpdateForm frm = new UpdateForm();
                frm.textName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.textAge.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.textEnrollment.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm.textFirstDose.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm.textSecondDose.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm.chkVaccinated.Checked = (bool)dataGridView1.Rows[e.RowIndex].Cells[6].Value;
                frm.ShowDialog();
            }

            if (e.ColumnIndex == 9)
            {
                DialogConfirm dialog = new DialogConfirm("delete");
                dialog.ShowDialog();
            }
        }
    }
}
