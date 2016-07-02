using System;
using System.ComponentModel.DataAnnotations;

namespace HelperMethods.Models {

    [MetadataType(typeof(PersonMetadata))]
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
        [Display(Name = "Address")]
        public string Line1 { get; set; }
        [Display(Name = "APT/UNIT")]
        public string Line2 { get; set; }
        public string City { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    public enum Role {
        Admin,
        User,
        Guest
    }
}