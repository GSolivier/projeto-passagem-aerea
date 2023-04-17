//Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

//Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
//O sistema deve exibir um menu com as seguintes opções:

//1- Cadastrar passagem
//2- Listar Passagens
//0- Sair

static bool VerificadorSenha(string senhaC, string senhaU){

    // return bool.Parse(senhaC = senhaU);
    if (senhaC == senhaU)
    {
        return true;
    }
    else
    {
        return false;
    }
}

string password = "admin123";
string senhaUser;
bool loopBreak = true;



Console.WriteLine(@$"

        BEM VINDO AO TurismoAirLines!
        
    Esse é o nosso programa de cadastramento
            automático de passagens.

    Digite a senha para desbloquear o acesso:    
        ");

do
{
senhaUser = Console.ReadLine();

if (VerificadorSenha(password, senhaUser))
{
    Console.Clear();
    Console.WriteLine($"Senha Correta");
    Console.WriteLine($"Aguarde...");
    Thread.Sleep(5000);
    Console.Clear();
    loopBreak = false;
}

else{
    Console.Clear();
    Console.WriteLine($"Senha incorreta, tente novamente");
    Console.WriteLine();
    Console.WriteLine($"Digite a senha para desbloquear o acesso: ");
    loopBreak = true;
}
    
} while (loopBreak);        


Console.Write($"Carregando informações");

for (var i = 0; i < 6; i++)
{
    Console.Write($".");
    Thread.Sleep(800);
}

Console.WriteLine(@$"
           MENU INICIAL
    
    Digite o número correspondente
    do serviço que deseja utilizar:

        1 - Cadastrar Passagem
        2 - Listar passagens
        0 - Fechar programa  
");
