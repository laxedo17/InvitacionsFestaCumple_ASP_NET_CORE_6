using System.ComponentModel.DataAnnotations;

namespace InvitacionsFesta.Models
{
    public class InvitacionResposta
    {
        [Required(ErrorMessage = "Por favor indica o teu nome")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Por favor indica a tua direccion de email")]
        [EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Por favor agrega o teu numero de telefono")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "Por favor especifica se podes ir ou non")]
        public bool? VaiAsistir { get; set; }
    }
}