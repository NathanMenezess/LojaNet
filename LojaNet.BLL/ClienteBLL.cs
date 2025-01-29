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

        public void Alterar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Excluir(string Id)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nome))
            {
                throw new Exception("O nome deve ser informado!");
            }
            if(string.IsNullOrEmpty(cliente.Id))
            {
                //Gera ID
                cliente.Id = Guid.NewGuid().ToString();
            }
            var dal = new ClienteDAL();
            dal.Incluir(cliente);


        }

        public Cliente ObterPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorId(string id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
