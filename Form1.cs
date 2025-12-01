// Libreria del Paquete Nuget para los iconos en los botones
using FontAwesome.Sharp;
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

namespace UnAmigoMas
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Form actualForm;

        public Form1()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Reinicio al dar Click en el Logo
        private void Reset()
        {
            currentPage.IconChar = IconChar.Home;
            currentPage.IconColor = Color.White;
            lblTituloHj.Text = "Inicio";
        }

        // Metodo para que al dar Click en otro boton te mande directo a otro Form
        private void AbrirForm(Form FormHijo)
        {
            // Abrir solamente el Form
            if (actualForm != null)
            {
                actualForm.Close();
            }
            actualForm = FormHijo;
            // Termina ejecucion
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            panel5.Controls.Add(FormHijo);
            panel5.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
            lblTituloHj.Text = FormHijo.Text;
        }

        // Activar los colores y movimiento del boton seleccionado en ese momento
        private void ActivarBoton(object senderBtn, Color color)
        {
            DesactivarBoton();
            if (senderBtn != null)
            {
                // Boton
                currentBtn = (IconButton)senderBtn;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                currentPage.IconChar = currentBtn.IconChar;
                currentPage.IconColor = color;
            }
        }

        // Desactiva y pone por default los colores y posicionamiento del boton deseleccionado
        private void DesactivarBoton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.FromArgb(64,64,64);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.DarkTurquoise;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        // Agarre del panel para poder mover la ventana
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Boton de Maximizar Ventana
        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        // Boton de Cerrar Ventana
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Boton de Minimizar Ventana
        private void btnMinV_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        // Abrir Ventana de "Adoptar"
        private void btnAdoptar_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Color.DarkTurquoise);
            AbrirForm(new Form2());
        }

        // Abrir Ventana de "Cuenta"
        private void btnCuenta_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Color.DarkTurquoise);
            AbrirForm(new Form3());
        }

        // Abrir Ventana de "Ajustes"
        private void btnAjustes_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Color.DarkTurquoise);
            AbrirForm(new Form4());
        }

        // Abrir Ventana de "Salir"
        private void btnSalirCu_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Color.DarkTurquoise);
            AbrirForm(new Form5());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DesactivarBoton();
            AbrirForm(new Form8());
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Color.DarkTurquoise);
            AbrirForm(new Form10());
        }
    }
}
