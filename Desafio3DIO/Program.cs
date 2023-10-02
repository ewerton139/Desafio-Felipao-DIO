using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero guerreiro = new Hero("Yuusha", 20, "guerreiro");
            guerreiro.Atacar(guerreiro.tipo);

            Hero mago = new Hero("Yuusha", 20, "mago");
            mago.Atacar(mago.tipo);

            Hero monge = new Hero("Yuusha", 20, "monge");
            guerreiro.Atacar(monge.tipo);

            Hero ninja = new Hero("Yuusha", 20, "ninja");
            ninja.Atacar(ninja.tipo);

            Console.ReadLine();
        }
    }
}
