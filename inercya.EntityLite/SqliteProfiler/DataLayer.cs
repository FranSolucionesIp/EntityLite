﻿
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Runtime.Serialization;
using System.ComponentModel;
using inercya.EntityLite;	
using inercya.EntityLite.Extensions;	

namespace inercya.EntityLite.SqliteProfiler.Entities
{
	[Serializable]
	[DataContract]
	[SqlEntity(BaseTableName="Statements")]
	public partial class Statement
	{
		private Int64 _statementId;
		[DataMember]
		[SqlField(DbType.Int64, 8, Precision = 19, IsKey=true, IsAutoincrement=true, ColumnName ="StatementId", BaseColumnName ="StatementId", BaseTableName = "Statements" )]		
		public Int64 StatementId 
		{ 
		    get { return _statementId; } 
			set 
			{
			    _statementId = value;
			}
        }

		private Int64 _commandTextHash;
		[DataMember]
		[SqlField(DbType.Int64, 8, Precision = 19, ColumnName ="CommandTextHash", BaseColumnName ="CommandTextHash", BaseTableName = "Statements" )]		
		public Int64 CommandTextHash 
		{ 
		    get { return _commandTextHash; } 
			set 
			{
			    _commandTextHash = value;
			}
        }

		private String _commandText;
		[DataMember]
		[SqlField(DbType.String, 2147483647, ColumnName ="CommandText", BaseColumnName ="CommandText", BaseTableName = "Statements" )]		
		public String CommandText 
		{ 
		    get { return _commandText; } 
			set 
			{
			    _commandText = value;
			}
        }

		private Double _maxTime;
		[DataMember]
		[SqlField(DbType.Double, 8, Precision = 53, ColumnName ="MaxTime", BaseColumnName ="MaxTime", BaseTableName = "Statements" )]		
		public Double MaxTime 
		{ 
		    get { return _maxTime; } 
			set 
			{
			    _maxTime = value;
			}
        }

		private Double _minTime;
		[DataMember]
		[SqlField(DbType.Double, 8, Precision = 53, ColumnName ="MinTime", BaseColumnName ="MinTime", BaseTableName = "Statements" )]		
		public Double MinTime 
		{ 
		    get { return _minTime; } 
			set 
			{
			    _minTime = value;
			}
        }

		private Double _totalTime;
		[DataMember]
		[SqlField(DbType.Double, 8, Precision = 53, ColumnName ="TotalTime", BaseColumnName ="TotalTime", BaseTableName = "Statements" )]		
		public Double TotalTime 
		{ 
		    get { return _totalTime; } 
			set 
			{
			    _totalTime = value;
			}
        }

		private Double _sampleTime;
		[DataMember]
		[SqlField(DbType.Double, 8, Precision = 53, ColumnName ="SampleTime", BaseColumnName ="SampleTime", BaseTableName = "Statements" )]		
		public Double SampleTime 
		{ 
		    get { return _sampleTime; } 
			set 
			{
			    _sampleTime = value;
			}
        }

		private Int64 _executionCount;
		[DataMember]
		[SqlField(DbType.Int64, 8, Precision = 19, ColumnName ="ExecutionCount", BaseColumnName ="ExecutionCount", BaseTableName = "Statements" )]		
		public Int64 ExecutionCount 
		{ 
		    get { return _executionCount; } 
			set 
			{
			    _executionCount = value;
			}
        }

		private String _maxTimeParams;
		[DataMember]
		[SqlField(DbType.String, 2147483647, ColumnName ="MaxTimeParams", BaseColumnName ="MaxTimeParams", BaseTableName = "Statements" )]		
		public String MaxTimeParams 
		{ 
		    get { return _maxTimeParams; } 
			set 
			{
			    _maxTimeParams = value;
			}
        }

		private String _minTimeParams;
		[DataMember]
		[SqlField(DbType.String, 2147483647, ColumnName ="MinTimeParams", BaseColumnName ="MinTimeParams", BaseTableName = "Statements" )]		
		public String MinTimeParams 
		{ 
		    get { return _minTimeParams; } 
			set 
			{
			    _minTimeParams = value;
			}
        }

		private String _sampleParams;
		[DataMember]
		[SqlField(DbType.String, 2147483647, ColumnName ="SampleParams", BaseColumnName ="SampleParams", BaseTableName = "Statements" )]		
		public String SampleParams 
		{ 
		    get { return _sampleParams; } 
			set 
			{
			    _sampleParams = value;
			}
        }

		private Object _avgTime;
		[DataMember]
		[SqlField(DbType.Object, 2147483647, ColumnName ="AvgTime" )]		
		public Object AvgTime 
		{ 
		    get { return _avgTime; } 
			set 
			{
			    _avgTime = value;
			}
        }


	}

	public partial class StatementRepository : Repository<Statement> 
	{
		public StatementRepository(DataService DataService) : base(DataService)
		{
		}

		public new SqliteProfilerDataService  DataService  
		{
			get { return (SqliteProfilerDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public Statement Get(string projectionName, Int64 statementId)
		{
			return ((IRepository<Statement>)this).Get(projectionName, statementId, FetchMode.UseIdentityMap);
		}

		public Statement Get(string projectionName, Int64 statementId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<Statement>)this).Get(projectionName, statementId, fetchMode);
		}

		public Statement Get(Projection projection, Int64 statementId)
		{
			return ((IRepository<Statement>)this).Get(projection, statementId, FetchMode.UseIdentityMap);
		}

		public Statement Get(Projection projection, Int64 statementId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<Statement>)this).Get(projection, statementId, fetchMode);
		}

		public Statement Get(string projectionName, Int64 statementId, params string[] fields)
		{
			return ((IRepository<Statement>)this).Get(projectionName, statementId, fields);
		}

