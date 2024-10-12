using Domain.Model;
using Infrastructure.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public sealed class GenStudentRepository : IGenStudentRepository
{
    private readonly DbSet<GenStudent> context;

    public GenStudentRepository(DormiTechContext context)
    {
        this.context = context.Set<GenStudent>();
    }

    public void Create(GenStudent genStudent)
    {
        context.Add(genStudent);
    }

    public async Task<IEnumerable<GenStudent>> Get()
    {
        IQueryable<GenStudent> query = context;

        return query;
    }

    public async Task<IEnumerable<GenStudent>> Search(string code = "", string fullName = "")
    {
        IQueryable<GenStudent> query = context;

        return query;
    }

    public void Update(GenStudent genStudent)
    {
        context.Update(genStudent);
    }
}