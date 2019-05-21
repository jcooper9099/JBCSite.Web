using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JBCSite.Auth.Models
{
    public class RolePermission
    {
        public Guid Id { get; set; }
        
        public Guid PermissionId { get; set; }

        [ForeignKey(nameof(PermissionId))]
        public AppPermission Permission { get; set; }

    }
}
