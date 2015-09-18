using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSM.Models
{
    public class TaskAndUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public UserModels User { get; set; }

        public int TaskId { get; set; }

        public TaskModels Task { get; set; }
    }
}
