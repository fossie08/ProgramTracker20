Module Program
	Sub Main()
		Dim choice As Int16
		Dim repeat As Int16 = 1
		Dim choiceName As String = ""
		Dim scoreChoice As String
		Dim name(11) As String
		Dim score(3, 11) As Int16
		Dim average(11) As Int16
		Dim test1 As Int16
		Dim test2 As Int16
		Dim test3 As Int16

		While repeat = 1
			Console.WriteLine("Please enter 1 for inputing student names, 2 for entering scores and 3 for displaing the names and scores and 4 for exiting the program")
			choice = Val(Console.ReadLine())

			If choice = 1 Then
				Console.WriteLine("Please enter a name ")
				choiceName = Console.ReadLine
				For c = 1 To 11
					If name(c) = "" Then
						name(c) = choiceName
						Exit For
					End If
				Next
			End If
			If choice = 2 Then
				Console.WriteLine("Please enter a name to enter scores for ")
				scoreChoice = Console.ReadLine()
				For c = 1 To 11
					If scoreChoice = name(c) Then
						Console.WriteLine("Please enter the score for test 1 ")
						score(1, c) = Console.ReadLine()
						Console.WriteLine("Please enter the score for test 2 ")
						score(2, c) = Console.ReadLine()
						Console.WriteLine("Please enter the score for test 3 ")
						score(3, c) = Console.ReadLine()
						average(c) = (score(1, c) + score(2, c) + score(3, c)) / 3
					Else
						Console.WriteLine("That name does not exist!")
						Exit For
					End If
				Next
			End If
			If choice = 3 Then
				Console.WriteLine("Name		Test 1		Test 2		Test 3		Average")
				For c = 1 To 11
					If name(c) = "" Then

					Else
						Console.WriteLine(name(c) & "		" & score(1, c) & "		" & score(2, c) & "		" & score(3, c) & "		" & average(c))
					End If
				Next
			End If
			If choice = 4 Then
				Console.WriteLine("Exiting")
				Exit While
			End If
		End While
	End Sub
End Module