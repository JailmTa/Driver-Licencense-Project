Namespace DVLD_Project
    Partial Class Form4
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
            getInformations2 = New GetInformations()
            SuspendLayout()
            ' 
            ' getInformations2
            ' 
            getInformations2.Location = New Drawing.Point(0, -1)
            getInformations2.Name = "getInformations2"
            getInformations2.Size = New Drawing.Size(739, 373)
            getInformations2.TabIndex = 0
            AddHandler getInformations2.Load, New EventHandler(AddressOf getInformations2_Load_1)
            ' 
            ' Form4
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(751, 384)
            Controls.Add(getInformations2)
            Name = "Form4"
            Text = "Form4"
            AddHandler Load, New EventHandler(AddressOf Form4_Load)
            ResumeLayout(False)

        End Sub

#End Region

        Private getInformations1 As GetInformations
        Private getInformations2 As GetInformations
    End Class
End Namespace
