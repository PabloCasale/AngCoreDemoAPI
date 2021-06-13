using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ang.Core.Demo.BackEnd.Models
{
    public class CreditCard
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Owner { get; set; }

        [Required]
        [StringLength(maximumLength: 16)]
        public string CardNumber { get; set; }

        [Required]
        [StringLength(maximumLength: 5)]
        public string ExpirationDate { get; set; }

        [Required]
        [StringLength(maximumLength: 3)]
        public string CVV { get; set; }
    }
}