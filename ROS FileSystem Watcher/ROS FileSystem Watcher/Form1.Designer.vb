<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MaterialCheckBox1 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.FolderBrowserComp = New System.Windows.Forms.FolderBrowserDialog()
        Me.Watch_Create = New System.IO.FileSystemWatcher()
        Me.MaterialCheckBox3 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialCheckBox2 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialCheckBox4 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Watch_Change = New System.IO.FileSystemWatcher()
        Me.Watch_Delete = New System.IO.FileSystemWatcher()
        Me.Watch_Rename = New System.IO.FileSystemWatcher()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton3 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialRaisedButton4 = New MaterialSkin.Controls.MaterialRaisedButton()
        CType(Me.Watch_Create, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Watch_Change, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Watch_Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Watch_Rename, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 22
        Me.ListBox1.Location = New System.Drawing.Point(12, 66)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(549, 334)
        Me.ListBox1.TabIndex = 0
        '
        'MaterialCheckBox1
        '
        Me.MaterialCheckBox1.AutoSize = True
        Me.MaterialCheckBox1.Checked = True
        Me.MaterialCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MaterialCheckBox1.Depth = 0
        Me.MaterialCheckBox1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox1.Location = New System.Drawing.Point(160, 3)
        Me.MaterialCheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox1.Name = "MaterialCheckBox1"
        Me.MaterialCheckBox1.Ripple = True
        Me.MaterialCheckBox1.Size = New System.Drawing.Size(153, 30)
        Me.MaterialCheckBox1.TabIndex = 1
        Me.MaterialCheckBox1.Text = "Track File Creations"
        Me.MaterialCheckBox1.UseVisualStyleBackColor = True
        Me.MaterialCheckBox1.Visible = False
        '
        'FolderBrowserComp
        '
        Me.FolderBrowserComp.ShowNewFolderButton = False
        '
        'Watch_Create
        '
        Me.Watch_Create.EnableRaisingEvents = True
        Me.Watch_Create.IncludeSubdirectories = True
        Me.Watch_Create.SynchronizingObject = Me
        '
        'MaterialCheckBox3
        '
        Me.MaterialCheckBox3.AutoSize = True
        Me.MaterialCheckBox3.Checked = True
        Me.MaterialCheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MaterialCheckBox3.Depth = 0
        Me.MaterialCheckBox3.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox3.Location = New System.Drawing.Point(325, 3)
        Me.MaterialCheckBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox3.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox3.Name = "MaterialCheckBox3"
        Me.MaterialCheckBox3.Ripple = True
        Me.MaterialCheckBox3.Size = New System.Drawing.Size(152, 30)
        Me.MaterialCheckBox3.TabIndex = 2
        Me.MaterialCheckBox3.Text = "Track File Deletions"
        Me.MaterialCheckBox3.UseVisualStyleBackColor = True
        Me.MaterialCheckBox3.Visible = False
        '
        'MaterialCheckBox2
        '
        Me.MaterialCheckBox2.AutoSize = True
        Me.MaterialCheckBox2.Checked = True
        Me.MaterialCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MaterialCheckBox2.Depth = 0
        Me.MaterialCheckBox2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox2.Location = New System.Drawing.Point(160, 33)
        Me.MaterialCheckBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox2.Name = "MaterialCheckBox2"
        Me.MaterialCheckBox2.Ripple = True
        Me.MaterialCheckBox2.Size = New System.Drawing.Size(148, 30)
        Me.MaterialCheckBox2.TabIndex = 2
        Me.MaterialCheckBox2.Text = "Track File Changes"
        Me.MaterialCheckBox2.UseVisualStyleBackColor = True
        Me.MaterialCheckBox2.Visible = False
        '
        'MaterialCheckBox4
        '
        Me.MaterialCheckBox4.AutoSize = True
        Me.MaterialCheckBox4.Depth = 0
        Me.MaterialCheckBox4.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox4.Location = New System.Drawing.Point(325, 33)
        Me.MaterialCheckBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox4.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox4.Name = "MaterialCheckBox4"
        Me.MaterialCheckBox4.Ripple = True
        Me.MaterialCheckBox4.Size = New System.Drawing.Size(151, 30)
        Me.MaterialCheckBox4.TabIndex = 3
        Me.MaterialCheckBox4.Text = "Track File Renames"
        Me.MaterialCheckBox4.UseVisualStyleBackColor = True
        Me.MaterialCheckBox4.Visible = False
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.AutoSize = True
        Me.MaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Icon = Global.ROS_FileSystem_Watcher.My.Resources.Resources.play
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(12, 17)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(44, 36)
        Me.MaterialRaisedButton1.TabIndex = 4
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'Watch_Change
        '
        Me.Watch_Change.EnableRaisingEvents = True
        Me.Watch_Change.IncludeSubdirectories = True
        Me.Watch_Change.SynchronizingObject = Me
        '
        'Watch_Delete
        '
        Me.Watch_Delete.EnableRaisingEvents = True
        Me.Watch_Delete.IncludeSubdirectories = True
        Me.Watch_Delete.SynchronizingObject = Me
        '
        'Watch_Rename
        '
        Me.Watch_Rename.EnableRaisingEvents = True
        Me.Watch_Rename.IncludeSubdirectories = True
        Me.Watch_Rename.SynchronizingObject = Me
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.AutoSize = True
        Me.MaterialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Icon = Global.ROS_FileSystem_Watcher.My.Resources.Resources.browse
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(63, 17)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(44, 36)
        Me.MaterialRaisedButton2.TabIndex = 5
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton3
        '
        Me.MaterialRaisedButton3.AutoSize = True
        Me.MaterialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton3.Depth = 0
        Me.MaterialRaisedButton3.Icon = Global.ROS_FileSystem_Watcher.My.Resources.Resources.settings
        Me.MaterialRaisedButton3.Location = New System.Drawing.Point(113, 17)
        Me.MaterialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton3.Name = "MaterialRaisedButton3"
        Me.MaterialRaisedButton3.Primary = True
        Me.MaterialRaisedButton3.Size = New System.Drawing.Size(44, 36)
        Me.MaterialRaisedButton3.TabIndex = 6
        Me.MaterialRaisedButton3.UseVisualStyleBackColor = True
        '
        'MaterialSingleLineTextField1
        '
        Me.MaterialSingleLineTextField1.Depth = 0
        Me.MaterialSingleLineTextField1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.MaterialSingleLineTextField1.Hint = "Type Directory Here"
        Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(166, 24)
        Me.MaterialSingleLineTextField1.MaxLength = 32767
        Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField1.SelectedText = ""
        Me.MaterialSingleLineTextField1.SelectionLength = 0
        Me.MaterialSingleLineTextField1.SelectionStart = 0
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(0, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 7
        Me.MaterialSingleLineTextField1.TabStop = False
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        '
        'MaterialRaisedButton4
        '
        Me.MaterialRaisedButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialRaisedButton4.AutoSize = True
        Me.MaterialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton4.Depth = 0
        Me.MaterialRaisedButton4.Icon = Global.ROS_FileSystem_Watcher.My.Resources.Resources.browse
        Me.MaterialRaisedButton4.Location = New System.Drawing.Point(517, 17)
        Me.MaterialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton4.Name = "MaterialRaisedButton4"
        Me.MaterialRaisedButton4.Primary = True
        Me.MaterialRaisedButton4.Size = New System.Drawing.Size(44, 36)
        Me.MaterialRaisedButton4.TabIndex = 8
        Me.MaterialRaisedButton4.UseVisualStyleBackColor = True
        Me.MaterialRaisedButton4.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(573, 412)
        Me.Controls.Add(Me.MaterialRaisedButton4)
        Me.Controls.Add(Me.MaterialSingleLineTextField1)
        Me.Controls.Add(Me.MaterialRaisedButton3)
        Me.Controls.Add(Me.MaterialRaisedButton2)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.MaterialCheckBox4)
        Me.Controls.Add(Me.MaterialCheckBox2)
        Me.Controls.Add(Me.MaterialCheckBox3)
        Me.Controls.Add(Me.MaterialCheckBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Roboto", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "ROS FileSystem Watcher"
        CType(Me.Watch_Create, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Watch_Change, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Watch_Delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Watch_Rename, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents MaterialCheckBox1 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents FolderBrowserComp As FolderBrowserDialog
    Friend WithEvents Watch_Create As IO.FileSystemWatcher
    Friend WithEvents MaterialCheckBox4 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialCheckBox2 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialCheckBox3 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Watch_Change As IO.FileSystemWatcher
    Friend WithEvents Watch_Delete As IO.FileSystemWatcher
    Friend WithEvents Watch_Rename As IO.FileSystemWatcher
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton3 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialRaisedButton4 As MaterialSkin.Controls.MaterialRaisedButton
End Class
