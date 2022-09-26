using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStores
{
    class Medical
    {
        public Medical( string Name, string City, string State, string Pvt )
        {
            this.Name = Name;
            this.City = City;
            this.State = State;
            this.Pvt = Pvt;

        }

        public string Name{ get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pvt { get; set; }
    }
}
