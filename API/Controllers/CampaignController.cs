using Microsoft.AspNetCore.Mvc;
using RollTheDie.Application.Services;
using RollTheDie.Domain.Entities;
using System.Runtime.InteropServices;

namespace RollTheDie.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CampaignController : ControllerBase
    {
        private readonly CampaignService _campaignService;

        public CampaignController(CampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Campaign campaign)
        {
            try
            {
                await _campaignService.Create(campaign);
                return Ok("Campanha Criada com sucesso");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _campaignService.GetAll());
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCampaignById(Guid id) {
            try
            {

                return Ok(await _campaignService.GetCampaign(id));
            }
            catch (ArgumentException ex) {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id) {
            try
            {
                await _campaignService.Delete(id);
                return Ok("Campanha deletada com sucesso");
            }
            catch (ArgumentException ex) {
                return BadRequest(ex.Message);
            }   
        }
    }
}
