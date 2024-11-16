Namespace DVLD_Project
    Partial Class Form18
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
            Dim dataGridViewCellStyle4 As Windows.Forms.DataGridViewCellStyle = New Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As Windows.Forms.DataGridViewCellStyle = New Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As Windows.Forms.DataGridViewCellStyle = New Windows.Forms.DataGridViewCellStyle()
            guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
            label1 = New Windows.Forms.Label()
            pictureBox1 = New Windows.Forms.PictureBox()
            label2 = New Windows.Forms.Label()
            guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
            cbFilters = New Guna.UI2.WinForms.Guna2ComboBox()
            CType(guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' guna2DataGridView1
            ' 
            guna2DataGridView1.AllowUserToAddRows = False
            guna2DataGridView1.AllowUserToDeleteRows = False
            dataGridViewCellStyle4.BackColor = Drawing.Color.White
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4
            guna2DataGridView1.AutoSizeColumnsMode = Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            guna2DataGridView1.BackgroundColor = Drawing.Color.White
            guna2DataGridView1.BorderStyle = Windows.Forms.BorderStyle.None
            guna2DataGridView1.CellBorderStyle = Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            guna2DataGridView1.ColumnHeadersBorderStyle = Windows.Forms.DataGridViewHeaderBorderStyle.None
            dataGridViewCellStyle5.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle5.BackColor = Drawing.Color.FromArgb(100, 88, 255)
            dataGridViewCellStyle5.Font = New Drawing.Font("Segoe UI", 10.5F)
            dataGridViewCellStyle5.ForeColor = Drawing.Color.White
            dataGridViewCellStyle5.SelectionBackColor = Drawing.SystemColors.Highlight
            dataGridViewCellStyle5.SelectionForeColor = Drawing.SystemColors.HighlightText
            dataGridViewCellStyle5.WrapMode = Windows.Forms.DataGridViewTriState.True
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5
            guna2DataGridView1.ColumnHeadersHeight = 40
            dataGridViewCellStyle6.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle6.BackColor = Drawing.Color.White
            dataGridViewCellStyle6.Font = New Drawing.Font("Segoe UI", 10.5F)
            dataGridViewCellStyle6.ForeColor = Drawing.Color.FromArgb(71, 69, 94)
            dataGridViewCellStyle6.SelectionBackColor = Drawing.Color.FromArgb(231, 229, 255)
            dataGridViewCellStyle6.SelectionForeColor = Drawing.Color.FromArgb(71, 69, 94)
            dataGridViewCellStyle6.WrapMode = Windows.Forms.DataGridViewTriState.False
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6
            guna2DataGridView1.EnableHeadersVisualStyles = False
            guna2DataGridView1.GridColor = Drawing.Color.FromArgb(231, 229, 255)
            guna2DataGridView1.Location = New Drawing.Point(37, 325)
            guna2DataGridView1.Name = "guna2DataGridView1"
            guna2DataGridView1.ReadOnly = True
            guna2DataGridView1.RowHeadersVisible = False
            guna2DataGridView1.RowHeadersWidth = 51
            guna2DataGridView1.RowTemplate.Height = 24
            guna2DataGridView1.SelectionMode = Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            guna2DataGridView1.Size = New Drawing.Size(1031, 379)
            guna2DataGridView1.TabIndex = 28
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
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40
            guna2DataGridView1.ThemeStyle.ReadOnly = True
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Drawing.Color.White
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = New Drawing.Font("Segoe UI", 10.5F)
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Drawing.Color.FromArgb(71, 69, 94)
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Drawing.Color.FromArgb(231, 229, 255)
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Drawing.Color.FromArgb(71, 69, 94)
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Microsoft Sans Serif", 18F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label1.ForeColor = Drawing.Color.FromArgb(255, 128, 128)
            label1.Location = New Drawing.Point(423, 203)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(240, 36)
            label1.TabIndex = 25
            label1.Text = "Maneage Drivers"
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Image = Global.DVLD_Project.Properties.Resources.icons8_taxi_service_64
            pictureBox1.Location = New Drawing.Point(444, 12)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(198, 173)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox1.TabIndex = 24
            pictureBox1.TabStop = False
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Font = New Drawing.Font("Modern No. 20", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label2.Location = New Drawing.Point(33, 274)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(56, 22)
            label2.TabIndex = 31
            label2.Text = "Filter"
            ' 
            ' guna2TextBox1
            ' 
            guna2TextBox1.AutoRoundedCorners = True
            guna2TextBox1.BorderColor = Drawing.Color.FromArgb(255, 128, 128)
            guna2TextBox1.BorderRadius = 16
            guna2TextBox1.Cursor = Windows.Forms.Cursors.IBeam
            guna2TextBox1.DefaultText = ""
            guna2TextBox1.DisabledState.BorderColor = Drawing.Color.FromArgb(208, 208, 208)
            guna2TextBox1.DisabledState.FillColor = Drawing.Color.FromArgb(226, 226, 226)
            guna2TextBox1.DisabledState.ForeColor = Drawing.Color.FromArgb(138, 138, 138)
            guna2TextBox1.DisabledState.Parent = guna2TextBox1
            guna2TextBox1.DisabledState.PlaceholderForeColor = Drawing.Color.FromArgb(138, 138, 138)
            guna2TextBox1.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            guna2TextBox1.FocusedState.Parent = guna2TextBox1
            guna2TextBox1.HoverState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            guna2TextBox1.HoverState.Parent = guna2TextBox1
            guna2TextBox1.Location = New Drawing.Point(379, 268)
            guna2TextBox1.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            guna2TextBox1.Name = "guna2TextBox1"
            guna2TextBox1.PasswordChar = ChrW(0)
            guna2TextBox1.PlaceholderText = ""
            guna2TextBox1.SelectedText = ""
            guna2TextBox1.ShadowDecoration.Parent = guna2TextBox1
            guna2TextBox1.Size = New Drawing.Size(267, 35)
            guna2TextBox1.TabIndex = 30
            ' 
            ' cbFilters
            ' 
            cbFilters.BackColor = Drawing.Color.Transparent
            cbFilters.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
            cbFilters.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            cbFilters.FocusedColor = Drawing.Color.Empty
            cbFilters.FocusedState.Parent = cbFilters
            cbFilters.Font = New Drawing.Font("Segoe UI", 10F)
            cbFilters.ForeColor = Drawing.Color.FromArgb(68, 88, 112)
            cbFilters.FormattingEnabled = True
            cbFilters.HoverState.Parent = cbFilters
            cbFilters.ItemHeight = 30
            cbFilters.ItemsAppearance.Parent = cbFilters
            cbFilters.Location = New Drawing.Point(109, 267)
            cbFilters.Name = "cbFilters"
            cbFilters.ShadowDecoration.Parent = cbFilters
            cbFilters.Size = New Drawing.Size(263, 36)
            cbFilters.TabIndex = 29
            ' 
            ' Form18
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(1105, 716)
            Controls.Add(label2)
            Controls.Add(guna2TextBox1)
            Controls.Add(cbFilters)
            Controls.Add(guna2DataGridView1)
            Controls.Add(label1)
            Controls.Add(pictureBox1)
            Name = "Form18"
            Text = "Form18"
            AddHandler Load, New EventHandler(AddressOf Form18_Load)
            CType(guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
        Private label1 As Windows.Forms.Label
        Private pictureBox1 As Windows.Forms.PictureBox
        Private label2 As Windows.Forms.Label
        Private guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
        Private cbFilters As Guna.UI2.WinForms.Guna2ComboBox
    End Class
End Namespace
