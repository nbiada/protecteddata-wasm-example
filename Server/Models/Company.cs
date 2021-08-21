using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProtectedDataWasmExample.Server.Models
{
    public class Company
    {
        [Key] 
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }
    }
}
