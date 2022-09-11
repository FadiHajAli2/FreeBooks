using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Domin.Resource;
using Amazon.Auth.AccessControlPolicy;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domin.Entity
{
    [Table("Categories", Schema = "dbo")]
    public class Category
    {
        public Guid Id { get; set; }
        [Required(ErrorMessageResourceType =typeof(Resource.ResourceData),ErrorMessageResourceName = "Category Name")]
        [MaxLength(20,ErrorMessageResourceType =typeof(Resource.ResourceData),ErrorMessageResourceName = "MaxLength")]
        [MinLength(3,ErrorMessageResourceType =typeof(Resource.ResourceData),ErrorMessageResourceName = "MinLength")]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        
        public int CurrentSatut { get; set; }
        
    }
}
