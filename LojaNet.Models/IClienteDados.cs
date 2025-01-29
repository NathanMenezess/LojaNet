using System;
using System.Collections.Generic;
using System.Text;

namespace LojaNet.Models
{
    public interface IClienteDados
    {
        //Definir quias sao as regras de acesso a dados 
        void Incluir(Cliente cliente);
        void Alterar(Cliente cliente);
        void Excluir(string Id);
        List<Cliente> ObterTodos();
        Cliente ObterPorId(string id);
        Cliente ObterPorEmail(string email);

    }
}
