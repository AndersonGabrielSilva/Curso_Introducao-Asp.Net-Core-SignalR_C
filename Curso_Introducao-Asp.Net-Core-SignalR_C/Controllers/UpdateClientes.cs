using Curso_Introducao_Asp.Net_Core_SignalR_C.Hubs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_Introducao_Asp.Net_Core_SignalR_C.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateClientesController : ControllerBase
    {
        public UpdateClientesController()
        {
        }

        [HttpGet("atualiza")]
        public async Task UpdateClientesAll([FromServices] IHubContext<PolHub> hubContext)
        {           
            //Enviando Dados para o Hub de qualque controller
            await hubContext.Clients.All.SendAsync("ReceiveMessage", "Teste", "Teste", "Teste", "teste").ConfigureAwait(false);
        }
    }
}
