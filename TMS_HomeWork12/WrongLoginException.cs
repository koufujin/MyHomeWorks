﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_HomeWork12
{
    internal class WrongLoginException:Exception
    {
        public WrongLoginException() : base() { }
        public WrongLoginException(string message) : base(message) { }

    }
}
