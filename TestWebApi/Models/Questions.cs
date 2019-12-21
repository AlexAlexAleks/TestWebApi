using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApi.Models
{
    public class Questions
    {
        public int Id { get; set; }

        public string Text { get; set; }
        public int TestId { get; set; }
    }
}
