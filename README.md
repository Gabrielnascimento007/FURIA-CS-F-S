🦾 Bot da FURIA – Telegram Fan Bot
🔥 Bot oficial da torcida FURIA no Telegram!
Permite que fãs acompanhem os próximos jogos, vejam o line-up do time, participem de quizzes interativos, acompanhem partidas ao vivo e interajam com um simulador de torcida!

-------------------------------------------------------------------------------------------------------

🚀 Funcionalidades
Comando	Descrição

/start	Exibe mensagem de boas-vindas e os comandos disponíveis

/proximosjogos	Lista atualizada dos próximos jogos da FURIA

/jogadores	Mostra o line-up atual da equipe

/quiz	Envia perguntas sobre a FURIA com pontuação (modo quiz Telegram)

/loja	Link para a loja oficial da FURIA

-------------------------------------------------------------------------------------------------------

🛠️ Tecnologias Utilizadas
.NET 7.0

Telegram.Bot API

C#

MarkdownV2 para mensagens formatadas

-------------------------------------------------------------------------------------------------------

ChatBot_Furia/
│
├── Program.cs                   # Entrada principal do bot
├── Exceptions/
│   └── ErrorHandler.cs         # Tratamento de erros
│
├── Service/
│   ├── TabelaService.cs        # Jogos da FURIA
│   ├── JogadoresService.cs     # Lista de jogadores
│   ├── QuizService.cs          # Perguntas e lógica do quiz
│   ├── LiveStatusService.cs    # Status ao vivo das partidas
│   └── TorcidaService.cs       # (em construção)

-------------------------------------------------------------------------------------------------------

🧪 Como Executar Localmente
Clone o repositório

bash
Copiar
Editar
git clone https://github.com/seuusuario/bot-da-furia.git
cd bot-da-furia
Configure seu token do bot

Crie um bot com o @BotFather

Copie o token e substitua no Program.cs:

csharp
Copiar
Editar
var botClient = new TelegramBotClient("SEU_TOKEN_AQUI");
Execute o projeto

bash
Copiar
Editar
dotnet run

-------------------------------------------------------------------------------------------------------

🧠 Ideias Futuras
Integração com API HLTV ou PandaScore para partidas reais

Pontuação com ranking dos fãs mais ativos

Simulador de torcida com emojis e reações

Landing page com stats e acesso ao bot

Web chat para quem não usa Telegram

🤝 Contribuição
Sinta-se livre para abrir issues, pull requests ou sugerir melhorias!
Esse projeto é feito por fãs, para fãs 💜🖤