		public Statement Get(Projection projection, Int64 statementId, params string[] fields)
		{
			return ((IRepository<Statement>)this).Get(projection, statementId, fields);
		}

		public bool Delete(Int64 statementId)
		{
			var entity = new Statement { StatementId = statementId };
			return this.Delete(entity);
		}

			}
	[Obsolete("Use nameof instead")]
	public static partial class StatementFields
	{
		public const string StatementId = "StatementId";
		public const string CommandTextHash = "CommandTextHash";
		public const string CommandText = "CommandText";
		public const string MaxTime = "MaxTime";
		public const string MinTime = "MinTime";
		public const string TotalTime = "TotalTime";
		public const string SampleTime = "SampleTime";
		public const string ExecutionCount = "ExecutionCount";
		public const string MaxTimeParams = "MaxTimeParams";
		public const string MinTimeParams = "MinTimeParams";
		public const string SampleParams = "SampleParams";
		public const string AvgTime = "AvgTime";
	}

	[Serializable]
	[DataContract]
	[SqlEntity(BaseTableName="Executions")]
	public partial class Execution
	{
		private Int64 _executionId;
		[DataMember]
		[SqlField(DbType.Int64, 8, Precision = 19, IsKey=true, IsAutoincrement=true, ColumnName ="ExecutionId", BaseColumnName ="ExecutionId", BaseTableName = "Executions" )]		
		public Int64 ExecutionId 
		{ 
		    get { return _executionId; } 
			set 
			{
			    _executionId = value;
			}
        }

		private Int64 _statementId;
		[DataMember]
		[SqlField(DbType.Int64, 8, Precision = 19, ColumnName ="StatementId", BaseColumnName ="StatementId", BaseTableName = "Executions" )]		
		public Int64 StatementId 
		{ 
		    get { return _statementId; } 
			set 
			{
			    _statementId = value;
			}
        }

		private DateTime _executionDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, ColumnName ="ExecutionDate", BaseColumnName ="ExecutionDate", BaseTableName = "Executions" )]		
		public DateTime ExecutionDate 
		{ 
		    get { return _executionDate; } 
			set 
			{
			    _executionDate = value;
			}
        }

		private Double _executionTime;
		[DataMember]
		[SqlField(DbType.Double, 8, Precision = 53, ColumnName ="ExecutionTime", BaseColumnName ="ExecutionTime", BaseTableName = "Executions" )]		
		public Double ExecutionTime 
		{ 
		    get { return _executionTime; } 
			set 
			{
			    _executionTime = value;
			}
        }


	}

	public partial class ExecutionRepository : Repository<Execution> 
	{
		public ExecutionRepository(DataService DataService) : base(DataService)
		{
		}

		public new SqliteProfilerDataService  DataService  
		{
			get { return (SqliteProfilerDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public Execution Get(string projectionName, Int64 executionId)
		{
			return ((IRepository<Execution>)this).Get(projectionName, executionId, FetchMode.UseIdentityMap);
		}

		public Execution Get(string projectionName, Int64 executionId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<Execution>)this).Get(projectionName, executionId, fetchMode);
		}

		public Execution Get(Projection projection, Int64 executionId)
		{
			return ((IRepository<Execution>)this).Get(projection, executionId, FetchMode.UseIdentityMap);
		}

		public Execution Get(Projection projection, Int64 executionId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<Execution>)this).Get(projection, executionId, fetchMode);
		}

		public Execution Get(string projectionName, Int64 executionId, params string[] fields)
		{
			return ((IRepository<Execution>)this).Get(projectionName, executionId, fields);
		}

		public Execution Get(Projection projection, Int64 executionId, params string[] fields)
		{
			return ((IRepository<Execution>)this).Get(projection, executionId, fields);
		}

		public bool Delete(Int64 executionId)
		{
			var entity = new Execution { ExecutionId = executionId };
			return this.Delete(entity);
		}

			}
	[Obsolete("Use nameof instead")]
	public static partial class ExecutionFields
	{
		public const string ExecutionId = "ExecutionId";
		public const string StatementId = "StatementId";
		public const string ExecutionDate = "ExecutionDate";
		public const string ExecutionTime = "ExecutionTime";
	}

}

namespace inercya.EntityLite.SqliteProfiler.Entities
{
	public partial class SqliteProfilerDataService : DataService
	{
		partial void OnCreated();

		private void Init()
		{
			EntityNameToEntityViewTransform = TextTransform.None;
			OnCreated();
		}

        public SqliteProfilerDataService() : base("AppConnectionString")
        {
			Init();
        }

        public SqliteProfilerDataService(string connectionStringName) : base(connectionStringName)
        {
			Init();
        }

        public SqliteProfilerDataService(string connectionString, string providerName) : base(connectionString, providerName)
        {
			Init();
        }

		private inercya.EntityLite.SqliteProfiler.Entities.StatementRepository _StatementRepository;
		public inercya.EntityLite.SqliteProfiler.Entities.StatementRepository StatementRepository
		{
			get 
			{
				if ( _StatementRepository == null)
				{
					_StatementRepository = new inercya.EntityLite.SqliteProfiler.Entities.StatementRepository(this);
				}
				return _StatementRepository;
			}
		}

		private inercya.EntityLite.SqliteProfiler.Entities.ExecutionRepository _ExecutionRepository;
		public inercya.EntityLite.SqliteProfiler.Entities.ExecutionRepository ExecutionRepository
		{
			get 
			{
				if ( _ExecutionRepository == null)
				{
					_ExecutionRepository = new inercya.EntityLite.SqliteProfiler.Entities.ExecutionRepository(this);
				}
				return _ExecutionRepository;
			}
		}
	}
}
