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

namespace pfftest1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Menu_Load(object sender, EventArgs e)
        {
            customaizeDesign();
        }
        private void customaizeDesign()
        {
            panelAfectaionSubmenu.Visible = false;
            panelMajSubmenu.Visible = false;
        }
        private void hideSubemenu()
        {
            if (panelAfectaionSubmenu.Visible == true)
            {

                panelAfectaionSubmenu.Visible = false;
            }
            if (panelMajSubmenu.Visible == true)
            {
                panelMajSubmenu.Visible = false;
            }

        }
        private void showSubemenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubemenu();
                submenu.Visible = true;

            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void btnMaj_Click(object sender, EventArgs e)
        {
            showSubemenu(panelMajSubmenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showSubemenu(panelAfectaionSubmenu);
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildform.Controls.Add(childForm);
            panelChildform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelChildform_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelSideMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MAJ_Secteur f3 = new MAJ_Secteur();
            f3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MAJ_FILIERE f3 = new MAJ_FILIERE();
            f3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MAJ_MODULE f3 = new MAJ_MODULE();
            f3.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MAJ_Groupe f3 = new MAJ_Groupe();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MAJ_Stagiaire f3 = new MAJ_Stagiaire();
            f3.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MAJ_Formateur f3 = new MAJ_Formateur();
            f3.Show();
        }
    }
}
