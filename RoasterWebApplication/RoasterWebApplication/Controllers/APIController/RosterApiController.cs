using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using RoasterWebApplication.Models;

namespace RoasterWebApplication.Controllers.Api
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class RosterApiController : ControllerBase
    {
        private readonly RosterDBContext _context;
        private readonly IHubContext<SignalRServer> _signalrHub;

        public RosterApiController(RosterDBContext context, IHubContext<SignalRServer> signalrHub)
        {
            _context = context;
            _signalrHub = signalrHub;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([Bind("Id,FullName,GroupName,Age")] Member roaster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roaster);
                await _context.SaveChangesAsync();
                var name = roaster.FullName;

                if(roaster.GroupName == "Avenger")
                await _signalrHub.Clients.All.SendAsync("LoadRosters", name);

                return Ok($"{roaster.FullName} joined the group");
            }
            return BadRequest();
        }
    }
}
