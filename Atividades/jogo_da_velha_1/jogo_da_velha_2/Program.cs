using System;

class jogo_da_velha{
    static void Main()
    {
        while(true)
        {
            int[,] matriz=new int[3,3];
            int valor=0;
            int ultimo_jogador = 0; 
            Console.WriteLine("================================");
            Console.WriteLine("   JOGO DA VELHA PAULO BUMBA ");
            Console.WriteLine("-------------------==============");
            for(int i=0;i<matriz.GetLength(0);i++)
            {
                for(int j=0;j<matriz.GetLength(1);j++)
                {
                    
                    Console.Write("informe o valor da jogada na posição["+i+";"+j+"] da matriz [entre [{0 e 1}]]  :");
                    string str= Console.ReadLine();
                    int.TryParse(str,out valor);
                    if (valor!=0 && valor!=1)
                    {
                        Console.WriteLine(" A sua jogada não foi valida  ");
                        Console.WriteLine(" Tente novamente");
                    }
                    else
                    {  
    
                            matriz[i,j]=valor;
                            ultimo_jogador = valor; 
                            Console.WriteLine(" A sua jogada foi valida ");
                        
                    }

                    }    
                }
            
            if (ultimo_jogador == matriz[0, 0] && matriz[0, 0] == matriz[0, 1] && matriz[0, 1] == matriz[0, 2] )
            {
                Fim();
                Imprimir_matriz(matriz);
                Console.WriteLine("vitoria na linha 1");
                Console.WriteLine($"O jogador {ultimo_jogador} ganhou o jogo!"); 
                
                break;
            }
            else if (ultimo_jogador == matriz[1, 0] && matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2] )
            {
                Imprimir_matriz(matriz);
                Console.WriteLine("vitoria na linha 2");
                Console.WriteLine($"O jogador {ultimo_jogador} ganhou o jogo!"); 
                Fim();
                
                break;
            }
            else if (ultimo_jogador == matriz[2, 0] && matriz[2, 0] == matriz[2, 1] && matriz[2, 1] == matriz[2, 2])
            {
                Imprimir_matriz(matriz);
                Console.WriteLine("vitoria na linha 3");
                Console.WriteLine($"O jogador {ultimo_jogador} ganhou o jogo!"); 
                Fim();
                break;
            }
            else if (ultimo_jogador == matriz[0, 0] && matriz[0, 0] == matriz[1, 0] && matriz[1, 0] == matriz[2, 0] )
            {
                Imprimir_matriz(matriz);

                Console.WriteLine("vitoria na coluna_1");
                
                Console.WriteLine($"O jogador {ultimo_jogador} ganhou o jogo!"); 
                Fim();
                break;
            }
            

            else if (ultimo_jogador == matriz[0, 1] && matriz[0, 1] == matriz[1, 1] && matriz[1, 1] == matriz[2, 1] )
            {
                Imprimir_matriz(matriz);
                Console.WriteLine("vitoria na coluna_2");
                Console.WriteLine($"O jogador {ultimo_jogador} ganhou o jogo!"); 
                Fim();
                break;
            }
            
            else if (ultimo_jogador == matriz[0, 2] && matriz[0, 2] == matriz[1, 2] && matriz[1, 2] == matriz[2, 2])
            {
                Imprimir_matriz(matriz);
                Console.WriteLine("vitoria na coluna_3");
                Console.WriteLine($"O jogador {ultimo_jogador} ganhou o jogo!"); 
                Fim();
                break;
            }
            
            else if (ultimo_jogador == matriz[0, 0] && matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2])
            {
                Imprimir_matriz(matriz);
                Console.WriteLine("vitoria na diagonal_1");
                Console.WriteLine($"O jogador {ultimo_jogador} ganhou o jogo!"); 
                Fim();
                break;
            }

            else if (ultimo_jogador == matriz[0, 2] && matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0])
            {
                Imprimir_matriz(matriz);
                Console.WriteLine("vitoria na diagonal_2");
                Console.WriteLine($"O jogador {ultimo_jogador} ganhou o jogo!"); 
                Fim();
                break;
            }

            else
            {
                Imprimir_matriz(matriz);
                Console.WriteLine("\n--------------");
                Console.WriteLine("Foi um empate !!!");
                Console.WriteLine("--------------");
                Console.WriteLine($"\nQue triste!!! Ninguém ganhou.");
                Console.WriteLine("Tente novamente ");

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
        Console.WriteLine($"\nParabéns!!! ");
        Console.WriteLine("Fim de Jogo!!!");
        Console.WriteLine("--------------");
        
    }    
}   

