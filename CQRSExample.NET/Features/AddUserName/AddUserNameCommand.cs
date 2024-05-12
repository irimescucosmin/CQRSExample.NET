using MediatR;

namespace CQRSExample.NET.Features.AddUserName;

public class AddUserNameCommand : IRequest<List<string>>
{
    public string UserName { get; set; }
}