using BookStore.Models.Requests;
using FluentValidation;


namespace BookStore.validator
{
    public class GetAllBooksByAuthorRequestValidator:AbstractValidator<GetAllBooksByAuthorRequest>
    {
        public GetAllBooksByAuthorRequestValidator() 
        {
            RuleFor(expression: X :GetAllBooksByAuthorRequest =>X.Time)
                .NotNull()
                .GreaterThan(valueToCompare: 0)
                .LessThan(valueToCompare: 1000)
                .WithMessage("Some error");

            RuleFor(expression: X:GetAllBooksByAuthorRequest =>X.Name)
                .NotNull()
                .NotEmpty()
                .MinimumLenght(2)
                .MaximumLenght(10);
        }
    }
}
