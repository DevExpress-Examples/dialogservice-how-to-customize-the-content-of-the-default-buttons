using DevExpress.Mvvm;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace dxDialog1.ViewModels {
    public class MainViewModel : ViewModelBase {
        protected IDialogService DialogService { get { return this.GetService<IDialogService>(); } }

        DialogViewModel dialogViewModel = null;

        public MainViewModel() {
            ShowDialogCommand = new DelegateCommand(ShowDialog);
        }

        public DelegateCommand ShowDialogCommand { get; private set; } 

        public async void ShowDialog() {
            if(dialogViewModel == null)
                dialogViewModel = new DialogViewModel();

            var result = await DialogService.ShowDialogAsync(MessageButton.YesNoCancel,
                "My Dialog Window",
                dialogViewModel);

        }

    }
}
