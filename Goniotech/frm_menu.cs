using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goniotech
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void equipeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_cad_paciente_Click(object sender, EventArgs e)
        {
            frm_paciente frm = new frm_paciente();
            frm.Show();
        }

        private void btn_cad_fisio_Click(object sender, EventArgs e)
        {
            frm_fisioterapeuta frm = new frm_fisioterapeuta();
            frm.Show();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_paciente frm = new frm_paciente();
            frm.Show();
        }

        private void fisioterapeutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_fisioterapeuta frm = new frm_fisioterapeuta();
            frm.Show();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            frm_consulta frm = new frm_consulta();
            frm.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_consulta frm = new frm_consulta();
            frm.Show();
        }
    }
}
