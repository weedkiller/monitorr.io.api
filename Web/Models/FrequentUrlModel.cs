﻿using Core.Domain;

namespace Web.Models
{
    public class FrequentUrlModel
    {
        public string Message { get; set; }
        public int Count { get; set; }
        public Severity Severity { get; set; }
    }
}