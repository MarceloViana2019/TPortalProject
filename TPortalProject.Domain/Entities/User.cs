﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TPortalProject.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
    }
}
