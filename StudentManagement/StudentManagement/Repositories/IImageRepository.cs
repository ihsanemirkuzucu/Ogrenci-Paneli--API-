using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace StudentManagement.Repositories
{
    public interface IImageRepository
    {
        Task<string> Upload(IFormFile file,string fileName);
    }
}
