using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HelperMethods.Models {

    [MetadataType(typeof(PersonMetaData))]
    public partial class Person {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Address HomeAddress { get; set; }
        public bool IsApproved { get; set; }
        public Role Role { get; set; }
    }

    //revised to partial class
    /*[DisplayName("New Person")]
    public class Person {
        [HiddenInput(DisplayValue=false)]
        public int PersonId { get; set; }

        [Display(Name ="First")]
        [UIHint("MultilineText")]
        public string FirstName { get; set; }

        [Display(Name ="Last")]
        public string LastName { get; set; }

        [Display(Name ="Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public Address HomeAddress { get; set; }

        [Display(Name ="Approved")]
        public bool IsApproved { get; set; }
        public Role Role { get; set; }
    }*/

    public class Address {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    public enum Role {
        Admin,
        User,
        Guest
    }
}