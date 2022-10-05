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
            this.lblmorador = new System.Windows.Forms.Label();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.lbldtchegada = new System.Windows.Forms.Label();
            this.lbldtentrega = new System.Windows.Forms.Label();
            this.txtMorador = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtDataChegada = new System.Windows.Forms.TextBox();
            this.txtDataEntrega = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimparTexts = new System.Windows.Forms.Button();
            this.dgvArmazenagem = new System.Windows.Forms.DataGridView();
            this.alimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aula_edsonDataSet = new WindowsFormsApp1.aula_edsonDataSet();
            this.btnListar = new System.Windows.Forms.Button();
            this.alimentosTableAdapter = new WindowsFormsApp1.aula_edsonDataSetTableAdapters.alimentosTableAdapter();
            this.chkMorador = new System.Windows.Forms.CheckBox();
            this.chkTelefone = new System.Windows.Forms.CheckBox();
            this.chkDataChegada = new System.Windows.Forms.CheckBox();
            this.chkDataEntrega = new System.Windows.Forms.CheckBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.aula_edsonDataSet1 = new WindowsFormsApp1.aula_edsonDataSet();
            this.moradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datachegadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArmazenagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_edsonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_edsonDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmorador
            // 
            this.lblmorador.AutoSize = true;
            this.lblmorador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmorador.ForeColor = System.Drawing.Color.Yellow;
            this.lblmorador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblmorador.Location = new System.Drawing.Point(8, 112);
            this.lblmorador.Name = "lblmorador";
            this.lblmorador.Size = new System.Drawing.Size(54, 15);
            this.lblmorador.TabIndex = 0;
            this.lblmorador.Text = "Morador";
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefone.ForeColor = System.Drawing.Color.Yellow;
            this.lbltelefone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbltelefone.Location = new System.Drawing.Point(8, 138);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(55, 15);
            this.lbltelefone.TabIndex = 1;
            this.lbltelefone.Text = "Telefone";
            // 
            // lbldtchegada
            // 
            this.lbldtchegada.AutoSize = true;
            this.lbldtchegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldtchegada.ForeColor = System.Drawing.Color.Yellow;
            this.lbldtchegada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbldtchegada.Location = new System.Drawing.Point(8, 164);
            this.lbldtchegada.Name = "lbldtchegada";
            this.lbldtchegada.Size = new System.Drawing.Size(101, 15);
            this.lbldtchegada.TabIndex = 3;
            this.lbldtchegada.Text = "Data de chegada";
            // 
            // lbldtentrega
            // 
            this.lbldtentrega.AutoSize = true;
            this.lbldtentrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldtentrega.ForeColor = System.Drawing.Color.Yellow;
            this.lbldtentrega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbldtentrega.Location = new System.Drawing.Point(8, 186);
            this.lbldtentrega.Name = "lbldtentrega";
            this.lbldtentrega.Size = new System.Drawing.Size(95, 15);
            this.lbldtentrega.TabIndex = 4;
            this.lbldtentrega.Text = "Data de entrega";
            // 
            // txtMorador
            // 
            this.txtMorador.Location = new System.Drawing.Point(115, 107);
            this.txtMorador.Name = "txtMorador";
            this.txtMorador.Size = new System.Drawing.Size(100, 20);
            this.txtMorador.TabIndex = 6;
            this.txtMorador.TextChanged += new System.EventHandler(this.txtMorador_TextChanged);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(115, 133);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 7;
            // 
            // txtDataChegada
            // 
            this.txtDataChegada.Location = new System.Drawing.Point(115, 159);
            this.txtDataChegada.Name = "txtDataChegada";
            this.txtDataChegada.Size = new System.Drawing.Size(100, 20);
            this.txtDataChegada.TabIndex = 9;
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.Location = new System.Drawing.Point(115, 185);
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Size = new System.Drawing.Size(100, 20);
            this.txtDataEntrega.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 223);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(115, 223);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimparTexts
            // 
            this.btnLimparTexts.Location = new System.Drawing.Point(63, 296);
            this.btnLimparTexts.Name = "btnLimparTexts";
            this.btnLimparTexts.Size = new System.Drawing.Size(75, 23);
            this.btnLimparTexts.TabIndex = 14;
            this.btnLimparTexts.Text = "Limpar Texts";
            this.btnLimparTexts.UseVisualStyleBackColor = true;
            this.btnLimparTexts.Click += new System.EventHandler(this.btnLimparTexts_Click);
            // 
            // dgvArmazenagem
            // 
            this.dgvArmazenagem.AutoGenerateColumns = false;
            this.dgvArmazenagem.BackgroundColor = System.Drawing.Color.Black;
            this.dgvArmazenagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArmazenagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moradorDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.datachegadaDataGridViewTextBoxColumn,
            this.dataentregaDataGridViewTextBoxColumn});
            this.dgvArmazenagem.DataSource = this.alimentosBindingSource;
            this.dgvArmazenagem.GridColor = System.Drawing.Color.Blue;
            this.dgvArmazenagem.Location = new System.Drawing.Point(263, 68);
            this.dgvArmazenagem.Name = "dgvArmazenagem";
            this.dgvArmazenagem.Size = new System.Drawing.Size(443, 251);
            this.dgvArmazenagem.TabIndex = 15;
            this.dgvArmazenagem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlimentos_CellClick);
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
            // chkMorador
            // 
            this.chkMorador.AutoSize = true;
            this.chkMorador.Checked = true;
            this.chkMorador.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMorador.ForeColor = System.Drawing.Color.Yellow;
            this.chkMorador.Location = new System.Drawing.Point(309, 44);
            this.chkMorador.Name = "chkMorador";
            this.chkMorador.Size = new System.Drawing.Size(65, 17);
            this.chkMorador.TabIndex = 17;
            this.chkMorador.Text = "Morador";
            this.chkMorador.UseVisualStyleBackColor = true;
            this.chkMorador.Click += new System.EventHandler(this.chkID_Click);
            // 
            // chkTelefone
            // 
            this.chkTelefone.AutoSize = true;
            this.chkTelefone.Checked = true;
            this.chkTelefone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTelefone.ForeColor = System.Drawing.Color.Yellow;
            this.chkTelefone.Location = new System.Drawing.Point(408, 44);
            this.chkTelefone.Name = "chkTelefone";
            this.chkTelefone.Size = new System.Drawing.Size(68, 17);
            this.chkTelefone.TabIndex = 18;
            this.chkTelefone.Text = "Telefone";
            this.chkTelefone.UseVisualStyleBackColor = true;
            this.chkTelefone.Click += new System.EventHandler(this.chkAlimento_Click);
            // 
            // chkDataChegada
            // 
            this.chkDataChegada.AutoSize = true;
            this.chkDataChegada.Checked = true;
            this.chkDataChegada.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDataChegada.ForeColor = System.Drawing.Color.Yellow;
            this.chkDataChegada.Location = new System.Drawing.Point(503, 44);
            this.chkDataChegada.Name = "chkDataChegada";
            this.chkDataChegada.Size = new System.Drawing.Size(110, 17);
            this.chkDataChegada.TabIndex = 20;
            this.chkDataChegada.Text = "Data de Chegada";
            this.chkDataChegada.UseVisualStyleBackColor = true;
            this.chkDataChegada.Click += new System.EventHandler(this.chkDataFabricacao_Click);
            // 
            // chkDataEntrega
            // 
            this.chkDataEntrega.AutoSize = true;
            this.chkDataEntrega.Checked = true;
            this.chkDataEntrega.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDataEntrega.ForeColor = System.Drawing.Color.Yellow;
            this.chkDataEntrega.Location = new System.Drawing.Point(613, 45);
            this.chkDataEntrega.Name = "chkDataEntrega";
            this.chkDataEntrega.Size = new System.Drawing.Size(104, 17);
            this.chkDataEntrega.TabIndex = 21;
            this.chkDataEntrega.Text = "Data de Entrega";
            this.chkDataEntrega.UseVisualStyleBackColor = true;
            this.chkDataEntrega.Click += new System.EventHandler(this.chkDataValidade_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(12, 263);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 25);
            this.btnAtualizar.TabIndex = 23;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(115, 265);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // aula_edsonDataSet1
            // 
            this.aula_edsonDataSet1.DataSetName = "aula_edsonDataSet";
            this.aula_edsonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moradorDataGridViewTextBoxColumn
            // 
            this.moradorDataGridViewTextBoxColumn.DataPropertyName = "Morador";
            this.moradorDataGridViewTextBoxColumn.HeaderText = "Morador";
            this.moradorDataGridViewTextBoxColumn.Name = "moradorDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // datachegadaDataGridViewTextBoxColumn
            // 
            this.datachegadaDataGridViewTextBoxColumn.DataPropertyName = "data_chegada";
            this.datachegadaDataGridViewTextBoxColumn.HeaderText = "Data_Chegada";
            this.datachegadaDataGridViewTextBoxColumn.Name = "datachegadaDataGridViewTextBoxColumn";
            // 
            // dataentregaDataGridViewTextBoxColumn
            // 
            this.dataentregaDataGridViewTextBoxColumn.DataPropertyName = "data_entrega";
            this.dataentregaDataGridViewTextBoxColumn.HeaderText = "Data_Entrega";
            this.dataentregaDataGridViewTextBoxColumn.Name = "dataentregaDataGridViewTextBoxColumn";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Yellow;
            this.checkBox1.Location = new System.Drawing.Point(11, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 20);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Encomendas";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.Yellow;
            this.checkBox2.Location = new System.Drawing.Point(11, 68);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 20);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "Cartas";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(887, 360);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.chkDataEntrega);
            this.Controls.Add(this.chkDataChegada);
            this.Controls.Add(this.chkTelefone);
            this.Controls.Add(this.chkMorador);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvArmazenagem);
            this.Controls.Add(this.btnLimparTexts);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtDataEntrega);
            this.Controls.Add(this.txtDataChegada);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtMorador);
            this.Controls.Add(this.lbldtentrega);
            this.Controls.Add(this.lbldtchegada);
            this.Controls.Add(this.lbltelefone);
            this.Controls.Add(this.lblmorador);
            this.Name = "frmCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArmazenagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_edsonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_edsonDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmorador;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.Label lbldtchegada;
        private System.Windows.Forms.Label lbldtentrega;
        private System.Windows.Forms.TextBox txtMorador;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtDataChegada;
        private System.Windows.Forms.TextBox txtDataEntrega;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimparTexts;
        private System.Windows.Forms.DataGridView dgvArmazenagem;
        private System.Windows.Forms.Button btnListar;
        private aula_edsonDataSet aula_edsonDataSet;
        private System.Windows.Forms.BindingSource alimentosBindingSource;
        private aula_edsonDataSetTableAdapters.alimentosTableAdapter alimentosTableAdapter;
        private System.Windows.Forms.CheckBox chkMorador;
        private System.Windows.Forms.CheckBox chkTelefone;
        private System.Windows.Forms.CheckBox chkDataChegada;
        private System.Windows.Forms.CheckBox chkDataEntrega;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datachegadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentregaDataGridViewTextBoxColumn;
        private aula_edsonDataSet aula_edsonDataSet1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

