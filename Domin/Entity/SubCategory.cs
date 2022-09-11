using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.SqlServer;
using Domin.Resource;

namespace Domin.Entity
{
    [Table("SubCategories", Schema = "dbo")]
    public class SubCategory
    {
        public Guid Id { get; set; }
        [Required(ErrorMessageResourceType =typeof(Resource.ResourceData),ErrorMessageResourceName = "SubCategory Name")]
        [MaxLength(20,ErrorMessageResourceType =typeof(Resource.ResourceData),ErrorMessageResourceName = "MaxLength")]
        [MinLength(3,ErrorMessageResourceType =typeof(Resource.ResourceData),ErrorMessageResourceName = "MinLength")]
        public string Name { get; set; } = string.Empty;
        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
        
        public int CurrentStaut { get; set; }
    }
}
