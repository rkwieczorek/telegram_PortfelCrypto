Imports System
Imports Telegram.Bot
Imports Telegram.Bot.Args



Module Program

    Public telegramBotClient As TelegramBotClient

    Sub Main(args As String())
        telegramBotClient = New TelegramBotClient("2108974422:AAGNErkuiZwkGDYRYWxupWCWQNNgoJfdEWc")
        AddHandler telegramBotClient.OnMessage, AddressOf telegramBotClientOnMessage
        telegramBotClient.StartReceiving()
        Threading.Thread.Sleep(-1)
    End Sub

    Private Sub telegramBotClientOnMessage(sender As Object, e As MessageEventArgs)
        Dim id = e.Message.Chat.Id
        Dim text As String = e.Message.Text

        telegramBotClient.SendTextMessageAsync(id, "Napisales:" & text)
    End Sub
End Module
