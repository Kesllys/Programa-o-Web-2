using System.ComponentModel.DataAnnotations; 


namespace Exercicios.Models
{
    public class Salario
    {
        [Display(Name = "Valor do Salário")]
        [Required(ErrorMessage = "Informe o Valor do Salário")]
        [RegularExpression(@"^\d+,?\d{0,2}$", ErrorMessage = "Informe um valor válido!")]
        public double Valor { get; set; }
        
        [Display(Name = "Taxa de Juros")]
        [Required(ErrorMessage = "Informe a Taxa de Juros, somente o número")]
        [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "Informe um valor válido!")]
        public double TaxaJuros { get; set; }

        [Display(Name = "Dias em Atraso")]
        [Required(ErrorMessage = "Informe o Número de Dias em Atraso")]
        [RegularExpression(@"[0-9]*$", ErrorMessage = "Informe um valor válido!")]
        public int DiasEmAtraso { get; set; }

        [Display(Name = "Salário com Juros")]
        [DisplayFormat(DataFormatString="{0:#.##}")]
        public double SalarioComJuros { get => Calcular(); }

        private double Calcular(){
            return (DiasEmAtraso * TaxaJuros)/100 + Valor;
        }

    }
}