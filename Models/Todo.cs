using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class Todo
    {
        [Key]
        public int id { get; set; }

        [Column (TypeName = "nvarchar(100)")]
        public string text { get; set; }

        [Column(TypeName = "bit")]
        public bool isCompleted { get; set; }
    }
}
