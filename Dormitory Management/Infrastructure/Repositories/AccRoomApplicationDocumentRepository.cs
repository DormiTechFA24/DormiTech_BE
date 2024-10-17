using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class AccRoomApplicationDocumentRepository(DormiTechContext context)
{
    public async Task<IEnumerable<AccRoomApplicationDocument>> GetAllAsync()
    {
        return await context.AccRoomApplicationDocuments.ToListAsync();
    }

    public async Task<AccRoomApplicationDocument?> GetByIdAsync(Guid id)
    {
        return await context.AccRoomApplicationDocuments.FindAsync(id);
    }

    public async Task AddAsync(AccRoomApplicationDocument document)
    {
        await context.AccRoomApplicationDocuments.AddAsync(document);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(AccRoomApplicationDocument document)
    {
        context.AccRoomApplicationDocuments.Update(document);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var document = await context.AccRoomApplicationDocuments.FindAsync(id);
        if (document != null)
        {
            context.AccRoomApplicationDocuments.Remove(document);
            await context.SaveChangesAsync();
        }
    }
}