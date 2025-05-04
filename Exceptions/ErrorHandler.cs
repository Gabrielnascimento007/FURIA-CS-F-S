using Telegram.Bot.Exceptions;

namespace ChatBot_Furia.Exceptions;

public class ErrorHandler
{
    public static Task HandleErrorAsync(Exception exception)
    {
        var errorMsg = exception switch
        {
            ApiRequestException apiRequestException =>
                $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
            _ => exception.ToString()
        };

        Console.WriteLine(errorMsg);
        return Task.CompletedTask;
    }
}
