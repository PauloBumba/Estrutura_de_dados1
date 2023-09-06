using System;
class Program
{
    static void Main(){
        int[] vetor =new int[]{1,2,3,4,5,6,7,8,9,0};
        foreach(int c in vetor)
        {
            //Console.WriteLine("O vetor contém "+vetor.Length+"elemento");
            Console.WriteLine($"[vetor{c}] = {vetor[c]}");
        }

         Console.WriteLine("O vetor contém "+vetor.Length +  "elemento");















    }
}
