using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabalho1
{
    public class Filme
    {
        public string Nome;
        public string Genero;
        public string Local;
        public DateTime Data;

        public Filme(string nome, string genero, string local, DateTime data)
        {
            this.Nome = nome;
            this.Genero = genero;
            this.Local = local;
            this.Data = data;
        }
    }
}
