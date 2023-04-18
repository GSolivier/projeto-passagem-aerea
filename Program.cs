//Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

//Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
//O sistema deve exibir um menu com as seguintes opções:

//1- Cadastrar passagem
//2- Listar Passagens
//0- Sair

static bool VerificadorSenha(string senhaC, string senhaU)
{

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

static void BarraCarregamento(string carregando, int tempo, int pontos)
{

    Console.Write($"{carregando}");

    for ( var i = 0; i < pontos; i++)
    {
        Console.Write($".");
        Thread.Sleep(tempo);
    }
}

string[] nomePassageiro = new string[1000];
string[] origem = new string[1000];
string[] destino = new string[1000];
string[] dataVoo = new string[1000];

string password = "admin123";
string senhaUser;
bool loopBreak = true;
int escolhaMenu;
int escolhaCadastro;
bool sairCadastro = false;


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

    else
    {
        Console.Clear();
        Console.WriteLine($"Senha incorreta, tente novamente");
        Console.WriteLine();
        Console.WriteLine($"Digite a senha para desbloquear o acesso: ");
        loopBreak = true;
    }

} while (loopBreak);

BarraCarregamento("Carregando Informações", 800, 6 );


do
{
    startOfLoop:
Console.WriteLine(@$"
           MENU INICIAL
    
    Digite o número correspondente
    do serviço que deseja utilizar:

        1 - Cadastrar Passagem
        2 - Listar passagens
        0 - Fechar programa  
");
    escolhaMenu = int.Parse(Console.ReadLine());

    if (escolhaMenu == 1)
    {
        Console.Clear();
                    Console.WriteLine(@$"
        MENU DE CADASTRO DE PASSAGENS

    Aqui você irá cadastrar suas passagens.
    Informe todas as informações corretamente,
    para evitar eventuais problemas.
            ");
    


        for (var i = 0; i < origem.Length; i++)
        {
            Console.WriteLine($"Informe o nome do titular da passagem:");
            nomePassageiro [i] = Console.ReadLine();
            
            Console.WriteLine($"Informe a origem da sua viagem:");
            origem [i] = Console.ReadLine();
            
            Console.WriteLine($"Informe o destino da sua viagem:");
            destino [i] = Console.ReadLine();
            
            Console.WriteLine($"Informe a data do seu voo:");
            dataVoo [i] = Console.ReadLine();

            Console.Clear();

            Console.WriteLine(@$"
            Deseja cadastras mais alguma passagem?
            [1] - SIM
            [2] - Retornar para o menu
            ");
            escolhaCadastro = int.Parse(Console.ReadLine());
                // Console.WriteLine($"{nomePassageiro [i]} {origem [i]} {destino [i]} {dataVoo [i]}");

            if (escolhaCadastro == 2)
            {
                
                goto startOfLoop;
            }

            else{
                Console.WriteLine($"");  
            }
            
        }
    }

    else if(escolhaMenu == 2)
    {
        Console.WriteLine($"Aqui estão todas as suas passagens cadastradas:");

        for (var i = 0; i < origem.Length; i++){

            if (nomePassageiro[i] == null)
            {
                
                Console.WriteLine($"Sem mais passagens cadastradas........");
                goto endOfList;
                
            }
            
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");
            Console.WriteLine($"ID da passagem: #0{i + 1}2023");
            Console.WriteLine($"Nome do titular: {nomePassageiro[i]}");
            Console.WriteLine($"Origem da viagem: {origem[i]}");
            Console.WriteLine($"Destino da viagem: {destino[i]}");
            Console.WriteLine($"Data da viagem: {dataVoo[i]}");
            Console.WriteLine($"");
        }
        endOfList:
            Console.WriteLine($"O que deseja fazer?");
            Console.WriteLine($"[1] - retornar ao menu");
            Console.WriteLine($"[2] - sair");
    }
    
} while (loopBreak);