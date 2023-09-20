using System;
using System.Collections;

namespace QueueClass
{
    public class Queue
    {
        static readonly int MAX = 1000;
        int top = -1;
        int [] fila = new int [MAX]; 

        public bool IsEmpty()
        {
            return (top < 0);
                        
        }

        public bool Enqueue(int data)
        {
            if(top >=MAX )
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            top += 1;
            fila[top] = data;
            return true;
        }

        public  int Dequeue() 
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                
            }

            int valor = fila[top];            
            top++;
            return valor;
            
        }

        public  void Peek()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }

            Console.WriteLine("O primeiro elemento da fila é {0}.", fila[top]);
            top++;
        }

        public void  PrintFila()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");

            }

            Console.WriteLine("Itens da pilha:");
            for(int i =0 ; i >= top; i++ )
            {
                string texto = $"fila  [{ fila[i] }]";
                Console.WriteLine(texto);
            }
        }
    }
}

