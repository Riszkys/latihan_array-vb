Public Class Form1
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Dim nama(0) As String
        nama(0) = txtnama.Text

        Dim list As New ListViewItem
        list = ListView1.Items.Add(nama(0))
        txtnama.Text = ""
        txtnama.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.Columns.Add("nama", 120)
    End Sub
End Class
