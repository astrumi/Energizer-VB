Imports System.ComponentModel
Imports System.Windows.Forms

Public Class FLoading

    Private WithEvents _worker As BackgroundWorker

    Public Sub New(worker As BackgroundWorker)
        InitializeComponent()

        ' Store the BackgroundWorker instance
        _worker = worker
    End Sub

    Private Sub _worker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles _worker.ProgressChanged
        ' Update the progress bar
        prgLoad.Value = e.ProgressPercentage

        ' Update the label with the user state string
        If e.UserState IsNot Nothing Then
            lblLoad.Text = e.UserState.ToString()
        End If
    End Sub

    Private Sub _worker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles _worker.RunWorkerCompleted
        ' Check for any errors that occurred during the operation
        If e.Error IsNot Nothing Then
            MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Close the dialog when the BackgroundWorker is done
        Me.Close()
    End Sub

End Class
