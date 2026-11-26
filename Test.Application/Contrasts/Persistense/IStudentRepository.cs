using Test.Domain.Entities;

namespace Test.Application.Contrasts.Persistense;

public interface IStudentRepository
{
    Task<List<Student>> GetAllAsync(CancellationToken cancellationToken);

    Task<Student?> GetByIdAsync(int id, CancellationToken cancellationToken);

    Task<Student> CreateAsync(Student student, CancellationToken cancellationToken);

    Task<Student?> UpdateAsync(Student student, CancellationToken cancellationToken);

    Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);
}