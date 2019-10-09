using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MVVM.ViewModel
{
    public class CarreraViewModel
    {
        public Command RegresarCommand { get; set; }
        public Command IrARoot { get; set; }
        public CarreraViewModel()
        {
            RegresarCommand = new Command(Atras);
            IrARoot = new Command(IrRoot);
        }

        private void Atras()
        {
            App.Current.MainPage.Navigation.PopAsync();
        }
        private void IrRoot()
        {
            App.Current.MainPage.Navigation.PopToRootAsync();
        }
    }
}
