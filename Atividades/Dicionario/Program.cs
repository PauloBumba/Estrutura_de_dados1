using System.Collections;
using System.ComponentModel;

//Criar Hashtable
Hashtable openWith = new Hashtable();

openWith.Add("txt","notepad++.exe");
openWith.Add("bmp","paint.exe");
openWith.Add("dib","paint.exe");
openWith.Add("rtf","wordpad.exe");

try
{
    openWith.Add("txt","notepad++.exe");
}

catch(ArgumentException aex)
{
    Console.WriteLine("você tentou adicionar uma chave que já existe ");
    Console.WriteLine($"Detalhes:{aex.Message}");
}
catch(Exception ex){
    Console.WriteLine("Erro Generico");
    

}
Console.WriteLine(" Na chave = \"rtf\"  é {0} ",openWith["rtf"] );
Console.WriteLine("Programa em Execução");

//Aterando o conteúdo da tabela Hash
openWith["rtf"]="winWord.Exe";
Console.WriteLine(" Na chave = \"rtf\"  é {0} ",openWith["rtf"] );

//testar sem  a chave existe na hash
if (!openWith.ContainsKey("ht")){
    openWith.Add("ht","hypertrm.Exe");
    Console.WriteLine("chave ht adicionada");
    
}
//percorrendo Hash com foreach
Console.WriteLine();
foreach (DictionaryEntry de in openWith)
{
    Console.WriteLine("key = {0}- value={1}",de.Key,de.Value);
}
openWith["paulo"]="bumba";
Console.WriteLine(" Na chave = \"paulo\"  é {0} ",openWith["paulo"] );

//obtendo os valores do hash
ICollection valueCol=openWith.Values;
Console.WriteLine();
foreach(var s in valueCol){
    Console.WriteLine("Value={0}",s);

}