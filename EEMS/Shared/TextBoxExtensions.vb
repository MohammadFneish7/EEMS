Imports System.Runtime.CompilerServices
Module TextBoxExtensions
    <Extension()>
    Public Sub AppendLine(textbox As TextBox, line As String)
        textbox.Text = Environment.NewLine + textbox.Text & line.Replace("\n", Environment.NewLine)
        If textbox.Visible Then
            textbox.SelectionStart = textbox.TextLength
            textbox.ScrollToCaret()
        End If
    End Sub

End Module
