﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.PrincipioDeInversionDeDependencias
{
    public class SendGridService: IMailService
    {
        public void Send()
        {
            // Todo: código para enviar el correo
        }
    }
}
