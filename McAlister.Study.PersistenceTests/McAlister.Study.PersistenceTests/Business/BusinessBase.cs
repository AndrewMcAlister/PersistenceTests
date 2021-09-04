using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using dfi = McAlister.Study.PersistenceTests.Definitions.Interfaces;
using dfm = McAlister.Study.PersistenceTests.Definitions.Models;
using dfe = McAlister.Study.PersistenceTests.Definitions.Entities;

namespace McAlister.Study.PersistenceTests.Business
{
    public abstract class BusinessBase<T> where T : dfi.IBusinessModel
    {
        public abstract Boolean IsValid(T entity, ref String msg);
    }
}
