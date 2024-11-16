Namespace DVLD_Project
    Partial Class Form16
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            Dim dataGridViewCellStyle1 As Windows.Forms.DataGridViewCellStyle = New Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As Windows.Forms.DataGridViewCellStyle = New Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As Windows.Forms.DataGridViewCellStyle = New Windows.Forms.DataGridViewCellStyle()
            label1 = New Windows.Forms.Label()
            guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
            guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
            pictureBox1 = New Windows.Forms.PictureBox()
            contextMenuStrip1 = New Windows.Forms.ContextMenuStrip(components)
            editDateToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            takeExamToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            getAppInfo1 = New GetAppInfo()
            getApplcationBisicInformations1 = New GetApplcationBisicInformations()
            CType(guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            contextMenuStrip1.SuspendLayout()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Microsoft Sans Serif", 18F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label1.ForeColor = Drawing.Color.FromArgb(255, 128, 128)
            label1.Location = New Drawing.Point(314, 92)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(181, 36)
            label1.TabIndex = 13
            label1.Text = "Vision Exam"
            ' 
            ' guna2DataGridView1
            ' 
            guna2DataGridView1.AllowUserToAddRows = False
            guna2DataGridView1.AllowUserToDeleteRows = False
            dataGridViewCellStyle1.BackColor = Drawing.Color.White
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1
            guna2DataGridView1.AutoSizeColumnsMode = Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            guna2DataGridView1.BackgroundColor = Drawing.Color.White
            guna2DataGridView1.BorderStyle = Windows.Forms.BorderStyle.None
            guna2DataGridView1.CellBorderStyle = Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            guna2DataGridView1.ColumnHeadersBorderStyle = Windows.Forms.DataGridViewHeaderBorderStyle.None
            dataGridViewCellStyle2.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle2.BackColor = Drawing.Color.FromArgb(100, 88, 255)
            dataGridViewCellStyle2.Font = New Drawing.Font("Segoe UI", 10.5F)
            dataGridViewCellStyle2.ForeColor = Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = Drawing.SystemColors.Highlight
            dataGridViewCellStyle2.SelectionForeColor = Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = Windows.Forms.DataGridViewTriState.True
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            guna2DataGridView1.ColumnHeadersHeight = 4
            dataGridViewCellStyle3.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = Drawing.Color.White
            dataGridViewCellStyle3.Font = New Drawing.Font("Segoe UI", 10.5F)
            dataGridViewCellStyle3.ForeColor = Drawing.Color.FromArgb(71, 69, 94)
            dataGridViewCellStyle3.SelectionBackColor = Drawing.Color.FromArgb(231, 229, 255)
            dataGridViewCellStyle3.SelectionForeColor = Drawing.Color.FromArgb(71, 69, 94)
            dataGridViewCellStyle3.WrapMode = Windows.Forms.DataGridViewTriState.False
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3
            guna2DataGridView1.EnableHeadersVisualStyles = False
            guna2DataGridView1.GridColor = Drawing.Color.FromArgb(231, 229, 255)
            guna2DataGridView1.Location = New Drawing.Point(35, 676)
            guna2DataGridView1.Name = "guna2DataGridView1"
            guna2DataGridView1.ReadOnly = True
            guna2DataGridView1.RowHeadersVisible = False
            guna2DataGridView1.RowHeadersWidth = 51
            guna2DataGridView1.RowTemplate.Height = 24
            guna2DataGridView1.SelectionMode = Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            guna2DataGridView1.Size = New Drawing.Size(736, 135)
            guna2DataGridView1.TabIndex = 24
            guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Drawing.Color.White
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Drawing.Color.Empty
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Drawing.Color.Empty
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Drawing.Color.Empty
            guna2DataGridView1.ThemeStyle.BackColor = Drawing.Color.White
            guna2DataGridView1.ThemeStyle.GridColor = Drawing.Color.FromArgb(231, 229, 255)
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Drawing.Color.FromArgb(100, 88, 255)
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = Windows.Forms.DataGridViewHeaderBorderStyle.None
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New Drawing.Font("Segoe UI", 10.5F)
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Drawing.Color.White
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4
            guna2DataGridView1.ThemeStyle.ReadOnly = True
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Drawing.Color.White
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = New Drawing.Font("Segoe UI", 10.5F)
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Drawing.Color.FromArgb(71, 69, 94)
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Drawing.Color.FromArgb(231, 229, 255)
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Drawing.Color.FromArgb(71, 69, 94)
            ' 
            ' guna2Button1
            ' 
            guna2Button1.CheckedState.Parent = guna2Button1
            guna2Button1.CustomImages.Parent = guna2Button1
            guna2Button1.FillColor = Drawing.Color.Transparent
            guna2Button1.Font = New Drawing.Font("Segoe UI", 9F)
            guna2Button1.ForeColor = Drawing.SystemColors.Window
            guna2Button1.HoverState.Parent = guna2Button1
            guna2Button1.Image = Global.DVLD_Project.Properties.Resources.icons8_calendar_plus_64
            guna2Button1.ImageSize = New Drawing.Size(50, 50)
            guna2Button1.Location = New Drawing.Point(696, 604)
            guna2Button1.Name = "guna2Button1"
            guna2Button1.ShadowDecoration.Parent = guna2Button1
            guna2Button1.Size = New Drawing.Size(75, 65)
            guna2Button1.TabIndex = 23
            AddHandler guna2Button1.Click, New EventHandler(AddressOf guna2Button1_Click)
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Image = Global.DVLD_Project.Properties.Resources.icons8_eye_64
            pictureBox1.Location = New Drawing.Point(281, 12)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(246, 76)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox1.TabIndex = 12
            pictureBox1.TabStop = False
            ' 
            ' contextMenuStrip1
            ' 
            contextMenuStrip1.ImageScalingSize = New Drawing.Size(20, 20)
            contextMenuStrip1.Items.AddRange(New Windows.Forms.ToolStripItem() {editDateToolStripMenuItem, takeExamToolStripMenuItem})
            contextMenuStrip1.Name = "contextMenuStrip1"
            contextMenuStrip1.Size = New Drawing.Size(215, 84)
            ' 
            ' editDateToolStripMenuItem
            ' 
            editDateToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_date_64
            editDateToolStripMenuItem.Name = "editDateToolStripMenuItem"
            editDateToolStripMenuItem.Size = New Drawing.Size(214, 26)
            editDateToolStripMenuItem.Text = "Edit Date"
            AddHandler editDateToolStripMenuItem.Click, New EventHandler(AddressOf editDateToolStripMenuItem_Click)
            ' 
            ' takeExamToolStripMenuItem
            ' 
            takeExamToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_test_64
            takeExamToolStripMenuItem.Name = "takeExamToolStripMenuItem"
            takeExamToolStripMenuItem.Size = New Drawing.Size(214, 26)
            takeExamToolStripMenuItem.Text = "Take Exam"
            AddHandler takeExamToolStripMenuItem.Click, New EventHandler(AddressOf takeExamToolStripMenuItem_Click)
            ' 
            ' getAppInfo1
            ' 
            getAppInfo1.Location = New Drawing.Point(35, 131)
            getAppInfo1.Name = "getAppInfo1"
            getAppInfo1.Size = New Drawing.Size(736, 152)
            getAppInfo1.TabIndex = 15
            ' 
            ' getApplcationBisicInformations1
            ' 
            getApplcationBisicInformations1.Location = New Drawing.Point(32, 236)
            getApplcationBisicInformations1.Name = "getApplcationBisicInformations1"
            getApplcationBisicInformations1.Size = New Drawing.Size(739, 373)
            getApplcationBisicInformations1.TabIndex = 16
            ' 
            ' Form16
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(800, 821)
            ContextMenuStrip = contextMenuStrip1
            Controls.Add(guna2DataGridView1)
            Controls.Add(guna2Button1)
            Controls.Add(getAppInfo1)
            Controls.Add(getApplcationBisicInformations1)
            Controls.Add(label1)
            Controls.Add(pictureBox1)
            Name = "Form16"
            StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Text = "Form16"
            AddHandler Load, New EventHandler(AddressOf Form16_Load)
            CType(guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            contextMenuStrip1.ResumeLayout(False)
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private label1 As Windows.Forms.Label
        Private pictureBox1 As Windows.Forms.PictureBox
        Private getAppInfo1 As GetAppInfo
        Private getApplcationBisicInformations1 As GetApplcationBisicInformations
        Private guna2Button1 As Guna.UI2.WinForms.Guna2Button
        Private guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
        Private contextMenuStrip1 As Windows.Forms.ContextMenuStrip
        Private editDateToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private takeExamToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    End Class
End Namespace
