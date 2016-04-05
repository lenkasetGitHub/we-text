﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeText.Common.Messaging;
using WeText.Common.Services;

namespace WeText.Services.Accounts
{
    public class AccountService : Microservice
    {
        public AccountService(ICommandConsumer commandConsumer, IEventConsumer eventConsumer)
            : base(commandConsumer, eventConsumer)
        { }
    }
}
