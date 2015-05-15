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
    internal sealed partial class MDSalarySessionDataAccess : BaseDataAccess, IMDSalarySessionDataAccess
    {
        #region Constructors

        public MDSalarySessionDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDSalarySessionEntity> CreateEntityBuilder<MDSalarySessionEntity>()
        {
            return (new MDSalarySessionBuilder()) as IEntityBuilder<MDSalarySessionEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDSalarySessionDataAccess.Add(MDSalarySessionEntity mDSalarySessionEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDSalarySessionEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDSalarySessionEntity, option);
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

        private Int64 Add(MDSalarySessionEntity mDSalarySessionEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDSalarySession_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "SalarySessionID");

                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, mDSalarySessionEntity.FiscalYearID);	
                Database.AddInParameter(cmd, "@Name", DbType.String, mDSalarySessionEntity.Name);	
                Database.AddInParameter(cmd, "@SessionStartDate", DbType.DateTime, mDSalarySessionEntity.SessionStartDate);	
                Database.AddInParameter(cmd, "@SessionEndDate", DbType.DateTime, mDSalarySessionEntity.SessionEndDate);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, mDSalarySessionEntity.Remarks);	
                Database.AddInParameter(cmd, "@SalarySessionStatusID", DbType.Int64, mDSalarySessionEntity.SalarySessionStatusID);	
                Database.AddInParameter(cmd, "@IsCurrentSession", DbType.Boolean, mDSalarySessionEntity.IsCurrentSession);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDSalarySessionEntity already exists. Please specify another MDSalarySessionEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDSalarySessionEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDSalarySessionEntity already exists. Please specify another MDSalarySessionEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDSalarySessionEntity mDSalarySessionEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDSalarySession_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "SalarySessionID", db);

                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, mDSalarySessionEntity.FiscalYearID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDSalarySessionEntity.Name);
                db.AddInParameter(cmd, "@SessionStartDate", DbType.DateTime, mDSalarySessionEntity.SessionStartDate);
                db.AddInParameter(cmd, "@SessionEndDate", DbType.DateTime, mDSalarySessionEntity.SessionEndDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, mDSalarySessionEntity.Remarks);
                db.AddInParameter(cmd, "@SalarySessionStatusID", DbType.Int64, mDSalarySessionEntity.SalarySessionStatusID);
                db.AddInParameter(cmd, "@IsCurrentSession", DbType.Boolean, mDSalarySessionEntity.IsCurrentSession);

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

        IList<Int64> IMDSalarySessionDataAccess.Add(IList<MDSalarySessionEntity> mDSalarySessionEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDSalarySessionEntity mDSalarySessionEntity in mDSalarySessionEntityList)
            {
                returnCode = (this as IMDSalarySessionDataAccess).Add(mDSalarySessionEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDSalarySessionDataAccess.Update(MDSalarySessionEntity mDSalarySessionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDSalarySessionEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDSalarySessionEntity, filterExpression, option);
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

        private Int64 Update(MDSalarySessionEntity mDSalarySessionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDSalarySession_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, mDSalarySessionEntity.SalarySessionID);
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, mDSalarySessionEntity.FiscalYearID);
                Database.AddInParameter(cmd, "@Name", DbType.String, mDSalarySessionEntity.Name);
                Database.AddInParameter(cmd, "@SessionStartDate", DbType.DateTime, mDSalarySessionEntity.SessionStartDate);
                Database.AddInParameter(cmd, "@SessionEndDate", DbType.DateTime, mDSalarySessionEntity.SessionEndDate);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, mDSalarySessionEntity.Remarks);
                Database.AddInParameter(cmd, "@SalarySessionStatusID", DbType.Int64, mDSalarySessionEntity.SalarySessionStatusID);
                Database.AddInParameter(cmd, "@IsCurrentSession", DbType.Boolean, mDSalarySessionEntity.IsCurrentSession);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDSalarySessionEntity already exists. Please specify another MDSalarySessionEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDSalarySessionEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDSalarySessionEntity already exists. Please specify another MDSalarySessionEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDSalarySessionEntity mDSalarySessionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDSalarySession_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, mDSalarySessionEntity.SalarySessionID);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, mDSalarySessionEntity.FiscalYearID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDSalarySessionEntity.Name);
                db.AddInParameter(cmd, "@SessionStartDate", DbType.DateTime, mDSalarySessionEntity.SessionStartDate);
                db.AddInParameter(cmd, "@SessionEndDate", DbType.DateTime, mDSalarySessionEntity.SessionEndDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, mDSalarySessionEntity.Remarks);
                db.AddInParameter(cmd, "@SalarySessionStatusID", DbType.Int64, mDSalarySessionEntity.SalarySessionStatusID);
                db.AddInParameter(cmd, "@IsCurrentSession", DbType.Boolean, mDSalarySessionEntity.IsCurrentSession);

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

        IList<Int64> IMDSalarySessionDataAccess.Update(IList<MDSalarySessionEntity> mDSalarySessionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDSalarySessionEntity mDSalarySessionEntity in mDSalarySessionEntityList)
            {
                returnCode = (this as IMDSalarySessionDataAccess).Update(mDSalarySessionEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDSalarySessionDataAccess.Delete(MDSalarySessionEntity mDSalarySessionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDSalarySessionEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDSalarySessionEntity, filterExpression, option);
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

        private Int64 Delete(MDSalarySessionEntity mDSalarySessionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDSalarySession_SET";

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
                                throw new ArgumentException("MDSalarySessionEntity already exists. Please specify another MDSalarySessionEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDSalarySessionEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDSalarySessionEntity already exists. Please specify another MDSalarySessionEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDSalarySessionEntity mDSalarySessionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDSalarySession_SET";

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

        IList<Int64> IMDSalarySessionDataAccess.Delete(IList<MDSalarySessionEntity> mDSalarySessionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDSalarySessionEntity mDSalarySessionEntity in mDSalarySessionEntityList)
            {
                returnCode = (this as IMDSalarySessionDataAccess).Delete(mDSalarySessionEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDSalarySessionEntity> IMDSalarySessionDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDSalarySession_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDSalarySessionEntity> list = CreateEntityBuilder<MDSalarySessionEntity>().BuildEntities(reader);

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

        DataTable IMDSalarySessionDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDSalarySession_GET";

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
