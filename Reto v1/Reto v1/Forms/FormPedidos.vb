Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class FormPedidos

    Private btnPanel As IconButton
    Private nuevoBoton As Panel
    Private Sub FormPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        nuevoBoton = New Panel()
        nuevoBoton.Size = New Size(7, 104)
        PanelMenu.Controls.Add(nuevoBoton)

        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
        WindowState = FormWindowState.Maximized
    End Sub
    Private Sub ActivateButton(senderbtn As Object, customColor As Color)
        If senderbtn IsNot Nothing Then
            disableButton()
            btnPanel = CType(senderbtn, IconButton)
            btnPanel.BackColor = Color.MediumSlateBlue
            btnPanel.ForeColor = customColor
            btnPanel.IconColor = customColor
            btnPanel.TextAlign = ContentAlignment.MiddleCenter
            btnPanel.ImageAlign = ContentAlignment.MiddleRight
            btnPanel.TextImageRelation = TextImageRelation.TextBeforeImage

            nuevoBoton.BackColor = customColor
            nuevoBoton.Location = New Point(0, btnPanel.Location.Y)
            nuevoBoton.Visible = True
            nuevoBoton.BringToFront()

        End If
    End Sub

    Private Sub disableButton()
        If btnPanel IsNot Nothing Then
            btnPanel.BackColor = Color.SkyBlue
            btnPanel.ForeColor = Color.Black
            btnPanel.IconColor = Color.Black
            btnPanel.TextAlign = ContentAlignment.MiddleLeft
            btnPanel.ImageAlign = ContentAlignment.MiddleLeft
            btnPanel.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub ibPrincipal_Click(sender As Object, e As EventArgs) Handles ibPrincipal.Click
        ActivateButton(sender, Color.SkyBlue)
        'OpenChildForm(New FormArticulos)
    End Sub
    Private Sub ibBebidas_Click(sender As Object, e As EventArgs) Handles ibBebidas.Click
        ActivateButton(sender, Color.SkyBlue)
    End Sub

    Private Sub ibEntrantes_Click(sender As Object, e As EventArgs) Handles ibEntrantes.Click
        ActivateButton(sender, Color.SkyBlue)
    End Sub

    <DllImport("user32.DLL”, EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapure()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal Wind As System.IntPtr, ByVal wii As Integer, ByVal waram As Integer, ByVal Param As Integer)
    End Sub


End Class