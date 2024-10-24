using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace sematek.Models;

public class Master : users
{
    public int Id { get; set; }
   
    public DateTime CreatedAt { get; set; }
}
