using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NunesSports.Models;

public class Product{


[Key]
[DisplayName("Cod_product")]
public int cod_product{get; set; }

[Required(ErrorMessage = "Informe o nome")]
[StringLength(80, ErrorMessage = "O nome deve conter até 80 caracteres!")]
[MinLength(5, ErrorMessage = "O nome deve conter no mínimo 5 caracteres!")]
[DisplayName("Nome do Produto")]
public string Name {get; set;} = string.Empty;

[Required(ErrorMessage = "Informe o nome")]
[StringLength(200, ErrorMessage = "A descrição deve conter até 200 caracteres!")]
[MinLength(5, ErrorMessage = "A descrição deve conter no mínimo 5 caracteres!")]
[DisplayName("Descrição do Produto")]
public string Description {get; set;} = string.Empty;

[Required(ErrorMessage = "Informe o preço")]
[Range(0.01, double.MaxValue, ErrorMessage = "O preço do produto deve ser maior que zero!")]
[DisplayName("Preço do Produto")]
public decimal Price { get; set; }


}