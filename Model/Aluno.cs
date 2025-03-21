using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APITATT2.Model
{
    public class Aluno
    {
        
        [Required]
        [StringLength(40)]
        public string Nome { get; set; }

        [Required]
        [StringLength(35)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public int Idade { get; set; }

    }
}
