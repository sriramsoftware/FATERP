// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-May-2013, 02:30:30




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
    internal sealed partial class CRMPaymentCollectionDataAccess : BaseDataAccess, ICRMPaymentCollectionDataAccess
    {
        #region Constructors

        public CRMPaymentCollectionDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMPaymentCollectionEntity> CreateEntityBuilder<CRMPaymentCollectionEntity>()
        {
            return (new CRMPaymentCollectionBuilder()) as IEntityBuilder<CRMPaymentCollectionEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICRMPaymentCollectionDataAccess.Add(CRMPaymentCollectionEntity cRMPaymentCollectionEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cRMPaymentCollectionEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cRMPaymentCollectionEntity, option);
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

        private Int64 Add(CRMPaymentCollectionEntity cRMPaymentCollectionEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMPaymentCollection_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "PaymentCollectionID");

                Database.AddInParameter(cmd, "@PaymentScheduleMapID", DbType.Int64, cRMPaymentCollectionEntity.PaymentScheduleMapID);	
                Database.AddInParameter(cmd, "@PaymentScheduleID", DbType.Int64, cRMPaymentCollectionEntity.PaymentScheduleID);	
                Database.AddInParameter(cmd, "@AgreementTypeID", DbType.Int64, cRMPaymentCollectionEntity.AgreementTypeID);	
                Database.AddInParameter(cmd, "@MoneyReceiptNo", DbType.Decimal, cRMPaymentCollectionEntity.MoneyReceiptNo);	
                Database.AddInParameter(cmd, "@ActualPaymentDate", DbType.DateTime, cRMPaymentCollectionEntity.ActualPaymentDate);	
                Database.AddInParameter(cmd, "@PaymentDescription", DbType.String, cRMPaymentCollectionEntity.PaymentDescription);	
                Database.AddInParameter(cmd, "@InstallmentPaymentAmount", DbType.Decimal, cRMPaymentCollectionEntity.InstallmentPaymentAmount);	
                Database.AddInParameter(cmd, "@InstallmentPaymentInWord", DbType.String, cRMPaymentCollectionEntity.InstallmentPaymentInWord);	
                Database.AddInParameter(cmd, "@InitialAmountInAgreement", DbType.Decimal, cRMPaymentCollectionEntity.InitialAmountInAgreement);	
                Database.AddInParameter(cmd, "@OverDueAmount", DbType.Decimal, cRMPaymentCollectionEntity.OverDueAmount);	
                Database.AddInParameter(cmd, "@DelayDayOnPayment", DbType.Decimal, cRMPaymentCollectionEntity.DelayDayOnPayment);	
                Database.AddInParameter(cmd, "@DelayDayOnOverDue", DbType.Decimal, cRMPaymentCollectionEntity.DelayDayOnOverDue);	
                Database.AddInParameter(cmd, "@PaymentReceivedInBank", DbType.Decimal, cRMPaymentCollectionEntity.PaymentReceivedInBank);	
                Database.AddInParameter(cmd, "@PaymentNotReceivedNote", DbType.String, cRMPaymentCollectionEntity.PaymentNotReceivedNote);	
                Database.AddInParameter(cmd, "@AgreementID", DbType.Int64, cRMPaymentCollectionEntity.AgreementID);	
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, cRMPaymentCollectionEntity.ProjectID);	
                Database.AddInParameter(cmd, "@ReverseEntry", DbType.Boolean, cRMPaymentCollectionEntity.ReverseEntry);	
                Database.AddInParameter(cmd, "@LastPayment", DbType.Boolean, cRMPaymentCollectionEntity.LastPayment);	
                Database.AddInParameter(cmd, "@DiscountAmount", DbType.Decimal, cRMPaymentCollectionEntity.DiscountAmount);	
                Database.AddInParameter(cmd, "@Vat", DbType.Decimal, cRMPaymentCollectionEntity.Vat);	
                Database.AddInParameter(cmd, "@Tax", DbType.Decimal, cRMPaymentCollectionEntity.Tax);	
                Database.AddInParameter(cmd, "@ServiceCharge", DbType.Decimal, cRMPaymentCollectionEntity.ServiceCharge);	
                Database.AddInParameter(cmd, "@AdditionalFee", DbType.Decimal, cRMPaymentCollectionEntity.AdditionalFee);	
                Database.AddInParameter(cmd, "@GrossAmount", DbType.Decimal, cRMPaymentCollectionEntity.GrossAmount);	
                Database.AddInParameter(cmd, "@NetAmount", DbType.Decimal, cRMPaymentCollectionEntity.NetAmount);	
                Database.AddInParameter(cmd, "@PaymentApprovalStatusID", DbType.Int64, cRMPaymentCollectionEntity.PaymentApprovalStatusID);	
                Database.AddInParameter(cmd, "@PaymentCategoryID", DbType.Int64, cRMPaymentCollectionEntity.PaymentCategoryID);	
                Database.AddInParameter(cmd, "@ExtraField", DbType.String, cRMPaymentCollectionEntity.ExtraField);	
                Database.AddInParameter(cmd, "@CashOrChequeNo", DbType.String, cRMPaymentCollectionEntity.CashOrChequeNo);	
                Database.AddInParameter(cmd, "@CashOrChequeDate", DbType.DateTime, cRMPaymentCollectionEntity.CashOrChequeDate);	
                Database.AddInParameter(cmd, "@BankName", DbType.String, cRMPaymentCollectionEntity.BankName);	
                Database.AddInParameter(cmd, "@BranchName", DbType.String, cRMPaymentCollectionEntity.BranchName);	
                Database.AddInParameter(cmd, "@ChequeInCashConfirmation", DbType.Boolean, cRMPaymentCollectionEntity.ChequeInCashConfirmation);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMPaymentCollectionEntity.Remarks);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMPaymentCollectionEntity.CreateDate);	
                Database.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, cRMPaymentCollectionEntity.CreateByEmployeeID);	
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMPaymentCollectionEntity.IP);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMPaymentCollectionEntity already exists. Please specify another CRMPaymentCollectionEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMPaymentCollectionEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMPaymentCollectionEntity already exists. Please specify another CRMPaymentCollectionEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CRMPaymentCollectionEntity cRMPaymentCollectionEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMPaymentCollection_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "PaymentCollectionID", db);

                db.AddInParameter(cmd, "@PaymentScheduleMapID", DbType.Int64, cRMPaymentCollectionEntity.PaymentScheduleMapID);
                db.AddInParameter(cmd, "@PaymentScheduleID", DbType.Int64, cRMPaymentCollectionEntity.PaymentScheduleID);
                db.AddInParameter(cmd, "@AgreementTypeID", DbType.Int64, cRMPaymentCollectionEntity.AgreementTypeID);
                db.AddInParameter(cmd, "@MoneyReceiptNo", DbType.Decimal, cRMPaymentCollectionEntity.MoneyReceiptNo);
                db.AddInParameter(cmd, "@ActualPaymentDate", DbType.DateTime, cRMPaymentCollectionEntity.ActualPaymentDate);
                db.AddInParameter(cmd, "@PaymentDescription", DbType.String, cRMPaymentCollectionEntity.PaymentDescription);
                db.AddInParameter(cmd, "@InstallmentPaymentAmount", DbType.Decimal, cRMPaymentCollectionEntity.InstallmentPaymentAmount);
                db.AddInParameter(cmd, "@InstallmentPaymentInWord", DbType.String, cRMPaymentCollectionEntity.InstallmentPaymentInWord);
                db.AddInParameter(cmd, "@InitialAmountInAgreement", DbType.Decimal, cRMPaymentCollectionEntity.InitialAmountInAgreement);
                db.AddInParameter(cmd, "@OverDueAmount", DbType.Decimal, cRMPaymentCollectionEntity.OverDueAmount);
                db.AddInParameter(cmd, "@DelayDayOnPayment", DbType.Decimal, cRMPaymentCollectionEntity.DelayDayOnPayment);
                db.AddInParameter(cmd, "@DelayDayOnOverDue", DbType.Decimal, cRMPaymentCollectionEntity.DelayDayOnOverDue);
                db.AddInParameter(cmd, "@PaymentReceivedInBank", DbType.Decimal, cRMPaymentCollectionEntity.PaymentReceivedInBank);
                db.AddInParameter(cmd, "@PaymentNotReceivedNote", DbType.String, cRMPaymentCollectionEntity.PaymentNotReceivedNote);
                db.AddInParameter(cmd, "@AgreementID", DbType.Int64, cRMPaymentCollectionEntity.AgreementID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, cRMPaymentCollectionEntity.ProjectID);
                db.AddInParameter(cmd, "@ReverseEntry", DbType.Boolean, cRMPaymentCollectionEntity.ReverseEntry);
                db.AddInParameter(cmd, "@LastPayment", DbType.Boolean, cRMPaymentCollectionEntity.LastPayment);
                db.AddInParameter(cmd, "@DiscountAmount", DbType.Decimal, cRMPaymentCollectionEntity.DiscountAmount);
                db.AddInParameter(cmd, "@Vat", DbType.Decimal, cRMPaymentCollectionEntity.Vat);
                db.AddInParameter(cmd, "@Tax", DbType.Decimal, cRMPaymentCollectionEntity.Tax);
                db.AddInParameter(cmd, "@ServiceCharge", DbType.Decimal, cRMPaymentCollectionEntity.ServiceCharge);
                db.AddInParameter(cmd, "@AdditionalFee", DbType.Decimal, cRMPaymentCollectionEntity.AdditionalFee);
                db.AddInParameter(cmd, "@GrossAmount", DbType.Decimal, cRMPaymentCollectionEntity.GrossAmount);
                db.AddInParameter(cmd, "@NetAmount", DbType.Decimal, cRMPaymentCollectionEntity.NetAmount);
                db.AddInParameter(cmd, "@PaymentApprovalStatusID", DbType.Int64, cRMPaymentCollectionEntity.PaymentApprovalStatusID);
                db.AddInParameter(cmd, "@PaymentCategoryID", DbType.Int64, cRMPaymentCollectionEntity.PaymentCategoryID);
                db.AddInParameter(cmd, "@ExtraField", DbType.String, cRMPaymentCollectionEntity.ExtraField);
                db.AddInParameter(cmd, "@CashOrChequeNo", DbType.String, cRMPaymentCollectionEntity.CashOrChequeNo);
                db.AddInParameter(cmd, "@CashOrChequeDate", DbType.DateTime, cRMPaymentCollectionEntity.CashOrChequeDate);
                db.AddInParameter(cmd, "@BankName", DbType.String, cRMPaymentCollectionEntity.BankName);
                db.AddInParameter(cmd, "@BranchName", DbType.String, cRMPaymentCollectionEntity.BranchName);
                db.AddInParameter(cmd, "@ChequeInCashConfirmation", DbType.Boolean, cRMPaymentCollectionEntity.ChequeInCashConfirmation);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMPaymentCollectionEntity.Remarks);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMPaymentCollectionEntity.CreateDate);
                db.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, cRMPaymentCollectionEntity.CreateByEmployeeID);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMPaymentCollectionEntity.IP);

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

        IList<Int64> ICRMPaymentCollectionDataAccess.Add(IList<CRMPaymentCollectionEntity> cRMPaymentCollectionEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CRMPaymentCollectionEntity cRMPaymentCollectionEntity in cRMPaymentCollectionEntityList)
            {
                returnCode = (this as ICRMPaymentCollectionDataAccess).Add(cRMPaymentCollectionEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICRMPaymentCollectionDataAccess.Update(CRMPaymentCollectionEntity cRMPaymentCollectionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cRMPaymentCollectionEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cRMPaymentCollectionEntity, filterExpression, option);
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

        private Int64 Update(CRMPaymentCollectionEntity cRMPaymentCollectionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMPaymentCollection_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@PaymentCollectionID", DbType.Int64, cRMPaymentCollectionEntity.PaymentCollectionID);
                Database.AddInParameter(cmd, "@PaymentScheduleMapID", DbType.Int64, cRMPaymentCollectionEntity.PaymentScheduleMapID);
                Database.AddInParameter(cmd, "@PaymentScheduleID", DbType.Int64, cRMPaymentCollectionEntity.PaymentScheduleID);
                Database.AddInParameter(cmd, "@AgreementTypeID", DbType.Int64, cRMPaymentCollectionEntity.AgreementTypeID);
                Database.AddInParameter(cmd, "@MoneyReceiptNo", DbType.Decimal, cRMPaymentCollectionEntity.MoneyReceiptNo);
                Database.AddInParameter(cmd, "@ActualPaymentDate", DbType.DateTime, cRMPaymentCollectionEntity.ActualPaymentDate);
                Database.AddInParameter(cmd, "@PaymentDescription", DbType.String, cRMPaymentCollectionEntity.PaymentDescription);
                Database.AddInParameter(cmd, "@InstallmentPaymentAmount", DbType.Decimal, cRMPaymentCollectionEntity.InstallmentPaymentAmount);
                Database.AddInParameter(cmd, "@InstallmentPaymentInWord", DbType.String, cRMPaymentCollectionEntity.InstallmentPaymentInWord);
                Database.AddInParameter(cmd, "@InitialAmountInAgreement", DbType.Decimal, cRMPaymentCollectionEntity.InitialAmountInAgreement);
                Database.AddInParameter(cmd, "@OverDueAmount", DbType.Decimal, cRMPaymentCollectionEntity.OverDueAmount);
                Database.AddInParameter(cmd, "@DelayDayOnPayment", DbType.Decimal, cRMPaymentCollectionEntity.DelayDayOnPayment);
                Database.AddInParameter(cmd, "@DelayDayOnOverDue", DbType.Decimal, cRMPaymentCollectionEntity.DelayDayOnOverDue);
                Database.AddInParameter(cmd, "@PaymentReceivedInBank", DbType.Decimal, cRMPaymentCollectionEntity.PaymentReceivedInBank);
                Database.AddInParameter(cmd, "@PaymentNotReceivedNote", DbType.String, cRMPaymentCollectionEntity.PaymentNotReceivedNote);
                Database.AddInParameter(cmd, "@AgreementID", DbType.Int64, cRMPaymentCollectionEntity.AgreementID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, cRMPaymentCollectionEntity.ProjectID);
                Database.AddInParameter(cmd, "@ReverseEntry", DbType.Boolean, cRMPaymentCollectionEntity.ReverseEntry);
                Database.AddInParameter(cmd, "@LastPayment", DbType.Boolean, cRMPaymentCollectionEntity.LastPayment);
                Database.AddInParameter(cmd, "@DiscountAmount", DbType.Decimal, cRMPaymentCollectionEntity.DiscountAmount);
                Database.AddInParameter(cmd, "@Vat", DbType.Decimal, cRMPaymentCollectionEntity.Vat);
                Database.AddInParameter(cmd, "@Tax", DbType.Decimal, cRMPaymentCollectionEntity.Tax);
                Database.AddInParameter(cmd, "@ServiceCharge", DbType.Decimal, cRMPaymentCollectionEntity.ServiceCharge);
                Database.AddInParameter(cmd, "@AdditionalFee", DbType.Decimal, cRMPaymentCollectionEntity.AdditionalFee);
                Database.AddInParameter(cmd, "@GrossAmount", DbType.Decimal, cRMPaymentCollectionEntity.GrossAmount);
                Database.AddInParameter(cmd, "@NetAmount", DbType.Decimal, cRMPaymentCollectionEntity.NetAmount);
                Database.AddInParameter(cmd, "@PaymentApprovalStatusID", DbType.Int64, cRMPaymentCollectionEntity.PaymentApprovalStatusID);
                Database.AddInParameter(cmd, "@PaymentCategoryID", DbType.Int64, cRMPaymentCollectionEntity.PaymentCategoryID);
                Database.AddInParameter(cmd, "@ExtraField", DbType.String, cRMPaymentCollectionEntity.ExtraField);
                Database.AddInParameter(cmd, "@CashOrChequeNo", DbType.String, cRMPaymentCollectionEntity.CashOrChequeNo);
                Database.AddInParameter(cmd, "@CashOrChequeDate", DbType.DateTime, cRMPaymentCollectionEntity.CashOrChequeDate);
                Database.AddInParameter(cmd, "@BankName", DbType.String, cRMPaymentCollectionEntity.BankName);
                Database.AddInParameter(cmd, "@BranchName", DbType.String, cRMPaymentCollectionEntity.BranchName);
                Database.AddInParameter(cmd, "@ChequeInCashConfirmation", DbType.Boolean, cRMPaymentCollectionEntity.ChequeInCashConfirmation);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMPaymentCollectionEntity.Remarks);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMPaymentCollectionEntity.CreateDate);
                Database.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, cRMPaymentCollectionEntity.CreateByEmployeeID);
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMPaymentCollectionEntity.IP);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMPaymentCollectionEntity already exists. Please specify another CRMPaymentCollectionEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMPaymentCollectionEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMPaymentCollectionEntity already exists. Please specify another CRMPaymentCollectionEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CRMPaymentCollectionEntity cRMPaymentCollectionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMPaymentCollection_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@PaymentCollectionID", DbType.Int64, cRMPaymentCollectionEntity.PaymentCollectionID);
                db.AddInParameter(cmd, "@PaymentScheduleMapID", DbType.Int64, cRMPaymentCollectionEntity.PaymentScheduleMapID);
                db.AddInParameter(cmd, "@PaymentScheduleID", DbType.Int64, cRMPaymentCollectionEntity.PaymentScheduleID);
                db.AddInParameter(cmd, "@AgreementTypeID", DbType.Int64, cRMPaymentCollectionEntity.AgreementTypeID);
                db.AddInParameter(cmd, "@MoneyReceiptNo", DbType.Decimal, cRMPaymentCollectionEntity.MoneyReceiptNo);
                db.AddInParameter(cmd, "@ActualPaymentDate", DbType.DateTime, cRMPaymentCollectionEntity.ActualPaymentDate);
                db.AddInParameter(cmd, "@PaymentDescription", DbType.String, cRMPaymentCollectionEntity.PaymentDescription);
                db.AddInParameter(cmd, "@InstallmentPaymentAmount", DbType.Decimal, cRMPaymentCollectionEntity.InstallmentPaymentAmount);
                db.AddInParameter(cmd, "@InstallmentPaymentInWord", DbType.String, cRMPaymentCollectionEntity.InstallmentPaymentInWord);
                db.AddInParameter(cmd, "@InitialAmountInAgreement", DbType.Decimal, cRMPaymentCollectionEntity.InitialAmountInAgreement);
                db.AddInParameter(cmd, "@OverDueAmount", DbType.Decimal, cRMPaymentCollectionEntity.OverDueAmount);
                db.AddInParameter(cmd, "@DelayDayOnPayment", DbType.Decimal, cRMPaymentCollectionEntity.DelayDayOnPayment);
                db.AddInParameter(cmd, "@DelayDayOnOverDue", DbType.Decimal, cRMPaymentCollectionEntity.DelayDayOnOverDue);
                db.AddInParameter(cmd, "@PaymentReceivedInBank", DbType.Decimal, cRMPaymentCollectionEntity.PaymentReceivedInBank);
                db.AddInParameter(cmd, "@PaymentNotReceivedNote", DbType.String, cRMPaymentCollectionEntity.PaymentNotReceivedNote);
                db.AddInParameter(cmd, "@AgreementID", DbType.Int64, cRMPaymentCollectionEntity.AgreementID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, cRMPaymentCollectionEntity.ProjectID);
                db.AddInParameter(cmd, "@ReverseEntry", DbType.Boolean, cRMPaymentCollectionEntity.ReverseEntry);
                db.AddInParameter(cmd, "@LastPayment", DbType.Boolean, cRMPaymentCollectionEntity.LastPayment);
                db.AddInParameter(cmd, "@DiscountAmount", DbType.Decimal, cRMPaymentCollectionEntity.DiscountAmount);
                db.AddInParameter(cmd, "@Vat", DbType.Decimal, cRMPaymentCollectionEntity.Vat);
                db.AddInParameter(cmd, "@Tax", DbType.Decimal, cRMPaymentCollectionEntity.Tax);
                db.AddInParameter(cmd, "@ServiceCharge", DbType.Decimal, cRMPaymentCollectionEntity.ServiceCharge);
                db.AddInParameter(cmd, "@AdditionalFee", DbType.Decimal, cRMPaymentCollectionEntity.AdditionalFee);
                db.AddInParameter(cmd, "@GrossAmount", DbType.Decimal, cRMPaymentCollectionEntity.GrossAmount);
                db.AddInParameter(cmd, "@NetAmount", DbType.Decimal, cRMPaymentCollectionEntity.NetAmount);
                db.AddInParameter(cmd, "@PaymentApprovalStatusID", DbType.Int64, cRMPaymentCollectionEntity.PaymentApprovalStatusID);
                db.AddInParameter(cmd, "@PaymentCategoryID", DbType.Int64, cRMPaymentCollectionEntity.PaymentCategoryID);
                db.AddInParameter(cmd, "@ExtraField", DbType.String, cRMPaymentCollectionEntity.ExtraField);
                db.AddInParameter(cmd, "@CashOrChequeNo", DbType.String, cRMPaymentCollectionEntity.CashOrChequeNo);
                db.AddInParameter(cmd, "@CashOrChequeDate", DbType.DateTime, cRMPaymentCollectionEntity.CashOrChequeDate);
                db.AddInParameter(cmd, "@BankName", DbType.String, cRMPaymentCollectionEntity.BankName);
                db.AddInParameter(cmd, "@BranchName", DbType.String, cRMPaymentCollectionEntity.BranchName);
                db.AddInParameter(cmd, "@ChequeInCashConfirmation", DbType.Boolean, cRMPaymentCollectionEntity.ChequeInCashConfirmation);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMPaymentCollectionEntity.Remarks);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMPaymentCollectionEntity.CreateDate);
                db.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, cRMPaymentCollectionEntity.CreateByEmployeeID);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMPaymentCollectionEntity.IP);

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

        IList<Int64> ICRMPaymentCollectionDataAccess.Update(IList<CRMPaymentCollectionEntity> cRMPaymentCollectionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CRMPaymentCollectionEntity cRMPaymentCollectionEntity in cRMPaymentCollectionEntityList)
            {
                returnCode = (this as ICRMPaymentCollectionDataAccess).Update(cRMPaymentCollectionEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICRMPaymentCollectionDataAccess.Delete(CRMPaymentCollectionEntity cRMPaymentCollectionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cRMPaymentCollectionEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cRMPaymentCollectionEntity, filterExpression, option);
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

        private Int64 Delete(CRMPaymentCollectionEntity cRMPaymentCollectionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMPaymentCollection_SET";

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
                                throw new ArgumentException("CRMPaymentCollectionEntity already exists. Please specify another CRMPaymentCollectionEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMPaymentCollectionEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMPaymentCollectionEntity already exists. Please specify another CRMPaymentCollectionEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CRMPaymentCollectionEntity cRMPaymentCollectionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMPaymentCollection_SET";

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

        IList<Int64> ICRMPaymentCollectionDataAccess.Delete(IList<CRMPaymentCollectionEntity> cRMPaymentCollectionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CRMPaymentCollectionEntity cRMPaymentCollectionEntity in cRMPaymentCollectionEntityList)
            {
                returnCode = (this as ICRMPaymentCollectionDataAccess).Delete(cRMPaymentCollectionEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CRMPaymentCollectionEntity> ICRMPaymentCollectionDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMPaymentCollection_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMPaymentCollectionEntity> list = CreateEntityBuilder<CRMPaymentCollectionEntity>().BuildEntities(reader);

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

        DataTable ICRMPaymentCollectionDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMPaymentCollection_GET";

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
