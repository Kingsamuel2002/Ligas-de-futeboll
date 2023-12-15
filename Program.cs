int menu;

int menu2;

Console.WriteLine("Selecione uma das opções abaixo");
Console.WriteLine();
Console.WriteLine("1- Inglaterra");
Console.WriteLine("2- Espanha");
Console.WriteLine("3- Itália");
Console.WriteLine("4- França");
Console.WriteLine("5- Alemanha");
Console.WriteLine("6- Arábia Saudita");
Console.WriteLine("7- Brasil");
Console.WriteLine();
Console.WriteLine("Selecione uma opção");
menu = Int32.Parse(Console.ReadLine());


Time arsenal = new Time();
arsenal.nome = "Arsenal";
arsenal.titulosNacionais = 29;

Time chelsea = new Time();
chelsea.nome = "Chelsea";
chelsea.titulosNacionais = 30; 

Time liverpool = new Time();
liverpool.nome = "liverpool";
liverpool.titulosNacionais = 52; 

Time Manchesterunited = new Time();
Manchesterunited.nome = "Manchester United";
Manchesterunited.titulosNacionais = 32;

Time Manchestercity = new Time();
Manchestercity.nome = "Manchester City";
Manchestercity.titulosNacionais = 30;

Time Tottenham = new Time();
Tottenham.nome = "Tottenham";
Tottenham.titulosNacionais = 21;

Time Astonvilla = new Time();
Astonvilla.nome = "Aston Villa";
Astonvilla.titulosNacionais = 20;

Time Nottinghamforest = new Time();
Nottinghamforest.nome = "Nottingham Forest";
Nottinghamforest.titulosNacionais = 8;

Time Atléticodemadrid = new Time();
Atléticodemadrid.nome = "Atlético de Madrid";
Atléticodemadrid.titulosNacionais = 23;

Time Barcelona = new Time();
Barcelona.nome = "Barcelona";
Barcelona.titulosNacionais = 72;

Time Realmadrid = new Time();
Realmadrid.nome = "Real Madrid";
Realmadrid.titulosNacionais = 67; 

Time Juventus = new Time();
Juventus.nome = "Juventus";
Juventus.titulosNacionais = 59;

Time Milan = new Time();
Milan.nome = "Milan";
Realmadrid.titulosNacionais = 31;

Time Intermilao = new Time();
Intermilao.nome = "Inter de Milão";
Intermilao.titulosNacionais = 35;

Time Roma = new Time();
Roma.nome = "Roma";
Roma.titulosNacionais = 14;

Time Napoli = new Time();
Napoli.nome = "Napoli";
Napoli.titulosNacionais = 11;

Time Lazio = new Time();
Lazio.nome = "Lazio";
Lazio.titulosNacionais = 14;

Time psg = new Time();
psg.nome = "PSG";
psg.titulosNacionais = 45;

Time Monaco = new Time();
Monaco.nome = "Monaco";
Monaco.titulosNacionais = 16;

Time Lyon = new Time();
Lyon.nome = "Lyon";
Lyon.titulosNacionais = 14;

Time Marselha = new Time();
Marselha.nome = "Marselha";
Marselha.titulosNacionais = 24;

Time Bayern = new Time();
Bayern.nome = "Bayern München";
Bayern.titulosNacionais = 69;

Time Borussia = new Time();
Borussia.nome = "Borussia Dortmund";
Borussia.titulosNacionais = 19;

Time Schalke04 = new Time();
Schalke04.nome = "Schalke 04";
Schalke04.titulosNacionais = 14;

Time Hamburgo = new Time();
Hamburgo.nome = "Hamburgo";
Hamburgo.titulosNacionais = 11;

Time AlHilal = new Time();
AlHilal.nome = "Al-Hilal";
AlHilal.titulosNacionais = 31;

Time AlNassr = new Time();
AlNassr.nome = "Al-Nassr";
AlNassr.titulosNacionais = 17;

Time AlAhli = new Time();
AlAhli.nome = "Al-Ahli";
AlAhli.titulosNacionais = 17;

Time AlIttihad = new Time();
AlIttihad.nome = "Al-Ittihad";
AlIttihad.titulosNacionais = 19;

Time SaoPaulo = new Time();
SaoPaulo.nome = "São Paulo";
SaoPaulo.titulosNacionais = 7;

Time Flamengo = new Time();
Flamengo.nome = "Flamengo";
Flamengo.titulosNacionais = 14;

Time Fluminense = new Time();
Fluminense.nome = "Fluminense";
Fluminense.titulosNacionais = 19;

Time vascodagama = new Time();
vascodagama.nome = "Vasco da gama";
vascodagama.titulosNacionais = 5;

