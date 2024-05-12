using CQRSExample.NET.Database;
using MediatR;

namespace CQRSExample.NET.Features.AddUserName;

public class AddUserNameHandler : IRequestHandler<AddUserNameCommand, List<string>>
{

    public Task<List<string>> Handle(AddUserNameCommand request, CancellationToken cancellationToken)
    {
        FakeDatabase.UserNames.Add(request.UserName);
        return Task.FromResult(FakeDatabase.UserNames);
    }
}