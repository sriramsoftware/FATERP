// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




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
    internal sealed partial class HREmployeeLoanApplicationDataAccess : BaseDataAccess, IHREmployeeLoanApplicationDataAccess
    {
        #region Constructors

        public HREmployeeLoanApplicationDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeLoanApplicationEntity> CreateEntityBuilder<HREmployeeLoanApplicationEntity>()
        {
            return (new HREmployeeLoanApplicationBuilder()) as IEntityBuilder<HREmployeeLoanApplicationEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeLoanApplicationDataAccess.Add(HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeLoanApplicationEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeLoanApplicationEntity, option);
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

        private Int64 Add(HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeLoanApplication_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeLoanApplicationID");

                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeLoanApplicationEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@LoanCategoryID", DbType.Int64, hREmployeeLoanApplicationEntity.LoanCategoryID);	
                Database.AddInParameter(cmd, "@AppliedLoanAmount", DbType.Decimal, hREmployeeLoanApplicationEntity.AppliedLoanAmount);	
                Database.AddInParameter(cmd, "@CurrencyID", DbType.Int64, hREmployeeLoanApplicationEntity.CurrencyID);	
                Database.AddInParameter(cmd, "@LoanPaymentStartDate", DbType.DateTime, hREmployeeLoanApplicationEntity.LoanPaymentStartDate);	
                Database.AddInParameter(cmd, "@LoanPaymentEndDate", DbType.DateTime, hREmployeeLoanApplicationEntity.LoanPaymentEndDate);	
                Database.AddInParameter(cmd, "@NumberOfInstallment", DbType.Decimal, hREmployeeLoanApplicationEntity.NumberOfInstallment);	
                Database.AddInParameter(cmd, "@Description", DbType.String, hREmployeeLoanApplicationEntity.Description);	
                Database.AddInParameter(cmd, "@EmployeeLoanApprovalStatusID", DbType.Int64, hREmployeeLoanApplicationEntity.EmployeeLoanApprovalStatusID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeLoanApplicationEntity.Remarks);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeLoanApplicationEntity already exists. Please specify another HREmployeeLoanApplicationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeLoanApplicationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeLoanApplicationEntity already exists. Please specify another HREmployeeLoanApplicationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeLoanApplication_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeLoanApplicationID", db);

                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeLoanApplicationEntity.EmployeeID);
                db.AddInParameter(cmd, "@LoanCategoryID", DbType.Int64, hREmployeeLoanApplicationEntity.LoanCategoryID);
                db.AddInParameter(cmd, "@AppliedLoanAmount", DbType.Decimal, hREmployeeLoanApplicationEntity.AppliedLoanAmount);
                db.AddInParameter(cmd, "@CurrencyID", DbType.Int64, hREmployeeLoanApplicationEntity.CurrencyID);
                db.AddInParameter(cmd, "@LoanPaymentStartDate", DbType.DateTime, hREmployeeLoanApplicationEntity.LoanPaymentStartDate);
                db.AddInParameter(cmd, "@LoanPaymentEndDate", DbType.DateTime, hREmployeeLoanApplicationEntity.LoanPaymentEndDate);
                db.AddInParameter(cmd, "@NumberOfInstallment", DbType.Decimal, hREmployeeLoanApplicationEntity.NumberOfInstallment);
                db.AddInParameter(cmd, "@Description", DbType.String, hREmployeeLoanApplicationEntity.Description);
                db.AddInParameter(cmd, "@EmployeeLoanApprovalStatusID", DbType.Int64, hREmployeeLoanApplicationEntity.EmployeeLoanApprovalStatusID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeLoanApplicationEntity.Remarks);

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

        IList<Int64> IHREmployeeLoanApplicationDataAccess.Add(IList<HREmployeeLoanApplicationEntity> hREmployeeLoanApplicationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity in hREmployeeLoanApplicationEntityList)
            {
                returnCode = (this as IHREmployeeLoanApplicationDataAccess).Add(hREmployeeLoanApplicationEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeLoanApplicationDataAccess.Update(HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeLoanApplicationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeLoanApplicationEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeLoanApplication_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeLoanApplicationID", DbType.Int64, hREmployeeLoanApplicationEntity.EmployeeLoanApplicationID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeLoanApplicationEntity.EmployeeID);
                Database.AddInParameter(cmd, "@LoanCategoryID", DbType.Int64, hREmployeeLoanApplicationEntity.LoanCategoryID);
                Database.AddInParameter(cmd, "@AppliedLoanAmount", DbType.Decimal, hREmployeeLoanApplicationEntity.AppliedLoanAmount);
                Database.AddInParameter(cmd, "@CurrencyID", DbType.Int64, hREmployeeLoanApplicationEntity.CurrencyID);
                Database.AddInParameter(cmd, "@LoanPaymentStartDate", DbType.DateTime, hREmployeeLoanApplicationEntity.LoanPaymentStartDate);
                Database.AddInParameter(cmd, "@LoanPaymentEndDate", DbType.DateTime, hREmployeeLoanApplicationEntity.LoanPaymentEndDate);
                Database.AddInParameter(cmd, "@NumberOfInstallment", DbType.Decimal, hREmployeeLoanApplicationEntity.NumberOfInstallment);
                Database.AddInParameter(cmd, "@Description", DbType.String, hREmployeeLoanApplicationEntity.Description);
                Database.AddInParameter(cmd, "@EmployeeLoanApprovalStatusID", DbType.Int64, hREmployeeLoanApplicationEntity.EmployeeLoanApprovalStatusID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeLoanApplicationEntity.Remarks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeLoanApplicationEntity already exists. Please specify another HREmployeeLoanApplicationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeLoanApplicationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeLoanApplicationEntity already exists. Please specify another HREmployeeLoanApplicationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeLoanApplication_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeLoanApplicationID", DbType.Int64, hREmployeeLoanApplicationEntity.EmployeeLoanApplicationID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeLoanApplicationEntity.EmployeeID);
                db.AddInParameter(cmd, "@LoanCategoryID", DbType.Int64, hREmployeeLoanApplicationEntity.LoanCategoryID);
                db.AddInParameter(cmd, "@AppliedLoanAmount", DbType.Decimal, hREmployeeLoanApplicationEntity.AppliedLoanAmount);
                db.AddInParameter(cmd, "@CurrencyID", DbType.Int64, hREmployeeLoanApplicationEntity.CurrencyID);
                db.AddInParameter(cmd, "@LoanPaymentStartDate", DbType.DateTime, hREmployeeLoanApplicationEntity.LoanPaymentStartDate);
                db.AddInParameter(cmd, "@LoanPaymentEndDate", DbType.DateTime, hREmployeeLoanApplicationEntity.LoanPaymentEndDate);
                db.AddInParameter(cmd, "@NumberOfInstallment", DbType.Decimal, hREmployeeLoanApplicationEntity.NumberOfInstallment);
                db.AddInParameter(cmd, "@Description", DbType.String, hREmployeeLoanApplicationEntity.Description);
                db.AddInParameter(cmd, "@EmployeeLoanApprovalStatusID", DbType.Int64, hREmployeeLoanApplicationEntity.EmployeeLoanApprovalStatusID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeLoanApplicationEntity.Remarks);

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

        IList<Int64> IHREmployeeLoanApplicationDataAccess.Update(IList<HREmployeeLoanApplicationEntity> hREmployeeLoanApplicationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity in hREmployeeLoanApplicationEntityList)
            {
                returnCode = (this as IHREmployeeLoanApplicationDataAccess).Update(hREmployeeLoanApplicationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeLoanApplicationDataAccess.Delete(HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeLoanApplicationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeLoanApplicationEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeLoanApplication_SET";

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
                                throw new ArgumentException("HREmployeeLoanApplicationEntity already exists. Please specify another HREmployeeLoanApplicationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeLoanApplicationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeLoanApplicationEntity already exists. Please specify another HREmployeeLoanApplicationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeLoanApplication_SET";

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

        IList<Int64> IHREmployeeLoanApplicationDataAccess.Delete(IList<HREmployeeLoanApplicationEntity> hREmployeeLoanApplicationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity in hREmployeeLoanApplicationEntityList)
            {
                returnCode = (this as IHREmployeeLoanApplicationDataAccess).Delete(hREmployeeLoanApplicationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeLoanApplicationEntity> IHREmployeeLoanApplicationDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeLoanApplication_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeLoanApplicationEntity> list = CreateEntityBuilder<HREmployeeLoanApplicationEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeLoanApplicationDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeLoanApplication_GET";

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
