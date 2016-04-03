Imports System.Text.RegularExpressions

'Regex = regular expressions, used to find patterns in text
Module regexp
    Function checkValidity(ByVal str As String) As Boolean
        Dim regex As Regex = New Regex("^[a-zA-Z0-9_ ]*$")
        Dim match As Match = regex.Match(str)
        If match.Success Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
