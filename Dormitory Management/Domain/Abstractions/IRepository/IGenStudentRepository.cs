using Domain.Model;

namespace Domain.Abstractions.IRepository;

public interface IGenStudentRepository
{
    Task<IEnumerable<GenStudent>> Get();
    Task<IEnumerable<GenStudent>> Search(
        string code = "",
        string fullName = "");
    void Create(GenStudent genStudent);
    void Update(GenStudent genStudent);
}