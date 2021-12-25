using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzzle_App
{
    public class Client
    {
        public int id { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string patronymic { get; private set; }
        public string birthday { get; private set; }
        public string registrationDate { get; private set; }
        public string email { get; private set; }
        public string phone { get; private set; }
        public string gender { get; private set; }

        public List<Service> services { get; set; }

        public Client(int id, string firstName, string lastName, string patronymic, string birthday, string registrationDate, string email, string phone, int gender)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.patronymic = patronymic;
            string[] arr = birthday.Split();
            this.birthday = arr[0];
            arr = registrationDate.Split();
            this.registrationDate = arr[0];
            this.email = email;
            this.phone = phone;
            if (gender == 0)
                this.gender = "Мужской";
            else
                this.gender = "Женский";
        }
    }
}
