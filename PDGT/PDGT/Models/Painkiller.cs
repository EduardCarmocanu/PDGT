using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PDGT.Models
{
    class Painkiller
    {
        [Required]
        [StringLength(64, ErrorMessage = "Painkiller name too long", MinimumLength = 2)]
        public string Type { get; set; }
        [Required]
        public int Amount { get; set; }
    }
}
