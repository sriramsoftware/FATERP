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
    internal sealed partial class HREmployeeSalaryBreakdownHistoryDataAccess : BaseDataAccess, IHREmployeeSalaryBreakdownHistoryDataAccess
    {
        #region Constructors

        public HREmployeeSalaryBreakdownHistoryDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeSalaryBreakdownHistoryEntity> CreateEntityBuilder<HREmployeeSalaryBreakdownHistoryEntity>()
        {
            return (new HREmployeeSalaryBreakdownHistoryBuilder()) as IEntityBuilder<HREmployeeSalaryBreakdownHistoryEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeSalaryBreakdownHistoryDataAccess.Add(HREmployeeSalaryBreakdownHistoryEntity hREmployeeSalaryBreakdownHistoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeSalaryBreakdownHistoryEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeSalaryBreakdownHistoryEntity, option);
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

        private Int64 Add(HREmployeeSalaryBreakdownHistoryEntity hREmployeeSalaryBreakdownHistoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryBreakdownHistory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);

                Database.AddInParameter(cmd, "@EmployeeSalaryBreakdownHistoryID", DbType.Int64, hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryBreakdownHistoryID);	
                Database.AddInParameter(cmd, "@EmployeeSalaryBreakDownID", DbType.Int64, hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryBreakDownID);	
                Database.AddInParameter(cmd, "@EmployeeSalaryInfoID", DbType.Int64, hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryInfoID);	
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryBreakdownHistoryEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@YearlyRate", DbType.Decimal, hREmployeeSalaryBreakdownHistoryEntity.YearlyRate);	
                Database.AddInParameter(cmd, "@MonthlyRate", DbType.Decimal, hREmployeeSalaryBreakdownHistoryEntity.MonthlyRate);	
                Database.AddInParameter(cmd, "@DailyRate", DbType.Decimal, hREmployeeSalaryBreakdownHistoryEntity.DailyRate);	
                Database.AddInParameter(cmd, "@OTHourlyRate", DbType.Decimal, hREmployeeSalaryBreakdownHistoryEntity.OTHourlyRate);	
                Database.AddInParameter(cmd, "@HoulryRate", DbType.Decimal, hREmployeeSalaryBreakdownHistoryEntity.HoulryRate);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hREmployeeSalaryBreakdownHistoryEntity.CreateDate);	
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, hREmployeeSalaryBreakdownHistoryEntity.CreatedByEmployeeID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeSalaryBreakdownHistoryEntity already exists. Please specify another HREmployeeSalaryBreakdownHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalaryBreakdownHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalaryBreakdownHistoryEntity already exists. Please specify another HREmployeeSalaryBreakdownHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeSalaryBreakdownHistoryEntity hREmployeeSalaryBreakdownHistoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryBreakdownHistory_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);

                db.AddInParameter(cmd, "@EmployeeSalaryBreakdownHistoryID", DbType.Int64, hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryBreakdownHistoryID);
                db.AddInParameter(cmd, "@EmployeeSalaryBreakDownID", DbType.Int64, hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryBreakDownID);
                db.AddInParameter(cmd, "@EmployeeSalaryInfoID", DbType.Int64, hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryInfoID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryBreakdownHistoryEntity.EmployeeID);
                db.AddInParameter(cmd, "@YearlyRate", DbType.Decimal, hREmployeeSalaryBreakdownHistoryEntity.YearlyRate);
                db.AddInParameter(cmd, "@MonthlyRate", DbType.Decimal, hREmployeeSalaryBreakdownHistoryEntity.MonthlyRate);
                db.AddInParameter(cmd, "@DailyRate", DbType.Decimal, hREmployeeSalaryBreakdownHistoryEntity.DailyRate);
                db.AddInParameter(cmd, "@OTHourlyRate", DbType.Decimal, hREmployeeSalaryBreakdownHistoryEntity.OTHourlyRate);
                db.AddInParameter(cmd, "@HoulryRate", DbType.Decimal, hREmployeeSalaryBreakdownHistoryEntity.HoulryRate);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hREmployeeSalaryBreakdownHistoryEntity.CreateDate);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, hREmployeeSalaryBreakdownHistoryEntity.CreatedByEmployeeID);

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

        IList<Int64> IHREmployeeSalaryBreakdownHistoryDataAccess.Add(IList<HREmployeeSalaryBreakdownHistoryEntity> hREmployeeSalaryBreakdownHistoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeSalaryBreakdownHistoryEntity hREmployeeSalaryBreakdownHistoryEntity in hREmployeeSalaryBreakdownHistoryEntityList)
            {
                returnCode = (this as IHREmployeeSalaryBreakdownHistoryDataAccess).Add(hREmployeeSalaryBreakdownHistoryEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeSalaryBreakdownHistoryDataAccess.Update(HREmployeeSalaryBreakdownHistoryEntity hREmployeeSalaryBreakdownHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeSalaryBreakdownHistoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeSalaryBreakdownHistoryEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeSalaryBreakdownHistoryEntity hREmployeeSalaryBreakdownHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryBreakdownHistory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeSalaryBreakdownHistoryID", DbType.Int64, hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryBreakdownHistoryID);
                Database.AddInParameter(cmd, "@EmployeeSalaryBreakDownID", DbType.Int64, hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryBreakDownID);
                Database.AddInParameter(cmd, "@EmployeeSalaryInfoID", DbType.Int64, hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryInfoID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryBreakdownHistoryEntity.EmployeeID);
                Database.AddInParameter(cmd, "@YearlyRate", DbType.Decimal, hREmployeeSalaryBreakdownHistoryEntity.YearlyRate);
                Database.AddInParameter(cmd, "@MonthlyRate", DbType.Decimal, hREmployeeSalaryBreakdownHistoryEntity.MonthlyRate);
                Database.AddInParameter(cmd, "@DailyRate", DbType.Decimal, hREmployeeSalaryBreakdownHistoryEntity.DailyRate);
                Database.AddInParameter(cmd, "@OTHourlyRate", DbType.Decimal, hREmployeeSalaryBreakdownHistoryEntity.OTHourlyRate);
                Database.AddInParameter(cmd, "@HoulryRate", DbType.Decimal, hREmployeeSalaryBreakdownHistoryEntity.HoulryRate);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hREmployeeSalaryBreakdownHistoryEntity.CreateDate);
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, hREmployeeSalaryBreakdownHistoryEntity.CreatedByEmployeeID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeSalaryBreakdownHistoryEntity already exists. Please specify another HREmployeeSalaryBreakdownHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalaryBreakdownHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalaryBreakdownHistoryEntity already exists. Please specify another HREmployeeSalaryBreakdownHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeSalaryBreakdownHistoryEntity hREmployeeSalaryBreakdownHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryBreakdownHistory_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeSalaryBreakdownHistoryID", DbType.Int64, hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryBreakdownHistoryID);
                db.AddInParameter(cmd, "@EmployeeSalaryBreakDownID", DbType.Int64, hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryBreakDownID);
                db.AddInParameter(cmd, "@EmployeeSalaryInfoID", DbType.Int64, hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryInfoID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryBreakdownHistoryEntity.EmployeeID);
                db.AddInParameter(cmd, "@YearlyRate", DbType.Decimal, hREmployeeSalaryBreakdownHistoryEntity.YearlyRate);
                db.AddInParameter(cmd, "@MonthlyRate", DbType.Decimal, hREmployeeSalaryBreakdownHistoryEntity.MonthlyRate);
                db.AddInParameter(cmd, "@DailyRate", DbType.Decimal, hREmployeeSalaryBreakdownHistoryEntity.DailyRate);
                db.AddInParameter(cmd, "@OTHourlyRate", DbType.Decimal, hREmployeeSalaryBreakdownHistoryEntity.OTHourlyRate);
                db.AddInParameter(cmd, "@HoulryRate", DbType.Decimal, hREmployeeSalaryBreakdownHistoryEntity.HoulryRate);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hREmployeeSalaryBreakdownHistoryEntity.CreateDate);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, hREmployeeSalaryBreakdownHistoryEntity.CreatedByEmployeeID);

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

        IList<Int64> IHREmployeeSalaryBreakdownHistoryDataAccess.Update(IList<HREmployeeSalaryBreakdownHistoryEntity> hREmployeeSalaryBreakdownHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeSalaryBreakdownHistoryEntity hREmployeeSalaryBreakdownHistoryEntity in hREmployeeSalaryBreakdownHistoryEntityList)
            {
                returnCode = (this as IHREmployeeSalaryBreakdownHistoryDataAccess).Update(hREmployeeSalaryBreakdownHistoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeSalaryBreakdownHistoryDataAccess.Delete(HREmployeeSalaryBreakdownHistoryEntity hREmployeeSalaryBreakdownHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeSalaryBreakdownHistoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeSalaryBreakdownHistoryEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeSalaryBreakdownHistoryEntity hREmployeeSalaryBreakdownHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryBreakdownHistory_SET";

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
                                throw new ArgumentException("HREmployeeSalaryBreakdownHistoryEntity already exists. Please specify another HREmployeeSalaryBreakdownHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalaryBreakdownHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalaryBreakdownHistoryEntity already exists. Please specify another HREmployeeSalaryBreakdownHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeSalaryBreakdownHistoryEntity hREmployeeSalaryBreakdownHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryBreakdownHistory_SET";

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

        IList<Int64> IHREmployeeSalaryBreakdownHistoryDataAccess.Delete(IList<HREmployeeSalaryBreakdownHistoryEntity> hREmployeeSalaryBreakdownHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeSalaryBreakdownHistoryEntity hREmployeeSalaryBreakdownHistoryEntity in hREmployeeSalaryBreakdownHistoryEntityList)
            {
                returnCode = (this as IHREmployeeSalaryBreakdownHistoryDataAccess).Delete(hREmployeeSalaryBreakdownHistoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeSalaryBreakdownHistoryEntity> IHREmployeeSalaryBreakdownHistoryDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeSalaryBreakdownHistory_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeSalaryBreakdownHistoryEntity> list = CreateEntityBuilder<HREmployeeSalaryBreakdownHistoryEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeSalaryBreakdownHistoryDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeSalaryBreakdownHistory_GET";

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
