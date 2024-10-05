using Ecommerce.Produto.Application.DTOs;
using FluentValidation;

namespace Ecommerce.Produto.Application.DTOs.Produto
{
    public class ProdutoDTOValidator : AbstractValidator<ProdutoDTO>
    {
        public ProdutoDTOValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("� obrigat�rio informar o nome do produto.")
                .MaximumLength(100).WithMessage("O nome do produto pode ter no m�ximo 100 caracteres.");


            RuleFor(p => p.Descricao)
                .NotEmpty().WithMessage("� obrigat�rio preencher a descri��o do produto.")
                .MaximumLength(250).WithMessage("A descri��o do produto pode ter no m�ximo 250 caracteres.");


            RuleFor(p => p.Quantidade)
                .GreaterThanOrEqualTo(0).WithMessage("� proibido que a quantidade em estoque seja negativa.");


            RuleFor(p => p.CategoriaId)
                .GreaterThan(0).WithMessage("� obrigat�rio que cada categoria tenha um ID e ele deve ser maior que zero.");
        }
    }

}