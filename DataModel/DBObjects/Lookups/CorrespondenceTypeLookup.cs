﻿using System.ComponentModel.DataAnnotations;

namespace DataModel.DBObjects.Lookups
{
    public class CorrespondenceTypeLookup
    {
        [Key]
        public int Id { get; set; }
        [Required] [MaxLength(10)]
        public string CorrespondenceType { get; set; }
        [Required] 
        public bool Archived { get; set; }
    }
}
