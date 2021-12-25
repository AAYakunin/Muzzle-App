using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzzle_App
{
    public class Service
    {
        public int ID { get; private set; }

        public int ServiceID { get; private set; }

        public string Title { get; private set; }

        public string Date { get; private set; }

        public string Comment { get; private set; }

        public Service(int id, int serviceID, string title, string date, string comment)
        {
            ID = id;
            ServiceID = serviceID;
            Date = date;
            Title = title; 
            Comment = comment;
        }

    }
}
