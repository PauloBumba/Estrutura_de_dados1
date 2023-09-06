using System;

class Arrays{
    static void Main(){
        int[] vetor =new int[10];
        for(int i=0;i<vetor.Length;i++)
        {
            Console.Write("informe um valor na posição  ["+ i + "] na posição:" );
            string str=Console.ReadLine();
            int.TryParse(str, out int valor);
            vetor[i]=valor;

        }
        int total=0;
        foreach(int soma in vetor){
            total+=soma;
        }
        Array.Sort(vetor);
        for (int i=0;i<vetor.Length;i++){
            Console.WriteLine(vetor[i]+ "a sua soma e ="+total);
        }















    }








}