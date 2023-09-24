using System;
using System.Diagnostics;
using System.Reflection.Metadata;
using Microsoft.VisualBasic;

struct Fifo()
{
    static readonly int Max=100;
    object[] queue =new object[Max];

    int Topo=-1;

    public bool IsEmpty(){
        if(Topo<0){
            Console.WriteLine("A fila está vazia");
            return true;
        }
        return false;
    }

    public object Enqueue(object inserir){
        if(Topo>=Max +1){
            Console.WriteLine("A fila está cheia.Infelizmente não podemos adicionar ");
            return Topo;
        }
        Topo++;
        queue[Topo]=inserir;
        return inserir;
    }  

    public object Dequeue(){
        if(Topo<0){
            Console.WriteLine("A fila está vazia , não podemos pedir pra seguir");
            return null;
        }
        var valor = queue[0];

        for (int i = 1; i < Topo; i++)
        {
            queue[i - 1] = queue[i];
        }

        Topo--;

        return valor;
    }

    public void Peek(){
         if(Topo<0){
            Console.WriteLine("A fila está vazia , não podemos imprimir  ");
            return ;
        }
        Console.WriteLine($"O primeiro elemeto da fila é {queue[0]} ");
        return;    
    }

    public void PrintQueue(){
        Console.WriteLine("itens da fila");
       for(int i=0;i<=Topo;i++)
       {
        Console.WriteLine(queue[i]);
       }
        Console.WriteLine();
    }
}
class Program{
    static void Main(){
        Fifo Fila=new Fifo();
        Fila.Enqueue("paulo");
        Fila.Enqueue("mario");
        Fila.Enqueue(114);
        Fila.Peek();
        Fila.PrintQueue();
        Fila.Dequeue();
        Fila.Peek();


    }
}