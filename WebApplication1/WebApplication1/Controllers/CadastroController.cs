using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

[Route("api/[controller]")]
[ApiController]
public class PessoaController : ControllerBase
{
    private readonly PessoaDAO _pessoaDAO;

    public PessoaController(PessoaDAO pessoaDAO)
    {
        _pessoaDAO = pessoaDAO;
    }

    // GET: api/Pessoa
    [HttpGet]
    public ActionResult<IEnumerable<Pessoa>> GetPessoas()
    {
        return _pessoaDAO.GetPessoas().ToList();
    }

    // GET: api/Pessoa/5
    [HttpGet("{id}")]
    public ActionResult<Pessoa> GetPessoa(int id)
    {
        var pessoa = _pessoaDAO.GetPessoa(id);

        if (pessoa == null)
        {
            return NotFound();
        }

        return pessoa;
    }

    // POST: api/Pessoa
    [HttpPost]
    public ActionResult<Pessoa> AddPessoa(Pessoa pessoa)
    {
        _pessoaDAO.AddPessoa(pessoa);

        return CreatedAtAction(nameof(GetPessoa), new { id = pessoa.ID_pessoa }, pessoa);
    }

    // PUT: api/Pessoa/id
    [HttpPut("{id}")]
    public IActionResult UpdatePessoa(int id, Pessoa pessoa)
    {
        if (id != pessoa.ID_pessoa)
        {
            return BadRequest();
        }

        _pessoaDAO.UpdatePessoa(pessoa);

        return NoContent();
    }

    // DELETE: api/Pessoa/id
    [HttpDelete("{id}")]
    public IActionResult DeletePessoa(int id)
    {
        var pessoa = _pessoaDAO.GetPessoa(id);
        if (pessoa == null)
        {
            return NotFound();
        }

        _pessoaDAO.DeletePessoa(id);

        return NoContent();
    }
}
