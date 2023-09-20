using System;
using System.Collections;

namespace QueueClass
{
    public class Queue
    {
        static readonly int MAX = 1000;
        int top = 0;
        string[] fila = new string[MAX]; 

        public bool IsEmpty()
        {
            return (top < 0);            
        }

        public bool Enqueue(string data)
        {
            if(top <=0 MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            top += 1;
            fila[top] = data;
            return true;
        }

        public string Dequeue() 
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return null;
            }

            while (fila.Count > 0)
            {
                string elemento = fila.Dequeue();
                Console.WriteLine("Removendo {0} da fila.", elemento);

            return valor;
        }

        public void Peek()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }

             Console.WriteLine("O primeiro elemento da fila é {0}.", fila.Peek());
        }

        public void PrintStack()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }

            Console.WriteLine("Itens da pilha:");
            for(int i =0 ; i <= top; i++ )
            {
                string texto = $"Stack[{ fila[i] }]";
                Console.WriteLine(texto);
            }
        }
    }
}
}