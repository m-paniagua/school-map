<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMapsQuiz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMapsQuiz))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.lblCsit1 = New System.Windows.Forms.Label()
        Me.btnEngineering = New System.Windows.Forms.Button()
        Me.lblCsit2 = New System.Windows.Forms.Label()
        Me.btnBusinessJourn = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picBusinessJournalism = New System.Windows.Forms.PictureBox()
        Me.picEngineering = New System.Windows.Forms.PictureBox()
        Me.picMap = New System.Windows.Forms.PictureBox()
        CType(Me.picBusinessJournalism, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEngineering, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Location = New System.Drawing.Point(455, 36)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(208, 13)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Do you need help finding your CSIT class?"
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.Color.Green
        Me.btnYes.Location = New System.Drawing.Point(458, 86)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(75, 23)
        Me.btnYes.TabIndex = 1
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = False
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.Color.Red
        Me.btnNo.Location = New System.Drawing.Point(588, 86)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(75, 23)
        Me.btnNo.TabIndex = 2
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = False
        '
        'lblCsit1
        '
        Me.lblCsit1.AutoSize = True
        Me.lblCsit1.Location = New System.Drawing.Point(503, 146)
        Me.lblCsit1.Name = "lblCsit1"
        Me.lblCsit1.Size = New System.Drawing.Size(115, 39)
        Me.lblCsit1.TabIndex = 3
        Me.lblCsit1.Text = "For CSIT:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "892, 808, 839,890,895" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click on Engineering"
        Me.lblCsit1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblCsit1.Visible = False
        '
        'btnEngineering
        '
        Me.btnEngineering.Location = New System.Drawing.Point(506, 221)
        Me.btnEngineering.Name = "btnEngineering"
        Me.btnEngineering.Size = New System.Drawing.Size(115, 23)
        Me.btnEngineering.TabIndex = 4
        Me.btnEngineering.Text = "Engineering"
        Me.btnEngineering.UseVisualStyleBackColor = True
        Me.btnEngineering.Visible = False
        '
        'lblCsit2
        '
        Me.lblCsit2.AutoSize = True
        Me.lblCsit2.Location = New System.Drawing.Point(491, 280)
        Me.lblCsit2.Name = "lblCsit2"
        Me.lblCsit2.Size = New System.Drawing.Size(142, 39)
        Me.lblCsit2.TabIndex = 5
        Me.lblCsit2.Text = "For CSIT:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "801, 816, and 875" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click on Business Journalism"
        Me.lblCsit2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblCsit2.Visible = False
        '
        'btnBusinessJourn
        '
        Me.btnBusinessJourn.Location = New System.Drawing.Point(503, 355)
        Me.btnBusinessJourn.Name = "btnBusinessJourn"
        Me.btnBusinessJourn.Size = New System.Drawing.Size(115, 23)
        Me.btnBusinessJourn.TabIndex = 6
        Me.btnBusinessJourn.Text = "Business Journalism"
        Me.btnBusinessJourn.UseVisualStyleBackColor = True
        Me.btnBusinessJourn.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(506, 414)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picBusinessJournalism
        '
        Me.picBusinessJournalism.Image = CType(resources.GetObject("picBusinessJournalism.Image"), System.Drawing.Image)
        Me.picBusinessJournalism.Location = New System.Drawing.Point(12, 12)
        Me.picBusinessJournalism.Name = "picBusinessJournalism"
        Me.picBusinessJournalism.Size = New System.Drawing.Size(421, 438)
        Me.picBusinessJournalism.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBusinessJournalism.TabIndex = 8
        Me.picBusinessJournalism.TabStop = False
        Me.picBusinessJournalism.Visible = False
        '
        'picEngineering
        '
        Me.picEngineering.Image = CType(resources.GetObject("picEngineering.Image"), System.Drawing.Image)
        Me.picEngineering.Location = New System.Drawing.Point(12, 12)
        Me.picEngineering.Name = "picEngineering"
        Me.picEngineering.Size = New System.Drawing.Size(421, 438)
        Me.picEngineering.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEngineering.TabIndex = 9
        Me.picEngineering.TabStop = False
        Me.picEngineering.Visible = False
        '
        'picMap
        '
        Me.picMap.Image = CType(resources.GetObject("picMap.Image"), System.Drawing.Image)
        Me.picMap.Location = New System.Drawing.Point(12, 12)
        Me.picMap.Name = "picMap"
        Me.picMap.Size = New System.Drawing.Size(421, 438)
        Me.picMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMap.TabIndex = 10
        Me.picMap.TabStop = False
        '
        'frmMapsQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.picMap)
        Me.Controls.Add(Me.picEngineering)
        Me.Controls.Add(Me.picBusinessJournalism)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBusinessJourn)
        Me.Controls.Add(Me.lblCsit2)
        Me.Controls.Add(Me.btnEngineering)
        Me.Controls.Add(Me.lblCsit1)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "frmMapsQuiz"
        Me.Text = "Campus Map"
        CType(Me.picBusinessJournalism, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEngineering, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents btnYes As System.Windows.Forms.Button
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents lblCsit1 As System.Windows.Forms.Label
    Friend WithEvents btnEngineering As System.Windows.Forms.Button
    Friend WithEvents lblCsit2 As System.Windows.Forms.Label
    Friend WithEvents btnBusinessJourn As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picBusinessJournalism As System.Windows.Forms.PictureBox
    Friend WithEvents picEngineering As System.Windows.Forms.PictureBox
    Friend WithEvents picMap As System.Windows.Forms.PictureBox

End Class
