Imports System.Text.RegularExpressions

Public Class Certificate_Key
    Private Sub Certificate_Key_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.urlText.Text = My.Settings.url
        Me.keyText.Text = My.Settings.cert
    End Sub

    Private Sub KeySave_Click(sender As Object, e As EventArgs) Handles KeySave.Click
        My.Settings.cert = Me.keyText.Text
        My.Settings.url = Me.urlText.Text
        My.Settings.Save()
        Me.Close()
        Form1.Show()

    End Sub
End Class