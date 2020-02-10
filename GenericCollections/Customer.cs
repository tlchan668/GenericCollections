using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollections {
    class Customer {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; } = true;//give default

        //add a constructor
        public Customer(int Id,string Name, bool Active) {
            this.Id = Id;  //the this is property Id is the parameter passed 
            //this talks about a property or method in the class helpful to determine
            //property from parameter
            //property = parameter setting values of property
            this.Name = Name;
            this.Active = Active;
        }
      //default constructor with no params
        public Customer() { }

    }
}
