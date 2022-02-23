using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsWPF.Models
{
    public class ContactModel
    {
        public string? ID { get; set; }
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Patronymic { get; set; } // Отчество
        public string? Phone { get; set; } // int?

        public string FullName
        {
            get
            {
                return $"{Surname} {Name} {Patronymic}".Trim();
                //string fullname = $"{Surname} {Name} {Patronymic}".Trim();
                //if (!String.IsNullOrEmpty(fullname))
                //    return fullname;
                //else
                //    return Phone
            }
        }

    }
}
