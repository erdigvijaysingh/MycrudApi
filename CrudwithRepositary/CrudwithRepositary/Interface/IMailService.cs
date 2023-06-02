﻿using CrudwithRepositary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudwithRepositary.Interface
{
   public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
