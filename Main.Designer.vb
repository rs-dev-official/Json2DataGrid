<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnGrid = New System.Windows.Forms.Button()
        Me.BtnJson = New System.Windows.Forms.Button()
        Me.RText = New System.Windows.Forms.RichTextBox()
        Me.DtGridView = New System.Windows.Forms.DataGridView()
        Me.BtnReset = New System.Windows.Forms.Button()
        CType(Me.DtGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnGrid
        '
        Me.BtnGrid.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrid.Location = New System.Drawing.Point(260, 142)
        Me.BtnGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnGrid.Name = "BtnGrid"
        Me.BtnGrid.Size = New System.Drawing.Size(224, 60)
        Me.BtnGrid.TabIndex = 0
        Me.BtnGrid.TabStop = False
        Me.BtnGrid.Text = "Grid View"
        Me.BtnGrid.UseVisualStyleBackColor = True
        '
        'BtnJson
        '
        Me.BtnJson.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJson.Location = New System.Drawing.Point(260, 76)
        Me.BtnJson.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnJson.Name = "BtnJson"
        Me.BtnJson.Size = New System.Drawing.Size(224, 60)
        Me.BtnJson.TabIndex = 2
        Me.BtnJson.TabStop = False
        Me.BtnJson.Text = "Create JSon"
        Me.BtnJson.UseVisualStyleBackColor = True
        '
        'RText
        '
        Me.RText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RText.Location = New System.Drawing.Point(10, 10)
        Me.RText.Margin = New System.Windows.Forms.Padding(0)
        Me.RText.Name = "RText"
        Me.RText.Size = New System.Drawing.Size(240, 192)
        Me.RText.TabIndex = 3
        Me.RText.TabStop = False
        Me.RText.Text = ""
        '
        'DtGridView
        '
        Me.DtGridView.AllowUserToAddRows = False
        Me.DtGridView.AllowUserToDeleteRows = False
        Me.DtGridView.AllowUserToOrderColumns = True
        Me.DtGridView.AllowUserToResizeColumns = False
        Me.DtGridView.AllowUserToResizeRows = False
        Me.DtGridView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DtGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DtGridView.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        Me.DtGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DtGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.DtGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DtGridView.GridColor = System.Drawing.Color.Black
        Me.DtGridView.Location = New System.Drawing.Point(10, 212)
        Me.DtGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.DtGridView.MultiSelect = False
        Me.DtGridView.Name = "DtGridView"
        Me.DtGridView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DtGridView.RowHeadersVisible = False
        Me.DtGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DtGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DtGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DtGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DtGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DtGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DtGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtGridView.ShowCellToolTips = False
        Me.DtGridView.ShowEditingIcon = False
        Me.DtGridView.Size = New System.Drawing.Size(474, 180)
        Me.DtGridView.TabIndex = 4
        Me.DtGridView.TabStop = False
        '
        'BtnReset
        '
        Me.BtnReset.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Location = New System.Drawing.Point(260, 10)
        Me.BtnReset.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(224, 60)
        Me.BtnReset.TabIndex = 5
        Me.BtnReset.Text = "Reset All"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(494, 403)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.DtGridView)
        Me.Controls.Add(Me.RText)
        Me.Controls.Add(Me.BtnJson)
        Me.Controls.Add(Me.BtnGrid)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Grid View From JSON"
        CType(Me.DtGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnGrid As System.Windows.Forms.Button
    Friend WithEvents BtnJson As System.Windows.Forms.Button
    Friend WithEvents RText As System.Windows.Forms.RichTextBox
    Friend WithEvents DtGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BtnReset As System.Windows.Forms.Button

End Class
