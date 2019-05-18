using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JBCSite.Domain.Models
{
    public class BlogUser
    {
        public Guid Id { get; set; }

        public Guid BlogId { get; set; }

        public Guid UserId {get;set;}

        [ForeignKey(nameof(BlogId))]
        public Blog Blog;
    }
}
