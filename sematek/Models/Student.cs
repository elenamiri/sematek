using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace sematek.Models;
        

    public class Student : users
    {
        public Student(string firstname,string lastname,string nationalcode, string phonenumber)
        {
        FirstName=firstname;
        LastName=lastname;
        NationalCode=nationalcode;
        PhoneNumber=phonenumber;
        
        }

        //AccessModifier DataType Name { get; set; }
        public int Id { get; set; } 
    
        public DateTime CreatedAt { get; set; }
        public enums.gender gender { get; set; }



}

