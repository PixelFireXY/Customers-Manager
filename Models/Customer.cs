using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersManager.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo Nome azienda è obbligatorio.")]
        [Display(Name = "Nome azienda")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Il campo P.IVA è obbligatorio.")]
        [StringLength(16, MinimumLength = 11, ErrorMessage = "Inserisci un valore compreso fra 11 e 16 caratteri")]
        [Display(Name = "P.IVA")]
        public string VATNumber { get; set; }

        [Display(Name = "Provincia")]
        public string Province { get; set; }

        [Display(Name = "Indirizzo")]
        public string Address { get; set; }
    }
}
