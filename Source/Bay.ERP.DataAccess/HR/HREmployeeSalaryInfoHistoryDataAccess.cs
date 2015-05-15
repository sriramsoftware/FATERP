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
    internal sealed partial class HREmployeeSalaryInfoHistoryDataAccess : BaseDataAccess, IHREmployeeSalaryInfoHistoryDataAccess
    {
        #region Constructors

        public HREmployeeSalaryInfoHistoryDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeSalaryInfoHistoryEntity> CreateEntityBuilder<HREmployeeSalaryInfoHistoryEntity>()
        {
            return (new HREmployeeSalaryInfoHistoryBuilder()) as IEntityBuilder<HREmployeeSalaryInfoHistoryEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeSalaryInfoHistoryDataAccess.Add(HREmployeeSalaryInfoHistoryEntity hREmployeeSalaryInfoHistoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeSalaryInfoHistoryEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeSalaryInfoHistoryEntity, option);
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

        private Int64 Add(HREmployeeSalaryInfoHistoryEntity hREmployeeSalaryInfoHistoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryInfoHistory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeSalaryInfoHistoryID");

                Database.AddInParameter(cmd, "@EmployeeSalaryInfoID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.EmployeeSalaryInfoID);	
                Database.AddInParameter(cmd, "@DesignationID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.DesignationID);	
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.FiscalYearID);	
                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.SalarySessionID);	
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@IsDeposite", DbType.Boolean, hREmployeeSalaryInfoHistoryEntity.IsDeposite);	
                Database.AddInParameter(cmd, "@SalaryAmount", DbType.Decimal, hREmployeeSalaryInfoHistoryEntity.SalaryAmount);	
                Database.AddInParameter(cmd, "@PayCycleID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.PayCycleID);	
                Database.AddInParameter(cmd, "@PayscaleID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.PayscaleID);	
                Database.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeSalaryInfoHistoryEntity.EmployeeCode);	
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.ProjectID);	
                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.DepartmentID);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hREmployeeSalaryInfoHistoryEntity.CreateDate);	
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.CreatedByEmployeeID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeSalaryInfoHistoryEntity already exists. Please specify another HREmployeeSalaryInfoHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalaryInfoHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalaryInfoHistoryEntity already exists. Please specify another HREmployeeSalaryInfoHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeSalaryInfoHistoryEntity hREmployeeSalaryInfoHistoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryInfoHistory_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeSalaryInfoHistoryID", db);

                db.AddInParameter(cmd, "@EmployeeSalaryInfoID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.EmployeeSalaryInfoID);
                db.AddInParameter(cmd, "@DesignationID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.DesignationID);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.FiscalYearID);
                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.SalarySessionID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.EmployeeID);
                db.AddInParameter(cmd, "@IsDeposite", DbType.Boolean, hREmployeeSalaryInfoHistoryEntity.IsDeposite);
                db.AddInParameter(cmd, "@SalaryAmount", DbType.Decimal, hREmployeeSalaryInfoHistoryEntity.SalaryAmount);
                db.AddInParameter(cmd, "@PayCycleID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.PayCycleID);
                db.AddInParameter(cmd, "@PayscaleID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.PayscaleID);
                db.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeSalaryInfoHistoryEntity.EmployeeCode);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.ProjectID);
                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.DepartmentID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hREmployeeSalaryInfoHistoryEntity.CreateDate);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.CreatedByEmployeeID);

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

        IList<Int64> IHREmployeeSalaryInfoHistoryDataAccess.Add(IList<HREmployeeSalaryInfoHistoryEntity> hREmployeeSalaryInfoHistoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeSalaryInfoHistoryEntity hREmployeeSalaryInfoHistoryEntity in hREmployeeSalaryInfoHistoryEntityList)
            {
                returnCode = (this as IHREmployeeSalaryInfoHistoryDataAccess).Add(hREmployeeSalaryInfoHistoryEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeSalaryInfoHistoryDataAccess.Update(HREmployeeSalaryInfoHistoryEntity hREmployeeSalaryInfoHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeSalaryInfoHistoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeSalaryInfoHistoryEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeSalaryInfoHistoryEntity hREmployeeSalaryInfoHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryInfoHistory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeSalaryInfoHistoryID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.EmployeeSalaryInfoHistoryID);
                Database.AddInParameter(cmd, "@EmployeeSalaryInfoID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.EmployeeSalaryInfoID);
                Database.AddInParameter(cmd, "@DesignationID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.DesignationID);
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.FiscalYearID);
                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.SalarySessionID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.EmployeeID);
                Database.AddInParameter(cmd, "@IsDeposite", DbType.Boolean, hREmployeeSalaryInfoHistoryEntity.IsDeposite);
                Database.AddInParameter(cmd, "@SalaryAmount", DbType.Decimal, hREmployeeSalaryInfoHistoryEntity.SalaryAmount);
                Database.AddInParameter(cmd, "@PayCycleID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.PayCycleID);
                Database.AddInParameter(cmd, "@PayscaleID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.PayscaleID);
                Database.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeSalaryInfoHistoryEntity.EmployeeCode);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.ProjectID);
                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.DepartmentID);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hREmployeeSalaryInfoHistoryEntity.CreateDate);
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.CreatedByEmployeeID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeSalaryInfoHistoryEntity already exists. Please specify another HREmployeeSalaryInfoHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalaryInfoHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalaryInfoHistoryEntity already exists. Please specify another HREmployeeSalaryInfoHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeSalaryInfoHistoryEntity hREmployeeSalaryInfoHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryInfoHistory_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeSalaryInfoHistoryID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.EmployeeSalaryInfoHistoryID);
                db.AddInParameter(cmd, "@EmployeeSalaryInfoID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.EmployeeSalaryInfoID);
                db.AddInParameter(cmd, "@DesignationID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.DesignationID);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.FiscalYearID);
                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.SalarySessionID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.EmployeeID);
                db.AddInParameter(cmd, "@IsDeposite", DbType.Boolean, hREmployeeSalaryInfoHistoryEntity.IsDeposite);
                db.AddInParameter(cmd, "@SalaryAmount", DbType.Decimal, hREmployeeSalaryInfoHistoryEntity.SalaryAmount);
                db.AddInParameter(cmd, "@PayCycleID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.PayCycleID);
                db.AddInParameter(cmd, "@PayscaleID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.PayscaleID);
                db.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeSalaryInfoHistoryEntity.EmployeeCode);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.ProjectID);
                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.DepartmentID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hREmployeeSalaryInfoHistoryEntity.CreateDate);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, hREmployeeSalaryInfoHistoryEntity.CreatedByEmployeeID);

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

        IList<Int64> IHREmployeeSalaryInfoHistoryDataAccess.Update(IList<HREmployeeSalaryInfoHistoryEntity> hREmployeeSalaryInfoHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeSalaryInfoHistoryEntity hREmployeeSalaryInfoHistoryEntity in hREmployeeSalaryInfoHistoryEntityList)
            {
                returnCode = (this as IHREmployeeSalaryInfoHistoryDataAccess).Update(hREmployeeSalaryInfoHistoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeSalaryInfoHistoryDataAccess.Delete(HREmployeeSalaryInfoHistoryEntity hREmployeeSalaryInfoHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeSalaryInfoHistoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeSalaryInfoHistoryEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeSalaryInfoHistoryEntity hREmployeeSalaryInfoHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryInfoHistory_SET";

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
                                throw new ArgumentException("HREmployeeSalaryInfoHistoryEntity already exists. Please specify another HREmployeeSalaryInfoHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalaryInfoHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalaryInfoHistoryEntity already exists. Please specify another HREmployeeSalaryInfoHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeSalaryInfoHistoryEntity hREmployeeSalaryInfoHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryInfoHistory_SET";

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

        IList<Int64> IHREmployeeSalaryInfoHistoryDataAccess.Delete(IList<HREmployeeSalaryInfoHistoryEntity> hREmployeeSalaryInfoHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeSalaryInfoHistoryEntity hREmployeeSalaryInfoHistoryEntity in hREmployeeSalaryInfoHistoryEntityList)
            {
                returnCode = (this as IHREmployeeSalaryInfoHistoryDataAccess).Delete(hREmployeeSalaryInfoHistoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeSalaryInfoHistoryEntity> IHREmployeeSalaryInfoHistoryDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeSalaryInfoHistory_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeSalaryInfoHistoryEntity> list = CreateEntityBuilder<HREmployeeSalaryInfoHistoryEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeSalaryInfoHistoryDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeSalaryInfoHistory_GET";

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
