using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaModelo;
using CamadaControle;

namespace CamadaApresentacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbMarketplaceDataSet.tbProduto'.
            this.tbProdutoTableAdapter.Fill(this.dbMarketplaceDataSet.tbProduto);

        }

        private void groupBoxProduto_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbNome_Click(object sender, EventArgs e)
        {

        }

        private void btnIncluirUsuario_Click(object sender, EventArgs e)
        {
            MdlProduto _MdlProduto = new MdlProduto();
            CtlVendedor _CtlVendedor = new CtlVendedor();

            try
            {
                _MdlProduto.IdProduto = tbId.Text;
                _MdlProduto.Nome = tbNome.Text;
                _MdlProduto.Preco = tbPreco.Text;

                bool retorno = _CtlVendedor.Cadastrar(_MdlProduto);

                if (retorno)
                {
                    LimparCampos();
                    MessageBox.Show("Produto incluído com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar a inclusão.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {;
            // Finaliza a edição do binding source
            tbProdutoBindingSource.EndEdit();

            // Atualiza o banco de dados
            tbProdutoTableAdapter.Update(dbMarketplaceDataSet);

            // Recarrega os dados no binding source (isso atualizará o DataGridView)
            tbProdutoTableAdapter.Fill(dbMarketplaceDataSet.tbProduto);

            // Informa ao DataGridView que os dados foram atualizados
            dataGridView1.Invalidate();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbMarketplace_Click(object sender, EventArgs e)
        {
            //lbMarketplace.Text = "M\na\nr\nq\nu\ne\nt\np\nl\na\nc\ne";
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            MdlProduto _MdlProduto = new MdlProduto();
            CtlVendedor _CtlVendedor = new CtlVendedor();

            try
            {
                _MdlProduto.IdProduto = tbId.Text;
                //_MdlProduto.Nome = tbNome.Text;

                bool retorno = _CtlVendedor.Excluir(_MdlProduto);

                if (retorno)
                {
                    LimparCampos(); ;
                    MessageBox.Show("Produto excluido com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar a exclusão.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            MdlProduto _MdlProduto = new MdlProduto();
            CtlVendedor _CtlVendedor = new CtlVendedor();

            try
            {
                _MdlProduto.IdProduto = tbId.Text;
                _MdlProduto.Nome = tbNome.Text;

                bool retorno = _CtlVendedor.Atualizar(_MdlProduto);

                if (retorno)
                {
                    LimparCampos();
                    MessageBox.Show("Produto atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar a atualização.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void LimparCampos()
        {
            tbId.Text = string.Empty;
            tbNome.Text = string.Empty;
            tbPreco.Text = string.Empty;
            tbDescricao.Text = string.Empty;
            tbCategoria.Text = string.Empty;
            tbNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
