Imports DevExpress.Mvvm
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics

Namespace dxDialog1.ViewModels
    Public Class MainViewModel
        Inherits ViewModelBase

        Protected ReadOnly Property DialogService() As IDialogService
            Get
                Return Me.GetService(Of IDialogService)()
            End Get
        End Property

        Private dialogViewModel As DialogViewModel = Nothing

        Public Sub New()
            ShowDialogCommand = New DelegateCommand(AddressOf ShowDialog)
        End Sub

        Private privateShowDialogCommand As DelegateCommand
        Public Property ShowDialogCommand() As DelegateCommand
            Get
                Return privateShowDialogCommand
            End Get
            Private Set(ByVal value As DelegateCommand)
                privateShowDialogCommand = value
            End Set
        End Property

        Public Async Sub ShowDialog()
            If dialogViewModel Is Nothing Then
                dialogViewModel = New DialogViewModel()
            End If

            Dim result = Await DialogService.ShowDialogAsync(MessageButton.YesNoCancel, "My Dialog Window", dialogViewModel)

        End Sub

    End Class
End Namespace
