﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    public interface IEmailSender
    {
        string SendEmail(string to, string subject);
    }
}
