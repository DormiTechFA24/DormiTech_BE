using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface IGenStudentRepository : IGenericRepository<GenStudent>
{
    //Task<IEnumerable<GenStudent>> Get();

    //Task<IEnumerable<GenStudent>> Search(
    //    string code = "",
    //    string fullName = "");

    //void Create(GenStudent genStudent);
    //void Update(GenStudent genStudent);
}