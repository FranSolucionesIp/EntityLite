﻿using inercya.EntityLite.Templates;
using inercya.EntityLite.Extensions;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Data;

namespace inercya.EntityLite
{
    public class TemplatedCommand
    {
        public readonly DataService DataService;
        public readonly ISqlTemplate Template;

        public TemplatedCommand(DataService dataService, ISqlTemplate template)
        {
            if (dataService == null) throw new ArgumentNullException("dataService");
            if (template == null) throw new ArgumentNullException("template");

            this.DataService = dataService;
            this.Template = template;
        }

        private  DbCommand CreateCommand()
        {
            DbCommand command = this.DataService.Connection.CreateCommand();
            string parameterPrefix = this.DataService.EntityLiteProvider.ParameterPrefix;
            command.CommandText = Template.GetSql(parameterPrefix);
            Template.AddParametersToCommand(command, parameterPrefix);
            return command;
        }

        public int ExecuteNonQuery()
        {
            return this.DataService.ExecuteCommand(CreateCommand, x => x().ExecuteNonQuery());
        }

        public object ExecuteScalar()
        {
            return this.DataService.ExecuteCommand(CreateCommand, x => x().ExecuteScalar());
        }

        public IDataReader ExecuteReader()
        {
            return this.DataService.ExecuteCommand(CreateCommand, x => x().ExecuteReader());
        }

        public IDataReader ExecuteReader(CommandBehavior behavior)
        {
            return this.DataService.ExecuteCommand(CreateCommand, x => x().ExecuteReader(behavior));
        }

        public T FirstOrDefault<T>() where T:class, new()
        {
            return this.ToEnumerable<T>().FirstOrDefault();
        }

        public IEnumerable<T> ToEnumerable<T>() where T: class, new()
        {
            return DataService.ToEnumerable<T>(CreateCommand);
        }

        public IList<T> ToList<T>() where T : class, new()
        {
            return this.ToEnumerable<T>().ToList();
        }
    }
}
