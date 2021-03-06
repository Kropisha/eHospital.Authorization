﻿using System.ComponentModel.DataAnnotations;

namespace EHospital.Authorization.Models
{
    /// <summary>
    /// Db roles
    /// </summary>
    public class Roles
    {
        [Key]
        public int Id { get; set; }

        [StringLength(10, ErrorMessage = "No more than 10 symbols")]
        public string Title { get; set; }
    }
}
