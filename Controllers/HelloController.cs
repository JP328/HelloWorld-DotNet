using Microsoft.AspNetCore.Mvc;

namespace helloworld.Controllers
{
    [Route("~/")]        
    [ApiController]
    public class HelloController
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello World - .Net is LIVE!";
        }

        [HttpGet("/bsms")]
        public string Bsms()
        {
            return "Mentalidade de crescimento\n" +
                    "Orientação ao futuro\n" +
                    "Orientação ao detalhe\n" +
                    "Comunicação\n" +
                    "Proatividade\n" +
                    "Persistência\n" +
                    "Trabalho em Equipe\n" +
                    "Responsabilidade Pessoal";
        }


        [HttpGet("/metas-da-semana")]
        public string Metas()
        {
            return "Fixar todo o conteúdo, me aproximar do meu grupo de PI e atingir minhas metas de estudo por fora do horário do bootcamp";
        }
    }
}
