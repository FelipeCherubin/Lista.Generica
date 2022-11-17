using System;

namespace ListaGenerica
{
    public class ListaManual<T>
    {
        private T[] ItemLista;

        public ListaManual()
        {
            ItemLista = new T[0];
        }

        public void Add(T novoItem)
        {
            T[] novosItens = new T[ItemLista.Length + 1];
            for (int index = 0; index < ItemLista.Length; index++)
                novosItens[index] = ItemLista[index];
            novosItens[novosItens.Length - 1] = novoItem;
            ItemLista = novosItens;
        }

        public int Count()
            => ItemLista.Length;

        public void PrintItens()
        {
            foreach (T t in ItemLista)
                Console.WriteLine(t);

            Console.WriteLine($"Total de itens na lista: {Count()}");
        }
    }
}
