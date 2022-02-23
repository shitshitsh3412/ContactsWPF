using Caliburn.Micro;
using ContactsWPF.Models;
using ContactsWPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ContactsWPF.ViewModels
{
    public class ShellViewModel
    {
        public BindableCollection<ContactModel> Contacts { get; set; }
        public ShellViewModel()
        {
            Contacts = new BindableCollection<ContactModel> { 
                new ContactModel { ID="Bebra", Name="Имя", Patronymic="Отчество", Phone="+79351314", Surname="Фамилия" },
                new ContactModel { ID="dabara", Name="иииммяяя", Patronymic="оооо", Phone="+71111111", Surname="ффафаф" },
                new ContactModel { ID="z", Name="Яеблан", Patronymic="Хуй", Phone="+71111111", Surname=null },
                new ContactModel { ID="dabara", Name="бебрааываыв", Patronymic="пыапыапыа", Phone="+71111111", Surname="ровпроапоапр" },
            };
        }
        public void AddContact()
        {
            //Contacts.Add(new ContactModel { Name = "New" });
            var contact = new ContactModel();
            ViewContact(contact);
        }
        public void ViewContact(ContactModel contact)
        {
            //MessageBox.Show($"You clicked on: {contact.FullName}");
            EditView edit = new EditView();
            edit.Owner = Application.Current.MainWindow;
            edit.DataContext = contact;
            edit.ShowDialog();
        }

        public bool CanSurname()
        {
            return false;
        }

        public void Delete()
        {
            MessageBox.Show("ShellViewModel");
        }
    }
}
