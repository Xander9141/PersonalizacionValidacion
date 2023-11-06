#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

public class Survey
{
    [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
    [MinLength(2, ErrorMessage = "El campo Nombre debe tener al menos 2 caracteres.")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "La ubicación es un campo obligatorio.")]
    public string Localizacion { get; set; }

    [Required(ErrorMessage = "El campo Lenguaje Favorito es obligatorio.")]
    public string Lenguaje { get; set; }

    [MinLength(20, ErrorMessage = "El Comentario debe tener al menos 20 caracteres.")]
    public string Comentario { get; set; }

    [FutureDate(ErrorMessage = "La fecha debe ser en el futuro")]
    public DateTime DateInFuture { get; set; }
}
