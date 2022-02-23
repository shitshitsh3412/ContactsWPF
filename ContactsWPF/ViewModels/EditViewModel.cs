using ContactsWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ContactsWPF.ViewModels
{
    public class EditViewModel
    {
        public EditViewModel(ContactModel? contact)
        {
            //if (contact != null)
            //{
            //    Surname = contact.Surname;
            //    Name = contact.Name;
            //    Patronymic = contact.Patronymic;
            //    Phone = contact.Phone;
            //}
        }
        public EditViewModel()
        {
            //Surname = "Test";
        }

        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Patronymic { get; set; }
        public string? Phone { get; set; }


        public void Delete()
        {
            MessageBox.Show("Delete");
        }
    }
}
