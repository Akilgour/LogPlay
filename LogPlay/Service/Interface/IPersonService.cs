using LogPlay.Models;

namespace LogPlay.Service.Interface
{
    public interface IPersonService
    {
        Person GetPersonById(int personId);
    }
}