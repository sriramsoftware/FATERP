// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Dec-2013, 03:14:39




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
    internal sealed partial class HRWorkingDayDataAccess : BaseDataAccess, IHRWorkingDayDataAccess
    {
        #region Constructors

        public HRWorkingDayDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HRWorkingDayEntity> CreateEntityBuilder<HRWorkingDayEntity>()
        {
            return (new HRWorkingDayBuilder()) as IEntityBuilder<HRWorkingDayEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHRWorkingDayDataAccess.Add(HRWorkingDayEntity hRWorkingDayEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hRWorkingDayEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hRWorkingDayEntity, option);
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

        private Int64 Add(HRWorkingDayEntity hRWorkingDayEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRWorkingDay_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "WorkingDayID");

                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hRWorkingDayEntity.FiscalYearID);	
                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hRWorkingDayEntity.SalarySessionID);	
                Database.AddInParameter(cmd, "@AttendanceLeaveAndHolidayCategoryID", DbType.Int64, hRWorkingDayEntity.AttendanceLeaveAndHolidayCategoryID);	
                Database.AddInParameter(cmd, "@Note", DbType.String, hRWorkingDayEntity.Note);	
                Database.AddInParameter(cmd, "@WorkingDay", DbType.DateTime, hRWorkingDayEntity.WorkingDay);	
                Database.AddInParameter(cmd, "@Year", DbType.Int32, hRWorkingDayEntity.Year);	
                Database.AddInParameter(cmd, "@Month", DbType.Int32, hRWorkingDayEntity.Month);	
                Database.AddInParameter(cmd, "@Day", DbType.Int32, hRWorkingDayEntity.Day);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hRWorkingDayEntity.Remarks);	
                Database.AddInParameter(cmd, "@Date", DbType.DateTime, hRWorkingDayEntity.Date);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hRWorkingDayEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HRWorkingDayEntity already exists. Please specify another HRWorkingDayEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRWorkingDayEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRWorkingDayEntity already exists. Please specify another HRWorkingDayEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HRWorkingDayEntity hRWorkingDayEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRWorkingDay_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "WorkingDayID", db);

                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hRWorkingDayEntity.FiscalYearID);
                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hRWorkingDayEntity.SalarySessionID);
                db.AddInParameter(cmd, "@AttendanceLeaveAndHolidayCategoryID", DbType.Int64, hRWorkingDayEntity.AttendanceLeaveAndHolidayCategoryID);
                db.AddInParameter(cmd, "@Note", DbType.String, hRWorkingDayEntity.Note);
                db.AddInParameter(cmd, "@WorkingDay", DbType.DateTime, hRWorkingDayEntity.WorkingDay);
                db.AddInParameter(cmd, "@Year", DbType.Int32, hRWorkingDayEntity.Year);
                db.AddInParameter(cmd, "@Month", DbType.Int32, hRWorkingDayEntity.Month);
                db.AddInParameter(cmd, "@Day", DbType.Int32, hRWorkingDayEntity.Day);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hRWorkingDayEntity.Remarks);
                db.AddInParameter(cmd, "@Date", DbType.DateTime, hRWorkingDayEntity.Date);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hRWorkingDayEntity.IsRemoved);

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

        IList<Int64> IHRWorkingDayDataAccess.Add(IList<HRWorkingDayEntity> hRWorkingDayEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HRWorkingDayEntity hRWorkingDayEntity in hRWorkingDayEntityList)
            {
                returnCode = (this as IHRWorkingDayDataAccess).Add(hRWorkingDayEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHRWorkingDayDataAccess.Update(HRWorkingDayEntity hRWorkingDayEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hRWorkingDayEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hRWorkingDayEntity, filterExpression, option);
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

        private Int64 Update(HRWorkingDayEntity hRWorkingDayEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRWorkingDay_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@WorkingDayID", DbType.Int64, hRWorkingDayEntity.WorkingDayID);
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hRWorkingDayEntity.FiscalYearID);
                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hRWorkingDayEntity.SalarySessionID);
                Database.AddInParameter(cmd, "@AttendanceLeaveAndHolidayCategoryID", DbType.Int64, hRWorkingDayEntity.AttendanceLeaveAndHolidayCategoryID);
                Database.AddInParameter(cmd, "@Note", DbType.String, hRWorkingDayEntity.Note);
                Database.AddInParameter(cmd, "@WorkingDay", DbType.DateTime, hRWorkingDayEntity.WorkingDay);
                Database.AddInParameter(cmd, "@Year", DbType.Int32, hRWorkingDayEntity.Year);
                Database.AddInParameter(cmd, "@Month", DbType.Int32, hRWorkingDayEntity.Month);
                Database.AddInParameter(cmd, "@Day", DbType.Int32, hRWorkingDayEntity.Day);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hRWorkingDayEntity.Remarks);
                Database.AddInParameter(cmd, "@Date", DbType.DateTime, hRWorkingDayEntity.Date);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hRWorkingDayEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HRWorkingDayEntity already exists. Please specify another HRWorkingDayEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRWorkingDayEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRWorkingDayEntity already exists. Please specify another HRWorkingDayEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HRWorkingDayEntity hRWorkingDayEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRWorkingDay_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@WorkingDayID", DbType.Int64, hRWorkingDayEntity.WorkingDayID);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hRWorkingDayEntity.FiscalYearID);
                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hRWorkingDayEntity.SalarySessionID);
                db.AddInParameter(cmd, "@AttendanceLeaveAndHolidayCategoryID", DbType.Int64, hRWorkingDayEntity.AttendanceLeaveAndHolidayCategoryID);
                db.AddInParameter(cmd, "@Note", DbType.String, hRWorkingDayEntity.Note);
                db.AddInParameter(cmd, "@WorkingDay", DbType.DateTime, hRWorkingDayEntity.WorkingDay);
                db.AddInParameter(cmd, "@Year", DbType.Int32, hRWorkingDayEntity.Year);
                db.AddInParameter(cmd, "@Month", DbType.Int32, hRWorkingDayEntity.Month);
                db.AddInParameter(cmd, "@Day", DbType.Int32, hRWorkingDayEntity.Day);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hRWorkingDayEntity.Remarks);
                db.AddInParameter(cmd, "@Date", DbType.DateTime, hRWorkingDayEntity.Date);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hRWorkingDayEntity.IsRemoved);

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

        IList<Int64> IHRWorkingDayDataAccess.Update(IList<HRWorkingDayEntity> hRWorkingDayEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HRWorkingDayEntity hRWorkingDayEntity in hRWorkingDayEntityList)
            {
                returnCode = (this as IHRWorkingDayDataAccess).Update(hRWorkingDayEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHRWorkingDayDataAccess.Delete(HRWorkingDayEntity hRWorkingDayEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hRWorkingDayEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hRWorkingDayEntity, filterExpression, option);
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

        private Int64 Delete(HRWorkingDayEntity hRWorkingDayEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRWorkingDay_SET";

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
                                throw new ArgumentException("HRWorkingDayEntity already exists. Please specify another HRWorkingDayEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRWorkingDayEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRWorkingDayEntity already exists. Please specify another HRWorkingDayEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HRWorkingDayEntity hRWorkingDayEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRWorkingDay_SET";

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

        IList<Int64> IHRWorkingDayDataAccess.Delete(IList<HRWorkingDayEntity> hRWorkingDayEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HRWorkingDayEntity hRWorkingDayEntity in hRWorkingDayEntityList)
            {
                returnCode = (this as IHRWorkingDayDataAccess).Delete(hRWorkingDayEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HRWorkingDayEntity> IHRWorkingDayDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HRWorkingDay_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HRWorkingDayEntity> list = CreateEntityBuilder<HRWorkingDayEntity>().BuildEntities(reader);

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

        DataTable IHRWorkingDayDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HRWorkingDay_GET";

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
