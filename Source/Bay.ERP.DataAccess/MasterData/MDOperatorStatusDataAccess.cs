// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2015, 12:41:19




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
    internal sealed partial class MDOperatorStatusDataAccess : BaseDataAccess, IMDOperatorStatusDataAccess
    {
        #region Constructors

        public MDOperatorStatusDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDOperatorStatusEntity> CreateEntityBuilder<MDOperatorStatusEntity>()
        {
            return (new MDOperatorStatusBuilder()) as IEntityBuilder<MDOperatorStatusEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDOperatorStatusDataAccess.Add(MDOperatorStatusEntity mDOperatorStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDOperatorStatusEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDOperatorStatusEntity, option);
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

        private Int64 Add(MDOperatorStatusEntity mDOperatorStatusEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDOperatorStatus_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "OperatorStatusID");

                Database.AddInParameter(cmd, "@Name", DbType.String, mDOperatorStatusEntity.Name);	
                Database.AddInParameter(cmd, "@Descripton", DbType.String, mDOperatorStatusEntity.Descripton);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDOperatorStatusEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDOperatorStatusEntity already exists. Please specify another MDOperatorStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDOperatorStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDOperatorStatusEntity already exists. Please specify another MDOperatorStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDOperatorStatusEntity mDOperatorStatusEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDOperatorStatus_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "OperatorStatusID", db);

                db.AddInParameter(cmd, "@Name", DbType.String, mDOperatorStatusEntity.Name);
                db.AddInParameter(cmd, "@Descripton", DbType.String, mDOperatorStatusEntity.Descripton);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDOperatorStatusEntity.IsRemoved);

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

        IList<Int64> IMDOperatorStatusDataAccess.Add(IList<MDOperatorStatusEntity> mDOperatorStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDOperatorStatusEntity mDOperatorStatusEntity in mDOperatorStatusEntityList)
            {
                returnCode = (this as IMDOperatorStatusDataAccess).Add(mDOperatorStatusEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDOperatorStatusDataAccess.Update(MDOperatorStatusEntity mDOperatorStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDOperatorStatusEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDOperatorStatusEntity, filterExpression, option);
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

        private Int64 Update(MDOperatorStatusEntity mDOperatorStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDOperatorStatus_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@OperatorStatusID", DbType.Int64, mDOperatorStatusEntity.OperatorStatusID);
                Database.AddInParameter(cmd, "@Name", DbType.String, mDOperatorStatusEntity.Name);
                Database.AddInParameter(cmd, "@Descripton", DbType.String, mDOperatorStatusEntity.Descripton);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDOperatorStatusEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDOperatorStatusEntity already exists. Please specify another MDOperatorStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDOperatorStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDOperatorStatusEntity already exists. Please specify another MDOperatorStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDOperatorStatusEntity mDOperatorStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDOperatorStatus_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@OperatorStatusID", DbType.Int64, mDOperatorStatusEntity.OperatorStatusID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDOperatorStatusEntity.Name);
                db.AddInParameter(cmd, "@Descripton", DbType.String, mDOperatorStatusEntity.Descripton);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDOperatorStatusEntity.IsRemoved);

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

        IList<Int64> IMDOperatorStatusDataAccess.Update(IList<MDOperatorStatusEntity> mDOperatorStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDOperatorStatusEntity mDOperatorStatusEntity in mDOperatorStatusEntityList)
            {
                returnCode = (this as IMDOperatorStatusDataAccess).Update(mDOperatorStatusEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDOperatorStatusDataAccess.Delete(MDOperatorStatusEntity mDOperatorStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDOperatorStatusEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDOperatorStatusEntity, filterExpression, option);
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

        private Int64 Delete(MDOperatorStatusEntity mDOperatorStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDOperatorStatus_SET";

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
                                throw new ArgumentException("MDOperatorStatusEntity already exists. Please specify another MDOperatorStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDOperatorStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDOperatorStatusEntity already exists. Please specify another MDOperatorStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDOperatorStatusEntity mDOperatorStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDOperatorStatus_SET";

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

        IList<Int64> IMDOperatorStatusDataAccess.Delete(IList<MDOperatorStatusEntity> mDOperatorStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDOperatorStatusEntity mDOperatorStatusEntity in mDOperatorStatusEntityList)
            {
                returnCode = (this as IMDOperatorStatusDataAccess).Delete(mDOperatorStatusEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDOperatorStatusEntity> IMDOperatorStatusDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDOperatorStatus_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDOperatorStatusEntity> list = CreateEntityBuilder<MDOperatorStatusEntity>().BuildEntities(reader);

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

        DataTable IMDOperatorStatusDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDOperatorStatus_GET";

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
