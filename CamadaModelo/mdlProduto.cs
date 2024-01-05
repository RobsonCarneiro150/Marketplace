using CamadaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelo
{
    public class MdlProduto
    {
        public string IdProduto { get; set; }
        public string Nome { get; set; }
        public string Preco { get; set; }
        public string Descrição { get; set; }
        public string Imagem { get; set; }
        public string Status { get; set; }
        public string Categoria { get; set; }
        public string Vendedor { get; set; }
    }

    public class MdlCliente
    {
        public int idCliente { get; set; }
        public string nome { get; set; }
        public long cpf { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string endereco { get; set; }
    }
    public class MdlCarrinho
    {
        public int idproduto { get; set; }
        public DateTime dataPedido { get; set; }
        public decimal valorTotal { get; set; }
        public int statusPedido { get; set; }
        public MdlCliente cliente { get; set; }
        public List<MdlProduto> produto { get; set; }
    }
    public class MdlVendedor
    {
        public int idVendedor { get; set; }
        public string razaoSocial { get; set; }
        public String nomeFantasia { get; set; }
        public string cnpj { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public decimal comissao { get; set; }
        public string endereco { get; set; }
    }
}