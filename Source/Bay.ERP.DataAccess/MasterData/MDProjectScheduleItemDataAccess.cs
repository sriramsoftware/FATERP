// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
    internal sealed partial class MDProjectScheduleItemDataAccess : BaseDataAccess, IMDProjectScheduleItemDataAccess
    {
        #region Constructors

        public MDProjectScheduleItemDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDProjectScheduleItemEntity> CreateEntityBuilder<MDProjectScheduleItemEntity>()
        {
            return (new MDProjectScheduleItemBuilder()) as IEntityBuilder<MDProjectScheduleItemEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDProjectScheduleItemDataAccess.Add(MDProjectScheduleItemEntity mDProjectScheduleItemEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDProjectScheduleItemEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDProjectScheduleItemEntity, option);
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

        private Int64 Add(MDProjectScheduleItemEntity mDProjectScheduleItemEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectScheduleItem_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectScheduleItemID");

                Database.AddInParameter(cmd, "@ParentProjectScheduleItemID", DbType.Int64, mDProjectScheduleItemEntity.ParentProjectScheduleItemID);	
                Database.AddInParameter(cmd, "@Title", DbType.String, mDProjectScheduleItemEntity.Title);	
                Database.AddInParameter(cmd, "@Description", DbType.String, mDProjectScheduleItemEntity.Description);	
                Database.AddInParameter(cmd, "@IssuePriorityID", DbType.Int64, mDProjectScheduleItemEntity.IssuePriorityID);	
                Database.AddInParameter(cmd, "@Duration", DbType.Decimal, mDProjectScheduleItemEntity.Duration);	
                Database.AddInParameter(cmd, "@NotifyBeforeMin", DbType.Int32, mDProjectScheduleItemEntity.NotifyBeforeMin);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDProjectScheduleItemEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDProjectScheduleItemEntity already exists. Please specify another MDProjectScheduleItemEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDProjectScheduleItemEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDProjectScheduleItemEntity already exists. Please specify another MDProjectScheduleItemEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDProjectScheduleItemEntity mDProjectScheduleItemEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectScheduleItem_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectScheduleItemID", db);

                db.AddInParameter(cmd, "@ParentProjectScheduleItemID", DbType.Int64, mDProjectScheduleItemEntity.ParentProjectScheduleItemID);
                db.AddInParameter(cmd, "@Title", DbType.String, mDProjectScheduleItemEntity.Title);
                db.AddInParameter(cmd, "@Description", DbType.String, mDProjectScheduleItemEntity.Description);
                db.AddInParameter(cmd, "@IssuePriorityID", DbType.Int64, mDProjectScheduleItemEntity.IssuePriorityID);
                db.AddInParameter(cmd, "@Duration", DbType.Decimal, mDProjectScheduleItemEntity.Duration);
                db.AddInParameter(cmd, "@NotifyBeforeMin", DbType.Int32, mDProjectScheduleItemEntity.NotifyBeforeMin);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDProjectScheduleItemEntity.IsRemoved);

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

        IList<Int64> IMDProjectScheduleItemDataAccess.Add(IList<MDProjectScheduleItemEntity> mDProjectScheduleItemEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDProjectScheduleItemEntity mDProjectScheduleItemEntity in mDProjectScheduleItemEntityList)
            {
                returnCode = (this as IMDProjectScheduleItemDataAccess).Add(mDProjectScheduleItemEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDProjectScheduleItemDataAccess.Update(MDProjectScheduleItemEntity mDProjectScheduleItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDProjectScheduleItemEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDProjectScheduleItemEntity, filterExpression, option);
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

        private Int64 Update(MDProjectScheduleItemEntity mDProjectScheduleItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectScheduleItem_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectScheduleItemID", DbType.Int64, mDProjectScheduleItemEntity.ProjectScheduleItemID);
                Database.AddInParameter(cmd, "@ParentProjectScheduleItemID", DbType.Int64, mDProjectScheduleItemEntity.ParentProjectScheduleItemID);
                Database.AddInParameter(cmd, "@Title", DbType.String, mDProjectScheduleItemEntity.Title);
                Database.AddInParameter(cmd, "@Description", DbType.String, mDProjectScheduleItemEntity.Description);
                Database.AddInParameter(cmd, "@IssuePriorityID", DbType.Int64, mDProjectScheduleItemEntity.IssuePriorityID);
                Database.AddInParameter(cmd, "@Duration", DbType.Decimal, mDProjectScheduleItemEntity.Duration);
                Database.AddInParameter(cmd, "@NotifyBeforeMin", DbType.Int32, mDProjectScheduleItemEntity.NotifyBeforeMin);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDProjectScheduleItemEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDProjectScheduleItemEntity already exists. Please specify another MDProjectScheduleItemEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDProjectScheduleItemEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDProjectScheduleItemEntity already exists. Please specify another MDProjectScheduleItemEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDProjectScheduleItemEntity mDProjectScheduleItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectScheduleItem_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectScheduleItemID", DbType.Int64, mDProjectScheduleItemEntity.ProjectScheduleItemID);
                db.AddInParameter(cmd, "@ParentProjectScheduleItemID", DbType.Int64, mDProjectScheduleItemEntity.ParentProjectScheduleItemID);
                db.AddInParameter(cmd, "@Title", DbType.String, mDProjectScheduleItemEntity.Title);
                db.AddInParameter(cmd, "@Description", DbType.String, mDProjectScheduleItemEntity.Description);
                db.AddInParameter(cmd, "@IssuePriorityID", DbType.Int64, mDProjectScheduleItemEntity.IssuePriorityID);
                db.AddInParameter(cmd, "@Duration", DbType.Decimal, mDProjectScheduleItemEntity.Duration);
                db.AddInParameter(cmd, "@NotifyBeforeMin", DbType.Int32, mDProjectScheduleItemEntity.NotifyBeforeMin);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDProjectScheduleItemEntity.IsRemoved);

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

        IList<Int64> IMDProjectScheduleItemDataAccess.Update(IList<MDProjectScheduleItemEntity> mDProjectScheduleItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDProjectScheduleItemEntity mDProjectScheduleItemEntity in mDProjectScheduleItemEntityList)
            {
                returnCode = (this as IMDProjectScheduleItemDataAccess).Update(mDProjectScheduleItemEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDProjectScheduleItemDataAccess.Delete(MDProjectScheduleItemEntity mDProjectScheduleItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDProjectScheduleItemEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDProjectScheduleItemEntity, filterExpression, option);
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

        private Int64 Delete(MDProjectScheduleItemEntity mDProjectScheduleItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectScheduleItem_SET";

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
                                throw new ArgumentException("MDProjectScheduleItemEntity already exists. Please specify another MDProjectScheduleItemEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDProjectScheduleItemEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDProjectScheduleItemEntity already exists. Please specify another MDProjectScheduleItemEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDProjectScheduleItemEntity mDProjectScheduleItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectScheduleItem_SET";

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

        IList<Int64> IMDProjectScheduleItemDataAccess.Delete(IList<MDProjectScheduleItemEntity> mDProjectScheduleItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDProjectScheduleItemEntity mDProjectScheduleItemEntity in mDProjectScheduleItemEntityList)
            {
                returnCode = (this as IMDProjectScheduleItemDataAccess).Delete(mDProjectScheduleItemEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDProjectScheduleItemEntity> IMDProjectScheduleItemDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDProjectScheduleItem_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDProjectScheduleItemEntity> list = CreateEntityBuilder<MDProjectScheduleItemEntity>().BuildEntities(reader);

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

        DataTable IMDProjectScheduleItemDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDProjectScheduleItem_GET";

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
