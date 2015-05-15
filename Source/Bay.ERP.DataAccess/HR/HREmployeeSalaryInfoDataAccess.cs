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
    internal sealed partial class HREmployeeSalaryInfoDataAccess : BaseDataAccess, IHREmployeeSalaryInfoDataAccess
    {
        #region Constructors

        public HREmployeeSalaryInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeSalaryInfoEntity> CreateEntityBuilder<HREmployeeSalaryInfoEntity>()
        {
            return (new HREmployeeSalaryInfoBuilder()) as IEntityBuilder<HREmployeeSalaryInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeSalaryInfoDataAccess.Add(HREmployeeSalaryInfoEntity hREmployeeSalaryInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeSalaryInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeSalaryInfoEntity, option);
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

        private Int64 Add(HREmployeeSalaryInfoEntity hREmployeeSalaryInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeSalaryInfoID");

                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeSalaryInfoEntity.FiscalYearID);		
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryInfoEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@IsDeposite", DbType.Boolean, hREmployeeSalaryInfoEntity.IsDeposite);	
                Database.AddInParameter(cmd, "@SalaryAmount", DbType.Decimal, hREmployeeSalaryInfoEntity.SalaryAmount);	
                Database.AddInParameter(cmd, "@PayCycleID", DbType.Int64, hREmployeeSalaryInfoEntity.PayCycleID);	
                Database.AddInParameter(cmd, "@PayscaleID", DbType.Int64, hREmployeeSalaryInfoEntity.PayscaleID);	
                Database.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeSalaryInfoEntity.EmployeeCode);	
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, hREmployeeSalaryInfoEntity.ProjectID);	
                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, hREmployeeSalaryInfoEntity.DepartmentID);	
                Database.AddInParameter(cmd, "@DesignationID", DbType.Int64, hREmployeeSalaryInfoEntity.DesignationID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeSalaryInfoEntity already exists. Please specify another HREmployeeSalaryInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalaryInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalaryInfoEntity already exists. Please specify another HREmployeeSalaryInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeSalaryInfoEntity hREmployeeSalaryInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeSalaryInfoID", db);

                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeSalaryInfoEntity.FiscalYearID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryInfoEntity.EmployeeID);
                db.AddInParameter(cmd, "@IsDeposite", DbType.Boolean, hREmployeeSalaryInfoEntity.IsDeposite);
                db.AddInParameter(cmd, "@SalaryAmount", DbType.Decimal, hREmployeeSalaryInfoEntity.SalaryAmount);
                db.AddInParameter(cmd, "@PayCycleID", DbType.Int64, hREmployeeSalaryInfoEntity.PayCycleID);
                db.AddInParameter(cmd, "@PayscaleID", DbType.Int64, hREmployeeSalaryInfoEntity.PayscaleID);
                db.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeSalaryInfoEntity.EmployeeCode);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, hREmployeeSalaryInfoEntity.ProjectID);
                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, hREmployeeSalaryInfoEntity.DepartmentID);
                db.AddInParameter(cmd, "@DesignationID", DbType.Int64, hREmployeeSalaryInfoEntity.DesignationID);

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

        IList<Int64> IHREmployeeSalaryInfoDataAccess.Add(IList<HREmployeeSalaryInfoEntity> hREmployeeSalaryInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeSalaryInfoEntity hREmployeeSalaryInfoEntity in hREmployeeSalaryInfoEntityList)
            {
                returnCode = (this as IHREmployeeSalaryInfoDataAccess).Add(hREmployeeSalaryInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeSalaryInfoDataAccess.Update(HREmployeeSalaryInfoEntity hREmployeeSalaryInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeSalaryInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeSalaryInfoEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeSalaryInfoEntity hREmployeeSalaryInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeSalaryInfoID", DbType.Int64, hREmployeeSalaryInfoEntity.EmployeeSalaryInfoID);
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeSalaryInfoEntity.FiscalYearID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryInfoEntity.EmployeeID);
                Database.AddInParameter(cmd, "@IsDeposite", DbType.Boolean, hREmployeeSalaryInfoEntity.IsDeposite);
                Database.AddInParameter(cmd, "@SalaryAmount", DbType.Decimal, hREmployeeSalaryInfoEntity.SalaryAmount);
                Database.AddInParameter(cmd, "@PayCycleID", DbType.Int64, hREmployeeSalaryInfoEntity.PayCycleID);
                Database.AddInParameter(cmd, "@PayscaleID", DbType.Int64, hREmployeeSalaryInfoEntity.PayscaleID);
                Database.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeSalaryInfoEntity.EmployeeCode);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, hREmployeeSalaryInfoEntity.ProjectID);
                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, hREmployeeSalaryInfoEntity.DepartmentID);
                Database.AddInParameter(cmd, "@DesignationID", DbType.Int64, hREmployeeSalaryInfoEntity.DesignationID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeSalaryInfoEntity already exists. Please specify another HREmployeeSalaryInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalaryInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalaryInfoEntity already exists. Please specify another HREmployeeSalaryInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeSalaryInfoEntity hREmployeeSalaryInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeSalaryInfoID", DbType.Int64, hREmployeeSalaryInfoEntity.EmployeeSalaryInfoID);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeSalaryInfoEntity.FiscalYearID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryInfoEntity.EmployeeID);
                db.AddInParameter(cmd, "@IsDeposite", DbType.Boolean, hREmployeeSalaryInfoEntity.IsDeposite);
                db.AddInParameter(cmd, "@SalaryAmount", DbType.Decimal, hREmployeeSalaryInfoEntity.SalaryAmount);
                db.AddInParameter(cmd, "@PayCycleID", DbType.Int64, hREmployeeSalaryInfoEntity.PayCycleID);
                db.AddInParameter(cmd, "@PayscaleID", DbType.Int64, hREmployeeSalaryInfoEntity.PayscaleID);
                db.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeSalaryInfoEntity.EmployeeCode);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, hREmployeeSalaryInfoEntity.ProjectID);
                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, hREmployeeSalaryInfoEntity.DepartmentID);
                db.AddInParameter(cmd, "@DesignationID", DbType.Int64, hREmployeeSalaryInfoEntity.DesignationID);

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

        IList<Int64> IHREmployeeSalaryInfoDataAccess.Update(IList<HREmployeeSalaryInfoEntity> hREmployeeSalaryInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeSalaryInfoEntity hREmployeeSalaryInfoEntity in hREmployeeSalaryInfoEntityList)
            {
                returnCode = (this as IHREmployeeSalaryInfoDataAccess).Update(hREmployeeSalaryInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeSalaryInfoDataAccess.Delete(HREmployeeSalaryInfoEntity hREmployeeSalaryInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeSalaryInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeSalaryInfoEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeSalaryInfoEntity hREmployeeSalaryInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryInfo_SET";

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
                                throw new ArgumentException("HREmployeeSalaryInfoEntity already exists. Please specify another HREmployeeSalaryInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalaryInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalaryInfoEntity already exists. Please specify another HREmployeeSalaryInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeSalaryInfoEntity hREmployeeSalaryInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryInfo_SET";

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

        IList<Int64> IHREmployeeSalaryInfoDataAccess.Delete(IList<HREmployeeSalaryInfoEntity> hREmployeeSalaryInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeSalaryInfoEntity hREmployeeSalaryInfoEntity in hREmployeeSalaryInfoEntityList)
            {
                returnCode = (this as IHREmployeeSalaryInfoDataAccess).Delete(hREmployeeSalaryInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeSalaryInfoEntity> IHREmployeeSalaryInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeSalaryInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeSalaryInfoEntity> list = CreateEntityBuilder<HREmployeeSalaryInfoEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeSalaryInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeSalaryInfo_GET";

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
