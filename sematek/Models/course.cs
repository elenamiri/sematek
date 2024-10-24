using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace sematek.Models;

    public class course
    {
    public int Id { get; set; }
    public Guid Code { get; set; }
    public string Title { get; set; }
    public int Duration { get;}
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }

}

