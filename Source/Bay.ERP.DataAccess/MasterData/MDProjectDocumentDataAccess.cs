// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Dec-2011, 11:00:45




using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;
using Bay.ERP.DataAccess;

namespace Bay.ERP.DataAccess
{
    internal sealed partial class MDProjectDocumentDataAccess : BaseDataAccess, IMDProjectDocumentDataAccess
    {
        #region Constructors

        public MDProjectDocumentDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDProjectDocumentEntity> CreateEntityBuilder<MDProjectDocumentEntity>()
        {
            return (new MDProjectDocumentBuilder()) as IEntityBuilder<MDProjectDocumentEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDProjectDocumentDataAccess.Add(MDProjectDocumentEntity mDProjectDocumentEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDProjectDocumentEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDProjectDocumentEntity, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Add(MDProjectDocumentEntity mDProjectDocumentEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectDocument_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectDocumentID");

                Database.AddInParameter(cmd, "@ProjectDocumentCategoryID", DbType.Int64, mDProjectDocumentEntity.ProjectDocumentCategoryID);	
                Database.AddInParameter(cmd, "@Name", DbType.String, mDProjectDocumentEntity.Name);	
                Database.AddInParameter(cmd, "@RequiredStandardTime", DbType.Int32, mDProjectDocumentEntity.RequiredStandardTime);	
                Database.AddInParameter(cmd, "@ReminderTime", DbType.Int32, mDProjectDocumentEntity.ReminderTime);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, mDProjectDocumentEntity.Remarks);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDProjectDocumentEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDProjectDocumentEntity already exists. Please specify another MDProjectDocumentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDProjectDocumentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDProjectDocumentEntity already exists. Please specify another MDProjectDocumentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDProjectDocumentEntity mDProjectDocumentEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectDocument_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectDocumentID", db);

                db.AddInParameter(cmd, "@ProjectDocumentCategoryID", DbType.Int64, mDProjectDocumentEntity.ProjectDocumentCategoryID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDProjectDocumentEntity.Name);
                db.AddInParameter(cmd, "@RequiredStandardTime", DbType.Int32, mDProjectDocumentEntity.RequiredStandardTime);
                db.AddInParameter(cmd, "@ReminderTime", DbType.Int32, mDProjectDocumentEntity.ReminderTime);
                db.AddInParameter(cmd, "@Remarks", DbType.String, mDProjectDocumentEntity.Remarks);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDProjectDocumentEntity.IsRemoved);

                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    returnCode = db.ExecuteNonQuery(cmd, transaction);

                    returnCode = GetReturnCodeFromParameter(cmd, db);

                    if (returnCode > 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Add Operation

        #region Add List Operation

        IList<Int64> IMDProjectDocumentDataAccess.Add(IList<MDProjectDocumentEntity> mDProjectDocumentEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDProjectDocumentEntity mDProjectDocumentEntity in mDProjectDocumentEntityList)
            {
                returnCode = (this as IMDProjectDocumentDataAccess).Add(mDProjectDocumentEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDProjectDocumentDataAccess.Update(MDProjectDocumentEntity mDProjectDocumentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDProjectDocumentEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDProjectDocumentEntity, filterExpression, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Update(MDProjectDocumentEntity mDProjectDocumentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectDocument_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectDocumentID", DbType.Int64, mDProjectDocumentEntity.ProjectDocumentID);
                Database.AddInParameter(cmd, "@ProjectDocumentCategoryID", DbType.Int64, mDProjectDocumentEntity.ProjectDocumentCategoryID);
                Database.AddInParameter(cmd, "@Name", DbType.String, mDProjectDocumentEntity.Name);
                Database.AddInParameter(cmd, "@RequiredStandardTime", DbType.Int32, mDProjectDocumentEntity.RequiredStandardTime);
                Database.AddInParameter(cmd, "@ReminderTime", DbType.Int32, mDProjectDocumentEntity.ReminderTime);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, mDProjectDocumentEntity.Remarks);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDProjectDocumentEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDProjectDocumentEntity already exists. Please specify another MDProjectDocumentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDProjectDocumentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDProjectDocumentEntity already exists. Please specify another MDProjectDocumentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDProjectDocumentEntity mDProjectDocumentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectDocument_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectDocumentID", DbType.Int64, mDProjectDocumentEntity.ProjectDocumentID);
                db.AddInParameter(cmd, "@ProjectDocumentCategoryID", DbType.Int64, mDProjectDocumentEntity.ProjectDocumentCategoryID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDProjectDocumentEntity.Name);
                db.AddInParameter(cmd, "@RequiredStandardTime", DbType.Int32, mDProjectDocumentEntity.RequiredStandardTime);
                db.AddInParameter(cmd, "@ReminderTime", DbType.Int32, mDProjectDocumentEntity.ReminderTime);
                db.AddInParameter(cmd, "@Remarks", DbType.String, mDProjectDocumentEntity.Remarks);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDProjectDocumentEntity.IsRemoved);

                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (IDataReader reader = db.ExecuteReader(cmd, transaction))
                    {
                        returnCode = GetReturnCodeFromParameter(cmd);
                    }                    

                    if (returnCode > 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Update Operation

        #region Update List Operation

        IList<Int64> IMDProjectDocumentDataAccess.Update(IList<MDProjectDocumentEntity> mDProjectDocumentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDProjectDocumentEntity mDProjectDocumentEntity in mDProjectDocumentEntityList)
            {
                returnCode = (this as IMDProjectDocumentDataAccess).Update(mDProjectDocumentEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDProjectDocumentDataAccess.Delete(MDProjectDocumentEntity mDProjectDocumentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDProjectDocumentEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDProjectDocumentEntity, filterExpression, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Delete(MDProjectDocumentEntity mDProjectDocumentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectDocument_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);


                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDProjectDocumentEntity already exists. Please specify another MDProjectDocumentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDProjectDocumentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDProjectDocumentEntity already exists. Please specify another MDProjectDocumentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDProjectDocumentEntity mDProjectDocumentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectDocument_SET";

            Database db = DatabaseFactory.CreateDatabase();


            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd, db);
                AddFilterExpressionParameter(cmd, filterExpression, db);


                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (IDataReader reader = db.ExecuteReader(cmd, transaction))
                    {
                        returnCode = GetReturnCodeFromParameter(cmd);
                    }

                    if (returnCode >= 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Delete Operation

        #region Delete List Operation

        IList<Int64> IMDProjectDocumentDataAccess.Delete(IList<MDProjectDocumentEntity> mDProjectDocumentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDProjectDocumentEntity mDProjectDocumentEntity in mDProjectDocumentEntityList)
            {
                returnCode = (this as IMDProjectDocumentDataAccess).Delete(mDProjectDocumentEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDProjectDocumentEntity> IMDProjectDocumentDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDProjectDocument_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDProjectDocumentEntity> list = CreateEntityBuilder<MDProjectDocumentEntity>().BuildEntities(reader);

                        if (list != null && list.Count > 0)
                        {
                            if ((reader.NextResult()) && (reader.Read()))
                            {
                                list[0].TotalRowCount = reader.GetInt32(0);
                            }
                        }

                        return list;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        DataTable IMDProjectDocumentDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDProjectDocument_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddCurrentPageParameter(cmd, currentPage);
                    AddPageSizeParameter(cmd, pageSize);
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    DataSet ds = new DataSet();
                    ds = Database.ExecuteDataSet(cmd);

                    if (ds.Tables.Count > 0)
                    {
                        return (ds.Tables[0]);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
