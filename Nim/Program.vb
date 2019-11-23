Imports System

Module Program
    Sub Main(args As String())
        Dim pile0 As New Pile(3)
        Dim pile1 As New Pile(2)
        Dim game = New Pile() {pile0, pile1}
        Dim player = 0
        Dim pileNum As String

        gameStateDisplay(game)

        Do While game(0).hasStones() Or game(1).hasStones()
            If pile0.hasStones() And pile1.hasStones() Then
                Console.WriteLine("Which pile do you want to take from: ")
                pileNum = Console.ReadLine()
            Else
                If pile0.hasStones() Then
                    pileNum = "0"
                Else
                    pileNum = "1"
                End If
            End If

            Dim num As Integer
            num = 0
            Do While num <= 0
                Console.WriteLine("How many stones: ")
                num = Console.ReadLine()
            Loop

            If pileNum = "0" Then
                pile0.Take(num)
            Else
                pile1.Take(num)
            End If

            checkGameHasEnded(pile0, pile1, player)

            player = (player + 1) Mod 2
            gameStateDisplay(game)

            Console.WriteLine("Player " + CStr(player) + " your go...")

        Loop



    End Sub

    Sub gameStateDisplay(game As Pile())
        For Each pile As Pile In game
            pile.display()
        Next
    End Sub

    Function checkGameHasEnded(pile0 As Pile, pile1 As Pile, playerNum As Integer) As Boolean
        If pile0.isEmpty() And pile1.isEmpty() Then
            Console.WriteLine("Player " + CStr(playerNum) + " has lost!")
            Environment.Exit(0)
        End If
    End Function


End Module
