'Author : Rishit Patel
'Date   : Quarantine Day 9
'Description: File Assignment 2
Imports System.IO
Imports System.Text.RegularExpressions

Module Module1

    Sub Main()
        Dim filedata = File.ReadAllLines("warandpeace.txt")
        Top10MostFrequentWords(filedata)
        Console.WriteLine("The file has " & filedata.Length & " lines.")
        LongestWord(filedata)
        ReverseFile(filedata)
        Console.ReadKey()
    End Sub

    Private Function Top10MostFrequentWords(data As IEnumerable(Of String)) As List(Of KeyValuePair(Of String, Integer))
        Dim wordCount = New Dictionary(Of String, Integer)

        For Each line In data
            Dim words = line.Split({" "}, StringSplitOptions.RemoveEmptyEntries)
            For Each word In words
                Dim tempWord = Regex.Replace(word, "[^A-Za-z]+", String.Empty)
                If wordCount.ContainsKey(tempWord) Then
                    wordCount(tempWord) += 1
                Else
                    wordCount.Add(tempWord, 1)
                End If
            Next
        Next

        Dim top10WordsLinq = wordCount.OrderByDescending(Function(x) x.Value).Take(10).ToList()
        Console.WriteLine("Top 10 most frequent words in the file:")
        For Each wordl In top10WordsLinq
            Console.WriteLine(wordl)
        Next
        Return top10WordsLinq

    End Function

    Private Function LongestWord(data As IEnumerable(Of String))
        Dim theLongestWord = String.Empty

        For Each line In data
            Dim words = line.Split({" "}, StringSplitOptions.RemoveEmptyEntries)
            For Each word In words
                If Not String.IsNullOrEmpty(word) AndAlso word.Length > theLongestWord.Length Then
                    theLongestWord = word
                End If
            Next
        Next

        Console.WriteLine("Longest word in the text is: " & theLongestWord)
        Return theLongestWord
    End Function

    Private Function ReverseFile(data As IEnumerable(Of String))
        Dim reversedOutFile = "reversefile.txt"
        Try
            Dim list As New List(Of String)()
            For Each line In data
                list.Add(line)
            Next
            list.Reverse()
            File.WriteAllLines(reversedOutFile, list)
        Catch ex As Exception
            MsgBox("Error")
        End Try
        Console.WriteLine("File reversed: " & reversedOutFile)
        Return reversedOutFile
    End Function

End Module
