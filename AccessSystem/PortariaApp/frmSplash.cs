using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortariaApp
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            //ligando o timer
            tmrSplash.Enabled = true;
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            tmrSplash.Enabled = false;
            //o que você colocar aqui dentro vai executar
            
            //MessageBox.Show("Executando...");
            
            //Carregando a barra de progresso
            pgbCarregando.Value = 100;

            //abrir outra janela
            frmLogin abrirLogin = new frmLogin();
            abrirLogin.Show();
            this.Hide();


            
        }
    }
}
