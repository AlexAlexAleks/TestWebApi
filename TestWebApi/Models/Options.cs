﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApi.Models
{
    public class Options
    {
        public int Id { get; set; }
        public string Text{ get; set; }
        public bool IsCorrect { get; set; }
        public int QuestionId { get; set; }

    }
}