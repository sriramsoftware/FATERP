// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Jan-2014, 06:33:35




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
    internal sealed partial class HREmployeeLeaveApplicationDataAccess : BaseDataAccess, IHREmployeeLeaveApplicationDataAccess
    {
        #region Constructors

        public HREmployeeLeaveApplicationDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeLeaveApplicationEntity> CreateEntityBuilder<HREmployeeLeaveApplicationEntity>()
        {
            return (new HREmployeeLeaveApplicationBuilder()) as IEntityBuilder<HREmployeeLeaveApplicationEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeLeaveApplicationDataAccess.Add(HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeLeaveApplicationEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeLeaveApplicationEntity, option);
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

        private Int64 Add(HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeLeaveApplication_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeLeaveApplicationID");

                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeLeaveApplicationEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@ApplicationDate", DbType.DateTime, hREmployeeLeaveApplicationEntity.ApplicationDate);	
                Database.AddInParameter(cmd, "@RequestStartDate", DbType.DateTime, hREmployeeLeaveApplicationEntity.RequestStartDate);	
                Database.AddInParameter(cmd, "@RequestEndDate", DbType.DateTime, hREmployeeLeaveApplicationEntity.RequestEndDate);	
                Database.AddInParameter(cmd, "@TotalLeaveDays", DbType.Decimal, hREmployeeLeaveApplicationEntity.TotalLeaveDays);	
                Database.AddInParameter(cmd, "@Description", DbType.String, hREmployeeLeaveApplicationEntity.Description);	
                Database.AddInParameter(cmd, "@BackupEmployeeID", DbType.Int64, hREmployeeLeaveApplicationEntity.BackupEmployeeID);	
                Database.AddInParameter(cmd, "@LeaveApplicationApplicationStatusID", DbType.Int64, hREmployeeLeaveApplicationEntity.LeaveApplicationApplicationStatusID);	
                Database.AddInParameter(cmd, "@LeaveCategoryID", DbType.Int64, hREmployeeLeaveApplicationEntity.LeaveCategoryID);	
                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeLeaveApplicationEntity.SalarySessionID);
                Database.AddInParameter(cmd, "@LeaveLocation", DbType.String, hREmployeeLeaveApplicationEntity.LeaveLocation);
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeLeaveApplicationEntity.FiscalYearID);

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeLeaveApplicationEntity already exists. Please specify another HREmployeeLeaveApplicationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeLeaveApplicationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeLeaveApplicationEntity already exists. Please specify another HREmployeeLeaveApplicationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeLeaveApplication_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeLeaveApplicationID", db);

                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeLeaveApplicationEntity.EmployeeID);
                db.AddInParameter(cmd, "@ApplicationDate", DbType.DateTime, hREmployeeLeaveApplicationEntity.ApplicationDate);
                db.AddInParameter(cmd, "@RequestStartDate", DbType.DateTime, hREmployeeLeaveApplicationEntity.RequestStartDate);
                db.AddInParameter(cmd, "@RequestEndDate", DbType.DateTime, hREmployeeLeaveApplicationEntity.RequestEndDate);
                db.AddInParameter(cmd, "@TotalLeaveDays", DbType.Decimal, hREmployeeLeaveApplicationEntity.TotalLeaveDays);
                db.AddInParameter(cmd, "@Description", DbType.String, hREmployeeLeaveApplicationEntity.Description);
                db.AddInParameter(cmd, "@BackupEmployeeID", DbType.Int64, hREmployeeLeaveApplicationEntity.BackupEmployeeID);
                db.AddInParameter(cmd, "@LeaveApplicationApplicationStatusID", DbType.Int64, hREmployeeLeaveApplicationEntity.LeaveApplicationApplicationStatusID);
                db.AddInParameter(cmd, "@LeaveCategoryID", DbType.Int64, hREmployeeLeaveApplicationEntity.LeaveCategoryID);
                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeLeaveApplicationEntity.SalarySessionID);
                db.AddInParameter(cmd, "@LeaveLocation", DbType.String, hREmployeeLeaveApplicationEntity.LeaveLocation);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeLeaveApplicationEntity.FiscalYearID);

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

        IList<Int64> IHREmployeeLeaveApplicationDataAccess.Add(IList<HREmployeeLeaveApplicationEntity> hREmployeeLeaveApplicationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity in hREmployeeLeaveApplicationEntityList)
            {
                returnCode = (this as IHREmployeeLeaveApplicationDataAccess).Add(hREmployeeLeaveApplicationEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeLeaveApplicationDataAccess.Update(HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeLeaveApplicationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeLeaveApplicationEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeLeaveApplication_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeLeaveApplicationID", DbType.Int64, hREmployeeLeaveApplicationEntity.EmployeeLeaveApplicationID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeLeaveApplicationEntity.EmployeeID);
                Database.AddInParameter(cmd, "@ApplicationDate", DbType.DateTime, hREmployeeLeaveApplicationEntity.ApplicationDate);
                Database.AddInParameter(cmd, "@RequestStartDate", DbType.DateTime, hREmployeeLeaveApplicationEntity.RequestStartDate);
                Database.AddInParameter(cmd, "@RequestEndDate", DbType.DateTime, hREmployeeLeaveApplicationEntity.RequestEndDate);
                Database.AddInParameter(cmd, "@TotalLeaveDays", DbType.Decimal, hREmployeeLeaveApplicationEntity.TotalLeaveDays);
                Database.AddInParameter(cmd, "@Description", DbType.String, hREmployeeLeaveApplicationEntity.Description);
                Database.AddInParameter(cmd, "@BackupEmployeeID", DbType.Int64, hREmployeeLeaveApplicationEntity.BackupEmployeeID);
                Database.AddInParameter(cmd, "@LeaveApplicationApplicationStatusID", DbType.Int64, hREmployeeLeaveApplicationEntity.LeaveApplicationApplicationStatusID);
                Database.AddInParameter(cmd, "@LeaveCategoryID", DbType.Int64, hREmployeeLeaveApplicationEntity.LeaveCategoryID);
                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeLeaveApplicationEntity.SalarySessionID);
                Database.AddInParameter(cmd, "@LeaveLocation", DbType.String, hREmployeeLeaveApplicationEntity.LeaveLocation);
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeLeaveApplicationEntity.FiscalYearID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeLeaveApplicationEntity already exists. Please specify another HREmployeeLeaveApplicationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeLeaveApplicationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeLeaveApplicationEntity already exists. Please specify another HREmployeeLeaveApplicationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeLeaveApplication_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeLeaveApplicationID", DbType.Int64, hREmployeeLeaveApplicationEntity.EmployeeLeaveApplicationID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeLeaveApplicationEntity.EmployeeID);
                db.AddInParameter(cmd, "@ApplicationDate", DbType.DateTime, hREmployeeLeaveApplicationEntity.ApplicationDate);
                db.AddInParameter(cmd, "@RequestStartDate", DbType.DateTime, hREmployeeLeaveApplicationEntity.RequestStartDate);
                db.AddInParameter(cmd, "@RequestEndDate", DbType.DateTime, hREmployeeLeaveApplicationEntity.RequestEndDate);
                db.AddInParameter(cmd, "@TotalLeaveDays", DbType.Decimal, hREmployeeLeaveApplicationEntity.TotalLeaveDays);
                db.AddInParameter(cmd, "@Description", DbType.String, hREmployeeLeaveApplicationEntity.Description);
                db.AddInParameter(cmd, "@BackupEmployeeID", DbType.Int64, hREmployeeLeaveApplicationEntity.BackupEmployeeID);
                db.AddInParameter(cmd, "@LeaveApplicationApplicationStatusID", DbType.Int64, hREmployeeLeaveApplicationEntity.LeaveApplicationApplicationStatusID);
                db.AddInParameter(cmd, "@LeaveCategoryID", DbType.Int64, hREmployeeLeaveApplicationEntity.LeaveCategoryID);
                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeLeaveApplicationEntity.SalarySessionID);
                db.AddInParameter(cmd, "@LeaveLocation", DbType.String, hREmployeeLeaveApplicationEntity.LeaveLocation);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeLeaveApplicationEntity.FiscalYearID);

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

        IList<Int64> IHREmployeeLeaveApplicationDataAccess.Update(IList<HREmployeeLeaveApplicationEntity> hREmployeeLeaveApplicationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity in hREmployeeLeaveApplicationEntityList)
            {
                returnCode = (this as IHREmployeeLeaveApplicationDataAccess).Update(hREmployeeLeaveApplicationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeLeaveApplicationDataAccess.Delete(HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeLeaveApplicationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeLeaveApplicationEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeLeaveApplication_SET";

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
                                throw new ArgumentException("HREmployeeLeaveApplicationEntity already exists. Please specify another HREmployeeLeaveApplicationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeLeaveApplicationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeLeaveApplicationEntity already exists. Please specify another HREmployeeLeaveApplicationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeLeaveApplication_SET";

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

        IList<Int64> IHREmployeeLeaveApplicationDataAccess.Delete(IList<HREmployeeLeaveApplicationEntity> hREmployeeLeaveApplicationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity in hREmployeeLeaveApplicationEntityList)
            {
                returnCode = (this as IHREmployeeLeaveApplicationDataAccess).Delete(hREmployeeLeaveApplicationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeLeaveApplicationEntity> IHREmployeeLeaveApplicationDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeLeaveApplication_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeLeaveApplicationEntity> list = CreateEntityBuilder<HREmployeeLeaveApplicationEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeLeaveApplicationDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeLeaveApplication_GET";

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
