'Joshua Makuch
'RCET 0265
'Fall 2023
'Fortune Cookie
'https://github.com/JoshuaMakuch/FortuneCookie.git

Option Explicit On
Option Strict On

Imports System

Module FortuneCookie
    Sub Main(args As String())

        Randomize()

        Dim randomNumber As Integer
        Dim userInput As Integer

        'Asks the user how many fortune cookies the want
        Do
            Console.WriteLine("")
            Console.WriteLine("How many fortune cookies would you like")
            Try
                userInput = CInt(Console.ReadLine())
                Console.WriteLine("")
                Console.WriteLine($"You chose {userInput} fortune cookies.")
                If userInput < 1001 And userInput >= 0 Then
                    Exit Do
                Else
                    Console.WriteLine("")
                    Console.WriteLine("That won't work, its a bit ludicrous of you to think it would >:(.")
                End If
            Catch ex As Exception
                Console.WriteLine("")
                Console.WriteLine("That amount is NO WORKY!")
            End Try
        Loop

        'This loops however many times the user input
        For i = 1 To userInput
            'This takes a random fraction and multiplies it by 2 then turns it into an integer, including rounding.
            'This creates a number from 0 to 2, one of three possible options
            randomNumber = CInt(Rnd() * 2)

            Select Case randomNumber
                Case 0
                    Console.WriteLine("You obtained Wisdom 1: Your greatest obstacle is the one that never ends.")
                Case 1
                    Console.WriteLine("You obtained Wisdom 2: There will be a day that you were hugged by your parents for the last time.")
                Case 2
                    Console.WriteLine("You obtained Wisdom 3: What gets bigger the more you take away from it, a hole.")
            End Select
        Next




    End Sub
End Module
