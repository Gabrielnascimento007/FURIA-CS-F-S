namespace ChatBot_Furia.Service;

public class TabelaService
{
    public static string ObterTabelasJogos()
    {
        return "*🎯 Próximos jogos da FURIA:*\n\n" +
               "```" +
               " Data   | Hora | Adversário | Evento             \n" +
               "-----------------------------------------------\n" +
               "06/05   | 18h  | Liquid     | IEM Dallas 2025    \n" +
               "10/05   | 15h  | Cloud9     | IEM Dallas 2025    \n" +
               "13/05   | 20h  | Heroic     | Blast Premier      \n" +
               "17/05   | 14h  | MOUZ       | Blast Premier      " +
               "```";
    }
}
