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
    internal sealed partial class MDProjectDocumentCategoryDataAccess : BaseDataAccess, IMDProjectDocumentCategoryDataAccess
    {
        #region Constructors

        public MDProjectDocumentCategoryDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDProjectDocumentCategoryEntity> CreateEntityBuilder<MDProjectDocumentCategoryEntity>()
        {
            return (new MDProjectDocumentCategoryBuilder()) as IEntityBuilder<MDProjectDocumentCategoryEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDProjectDocumentCategoryDataAccess.Add(MDProjectDocumentCategoryEntity mDProjectDocumentCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDProjectDocumentCategoryEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDProjectDocumentCategoryEntity, option);
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

        private Int64 Add(MDProjectDocumentCategoryEntity mDProjectDocumentCategoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectDocumentCategory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectDocumentCategoryID");

                Database.AddInParameter(cmd, "@ParentProjectDocumentCategoryID", DbType.Int64, mDProjectDocumentCategoryEntity.ParentProjectDocumentCategoryID);	
                Database.AddInParameter(cmd, "@Name", DbType.String, mDProjectDocumentCategoryEntity.Name);	
                Database.AddInParameter(cmd, "@RequiredStandardTime", DbType.Int32, mDProjectDocumentCategoryEntity.RequiredStandardTime);	
                Database.AddInParameter(cmd, "@ReminderTime", DbType.Int32, mDProjectDocumentCategoryEntity.ReminderTime);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDProjectDocumentCategoryEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDProjectDocumentCategoryEntity already exists. Please specify another MDProjectDocumentCategoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDProjectDocumentCategoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDProjectDocumentCategoryEntity already exists. Please specify another MDProjectDocumentCategoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDProjectDocumentCategoryEntity mDProjectDocumentCategoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectDocumentCategory_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectDocumentCategoryID", db);

                db.AddInParameter(cmd, "@ParentProjectDocumentCategoryID", DbType.Int64, mDProjectDocumentCategoryEntity.ParentProjectDocumentCategoryID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDProjectDocumentCategoryEntity.Name);
                db.AddInParameter(cmd, "@RequiredStandardTime", DbType.Int32, mDProjectDocumentCategoryEntity.RequiredStandardTime);
                db.AddInParameter(cmd, "@ReminderTime", DbType.Int32, mDProjectDocumentCategoryEntity.ReminderTime);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDProjectDocumentCategoryEntity.IsRemoved);

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

        IList<Int64> IMDProjectDocumentCategoryDataAccess.Add(IList<MDProjectDocumentCategoryEntity> mDProjectDocumentCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDProjectDocumentCategoryEntity mDProjectDocumentCategoryEntity in mDProjectDocumentCategoryEntityList)
            {
                returnCode = (this as IMDProjectDocumentCategoryDataAccess).Add(mDProjectDocumentCategoryEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDProjectDocumentCategoryDataAccess.Update(MDProjectDocumentCategoryEntity mDProjectDocumentCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDProjectDocumentCategoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDProjectDocumentCategoryEntity, filterExpression, option);
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

        private Int64 Update(MDProjectDocumentCategoryEntity mDProjectDocumentCategoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectDocumentCategory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectDocumentCategoryID", DbType.Int64, mDProjectDocumentCategoryEntity.ProjectDocumentCategoryID);
                Database.AddInParameter(cmd, "@ParentProjectDocumentCategoryID", DbType.Int64, mDProjectDocumentCategoryEntity.ParentProjectDocumentCategoryID);
                Database.AddInParameter(cmd, "@Name", DbType.String, mDProjectDocumentCategoryEntity.Name);
                Database.AddInParameter(cmd, "@RequiredStandardTime", DbType.Int32, mDProjectDocumentCategoryEntity.RequiredStandardTime);
                Database.AddInParameter(cmd, "@ReminderTime", DbType.Int32, mDProjectDocumentCategoryEntity.ReminderTime);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDProjectDocumentCategoryEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDProjectDocumentCategoryEntity already exists. Please specify another MDProjectDocumentCategoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDProjectDocumentCategoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDProjectDocumentCategoryEntity already exists. Please specify another MDProjectDocumentCategoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDProjectDocumentCategoryEntity mDProjectDocumentCategoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectDocumentCategory_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectDocumentCategoryID", DbType.Int64, mDProjectDocumentCategoryEntity.ProjectDocumentCategoryID);
                db.AddInParameter(cmd, "@ParentProjectDocumentCategoryID", DbType.Int64, mDProjectDocumentCategoryEntity.ParentProjectDocumentCategoryID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDProjectDocumentCategoryEntity.Name);
                db.AddInParameter(cmd, "@RequiredStandardTime", DbType.Int32, mDProjectDocumentCategoryEntity.RequiredStandardTime);
                db.AddInParameter(cmd, "@ReminderTime", DbType.Int32, mDProjectDocumentCategoryEntity.ReminderTime);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDProjectDocumentCategoryEntity.IsRemoved);

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

        IList<Int64> IMDProjectDocumentCategoryDataAccess.Update(IList<MDProjectDocumentCategoryEntity> mDProjectDocumentCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDProjectDocumentCategoryEntity mDProjectDocumentCategoryEntity in mDProjectDocumentCategoryEntityList)
            {
                returnCode = (this as IMDProjectDocumentCategoryDataAccess).Update(mDProjectDocumentCategoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDProjectDocumentCategoryDataAccess.Delete(MDProjectDocumentCategoryEntity mDProjectDocumentCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDProjectDocumentCategoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDProjectDocumentCategoryEntity, filterExpression, option);
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

        private Int64 Delete(MDProjectDocumentCategoryEntity mDProjectDocumentCategoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectDocumentCategory_SET";

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
                                throw new ArgumentException("MDProjectDocumentCategoryEntity already exists. Please specify another MDProjectDocumentCategoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDProjectDocumentCategoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDProjectDocumentCategoryEntity already exists. Please specify another MDProjectDocumentCategoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDProjectDocumentCategoryEntity mDProjectDocumentCategoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectDocumentCategory_SET";

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

        IList<Int64> IMDProjectDocumentCategoryDataAccess.Delete(IList<MDProjectDocumentCategoryEntity> mDProjectDocumentCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDProjectDocumentCategoryEntity mDProjectDocumentCategoryEntity in mDProjectDocumentCategoryEntityList)
            {
                returnCode = (this as IMDProjectDocumentCategoryDataAccess).Delete(mDProjectDocumentCategoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDProjectDocumentCategoryEntity> IMDProjectDocumentCategoryDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDProjectDocumentCategory_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDProjectDocumentCategoryEntity> list = CreateEntityBuilder<MDProjectDocumentCategoryEntity>().BuildEntities(reader);

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

        DataTable IMDProjectDocumentCategoryDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDProjectDocumentCategory_GET";

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
