using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    public partial class frmCadastro : Form
    {
        // Criando o objeto que representa a conexão
        SqlConnection sqlCon = null;

        //Data Source=.\SQLEXPRESS;Integrated Security=True;Connect Timeout=30
        private string strCon = "Data Source=LI02-10;Initial Catalog = aula_edson; User ID = sa; password=123456";
        private string strSql = "";

        SqlConnection objConect = null; //
        SqlCommand objCommand = null; //

        string campos;
        DateTime dataval;

        public frmCadastro()
        {
            InitializeComponent();
        }

        public void listaGrid() //
        {
            strSql = "Select * from alimentos where ativo = 1";
            objConect = new SqlConnection(strCon);
            objCommand = new SqlCommand(strSql, objConect);

            try
            {
                // pode armazenar varios registros
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                // possibilita jogar os registros em um datagridview
                DataTable dtLista = new DataTable();
                // carregando os registros no datatable
                objAdp.Fill(dtLista);
                dgvAlimentos.DataSource = null; // **** para atualizar o grid
                dgvAlimentos.DataSource = dtLista;
            }
            catch
            {
                MessageBox.Show("Erro no banco");
            }


        }





        private void frmCadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aula_edsonDataSet.alimentos'. Você pode movê-la ou removê-la conforme necessário.
            //this.alimentosTableAdapter.Fill(this.aula_edsonDataSet.alimentos);
            configuraDataGridView();
            listaGrid();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            strSql = "select * from alimentos where id_alimento = @id_alimento";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@id_alimento", SqlDbType.Int).Value = txtID.Text;
            sqlCon.Open();
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("Impossível cadastrar. O id já existe.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                // construção da instrução sql de cadastro de registro
                strSql = "insert into alimentos (ID_alimento, alimento, quantidade, data_fabricacao, data_validade, preco, ativo) values (@ID_alimento, @alimento, @quantidade, @data_fabricacao, @data_validade, @preco, 1)";

                // abertura da tabela no sqlcon: objeto que representa o banco de dados
                sqlCon = new SqlConnection(strCon);
                // objeto que representa a instrucao sql de cadastro
                comando = new SqlCommand(strSql, sqlCon);

                // Adiciona o conteudo do Text na variável do banco de dados

                comando.Parameters.Add("@id_alimento", SqlDbType.Int).Value = txtID.Text;
                comando.Parameters.Add("@alimento", SqlDbType.VarChar).Value = txtAlimento.Text;
                comando.Parameters.Add("@quantidade", SqlDbType.Int).Value = txtQuantidade.Text;
                comando.Parameters.Add("@data_fabricacao", SqlDbType.Date).Value = txtDataFabricacao.Text;
                comando.Parameters.Add("@data_validade", SqlDbType.Date).Value = txtDataValidade.Text;
                comando.Parameters.Add("@preco", SqlDbType.Real).Value = txtPreco.Text;

                // está de fato abrindo a conexao
                sqlCon.Open();
                // executar uma instrucao simples de 1 para 1
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro efetuado com sucesso");

                listaGrid();

                sqlCon.Close();
                limparTexts();
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            strSql = "select * from alimentos where id_alimento = @id_alimento";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);


            comando.Parameters.Add("@id_alimento", SqlDbType.Int).Value = txtID.Text;

            sqlCon.Open();
            SqlDataReader dr = comando.ExecuteReader();
            if(dr.HasRows == true)
            {
                dr.Read();
                 txtAlimento.Text = Convert.ToString(dr["alimento"]);
                 txtQuantidade.Text = Convert.ToString(dr["quantidade"]);
                 txtDataFabricacao.Text = String.Format("{0:d}",dr["data_fabricacao"]);
                 txtDataValidade.Text = String.Format("{0:d}", dr["data_validade"]);
                 txtPreco.Text = Convert.ToString(dr["preco"]);
                
                }
            else
            {
                MessageBox.Show("Registro nao existe");
            }
            txtID.Enabled = false;
        }

        private void btnLimparTexts_Click(object sender, EventArgs e)
        {
            limparTexts();
            txtID.Enabled = true;
        }

        private void limparTexts()
        {
            txtAlimento.Clear();
            txtDataFabricacao.Clear();
            txtDataValidade.Clear();
            txtID.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            txtID.Focus();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
           
            listaGrid(); //
            


        }

        private void configuraDataGridView()
               {
                   // Configura o cabeçalho
                   dgvAlimentos.Columns[0].HeaderText = "ID";
                   dgvAlimentos.Columns[1].HeaderText = "Alimento";
                   dgvAlimentos.Columns[2].HeaderText = "Quantidade";
                   dgvAlimentos.Columns[3].HeaderText = "Data Fabricação";
                   dgvAlimentos.Columns[4].HeaderText = "Data Validade";
                   dgvAlimentos.Columns[5].HeaderText = "Preço";

                   // Configura as larguras das colunas
                   dgvAlimentos.Columns[0].Width = 50;
                   dgvAlimentos.Columns[1].Width = 200;
                   dgvAlimentos.Columns[2].Width = 50;
                   dgvAlimentos.Columns[3].Width = 80;
                   dgvAlimentos.Columns[4].Width = 80;
                   dgvAlimentos.Columns[5].Width = 80;


               }



        private void chkID_Click(object sender, EventArgs e)
        {
            if (chkID.Checked)
            {
                dgvAlimentos.Columns[0].Visible = true;
            }
            else
            {
                dgvAlimentos.Columns[0].Visible = false;

            }
        }

        private void chkAlimento_Click(object sender, EventArgs e)
        {
            if (chkAlimento.Checked)
            {
                dgvAlimentos.Columns[1].Visible = true;
            }
            else
            {
                dgvAlimentos.Columns[1].Visible = false;

            }
        }

        private void chkQuantidade_Click(object sender, EventArgs e)
        {
            if (chkQuantidade.Checked)
            {
                dgvAlimentos.Columns[2].Visible = true;
            }
            else
            {
                dgvAlimentos.Columns[2].Visible = false;

            }
        }

        private void chkDataFabricacao_Click(object sender, EventArgs e)
        {
            if (chkDataFabricacao.Checked)
            {
                dgvAlimentos.Columns[3].Visible = true;
            }
            else
            {
                dgvAlimentos.Columns[3].Visible = false;

            }
        }

        private void chkDataValidade_Click(object sender, EventArgs e)
        {
            if (chkDataValidade.Checked)
            {
                dgvAlimentos.Columns[4].Visible = true;
            }
            else
            {
                dgvAlimentos.Columns[4].Visible = false;

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que você quer excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                strSql = "update alimentos set ativo = 0 where id_alimento = @id_alimento";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                sqlCon.Open();
                comando.Parameters.Add("@id_alimento", SqlDbType.Int).Value = txtID.Text;
                comando.ExecuteNonQuery();
                limparTexts();
                listaGrid();
                sqlCon.Close();
                MessageBox.Show("Registro excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
                /*

                -- V1

                 strSql = "delete from alimentos where id_alimento = @id_alimento";
                 sqlCon = new SqlConnection(strCon);
                 SqlCommand comando = new SqlCommand(strSql, sqlCon);

                 sqlCon.Open();
                 comando.Parameters.Add("@id_alimento", SqlDbType.Int).Value = txtID.Text;
                 comando.ExecuteNonQuery();
                 limparTexts();
                 listaGrid();
                 sqlCon.Close();
                 MessageBox.Show("Registro excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);            }
         */

            
        }

        private void dgvAlimentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idClicado;
            //captura o código
            //MessageBox.Show(Convert.ToString(dgvAlimentos.Rows[e.RowIndex].Cells[0].Value));
            idClicado = Convert.ToString(dgvAlimentos.Rows[e.RowIndex].Cells[0].Value); //17 "17"

            strSql = "select * from alimentos where id_alimento = @id_alimento";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);


            comando.Parameters.Add("@id_alimento", SqlDbType.Int).Value = idClicado;

            sqlCon.Open();
            SqlDataReader dr = comando.ExecuteReader();
          
            dr.Read();
            txtID.Text = Convert.ToString(dr["id_alimento"]);
            txtAlimento.Text = Convert.ToString(dr["alimento"]);
            txtQuantidade.Text = Convert.ToString(dr["quantidade"]);
            txtDataFabricacao.Text = String.Format("{0:d}", dr["data_fabricacao"]);
            txtDataValidade.Text = String.Format("{0:d}", dr["data_validade"]);
            txtPreco.Text = Convert.ToString(dr["preco"]);
            txtID.Enabled = false;
            

        }


        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            // construção da instrução sql de cadastro de registro
            strSql = "update alimentos set alimento = @alimento, quantidade = @quantidade, data_fabricacao = @data_fabricacao, data_validade = @data_validade, preco = @preco where id_alimento = @id_alimento" ;

            // abertura da tabela no sqlcon: objeto que representa o banco de dados
            sqlCon = new SqlConnection(strCon);
            // objeto que representa a instrucao sql de cadastro
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            // Adiciona co conteudo do Text na variável do banco de dados

            // adicionar o parametro id alimento nestra instrucao do tipo int

            comando.Parameters.Add("@id_alimento", SqlDbType.Int).Value = txtID.Text;
            comando.Parameters.Add("@alimento", SqlDbType.VarChar).Value = txtAlimento.Text;
            comando.Parameters.Add("@quantidade", SqlDbType.Int).Value = txtQuantidade.Text;
            comando.Parameters.Add("@data_fabricacao", SqlDbType.Date).Value = txtDataFabricacao.Text;
            comando.Parameters.Add("@data_validade", SqlDbType.Date).Value = txtDataValidade.Text;
            comando.Parameters.Add("@preco", SqlDbType.Real).Value = txtPreco.Text;

            // está de fato abrindo a conexao
            sqlCon.Open();
            // executar uma instrucao simples de 1 para 1
            comando.ExecuteNonQuery();
            //MessageBox.Show("Atualização efetuada com sucesso");
            dgvAlimentos.Refresh();
            listaGrid();
        }
    }
}
