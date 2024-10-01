using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readers.Models
{
    public class BookPoint
    {
        public BookPoint() { }


        public BookPoint(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
