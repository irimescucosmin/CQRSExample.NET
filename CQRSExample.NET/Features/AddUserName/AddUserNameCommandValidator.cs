using CQRSExample.NET.Database;
using CQRSExample.NET.Features.AddUserName;
using FluentValidation;

public class AddUsernameCommandValidator : AbstractValidator<AddUserNameCommand>
{
    public AddUsernameCommandValidator()
    {
        RuleFor(x => x.UserName).NotEmpty().WithMessage("Username is required.")
            .Must(BeUniqueUsername).WithMessage("Username already exists.");
    }

    private static bool BeUniqueUsername(string username)
    {
        return !FakeDatabase.UserNames.Contains(username);
    }
}