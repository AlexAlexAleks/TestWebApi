using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApi.Models
{
    public class Results
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public int Result { get; set; }
        public DateTime Duration { get; set; }
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
