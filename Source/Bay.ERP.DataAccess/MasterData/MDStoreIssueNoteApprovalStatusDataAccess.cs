// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 12:52:14




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
    internal sealed partial class MDStoreIssueNoteApprovalStatusDataAccess : BaseDataAccess, IMDStoreIssueNoteApprovalStatusDataAccess
    {
        #region Constructors

        public MDStoreIssueNoteApprovalStatusDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDStoreIssueNoteApprovalStatusEntity> CreateEntityBuilder<MDStoreIssueNoteApprovalStatusEntity>()
        {
            return (new MDStoreIssueNoteApprovalStatusBuilder()) as IEntityBuilder<MDStoreIssueNoteApprovalStatusEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDStoreIssueNoteApprovalStatusDataAccess.Add(MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDStoreIssueNoteApprovalStatusEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDStoreIssueNoteApprovalStatusEntity, option);
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

        private Int64 Add(MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDStoreIssueNoteApprovalStatus_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "StoreIssueNoteApprovalStatusID");

                Database.AddInParameter(cmd, "@Name", DbType.String, mDStoreIssueNoteApprovalStatusEntity.Name);	
                Database.AddInParameter(cmd, "@Description", DbType.String, mDStoreIssueNoteApprovalStatusEntity.Description);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDStoreIssueNoteApprovalStatusEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDStoreIssueNoteApprovalStatusEntity already exists. Please specify another MDStoreIssueNoteApprovalStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDStoreIssueNoteApprovalStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDStoreIssueNoteApprovalStatusEntity already exists. Please specify another MDStoreIssueNoteApprovalStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDStoreIssueNoteApprovalStatus_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "StoreIssueNoteApprovalStatusID", db);

                db.AddInParameter(cmd, "@Name", DbType.String, mDStoreIssueNoteApprovalStatusEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDStoreIssueNoteApprovalStatusEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDStoreIssueNoteApprovalStatusEntity.IsRemoved);

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

        IList<Int64> IMDStoreIssueNoteApprovalStatusDataAccess.Add(IList<MDStoreIssueNoteApprovalStatusEntity> mDStoreIssueNoteApprovalStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity in mDStoreIssueNoteApprovalStatusEntityList)
            {
                returnCode = (this as IMDStoreIssueNoteApprovalStatusDataAccess).Add(mDStoreIssueNoteApprovalStatusEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDStoreIssueNoteApprovalStatusDataAccess.Update(MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDStoreIssueNoteApprovalStatusEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDStoreIssueNoteApprovalStatusEntity, filterExpression, option);
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

        private Int64 Update(MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDStoreIssueNoteApprovalStatus_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@StoreIssueNoteApprovalStatusID", DbType.Int64, mDStoreIssueNoteApprovalStatusEntity.StoreIssueNoteApprovalStatusID);
                Database.AddInParameter(cmd, "@Name", DbType.String, mDStoreIssueNoteApprovalStatusEntity.Name);
                Database.AddInParameter(cmd, "@Description", DbType.String, mDStoreIssueNoteApprovalStatusEntity.Description);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDStoreIssueNoteApprovalStatusEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDStoreIssueNoteApprovalStatusEntity already exists. Please specify another MDStoreIssueNoteApprovalStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDStoreIssueNoteApprovalStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDStoreIssueNoteApprovalStatusEntity already exists. Please specify another MDStoreIssueNoteApprovalStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDStoreIssueNoteApprovalStatus_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@StoreIssueNoteApprovalStatusID", DbType.Int64, mDStoreIssueNoteApprovalStatusEntity.StoreIssueNoteApprovalStatusID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDStoreIssueNoteApprovalStatusEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDStoreIssueNoteApprovalStatusEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDStoreIssueNoteApprovalStatusEntity.IsRemoved);

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

        IList<Int64> IMDStoreIssueNoteApprovalStatusDataAccess.Update(IList<MDStoreIssueNoteApprovalStatusEntity> mDStoreIssueNoteApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity in mDStoreIssueNoteApprovalStatusEntityList)
            {
                returnCode = (this as IMDStoreIssueNoteApprovalStatusDataAccess).Update(mDStoreIssueNoteApprovalStatusEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDStoreIssueNoteApprovalStatusDataAccess.Delete(MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDStoreIssueNoteApprovalStatusEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDStoreIssueNoteApprovalStatusEntity, filterExpression, option);
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

        private Int64 Delete(MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDStoreIssueNoteApprovalStatus_SET";

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
                                throw new ArgumentException("MDStoreIssueNoteApprovalStatusEntity already exists. Please specify another MDStoreIssueNoteApprovalStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDStoreIssueNoteApprovalStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDStoreIssueNoteApprovalStatusEntity already exists. Please specify another MDStoreIssueNoteApprovalStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDStoreIssueNoteApprovalStatus_SET";

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

        IList<Int64> IMDStoreIssueNoteApprovalStatusDataAccess.Delete(IList<MDStoreIssueNoteApprovalStatusEntity> mDStoreIssueNoteApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity in mDStoreIssueNoteApprovalStatusEntityList)
            {
                returnCode = (this as IMDStoreIssueNoteApprovalStatusDataAccess).Delete(mDStoreIssueNoteApprovalStatusEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDStoreIssueNoteApprovalStatusEntity> IMDStoreIssueNoteApprovalStatusDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDStoreIssueNoteApprovalStatus_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDStoreIssueNoteApprovalStatusEntity> list = CreateEntityBuilder<MDStoreIssueNoteApprovalStatusEntity>().BuildEntities(reader);

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

        DataTable IMDStoreIssueNoteApprovalStatusDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDStoreIssueNoteApprovalStatus_GET";

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
