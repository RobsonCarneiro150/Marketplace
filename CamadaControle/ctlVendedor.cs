using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelo;

namespace CamadaControle
{
    public class CtlVendedor
    {
        public bool Cadastrar(MdlProduto _MdlProduto)
        {
            string conexaoAccess = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\robso\source\repos\Marketplace\dbMarketplace.accdb";

            OleDbConnection conexaodb = new OleDbConnection(conexaoAccess);

            try
            {
                conexaodb.Open();

                string query = "INSERT INTO tbProduto (cId, cNome, cPreco) VALUES (@IdProduto,@Nome,cPreco)";
                OleDbCommand cmd = new OleDbCommand(query, conexaodb);

                // Parâmetro para o ID
                var pmtIdProduto = cmd.CreateParameter();
                pmtIdProduto.ParameterName = "@IdProduto";
                pmtIdProduto.DbType = DbType.Int32; // Use DbType.Int32 se IdProduto for um número inteiro
                pmtIdProduto.Value = _MdlProduto.IdProduto; // Corrigido para usar IdProduto
                cmd.Parameters.Add(pmtIdProduto);

                // Parâmetro para o Nome
                var pmtNome = cmd.CreateParameter();
                pmtNome.ParameterName = "@Nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = _MdlProduto.Nome;
                cmd.Parameters.Add(pmtNome);

                // Parâmetro para o Preco
                var pmtPreco = cmd.CreateParameter();
                pmtPreco.ParameterName = "@Preco";
                pmtPreco.DbType = DbType.Decimal;
                pmtPreco.Value = _MdlProduto.Preco;
                cmd.Parameters.Add(pmtPreco);

                // Executa o comando de inserção
                if (cmd.ExecuteNonQuery() > 0)
                {
                    conexaodb.Close();
                    return true;
                }
                else
                {
                    conexaodb.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conexaodb.Close();
                throw new Exception("Erro ao cadastrar produto: " + ex.Message);
            }
            finally
            {
                conexaodb.Close();
            }
        }
        public bool Excluir(MdlProduto _MdlProduto)
        {
            string conexaoAccess = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\robso\source\repos\Marketplace\dbMarketplace.accdb";

            OleDbConnection conexaodb = new OleDbConnection(conexaoAccess);

            try
            {
                conexaodb.Open();

                string query = "DELETE FROM tbProduto where cId = @IdProduto";
                OleDbCommand cmd = new OleDbCommand(query, conexaodb);

                // Parâmetro para o ID
                var pmtIdProduto = cmd.CreateParameter();
                pmtIdProduto.ParameterName = "@IdProduto";
                pmtIdProduto.DbType = DbType.Int32; // Use DbType.Int32 se IdProduto for um número inteiro
                pmtIdProduto.Value = _MdlProduto.IdProduto; // Corrigido para usar IdProduto
                cmd.Parameters.Add(pmtIdProduto);

                // Parâmetro para o Nome
                var pmtNome = cmd.CreateParameter();
                pmtNome.ParameterName = "@Nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = _MdlProduto.Nome;
                cmd.Parameters.Add(pmtNome);

                // Executa o comando de inserção
                if (cmd.ExecuteNonQuery() > 0)
                {
                    conexaodb.Close();
                    return true;
                }
                else
                {
                    conexaodb.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conexaodb.Close();
                throw new Exception("Erro ao excluir produto: " + ex.Message);
            }
            finally
            {
                conexaodb.Close();
            }
        }
        public bool Atualizar(MdlProduto _MdlProduto)
        {
            string conexaoAccess = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\robso\source\repos\Marketplace\dbMarketplace.accdb";

            OleDbConnection conexaodb = new OleDbConnection(conexaoAccess);

            try
            {
                conexaodb.Open();

                // Utiliza a instrução SQL UPDATE para atualizar os dados
                string query = "UPDATE tbProduto SET cNome = @Nome, cPreco = @Preco WHERE cId = @IdProduto";
                OleDbCommand cmd = new OleDbCommand(query, conexaodb);

                // Parâmetro para o Nome
                var pmtNome = cmd.CreateParameter();
                pmtNome.ParameterName = "@Nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = _MdlProduto.Nome;
                cmd.Parameters.Add(pmtNome);

                // Parâmetro para o Preco
                var pmtPreco = cmd.CreateParameter();
                pmtPreco.ParameterName = "@Preco";
                pmtPreco.DbType = DbType.Int32;
                pmtPreco.Value = _MdlProduto.Preco;
                cmd.Parameters.Add(pmtPreco);

                // Parâmetro para o ID
                var pmtIdProduto = cmd.CreateParameter();
                pmtIdProduto.ParameterName = "@IdProduto";
                pmtIdProduto.DbType = DbType.Int32; // Use DbType.Int32 se IdProduto for um número inteiro
                pmtIdProduto.Value = _MdlProduto.IdProduto;
                cmd.Parameters.Add(pmtIdProduto);

                // Executa o comando de atualização
                if (cmd.ExecuteNonQuery() > 0)
                {
                    conexaodb.Close();
                    return true;
                }
                else
                {
                    conexaodb.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conexaodb.Close();
                throw new Exception("Erro ao atualizar produto: " + ex.Message);
            }
            finally
            {
                conexaodb.Close();
            }
        }
        public List<MdlProduto> Consultar(MdlProduto _MdlProduto)
        {
            string conexaoAccess = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\robso\source\repos\Marketplace\dbMarketplace.accdb";

            OleDbConnection conexaodb = new OleDbConnection(conexaoAccess);
            List<MdlProduto> _lstMdlProduto = new List<MdlProduto>();

            try
            {
                conexaodb.Open();

                string query = "SELECT * FROM tbProduto WHERE cId = @IdProduto";
                OleDbCommand cmd = new OleDbCommand(query, conexaodb);

                // Parâmetro para o ID
                var pmtIdProduto = cmd.CreateParameter();
                pmtIdProduto.ParameterName = "@IdProduto";
                pmtIdProduto.DbType = DbType.Int32; // Use DbType.Int32 se IdProduto for um número inteiro
                pmtIdProduto.Value = _MdlProduto.IdProduto;
                cmd.Parameters.Add(pmtIdProduto);

                OleDbDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    MdlProduto produto = new MdlProduto();
                    produto.IdProduto = rd.GetString(0);
                    produto.Nome = rd.GetString(1);
                    _lstMdlProduto.Add(produto);
                }
                return _lstMdlProduto;

            }
            catch (Exception ex)
            {
                conexaodb.Close();
                throw new Exception("Erro ao consultar dados do produto: " + ex.Message);
            }
            finally
            {
                conexaodb.Close();
            }
        }
    }
}