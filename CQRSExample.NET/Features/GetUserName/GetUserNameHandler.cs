using CQRSExample.NET.Database;
using MediatR;

namespace CQRSExample.NET.Features.GetUserName;

public class GetUserNameHandler : IRequestHandler<GetUserNameQuery, List<string>>
{
    public Task<List<string>> Handle(GetUserNameQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(FakeDatabase.UserNames);
    }
}