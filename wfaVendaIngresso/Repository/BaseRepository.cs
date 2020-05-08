using System;
using System.Collections.Generic;
using wfaVendaIngresso.Configuration;
using Npgsql;
using System.Data;

namespace wfaVendaIngresso.Repository
{
    abstract class BaseRepository<T> : Repository<T>
    {
        String tableName;
        public BaseRepository()
        {
            tableName = typeof(T).Name.ToLower();
        }

        public List<T> getAll()
        {
            var connection = Connection.getConnection();
            var cmd = new NpgsqlCommand("SELECT * FROM " + tableName, connection);
            var reader = cmd.ExecuteReader();

            List<T> records = new List<T>();

            while (reader.Read())
            {
                records.Add(parse(reader));
            }
            connection.Close();
            return records;
        }

        public T find(string id)
        {
            throw new NotImplementedException();
        }

        public T create(T model)
        {
            throw new NotImplementedException();
        }

        public T delete(string id)
        {
            throw new NotImplementedException();
        }
        public T update(string id, T model)
        {
            throw new NotImplementedException();
        }
        public abstract T parse(IDataRecord record);

    }
}
