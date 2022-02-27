using System;
using System.Collections.Generic;
using System.Text;

namespace TPortalProject.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public bool IsDeleted { get; set; }
    }
}
