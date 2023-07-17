using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCNETSecuTF.Models.Forms;

public class CreateCarForm
{
    
    [Required(ErrorMessage = "Le Champ Marque est requis je te le dis !")]
    [MinLength(3, ErrorMessage = "La Longueur Minimum de Marque est de 3")]
    [MaxLength(25, ErrorMessage = "La Longueur Maximum de Marque est de 25")]
    public string Marque { get; set; }
    
    
    [Required]
    [MinLength(3)]
    [MaxLength(25)]
    public string Modele { get; set; }
    
    
    [Required]
    [Range(1900, 2023)]
    public int Annee { get; set; }
    
    [MinLength(3)]
    [MaxLength(25)]
    public string? Couleur { get; set; }
    
    [Required]
    [Range(1, 7)]
    public int Portes { get; set; }
}