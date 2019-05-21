using System;
using System.ComponentModel.DataAnnotations;

namespace JBCSite.Auth.Models
{
    public class AppPermission
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        //[StringLength(512)]
        public string Description { get; set; }
    }
}
