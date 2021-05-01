using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Curso_Introducao_Asp.Net_Core_SignalR_C.Hubs
{
    //O Hub é o coração do SignalR
    public class PolHub : Hub
    {
        /*Sempre havera um metodo de SendMessage dentro do Hub
        // Verifique o codigo de retorno da mensagem, na Pasta 
        // wwwroot/js/polhub : 


        await Clients.All.SendAsync("ReceiveMessage", user, message, myChanelId, myChanelVal).ConfigureAwait(false);

        ReceiveMessage: É como se uma Key, onde lá no Clinte-side é consigo carantir que todos os eventos ou chamadas lançadas pelo "ReceiveMessage" voltem para o cliente

        */

        /// <summary>
        /// Responsavel por enviar a todos os clientes os dados da votação
        /// </summary>
        /// <returns></returns>
        public async Task SendMessage(string user, string message, string myChanelId, string myChanelVal)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message, myChanelId, myChanelVal).ConfigureAwait(false);
        }
    }
}
