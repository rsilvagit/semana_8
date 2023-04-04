﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banco_Dev.Models;
using Banco_Dev.Controllers;
using Banco_Dev.Interface;
using Banco_Dev.Service;

namespace Banco_Dev.Interface
{
    public interface IClienteService
    {
        void CriarConta(Cliente cliente);
        List<PessoaFisica> ExibirClientesPF();
        List<PessoaJuridica> ExibirClientesPJ();
        Cliente BuscarCliente(int id);
        Cliente AtualizarPessoaFisica(PessoaFisica pessoaFisica, int id);
        Cliente AtualizarPessoaJuridica(PessoaJuridica pessoaJuridica, int id);
        void DeletarCliente(int id);
        void AdicionarTransacao(Transacao transacao, int idCliente);
        List<Transacao> ListarTransacao(int idCliente);

    }
}