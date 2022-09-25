
namespace PVacina0030482023008
{
    partial class frmVacina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVacina));
            this.bnVacina = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnIncluir = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbVacina = new System.Windows.Forms.TabPage();
            this.dgvVacina = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbxEnfermeiroVacina = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxCidadeVacina = new System.Windows.Forms.ComboBox();
            this.cmbxGrupoPriori = new System.Windows.Forms.ComboBox();
            this.cmbxComorbidadeVacina = new System.Windows.Forms.ComboBox();
            this.cmbxTipoVacina = new System.Windows.Forms.ComboBox();
            this.mskbxRgVacina = new System.Windows.Forms.MaskedTextBox();
            this.mskbxCprfVacina = new System.Windows.Forms.MaskedTextBox();
            this.txtEnderecoVacina = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDataVacina = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataNascVacina = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomePessoaVacina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdVacina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bnVacina)).BeginInit();
            this.bnVacina.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbVacina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacina)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bnVacina
            // 
            this.bnVacina.AddNewItem = null;
            this.bnVacina.CountItem = this.bindingNavigatorCountItem;
            this.bnVacina.DeleteItem = null;
            this.bnVacina.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnIncluir,
            this.btnSalvar,
            this.btnAlterar,
            this.btnExcluir,
            this.btnCancelar,
            this.btnSair});
            this.bnVacina.Location = new System.Drawing.Point(0, 0);
            this.bnVacina.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnVacina.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnVacina.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnVacina.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnVacina.Name = "bnVacina";
            this.bnVacina.PositionItem = this.bindingNavigatorPositionItem;
            this.bnVacina.Size = new System.Drawing.Size(1283, 25);
            this.bnVacina.TabIndex = 0;
            this.bnVacina.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnIncluir
            // 
            this.btnIncluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(23, 22);
            this.btnIncluir.Text = "Novo Registro";
            this.btnIncluir.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(23, 22);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(23, 22);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbVacina);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1257, 515);
            this.tabControl1.TabIndex = 1;
            // 
            // tbVacina
            // 
            this.tbVacina.Controls.Add(this.dgvVacina);
            this.tbVacina.Location = new System.Drawing.Point(4, 22);
            this.tbVacina.Name = "tbVacina";
            this.tbVacina.Padding = new System.Windows.Forms.Padding(3);
            this.tbVacina.Size = new System.Drawing.Size(1249, 489);
            this.tbVacina.TabIndex = 0;
            this.tbVacina.Text = "Dados";
            this.tbVacina.UseVisualStyleBackColor = true;
            // 
            // dgvVacina
            // 
            this.dgvVacina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacina.Location = new System.Drawing.Point(6, 6);
            this.dgvVacina.Name = "dgvVacina";
            this.dgvVacina.Size = new System.Drawing.Size(1311, 363);
            this.dgvVacina.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Azure;
            this.tabPage2.Controls.Add(this.cbxEnfermeiroVacina);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.cbxCidadeVacina);
            this.tabPage2.Controls.Add(this.cmbxGrupoPriori);
            this.tabPage2.Controls.Add(this.cmbxComorbidadeVacina);
            this.tabPage2.Controls.Add(this.cmbxTipoVacina);
            this.tabPage2.Controls.Add(this.mskbxRgVacina);
            this.tabPage2.Controls.Add(this.mskbxCprfVacina);
            this.tabPage2.Controls.Add(this.txtEnderecoVacina);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtDataVacina);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtDataNascVacina);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtNomePessoaVacina);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtIdVacina);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1249, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhes";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // cbxEnfermeiroVacina
            // 
            this.cbxEnfermeiroVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEnfermeiroVacina.Enabled = false;
            this.cbxEnfermeiroVacina.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEnfermeiroVacina.FormattingEnabled = true;
            this.cbxEnfermeiroVacina.Location = new System.Drawing.Point(474, 178);
            this.cbxEnfermeiroVacina.Name = "cbxEnfermeiroVacina";
            this.cbxEnfermeiroVacina.Size = new System.Drawing.Size(121, 23);
            this.cbxEnfermeiroVacina.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(701, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cbxCidadeVacina
            // 
            this.cbxCidadeVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidadeVacina.Enabled = false;
            this.cbxCidadeVacina.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCidadeVacina.FormattingEnabled = true;
            this.cbxCidadeVacina.Location = new System.Drawing.Point(170, 180);
            this.cbxCidadeVacina.Name = "cbxCidadeVacina";
            this.cbxCidadeVacina.Size = new System.Drawing.Size(121, 23);
            this.cbxCidadeVacina.TabIndex = 27;
            this.cbxCidadeVacina.SelectedIndexChanged += new System.EventHandler(this.cbxCidadeVacina_SelectedIndexChanged);
            // 
            // cmbxGrupoPriori
            // 
            this.cmbxGrupoPriori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxGrupoPriori.Enabled = false;
            this.cmbxGrupoPriori.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxGrupoPriori.FormattingEnabled = true;
            this.cmbxGrupoPriori.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cmbxGrupoPriori.Location = new System.Drawing.Point(474, 226);
            this.cmbxGrupoPriori.Name = "cmbxGrupoPriori";
            this.cmbxGrupoPriori.Size = new System.Drawing.Size(121, 23);
            this.cmbxGrupoPriori.TabIndex = 26;
            // 
            // cmbxComorbidadeVacina
            // 
            this.cmbxComorbidadeVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxComorbidadeVacina.Enabled = false;
            this.cmbxComorbidadeVacina.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxComorbidadeVacina.FormattingEnabled = true;
            this.cmbxComorbidadeVacina.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cmbxComorbidadeVacina.Location = new System.Drawing.Point(474, 274);
            this.cmbxComorbidadeVacina.Name = "cmbxComorbidadeVacina";
            this.cmbxComorbidadeVacina.Size = new System.Drawing.Size(121, 23);
            this.cmbxComorbidadeVacina.TabIndex = 25;
            this.cmbxComorbidadeVacina.SelectedIndexChanged += new System.EventHandler(this.cmbxComorbidadeVacina_SelectedIndexChanged);
            // 
            // cmbxTipoVacina
            // 
            this.cmbxTipoVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTipoVacina.Enabled = false;
            this.cmbxTipoVacina.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxTipoVacina.FormattingEnabled = true;
            this.cmbxTipoVacina.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbxTipoVacina.Location = new System.Drawing.Point(282, 442);
            this.cmbxTipoVacina.Name = "cmbxTipoVacina";
            this.cmbxTipoVacina.Size = new System.Drawing.Size(121, 23);
            this.cmbxTipoVacina.TabIndex = 24;
            // 
            // mskbxRgVacina
            // 
            this.mskbxRgVacina.Enabled = false;
            this.mskbxRgVacina.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxRgVacina.Location = new System.Drawing.Point(170, 276);
            this.mskbxRgVacina.Mask = "999999999";
            this.mskbxRgVacina.Name = "mskbxRgVacina";
            this.mskbxRgVacina.Size = new System.Drawing.Size(110, 23);
            this.mskbxRgVacina.TabIndex = 23;
            // 
            // mskbxCprfVacina
            // 
            this.mskbxCprfVacina.Enabled = false;
            this.mskbxCprfVacina.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxCprfVacina.Location = new System.Drawing.Point(170, 229);
            this.mskbxCprfVacina.Mask = "99999999999";
            this.mskbxCprfVacina.Name = "mskbxCprfVacina";
            this.mskbxCprfVacina.Size = new System.Drawing.Size(110, 23);
            this.mskbxCprfVacina.TabIndex = 22;
            // 
            // txtEnderecoVacina
            // 
            this.txtEnderecoVacina.Enabled = false;
            this.txtEnderecoVacina.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoVacina.Location = new System.Drawing.Point(172, 127);
            this.txtEnderecoVacina.MaxLength = 100;
            this.txtEnderecoVacina.Name = "txtEnderecoVacina";
            this.txtEnderecoVacina.Size = new System.Drawing.Size(425, 27);
            this.txtEnderecoVacina.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(308, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 18);
            this.label12.TabIndex = 15;
            this.label12.Text = "Enfermeiro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(306, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 18);
            this.label11.TabIndex = 14;
            this.label11.Text = "Grupo Prioritário?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(306, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tem Comorbidade?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(146, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(421, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tipo Vacina (1-CoronaVac, 2- Astrazeneca, 3-Pfizer)";
            // 
            // txtDataVacina
            // 
            this.txtDataVacina.CustomFormat = "dd/MM/yyyy";
            this.txtDataVacina.Enabled = false;
            this.txtDataVacina.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataVacina.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataVacina.Location = new System.Drawing.Point(271, 357);
            this.txtDataVacina.Name = "txtDataVacina";
            this.txtDataVacina.Size = new System.Drawing.Size(200, 27);
            this.txtDataVacina.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(82, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Data de Vacinação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(82, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "RG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(82, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(82, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(82, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Endereço";
            // 
            // txtDataNascVacina
            // 
            this.txtDataNascVacina.CustomFormat = "dd/MM/yyyy";
            this.txtDataNascVacina.Enabled = false;
            this.txtDataNascVacina.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascVacina.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataNascVacina.Location = new System.Drawing.Point(271, 316);
            this.txtDataNascVacina.Name = "txtDataNascVacina";
            this.txtDataNascVacina.Size = new System.Drawing.Size(200, 27);
            this.txtDataNascVacina.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(82, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Nascimento";
            // 
            // txtNomePessoaVacina
            // 
            this.txtNomePessoaVacina.Enabled = false;
            this.txtNomePessoaVacina.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePessoaVacina.Location = new System.Drawing.Point(239, 74);
            this.txtNomePessoaVacina.MaxLength = 50;
            this.txtNomePessoaVacina.Name = "txtNomePessoaVacina";
            this.txtNomePessoaVacina.Size = new System.Drawing.Size(358, 27);
            this.txtNomePessoaVacina.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(82, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome da pessoa";
            // 
            // txtIdVacina
            // 
            this.txtIdVacina.Enabled = false;
            this.txtIdVacina.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVacina.Location = new System.Drawing.Point(178, 35);
            this.txtIdVacina.Name = "txtIdVacina";
            this.txtIdVacina.Size = new System.Drawing.Size(110, 26);
            this.txtIdVacina.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(82, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pessoa ID";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(632, 33);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Cadastro de Vacinação Contra a COVID-19. ";
            // 
            // frmVacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1283, 613);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bnVacina);
            this.Name = "frmVacina";
            this.Text = "frmVacina";
            this.Load += new System.EventHandler(this.frmVacina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnVacina)).EndInit();
            this.bnVacina.ResumeLayout(false);
            this.bnVacina.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbVacina.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacina)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnVacina;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbVacina;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvVacina;
        private System.Windows.Forms.ToolStripButton btnIncluir;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txtDataVacina;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtDataNascVacina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomePessoaVacina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdVacina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnderecoVacina;
        private System.Windows.Forms.MaskedTextBox mskbxRgVacina;
        private System.Windows.Forms.MaskedTextBox mskbxCprfVacina;
        private System.Windows.Forms.ComboBox cmbxGrupoPriori;
        private System.Windows.Forms.ComboBox cmbxComorbidadeVacina;
        private System.Windows.Forms.ComboBox cmbxTipoVacina;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbxCidadeVacina;
        private System.Windows.Forms.ComboBox cbxEnfermeiroVacina;
    }
}