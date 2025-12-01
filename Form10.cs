using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnAmigoMas
{
    public partial class Form10 : Form
    {
        private Form actualForm;

        public Form10()
        {
            InitializeComponent();
        }

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
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form7());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
