Imports MaterialSkin

Public Class Form1

    Dim showingsettings As Boolean = False
    Dim showingbrowse As Boolean = False
    Dim monitoron As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Red200, TextShade.WHITE)
        FileSaveComp.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        If monitoron = False Then
            If Not My.Computer.FileSystem.DirectoryExists(MaterialSingleLineTextField1.Text) Then
                MsgBox("The Directory You Specified Does Not Exist!", MsgBoxStyle.Exclamation)
                If MaterialRaisedButton2.Enabled = True Then
                    If showingbrowse = False Then
                        MaterialRaisedButton2.PerformClick()
                    Else
                        MaterialSingleLineTextField1.Focus()
                    End If

                End If
                Exit Sub
            End If
            Watch_Create.Path = MaterialSingleLineTextField1.Text
            Watch_Change.Path = MaterialSingleLineTextField1.Text
            Watch_Delete.Path = MaterialSingleLineTextField1.Text
            Watch_Rename.Path = MaterialSingleLineTextField1.Text
            Watch_Create.EnableRaisingEvents = MaterialCheckBox1.Checked
            Watch_Change.EnableRaisingEvents = MaterialCheckBox2.Checked
            Watch_Delete.EnableRaisingEvents = MaterialCheckBox3.Checked
            Watch_Rename.EnableRaisingEvents = MaterialCheckBox4.Checked
            MaterialRaisedButton1.Icon = My.Resources.pause
            monitoron = True
        Else
            Watch_Create.EnableRaisingEvents = False
            Watch_Change.EnableRaisingEvents = False
            Watch_Delete.EnableRaisingEvents = False
            Watch_Rename.EnableRaisingEvents = False
            MaterialRaisedButton1.Icon = My.Resources.play
            monitoron = False
        End If
    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        If showingbrowse = True Then
            If MaterialRaisedButton2.Enabled = True Then
                MaterialRaisedButton3.Enabled = False
                MaterialRaisedButton2.PerformClick()
                MaterialRaisedButton3.Enabled = True
            End If
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
            If MaterialRaisedButton3.Enabled = True Then
                MaterialRaisedButton2.Enabled = False
                MaterialRaisedButton3.PerformClick()
                MaterialRaisedButton2.Enabled = False
            End If
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
        MaterialLabel1.Text = "File Created | " & e.FullPath
    End Sub

    Private Sub Watch_Change_Changed(sender As Object, e As IO.FileSystemEventArgs) Handles Watch_Change.Changed
        ListBox1.Items.Add("File Changed | " & e.FullPath)
        MaterialLabel1.Text = "File Changed | " & e.FullPath
    End Sub

    Private Sub Watch_Delete_Deleted(sender As Object, e As IO.FileSystemEventArgs) Handles Watch_Delete.Deleted
        ListBox1.Items.Add("File Deleted | " & e.FullPath)
        MaterialLabel1.Text = "File Deleted | " & e.FullPath
    End Sub

    Private Sub Watch_Rename_Renamed(sender As Object, e As IO.RenamedEventArgs) Handles Watch_Rename.Renamed
        ListBox1.Items.Add("File Renamed | " & e.FullPath)
        MaterialLabel1.Text = "File Renamed | " & e.FullPath
    End Sub

    Private Sub MaterialCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox1.CheckedChanged
        If monitoron = True Then
            Watch_Create.EnableRaisingEvents = MaterialCheckBox1.Checked
        End If
    End Sub

    Private Sub MaterialCheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox2.CheckedChanged
        Watch_Change.EnableRaisingEvents = MaterialCheckBox2.Checked
    End Sub

    Private Sub MaterialCheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox3.CheckedChanged
        Watch_Delete.EnableRaisingEvents = MaterialCheckBox3.Checked
    End Sub

    Private Sub MaterialCheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox4.CheckedChanged
        Watch_Rename.EnableRaisingEvents = MaterialCheckBox4.Checked
    End Sub
End Class
