namespace CamadaApresentacao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbMarketplaceDataSet = new CamadaApresentacao.dbMarketplaceDataSet();
            this.tbProdutoTableAdapter = new CamadaApresentacao.dbMarketplaceDataSetTableAdapters.tbProdutoTableAdapter();
            this.groupBoxProduto = new System.Windows.Forms.GroupBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.btnIncluirUsuario = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbMarketplace = new System.Windows.Forms.Label();
            this.lbMarketplace2 = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMarketplaceDataSet)).BeginInit();
            this.groupBoxProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProdutoBindingSource
            // 
            this.tbProdutoBindingSource.DataMember = "tbProduto";
            this.tbProdutoBindingSource.DataSource = this.dbMarketplaceDataSet;
            // 
            // dbMarketplaceDataSet
            // 
            this.dbMarketplaceDataSet.DataSetName = "dbMarketplaceDataSet";
            this.dbMarketplaceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbProdutoTableAdapter
            // 
            this.tbProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // groupBoxProduto
            // 
            this.groupBoxProduto.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxProduto.BackgroundImage = global::CamadaApresentacao.Properties.Resources.azul_escuro1;
            this.groupBoxProduto.Controls.Add(this.tbCategoria);
            this.groupBoxProduto.Controls.Add(this.lbCategoria);
            this.groupBoxProduto.Controls.Add(this.tbDescricao);
            this.groupBoxProduto.Controls.Add(this.tbPreco);
            this.groupBoxProduto.Controls.Add(this.tbNome);
            this.groupBoxProduto.Controls.Add(this.tbId);
            this.groupBoxProduto.Controls.Add(this.lbDescricao);
            this.groupBoxProduto.Controls.Add(this.lbPreco);
            this.groupBoxProduto.Controls.Add(this.lbNome);
            this.groupBoxProduto.Controls.Add(this.lbId);
            this.groupBoxProduto.ForeColor = System.Drawing.SystemColors.Menu;
            this.groupBoxProduto.Location = new System.Drawing.Point(48, 12);
            this.groupBoxProduto.Name = "groupBoxProduto";
            this.groupBoxProduto.Size = new System.Drawing.Size(233, 238);
            this.groupBoxProduto.TabIndex = 1;
            this.groupBoxProduto.TabStop = false;
            this.groupBoxProduto.Text = "Produto";
            this.groupBoxProduto.Enter += new System.EventHandler(this.groupBoxProduto_Enter);
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(121, 124);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(100, 20);
            this.tbCategoria.TabIndex = 9;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(5, 131);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(106, 13);
            this.lbCategoria.TabIndex = 8;
            this.lbCategoria.Text = "Categoria do produto";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(121, 98);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(100, 20);
            this.tbDescricao.TabIndex = 7;
            // 
            // tbPreco
            // 
            this.tbPreco.Location = new System.Drawing.Point(121, 72);
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.Size = new System.Drawing.Size(100, 20);
            this.tbPreco.TabIndex = 6;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(121, 46);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 20);
            this.tbNome.TabIndex = 5;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(121, 20);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 4;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(6, 105);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(109, 13);
            this.lbDescricao.TabIndex = 3;
            this.lbDescricao.Text = "Descrição do produto";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Location = new System.Drawing.Point(7, 79);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(89, 13);
            this.lbPreco.TabIndex = 2;
            this.lbPreco.Text = "Preço do produto";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(8, 53);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(89, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome do produto";
            this.lbNome.Click += new System.EventHandler(this.lbNome_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(8, 27);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(72, 13);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "ID do produto";
            this.lbId.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnIncluirUsuario
            // 
            this.btnIncluirUsuario.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnIncluirUsuario.Image = global::CamadaApresentacao.Properties.Resources.azul_escuro1;
            this.btnIncluirUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIncluirUsuario.Location = new System.Drawing.Point(621, 22);
            this.btnIncluirUsuario.Name = "btnIncluirUsuario";
            this.btnIncluirUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnIncluirUsuario.Size = new System.Drawing.Size(131, 39);
            this.btnIncluirUsuario.TabIndex = 2;
            this.btnIncluirUsuario.Text = "Incluir produto";
            this.btnIncluirUsuario.UseVisualStyleBackColor = true;
            this.btnIncluirUsuario.Click += new System.EventHandler(this.btnIncluirUsuario_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackgroundImage = global::CamadaApresentacao.Properties.Resources.azul_escuro1;
            this.btSalvar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btSalvar.Location = new System.Drawing.Point(621, 211);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(131, 39);
            this.btSalvar.TabIndex = 3;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btSair
            // 
            this.btSair.BackgroundImage = global::CamadaApresentacao.Properties.Resources.azul_escuro1;
            this.btSair.ForeColor = System.Drawing.SystemColors.Menu;
            this.btSair.Location = new System.Drawing.Point(658, 415);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 23);
            this.btSair.TabIndex = 4;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdDataGridViewTextBoxColumn,
            this.cNomeDataGridViewTextBoxColumn,
            this.cPrecoDataGridViewTextBoxColumn,
            this.cDescricaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbProdutoBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Violet;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cIdDataGridViewTextBoxColumn
            // 
            this.cIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cIdDataGridViewTextBoxColumn.DataPropertyName = "cId";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            this.cIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.cIdDataGridViewTextBoxColumn.HeaderText = "cId";
            this.cIdDataGridViewTextBoxColumn.Name = "cIdDataGridViewTextBoxColumn";
            this.cIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // cNomeDataGridViewTextBoxColumn
            // 
            this.cNomeDataGridViewTextBoxColumn.DataPropertyName = "cNome";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            this.cNomeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.cNomeDataGridViewTextBoxColumn.HeaderText = "cNome";
            this.cNomeDataGridViewTextBoxColumn.Name = "cNomeDataGridViewTextBoxColumn";
            // 
            // cPrecoDataGridViewTextBoxColumn
            // 
            this.cPrecoDataGridViewTextBoxColumn.DataPropertyName = "cPreco";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            this.cPrecoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.cPrecoDataGridViewTextBoxColumn.HeaderText = "cPreco";
            this.cPrecoDataGridViewTextBoxColumn.Name = "cPrecoDataGridViewTextBoxColumn";
            // 
            // cDescricaoDataGridViewTextBoxColumn
            // 
            this.cDescricaoDataGridViewTextBoxColumn.DataPropertyName = "cDescricao";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent;
            this.cDescricaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.cDescricaoDataGridViewTextBoxColumn.HeaderText = "cDescricao";
            this.cDescricaoDataGridViewTextBoxColumn.Name = "cDescricaoDataGridViewTextBoxColumn";
            // 
            // lbMarketplace
            // 
            this.lbMarketplace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMarketplace.BackColor = System.Drawing.Color.Transparent;
            this.lbMarketplace.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbMarketplace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbMarketplace.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarketplace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(86)))));
            this.lbMarketplace.Location = new System.Drawing.Point(12, 9);
            this.lbMarketplace.Name = "lbMarketplace";
            this.lbMarketplace.Size = new System.Drawing.Size(30, 241);
            this.lbMarketplace.TabIndex = 5;
            this.lbMarketplace.Text = "M\r\nA\r\nR\r\nQ\r\nU\r\nE\r\nT\r\nP\r\nL\r\nA\r\nC\r\nE";
            this.lbMarketplace.Click += new System.EventHandler(this.lbMarketplace_Click);
            // 
            // lbMarketplace2
            // 
            this.lbMarketplace2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMarketplace2.BackColor = System.Drawing.Color.Transparent;
            this.lbMarketplace2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbMarketplace2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbMarketplace2.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarketplace2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(86)))));
            this.lbMarketplace2.Location = new System.Drawing.Point(758, 12);
            this.lbMarketplace2.Name = "lbMarketplace2";
            this.lbMarketplace2.Size = new System.Drawing.Size(30, 241);
            this.lbMarketplace2.TabIndex = 6;
            this.lbMarketplace2.Text = "M\r\nA\r\nR\r\nQ\r\nU\r\nE\r\nT\r\nP\r\nL\r\nA\r\nC\r\nE";
            // 
            // btExcluir
            // 
            this.btExcluir.ForeColor = System.Drawing.SystemColors.Menu;
            this.btExcluir.Image = global::CamadaApresentacao.Properties.Resources.azul_escuro1;
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btExcluir.Location = new System.Drawing.Point(621, 84);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btExcluir.Size = new System.Drawing.Size(131, 39);
            this.btExcluir.TabIndex = 7;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btAtualizar.Image = global::CamadaApresentacao.Properties.Resources.azul_escuro1;
            this.btAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAtualizar.Location = new System.Drawing.Point(621, 153);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btAtualizar.Size = new System.Drawing.Size(131, 39);
            this.btAtualizar.TabIndex = 8;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.marketplace_vendus_1200_og;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.lbMarketplace2);
            this.Controls.Add(this.lbMarketplace);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btnIncluirUsuario);
            this.Controls.Add(this.groupBoxProduto);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMarketplaceDataSet)).EndInit();
            this.groupBoxProduto.ResumeLayout(false);
            this.groupBoxProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private dbMarketplaceDataSet dbMarketplaceDataSet;
        private System.Windows.Forms.BindingSource tbProdutoBindingSource;
        private dbMarketplaceDataSetTableAdapters.tbProdutoTableAdapter tbProdutoTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxProduto;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbPreco;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Button btnIncluirUsuario;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbMarketplace;
        private System.Windows.Forms.Label lbMarketplace2;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAtualizar;
    }
}

