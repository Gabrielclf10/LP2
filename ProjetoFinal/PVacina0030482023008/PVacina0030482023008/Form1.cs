using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PVacina0030482023008
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;//variavel global

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                // aqui a conexão vai depende da sua máquina da escola ou particular 
                conexao = new SqlConnection("Data Source=DESKTOP-9MUT243;Initial Catalog=LP2;Integrated Security=True"); 
                conexao.Open(); //executa conexao
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros Erros =/" + ex.Message);
            }

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastroVacinaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVacina objvacina = new frmVacina();
            objvacina.MdiParent = this;
            objvacina.WindowState = FormWindowState.Maximized;
            objvacina.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 objvacina = new AboutBox1();
            objvacina.MdiParent = this;
            objvacina.WindowState = FormWindowState.Maximized;
            objvacina.Show();
        }
    }
}
