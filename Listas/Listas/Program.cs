using System;
using System.Collections.Generic; //serve para trabalhar com listas
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> clientes = new List<string>();
            clientes.Add("Pandoro");
            clientes.Add("Pacheco");
            string pessoa = "José";
            clientes.Add(pessoa);

            foreach(string cliente in clientes)//mostrar todos os itens
            {
                Console.WriteLine(cliente);
            }

            //string busca = clientes.Find(cliente => cliente == "Pandoro");
            //string busca = clientes.Find(cliente => cliente.Length > 4);//buscando na lista um nome que tenha mais do que 4 carctere
            List<string> filtragem = clientes.FindAll(cliente => cliente.Length < 5);//filtra todos da lista que sejam menor que 5
            Console.WriteLine("========");

            foreach(string cliente in filtragem)
            {
                Console.WriteLine(cliente);
            }

            /*clientes.RemoveAll( cliente => cliente == "Pandoro");//remove um item quando você não sabe a posição do item na lista

            clientes.RemoveAt(1);//remove o item pela posição
            Console.WriteLine("============");

            foreach (string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

            clientes[2] = "Crislaine"; //editar um item
            Console.WriteLine(clientes[2]);*/
            Console.ReadLine();

        }
    }
}
