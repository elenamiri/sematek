#nullable disable

namespace sematek.Models
{
    public class users
    {
     
        public string FirstName { get;  set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string NationalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
       
       
       
    }
}
