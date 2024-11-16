Imports BussnessLayerForDVLD

Namespace DVLD_Project
    Partial Class Form8
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
            getInformations1 = New GetInformations()
            userInfo1 = New UserInfo(clsBussnesLayer.GetUserID())
            SuspendLayout()
            ' 
            ' getInformations1
            ' 
            getInformations1.Location = New Drawing.Point(81, 12)
            getInformations1.Name = "getInformations1"
            getInformations1.Size = New Drawing.Size(739, 373)
            getInformations1.TabIndex = 0
            AddHandler getInformations1.Load, New EventHandler(AddressOf getInformations1_Load)
            ' 
            ' userInfo1
            ' 
            userInfo1.Location = New Drawing.Point(81, 381)
            userInfo1.Name = "userInfo1"
            userInfo1.Size = New Drawing.Size(739, 91)
            userInfo1.TabIndex = 1
            ' 
            ' Form8
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(882, 528)
            Controls.Add(userInfo1)
            Controls.Add(getInformations1)
            Name = "Form8"
            Text = "Form8"
            AddHandler Load, New EventHandler(AddressOf Form8_Load)
            ResumeLayout(False)

        End Sub

#End Region

        Private getInformations1 As GetInformations
        Private userInfo1 As UserInfo
    End Class
End Namespace
