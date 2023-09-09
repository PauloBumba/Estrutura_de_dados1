using System;

namespace System.Collections{
    class StackClass{
    
    public static void EscreverMenu(){
    
    Console.WriteLine();
    Console.WriteLine("----Seja bem-vindo ao nosso programa! Informe as opções abaixo:---");
    Console.WriteLine("➡ 1 - Sair do programa");
    Console.Write("   ");
    Console.WriteLine("➡ 2 - Verificar se a pilha está vazia");
    Console.Write("   ");
    Console.WriteLine("➡ 3 - Empilhar");
    Console.Write("   ");
    Console.WriteLine("➡ 4 - Desempilhar");
    Console.Write("   ");
    Console.WriteLine("➡ 5 - Mostrar o topo da pilha");
    Console.Write("   ");
    Console.WriteLine("➡ 6 - Ver todos os elementos da pilha");
    Console.Write("   ");
    Console.WriteLine("➡ 7 - Consultar o número de elementos na pilha");
    Console.Write("   ");
    Console.WriteLine("➡ 8 - Limpar a pilha");
}

        public static void Main(){
            
            Stack Pilha=new Stack();
            int Menu_Command=0;
            
            while (Menu_Command!=1)
            
            {   Console.WriteLine("=============================================================");
                EscreverMenu();
                Console.WriteLine("=============================================================");
                Console.WriteLine();
                Console.Write($" Escolha as suas opções de [1 a 8] :  ");
                string Menu =Console.ReadLine();
                int.TryParse(Menu,out Menu_Command);
        
                switch (Menu_Command){
                    case 1:
                        Console.WriteLine("programa terminado");
                        break;
                    case 2:
                        if(Pilha.Count==0)
                        {
                            Console.WriteLine("pilha vazia");
                        }
                        else
                        {
                            Console.WriteLine(" pilha não vazia");
                        }

                        
                        break;
                    case 3:
                        Console.Write("informa o que você quer empilhar :  ");
                        string dado=Console.ReadLine();
                        Pilha.Push(dado);
                        break;
                    case 4:
                        if  (Pilha.Count == 0 )
                        {
                            Console.WriteLine("pilha vazia");
                        }
                        else 
                        {
                            Pilha.Pop();
                            Console.WriteLine(" removido com sucesso");
                        }
                        break;
                    case 5:
                        if (Pilha.Count==0)
                        {
                            Console.WriteLine("pilha vazia não temos podemos mostrar o topo");
                        }
                        Console.WriteLine("O topo da pilha tem o valor de " + Pilha.Peek());
                        break;
                    case 6:
                        foreach (var item in Pilha)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 7:
                        var tamanho =0;
                        if (Pilha.Count==0){
                            Console.WriteLine("pilha vazia ");
                        }
                        else{
                            tamanho=Pilha.Count;
                            Console.WriteLine("A pilha tem "+ tamanho + "elementos");
                        }
                        break;
                    case 8:
                        Pilha.Clear();
                        Console.WriteLine("A pilha foi limpada com sucesso");
                        break;
                }
                
            }

        }
    }

}