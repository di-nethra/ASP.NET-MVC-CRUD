using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ToDo
    {
        [Key]

        public int Id { get; set; }
        public string Task { get; set; }
        public  string FromTime { get; set; }
        public string ToTime { get; set; }
    }
}
