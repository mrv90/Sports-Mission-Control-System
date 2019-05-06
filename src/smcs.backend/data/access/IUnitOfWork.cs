using System;
using System.Collections.Generic;
using System.Text;

namespace smcs.backend.data.access
{
    internal interface IUnitOfWork
    {
        SmcsContext Cntx { get; set; }

        bool Commit();
    }
}
