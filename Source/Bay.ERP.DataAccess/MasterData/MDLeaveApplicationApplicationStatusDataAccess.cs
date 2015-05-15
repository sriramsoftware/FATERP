// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    internal sealed partial class MDLeaveApplicationApplicationStatusDataAccess : BaseDataAccess, IMDLeaveApplicationApplicationStatusDataAccess
    {
        #region Constructors

        public MDLeaveApplicationApplicationStatusDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDLeaveApplicationApplicationStatusEntity> CreateEntityBuilder<MDLeaveApplicationApplicationStatusEntity>()
        {
            return (new MDLeaveApplicationApplicationStatusBuilder()) as IEntityBuilder<MDLeaveApplicationApplicationStatusEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDLeaveApplicationApplicationStatusDataAccess.Add(MDLeaveApplicationApplicationStatusEntity mDLeaveApplicationApplicationStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDLeaveApplicationApplicationStatusEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDLeaveApplicationApplicationStatusEntity, option);
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

        private Int64 Add(MDLeaveApplicationApplicationStatusEntity mDLeaveApplicationApplicationStatusEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDLeaveApplicationApplicationStatus_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "LeaveApplicationApplicationStatusID");

                Database.AddInParameter(cmd, "@Name", DbType.String, mDLeaveApplicationApplicationStatusEntity.Name);	
                Database.AddInParameter(cmd, "@Description", DbType.String, mDLeaveApplicationApplicationStatusEntity.Description);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDLeaveApplicationApplicationStatusEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDLeaveApplicationApplicationStatusEntity already exists. Please specify another MDLeaveApplicationApplicationStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDLeaveApplicationApplicationStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDLeaveApplicationApplicationStatusEntity already exists. Please specify another MDLeaveApplicationApplicationStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDLeaveApplicationApplicationStatusEntity mDLeaveApplicationApplicationStatusEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDLeaveApplicationApplicationStatus_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "LeaveApplicationApplicationStatusID", db);

                db.AddInParameter(cmd, "@Name", DbType.String, mDLeaveApplicationApplicationStatusEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDLeaveApplicationApplicationStatusEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDLeaveApplicationApplicationStatusEntity.IsRemoved);

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

        IList<Int64> IMDLeaveApplicationApplicationStatusDataAccess.Add(IList<MDLeaveApplicationApplicationStatusEntity> mDLeaveApplicationApplicationStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDLeaveApplicationApplicationStatusEntity mDLeaveApplicationApplicationStatusEntity in mDLeaveApplicationApplicationStatusEntityList)
            {
                returnCode = (this as IMDLeaveApplicationApplicationStatusDataAccess).Add(mDLeaveApplicationApplicationStatusEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDLeaveApplicationApplicationStatusDataAccess.Update(MDLeaveApplicationApplicationStatusEntity mDLeaveApplicationApplicationStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDLeaveApplicationApplicationStatusEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDLeaveApplicationApplicationStatusEntity, filterExpression, option);
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

        private Int64 Update(MDLeaveApplicationApplicationStatusEntity mDLeaveApplicationApplicationStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDLeaveApplicationApplicationStatus_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@LeaveApplicationApplicationStatusID", DbType.Int64, mDLeaveApplicationApplicationStatusEntity.LeaveApplicationApplicationStatusID);
                Database.AddInParameter(cmd, "@Name", DbType.String, mDLeaveApplicationApplicationStatusEntity.Name);
                Database.AddInParameter(cmd, "@Description", DbType.String, mDLeaveApplicationApplicationStatusEntity.Description);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDLeaveApplicationApplicationStatusEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDLeaveApplicationApplicationStatusEntity already exists. Please specify another MDLeaveApplicationApplicationStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDLeaveApplicationApplicationStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDLeaveApplicationApplicationStatusEntity already exists. Please specify another MDLeaveApplicationApplicationStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDLeaveApplicationApplicationStatusEntity mDLeaveApplicationApplicationStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDLeaveApplicationApplicationStatus_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@LeaveApplicationApplicationStatusID", DbType.Int64, mDLeaveApplicationApplicationStatusEntity.LeaveApplicationApplicationStatusID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDLeaveApplicationApplicationStatusEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDLeaveApplicationApplicationStatusEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDLeaveApplicationApplicationStatusEntity.IsRemoved);

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

        IList<Int64> IMDLeaveApplicationApplicationStatusDataAccess.Update(IList<MDLeaveApplicationApplicationStatusEntity> mDLeaveApplicationApplicationStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDLeaveApplicationApplicationStatusEntity mDLeaveApplicationApplicationStatusEntity in mDLeaveApplicationApplicationStatusEntityList)
            {
                returnCode = (this as IMDLeaveApplicationApplicationStatusDataAccess).Update(mDLeaveApplicationApplicationStatusEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDLeaveApplicationApplicationStatusDataAccess.Delete(MDLeaveApplicationApplicationStatusEntity mDLeaveApplicationApplicationStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDLeaveApplicationApplicationStatusEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDLeaveApplicationApplicationStatusEntity, filterExpression, option);
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

        private Int64 Delete(MDLeaveApplicationApplicationStatusEntity mDLeaveApplicationApplicationStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDLeaveApplicationApplicationStatus_SET";

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
                                throw new ArgumentException("MDLeaveApplicationApplicationStatusEntity already exists. Please specify another MDLeaveApplicationApplicationStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDLeaveApplicationApplicationStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDLeaveApplicationApplicationStatusEntity already exists. Please specify another MDLeaveApplicationApplicationStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDLeaveApplicationApplicationStatusEntity mDLeaveApplicationApplicationStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDLeaveApplicationApplicationStatus_SET";

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

        IList<Int64> IMDLeaveApplicationApplicationStatusDataAccess.Delete(IList<MDLeaveApplicationApplicationStatusEntity> mDLeaveApplicationApplicationStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDLeaveApplicationApplicationStatusEntity mDLeaveApplicationApplicationStatusEntity in mDLeaveApplicationApplicationStatusEntityList)
            {
                returnCode = (this as IMDLeaveApplicationApplicationStatusDataAccess).Delete(mDLeaveApplicationApplicationStatusEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDLeaveApplicationApplicationStatusEntity> IMDLeaveApplicationApplicationStatusDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDLeaveApplicationApplicationStatus_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDLeaveApplicationApplicationStatusEntity> list = CreateEntityBuilder<MDLeaveApplicationApplicationStatusEntity>().BuildEntities(reader);

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

        DataTable IMDLeaveApplicationApplicationStatusDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDLeaveApplicationApplicationStatus_GET";

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
