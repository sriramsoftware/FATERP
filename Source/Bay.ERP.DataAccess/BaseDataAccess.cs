using System;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Collections.Generic;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    internal interface IEntityBuilder<T> where T : BaseEntity
    {
        IList<T> BuildEntities(IDataReader dataReader);

        T BuildEntity(IDataReader dataReader);
    }

    internal abstract class BaseDataAccess : MarshalByRefObject, IDisposable
    {
        #region Instance Variables

        private bool _isDisposed;
        private Context _context;

        private Database _db;

        #endregion

        #region Properties

        protected virtual Context Context
        {
            [DebuggerStepThrough()]
            get
            {
                if (_context == null)
                {
                    _context = new Context();
                }

                return _context;
            }
        }

        protected virtual Database Database
        {
            [DebuggerStepThrough()]
            get
            {
                if (_db == null)
                {
                    string type = typeof(Database).ToString();

                    if (Context.Contains(type))
                    {
                        _db = (Database)Context[type];

                    }
                    else
                    {
                        _db = DatabaseFactory.CreateDatabase();

                        Context[type] = _db as IDisposable;
                    }
                }

                return _db;
            }
        }

        #endregion

        #region Constructer & Destructer

        protected BaseDataAccess(Context context)
        {
            _context = context;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                }
            }

            _isDisposed = true;
        }

        ~BaseDataAccess()
        {
            Dispose(false);
        }

        #endregion

        #region Protected Methods

        [DebuggerStepThrough()]
        protected abstract IEntityBuilder<T> CreateEntityBuilder<T>() where T : BaseEntity;

        [DebuggerStepThrough()]
        protected virtual Int64 GetReturnCodeFromParameter(DbCommand command)
        {
            return (Int64)Database.GetParameterValue(command, SqlConstants.PRM_RETURN_CODE);
        }

        [DebuggerStepThrough()]
        protected virtual Int64 GetReturnCodeFromParameter(DbCommand command, Database db)
        {
            return (Int64)db.GetParameterValue(command, SqlConstants.PRM_RETURN_CODE);
        }

        [DebuggerStepThrough()]
        protected virtual int GetNewIdFromParameter(DbCommand command, string paramName)
        {
            return (int)Database.GetParameterValue(command, string.Concat("@" + paramName));
        }

        [DebuggerStepThrough()]
        protected virtual int GetTotalRowFromParameter(DbCommand command)
        {
            return (int)Database.GetParameterValue(command, SqlConstants.PRM_TOTAL_ROW);
        }

        [DebuggerStepThrough()]
        protected virtual int GetTotalPageFromParameter(DbCommand command)
        {
            return (int)Database.GetParameterValue(command, SqlConstants.PRM_TOTAL_PAGE);
        }

        [DebuggerStepThrough()]
        protected virtual int GetCountFromParameter(DbCommand command)
        {
            return (int)Database.GetParameterValue(command, SqlConstants.PRM_COUNT);
        }

        [DebuggerStepThrough()]
        protected void AddOutputParameter(DbCommand command)
        {
            Database.AddOutParameter(command, "@ReturnKey", DbType.Int64, 4);
        }

        #region EXTRAS

        // this method should be removed
        [DebuggerStepThrough()]
        protected void AddOptionParameter(DbCommand command, int Option)
        {
            Database.AddInParameter(command, "@Option", DbType.Int32, Option);
        }

        [DebuggerStepThrough()]
        protected void AddOptionParameter(DbCommand command, DatabaseOperationType option)
        {
            Database.AddInParameter(command, "@Option", DbType.Int32, option);
        }

        [DebuggerStepThrough()]
        protected void AddCurrentPageParameter(DbCommand command, int? currentPage)
        {
            if (currentPage == null)
            {
                currentPage = -1; 
            }
            Database.AddInParameter(command, "@CurrentPage", DbType.Int32, currentPage);
        }

        [DebuggerStepThrough()]
        protected void AddPageSizeParameter(DbCommand command, int? pageSize)
        {
            if (pageSize == null)
            {
                pageSize = -1;
            }

            Database.AddInParameter(command, "@PageSize", DbType.Int32, pageSize);
        }

        //this method should be romeved
        [DebuggerStepThrough()]
        protected void AddSortExpressionParameter(DbCommand command, string SortExpression)
        {
            Database.AddInParameter(command, "@SortExpression", DbType.String, SortExpression);
        }       

        [DebuggerStepThrough()]
        protected void AddFilterExpressionParameter(DbCommand command, string filterExpression)
        {
            Database.AddInParameter(command, "@FilterExpression", DbType.String, filterExpression);
        }

        [DebuggerStepThrough()]
        protected void AddEntryDateParameter(DbCommand command)
        {
            DateTime defaultDate = new DateTime(1754, 1, 1);
            Database.AddInParameter(command, "@EntryDate", DbType.Date, defaultDate);
        }

        [DebuggerStepThrough()]
        protected void AddNullTsParameter(DbCommand command)
        {
            Database.AddInParameter(command, "@Ts", DbType.Int64, -99);
        }

        [DebuggerStepThrough()]
        protected void AddNullPrimaryKeyParameter(DbCommand command, string KeyName)
        {
            Database.AddInParameter(command, "@" + KeyName.ToString(), DbType.Int64, -99);
        }

        // FOR TRANSACTION OPEN DB

        [DebuggerStepThrough()]
        protected void AddOutputParameter(DbCommand command, Database db)
        {
            db.AddOutParameter(command, "@ReturnKey", DbType.Int64, 8);
        }
        
        [DebuggerStepThrough()]
        protected void AddOptionParameter(DbCommand command, int Option, Database db)
        {
            db.AddInParameter(command, "@Option", DbType.Int32, Option);
        }

        [DebuggerStepThrough()]
        protected void AddOptionParameter(DbCommand command, DatabaseOperationType option, Database db)
        {
            db.AddInParameter(command, "@Option", DbType.Int32, option);
        }

        [DebuggerStepThrough()]
        protected void AddCurrentPageParameter(DbCommand command, int? currentPage, Database db)
        {
            if (currentPage == null)
            {
                currentPage = -1;
            }

            db.AddInParameter(command, "@CurrentPage", DbType.Int32, currentPage);
        }

        [DebuggerStepThrough()]
        protected void AddPageSizeParameter(DbCommand command, int? pageSize, Database db)
        {
            if (pageSize == null)
            {
                pageSize = -1;
            }

            db.AddInParameter(command, "@PageSize", DbType.Int32, pageSize);
        }        
        
        [DebuggerStepThrough()]
        protected void AddSortExpressionParameter(DbCommand command, string SortExpression, Database db)
        {
            db.AddInParameter(command, "@SortExpression", DbType.String, SortExpression);
        }

        [DebuggerStepThrough()]
        protected void AddFilterExpressionParameter(DbCommand command, string filterExpression, Database db)
        {                               
            db.AddInParameter(command, "@FilterExpression", DbType.String, filterExpression);
        }

        [DebuggerStepThrough()]
        protected void AddEntryDateParameter(DbCommand command, Database db)
        {
            DateTime defaultDate = new DateTime(1754, 1, 1);
            db.AddInParameter(command, "@EntryDate", DbType.String, defaultDate.ToString());
        }

        [DebuggerStepThrough()]
        protected void AddNullTsParameter(DbCommand command, Database db)
        {
            db.AddInParameter(command, "@Ts", DbType.Int64, -99);
        }

        protected void AddNullPrimaryKeyParameter(DbCommand command, string KeyName, Database db)
        {
            db.AddInParameter(command, "@" + KeyName.ToString(), DbType.Int64, -99);
        }

        //EntryDate

        #endregion



        #endregion
    }
}