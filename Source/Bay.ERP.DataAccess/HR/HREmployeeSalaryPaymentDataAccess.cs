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
    internal sealed partial class HREmployeeSalaryPaymentDataAccess : BaseDataAccess, IHREmployeeSalaryPaymentDataAccess
    {
        #region Constructors

        public HREmployeeSalaryPaymentDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeSalaryPaymentEntity> CreateEntityBuilder<HREmployeeSalaryPaymentEntity>()
        {
            return (new HREmployeeSalaryPaymentBuilder()) as IEntityBuilder<HREmployeeSalaryPaymentEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeSalaryPaymentDataAccess.Add(HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeSalaryPaymentEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeSalaryPaymentEntity, option);
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

        private Int64 Add(HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryPayment_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeSalaryPaymentID");

                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryPaymentEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, hREmployeeSalaryPaymentEntity.EmployeeJobTypeID);	
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, hREmployeeSalaryPaymentEntity.ProjectID);	
                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, hREmployeeSalaryPaymentEntity.DepartmentID);	
                Database.AddInParameter(cmd, "@DesignationID", DbType.Int64, hREmployeeSalaryPaymentEntity.DesignationID);	
                Database.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeSalaryPaymentEntity.EmployeeCode);	
                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeSalaryPaymentEntity.SalarySessionID);	
                Database.AddInParameter(cmd, "@SalarySessionStartDate", DbType.DateTime, hREmployeeSalaryPaymentEntity.SalarySessionStartDate);	
                Database.AddInParameter(cmd, "@SalarySessionEndDate", DbType.DateTime, hREmployeeSalaryPaymentEntity.SalarySessionEndDate);	
                Database.AddInParameter(cmd, "@ConsolidateSalaryAmount", DbType.Decimal, hREmployeeSalaryPaymentEntity.ConsolidateSalaryAmount);	
                Database.AddInParameter(cmd, "@Workdays", DbType.Decimal, hREmployeeSalaryPaymentEntity.Workdays);	
                Database.AddInParameter(cmd, "@Advance", DbType.Decimal, hREmployeeSalaryPaymentEntity.Advance);	
                Database.AddInParameter(cmd, "@Fine", DbType.Decimal, hREmployeeSalaryPaymentEntity.Fine);	
                Database.AddInParameter(cmd, "@Meals", DbType.Decimal, hREmployeeSalaryPaymentEntity.Meals);	
                Database.AddInParameter(cmd, "@AIT", DbType.Decimal, hREmployeeSalaryPaymentEntity.AIT);	
                Database.AddInParameter(cmd, "@Adjustment", DbType.Decimal, hREmployeeSalaryPaymentEntity.Adjustment);	
                Database.AddInParameter(cmd, "@NetPayable", DbType.Decimal, hREmployeeSalaryPaymentEntity.NetPayable);	
                Database.AddInParameter(cmd, "@Note", DbType.Decimal, hREmployeeSalaryPaymentEntity.Note);	
                Database.AddInParameter(cmd, "@Cash", DbType.Decimal, hREmployeeSalaryPaymentEntity.Cash);	
                Database.AddInParameter(cmd, "@BankAmount", DbType.Decimal, hREmployeeSalaryPaymentEntity.BankAmount);	
                Database.AddInParameter(cmd, "@SalaryPayable", DbType.Decimal, hREmployeeSalaryPaymentEntity.SalaryPayable);	
                Database.AddInParameter(cmd, "@Allowance", DbType.Decimal, hREmployeeSalaryPaymentEntity.Allowance);	
                Database.AddInParameter(cmd, "@ProjectActual", DbType.Decimal, hREmployeeSalaryPaymentEntity.ProjectActual);	
                Database.AddInParameter(cmd, "@Bonus", DbType.Decimal, hREmployeeSalaryPaymentEntity.Bonus);	
                Database.AddInParameter(cmd, "@PhoneCeiling", DbType.Decimal, hREmployeeSalaryPaymentEntity.PhoneCeiling);	
                Database.AddInParameter(cmd, "@PhoneActualBill", DbType.Decimal, hREmployeeSalaryPaymentEntity.PhoneActualBill);	
                Database.AddInParameter(cmd, "@PhoneBillAdjustment", DbType.Decimal, hREmployeeSalaryPaymentEntity.PhoneBillAdjustment);	
                Database.AddInParameter(cmd, "@ProvidentFundDeductedAmount", DbType.Decimal, hREmployeeSalaryPaymentEntity.ProvidentFundDeductedAmount);	
                Database.AddInParameter(cmd, "@PBR", DbType.Decimal, hREmployeeSalaryPaymentEntity.PBR);	
                Database.AddInParameter(cmd, "@EBR", DbType.Decimal, hREmployeeSalaryPaymentEntity.EBR);	
                Database.AddInParameter(cmd, "@PhoneBill", DbType.Decimal, hREmployeeSalaryPaymentEntity.PhoneBill);	
                Database.AddInParameter(cmd, "@EmployeeSalaryPaymentStatusID", DbType.Int64, hREmployeeSalaryPaymentEntity.EmployeeSalaryPaymentStatusID);
                Database.AddInParameter(cmd, "@SalaryLevel", DbType.Int64, hREmployeeSalaryPaymentEntity.SalaryLevel);	
                Database.AddInParameter(cmd, "@Field2", DbType.String, hREmployeeSalaryPaymentEntity.Field2);	
                Database.AddInParameter(cmd, "@Field3", DbType.String, hREmployeeSalaryPaymentEntity.Field3);	
                Database.AddInParameter(cmd, "@Field4", DbType.String, hREmployeeSalaryPaymentEntity.Field4);
                Database.AddInParameter(cmd, "@TBR", DbType.Decimal, hREmployeeSalaryPaymentEntity.TBR);
                Database.AddInParameter(cmd, "@TAX", DbType.Decimal, hREmployeeSalaryPaymentEntity.TAX);

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeSalaryPaymentEntity already exists. Please specify another HREmployeeSalaryPaymentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalaryPaymentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalaryPaymentEntity already exists. Please specify another HREmployeeSalaryPaymentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryPayment_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeSalaryPaymentID", db);

                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryPaymentEntity.EmployeeID);
                db.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, hREmployeeSalaryPaymentEntity.EmployeeJobTypeID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, hREmployeeSalaryPaymentEntity.ProjectID);
                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, hREmployeeSalaryPaymentEntity.DepartmentID);
                db.AddInParameter(cmd, "@DesignationID", DbType.Int64, hREmployeeSalaryPaymentEntity.DesignationID);
                db.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeSalaryPaymentEntity.EmployeeCode);
                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeSalaryPaymentEntity.SalarySessionID);
                db.AddInParameter(cmd, "@SalarySessionStartDate", DbType.DateTime, hREmployeeSalaryPaymentEntity.SalarySessionStartDate);
                db.AddInParameter(cmd, "@SalarySessionEndDate", DbType.DateTime, hREmployeeSalaryPaymentEntity.SalarySessionEndDate);
                db.AddInParameter(cmd, "@ConsolidateSalaryAmount", DbType.Decimal, hREmployeeSalaryPaymentEntity.ConsolidateSalaryAmount);
                db.AddInParameter(cmd, "@Workdays", DbType.Decimal, hREmployeeSalaryPaymentEntity.Workdays);
                db.AddInParameter(cmd, "@Advance", DbType.Decimal, hREmployeeSalaryPaymentEntity.Advance);
                db.AddInParameter(cmd, "@Fine", DbType.Decimal, hREmployeeSalaryPaymentEntity.Fine);
                db.AddInParameter(cmd, "@Meals", DbType.Decimal, hREmployeeSalaryPaymentEntity.Meals);
                db.AddInParameter(cmd, "@AIT", DbType.Decimal, hREmployeeSalaryPaymentEntity.AIT);
                db.AddInParameter(cmd, "@Adjustment", DbType.Decimal, hREmployeeSalaryPaymentEntity.Adjustment);
                db.AddInParameter(cmd, "@NetPayable", DbType.Decimal, hREmployeeSalaryPaymentEntity.NetPayable);
                db.AddInParameter(cmd, "@Note", DbType.Decimal, hREmployeeSalaryPaymentEntity.Note);
                db.AddInParameter(cmd, "@Cash", DbType.Decimal, hREmployeeSalaryPaymentEntity.Cash);
                db.AddInParameter(cmd, "@BankAmount", DbType.Decimal, hREmployeeSalaryPaymentEntity.BankAmount);
                db.AddInParameter(cmd, "@SalaryPayable", DbType.Decimal, hREmployeeSalaryPaymentEntity.SalaryPayable);
                db.AddInParameter(cmd, "@Allowance", DbType.Decimal, hREmployeeSalaryPaymentEntity.Allowance);
                db.AddInParameter(cmd, "@ProjectActual", DbType.Decimal, hREmployeeSalaryPaymentEntity.ProjectActual);
                db.AddInParameter(cmd, "@Bonus", DbType.Decimal, hREmployeeSalaryPaymentEntity.Bonus);
                db.AddInParameter(cmd, "@PhoneCeiling", DbType.Decimal, hREmployeeSalaryPaymentEntity.PhoneCeiling);
                db.AddInParameter(cmd, "@PhoneActualBill", DbType.Decimal, hREmployeeSalaryPaymentEntity.PhoneActualBill);
                db.AddInParameter(cmd, "@PhoneBillAdjustment", DbType.Decimal, hREmployeeSalaryPaymentEntity.PhoneBillAdjustment);
                db.AddInParameter(cmd, "@ProvidentFundDeductedAmount", DbType.Decimal, hREmployeeSalaryPaymentEntity.ProvidentFundDeductedAmount);
                db.AddInParameter(cmd, "@PBR", DbType.Decimal, hREmployeeSalaryPaymentEntity.PBR);
                db.AddInParameter(cmd, "@EBR", DbType.Decimal, hREmployeeSalaryPaymentEntity.EBR);
                db.AddInParameter(cmd, "@PhoneBill", DbType.Decimal, hREmployeeSalaryPaymentEntity.PhoneBill);
                db.AddInParameter(cmd, "@EmployeeSalaryPaymentStatusID", DbType.Int64, hREmployeeSalaryPaymentEntity.EmployeeSalaryPaymentStatusID);
                db.AddInParameter(cmd, "@SalaryLevel", DbType.Int64, hREmployeeSalaryPaymentEntity.SalaryLevel);	
                db.AddInParameter(cmd, "@Field2", DbType.String, hREmployeeSalaryPaymentEntity.Field2);
                db.AddInParameter(cmd, "@Field3", DbType.String, hREmployeeSalaryPaymentEntity.Field3);
                db.AddInParameter(cmd, "@Field4", DbType.String, hREmployeeSalaryPaymentEntity.Field4);
                db.AddInParameter(cmd, "@TBR", DbType.Decimal, hREmployeeSalaryPaymentEntity.TBR);
                db.AddInParameter(cmd, "@TAX", DbType.Decimal, hREmployeeSalaryPaymentEntity.TAX);

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

        IList<Int64> IHREmployeeSalaryPaymentDataAccess.Add(IList<HREmployeeSalaryPaymentEntity> hREmployeeSalaryPaymentEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity in hREmployeeSalaryPaymentEntityList)
            {
                returnCode = (this as IHREmployeeSalaryPaymentDataAccess).Add(hREmployeeSalaryPaymentEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeSalaryPaymentDataAccess.Update(HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeSalaryPaymentEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeSalaryPaymentEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryPayment_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeSalaryPaymentID", DbType.Int64, hREmployeeSalaryPaymentEntity.EmployeeSalaryPaymentID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryPaymentEntity.EmployeeID);
                Database.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, hREmployeeSalaryPaymentEntity.EmployeeJobTypeID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, hREmployeeSalaryPaymentEntity.ProjectID);
                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, hREmployeeSalaryPaymentEntity.DepartmentID);
                Database.AddInParameter(cmd, "@DesignationID", DbType.Int64, hREmployeeSalaryPaymentEntity.DesignationID);
                Database.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeSalaryPaymentEntity.EmployeeCode);
                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeSalaryPaymentEntity.SalarySessionID);
                Database.AddInParameter(cmd, "@SalarySessionStartDate", DbType.DateTime, hREmployeeSalaryPaymentEntity.SalarySessionStartDate);
                Database.AddInParameter(cmd, "@SalarySessionEndDate", DbType.DateTime, hREmployeeSalaryPaymentEntity.SalarySessionEndDate);
                Database.AddInParameter(cmd, "@ConsolidateSalaryAmount", DbType.Decimal, hREmployeeSalaryPaymentEntity.ConsolidateSalaryAmount);
                Database.AddInParameter(cmd, "@Workdays", DbType.Decimal, hREmployeeSalaryPaymentEntity.Workdays);
                Database.AddInParameter(cmd, "@Advance", DbType.Decimal, hREmployeeSalaryPaymentEntity.Advance);
                Database.AddInParameter(cmd, "@Fine", DbType.Decimal, hREmployeeSalaryPaymentEntity.Fine);
                Database.AddInParameter(cmd, "@Meals", DbType.Decimal, hREmployeeSalaryPaymentEntity.Meals);
                Database.AddInParameter(cmd, "@AIT", DbType.Decimal, hREmployeeSalaryPaymentEntity.AIT);
                Database.AddInParameter(cmd, "@Adjustment", DbType.Decimal, hREmployeeSalaryPaymentEntity.Adjustment);
                Database.AddInParameter(cmd, "@NetPayable", DbType.Decimal, hREmployeeSalaryPaymentEntity.NetPayable);
                Database.AddInParameter(cmd, "@Note", DbType.Decimal, hREmployeeSalaryPaymentEntity.Note);
                Database.AddInParameter(cmd, "@Cash", DbType.Decimal, hREmployeeSalaryPaymentEntity.Cash);
                Database.AddInParameter(cmd, "@BankAmount", DbType.Decimal, hREmployeeSalaryPaymentEntity.BankAmount);
                Database.AddInParameter(cmd, "@SalaryPayable", DbType.Decimal, hREmployeeSalaryPaymentEntity.SalaryPayable);
                Database.AddInParameter(cmd, "@Allowance", DbType.Decimal, hREmployeeSalaryPaymentEntity.Allowance);
                Database.AddInParameter(cmd, "@ProjectActual", DbType.Decimal, hREmployeeSalaryPaymentEntity.ProjectActual);
                Database.AddInParameter(cmd, "@Bonus", DbType.Decimal, hREmployeeSalaryPaymentEntity.Bonus);
                Database.AddInParameter(cmd, "@PhoneCeiling", DbType.Decimal, hREmployeeSalaryPaymentEntity.PhoneCeiling);
                Database.AddInParameter(cmd, "@PhoneActualBill", DbType.Decimal, hREmployeeSalaryPaymentEntity.PhoneActualBill);
                Database.AddInParameter(cmd, "@PhoneBillAdjustment", DbType.Decimal, hREmployeeSalaryPaymentEntity.PhoneBillAdjustment);
                Database.AddInParameter(cmd, "@ProvidentFundDeductedAmount", DbType.Decimal, hREmployeeSalaryPaymentEntity.ProvidentFundDeductedAmount);
                Database.AddInParameter(cmd, "@PBR", DbType.Decimal, hREmployeeSalaryPaymentEntity.PBR);
                Database.AddInParameter(cmd, "@EBR", DbType.Decimal, hREmployeeSalaryPaymentEntity.EBR);
                Database.AddInParameter(cmd, "@PhoneBill", DbType.Decimal, hREmployeeSalaryPaymentEntity.PhoneBill);
                Database.AddInParameter(cmd, "@EmployeeSalaryPaymentStatusID", DbType.Int64, hREmployeeSalaryPaymentEntity.EmployeeSalaryPaymentStatusID);
                Database.AddInParameter(cmd, "@SalaryLevel", DbType.Int64, hREmployeeSalaryPaymentEntity.SalaryLevel);	
                Database.AddInParameter(cmd, "@Field2", DbType.String, hREmployeeSalaryPaymentEntity.Field2);
                Database.AddInParameter(cmd, "@Field3", DbType.String, hREmployeeSalaryPaymentEntity.Field3);
                Database.AddInParameter(cmd, "@Field4", DbType.String, hREmployeeSalaryPaymentEntity.Field4);
                Database.AddInParameter(cmd, "@TBR", DbType.Decimal, hREmployeeSalaryPaymentEntity.TBR);
                Database.AddInParameter(cmd, "@TAX", DbType.Decimal, hREmployeeSalaryPaymentEntity.TAX);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeSalaryPaymentEntity already exists. Please specify another HREmployeeSalaryPaymentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalaryPaymentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalaryPaymentEntity already exists. Please specify another HREmployeeSalaryPaymentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryPayment_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeSalaryPaymentID", DbType.Int64, hREmployeeSalaryPaymentEntity.EmployeeSalaryPaymentID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSalaryPaymentEntity.EmployeeID);
                db.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, hREmployeeSalaryPaymentEntity.EmployeeJobTypeID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, hREmployeeSalaryPaymentEntity.ProjectID);
                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, hREmployeeSalaryPaymentEntity.DepartmentID);
                db.AddInParameter(cmd, "@DesignationID", DbType.Int64, hREmployeeSalaryPaymentEntity.DesignationID);
                db.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeSalaryPaymentEntity.EmployeeCode);
                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeSalaryPaymentEntity.SalarySessionID);
                db.AddInParameter(cmd, "@SalarySessionStartDate", DbType.DateTime, hREmployeeSalaryPaymentEntity.SalarySessionStartDate);
                db.AddInParameter(cmd, "@SalarySessionEndDate", DbType.DateTime, hREmployeeSalaryPaymentEntity.SalarySessionEndDate);
                db.AddInParameter(cmd, "@ConsolidateSalaryAmount", DbType.Decimal, hREmployeeSalaryPaymentEntity.ConsolidateSalaryAmount);
                db.AddInParameter(cmd, "@Workdays", DbType.Decimal, hREmployeeSalaryPaymentEntity.Workdays);
                db.AddInParameter(cmd, "@Advance", DbType.Decimal, hREmployeeSalaryPaymentEntity.Advance);
                db.AddInParameter(cmd, "@Fine", DbType.Decimal, hREmployeeSalaryPaymentEntity.Fine);
                db.AddInParameter(cmd, "@Meals", DbType.Decimal, hREmployeeSalaryPaymentEntity.Meals);
                db.AddInParameter(cmd, "@AIT", DbType.Decimal, hREmployeeSalaryPaymentEntity.AIT);
                db.AddInParameter(cmd, "@Adjustment", DbType.Decimal, hREmployeeSalaryPaymentEntity.Adjustment);
                db.AddInParameter(cmd, "@NetPayable", DbType.Decimal, hREmployeeSalaryPaymentEntity.NetPayable);
                db.AddInParameter(cmd, "@Note", DbType.Decimal, hREmployeeSalaryPaymentEntity.Note);
                db.AddInParameter(cmd, "@Cash", DbType.Decimal, hREmployeeSalaryPaymentEntity.Cash);
                db.AddInParameter(cmd, "@BankAmount", DbType.Decimal, hREmployeeSalaryPaymentEntity.BankAmount);
                db.AddInParameter(cmd, "@SalaryPayable", DbType.Decimal, hREmployeeSalaryPaymentEntity.SalaryPayable);
                db.AddInParameter(cmd, "@Allowance", DbType.Decimal, hREmployeeSalaryPaymentEntity.Allowance);
                db.AddInParameter(cmd, "@ProjectActual", DbType.Decimal, hREmployeeSalaryPaymentEntity.ProjectActual);
                db.AddInParameter(cmd, "@Bonus", DbType.Decimal, hREmployeeSalaryPaymentEntity.Bonus);
                db.AddInParameter(cmd, "@PhoneCeiling", DbType.Decimal, hREmployeeSalaryPaymentEntity.PhoneCeiling);
                db.AddInParameter(cmd, "@PhoneActualBill", DbType.Decimal, hREmployeeSalaryPaymentEntity.PhoneActualBill);
                db.AddInParameter(cmd, "@PhoneBillAdjustment", DbType.Decimal, hREmployeeSalaryPaymentEntity.PhoneBillAdjustment);
                db.AddInParameter(cmd, "@ProvidentFundDeductedAmount", DbType.Decimal, hREmployeeSalaryPaymentEntity.ProvidentFundDeductedAmount);
                db.AddInParameter(cmd, "@PBR", DbType.Decimal, hREmployeeSalaryPaymentEntity.PBR);
                db.AddInParameter(cmd, "@EBR", DbType.Decimal, hREmployeeSalaryPaymentEntity.EBR);
                db.AddInParameter(cmd, "@PhoneBill", DbType.Decimal, hREmployeeSalaryPaymentEntity.PhoneBill);
                db.AddInParameter(cmd, "@EmployeeSalaryPaymentStatusID", DbType.Int64, hREmployeeSalaryPaymentEntity.EmployeeSalaryPaymentStatusID);
                db.AddInParameter(cmd, "@SalaryLevel", DbType.Int64, hREmployeeSalaryPaymentEntity.SalaryLevel);	
                db.AddInParameter(cmd, "@Field2", DbType.String, hREmployeeSalaryPaymentEntity.Field2);
                db.AddInParameter(cmd, "@Field3", DbType.String, hREmployeeSalaryPaymentEntity.Field3);
                db.AddInParameter(cmd, "@Field4", DbType.String, hREmployeeSalaryPaymentEntity.Field4);
                db.AddInParameter(cmd, "@TBR", DbType.Decimal, hREmployeeSalaryPaymentEntity.TBR);
                db.AddInParameter(cmd, "@TAX", DbType.Decimal, hREmployeeSalaryPaymentEntity.TAX);

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

        IList<Int64> IHREmployeeSalaryPaymentDataAccess.Update(IList<HREmployeeSalaryPaymentEntity> hREmployeeSalaryPaymentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity in hREmployeeSalaryPaymentEntityList)
            {
                returnCode = (this as IHREmployeeSalaryPaymentDataAccess).Update(hREmployeeSalaryPaymentEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeSalaryPaymentDataAccess.Delete(HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeSalaryPaymentEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeSalaryPaymentEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryPayment_SET";

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
                                throw new ArgumentException("HREmployeeSalaryPaymentEntity already exists. Please specify another HREmployeeSalaryPaymentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalaryPaymentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalaryPaymentEntity already exists. Please specify another HREmployeeSalaryPaymentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalaryPayment_SET";

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

        IList<Int64> IHREmployeeSalaryPaymentDataAccess.Delete(IList<HREmployeeSalaryPaymentEntity> hREmployeeSalaryPaymentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity in hREmployeeSalaryPaymentEntityList)
            {
                returnCode = (this as IHREmployeeSalaryPaymentDataAccess).Delete(hREmployeeSalaryPaymentEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeSalaryPaymentEntity> IHREmployeeSalaryPaymentDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeSalaryPayment_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeSalaryPaymentEntity> list = CreateEntityBuilder<HREmployeeSalaryPaymentEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeSalaryPaymentDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeSalaryPayment_GET";

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
