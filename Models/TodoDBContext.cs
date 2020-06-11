using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoDBContext : DbContext
    {
        public TodoDBContext(DbContextOptions <TodoDBContext> options):base(options)
        {

        }

        public DbSet<Todo> Todos { get; set; }
    }
}
