using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace script
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dataAtual  = DateTime.Now;
            Console.WriteLine(dataAtual.ToString());

            Console.WriteLine("Nos informe seu nick/nome");
            string nome = Console.ReadLine();
            Console.WriteLine(nome + " Painel liberado com sucesso.");

            string[] filmes  = {"Batman","Homem Aranha","Divertidamente"};
            foreach (string filme in filmes)
            {
             Console.WriteLine("Filmes disponiveis: " +filme);
            }
            Console.WriteLine("Escolha um filme nas tecla 1,2,3");
            string opcao = Console.ReadKey(true).KeyChar.ToString();
            if (opcao == "s" || opcao == "S")
            {
                Console.WriteLine("Você fechou o programa");
                Console.Clear();
                Console.WriteLine("Console fechado!");
            }
           
            string escolheu = Console.ReadKey(true).KeyChar.ToString().ToUpper();
            switch (escolheu)
            {
                case "1":
                    Console.WriteLine(nome + " Você escolheu - Homem Aranha");
                    break;
                    case "2":
                    Console.WriteLine(nome + " Você escolheu - Batman");
                    break;
                    case "3":
                    Console.WriteLine(nome + " Você escolheu - Divertidamente");
                    break;
                default:
                    Console.WriteLine(nome + " Tecla desconhecida");
                    break;
            }



            
            Console.ReadKey();
        }
    }
}


