Imports System.Diagnostics

Public Class UC_Analysis

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim url As String = "https://linktr.ee/ecodeLabs"
        Process.Start(New ProcessStartInfo(url) With {.UseShellExecute = True})
    End Sub
End Class
