using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace ChatBot_Furia.Service;

public static class QuizService
{
    private static readonly List<(string pergunta, string[] opcoes, int correta, string explicacao)> perguntasQuiz = new()
{
    ("Quem é o IGL da FURIA?", new[] { "chelo", "arT", "FalleN", "KSCERATO" }, 2, "✅ FalleN é o In-Game Leader da FURIA!"),
    ("Qual jogador é conhecido por jogadas agressivas?", new[] { "molodoy", "FalleN", "KSCERATO", "yuurih" }, 1, "✅ FalleN é conhecido por liderar com proatividade e agressividade!"),
    ("Em que ano a FURIA foi fundada?", new[] { "2014", "2016", "2017", "2019" }, 2, "✅ A FURIA foi fundada em 2017!"),
    ("Qual evento a FURIA chegou na semifinal em 2022?", new[] { "PGL Antwerp", "ESL Cologne", "Major Rio", "IEM Katowice" }, 2, "✅ Foi no Major do Rio de Janeiro!"),
    ("Quem é o AWPer principal da FURIA?", new[] { "yuurih", "molodoy", "FalleN", "YEKINDAR" }, 2, "✅ FalleN é o principal AWPer da FURIA!"),
    ("Qual é o país de origem da FURIA?", new[] { "Brasil", "Portugal", "Argentina", "Espanha" }, 0, "✅ A FURIA é do Brasil!"),
    ("Quem é o fundador da FURIA?", new[] { "FalleN", "André Akkari", "arT", "KSCERATO" }, 1, "✅ André Akkari é um dos fundadores!"),
    ("Em qual plataforma a FURIA estreou no CS:GO?", new[] { "ESL", "Gamers Club", "FACEIT", "CEVO" }, 2, "✅ A FURIA começou jogando pela FACEIT!"),
    ("Qual estilo de jogo a FURIA é conhecida?", new[] { "Passivo", "Agressivo", "Tático", "Padrão" }, 1, "✅ A FURIA é famosa pelo estilo ultra agressivo!"),
    ("Quantos jogadores formam o time principal da FURIA?", new[] { "4", "5", "6", "7" }, 1, "✅ O time oficial tem 5 jogadores."),
    ("Quem é o capitão da FURIA?", new[] { "chelo", "yuurih", "FalleN", "molodoy" }, 2, "✅ FalleN é o capitão do time."),
    ("Qual o mascote da FURIA?", new[] { "Pantera", "Tigre", "Leão", "Lobo" }, 0, "✅ O símbolo da FURIA é a Pantera!")
};

    public static async Task EnviarQuiz(ITelegramBotClient bot, long chatId, CancellationToken ct)
    {
        var random = new Random();
        var perguntasSelecionadas = perguntasQuiz
            .OrderBy(_ => random.Next())
            .Take(5)
            .ToList();

        foreach (var pergunta in perguntasSelecionadas)
        {
            await bot.SendPollAsync(
                chatId: chatId,
                question: pergunta.pergunta,
                options: pergunta.opcoes,
                type: PollType.Quiz,
                correctOptionId: pergunta.correta,
                isAnonymous: false,
                explanation: pergunta.explicacao,
                cancellationToken: ct
            );

            await Task.Delay(1000, ct);
        }
    }
}
