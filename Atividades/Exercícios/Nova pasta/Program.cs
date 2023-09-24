using System.Collections;
using System.Text;
// Criar uma Hashtable para armazenar nome e CPF
Hashtable dicionario = new Hashtable();

// Criar uma variável para controlar o loop
string Continuar;

// Exibir uma mensagem de boas-vindas
Console.WriteLine("Cadastramento de nome e CPF");

// Iniciar um loop infinito
while(true)
{
    // Perguntar ao usuário se ele quer continuar
    Console.Write($"Você quer continuar [s/n] : ");
    Continuar=Console.ReadLine();

    // Se o usuário digitar "n", sair do loop
    if(Continuar=="n"){
        break;
    }
    // Se o usuário digitar "s", prosseguir com o cadastro
    else if (Continuar == "s")
    {
        // Perguntar ao usuário o nome
        Console.Write("Informe um nome :");
        string nome = Console.ReadLine();

        // Verificar se o nome já existe na tabela
        if (dicionario.ContainsKey($"{nome}")){
            // Se sim, exibir uma mensagem de erro e voltar ao início do loop
            Console.WriteLine("Nome duplicado. Não podemos realizar o cadastro. Tente novamente.");
            continue;
        }
        // Se não, prosseguir com o cadastro
        else{
            // Criar um array de inteiros para armazenar o CPF
            int[] CPF=new int[11];

            // Perguntar ao usuário o CPF
            Console.Write("Informe um CPF :");
            string tela= Console.ReadLine();

            // Verificar se o CPF tem 11 dígitos
            if (tela.Length != 11)
            {
                // Se não, exibir uma mensagem de erro e voltar ao início do loop
                Console.WriteLine("CPF inválido. Deve ter 11 dígitos. Tente novamente.");
                continue;
            }
            
            // Usar um loop for para converter cada dígito do CPF em um inteiro e armazená-lo no array
            for (int i = 0; i < 11; i++)
            {
                // Usar o método TryParse para tentar converter o dígito em um inteiro
                bool success = int.TryParse(tela[i].ToString(), out CPF[i]);

                // Verificar se a conversão foi bem-sucedida
                if (!success)
                {
                    // Se não, exibir uma mensagem de erro e voltar ao início do loop
                    Console.WriteLine("CPF inválido. Deve conter apenas números. Tente novamente.");
                    break;
                }
            }

            // Adicionar o par nome/CPF na tabela Hash
            dicionario.Add(nome, CPF);
        }
    }
    // Se o usuário digitar algo diferente de "s" ou "n", exibir uma mensagem de erro e voltar ao início do loop
    else 
    {
        Console.WriteLine("Opção inválida. Digite s ou n.");
    }
    
}

// Exibir uma mensagem de despedida
Console.WriteLine("Obrigado por usar o nosso programa.");

// Percorrer a tabela Hash e exibir os dados na tela usando um foreach
foreach (DictionaryEntry de in dicionario)
{
    // Obter a chave (nome) e o valor (CPF) da entrada atual
    string nome = (string)de.Key;
    int[] CPF = (int[])de.Value;

    // Converter o array de inteiros em uma string usando um loop for e um StringBuilder
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < 11; i++)
    {
        sb.Append(CPF[i]);
    }
    string cpf = sb.ToString();

    // Exibir o nome e o CPF formatados na tela
    Console.WriteLine($"{nome} - {cpf.Substring(0,3)}.{cpf.Substring(3,3)}.{cpf.Substring(6,3)}-{cpf.Substring(9,2)}");
}
