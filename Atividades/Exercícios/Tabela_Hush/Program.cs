using System.Collections;
class Pro{
    static void Main()
    {
        Hashtable Cadastro = new Hashtable();

        string CPF,nome;
        

        while (true)
        {
                Console.WriteLine("castramento de Cpf e nome");
                Console.WriteLine( );
                Console.Write("Você quer continuar a cadastrar [s/n] :");
                string continuar =Console.ReadLine();
                if(continuar=="n"){
                    break;
                }
                else if (continuar=="s")
                {
                    Console.Write("Iforme um CPF :");
                    CPF =Console.ReadLine();
                    try{
                            Cadastro.ContainsKey($"{CPF}");
                    }

                    catch
                    {

                        Console.WriteLine("CPF duplicado. Não podemos realizar o cadastro. Tente novamente.");
                        continue;
                    }
                    
                        
                    else if (CPF.Length != 11)
                    {
                        Console.WriteLine("CPF inválido. Deve ter 11 dígitos. Tente novamente.");
                        continue;
                    }
                    else
                    {
                        
                        Console.Write("Iforme um nome :");
                        nome =Console.ReadLine();
                        
                
                    }
                    
                    
        
    
                    Cadastro.Add(CPF, nome);

                }
                
                else
                {
                    Console.WriteLine("Opção errada digite [s/n]");
                }

            }
    foreach (DictionaryEntry de in Cadastro)
    {   
        Console.WriteLine("CPF  = {0}  - Nome={1}",de.Key,de.Value);
    }
     
    }
}


