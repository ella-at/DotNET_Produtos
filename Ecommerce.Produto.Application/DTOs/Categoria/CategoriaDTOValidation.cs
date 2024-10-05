using Ecommerce.Produto.Application.DTOs;
using FluentValidation;

namespace Ecommerce.Produto.Application.DTOs.Categoria
{

    public class CategoriaDTOValidator : AbstractValidator<CategoriaDTO>
    {
        public CategoriaDTOValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("� obrigat�rio informar o nome da categoria.")
                .MaximumLength(100).WithMessage("O nome da categoria pode ter no m�ximo 100 caracteres.");


            RuleFor(p => p.Descricao)
                .NotEmpty().WithMessage("� obrigat�rio preencher a descri��o da categoria.")
                .MaximumLength(250).WithMessage("A descri��o da categoria pode ter no m�ximo 250 caracteres.");


        }
    }
}