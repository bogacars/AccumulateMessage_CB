'Carson Bogart
'RCET 0265
'Spring 22
'Accumultae Messages
'https://github.com/bogacars/AccumulateMessage_CB.git

Option Strict On
Option Explicit On
Option Compare Text
Module Accumulate

    Sub Main()
        Dim userInput As String
        Do
            Console.WriteLine("Enter your text")
            userInput = Console.ReadLine()
            UsersStuff(userInput, False)
            Console.WriteLine(UsersStuff("", False))



        Loop While userInput <> "Q"
        Console.Read()
    End Sub
    Function UsersStuff(ByVal theMessage As String, ByVal clr As Boolean) As String
        Static message As String
        If clr = True Then
            message = ""
        ElseIf theMessage <> "" Then
            message &= theMessage & vbNewLine
        End If
        Return message
    End Function
End Module
