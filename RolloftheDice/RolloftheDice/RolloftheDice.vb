

Module RolloftheDice

    Sub Main()
        TestRandomness()
    End Sub

    Sub TestRandomness()
        Dim dieCountTotal(12) As Integer
        Dim woag As String = "X |"
        Dim heading() As String = {"2 |", "3 |", "4 |", "5 |", "6 |", "7 |", "8 |", "9 |", "10 |", "11 |", "12 |"}

        Console.WriteLine("Roll the Dice")
        Console.WriteLine(StrDup(66, "_") & vbNewLine)

        For Each letter In heading
            Console.Write(letter.PadLeft(6).PadRight(6))
        Next

        Console.WriteLine(vbNewLine & StrDup(66, "_") & vbNewLine)

        For i = 1 To 1000
            dieCountTotal((RandomDieOne(1, 6)) + RandomDieTwo(1, 6)) += 1
        Next

        For i = 2 To 12
            woag = CStr(dieCountTotal(i)).PadLeft(4)
            Console.Write(woag & " |")
        Next
        Console.WriteLine(vbNewLine & StrDup(66, "_"))

    End Sub

    Function RandomDieOne(min As Integer, max As Integer) As Integer
        Dim woag As Single
        max += 1 'ensures max is included for math dot floor
        Randomize()
        woag = Rnd()
        woag *= max - min
        woag += min
        Return CInt(Int(woag))

    End Function

    Function RandomDieTwo(min As Integer, max As Integer) As Integer
        Dim pow As Single
        max += 1 'ensures max is included for math dot floor
        Randomize()
        pow = Rnd()
        pow *= max - min
        pow += min
        Return CInt(Int(pow))
    End Function

End Module
