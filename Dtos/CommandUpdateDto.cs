using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace minimal_api.Dtos
{
    public class CommandUpdateDto
    {
        [Required]
        public string? Howto { get; set; }
        [Required]
        [MaxLength(5)]
        public string? Platform { get; set; }
        [Required]
        public string? CommandLine { get; set; }
    }
}