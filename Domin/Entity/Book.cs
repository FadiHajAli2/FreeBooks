using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domin.Resource;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domin.Entity
{
    [Table("Books",Schema ="dbo")]
    public class Book
    {
        public Guid Id { get; set; }
        [Required(ErrorMessageResourceType =typeof(Resource.ResourceData),ErrorMessageResourceName = "Book Name")]
        [MaxLength(20,ErrorMessageResourceType =typeof(Resource.ResourceData),ErrorMessageResourceName = "MaxLength")]
        [MinLength(3,ErrorMessageResourceType =typeof(Resource.ResourceData),ErrorMessageResourceName = "MinLength")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessageResourceType =typeof(Resource.ResourceData),ErrorMessageResourceName = " Author Name")]
        [MaxLength(20,ErrorMessageResourceType =typeof(Resource.ResourceData),ErrorMessageResourceName = "MaxLength")]
        [MinLength(3,ErrorMessageResourceType =typeof(Resource.ResourceData),ErrorMessageResourceName = "MinLength")]
        public string Author { get; set; } = string.Empty;
        public string ImageName { get; set; } = string.Empty;
        public string FileName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool Publish { get; set; }
        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
        public Guid SubCategoryId { get; set; }
        [ForeignKey("SubCategoryId")]
        public SubCategory? SubCategory { get; set; }
        
        public int CurrentStaut { get; set; }
    }
}
