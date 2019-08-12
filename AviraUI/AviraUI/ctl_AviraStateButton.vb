Imports Guna.UI.WinForms
Imports System.ComponentModel

<DefaultEvent("ButtonClick")>
Public Class ctl_AviraStateButton


    Private _image As Image
    Public Property Image As Image
        Get
            Return _image
        End Get
        Set(value As Image)
            _image = value
            GunaPictureBox1.Image = value
            GunaMouseStateHelper1.RefreshMouseState()
        End Set
    End Property


    Private _OnHoverImage As Image
    Public Property OnHoverImage As Image
        Get
            Return _OnHoverImage
        End Get
        Set(value As Image)
            _OnHoverImage = value
            GunaMouseStateHelper1.RefreshMouseState()
        End Set
    End Property

    Public Property ButtonText As String
        Get
            Return GunaLabel1.Text
        End Get
        Set(value As String)
            GunaLabel1.Text = value
            GunaMouseStateHelper1.RefreshMouseState()
        End Set
    End Property


    Enum StateButtonEnum
        [ON]
        [OFF]
        PRO
    End Enum


    Private _StateButton As StateButtonEnum
    Public Property StateButton As StateButtonEnum
        Get
            Return _StateButton
        End Get
        Set(value As StateButtonEnum)
            _StateButton = value
            Select Case value
                Case StateButtonEnum.OFF
                    GunaButton1.BaseColor = Color.FromArgb(219, 13, 21)
                    GunaButton1.Text = "OFF"
                Case StateButtonEnum.ON
                    GunaButton1.BaseColor = Color.FromArgb(67, 186, 73)
                    GunaButton1.Text = "ON"
                Case StateButtonEnum.PRO
                    GunaButton1.BaseColor = Color.FromArgb(255, 143, 0)
                    GunaButton1.Text = "PRO"
            End Select
            GunaMouseStateHelper1.RefreshMouseState()
        End Set
    End Property

    Private Sub GunaMouseStateHelper1_MouseStateChanged(sender As Object, state As MouseState) Handles GunaMouseStateHelper1.MouseStateChanged
        If state = MouseState.DOWN Or state = MouseState.HOVER Then
            GunaPictureBox1.Image = Me.OnHoverImage
            GunaLabel1.ForeColor = Color.FromArgb(66, 66, 66)
        Else
            GunaPictureBox1.Image = Me.Image
            GunaLabel1.ForeColor = Color.FromArgb(117, 117, 117)
        End If
        Invalidate()
    End Sub

    Event ButtonClick As EventHandler
    Private Sub GunaMouseStateHelper1_Click(sender As Object, e As EventArgs) Handles GunaMouseStateHelper1.Click
        RaiseEvent ButtonClick(Me, EventArgs.Empty)
    End Sub
End Class
