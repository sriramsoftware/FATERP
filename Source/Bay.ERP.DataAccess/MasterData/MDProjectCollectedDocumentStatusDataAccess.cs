// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




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
    internal sealed partial class MDProjectCollectedDocumentStatusDataAccess : BaseDataAccess, IMDProjectCollectedDocumentStatusDataAccess
    {
        #region Constructors

        public MDProjectCollectedDocumentStatusDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDProjectCollectedDocumentStatusEntity> CreateEntityBuilder<MDProjectCollectedDocumentStatusEntity>()
        {
            return (new MDProjectCollectedDocumentStatusBuilder()) as IEntityBuilder<MDProjectCollectedDocumentStatusEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDProjectCollectedDocumentStatusDataAccess.Add(MDProjectCollectedDocumentStatusEntity mDProjectCollectedDocumentStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDProjectCollectedDocumentStatusEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDProjectCollectedDocumentStatusEntity, option);
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

        private Int64 Add(MDProjectCollectedDocumentStatusEntity mDProjectCollectedDocumentStatusEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectCollectedDocumentStatus_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectCollectedDocumentStatusID");

                Database.AddInParameter(cmd, "@Name", DbType.String, mDProjectCollectedDocumentStatusEntity.Name);	
                Database.AddInParameter(cmd, "@Description", DbType.String, mDProjectCollectedDocumentStatusEntity.Description);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDProjectCollectedDocumentStatusEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDProjectCollectedDocumentStatusEntity already exists. Please specify another MDProjectCollectedDocumentStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDProjectCollectedDocumentStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDProjectCollectedDocumentStatusEntity already exists. Please specify another MDProjectCollectedDocumentStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDProjectCollectedDocumentStatusEntity mDProjectCollectedDocumentStatusEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectCollectedDocumentStatus_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectCollectedDocumentStatusID", db);

                db.AddInParameter(cmd, "@Name", DbType.String, mDProjectCollectedDocumentStatusEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDProjectCollectedDocumentStatusEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDProjectCollectedDocumentStatusEntity.IsRemoved);

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

        IList<Int64> IMDProjectCollectedDocumentStatusDataAccess.Add(IList<MDProjectCollectedDocumentStatusEntity> mDProjectCollectedDocumentStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDProjectCollectedDocumentStatusEntity mDProjectCollectedDocumentStatusEntity in mDProjectCollectedDocumentStatusEntityList)
            {
                returnCode = (this as IMDProjectCollectedDocumentStatusDataAccess).Add(mDProjectCollectedDocumentStatusEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDProjectCollectedDocumentStatusDataAccess.Update(MDProjectCollectedDocumentStatusEntity mDProjectCollectedDocumentStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDProjectCollectedDocumentStatusEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDProjectCollectedDocumentStatusEntity, filterExpression, option);
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

        private Int64 Update(MDProjectCollectedDocumentStatusEntity mDProjectCollectedDocumentStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectCollectedDocumentStatus_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectCollectedDocumentStatusID", DbType.Int64, mDProjectCollectedDocumentStatusEntity.ProjectCollectedDocumentStatusID);
                Database.AddInParameter(cmd, "@Name", DbType.String, mDProjectCollectedDocumentStatusEntity.Name);
                Database.AddInParameter(cmd, "@Description", DbType.String, mDProjectCollectedDocumentStatusEntity.Description);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDProjectCollectedDocumentStatusEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDProjectCollectedDocumentStatusEntity already exists. Please specify another MDProjectCollectedDocumentStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDProjectCollectedDocumentStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDProjectCollectedDocumentStatusEntity already exists. Please specify another MDProjectCollectedDocumentStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDProjectCollectedDocumentStatusEntity mDProjectCollectedDocumentStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectCollectedDocumentStatus_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectCollectedDocumentStatusID", DbType.Int64, mDProjectCollectedDocumentStatusEntity.ProjectCollectedDocumentStatusID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDProjectCollectedDocumentStatusEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDProjectCollectedDocumentStatusEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDProjectCollectedDocumentStatusEntity.IsRemoved);

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

        IList<Int64> IMDProjectCollectedDocumentStatusDataAccess.Update(IList<MDProjectCollectedDocumentStatusEntity> mDProjectCollectedDocumentStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDProjectCollectedDocumentStatusEntity mDProjectCollectedDocumentStatusEntity in mDProjectCollectedDocumentStatusEntityList)
            {
                returnCode = (this as IMDProjectCollectedDocumentStatusDataAccess).Update(mDProjectCollectedDocumentStatusEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDProjectCollectedDocumentStatusDataAccess.Delete(MDProjectCollectedDocumentStatusEntity mDProjectCollectedDocumentStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDProjectCollectedDocumentStatusEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDProjectCollectedDocumentStatusEntity, filterExpression, option);
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

        private Int64 Delete(MDProjectCollectedDocumentStatusEntity mDProjectCollectedDocumentStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectCollectedDocumentStatus_SET";

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
                                throw new ArgumentException("MDProjectCollectedDocumentStatusEntity already exists. Please specify another MDProjectCollectedDocumentStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDProjectCollectedDocumentStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDProjectCollectedDocumentStatusEntity already exists. Please specify another MDProjectCollectedDocumentStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDProjectCollectedDocumentStatusEntity mDProjectCollectedDocumentStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectCollectedDocumentStatus_SET";

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

        IList<Int64> IMDProjectCollectedDocumentStatusDataAccess.Delete(IList<MDProjectCollectedDocumentStatusEntity> mDProjectCollectedDocumentStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDProjectCollectedDocumentStatusEntity mDProjectCollectedDocumentStatusEntity in mDProjectCollectedDocumentStatusEntityList)
            {
                returnCode = (this as IMDProjectCollectedDocumentStatusDataAccess).Delete(mDProjectCollectedDocumentStatusEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDProjectCollectedDocumentStatusEntity> IMDProjectCollectedDocumentStatusDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDProjectCollectedDocumentStatus_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDProjectCollectedDocumentStatusEntity> list = CreateEntityBuilder<MDProjectCollectedDocumentStatusEntity>().BuildEntities(reader);

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

        DataTable IMDProjectCollectedDocumentStatusDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDProjectCollectedDocumentStatus_GET";

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
