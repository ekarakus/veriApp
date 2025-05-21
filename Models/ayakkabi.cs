using System.ComponentModel.DataAnnotations;

public class Ayakkabi
{
    [Required]
    public string? Marka { get; set; } 
    public string? Renk { get; set; } 
    public Double Numara { get; set; } 

    
    
}