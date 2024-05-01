using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Remx.Api.Controllers;

// [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class BaseController: ControllerBase
{
    
}