// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Nov-2013, 09:51:38




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
    internal sealed partial class MDLeavePolicyDataAccess : BaseDataAccess, IMDLeavePolicyDataAccess
    {
        #region Constructors

        public MDLeavePolicyDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDLeavePolicyEntity> CreateEntityBuilder<MDLeavePolicyEntity>()
        {
            return (new MDLeavePolicyBuilder()) as IEntityBuilder<MDLeavePolicyEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDLeavePolicyDataAccess.Add(MDLeavePolicyEntity mDLeavePolicyEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDLeavePolicyEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDLeavePolicyEntity, option);
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

        private Int64 Add(MDLeavePolicyEntity mDLeavePolicyEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDLeavePolicy_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "LeavePolicyID");

                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, mDLeavePolicyEntity.FiscalYearID);
                Database.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, mDLeavePolicyEntity.EmployeeJobTypeID);
                Database.AddInParameter(cmd, "@LeaveCategoryID", DbType.Int64, mDLeavePolicyEntity.LeaveCategoryID);
                Database.AddInParameter(cmd, "@LeaveInDays", DbType.Decimal, mDLeavePolicyEntity.LeaveInDays);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, mDLeavePolicyEntity.Remarks);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDLeavePolicyEntity.IsRemoved);
                Database.AddInParameter(cmd, "@ExtraField1", DbType.String, mDLeavePolicyEntity.ExtraField1);
                Database.AddInParameter(cmd, "@ExtraField2", DbType.String, mDLeavePolicyEntity.ExtraField2);


				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDLeavePolicyEntity already exists. Please specify another MDLeavePolicyEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDLeavePolicyEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDLeavePolicyEntity already exists. Please specify another MDLeavePolicyEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDLeavePolicyEntity mDLeavePolicyEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDLeavePolicy_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "LeavePolicyID", db);

                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, mDLeavePolicyEntity.FiscalYearID);
                db.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, mDLeavePolicyEntity.EmployeeJobTypeID);
                db.AddInParameter(cmd, "@LeaveCategoryID", DbType.Int64, mDLeavePolicyEntity.LeaveCategoryID);
                db.AddInParameter(cmd, "@LeaveInDays", DbType.Decimal, mDLeavePolicyEntity.LeaveInDays);
                db.AddInParameter(cmd, "@Remarks", DbType.String, mDLeavePolicyEntity.Remarks);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDLeavePolicyEntity.IsRemoved);
                db.AddInParameter(cmd, "@ExtraField1", DbType.String, mDLeavePolicyEntity.ExtraField1);
                db.AddInParameter(cmd, "@ExtraField2", DbType.String, mDLeavePolicyEntity.ExtraField2);

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

        IList<Int64> IMDLeavePolicyDataAccess.Add(IList<MDLeavePolicyEntity> mDLeavePolicyEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDLeavePolicyEntity mDLeavePolicyEntity in mDLeavePolicyEntityList)
            {
                returnCode = (this as IMDLeavePolicyDataAccess).Add(mDLeavePolicyEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDLeavePolicyDataAccess.Update(MDLeavePolicyEntity mDLeavePolicyEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDLeavePolicyEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDLeavePolicyEntity, filterExpression, option);
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

        private Int64 Update(MDLeavePolicyEntity mDLeavePolicyEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDLeavePolicy_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@LeavePolicyID", DbType.Int64, mDLeavePolicyEntity.LeavePolicyID);
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, mDLeavePolicyEntity.FiscalYearID);
                Database.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, mDLeavePolicyEntity.EmployeeJobTypeID);
                Database.AddInParameter(cmd, "@LeaveCategoryID", DbType.Int64, mDLeavePolicyEntity.LeaveCategoryID);
                Database.AddInParameter(cmd, "@LeaveInDays", DbType.Decimal, mDLeavePolicyEntity.LeaveInDays);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, mDLeavePolicyEntity.Remarks);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDLeavePolicyEntity.IsRemoved);
                Database.AddInParameter(cmd, "@ExtraField1", DbType.String, mDLeavePolicyEntity.ExtraField1);
                Database.AddInParameter(cmd, "@ExtraField2", DbType.String, mDLeavePolicyEntity.ExtraField2);                

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDLeavePolicyEntity already exists. Please specify another MDLeavePolicyEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDLeavePolicyEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDLeavePolicyEntity already exists. Please specify another MDLeavePolicyEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDLeavePolicyEntity mDLeavePolicyEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDLeavePolicy_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@LeavePolicyID", DbType.Int64, mDLeavePolicyEntity.LeavePolicyID);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, mDLeavePolicyEntity.FiscalYearID);
                db.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, mDLeavePolicyEntity.EmployeeJobTypeID);
                db.AddInParameter(cmd, "@LeaveCategoryID", DbType.Int64, mDLeavePolicyEntity.LeaveCategoryID);
                db.AddInParameter(cmd, "@LeaveInDays", DbType.Decimal, mDLeavePolicyEntity.LeaveInDays);
                db.AddInParameter(cmd, "@Remarks", DbType.String, mDLeavePolicyEntity.Remarks);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDLeavePolicyEntity.IsRemoved);
                db.AddInParameter(cmd, "@ExtraField1", DbType.String, mDLeavePolicyEntity.ExtraField1);
                db.AddInParameter(cmd, "@ExtraField2", DbType.String, mDLeavePolicyEntity.ExtraField2);

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

        IList<Int64> IMDLeavePolicyDataAccess.Update(IList<MDLeavePolicyEntity> mDLeavePolicyEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDLeavePolicyEntity mDLeavePolicyEntity in mDLeavePolicyEntityList)
            {
                returnCode = (this as IMDLeavePolicyDataAccess).Update(mDLeavePolicyEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDLeavePolicyDataAccess.Delete(MDLeavePolicyEntity mDLeavePolicyEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDLeavePolicyEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDLeavePolicyEntity, filterExpression, option);
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

        private Int64 Delete(MDLeavePolicyEntity mDLeavePolicyEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDLeavePolicy_SET";

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
                                throw new ArgumentException("MDLeavePolicyEntity already exists. Please specify another MDLeavePolicyEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDLeavePolicyEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDLeavePolicyEntity already exists. Please specify another MDLeavePolicyEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDLeavePolicyEntity mDLeavePolicyEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDLeavePolicy_SET";

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

        IList<Int64> IMDLeavePolicyDataAccess.Delete(IList<MDLeavePolicyEntity> mDLeavePolicyEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDLeavePolicyEntity mDLeavePolicyEntity in mDLeavePolicyEntityList)
            {
                returnCode = (this as IMDLeavePolicyDataAccess).Delete(mDLeavePolicyEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDLeavePolicyEntity> IMDLeavePolicyDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDLeavePolicy_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDLeavePolicyEntity> list = CreateEntityBuilder<MDLeavePolicyEntity>().BuildEntities(reader);

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

        DataTable IMDLeavePolicyDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDLeavePolicy_GET";

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
