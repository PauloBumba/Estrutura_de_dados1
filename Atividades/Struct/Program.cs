using System;

struct Cachoros
{
    string cor;
    string nome;
    int idade ;
    double tamanho;
    public void Construtor(string cor,string nome,int idade,double tamanho){
        this.cor=cor;
        this.nome=nome;
        this.idade=idade;
        this.tamanho=tamanho;

    }
    
    public void Print(){
        Console.WriteLine("cor ...{0}",cor);
        Console.WriteLine("nome ...{0}",nome);
        Console.WriteLine("idade ...{0} anos",idade);
        Console.WriteLine("tamanho ...{0}",tamanho);
        
    }
    public void correr(){
            Console.WriteLine($"{nome} esta correndo");
        }
}
class Program{
    static void Main()
    {
        Construtor c1 =new Construtor("preto","paulo",3,4.5);
        c1.Print();
        c1.correr();
        
       
    }
}
