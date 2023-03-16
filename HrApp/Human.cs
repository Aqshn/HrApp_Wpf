﻿using System;

namespace Human
{
    public class Human
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString() => $@"Name: {Name} Surname: {Surname} BirthDate: {BirthDate.Date}";
    }
}