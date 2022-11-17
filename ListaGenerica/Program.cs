using System;

namespace ListaGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Simples exemplo de criação de uma lista generica de uma forma manual sem usar o System.Collections.Generic
             */
            ListaManual<string> listaManual = new();
            listaManual.Add(novoItem: "LP");
            listaManual.Add(novoItem: "David");
            listaManual.Add(novoItem: "Alê");
            listaManual.Add(novoItem: "Glauber");

            listaManual.PrintItens();


            ListaManual<int> listaManual1 = new();
            listaManual1.Add(novoItem: 1);
            listaManual1.Add(novoItem: 2);
            listaManual1.Add(novoItem: 3);

            listaManual1.PrintItens();

            Console.ReadLine();
        }
    }
}
