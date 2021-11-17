using System.Collections.Generic;
namespace ASPNETCoreMVCtodoList.Models
{
    public interface ITodoRepository
    {
        Todo Get(int? id);

        IEnumerable<Todo> GetAll();
    }
}
