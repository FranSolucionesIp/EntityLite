﻿using inercya.EntityLite.Builders;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace inercya.EntityLite.Providers
{
    public class NpgsqlEntityLiteProvider : EntityLiteProvider
    {
        public const string ProviderName = "Npgsql";
        private readonly DataService DataService;

        public NpgsqlEntityLiteProvider(DataService dataService)
        {
            this.DataService = dataService;
            if (DataService.ProviderName != ProviderName)
            {
                throw new InvalidOperationException(this.GetType().Name + " is for " + ProviderName + ". Not for " + DataService.ProviderName);
            }
        }



        string _defaultSchema;
        public override string DefaultSchema
        {
            get
            {
               if (_defaultSchema == null)
               {
                   _defaultSchema = "public";
               }
               return _defaultSchema;
            }
            set
            {
                _defaultSchema = value;
            }
        }

        protected override void AppendGetAutoincrementField(StringBuilder commandText, EntityMetadata entityMetadata)
        {
            commandText.Append("\nRETURNING ")
                .Append(DataService.EntityLiteProvider.StartQuote)
                .Append(entityMetadata.Properties[entityMetadata.AutogeneratedFieldName].SqlField.BaseColumnName)
                .Append(DataService.EntityLiteProvider.EndQuote).Append(";");
        }
    }
}
