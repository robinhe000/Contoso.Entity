﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model.Common
{
    public class Entity : IEntity
    {
        public virtual int Id { get; set; }
    }
}
