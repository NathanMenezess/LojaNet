using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LojaNet.Models;
using LojaNet.DAL;

namespace LojaNet.BLL
{
    public class ClienteBLL : IClienteDados
    {

        //Busineess Logic Layer
        //serve para ver se ele e valido
        //tipo: se o campo nome ou email estao preenchidos

        private ClienteDAL dal;

        public ClienteBLL()
        {
            this.dal = new ClienteDAL();
        }


        public void Alterar(Cliente cliente)
        {
            Validar(cliente);

            if (string.IsNullOrEmpty(cliente.Id))
            {
                //checa se o ID foi infomado
                throw new Exception("O ID deve ser informado!");
            }

            dal.Alterar(cliente);
        }

        public void Excluir(string Id)
        {
            if (string.IsNullOrEmpty(Id))
            {
                //checa se o ID foi infomado
                throw new Exception("O ID deve ser informado!");
            }
            dal.Excluir(Id);
        }

        public void Incluir(Cliente cliente)
        {
            Validar(cliente);
            if (string.IsNullOrEmpty(cliente.Id))
            {
                //Gera ID
                cliente.Id = Guid.NewGuid().ToString();
            }
            dal.Incluir(cliente);


        }

        private static void Validar(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nome))
            {
                throw new Exception("O nome deve ser informado!");
            }
        }

        public Cliente ObterPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorId(string id)
        {
            return dal.ObterPorId(id);

        }

        public List<Cliente> ObterTodos()
        {

            var lista = dal.ObterTodos();
            return lista;
        }
    }
}
