using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace fnx_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class _baseController : ControllerBase
    {
    }

    [Authorize]
    public class AuthBaseController : _baseController { }
}
