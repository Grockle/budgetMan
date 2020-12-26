﻿using System.ComponentModel.DataAnnotations;

namespace BackendService.Data.DTOs.Personal.Request
{
    public class UpdatePersonalCategoryRequest
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public int Type { get; set; }
        
        [Required]
        public string CategoryName { get; set; }
    }
}