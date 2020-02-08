using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.Application.ViewModel
{
    public class UserParamsModel
    {
        private const int MaxPageSize = 50;
        private int pageSize = 10;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }

        public int PageNumber { get; set; } = 1;
    }
}
