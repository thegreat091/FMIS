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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btndashboard = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnnewtransaction = New System.Windows.Forms.Button()
        Me.btnvalidation = New System.Windows.Forms.Button()
        Me.btnprintdocument = New System.Windows.Forms.Button()
        Me.btnreports = New System.Windows.Forms.Button()
        Me.btnbackup = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(319, 844)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Welcome!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'btnlogout
        '
        Me.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnlogout.ForeColor = System.Drawing.Color.White
        Me.btnlogout.Image = CType(resources.GetObject("btnlogout.Image"), System.Drawing.Image)
        Me.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogout.Location = New System.Drawing.Point(0, 603)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(319, 48)
        Me.btnlogout.TabIndex = 2
        Me.btnlogout.Text = "Log out"
        Me.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'btndashboard
        '
        Me.btndashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btndashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndashboard.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btndashboard.ForeColor = System.Drawing.Color.White
        Me.btndashboard.Image = CType(resources.GetObject("btndashboard.Image"), System.Drawing.Image)
        Me.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndashboard.Location = New System.Drawing.Point(0, 0)
        Me.btndashboard.Name = "btndashboard"
        Me.btndashboard.Size = New System.Drawing.Size(319, 48)
        Me.btndashboard.TabIndex = 3
        Me.btndashboard.Text = "Dashboard"
        Me.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndashboard.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnbackup)
        Me.Panel2.Controls.Add(Me.btnreports)
        Me.Panel2.Controls.Add(Me.btnprintdocument)
        Me.Panel2.Controls.Add(Me.btnvalidation)
        Me.Panel2.Controls.Add(Me.btnnewtransaction)
        Me.Panel2.Controls.Add(Me.btnlogout)
        Me.Panel2.Controls.Add(Me.btndashboard)
        Me.Panel2.Location = New System.Drawing.Point(0, 193)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(319, 651)
        Me.Panel2.TabIndex = 4
        '
        'btnnewtransaction
        '
        Me.btnnewtransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnnewtransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnewtransaction.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnnewtransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnewtransaction.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnnewtransaction.ForeColor = System.Drawing.Color.White
        Me.btnnewtransaction.Image = CType(resources.GetObject("btnnewtransaction.Image"), System.Drawing.Image)
        Me.btnnewtransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnewtransaction.Location = New System.Drawing.Point(0, 48)
        Me.btnnewtransaction.Name = "btnnewtransaction"
        Me.btnnewtransaction.Size = New System.Drawing.Size(319, 48)
        Me.btnnewtransaction.TabIndex = 4
        Me.btnnewtransaction.Text = "New Transaction"
        Me.btnnewtransaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnewtransaction.UseVisualStyleBackColor = True
        '
        'btnvalidation
        '
        Me.btnvalidation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnvalidation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnvalidation.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnvalidation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvalidation.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnvalidation.ForeColor = System.Drawing.Color.White
        Me.btnvalidation.Image = CType(resources.GetObject("btnvalidation.Image"), System.Drawing.Image)
        Me.btnvalidation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnvalidation.Location = New System.Drawing.Point(0, 96)
        Me.btnvalidation.Name = "btnvalidation"
        Me.btnvalidation.Size = New System.Drawing.Size(319, 48)
        Me.btnvalidation.TabIndex = 5
        Me.btnvalidation.Text = "Validation"
        Me.btnvalidation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnvalidation.UseVisualStyleBackColor = True
        '
        'btnprintdocument
        '
        Me.btnprintdocument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnprintdocument.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprintdocument.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnprintdocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprintdocument.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnprintdocument.ForeColor = System.Drawing.Color.White
        Me.btnprintdocument.Image = CType(resources.GetObject("btnprintdocument.Image"), System.Drawing.Image)
        Me.btnprintdocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnprintdocument.Location = New System.Drawing.Point(0, 144)
        Me.btnprintdocument.Name = "btnprintdocument"
        Me.btnprintdocument.Size = New System.Drawing.Size(319, 48)
        Me.btnprintdocument.TabIndex = 6
        Me.btnprintdocument.Text = "Print document"
        Me.btnprintdocument.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnprintdocument.UseVisualStyleBackColor = True
        '
        'btnreports
        '
        Me.btnreports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnreports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreports.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnreports.ForeColor = System.Drawing.Color.White
        Me.btnreports.Image = CType(resources.GetObject("btnreports.Image"), System.Drawing.Image)
        Me.btnreports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreports.Location = New System.Drawing.Point(0, 192)
        Me.btnreports.Name = "btnreports"
        Me.btnreports.Size = New System.Drawing.Size(319, 48)
        Me.btnreports.TabIndex = 7
        Me.btnreports.Text = "Reports"
        Me.btnreports.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnreports.UseVisualStyleBackColor = True
        '
        'btnbackup
        '
        Me.btnbackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnbackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbackup.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnbackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbackup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnbackup.ForeColor = System.Drawing.Color.White
        Me.btnbackup.Image = CType(resources.GetObject("btnbackup.Image"), System.Drawing.Image)
        Me.btnbackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbackup.Location = New System.Drawing.Point(0, 240)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(319, 48)
        Me.btnbackup.TabIndex = 8
        Me.btnbackup.Text = "Backup"
        Me.btnbackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnbackup.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1780, 844)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnlogout As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btndashboard As Button
    Friend WithEvents btnbackup As Button
    Friend WithEvents btnreports As Button
    Friend WithEvents btnprintdocument As Button
    Friend WithEvents btnvalidation As Button
    Friend WithEvents btnnewtransaction As Button
End Class
