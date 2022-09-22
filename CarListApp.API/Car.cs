﻿using System.ComponentModel.DataAnnotations;

namespace CarListApp.API.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? Vin { get; set; }
        public string? Color { get; set; }
    }
}
