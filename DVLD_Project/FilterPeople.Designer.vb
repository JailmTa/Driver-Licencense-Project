Namespace DVLD_Project
    Partial Class FilterPeople
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

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            label2 = New Windows.Forms.Label()
            guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
            cbFilters = New Guna.UI2.WinForms.Guna2ComboBox()
            guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
            SuspendLayout()
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Font = New Drawing.Font("Modern No. 20", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label2.Location = New Drawing.Point(20, 20)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(56, 22)
            label2.TabIndex = 12
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
            guna2TextBox1.Location = New Drawing.Point(366, 14)
            guna2TextBox1.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            guna2TextBox1.Name = "guna2TextBox1"
            guna2TextBox1.PasswordChar = ChrW(0)
            guna2TextBox1.PlaceholderText = ""
            guna2TextBox1.SelectedText = ""
            guna2TextBox1.ShadowDecoration.Parent = guna2TextBox1
            guna2TextBox1.Size = New Drawing.Size(267, 35)
            guna2TextBox1.TabIndex = 11
            AddHandler guna2TextBox1.TextChanged, New EventHandler(AddressOf guna2TextBox1_TextChanged)
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
            cbFilters.Location = New Drawing.Point(96, 13)
            cbFilters.Name = "cbFilters"
            cbFilters.ShadowDecoration.Parent = cbFilters
            cbFilters.Size = New Drawing.Size(263, 36)
            cbFilters.TabIndex = 10
            AddHandler cbFilters.SelectedIndexChanged, New EventHandler(AddressOf cbFilters_SelectedIndexChanged)
            ' 
            ' guna2Button4
            ' 
            guna2Button4.CheckedState.Parent = guna2Button4
            guna2Button4.CustomImages.Parent = guna2Button4
            guna2Button4.FillColor = Drawing.Color.Transparent
            guna2Button4.Font = New Drawing.Font("Segoe UI", 9F)
            guna2Button4.ForeColor = Drawing.SystemColors.Window
            guna2Button4.HoverState.Parent = guna2Button4
            guna2Button4.Image = Global.DVLD_Project.Properties.Resources.icons8_add_male_user_64
            guna2Button4.ImageSize = New Drawing.Size(64, 64)
            guna2Button4.Location = New Drawing.Point(824, 0)
            guna2Button4.Name = "guna2Button4"
            guna2Button4.ShadowDecoration.Parent = guna2Button4
            guna2Button4.Size = New Drawing.Size(75, 65)
            guna2Button4.TabIndex = 21
            ' 
            ' guna2Button3
            ' 
            guna2Button3.CheckedState.Parent = guna2Button3
            guna2Button3.CustomImages.Parent = guna2Button3
            guna2Button3.FillColor = Drawing.Color.Transparent
            guna2Button3.Font = New Drawing.Font("Segoe UI", 9F)
            guna2Button3.ForeColor = Drawing.SystemColors.Window
            guna2Button3.HoverState.Parent = guna2Button3
            guna2Button3.Image = Global.DVLD_Project.Properties.Resources.icons8_search_account_64
            guna2Button3.ImageSize = New Drawing.Size(64, 64)
            guna2Button3.Location = New Drawing.Point(763, 0)
            guna2Button3.Name = "guna2Button3"
            guna2Button3.ShadowDecoration.Parent = guna2Button3
            guna2Button3.Size = New Drawing.Size(65, 65)
            guna2Button3.TabIndex = 20
            ' 
            ' FilterPeople
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            Controls.Add(guna2Button4)
            Controls.Add(guna2Button3)
            Controls.Add(label2)
            Controls.Add(guna2TextBox1)
            Controls.Add(cbFilters)
            Name = "FilterPeople"
            Size = New Drawing.Size(899, 64)
            AddHandler Load, New EventHandler(AddressOf FilterPeople_Load)
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private label2 As Windows.Forms.Label
        Private guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
        Private cbFilters As Guna.UI2.WinForms.Guna2ComboBox
        Private guna2Button4 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button3 As Guna.UI2.WinForms.Guna2Button
    End Class
End Namespace
