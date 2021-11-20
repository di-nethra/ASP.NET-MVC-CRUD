using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class ToDoDbContext:DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext>options):base(options) {
        
        }
        public DbSet<ToDo> todo { get; set; }
    }
}
