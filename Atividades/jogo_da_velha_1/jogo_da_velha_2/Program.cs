using System;

class jogo_da_velha{
    static void Main()
    {
        while(true)
        {
            int[,] matriz=new int[3,3];
            int valor=0;
            Console.WriteLine("-------------------");
            Console.WriteLine("   JOGO DA VELHA PAULO BUMBA ");
            Console.WriteLine("-------------------");
            for(int i=0;i<matriz.GetLength(0);i++)
            {
                for(int j=0;j<matriz.GetLength(1);j++)
                {
                    
                    Console.Write("informe o valor da jogada na posição["+i+";"+j+"] da matriz [entre [{0 e 1}]]");
                    string str= Console.ReadLine();
                    int.TryParse(str,out valor);
                    if (valor!=0 && valor!=1)
                    {
                        Console.WriteLine(" tente novamente");
                    }
                    else
                    {  
    
                            matriz[i,j]=valor;
                            Console.WriteLine(" A sua jogada foi valida ");
                        
                    }

                    }    
                }
            }
            if (matriz[0, 0] == matriz[0, 1] && matriz[0, 1] == matriz[0, 2] )
            {
                Fim(valor);
                Imprimir_matriz(matriz);
                Console.Write("vetoria na linha 1");
                
                break;
            }
            else if (matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2] )
            {
                Imprimir_matriz(matriz);
                Console.Write("vetoria na linha 2");
                Fim(valor);
                
                break;
            }
            else if (matriz[2, 0] == matriz[2, 1] && matriz[2, 1] == matriz[2, 2])
            {
                Imprimir_matriz(matriz);
                Console.Write("vetoria na linha 3");
                Fim(valor);
                break;
            }
            else if (matriz[0, 0] == matriz[1, 0] && matriz[1, 0] == matriz[2, 0] )
            {
                Console.Write("vetoria na coluna1");
                Imprimir_matriz(matriz);
                Fim(valor);
                break;
            }
            

            else if (matriz[0, 1] == matriz[1, 1] && matriz[1, 1] == matriz[2, 1] )
            {
                Imprimir_matriz(matriz);
                Console.Write("vetoria na coluna2");
                Fim(valor);
                break;
            }
            
            else if (matriz[0, 2] == matriz[1, 2] && matriz[1, 2] == matriz[2, 2])
            {
                Imprimir_matriz(matriz);
                Console.Write("vetoria na coluna3");
                Fim(valor);
                break;
            }
            
            else if  (matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2] )
            {
                Imprimir_matriz(matriz);
                Console.Write("vetoria na diagonal1");
                Fim(valor);
                break;
            }

            else if (matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0])
            {
                Imprimir_matriz(matriz);
                Console.Write("vetoria na diagonal2");
                Fim(valor);
                break;
            }

            else
            {
                Imprimir_matriz(matriz);
                Console.WriteLine("\n--------------");
                Console.WriteLine("Fim de Jogo!!!");
                Console.WriteLine("--------------");
                Console.WriteLine($"\nQue triste!!! Ninguém ganhou.");
                Console.WriteLine("tente novamente ");

            }
        }
    }
    static void Imprimir_matriz(int[,] matriz)
    {

        int cont=0;
       foreach (int elemento in matriz)
        {
            Console.Write($"[{elemento + " "}]"); 
            cont++; 
            if (cont % matriz.GetLength(1) == 0) 
            {
                Console.WriteLine(); 
            }
        }
        Console.WriteLine(); 

    }
    static void Fim() 
    {
        Console.WriteLine("\n--------------");
        Console.WriteLine($"\nParabéns!!! ")
        Console.WriteLine("Fim de Jogo!!!");
        Console.WriteLine("--------------");
        //Console.WriteLine($"\nParabéns!!! ");
    }    
}   
    
    
    

    



    





















