using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using store.Data;
using store.Models;

namespace store.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DetailsCommandeController : ControllerBase
    {
        private readonly storeContext _context;
        public DetailsCommandeController(storeContext context)
        {
            _context = context;
        }

        [HttpPut("{commandeId}/items/{itemId}")]
        public async Task<IActionResult> UpdateItem(int commandeId, int itemId, DétailsCommandeDTO updatedItemDto)
        {
            var commande = await _context.Commande
                                         .Include(c => c.Items)
                                         .FirstOrDefaultAsync(c => c.Id == commandeId);

            if (commande == null)
            {
                return NotFound("Commande not found");
            }

            var item = commande.Items.FirstOrDefault(i => i.Id == itemId);
            if (item == null)
            {
                return NotFound("Item not found");
            }

            item.Qte = updatedItemDto.Qte;
            item.PrixUnitaire = updatedItemDto.PrixUnitaire;
            item.PrixTotal = updatedItemDto.PrixTotal;
            item.idProduit = updatedItemDto.idProduit;

            await _context.SaveChangesAsync();

            return Ok();
        }
        [HttpPost("{commandeId}/items")]
        public async Task<IActionResult> AddItemToCommande(int commandeId, [FromBody] DétailsCommandeDTO newItemDto)
        {
            var commande = await _context.Commande.Include(c => c.Items)
                                        .FirstOrDefaultAsync(c => c.Id == commandeId);

            if (commande == null)
            {
                return NotFound("Commande not found");
            }

            var newItem = new DétailsCommande
            {
                Qte = newItemDto.Qte,
                PrixUnitaire = newItemDto.PrixUnitaire,
                PrixTotal = newItemDto.PrixTotal,
                idProduit = newItemDto.idProduit
            };

            commande.Items.Add(newItem);

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{commandeId}/items/{itemId}")]
        public async Task<IActionResult> DeleteItem(int commandeId, int itemId)
        {
            var commande = await _context.Commande
                                         .Include(c => c.Items)
                                         .FirstOrDefaultAsync(c => c.Id == commandeId);

            if (commande == null)
            {
                return NotFound("Commande not found");
            }

            var item = commande.Items.FirstOrDefault(i => i.Id == itemId);
            if (item == null)
            {
                return NotFound("Item not found");
            }

            commande.Items.Remove(item);

            await _context.SaveChangesAsync();
            return Ok();
        }


    }
}
