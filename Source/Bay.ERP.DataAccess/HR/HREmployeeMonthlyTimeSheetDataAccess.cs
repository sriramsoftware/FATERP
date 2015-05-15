// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




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
    internal sealed partial class HREmployeeMonthlyTimeSheetDataAccess : BaseDataAccess, IHREmployeeMonthlyTimeSheetDataAccess
    {
        #region Constructors

        public HREmployeeMonthlyTimeSheetDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeMonthlyTimeSheetEntity> CreateEntityBuilder<HREmployeeMonthlyTimeSheetEntity>()
        {
            return (new HREmployeeMonthlyTimeSheetBuilder()) as IEntityBuilder<HREmployeeMonthlyTimeSheetEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeMonthlyTimeSheetDataAccess.Add(HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeMonthlyTimeSheetEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeMonthlyTimeSheetEntity, option);
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

        private Int64 Add(HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeMonthlyTimeSheet_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeMonthlyTimeSheetID");

                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeMonthlyTimeSheetEntity.FiscalYearID);	
                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeMonthlyTimeSheetEntity.SalarySessionID);	
                Database.AddInParameter(cmd, "@AttendanceLeaveAndHolidayCategoryID", DbType.Int64, hREmployeeMonthlyTimeSheetEntity.AttendanceLeaveAndHolidayCategoryID);	
                Database.AddInParameter(cmd, "@Note", DbType.String, hREmployeeMonthlyTimeSheetEntity.Note);	
                Database.AddInParameter(cmd, "@WorkingDay", DbType.DateTime, hREmployeeMonthlyTimeSheetEntity.WorkingDay);	
                Database.AddInParameter(cmd, "@Year", DbType.Int32, hREmployeeMonthlyTimeSheetEntity.Year);	
                Database.AddInParameter(cmd, "@Month", DbType.Int32, hREmployeeMonthlyTimeSheetEntity.Month);	
                Database.AddInParameter(cmd, "@Day", DbType.Int32, hREmployeeMonthlyTimeSheetEntity.Day);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeMonthlyTimeSheetEntity.Remarks);	
                Database.AddInParameter(cmd, "@Date", DbType.DateTime, hREmployeeMonthlyTimeSheetEntity.Date);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hREmployeeMonthlyTimeSheetEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeMonthlyTimeSheetEntity already exists. Please specify another HREmployeeMonthlyTimeSheetEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeMonthlyTimeSheetEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeMonthlyTimeSheetEntity already exists. Please specify another HREmployeeMonthlyTimeSheetEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeMonthlyTimeSheet_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeMonthlyTimeSheetID", db);

                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeMonthlyTimeSheetEntity.FiscalYearID);
                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeMonthlyTimeSheetEntity.SalarySessionID);
                db.AddInParameter(cmd, "@AttendanceLeaveAndHolidayCategoryID", DbType.Int64, hREmployeeMonthlyTimeSheetEntity.AttendanceLeaveAndHolidayCategoryID);
                db.AddInParameter(cmd, "@Note", DbType.String, hREmployeeMonthlyTimeSheetEntity.Note);
                db.AddInParameter(cmd, "@WorkingDay", DbType.DateTime, hREmployeeMonthlyTimeSheetEntity.WorkingDay);
                db.AddInParameter(cmd, "@Year", DbType.Int32, hREmployeeMonthlyTimeSheetEntity.Year);
                db.AddInParameter(cmd, "@Month", DbType.Int32, hREmployeeMonthlyTimeSheetEntity.Month);
                db.AddInParameter(cmd, "@Day", DbType.Int32, hREmployeeMonthlyTimeSheetEntity.Day);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeMonthlyTimeSheetEntity.Remarks);
                db.AddInParameter(cmd, "@Date", DbType.DateTime, hREmployeeMonthlyTimeSheetEntity.Date);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hREmployeeMonthlyTimeSheetEntity.IsRemoved);

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

        IList<Int64> IHREmployeeMonthlyTimeSheetDataAccess.Add(IList<HREmployeeMonthlyTimeSheetEntity> hREmployeeMonthlyTimeSheetEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity in hREmployeeMonthlyTimeSheetEntityList)
            {
                returnCode = (this as IHREmployeeMonthlyTimeSheetDataAccess).Add(hREmployeeMonthlyTimeSheetEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeMonthlyTimeSheetDataAccess.Update(HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeMonthlyTimeSheetEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeMonthlyTimeSheetEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeMonthlyTimeSheet_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeMonthlyTimeSheetID", DbType.Int64, hREmployeeMonthlyTimeSheetEntity.EmployeeMonthlyTimeSheetID);
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeMonthlyTimeSheetEntity.FiscalYearID);
                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeMonthlyTimeSheetEntity.SalarySessionID);
                Database.AddInParameter(cmd, "@AttendanceLeaveAndHolidayCategoryID", DbType.Int64, hREmployeeMonthlyTimeSheetEntity.AttendanceLeaveAndHolidayCategoryID);
                Database.AddInParameter(cmd, "@Note", DbType.String, hREmployeeMonthlyTimeSheetEntity.Note);
                Database.AddInParameter(cmd, "@WorkingDay", DbType.DateTime, hREmployeeMonthlyTimeSheetEntity.WorkingDay);
                Database.AddInParameter(cmd, "@Year", DbType.Int32, hREmployeeMonthlyTimeSheetEntity.Year);
                Database.AddInParameter(cmd, "@Month", DbType.Int32, hREmployeeMonthlyTimeSheetEntity.Month);
                Database.AddInParameter(cmd, "@Day", DbType.Int32, hREmployeeMonthlyTimeSheetEntity.Day);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeMonthlyTimeSheetEntity.Remarks);
                Database.AddInParameter(cmd, "@Date", DbType.DateTime, hREmployeeMonthlyTimeSheetEntity.Date);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hREmployeeMonthlyTimeSheetEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeMonthlyTimeSheetEntity already exists. Please specify another HREmployeeMonthlyTimeSheetEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeMonthlyTimeSheetEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeMonthlyTimeSheetEntity already exists. Please specify another HREmployeeMonthlyTimeSheetEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeMonthlyTimeSheet_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeMonthlyTimeSheetID", DbType.Int64, hREmployeeMonthlyTimeSheetEntity.EmployeeMonthlyTimeSheetID);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeMonthlyTimeSheetEntity.FiscalYearID);
                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeMonthlyTimeSheetEntity.SalarySessionID);
                db.AddInParameter(cmd, "@AttendanceLeaveAndHolidayCategoryID", DbType.Int64, hREmployeeMonthlyTimeSheetEntity.AttendanceLeaveAndHolidayCategoryID);
                db.AddInParameter(cmd, "@Note", DbType.String, hREmployeeMonthlyTimeSheetEntity.Note);
                db.AddInParameter(cmd, "@WorkingDay", DbType.DateTime, hREmployeeMonthlyTimeSheetEntity.WorkingDay);
                db.AddInParameter(cmd, "@Year", DbType.Int32, hREmployeeMonthlyTimeSheetEntity.Year);
                db.AddInParameter(cmd, "@Month", DbType.Int32, hREmployeeMonthlyTimeSheetEntity.Month);
                db.AddInParameter(cmd, "@Day", DbType.Int32, hREmployeeMonthlyTimeSheetEntity.Day);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeMonthlyTimeSheetEntity.Remarks);
                db.AddInParameter(cmd, "@Date", DbType.DateTime, hREmployeeMonthlyTimeSheetEntity.Date);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hREmployeeMonthlyTimeSheetEntity.IsRemoved);

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

        IList<Int64> IHREmployeeMonthlyTimeSheetDataAccess.Update(IList<HREmployeeMonthlyTimeSheetEntity> hREmployeeMonthlyTimeSheetEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity in hREmployeeMonthlyTimeSheetEntityList)
            {
                returnCode = (this as IHREmployeeMonthlyTimeSheetDataAccess).Update(hREmployeeMonthlyTimeSheetEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeMonthlyTimeSheetDataAccess.Delete(HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeMonthlyTimeSheetEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeMonthlyTimeSheetEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeMonthlyTimeSheet_SET";

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
                                throw new ArgumentException("HREmployeeMonthlyTimeSheetEntity already exists. Please specify another HREmployeeMonthlyTimeSheetEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeMonthlyTimeSheetEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeMonthlyTimeSheetEntity already exists. Please specify another HREmployeeMonthlyTimeSheetEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeMonthlyTimeSheet_SET";

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

        IList<Int64> IHREmployeeMonthlyTimeSheetDataAccess.Delete(IList<HREmployeeMonthlyTimeSheetEntity> hREmployeeMonthlyTimeSheetEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity in hREmployeeMonthlyTimeSheetEntityList)
            {
                returnCode = (this as IHREmployeeMonthlyTimeSheetDataAccess).Delete(hREmployeeMonthlyTimeSheetEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeMonthlyTimeSheetEntity> IHREmployeeMonthlyTimeSheetDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeMonthlyTimeSheet_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeMonthlyTimeSheetEntity> list = CreateEntityBuilder<HREmployeeMonthlyTimeSheetEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeMonthlyTimeSheetDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeMonthlyTimeSheet_GET";

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
