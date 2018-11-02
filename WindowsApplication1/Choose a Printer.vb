Imports System.Drawing.Printing

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add list of installed printers found to the list box.
        ' The pkInstalledPrinters string will be used to provide the display string.
        Dim i As Integer
        Dim pkInstalledPrinters As String

        For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
            pkInstalledPrinters = PrinterSettings.InstalledPrinters.Item(i)
            PrinterList.Items.Add(pkInstalledPrinters)
        Next
    End Sub
    Private Sub PrinterList_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrinterList.SelectedIndexChanged
        ' Set the printer to a printer in the combo box when the selection changes.

        If PrinterList.SelectedIndex <> -1 Then
            ' The list box's Text property returns the selected item's text, which is the printer name.
            Form1.PrintDocument1.PrinterSettings.PrinterName = PrinterList.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class