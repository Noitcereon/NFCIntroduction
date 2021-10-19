using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNFC.Data
{
    public class NFCInputModel
    {
        [Required]
        public String Input { get; set; }

        public NFCInputModel()
        {
            
        }
    }
}
