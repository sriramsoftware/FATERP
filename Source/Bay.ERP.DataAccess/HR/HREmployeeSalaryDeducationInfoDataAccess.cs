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
    internal sealed partial class HREmployeeSalaryDeducationInfoDataAccess : BaseDataAccess, IHREmployeeSalaryDeducationInfoDataAccess
    {
        #region Constructors

        public HREmployeeSalaryDeducationInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeSalaryDeducationInfoEntity> CreateEntityBuilder<HREmployeeSalaryDeducationInfoEntity>()
        {
            return (new HREmployeeSalaryDeducationInfoBuilder()) as IEntityBuilder<HREmployeeSalaryDeducationInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeSalaryDeducationInfoDataAccess.Add(HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeSalaryDeducationInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeSalaryDeducationInfoEntity, option);
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

        private Int64 Add(HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryDeducationInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeSalaryDeducationInfoID");

                Database.AddInParameter(cmd, "@SalaryDeducationCategoryID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.SalaryDeducationCategoryID);	
                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.SalarySessionID);	
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.FiscalYearID);	
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@DeductionAmount", DbType.Decimal, hREmployeeSalaryDeducationInfoEntity.DeductionAmount);	
                Database.AddInParameter(cmd, "@PercentageOfBasicSalary", DbType.Decimal, hREmployeeSalaryDeducationInfoEntity.PercentageOfBasicSalary);	
                Database.AddInParameter(cmd, "@PayCycleID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.PayCycleID);	
                Database.AddInParameter(cmd, "@EffectiveDate", DbType.DateTime, hREmployeeSalaryDeducationInfoEntity.EffectiveDate);	
                Database.AddInParameter(cmd, "@EndDate", DbType.DateTime, hREmployeeSalaryDeducationInfoEntity.EndDate);	
                Database.AddInParameter(cmd, "@NumberOfPayments", DbType.Decimal, hREmployeeSalaryDeducationInfoEntity.NumberOfPayments);	
                Database.AddInParameter(cmd, "@Note", DbType.String, hREmployeeSalaryDeducationInfoEntity.Note);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hREmployeeSalaryDeducationInfoEntity.IsRemoved);
                Database.AddInParameter(cmd, "@NextInstallMent", DbType.Decimal, hREmployeeSalaryDeducationInfoEntity.NextInstallMent);

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeSalaryDeducationInfoEntity already exists. Please specify another HREmployeeSalaryDeducationInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalaryDeducationInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalaryDeducationInfoEntity already exists. Please specify another HREmployeeSalaryDeducationInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryDeducationInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeSalaryDeducationInfoID", db);

                db.AddInParameter(cmd, "@SalaryDeducationCategoryID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.SalaryDeducationCategoryID);
                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.SalarySessionID);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.FiscalYearID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.EmployeeID);
                db.AddInParameter(cmd, "@DeductionAmount", DbType.Decimal, hREmployeeSalaryDeducationInfoEntity.DeductionAmount);
                db.AddInParameter(cmd, "@PercentageOfBasicSalary", DbType.Decimal, hREmployeeSalaryDeducationInfoEntity.PercentageOfBasicSalary);
                db.AddInParameter(cmd, "@PayCycleID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.PayCycleID);
                db.AddInParameter(cmd, "@EffectiveDate", DbType.DateTime, hREmployeeSalaryDeducationInfoEntity.EffectiveDate);
                db.AddInParameter(cmd, "@EndDate", DbType.DateTime, hREmployeeSalaryDeducationInfoEntity.EndDate);
                db.AddInParameter(cmd, "@NumberOfPayments", DbType.Decimal, hREmployeeSalaryDeducationInfoEntity.NumberOfPayments);
                db.AddInParameter(cmd, "@Note", DbType.String, hREmployeeSalaryDeducationInfoEntity.Note);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hREmployeeSalaryDeducationInfoEntity.IsRemoved);
                db.AddInParameter(cmd, "@NextInstallMent", DbType.Decimal, hREmployeeSalaryDeducationInfoEntity.NextInstallMent);

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

        IList<Int64> IHREmployeeSalaryDeducationInfoDataAccess.Add(IList<HREmployeeSalaryDeducationInfoEntity> hREmployeeSalaryDeducationInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity in hREmployeeSalaryDeducationInfoEntityList)
            {
                returnCode = (this as IHREmployeeSalaryDeducationInfoDataAccess).Add(hREmployeeSalaryDeducationInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeSalaryDeducationInfoDataAccess.Update(HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeSalaryDeducationInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeSalaryDeducationInfoEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryDeducationInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeSalaryDeducationInfoID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.EmployeeSalaryDeducationInfoID);
                Database.AddInParameter(cmd, "@SalaryDeducationCategoryID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.SalaryDeducationCategoryID);
                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.SalarySessionID);
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.FiscalYearID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.EmployeeID);
                Database.AddInParameter(cmd, "@DeductionAmount", DbType.Decimal, hREmployeeSalaryDeducationInfoEntity.DeductionAmount);
                Database.AddInParameter(cmd, "@PercentageOfBasicSalary", DbType.Decimal, hREmployeeSalaryDeducationInfoEntity.PercentageOfBasicSalary);
                Database.AddInParameter(cmd, "@PayCycleID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.PayCycleID);
                Database.AddInParameter(cmd, "@EffectiveDate", DbType.DateTime, hREmployeeSalaryDeducationInfoEntity.EffectiveDate);
                Database.AddInParameter(cmd, "@EndDate", DbType.DateTime, hREmployeeSalaryDeducationInfoEntity.EndDate);
                Database.AddInParameter(cmd, "@NumberOfPayments", DbType.Decimal, hREmployeeSalaryDeducationInfoEntity.NumberOfPayments);
                Database.AddInParameter(cmd, "@Note", DbType.String, hREmployeeSalaryDeducationInfoEntity.Note);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hREmployeeSalaryDeducationInfoEntity.IsRemoved);
                Database.AddInParameter(cmd, "@NextInstallMent", DbType.Decimal, hREmployeeSalaryDeducationInfoEntity.NextInstallMent);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeSalaryDeducationInfoEntity already exists. Please specify another HREmployeeSalaryDeducationInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalaryDeducationInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalaryDeducationInfoEntity already exists. Please specify another HREmployeeSalaryDeducationInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryDeducationInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeSalaryDeducationInfoID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.EmployeeSalaryDeducationInfoID);
                db.AddInParameter(cmd, "@SalaryDeducationCategoryID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.SalaryDeducationCategoryID);
                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.SalarySessionID);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.FiscalYearID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.EmployeeID);
                db.AddInParameter(cmd, "@DeductionAmount", DbType.Decimal, hREmployeeSalaryDeducationInfoEntity.DeductionAmount);
                db.AddInParameter(cmd, "@PercentageOfBasicSalary", DbType.Decimal, hREmployeeSalaryDeducationInfoEntity.PercentageOfBasicSalary);
                db.AddInParameter(cmd, "@PayCycleID", DbType.Int64, hREmployeeSalaryDeducationInfoEntity.PayCycleID);
                db.AddInParameter(cmd, "@EffectiveDate", DbType.DateTime, hREmployeeSalaryDeducationInfoEntity.EffectiveDate);
                db.AddInParameter(cmd, "@EndDate", DbType.DateTime, hREmployeeSalaryDeducationInfoEntity.EndDate);
                db.AddInParameter(cmd, "@NumberOfPayments", DbType.Decimal, hREmployeeSalaryDeducationInfoEntity.NumberOfPayments);
                db.AddInParameter(cmd, "@Note", DbType.String, hREmployeeSalaryDeducationInfoEntity.Note);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hREmployeeSalaryDeducationInfoEntity.IsRemoved);
                db.AddInParameter(cmd, "@NextInstallMent", DbType.Decimal, hREmployeeSalaryDeducationInfoEntity.NextInstallMent);

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

        IList<Int64> IHREmployeeSalaryDeducationInfoDataAccess.Update(IList<HREmployeeSalaryDeducationInfoEntity> hREmployeeSalaryDeducationInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity in hREmployeeSalaryDeducationInfoEntityList)
            {
                returnCode = (this as IHREmployeeSalaryDeducationInfoDataAccess).Update(hREmployeeSalaryDeducationInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeSalaryDeducationInfoDataAccess.Delete(HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeSalaryDeducationInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeSalaryDeducationInfoEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryDeducationInfo_SET";

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
                                throw new ArgumentException("HREmployeeSalaryDeducationInfoEntity already exists. Please specify another HREmployeeSalaryDeducationInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalaryDeducationInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalaryDeducationInfoEntity already exists. Please specify another HREmployeeSalaryDeducationInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryDeducationInfo_SET";

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

        IList<Int64> IHREmployeeSalaryDeducationInfoDataAccess.Delete(IList<HREmployeeSalaryDeducationInfoEntity> hREmployeeSalaryDeducationInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity in hREmployeeSalaryDeducationInfoEntityList)
            {
                returnCode = (this as IHREmployeeSalaryDeducationInfoDataAccess).Delete(hREmployeeSalaryDeducationInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeSalaryDeducationInfoEntity> IHREmployeeSalaryDeducationInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeSalaryDeducationInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeSalaryDeducationInfoEntity> list = CreateEntityBuilder<HREmployeeSalaryDeducationInfoEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeSalaryDeducationInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeSalaryDeducationInfo_GET";

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
