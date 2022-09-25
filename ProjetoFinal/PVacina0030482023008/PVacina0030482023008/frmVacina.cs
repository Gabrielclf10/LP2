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
    public partial class frmVacina : Form
    {
        private BindingSource bsVacina = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsVacina = new DataSet(); //pra receber o listar()
        private DataSet dsCidade = new DataSet();
        private DataSet dsEnfermeiro = new DataSet();

        public frmVacina()
        {
            InitializeComponent();
        }

        private void frmVacina_Load(object sender, EventArgs e)
        {
            try
            {
                Vacina Vac = new Vacina(); // criar objeto
                dsVacina.Tables.Add(Vac.Listar());
                bsVacina.DataSource = dsVacina.Tables["Vacina"]; //esse conecta o dataset aos componentes
                bnVacina.BindingSource = bsVacina; 
                dgvVacina.DataSource = bsVacina;

                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());
                cbxCidadeVacina.DataSource = dsCidade.Tables["Cidade"];
                cbxCidadeVacina.DisplayMember = "nome_cidade";
                cbxCidadeVacina.ValueMember = "id_cidade";

                Enfermeiro Enf = new Enfermeiro();
                dsEnfermeiro.Tables.Add(Enf.Listar());
                cbxEnfermeiroVacina.DataSource = dsEnfermeiro.Tables["Enfermeiro"];
                cbxEnfermeiroVacina.DisplayMember = "nome_enfermeiro";
                cbxEnfermeiroVacina.ValueMember = "id_enfermeiro";

                txtIdVacina.DataBindings.Add("Text", bsVacina, "ID_VACINA");
                txtNomePessoaVacina.DataBindings.Add("Text", bsVacina, "NOME_VACINA");
                txtDataNascVacina.DataBindings.Add("Text", bsVacina, "DATANASC_VACINA");
                txtEnderecoVacina.DataBindings.Add("Text", bsVacina, "END_VACINA");
                cbxCidadeVacina.DataBindings.Add("SelectedValue", bsVacina, "CIDADE_ID_CIDADE");
                mskbxCprfVacina.DataBindings.Add("Text", bsVacina, "CPF_VACINA");
                mskbxRgVacina.DataBindings.Add("Text", bsVacina, "RG_VACINA");
                txtDataVacina.DataBindings.Add("Text", bsVacina, "DATA_VACINA");
                cmbxTipoVacina.DataBindings.Add("SelectedItem", bsVacina, "TIPO_VACINA");
                cmbxComorbidadeVacina.DataBindings.Add("SelectedItem", bsVacina, "COMORBIDADE_VACINA");
                cmbxGrupoPriori.DataBindings.Add("SelectedItem", bsVacina, "GRUPOPRIORI_VACINA");
                cbxEnfermeiroVacina.DataBindings.Add("SelectedValue", bsVacina, "ENFERMEIRO_ID_ENFERMEIRO");

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }

            bsVacina.AddNew();

            txtNomePessoaVacina.Enabled = true;
            txtDataNascVacina.Enabled = true;
            txtEnderecoVacina.Enabled = true;
            cbxCidadeVacina.Enabled = true;
            cbxCidadeVacina.SelectedIndex = 0;
            mskbxCprfVacina.Enabled = true;
            mskbxRgVacina.Enabled = true;
            txtDataVacina.Enabled = true;
            cmbxTipoVacina.Enabled = true;
            cmbxComorbidadeVacina.Enabled = true;
            cmbxGrupoPriori.Enabled = true;
            cbxEnfermeiroVacina.Enabled = true;
            cbxEnfermeiroVacina.SelectedIndex = 0;
            cmbxTipoVacina.SelectedIndex = 0;
            cmbxComorbidadeVacina.SelectedIndex = 0;
            cmbxGrupoPriori.SelectedIndex = 0;

           
            btnIncluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = true;
            

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DateTime Data;

            //validar dados
            if(txtNomePessoaVacina.Text=="")
                MessageBox.Show("Nome inválido!");
            else
                if (!DateTime.TryParse(txtDataNascVacina.Value.ToString(), out Data))
                MessageBox.Show("Data inválida");
            else
                if(mskbxCprfVacina.Text == "")
                MessageBox.Show("CPF inválido");
            else
                if(mskbxRgVacina.Text == "")
                MessageBox.Show("RG inválido");
            else
                if(!DateTime.TryParse(txtDataVacina.Value.ToString(), out Data))
                MessageBox.Show("Data inválida");
            else
            {
                Vacina RegVac = new Vacina();

                RegVac.NomeVacina = txtNomePessoaVacina.Text;
                RegVac.EndVacina = txtEnderecoVacina.Text;
                RegVac.DataNascVacina = txtDataNascVacina.Value;
                RegVac.DataVacina = txtDataVacina.Value;
                RegVac.CidadeIdVacina = Convert.ToInt32(cbxCidadeVacina.SelectedValue);
                RegVac.CpfVacina = mskbxCprfVacina.Text;
                RegVac.RgVacina = mskbxRgVacina.Text;
                RegVac.TipoVacina = Convert.ToChar(cmbxTipoVacina.SelectedItem.ToString());
                RegVac.GrupoPrioriVacina = Convert.ToChar(cmbxGrupoPriori.SelectedItem.ToString());
                RegVac.ComorbidadeVacina = Convert.ToChar(cmbxComorbidadeVacina.SelectedItem.ToString());
                RegVac.EnfermeiroIdEnfermeiro = Convert.ToInt32(cbxEnfermeiroVacina.SelectedValue);


                if (bInclusao)
                {
                    if (RegVac.Salvar() > 0)
                    {
                        MessageBox.Show("Vacina adicionada com sucesso!");



                        txtNomePessoaVacina.Enabled = false;
                        txtDataNascVacina.Enabled = false;
                        txtEnderecoVacina.Enabled = false;
                        cbxCidadeVacina.Enabled = false;
                        mskbxCprfVacina.Enabled = false;
                        mskbxRgVacina.Enabled = false;
                        txtDataVacina.Enabled = false;
                        cmbxTipoVacina.Enabled = false;
                        cmbxComorbidadeVacina.Enabled = false;
                        cmbxGrupoPriori.Enabled = false;
                        cbxEnfermeiroVacina.Enabled = false;



                        btnIncluir.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;



                        // recarrega o grid
                        dsVacina.Tables.Clear();
                        dsVacina.Tables.Add(RegVac.Listar());
                        bsVacina.DataSource = dsVacina.Tables["Vacina"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar vacina!");
                    }
                }
                else
                {
                    RegVac.IdVacina = Convert.ToInt32(txtIdVacina.Text);

                    if (RegVac.Alterar() > 0)
                    {
                        MessageBox.Show("Vacina alterada com sucesso!");

                        txtNomePessoaVacina.Enabled = false;
                        txtDataNascVacina.Enabled = false;
                        txtEnderecoVacina.Enabled = false;
                        cbxCidadeVacina.Enabled = false;
                        mskbxCprfVacina.Enabled = false;
                        mskbxRgVacina.Enabled = false;
                        txtDataVacina.Enabled = false;
                        cmbxTipoVacina.Enabled = false;
                        cmbxComorbidadeVacina.Enabled = false;
                        cmbxGrupoPriori.Enabled = false;
                        cbxEnfermeiroVacina.Enabled = false;

                        btnIncluir.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;


                        // recarrega o grid
                        dsVacina.Tables.Clear();
                        dsVacina.Tables.Add(RegVac.Listar());
                        bsVacina.DataSource = dsVacina.Tables["Vacina"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar vacina!");
                    }

                 }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }

            txtNomePessoaVacina.Enabled = true;
            txtDataNascVacina.Enabled = true;
            txtEnderecoVacina.Enabled = true;
            cbxCidadeVacina.Enabled = true;
            mskbxCprfVacina.Enabled = true;
            mskbxRgVacina.Enabled = true;
            txtDataVacina.Enabled = true;
            cmbxTipoVacina.Enabled = true;
            cmbxComorbidadeVacina.Enabled = true;
            cmbxGrupoPriori.Enabled = true;
            cbxEnfermeiroVacina.Enabled = true;
            cmbxTipoVacina.SelectedIndex = 0;
            cmbxComorbidadeVacina.SelectedIndex = 0;
            cmbxGrupoPriori.SelectedIndex = 0;

            btnIncluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }
            if (MessageBox.Show("Confirma exclusão?", "Sim ou Não", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Vacina RegVac = new Vacina();
                RegVac.IdVacina = Convert.ToInt32(txtIdVacina.Text);

                if (RegVac.Excluir() > 0)
                {
                    MessageBox.Show("Vacina excluída com sucesso!");

                    // recarrega o grid
                    dsVacina.Tables.Clear();
                    dsVacina.Tables.Add(RegVac.Listar());
                    bsVacina.DataSource = dsVacina.Tables["Vacina"];
                }
                else
                    MessageBox.Show("Erro ao excluir vacina!");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bsVacina.CancelEdit();

            txtNomePessoaVacina.Enabled = false;
            txtDataNascVacina.Enabled = false;
            txtEnderecoVacina.Enabled = false;
            cbxCidadeVacina.Enabled = false;
            mskbxCprfVacina.Enabled = false;
            mskbxRgVacina.Enabled = false;
            txtDataVacina.Enabled = false;
            cmbxTipoVacina.Enabled = false;
            cmbxComorbidadeVacina.Enabled = false;
            cmbxGrupoPriori.Enabled = false;
            cbxEnfermeiroVacina.Enabled = false;

            btnIncluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;

            bInclusao = false;

        }

        private void cmbxComorbidadeVacina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void cbxCidadeVacina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
