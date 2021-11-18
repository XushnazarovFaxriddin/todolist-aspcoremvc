using System;
using System.Collections.Generic;
using System.Linq;

namespace ASPNETCoreMVCtodoList.Models
{
    public class MockTodoRepository : ITodoRepository
    {

        public string[] Colors = { "7E03F9", "127DFF", "FB05A4", "7E03F9", "FE5711", "137EFF" };

        Random random = new Random();
        List<Todo> _todoList = new List<Todo>();
        public MockTodoRepository()
        {
            _todoList = new List<Todo>()
            {
                new Todo(){Id = 1, IsCheckend = true, Name = "Faxriddin", deta = new DateTime(2015, 12, 31), Color = Colors[random.Next(0,Colors.Length)]},
                new Todo(){Id = 2, IsCheckend = false, Name = "Bexruz", deta = new DateTime(2016,12, 31), Color = Colors[random.Next(0,Colors.Length)]},
                new Todo(){Id = 3, IsCheckend = true, Name = "Bexzod", deta = new DateTime(2017,12,31), Color=Colors[random.Next(0,Colors.Length)]},
                new Todo(){Id = 4, IsCheckend = false, Name = "Numuhammad", deta = new DateTime(2018,02,23), Color=Colors[random.Next(0,Colors.Length)]},
                new Todo(){Id = 5, IsCheckend = false, Name = "Ziyodullo", deta = new DateTime(2020,11,12), Color=Colors[random.Next(0,Colors.Length)]},
                new Todo(){Id = 6, IsCheckend = true, Name = "Sevinchbek", deta = new DateTime(2012,12,12), Color=Colors[random.Next(0,Colors.Length)]}
            };
        }
        public Todo Get(int? id)
        {
            return _todoList.FirstOrDefault(todo=>todo.Id.Equals(id??1));
        }

        public IEnumerable<Todo> GetAll()
        {
            return _todoList;
        }
    }
}
