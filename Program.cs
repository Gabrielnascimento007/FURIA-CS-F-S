using ChatBot_Furia.Exceptions;
using ChatBot_Furia.Service;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

var botClient = new TelegramBotClient("7731300518:AAGnyYllxvIeF5oaeUzxRCASTJRby7MqS0s");
using var cts = new CancellationTokenSource();

var receiverOptions = new ReceiverOptions
{
    AllowedUpdates = Array.Empty<UpdateType>()
};

botClient.StartReceiving(
    HandleUpdateAsync,
    (bot, exception, ct) => ErrorHandler.HandleErrorAsync(exception),
    receiverOptions,
    cancellationToken: cts.Token
);

var me = await botClient.GetMeAsync();
Console.WriteLine($"🤖 Bot @{me.Username} iniciado.");
Console.ReadLine();

async Task HandleUpdateAsync(ITelegramBotClient bot, Update update, CancellationToken ct)
{
    if (update.Message is not { } message || message.Text is not { } messageText)
        return;

    Console.WriteLine($"Recebido de {message.Chat.Id}: {messageText}");

    switch (messageText.ToLower())
    {
        case "/start":
            await bot.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: "🔥 Bem-vindo ao Bot da FURIA!\nUse: \n/proximosjogos\n/jogadores\n/quiz\n/loja.",
                cancellationToken: ct
            );
            break;

        case "/proximosjogos":
            await bot.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: TabelaService.ObterTabelasJogos(),
                parseMode: ParseMode.MarkdownV2,
                cancellationToken: ct
            );
            break;

        case "/jogadores":
            await bot.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: JogadoresService.ObterListaJogadores(),
                cancellationToken: ct
            );
            break;

        case "/quiz":
            await QuizService.EnviarQuiz(bot, message.Chat.Id, ct);
            break;

        case "/loja":
            await bot.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: "🛍️ Loja oficial da FURIA: https://loja.furia.gg/",
                cancellationToken: ct
            );
            break;
        default:
            await bot.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: "❓ Comando não reconhecido. Use /start para ver as opções.",
                cancellationToken: ct
            );
            break;
    }
}


