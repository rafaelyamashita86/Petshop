using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petshop
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void funcionarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormFuncionario func = new FormFuncionario();
            func.Show();
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormCliente cli = new FormCliente();
            cli.Show();
        }

        private void serviçoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormServico serv = new FormServico();
            serv.Show();
        }

        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAnimais anim = new FormAnimais();
            anim.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgenda agenda = new FormAgenda();
            agenda.Show();

        }
    }
}
