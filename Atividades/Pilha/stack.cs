using System;

namespace StackClass
{
    public class Stack
    {
       static  readonly int MAX=1000;
        int top=-1;
        int [] stack =new int[MAX];

        public bool IsEmply()
        {
            return (top<0);

        }
        public bool Push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("stack overflow");
                return false;
            }
            else 
            {
                top=+1;
                stack[top]=data;
                return true;
            }
        }
        public int Pop()
        {
            if (top<0)
            {
                Console.WriteLine("stack underflow");
                return 0;
            }
    
            int valor=stack[top];
            top-=1;
            return valor ;
        }
        public void Peek(){
            if (top<0)
            {
                Console.WriteLine("stack UnderFlow");
                return;
            }
            Console.WriteLine($"O topo daa pilha é : {stack[top]}");
            return;
        }
        public void Printstack()
        {
            if (top<0)
            {
                Console.WriteLine("stack UnderFlow");
                return;
            }
            Console.WriteLine("ntes da pilha : ");
            for(int i=top;i>=0;i--)
            {
                string texto=$"Stack[{stack[i]}]";
                Console.WriteLine(texto);
            }
        }
    }

}


