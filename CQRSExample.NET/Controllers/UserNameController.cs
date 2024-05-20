using CQRSExample.NET.Features.AddUserName;
using CQRSExample.NET.Features.GetUserName;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSExample.NET.Controllers;

[Route("/[controller]/[action]")]
public class UserNameController(ISender sender) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> List()
    {
        return Ok(await sender.Send(new GetUserNameQuery()));
    }

    [HttpPost]
    public async Task<IActionResult> Add(string userName)
    {
        return Ok(await sender.Send(new AddUserNameCommand
        {
            UserName = userName
        }));
    }
}