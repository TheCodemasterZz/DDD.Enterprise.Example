﻿using Demo.Library.Responses;
using ServiceStack;
using ServiceStack.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.ServiceStack.Accounting.PaymentOrder.Entities.Invoice.Validators
{
    public class Add : AbstractValidator<Services.Add>
    {
        public Add()
        {
            RuleFor(x => x.PaymentOrderId).NotEmpty();
            RuleFor(x => x.InvoiceId).NotEmpty();
        }
    }
}