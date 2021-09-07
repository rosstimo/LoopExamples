Option Explicit On


Module LoopExamples

        Sub Main()

        'Runs a number of times increment by Step
        Dim pattern As String
        For i = 1 To 10 Step 1
            'Console.WriteLine(i)
            pattern &= "*"
            Console.WriteLine(pattern)
        Next

        Dim count As Integer '= 11
        'Evaluate before entering the loop
        Do While count <= 10
            count += 1
        Loop

        'evaluate at the end of the loop
        'always runs the nested code at least once
        Do
            count += 1
        Loop While count <= 10

        Console.Read()
        End Sub

    End Module
