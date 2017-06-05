﻿using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Entities
{
    public enum CuisineType
    {
        None,
        Italian,
        Arabian,
        French,
        Chinese,
        Japanese
    }
    public class Restaurant
    {
        public int Id { get; set; }
    
        [Required, MaxLength(80)]
        [Display(Name="Restaurant Name")]
        public string Name { get; set; }

        public CuisineType Cuisine { get; set; }
    }
}
