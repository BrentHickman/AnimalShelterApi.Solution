using System.ComponentModel.DataAnnotations;


namespace AnimalShelterApi.Models
{
  public class Cat
  {
    public int CatId { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    [Required]
    [Range(0, 100, ErrorMessage = "Years must be between 0 and 100.")]
    public int AgeYears { get; set; }
    [Required]
    [Range(0, 11, ErrorMessage = "Months must be between 0 and 11.")]
    public int AgeMonths { get; set; }
    [Required]
    public string Sex { get; set; }
    [StringLength(30)]
    public string Breed { get; set; }
    [Required]
    public int Weight { get; set; }
    [Required]
    [StringLength(20)]
    public string Coloring { get; set; }
    public string Description { get; set; }
    public string DateAvailable { get; set; }

  }
}