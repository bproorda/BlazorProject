using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorChat.Blazor.Shared
{
   public class taskModel
    {
        public string title { get; set; }

        public int difficulty { get; set; }

        public string assignedTo { get; set; }

        public bool completed { get; set; }
    }
}
