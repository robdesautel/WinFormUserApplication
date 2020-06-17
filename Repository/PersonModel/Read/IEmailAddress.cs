﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorksEntity.Model;

namespace Repository.PersonModel.Read
{
    interface IEmailAddress
    {
        EmailAddress GetEmailAddressByBusinessEntityID(int BusinessEntityID);

    }
}
