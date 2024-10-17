using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



public class Administrador
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [StringLength(250)]
    public string Email { get; set; }

    [Required]
    [StringLength(50)]
    public string Senha { get; set; }
    
    [Required]
    [StringLength(10)]
    public string Prefil { get; set; }

}