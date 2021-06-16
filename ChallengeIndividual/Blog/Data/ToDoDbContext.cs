using ToDoMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoMVC.Data
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) 
            : base(options) 
        {

        }

        public DbSet<Models.Task> Tasks{ get; set; }
        public DbSet<Folder> Folders { get; set; }
    }
}
