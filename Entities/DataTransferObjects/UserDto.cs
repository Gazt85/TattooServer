﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class UserDto
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }
    }
}
