﻿using System.ComponentModel.DataAnnotations;
namespace WebRepo.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
        public string adress { get; set; }

    }
}
