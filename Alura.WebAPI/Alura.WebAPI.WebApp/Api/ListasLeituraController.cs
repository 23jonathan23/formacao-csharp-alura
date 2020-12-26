using System.Collections.Generic;
using System.Linq;
using Alura.ListaLeitura.Modelos;
using Alura.ListaLeitura.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Lista = Alura.ListaLeitura.Modelos.ListaLeitura;

namespace Alura.WebAPI.WebApp.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListaLeituraController : ControllerBase
    {
        private readonly IRepository<Livro> _repo;

        public ListaLeituraController(IRepository<Livro> repository)
        {
            _repo = repository;
        }

        private Lista CriarLista(TipoListaLeitura tipo)
        {
            return new Lista
            {
                Tipo = tipo.ParaString(),
                Livros = _repo.All
                    .Where(l => l.Lista == tipo)
                    .Select(l => l.ToApi())
                    .ToList()
            };
        }

        [HttpGet]
        public IActionResult TodasListas()
        {
            Lista paraLer = CriarLista(TipoListaLeitura.ParaLer);
            Lista lendo = CriarLista(TipoListaLeitura.Lendo);
            Lista lidos = CriarLista(TipoListaLeitura.Lidos);
            var colecao = new List<Lista> { paraLer, lendo, lidos };
            return Ok(colecao);
        }

        [HttpGet("{tipo}")]
        public IActionResult Recuperar(TipoListaLeitura tipo)
        {
            var lista = CriarLista(tipo);
            return Ok(lista);
        }

        [HttpGet("capas/{id}")]
        public IActionResult ImagemCapa(int id)
        {
            byte[] img = _repo.All
                .Where(l => l.Id == id)
                .Select(l => l.ImagemCapa)
                .FirstOrDefault();
            if (img != null)
            {
                return File(img, "image/png");
            }
            return File("~/images/capas/capa-vazia.png", "image/png");
        }
    }
}