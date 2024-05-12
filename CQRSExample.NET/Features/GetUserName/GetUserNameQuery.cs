using MediatR;

namespace CQRSExample.NET.Features.GetUserName;

public class GetUserNameQuery : IRequest<List<string>>;