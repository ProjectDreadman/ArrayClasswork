Module Module1

    Sub Main()
        Dim rndNum As New Random
        Dim Num As Integer
        Dim AllNums(49) As Integer

        'Num = rndNum.Next(1, 51) '1 is inclusive, 51 is exclusive
        'Console.WriteLine(Num)
        For i = 0 To 49
            AllNums(i) = rndNum.Next(1, 51)

        Next

        For i = 0 To 49
            ' Console.WriteLine(AllNums(i))
        Next

        'number 2 starts below
        Dim EvenNums(49) As Integer
        Dim OddNums(49) As Integer
        Dim rndNum2 As New Random
        Dim num2(49) As Integer

        For i = 0 To 49
            num2(i) = rndNum2.Next(1, 51)
            If num2(i) Mod 2 = 0 Then
                EvenNums(i) = num2(i)
            Else
                OddNums(i) = num2(i)
            End If
        Next

        For i = 0 To 49
            If EvenNums(i) <> 0 Then
                Console.WriteLine(EvenNums(i))
            End If
        Next

        'number 3 starts here
        Dim totalEven As Integer
        Dim TotalOdd As Integer
        Dim Total As Integer
        Dim avg As Integer

        For i = 0 To 49
            If EvenNums(i) > 0 Then
                Total += EvenNums(i)
                totalEven += 1
            End If

        Next
        avg = Total / totalEven
        Total = 0
        For i = 0 To 49
            If OddNums(i) > 0 Then
                Total += OddNums(i)
                TotalOdd += 1
            End If

        Next
        avg = Total / TotalOdd
    End Sub


End Module
