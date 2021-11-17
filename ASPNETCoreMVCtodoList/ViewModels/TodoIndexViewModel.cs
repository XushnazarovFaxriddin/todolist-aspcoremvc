using ASPNETCoreMVCtodoList.Models;
using System;
using System.Collections.Generic;
namespace ASPNETCoreMVCtodoList.ViewModels
{
    public class TodoIndexViewModel
    {
        public IEnumerable<Todo> todo { get; set; }
    }
}
