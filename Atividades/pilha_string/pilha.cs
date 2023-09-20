using System;

namespace StackClass
{
    public class Queue
    {
        static readonly int MAX = 1000;
        int top = -1;
        string[] stack = new string[MAX]; 

        public bool IsEmpty()
        {
            return (top < 0);            
        }

        public bool Push(string data)
        {
            if(top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            top += 1;
            stack[top] = data;
            return true;
        }

        public string Pop() 
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return null;
            }

            string valor = stack[top];            
            top--;

            return valor;
        }

        public void Peek()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }

            Console.WriteLine($"O topo da pilha é: {stack[top]}" );
        }

        public void PrintStack()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }

            Console.WriteLine("Itens da pilha:");
            for(int i = top; i >= 0; i-- )
            {
                string texto = $"Stack[{ stack[i] }]";
                Console.WriteLine(texto);
            }
        }
    }
}
