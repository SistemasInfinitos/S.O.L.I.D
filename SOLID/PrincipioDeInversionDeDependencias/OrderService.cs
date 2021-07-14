using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.PrincipioDeInversionDeDependencias
{
    public class OrderService
    {
        public readonly IMailService _mailService;

        public OrderService(IMailService mailService)
        {
            _mailService = mailService;
        }

        public void Create(Order order)
        {
            // ToDo: código para crear la orden

            // Enviar notificación de la orden creada
            _mailService.Send();
        }
    }
}
