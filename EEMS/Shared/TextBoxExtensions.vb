Imports System.Runtime.CompilerServices
Module TextBoxExtensions
    <Extension()>
    Public Sub AppendLine(textbox As TextBox, line As String)
        If String.IsNullOrWhiteSpace(line) Then
            Return
        End If
        textbox.Text = textbox.Text & vbNewLine & line.Replace("\n", vbNewLine)
        If textbox.Visible Then
            textbox.SelectionStart = textbox.TextLength
            textbox.ScrollToCaret()
        End If
    End Sub

End Module
