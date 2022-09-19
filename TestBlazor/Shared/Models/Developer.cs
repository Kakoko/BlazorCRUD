using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBlazor.Shared.Models
{
    public class Developer
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Cellnumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
