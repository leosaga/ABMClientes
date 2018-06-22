Public Class Form1
    Dim operacion_ As String



    Dim micliente As New ClientesClass

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property
    Dim indice_ As Byte
    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set
    End Property

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' no deja pasar sin poner nada
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("ingrese una categoria de iva")
            Exit Sub
        End If
        'para validar los texbox que no queden en blanco primer caso
        ' no deja pasar sin poner nada
        If TextBox1.Text = "" Then
            MsgBox("ingrese un id")
            Exit Sub
        End If
        ' no deja pasar sin poner nada
        If TextBox2.Text.Trim = "" Then
            MsgBox("ingrese un nombre")
            Exit Sub
        End If
        ' no deja pasar sin poner nada
        If TextBox3.Text = "" Then
            MsgBox("ingrese una direccion")
            Exit Sub
            ' no deja pasar sin poner nada
            If TextBox4.Text = "" Then
                MsgBox("ingrese un saldo")
                Exit Sub
            End If

        End If
        'para validar los texbox que no queden en blanco segundo caso
        ' if TextBox1.Text=""or TextBox2.Text"" or TextBox3.Text"" or TextBox4.Text"" Then 

        'MsgBox("no debe tener campos en blanco")
        'exit sub
        micliente.id = CInt(TextBox1.Text)


        micliente.nombre = TextBox2.Text


        micliente.direccion = TextBox3.Text

        micliente.saldo = TextBox4.Text

        micliente.categiva = ComboBox1.SelectedItem


        Select Case operacion_
            Case "alta"
                lst.Add(micliente)
            Case "elimina"
                lst.RemoveAt(indice_)
            Case "modifica"
                lst.Item(indice_) = micliente

                GrillaClientes.DataGridView1.Refresh()

        End Select
        Me.Close()
    End Sub




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then

            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then


        End If
    End Sub

   
    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
