﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyKTV.KTVEntity
{
    public class KTVDataBase : DbContext
    {
        public KTVDataBase() : base()
        {
            DbInterception.Add(new MyInterceptor());
        }
        public DbSet<SearchCache> SearchCache { get; set; }

        public DbSet<MyMTV> MyMTV { get; set; }
    }

    public class MyInterceptor: IDbCommandInterceptor
    {
        private static Regex replaceRegex = new Regex(@"\(CHARINDEX\((.*?),\s?(.*?)\)\)\s*?>\s*?0");

        public void NonQueryExecuted(DbCommand command, DbCommandInterceptionContext<int> interceptionContext)
        {

        }

        public void NonQueryExecuting(DbCommand command, DbCommandInterceptionContext<int> interceptionContext)
        {
            
        }

        public void ReaderExecuted(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext)
        {
            
        }

        public void ReaderExecuting(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext)
        {
            ReplaceCharIndexFunc(command);
        }

        public void ScalarExecuted(DbCommand command, DbCommandInterceptionContext<object> interceptionContext)
        {
            
        }

        public void ScalarExecuting(DbCommand command, DbCommandInterceptionContext<object> interceptionContext)
        {
            ReplaceCharIndexFunc(command);
        }

        private void ReplaceCharIndexFunc(DbCommand command)
        {
            bool isMatch = false;
            var text = replaceRegex.Replace(command.CommandText, (match) =>
            {
                if (match.Success)
                {
                    string paramsKey = match.Groups[1].Value;
                    string paramsColumnName = match.Groups[2].Value;
                    //replaceParams
                    foreach (DbParameter param in command.Parameters)
                    {
                        if (param.ParameterName == paramsKey.Substring(1))
                        {
                            param.Value = string.Format("%{0}%", param.Value);
                            break;
                        }
                    }
                    isMatch = true;
                    return string.Format("{0} LIKE {1}", paramsColumnName, paramsKey);
                }
                else
                    return match.Value;
            });
            if (isMatch)
                command.CommandText = text;
        }
    }
}
