using MVVM.Model;
using MVVM.View;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MVVM.ViewModel
{
    public class StudentViewModel
    {
        public StudentModel MyStudent { get; set; }
        public Command BotonCommand { get; set; }
        public Command InscripcionCarrera { get; set; }
        public StudentViewModel()
        {
            MyStudent = new StudentModel();
            BotonCommand = new Command(Metodo);
            InscripcionCarrera = new Command(IrACarrera);
        }

        private void IrACarrera()
        {
            App.Current.MainPage.Navigation.PushAsync(new CarreraView());
        }

        private void Metodo()
        {
            App.Current.MainPage.DisplayAlert("Estudiante", MyStudent.Nombre,"Ok");
        }

    }
}
