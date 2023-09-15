﻿using static Dapper.SqlMapper;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace MVMS.DBEngine
{
    public interface ISQLHandler
    {
        Task<T> QueryFirstOrDefaultAsync<T>(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure);  // return the Single row Data table values

        Task<T> QuerySingleAsync<T>(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure); // return the Data table values

        Task<T> ExecuteScalarAsync<T>(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure);  // return the object values

        Task ExecuteAsync(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure); // Insert, Update and Delete

        Task<IEnumerable<T>> QueryAsync<T>(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure);   // return the Single data table

        Task<GridReader> QueryMultipleAsync(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure);  // return the Data Set  values

        Task<IDataReader> ExecuteReaderAsync(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure);  // return the Data Set  values
    }
    public class SQLHandler: ISQLHandler
    {
        private readonly IConfiguration _configuration;

        public SQLHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection Connection
        {
            get
            {
                var sqlconnection = new SqlConnection(_configuration.GetConnectionString("ConnString"));
                return sqlconnection;
            }
        }

        public async Task<T> QueryFirstOrDefaultAsync<T>(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            using (Connection)
            {
                return await Connection.QueryFirstOrDefaultAsync<T>(sql, parameters, commandType: commandType);
            }
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            using (Connection)
            {
                return await Connection.QueryAsync<T>(sql, parameters, commandType: commandType, commandTimeout: 600);
            }
        }

        public async Task<T> QuerySingleAsync<T>(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            using (Connection)
            {
                return await Connection.QuerySingleAsync<T>(sql, parameters, commandType: commandType);
            }
        }

        public async Task<T> ExecuteScalarAsync<T>(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            using (Connection)
            {
                return await Connection.ExecuteScalarAsync<T>(sql, parameters, commandType: commandType);
            }
        }

        public async Task ExecuteAsync(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            using (Connection)
            {
                await Connection.ExecuteAsync(sql, parameters, commandType: commandType);
            }
        }

        public async Task<GridReader> QueryMultipleAsync(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            return await Connection.QueryMultipleAsync(sql, parameters, commandType: commandType, commandTimeout: 180);
        }

        public async Task<IDataReader> ExecuteReaderAsync(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            return await Connection.ExecuteReaderAsync(sql, parameters, commandType: commandType, commandTimeout: 180);
        }
    }
}