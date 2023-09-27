<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtnama = New TextBox()
        btntambah = New Button()
        btnkeluar = New Button()
        ListView1 = New ListView()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(79, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' txtnama
        ' 
        txtnama.Location = New Point(169, 52)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(307, 23)
        txtnama.TabIndex = 1
        ' 
        ' btntambah
        ' 
        btntambah.Location = New Point(103, 297)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(75, 23)
        btntambah.TabIndex = 2
        btntambah.Text = "Tambah"
        btntambah.UseVisualStyleBackColor = True
        ' 
        ' btnkeluar
        ' 
        btnkeluar.Location = New Point(322, 297)
        btnkeluar.Name = "btnkeluar"
        btnkeluar.Size = New Size(75, 23)
        btnkeluar.TabIndex = 3
        btnkeluar.Text = "Keluar"
        btnkeluar.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(117, 118)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(416, 147)
        ListView1.TabIndex = 4
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListView1)
        Controls.Add(btnkeluar)
        Controls.Add(btntambah)
        Controls.Add(txtnama)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents btntambah As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents ListView1 As ListView
End Class
