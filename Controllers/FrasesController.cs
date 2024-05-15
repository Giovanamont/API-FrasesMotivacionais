using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrasesMAPI.Data;
using FrasesMAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrasesMAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FrasesController : ControllerBase
    {
         private readonly DataContext _context;

        public FrasesController(DataContext  context)
        {
            _context = context;
        }

         [HttpGet("{sentimento}")] 
        public async Task<IActionResult> GetSingle(string sentimento)
        {
            try
            {
                FM a = await _context.TB_frasesM.FirstOrDefaultAsync(aBusca => aBusca.sentimento == sentimento);
                //using Microsoft.EntityFrameworkCore;

                return Ok(a);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                //using System.Collections.Generic;
                List<FM> lista = await _context.TB_frasesM.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(FM novaFM)
        {
            try
            {               
                await _context.TB_frasesM.AddAsync(novaFM);
                await _context.SaveChangesAsync();

                return Ok(novaFM.sentimento);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(FM novaFM)
        {
            try
            {
                _context.TB_frasesM.Update(novaFM);
                int linhaAfetadas = await _context.SaveChangesAsync();

                return Ok(linhaAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{sentimento}")]
        public async Task<IActionResult> Delete(string sentimento)
        {
            try
            {
                FM aRemover = await _context.TB_frasesM.FirstOrDefaultAsync(p => p.sentimento == sentimento );

                _context.TB_frasesM.Remove(aRemover);
                int linhaAfetadas = await _context.SaveChangesAsync();

                return Ok(linhaAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}