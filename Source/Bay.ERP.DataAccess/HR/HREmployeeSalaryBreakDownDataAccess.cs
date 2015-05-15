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
    internal sealed partial class HREmployeeSalaryBreakDownDataAccess : BaseDataAccess, IHREmployeeSalaryBreakDownDataAccess
    {
        #region Constructors

        public HREmployeeSalaryBreakDownDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeSalaryBreakDownEntity> CreateEntityBuilder<HREmployeeSalaryBreakDownEntity>()
        {
            return (new HREmployeeSalaryBreakDownBuilder()) as IEntityBuilder<HREmployeeSalaryBreakDownEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeSalaryBreakDownDataAccess.Add(HREmployeeSalaryBreakDownEntity hREmployeeSalaryBreakDownEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeSalaryBreakDownEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeSalaryBreakDownEntity, option);
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

        private Int64 Add(HREmployeeSalaryBreakDownEntity hREmployeeSalaryBreakDownEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryBreakDown_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeSalaryBreakDownID");

                Database.AddInParameter(cmd, "@EmployeeSalaryInfoID", DbType.Int64, hREmployeeSalaryBreakDownEntity.EmployeeSalaryInfoID);	
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryBreakDownEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@YearlyRate", DbType.Decimal, hREmployeeSalaryBreakDownEntity.YearlyRate);	
                Database.AddInParameter(cmd, "@MonthlyRate", DbType.Decimal, hREmployeeSalaryBreakDownEntity.MonthlyRate);	
                Database.AddInParameter(cmd, "@DailyRate", DbType.Decimal, hREmployeeSalaryBreakDownEntity.DailyRate);	
                Database.AddInParameter(cmd, "@OTHourlyRate", DbType.Decimal, hREmployeeSalaryBreakDownEntity.OTHourlyRate);	
                Database.AddInParameter(cmd, "@HoulryRate", DbType.Decimal, hREmployeeSalaryBreakDownEntity.HoulryRate);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeSalaryBreakDownEntity already exists. Please specify another HREmployeeSalaryBreakDownEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalaryBreakDownEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalaryBreakDownEntity already exists. Please specify another HREmployeeSalaryBreakDownEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeSalaryBreakDownEntity hREmployeeSalaryBreakDownEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryBreakDown_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeSalaryBreakDownID", db);

                db.AddInParameter(cmd, "@EmployeeSalaryInfoID", DbType.Int64, hREmployeeSalaryBreakDownEntity.EmployeeSalaryInfoID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryBreakDownEntity.EmployeeID);
                db.AddInParameter(cmd, "@YearlyRate", DbType.Decimal, hREmployeeSalaryBreakDownEntity.YearlyRate);
                db.AddInParameter(cmd, "@MonthlyRate", DbType.Decimal, hREmployeeSalaryBreakDownEntity.MonthlyRate);
                db.AddInParameter(cmd, "@DailyRate", DbType.Decimal, hREmployeeSalaryBreakDownEntity.DailyRate);
                db.AddInParameter(cmd, "@OTHourlyRate", DbType.Decimal, hREmployeeSalaryBreakDownEntity.OTHourlyRate);
                db.AddInParameter(cmd, "@HoulryRate", DbType.Decimal, hREmployeeSalaryBreakDownEntity.HoulryRate);

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

        IList<Int64> IHREmployeeSalaryBreakDownDataAccess.Add(IList<HREmployeeSalaryBreakDownEntity> hREmployeeSalaryBreakDownEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeSalaryBreakDownEntity hREmployeeSalaryBreakDownEntity in hREmployeeSalaryBreakDownEntityList)
            {
                returnCode = (this as IHREmployeeSalaryBreakDownDataAccess).Add(hREmployeeSalaryBreakDownEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeSalaryBreakDownDataAccess.Update(HREmployeeSalaryBreakDownEntity hREmployeeSalaryBreakDownEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeSalaryBreakDownEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeSalaryBreakDownEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeSalaryBreakDownEntity hREmployeeSalaryBreakDownEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryBreakDown_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeSalaryBreakDownID", DbType.Int64, hREmployeeSalaryBreakDownEntity.EmployeeSalaryBreakDownID);
                Database.AddInParameter(cmd, "@EmployeeSalaryInfoID", DbType.Int64, hREmployeeSalaryBreakDownEntity.EmployeeSalaryInfoID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryBreakDownEntity.EmployeeID);
                Database.AddInParameter(cmd, "@YearlyRate", DbType.Decimal, hREmployeeSalaryBreakDownEntity.YearlyRate);
                Database.AddInParameter(cmd, "@MonthlyRate", DbType.Decimal, hREmployeeSalaryBreakDownEntity.MonthlyRate);
                Database.AddInParameter(cmd, "@DailyRate", DbType.Decimal, hREmployeeSalaryBreakDownEntity.DailyRate);
                Database.AddInParameter(cmd, "@OTHourlyRate", DbType.Decimal, hREmployeeSalaryBreakDownEntity.OTHourlyRate);
                Database.AddInParameter(cmd, "@HoulryRate", DbType.Decimal, hREmployeeSalaryBreakDownEntity.HoulryRate);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeSalaryBreakDownEntity already exists. Please specify another HREmployeeSalaryBreakDownEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalaryBreakDownEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalaryBreakDownEntity already exists. Please specify another HREmployeeSalaryBreakDownEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeSalaryBreakDownEntity hREmployeeSalaryBreakDownEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryBreakDown_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeSalaryBreakDownID", DbType.Int64, hREmployeeSalaryBreakDownEntity.EmployeeSalaryBreakDownID);
                db.AddInParameter(cmd, "@EmployeeSalaryInfoID", DbType.Int64, hREmployeeSalaryBreakDownEntity.EmployeeSalaryInfoID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryBreakDownEntity.EmployeeID);
                db.AddInParameter(cmd, "@YearlyRate", DbType.Decimal, hREmployeeSalaryBreakDownEntity.YearlyRate);
                db.AddInParameter(cmd, "@MonthlyRate", DbType.Decimal, hREmployeeSalaryBreakDownEntity.MonthlyRate);
                db.AddInParameter(cmd, "@DailyRate", DbType.Decimal, hREmployeeSalaryBreakDownEntity.DailyRate);
                db.AddInParameter(cmd, "@OTHourlyRate", DbType.Decimal, hREmployeeSalaryBreakDownEntity.OTHourlyRate);
                db.AddInParameter(cmd, "@HoulryRate", DbType.Decimal, hREmployeeSalaryBreakDownEntity.HoulryRate);

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

        IList<Int64> IHREmployeeSalaryBreakDownDataAccess.Update(IList<HREmployeeSalaryBreakDownEntity> hREmployeeSalaryBreakDownEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeSalaryBreakDownEntity hREmployeeSalaryBreakDownEntity in hREmployeeSalaryBreakDownEntityList)
            {
                returnCode = (this as IHREmployeeSalaryBreakDownDataAccess).Update(hREmployeeSalaryBreakDownEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeSalaryBreakDownDataAccess.Delete(HREmployeeSalaryBreakDownEntity hREmployeeSalaryBreakDownEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeSalaryBreakDownEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeSalaryBreakDownEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeSalaryBreakDownEntity hREmployeeSalaryBreakDownEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryBreakDown_SET";

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
                                throw new ArgumentException("HREmployeeSalaryBreakDownEntity already exists. Please specify another HREmployeeSalaryBreakDownEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalaryBreakDownEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalaryBreakDownEntity already exists. Please specify another HREmployeeSalaryBreakDownEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeSalaryBreakDownEntity hREmployeeSalaryBreakDownEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryBreakDown_SET";

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

        IList<Int64> IHREmployeeSalaryBreakDownDataAccess.Delete(IList<HREmployeeSalaryBreakDownEntity> hREmployeeSalaryBreakDownEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeSalaryBreakDownEntity hREmployeeSalaryBreakDownEntity in hREmployeeSalaryBreakDownEntityList)
            {
                returnCode = (this as IHREmployeeSalaryBreakDownDataAccess).Delete(hREmployeeSalaryBreakDownEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeSalaryBreakDownEntity> IHREmployeeSalaryBreakDownDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeSalaryBreakDown_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeSalaryBreakDownEntity> list = CreateEntityBuilder<HREmployeeSalaryBreakDownEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeSalaryBreakDownDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeSalaryBreakDown_GET";

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