Time Corinthians = new Time();
Corinthians.nome = "Corinthians";
Corinthians.titulosNacionais = 10;

Time Santos = new Time();
Santos.nome = "Santos";
Santos.titulosNacionais = 9;

Time Gremio = new Time();
Gremio.nome = "Gremio";
Gremio.titulosNacionais = 7;

Time Internacional = new Time();
Internacional.nome = "Internacional";
Internacional.titulosNacionais = 4;

Time Palmeiras = new Time();
Palmeiras.nome = "Palmeiras";
Palmeiras.titulosNacionais = 16;

Time AtléticoMG = new Time();
AtléticoMG.nome = "Atlético-MG";
AtléticoMG.titulosNacionais = 5;

Time Cruzeiro = new Time();
Cruzeiro.nome = "Cruzeiro";
Cruzeiro.titulosNacionais = 10;

Time  Botafogo = new Time();
Botafogo.nome = " Botafogo";
Botafogo.titulosNacionais = 2;


switch(menu) 
{
    case 1:
    Console.WriteLine("1 - Arsenal, 2- Chelsea, 3- Liverpool, 4- United, 5- City, 6- Tottenham, 7- Aston Villa, 8- Nottingham Forest");
    Console.WriteLine();
    Console.WriteLine("Selecione uma opção");
    menu2 = Int32.Parse(Console.ReadLine());
    switch(menu2) {
        case 1:
            Console.WriteLine(arsenal.nome);
            Console.WriteLine(arsenal.titulosNacionais);
            break;

            case 2:
                Console.WriteLine(chelsea.nome);
                Console.WriteLine(chelsea.titulosNacionais);
                break;

            case 3:
                Console.WriteLine(liverpool.nome);
                Console.WriteLine(liverpool.titulosNacionais);
                break;  

            case 4:
                Console.WriteLine(Manchesterunited.nome);
                Console.WriteLine(Manchesterunited.titulosNacionais);
                break;  

            case 5:
                Console.WriteLine(Manchestercity.nome);
                Console.WriteLine(Manchestercity.titulosNacionais);
                break;

            case 6:
                Console.WriteLine(Tottenham.nome);
                Console.WriteLine(Tottenham.titulosNacionais);
                break; 

            case 7:
                Console.WriteLine(Astonvilla.nome);
                Console.WriteLine(Astonvilla.titulosNacionais);
                break;

            case 8:
                Console.WriteLine(Nottinghamforest.nome);
                Console.WriteLine(Nottinghamforest.titulosNacionais);
                break;                       

    }

    break;

    case 2:
    Console.WriteLine("1- Atlético de Madrid,2- Barcelona,3- Real Madrid");
    Console.WriteLine();
    Console.WriteLine("Selecione uma opção");
    menu2 = Int32.Parse(Console.ReadLine());
    switch(menu2) {
     case 1:
            Console.WriteLine(Atléticodemadrid.nome);
            Console.WriteLine(Atléticodemadrid.titulosNacionais);
            break;

        case 2:
            Console.WriteLine(Barcelona.nome);
            Console.WriteLine(Barcelona.titulosNacionais);
            break;

        case 3:
            Console.WriteLine(Realmadrid.nome);
            Console.WriteLine(Realmadrid.titulosNacionais);
            break;        

    }
    break;

    case 3:
    Console.WriteLine("1- Juventus,2- Milan,3- Inter de Milão,4- Roma,5- Napoli ,6- Lazio");
    Console.WriteLine();
    Console.WriteLine("Selecione uma opção");
    menu2 = Int32.Parse(Console.ReadLine());
    switch (menu2)
    {
        
        case 1:
            Console.WriteLine(Juventus.nome);
            Console.WriteLine(Juventus.titulosNacionais);
            break;

            case 2:
                Console.WriteLine(Milan.nome);
                Console.WriteLine(Milan.titulosNacionais);
                break;

            case 3:
                Console.WriteLine(Intermilao.nome);
                Console.WriteLine(Intermilao.titulosNacionais);
                break;  

            case 4:
                Console.WriteLine(Roma.nome);
                Console.WriteLine(Roma.titulosNacionais);
                break;  

            case 5:
                Console.WriteLine(Napoli.nome);
                Console.WriteLine(Napoli.titulosNacionais);
                break;

            case 6:
                Console.WriteLine(Lazio.nome);
                Console.WriteLine(Lazio.titulosNacionais);
                break;    

    }

    break;

    case 4:
    Console.WriteLine("1- PSG,2- Monaco,3- Lyon,4- Marselha");
    Console.WriteLine();
    Console.WriteLine("Selecione uma opção");
    menu2 = Int32.Parse(Console.ReadLine());
    switch(menu2) {
        case 1:
            Console.WriteLine(psg.nome);
            Console.WriteLine(psg.titulosNacionais);
            break;

            case 2:
                Console.WriteLine(Monaco.nome);
                Console.WriteLine(Monaco.titulosNacionais);
                break;

            case 3:
                Console.WriteLine(Lyon.nome);
                Console.WriteLine(Lyon.titulosNacionais);
                break;  

            case 4:
                Console.WriteLine(Marselha.nome);
                Console.WriteLine(Marselha.titulosNacionais);
                break;  
    }
    break; 

    case 5:
    Console.WriteLine("1- Bayern München,2- Borussia Dortmund,3- Schalke 04,4- Hamburgo,");
    Console.WriteLine();
    Console.WriteLine("Selecione uma opção");
    menu2 = Int32.Parse(Console.ReadLine());
    switch(menu2) {
        case 1:
            Console.WriteLine(Bayern.nome);
            Console.WriteLine(Bayern.titulosNacionais);
            break;

            case 2:
                Console.WriteLine(Borussia.nome);
                Console.WriteLine(Borussia.titulosNacionais);
                break;

            case 3:
                Console.WriteLine(Schalke04.nome);
                Console.WriteLine(Schalke04.titulosNacionais);
                break;  

            case 4:
                Console.WriteLine(Hamburgo.nome);
                Console.WriteLine(Hamburgo.titulosNacionais);
                break;  
    }
    break;

    case 6:
    Console.WriteLine("1- Al-Hilal ,2- Al-Nassr ,3- Al-Ahli,4- Al-Ittihad");
    Console.WriteLine();
    Console.WriteLine("Selecione uma opção");
    menu2 = Int32.Parse(Console.ReadLine());
    switch(menu2) {
        case 1:
            Console.WriteLine(AlHilal.nome);
            Console.WriteLine(AlHilal.titulosNacionais);
            break;

            case 2:
                Console.WriteLine(AlNassr.nome);
                Console.WriteLine(AlNassr.titulosNacionais);
                break;

            case 3:
                Console.WriteLine(AlAhli.nome);
                Console.WriteLine(AlAhli.titulosNacionais);
                break;  

            case 4:
                Console.WriteLine(AlIttihad.nome);
                Console.WriteLine(AlIttihad.titulosNacionais);
                break; 
    }
    break;

    case 7:
    Console.WriteLine("1- São Paulo,2- Flamengo,3- Fluminense,4- Vasco da Gama,5- Corinthians,6- Santos,7- Gremio,8- Internacional,9- Palmeiras,10- Atlético-MG,11- Cruzeiro,12- Botafogo");
    Console.WriteLine();
    Console.WriteLine("Selecione uma opção");
    menu2 = Int32.Parse(Console.ReadLine());
    switch(menu2) {

       case 1:
            Console.WriteLine(SaoPaulo.nome);
            Console.WriteLine(SaoPaulo.titulosNacionais);
            break;

            case 2:
                Console.WriteLine(Flamengo.nome);
                Console.WriteLine(Flamengo.titulosNacionais);
                break;

            case 3:
                Console.WriteLine(Fluminense.nome);
                Console.WriteLine(Fluminense.titulosNacionais);
                break;  

            case 4:
                Console.WriteLine(vascodagama.nome);
                Console.WriteLine(vascodagama.titulosNacionais);
                break; 

                case 5:
                Console.WriteLine(Corinthians.nome);
                Console.WriteLine(Corinthians.titulosNacionais);
                break; 

            case 6:
                Console.WriteLine(Santos.nome);
                Console.WriteLine(Santos.titulosNacionais);
                break; 
            case 7:
                Console.WriteLine( Gremio.nome);
                Console.WriteLine( Gremio.titulosNacionais);
                break; 
            case 8:
                Console.WriteLine(Internacional.nome);
                Console.WriteLine(Internacional.titulosNacionais);
                break; 
            case 9:
                Console.WriteLine(Palmeiras.nome);
                Console.WriteLine(Palmeiras.titulosNacionais);
                break; 
            case 10:
                Console.WriteLine(AtléticoMG.nome);
                Console.WriteLine(AtléticoMG.titulosNacionais);
                break;
                case 11:
                Console.WriteLine(Cruzeiro.nome);
                Console.WriteLine(Cruzeiro.titulosNacionais);
                break; 
                case 12:
                Console.WriteLine(Botafogo.nome);
                Console.WriteLine(Botafogo.titulosNacionais);
                break;  
    }
    break;
}
