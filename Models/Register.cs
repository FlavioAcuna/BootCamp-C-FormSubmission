#pragma warning disable CS8618
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models;

public class Register
{
    [Required(ErrorMessage = "Campo Obligatorio")]
    [MinLength(4, ErrorMessage = "El nombre debe ser de minimo 4 caracteres")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "Campo Obligatorio")]
    [MinLength(4, ErrorMessage = "El apellido debe ser de minimo 4 caracteres")]
    public string Apellido { get; set; }

    [Required(ErrorMessage = "Campo Obligatorio")]
    [AgeValidator]
    public int Edad { get; set; }

    [Required(ErrorMessage = "Campo Obligatorio")]
    [EmailAddress]
    public string Email { get; set; }

    [Required(ErrorMessage = "Campo Obligatorio")]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage = "La contraseña debe ser de minimo 8 caracteres")]
    public string Password { get; set; }
}