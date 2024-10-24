using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sematek.Utilities;

    public static class CleanData
    {
    /// <summary>
    /// clean the phoneNumber
    /// </summary>
    /// <param name="phonenumber">phonenumber </param>
    /// <returns>clean phonenumber</returns>
      public static string PhoneNumber(string phonenumber)
      {
        if(string.IsNullOrEmpty(phonenumber))
         return string.Empty;

        phonenumber = phonenumber.Trim().Replace("+98", "0").Replace("0098", "0");
        phonenumber= phonenumber.Length == 10 ? "0" + phonenumber : phonenumber;
        return phonenumber;
    
    
      }
    }

