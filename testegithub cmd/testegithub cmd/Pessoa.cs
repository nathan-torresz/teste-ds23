using System;
using System.Collections.Generic;
using System.Text;

namespace testegithub_cmd
{
    class Pessoa
    {
        private string _nome;
        private int _cpf;
        private int _rg;
        private int idade;

        public string nome { get => _nome; set => _nome = value; }
        public int cpf { get => _cpf; set => _cpf = value; }
        public int rg { get => _rg; set => _rg = value; }
        public int Idade { get => idade; set => idade = value; }



    }
}
