using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3DIO
{
    public class Hero
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public string tipo { get; set; }

        public Hero(string nome, int idade, string tipo)
        {
            this.nome = nome;
            this.idade = idade;
            this.tipo = tipo;
        }

        public void Atacar(string tipo)
        {
            string ataque = "";

            if (tipo == "guerreiro")
            {
                ataque = "usando espada";
            }
            else if (tipo == "mago")
            {
                ataque = "usando magia";
            }
            else if (tipo == "monge")
            {
                ataque = "usando artes marciais";
            }
            else if (tipo == "ninja")
            {
                ataque = "usando shuriken";
            }
            Console.WriteLine($"O {tipo} atacou {ataque}\n");
        }
    }
}
