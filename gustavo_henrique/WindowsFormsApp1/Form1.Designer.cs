namespace WindowsFormsApp1
{
    partial class frmCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAlimento = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtDataFabricacao = new System.Windows.Forms.TextBox();
            this.txtDataValidade = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimparTexts = new System.Windows.Forms.Button();
            this.dgvAlimentos = new System.Windows.Forms.DataGridView();
            this.idalimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafabricacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aula_edsonDataSet = new WindowsFormsApp1.aula_edsonDataSet();
            this.btnListar = new System.Windows.Forms.Button();
            this.alimentosTableAdapter = new WindowsFormsApp1.aula_edsonDataSetTableAdapters.alimentosTableAdapter();
            this.chkID = new System.Windows.Forms.CheckBox();
            this.chkAlimento = new System.Windows.Forms.CheckBox();
            this.chkQuantidade = new System.Windows.Forms.CheckBox();
            this.chkDataFabricacao = new System.Windows.Forms.CheckBox();
            this.chkDataValidade = new System.Windows.Forms.CheckBox();
            this.chkPreco = new System.Windows.Forms.CheckBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_edsonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de fabricação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Validade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Preço";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(118, 9);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 6;
            // 
            // txtAlimento
            // 
            this.txtAlimento.Location = new System.Drawing.Point(118, 36);
            this.txtAlimento.Name = "txtAlimento";
            this.txtAlimento.Size = new System.Drawing.Size(100, 20);
            this.txtAlimento.TabIndex = 7;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(118, 62);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 8;
            // 
            // txtDataFabricacao
            // 
            this.txtDataFabricacao.Location = new System.Drawing.Point(118, 87);
            this.txtDataFabricacao.Name = "txtDataFabricacao";
            this.txtDataFabricacao.Size = new System.Drawing.Size(100, 20);
            this.txtDataFabricacao.TabIndex = 9;
            // 
            // txtDataValidade
            // 
            this.txtDataValidade.Location = new System.Drawing.Point(118, 113);
            this.txtDataValidade.Name = "txtDataValidade";
            this.txtDataValidade.Size = new System.Drawing.Size(100, 20);
            this.txtDataValidade.TabIndex = 10;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(118, 139);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 11;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(26, 185);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(128, 185);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimparTexts
            // 
            this.btnLimparTexts.Location = new System.Drawing.Point(77, 225);
            this.btnLimparTexts.Name = "btnLimparTexts";
            this.btnLimparTexts.Size = new System.Drawing.Size(75, 23);
            this.btnLimparTexts.TabIndex = 14;
            this.btnLimparTexts.Text = "Limpar Texts";
            this.btnLimparTexts.UseVisualStyleBackColor = true;
            this.btnLimparTexts.Click += new System.EventHandler(this.btnLimparTexts_Click);
            // 
            // dgvAlimentos
            // 
            this.dgvAlimentos.AutoGenerateColumns = false;
            this.dgvAlimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalimentoDataGridViewTextBoxColumn,
            this.alimentoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.datafabricacaoDataGridViewTextBoxColumn,
            this.datavalidadeDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn});
            this.dgvAlimentos.DataSource = this.alimentosBindingSource;
            this.dgvAlimentos.Location = new System.Drawing.Point(263, 68);
            this.dgvAlimentos.Name = "dgvAlimentos";
            this.dgvAlimentos.Size = new System.Drawing.Size(605, 251);
            this.dgvAlimentos.TabIndex = 15;
            this.dgvAlimentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlimentos_CellClick);
            // 
            // idalimentoDataGridViewTextBoxColumn
            // 
            this.idalimentoDataGridViewTextBoxColumn.DataPropertyName = "id_alimento";
            this.idalimentoDataGridViewTextBoxColumn.HeaderText = "id_alimento";
            this.idalimentoDataGridViewTextBoxColumn.Name = "idalimentoDataGridViewTextBoxColumn";
            // 
            // alimentoDataGridViewTextBoxColumn
            // 
            this.alimentoDataGridViewTextBoxColumn.DataPropertyName = "alimento";
            this.alimentoDataGridViewTextBoxColumn.HeaderText = "alimento";
            this.alimentoDataGridViewTextBoxColumn.Name = "alimentoDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // datafabricacaoDataGridViewTextBoxColumn
            // 
            this.datafabricacaoDataGridViewTextBoxColumn.DataPropertyName = "data_fabricacao";
            this.datafabricacaoDataGridViewTextBoxColumn.HeaderText = "data_fabricacao";
            this.datafabricacaoDataGridViewTextBoxColumn.Name = "datafabricacaoDataGridViewTextBoxColumn";
            // 
            // datavalidadeDataGridViewTextBoxColumn
            // 
            this.datavalidadeDataGridViewTextBoxColumn.DataPropertyName = "data_validade";
            this.datavalidadeDataGridViewTextBoxColumn.HeaderText = "data_validade";
            this.datavalidadeDataGridViewTextBoxColumn.Name = "datavalidadeDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // alimentosBindingSource
            // 
            this.alimentosBindingSource.DataMember = "alimentos";
            this.alimentosBindingSource.DataSource = this.aula_edsonDataSet;
            // 
            // aula_edsonDataSet
            // 
            this.aula_edsonDataSet.DataSetName = "aula_edsonDataSet";
            this.aula_edsonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(263, 325);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // alimentosTableAdapter
            // 
            this.alimentosTableAdapter.ClearBeforeFill = true;
            // 
            // chkID
            // 
            this.chkID.AutoSize = true;
            this.chkID.Checked = true;
            this.chkID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkID.Location = new System.Drawing.Point(303, 45);
            this.chkID.Name = "chkID";
            this.chkID.Size = new System.Drawing.Size(35, 17);
            this.chkID.TabIndex = 17;
            this.chkID.Text = "Id";
            this.chkID.UseVisualStyleBackColor = true;
            this.chkID.Click += new System.EventHandler(this.chkID_Click);
            // 
            // chkAlimento
            // 
            this.chkAlimento.AutoSize = true;
            this.chkAlimento.Checked = true;
            this.chkAlimento.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlimento.Location = new System.Drawing.Point(404, 45);
            this.chkAlimento.Name = "chkAlimento";
            this.chkAlimento.Size = new System.Drawing.Size(66, 17);
            this.chkAlimento.TabIndex = 18;
            this.chkAlimento.Text = "Alimento";
            this.chkAlimento.UseVisualStyleBackColor = true;
            this.chkAlimento.Click += new System.EventHandler(this.chkAlimento_Click);
            // 
            // chkQuantidade
            // 
            this.chkQuantidade.AutoSize = true;
            this.chkQuantidade.Checked = true;
            this.chkQuantidade.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkQuantidade.Location = new System.Drawing.Point(507, 45);
            this.chkQuantidade.Name = "chkQuantidade";
            this.chkQuantidade.Size = new System.Drawing.Size(81, 17);
            this.chkQuantidade.TabIndex = 19;
            this.chkQuantidade.Text = "Quantidade";
            this.chkQuantidade.UseVisualStyleBackColor = true;
            this.chkQuantidade.Click += new System.EventHandler(this.chkQuantidade_Click);
            // 
            // chkDataFabricacao
            // 
            this.chkDataFabricacao.AutoSize = true;
            this.chkDataFabricacao.Checked = true;
            this.chkDataFabricacao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDataFabricacao.Location = new System.Drawing.Point(608, 45);
            this.chkDataFabricacao.Name = "chkDataFabricacao";
            this.chkDataFabricacao.Size = new System.Drawing.Size(105, 17);
            this.chkDataFabricacao.TabIndex = 20;
            this.chkDataFabricacao.Text = "Data Fabricação";
            this.chkDataFabricacao.UseVisualStyleBackColor = true;
            this.chkDataFabricacao.Click += new System.EventHandler(this.chkDataFabricacao_Click);
            // 
            // chkDataValidade
            // 
            this.chkDataValidade.AutoSize = true;
            this.chkDataValidade.Checked = true;
            this.chkDataValidade.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDataValidade.Location = new System.Drawing.Point(708, 45);
            this.chkDataValidade.Name = "chkDataValidade";
            this.chkDataValidade.Size = new System.Drawing.Size(93, 17);
            this.chkDataValidade.TabIndex = 21;
            this.chkDataValidade.Text = "Data Validade";
            this.chkDataValidade.UseVisualStyleBackColor = true;
            this.chkDataValidade.Click += new System.EventHandler(this.chkDataValidade_Click);
            // 
            // chkPreco
            // 
            this.chkPreco.AutoSize = true;
            this.chkPreco.Checked = true;
            this.chkPreco.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreco.Location = new System.Drawing.Point(808, 45);
            this.chkPreco.Name = "chkPreco";
            this.chkPreco.Size = new System.Drawing.Size(54, 17);
            this.chkPreco.TabIndex = 22;
            this.chkPreco.Text = "Preço";
            this.chkPreco.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(26, 254);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 25);
            this.btnAtualizar.TabIndex = 23;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(128, 255);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 360);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.chkPreco);
            this.Controls.Add(this.chkDataValidade);
            this.Controls.Add(this.chkDataFabricacao);
            this.Controls.Add(this.chkQuantidade);
            this.Controls.Add(this.chkAlimento);
            this.Controls.Add(this.chkID);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvAlimentos);
            this.Controls.Add(this.btnLimparTexts);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtDataValidade);
            this.Controls.Add(this.txtDataFabricacao);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtAlimento);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_edsonDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAlimento;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtDataFabricacao;
        private System.Windows.Forms.TextBox txtDataValidade;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimparTexts;
        private System.Windows.Forms.DataGridView dgvAlimentos;
        private System.Windows.Forms.Button btnListar;
        private aula_edsonDataSet aula_edsonDataSet;
        private System.Windows.Forms.BindingSource alimentosBindingSource;
        private aula_edsonDataSetTableAdapters.alimentosTableAdapter alimentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafabricacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox chkID;
        private System.Windows.Forms.CheckBox chkAlimento;
        private System.Windows.Forms.CheckBox chkQuantidade;
        private System.Windows.Forms.CheckBox chkDataFabricacao;
        private System.Windows.Forms.CheckBox chkDataValidade;
        private System.Windows.Forms.CheckBox chkPreco;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
    }
}

