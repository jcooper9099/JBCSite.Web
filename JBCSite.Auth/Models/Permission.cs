using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JBCSite.Auth.Models
{
    public class Permission
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
