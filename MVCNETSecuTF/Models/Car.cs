using System.ComponentModel.DataAnnotations;

namespace MVCNETSecuTF.Models;

public class Car
{
    
    public Car(int id, string marque, string modele, string couleur, double prix, int puissance)
    {
        Id = id;
        Marque = marque;
        Modele = modele;
        Couleur = couleur;
        Prix = prix;
        Puissance = puissance;
    }

    public Car()
    {
    }

    public int Id { get; set; }
    
    [Required]
    public string Marque { get; set; }
    
    [Required]
    public string Modele { get; set; }
    
    [Required]
    public string Couleur { get; set; }
    
    [Required]
    [Range(0,100000000)]
    public double Prix { get; set; }
    
    [Required]
    [Range(0,1500)]
    public int Puissance { get; set; }
}