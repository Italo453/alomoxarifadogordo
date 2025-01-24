using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly List<Categoria> _categorias;

        public CategoriaController()
        {
            _categorias = new List<Categoria>()
            {
                new Categoria()
                {
                    Codigo = 1,
                    Descricao ="Bebidas"
                },
                new Categoria()
                {
                    Codigo = 2,
                    Descricao ="Alimento"
                }
            };
        }

        [HttpGet("/lista")]
        public IActionResult listaCategorias()
        {
            return Ok(_categorias);
        }

        [HttpPost("/categoria")]
        public IActionResult listaCategorias(CategoriaDTO categoria)
        {
            return Ok(_categorias.Where(x => x.Codigo == categoria.Codigo));
        }
        [HttpPost("/criarcategoria")]
        public IActionResult criarcategoria(Categoria categoria)
        {
            var novaCategoria = new Categoria()
            {
                Codigo = categoria.Codigo,
                Descricao = categoria.Descricao
            };
            _categorias.Add(novaCategoria);

            return Ok(_categorias);
        }


        [HttpDelete("/removecategoria")]

        public IActionResult removecategoria(Categoria categoria)
        {
            var itemPesquisado = _categorias.FirstOrDefault(x => x.Codigo == categoria.Codigo);
            if (itemPesquisado != null)
            {
                _categorias.Remove(itemPesquisado);
                return Ok("removidp com sucesso");
            }
            else
            {
                return Ok("Produto não localizado");
            }
        }

    }   
}
