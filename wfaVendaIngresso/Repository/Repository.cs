using System;
using System.Collections.Generic;
using System.Data;

namespace wfaVendaIngresso.Repository
{
    interface Repository<T>
    {
        List<T> getAll();
        T create(T model);
        T find(String id);
        T update(String id, T model);
        T delete(String id);
        T parse(IDataRecord record);

    }
}
