Imports System
Imports System.IO
Imports System.Text
Public Class BanchouPatcher

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Origen.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirOrigen.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Origen.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Comprimir.CheckedChanged

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub Patch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Patch.Click
        'Obteniendo información del origen
        Dim informationOrigen As System.IO.FileInfo
        informationOrigen = My.Computer.FileSystem.GetFileInfo(Origen.Text)
        Dim PathOrigen As String = informationOrigen.DirectoryName
        Dim NombreOrigen As String = informationOrigen.Name
        'Obteniendo información del destino
        Dim informationDestino As System.IO.FileInfo
        informationDestino = My.Computer.FileSystem.GetFileInfo(Destino.Text)
        Dim PathDestino As String = informationDestino.DirectoryName
        Dim NombreDestino As String = informationDestino.Name
        Dim DirParche As String = DirDestino.Text
        Dim PrefijoParche As String = Prefijo.Text
        Dim TextoLeeme As String = ("MUY IMPORTANTE" & vbCrLf & vbCrLf & "Usuarios de Windows:" & vbCrLf & "Copien el archivo a parchar y ejecuten el .bat que viene incluido." & vbCrLf & vbCrLf & "Usuarios de Linux:" & vbCrLf & "Asegúrense de tener instalada en su distribución el paquete xdelta3. Una vez revisado este punto, copien el archivo a parchar y ejecuten el script en Bash que viene incluido." & vbCrLf & vbCrLf & "Usuarios de Mac:" & vbCrLf & "No hay solución por el momento.")
        If Origen.Text = ("Abrir archivo origen") Or Destino.Text = ("Abrir archivo destino") Or Prefijo.Text = ("Nombre del parche") Or DirDestino.Text = ("Abrir directorio destino") Then
            MsgBox("Los campos no pueden ir por defecto")
        Else
            Estado.Text = ("Creando scripts del parche...")
            ' Creamos los scripts
            Dim fs1 As FileStream = File.Create(DirParche & "\" & PrefijoParche & ".bat")
            Dim info1 As Byte() = New UTF8Encoding(True).GetBytes("@echo off" & vbCrLf & "echo Archivo generado por BanchouPatcher" & vbCrLf & "xdelta3 -d -s """ & NombreOrigen & """" & " """ & PrefijoParche & ".vcdiff""" & " """ & NombreDestino & """" & vbCrLf & "pause")
            fs1.Write(info1, 0, info1.Length)
            fs1.Close()
            Dim fs2 As FileStream = File.Create(DirParche & "\" & PrefijoParche & ".sh")
            Dim info2 As Byte() = New UTF8Encoding(True).GetBytes("#!/bin/bash" & vbCrLf & "echo ""Archivo generado por BanchouPatcher.""" & vbCrLf & "xdelta3 -d -s """ & NombreOrigen & """" & " """ & PrefijoParche & ".vcdiff""" & " """ & NombreDestino & """" & vbCrLf & "if [ "" $? "" = "" 0 ""]; then echo ""Parche aplicado correctamente.""" & vbCrLf & "else" & vbCrLf & "echo ""Ups, algo salió mal. Revisa el nombre de los archivos y que se encuentren en el mismo directorio"" 1 > &2 " & vbCrLf & "exit 1" & vbCrLf & "fi")
            fs2.Write(info2, 0, info2.Length)
            fs2.Close()
            Dim fs3 As FileStream = File.Create(DirParche & "\" & "leeme.txt")
            Dim info3 As Byte() = New UTF8Encoding(True).GetBytes(TextoLeeme)
            fs3.Write(info3, 0, info3.Length)
            fs3.Close()
            ' Terminando de crear los scripts
            ' Creando parche
            Shell(My.Computer.FileSystem.CurrentDirectory & "\xdelta3.exe" & " -e -s """ & informationOrigen.FullName & """ """ & informationDestino.FullName & """ """ & DirParche & "\" & PrefijoParche & ".vcdiff""", , True)
            'Copiando xdelta3 para windows
            My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.CurrentDirectory & "\xdelta3.exe", DirParche & "\xdelta3.exe", Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            'Se comprimen los archivos si se requirió
            If Comprimir.CheckState = 1 Then
                Estado.Text = "Comprimiendo archivos intermedios."
                Shell(My.Computer.FileSystem.CurrentDirectory & "\zip.exe -j """ & DirParche & "\" & PrefijoParche & ".zip"" """ & DirParche & "\" & PrefijoParche & ".vcdiff"" """ & DirParche & "\" & PrefijoParche & ".sh"" """ & DirParche & "\" & PrefijoParche & ".bat"" """ & DirParche & "\leeme.txt"" """ & DirParche & "\" & "xdelta3.exe""", , True)
                Estado.Text = "Borrando archivos intermedios."
                My.Computer.FileSystem.DeleteFile(DirParche & "\" & PrefijoParche & ".vcdiff")
                My.Computer.FileSystem.DeleteFile(DirParche & "\" & PrefijoParche & ".sh")
                My.Computer.FileSystem.DeleteFile(DirParche & "\" & PrefijoParche & ".bat")
                My.Computer.FileSystem.DeleteFile(DirParche & "\" & "xdelta3.exe")
                My.Computer.FileSystem.DeleteFile(DirParche & "\" & "leeme.txt")
            End If
            Estado.Text = "Listo."
            MsgBox("Parche creado satisfactoriamente.")
            ' Terminando parche
        End If
    End Sub

    Private Sub AbrirDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirDestino.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Destino.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub AbrirDirDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirDirDestino.Click

        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            DirDestino.Text = FolderBrowserDialog1.SelectedPath

        End If
    End Sub

    Private Sub DirDestino_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirDestino.TextChanged
    End Sub

    Private Sub Destino_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Destino.TextChanged

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AcercaDe.Show()

    End Sub
End Class
