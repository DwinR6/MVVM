using MVVM.Model;
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
        public StudentViewModel()
        {
            MyStudent = new StudentModel();
            BotonCommand = new Command(Metodo);

        }

        private void Metodo()
        {
            App.Current.MainPage.DisplayAlert("Estudiante", MyStudent.Nombre,"Ok");
        }
    }
}
