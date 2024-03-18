using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSortCSharp
{
    public class Book
    {

        public int Pages { get; set; }

        public override string ToString()
        {
            return Pages.ToString();
        }
    }
}
