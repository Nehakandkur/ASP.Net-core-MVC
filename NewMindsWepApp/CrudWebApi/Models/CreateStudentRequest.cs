﻿namespace CrudWebApi.Models
{
    public class CreateStudentRequest
    {

        public Guid Id { get; set; }


        public string Name { get; set; }


        public int age { get; set; }


        public long PhoneNumber { get; set; }


        public string? Address { get; set; }
    }
}
