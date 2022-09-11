using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Domin.Entity
{
    [Table("LogBooks", Schema = "dbo")]
    public class LogBook
    {
        public Guid Id { get; set; }
        public string Action { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public Guid BookId { get; set ; }
        [ForeignKey("BookId")]
        public Book? Book { get; set; }
    }
}
