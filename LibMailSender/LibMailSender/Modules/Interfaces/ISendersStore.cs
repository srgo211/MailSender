﻿using LibMailSender.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibMailSender.Modules.Interfaces
{
    public interface ISendersStore : IDataStore<Sender> { }
}
