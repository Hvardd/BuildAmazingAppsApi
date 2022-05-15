using BuildAmazingAppsApi.DataModels;

namespace BuildAmazingAppsApi.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();


    }
}
