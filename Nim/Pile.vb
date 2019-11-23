Public Class Pile
    Private numStones As String

    Public Sub New(ByVal numStones As String)
        Me.numStones = numStones

    End Sub
    Public Sub display()
        Console.WriteLine("Pile: " + New String("*", Me.numStones))

    End Sub

    Public Sub Take(num As Integer)
        Me.numStones = Me.numStones - num
        If Me.numStones < 0 Then
            Me.numStones = 0
        End If
    End Sub

    Public Function isEmpty() As Boolean
        Return Not Me.hasStones
    End Function

    Public Function hasStones() As Boolean
        Return Me.numStones > 0
    End Function

End Class
