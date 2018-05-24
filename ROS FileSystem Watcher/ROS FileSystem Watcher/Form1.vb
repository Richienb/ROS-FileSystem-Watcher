Imports MaterialSkin

Public Class Form1

    Dim showingsettings As Boolean = False
    Dim showingbrowse As Boolean = False
    Dim monitoron As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Red200, TextShade.WHITE)
        MaterialSingleLineTextField1.Text = My.Computer.FileSystem.SpecialDirectories.Desktop
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        If monitoron = False Then
            If Not My.Computer.FileSystem.DirectoryExists(MaterialSingleLineTextField1.Text) Then
                MsgBox("Directory " & MaterialSingleLineTextField1.Text & " Does Not Exist!")
                Exit Sub
            End If
            Watch_Create.Path = MaterialSingleLineTextField1.Text
            Watch_Change.Path = MaterialSingleLineTextField1.Text
            Watch_Delete.Path = MaterialSingleLineTextField1.Text
            Watch_Rename.Path = MaterialSingleLineTextField1.Text
            If MaterialCheckBox1.Checked = True Then
                Watch_Create.EnableRaisingEvents = True
            End If
            If MaterialCheckBox2.Checked = True Then
                Watch_Change.EnableRaisingEvents = True
            End If
            If MaterialCheckBox3.Checked = True Then
                Watch_Delete.EnableRaisingEvents = True
            End If
            If MaterialCheckBox4.Checked = True Then
                Watch_Rename.EnableRaisingEvents = True
            End If
            monitoron = True
        Else
            monitoron = False
        End If
    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        If showingbrowse = True Then
            MaterialRaisedButton2.PerformClick()
        End If
        If showingsettings = False Then
            MaterialRaisedButton3.Enabled = False
            delay(10)
            MaterialCheckBox1.Visible = True
            delay(100)
            MaterialCheckBox2.Visible = True
            delay(100)
            MaterialCheckBox3.Visible = True
            delay(100)
            MaterialCheckBox4.Visible = True
            MaterialRaisedButton3.Icon = My.Resources.close
            showingsettings = True
            MaterialRaisedButton3.Enabled = True
        Else
            MaterialRaisedButton3.Enabled = False
            delay(10)
            MaterialCheckBox4.Visible = False
            delay(100)
            MaterialCheckBox3.Visible = False
            delay(100)
            MaterialCheckBox2.Visible = False
            delay(100)
            MaterialCheckBox1.Visible = False
            MaterialRaisedButton3.Icon = My.Resources.settings
            showingsettings = False
            MaterialRaisedButton3.Enabled = True
        End If

    End Sub

    Private Sub delay(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

    Private Sub MaterialSingleLineTextField1_Click(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField1.Click

    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        If showingsettings = True Then
            MaterialRaisedButton3.PerformClick()
        End If
        If showingbrowse = False Then
            MaterialRaisedButton2.Enabled = False
            delay(10)
            For i = 0 To Me.Width - MaterialSingleLineTextField1.Right - 80
                delay(1)
                MaterialSingleLineTextField1.Size = New Size(i, 23)
            Next
            MaterialRaisedButton4.Visible = True
            MaterialRaisedButton2.Icon = My.Resources.close
            showingbrowse = True
            MaterialRaisedButton2.Enabled = True
            MaterialSingleLineTextField1.Focus()
        Else
            MaterialRaisedButton2.Enabled = False
            delay(10)
            Dim startsize = MaterialSingleLineTextField1.Width
            For i = 0 To startsize
                delay(1)
                MaterialSingleLineTextField1.Size = New Size(startsize - i, 23)
            Next
            MaterialRaisedButton4.Visible = False
            MaterialRaisedButton2.Icon = My.Resources.browse
            showingbrowse = False
            MaterialRaisedButton2.Enabled = True
        End If
    End Sub

    Private Sub MaterialRaisedButton4_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton4.Click
        FolderBrowserComp.ShowDialog()
        If Not FolderBrowserComp.SelectedPath = Nothing Then
            MaterialSingleLineTextField1.Text = FolderBrowserComp.SelectedPath.ToString
        End If
    End Sub

    Private Sub Watch_Create_Created(sender As Object, e As IO.FileSystemEventArgs) Handles Watch_Create.Created
        ListBox1.Items.Add("File Created | " & e.FullPath)
    End Sub

    Private Sub Watch_Change_Changed(sender As Object, e As IO.FileSystemEventArgs) Handles Watch_Change.Changed
        ListBox1.Items.Add("File Changed | " & e.FullPath)
    End Sub

    Private Sub Watch_Delete_Deleted(sender As Object, e As IO.FileSystemEventArgs) Handles Watch_Delete.Deleted
        ListBox1.Items.Add("File Deleted | " & e.FullPath)
    End Sub

    Private Sub Watch_Rename_Renamed(sender As Object, e As IO.RenamedEventArgs) Handles Watch_Rename.Renamed
        ListBox1.Items.Add("File Renamed | " & e.FullPath)
    End Sub
End Class
