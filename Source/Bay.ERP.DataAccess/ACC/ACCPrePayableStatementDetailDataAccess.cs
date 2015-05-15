// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Dec-2012, 11:55:46




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
    internal sealed partial class ACCPrePayableStatementDetailDataAccess : BaseDataAccess, IACCPrePayableStatementDetailDataAccess
    {
        #region Constructors

        public ACCPrePayableStatementDetailDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACCPrePayableStatementDetailEntity> CreateEntityBuilder<ACCPrePayableStatementDetailEntity>()
        {
            return (new ACCPrePayableStatementDetailBuilder()) as IEntityBuilder<ACCPrePayableStatementDetailEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACCPrePayableStatementDetailDataAccess.Add(ACCPrePayableStatementDetailEntity aCCPrePayableStatementDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCCPrePayableStatementDetailEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCCPrePayableStatementDetailEntity, option);
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

        private Int64 Add(ACCPrePayableStatementDetailEntity aCCPrePayableStatementDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACCPrePayableStatementDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "PrePayableStatementDetailID");

                Database.AddInParameter(cmd, "@PrePayableStatementID", DbType.Int64, aCCPrePayableStatementDetailEntity.PrePayableStatementID);	
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCCPrePayableStatementDetailEntity.ProjectID);	
                Database.AddInParameter(cmd, "@ProjectCode", DbType.String, aCCPrePayableStatementDetailEntity.ProjectCode);	
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCCPrePayableStatementDetailEntity.WorkOrderID);	
                Database.AddInParameter(cmd, "@WorkOrderNo", DbType.String, aCCPrePayableStatementDetailEntity.WorkOrderNo);	
                Database.AddInParameter(cmd, "@WorkOrderAmount", DbType.Decimal, aCCPrePayableStatementDetailEntity.WorkOrderAmount);	
                Database.AddInParameter(cmd, "@WorkOrderDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.WorkOrderDate);	
                Database.AddInParameter(cmd, "@PaidAmount", DbType.Decimal, aCCPrePayableStatementDetailEntity.PaidAmount);	
                Database.AddInParameter(cmd, "@SecurityMoney", DbType.Decimal, aCCPrePayableStatementDetailEntity.SecurityMoney);	
                Database.AddInParameter(cmd, "@TDSAmount", DbType.Decimal, aCCPrePayableStatementDetailEntity.TDSAmount);	
                Database.AddInParameter(cmd, "@PayableAgainstWorkOrder", DbType.Decimal, aCCPrePayableStatementDetailEntity.PayableAgainstWorkOrder);	
                Database.AddInParameter(cmd, "@ApprovedBillAmount", DbType.Decimal, aCCPrePayableStatementDetailEntity.ApprovedBillAmount);	
                Database.AddInParameter(cmd, "@NetPayableConsideringBillAndSecurity", DbType.Decimal, aCCPrePayableStatementDetailEntity.NetPayableConsideringBillAndSecurity);	
                Database.AddInParameter(cmd, "@PartyReconcile", DbType.Boolean, aCCPrePayableStatementDetailEntity.PartyReconcile);	
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCCPrePayableStatementDetailEntity.RequisitionID);	
                Database.AddInParameter(cmd, "@RequisitionNo", DbType.String, aCCPrePayableStatementDetailEntity.RequisitionNo);	
                Database.AddInParameter(cmd, "@RequisitionDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.RequisitionDate);	
                Database.AddInParameter(cmd, "@BillID", DbType.Int64, aCCPrePayableStatementDetailEntity.BillID);	
                Database.AddInParameter(cmd, "@BillNo", DbType.String, aCCPrePayableStatementDetailEntity.BillNo);	
                Database.AddInParameter(cmd, "@BillDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.BillDate);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, aCCPrePayableStatementDetailEntity.Remarks);	
                Database.AddInParameter(cmd, "@Ref", DbType.String, aCCPrePayableStatementDetailEntity.Ref);	
                Database.AddInParameter(cmd, "@VendorCategoryID", DbType.Int64, aCCPrePayableStatementDetailEntity.VendorCategoryID);	
                Database.AddInParameter(cmd, "@FromVendorID", DbType.Int64, aCCPrePayableStatementDetailEntity.FromVendorID);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.CreateDate);	
                Database.AddInParameter(cmd, "@DueDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.DueDate);	
                Database.AddInParameter(cmd, "@PlannedDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.PlannedDate);	
                Database.AddInParameter(cmd, "@AdditionalRemarks", DbType.String, aCCPrePayableStatementDetailEntity.AdditionalRemarks);	
                Database.AddInParameter(cmd, "@ACCPayablePaymentStatusID", DbType.Int64, aCCPrePayableStatementDetailEntity.ACCPayablePaymentStatusID);	
                Database.AddInParameter(cmd, "@ACCPayableApprovalStatusID", DbType.Int64, aCCPrePayableStatementDetailEntity.ACCPayableApprovalStatusID);	
                Database.AddInParameter(cmd, "@AccountPaybleStatementDetailCategoryID", DbType.Int64, aCCPrePayableStatementDetailEntity.AccountPaybleStatementDetailCategoryID);	
                Database.AddInParameter(cmd, "@PayableClassificationID", DbType.Int64, aCCPrePayableStatementDetailEntity.PayableClassificationID);	
                Database.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, aCCPrePayableStatementDetailEntity.CreateByEmployeeID);	
                Database.AddInParameter(cmd, "@APPanelID", DbType.Int64, aCCPrePayableStatementDetailEntity.APPanelID);	
                Database.AddInParameter(cmd, "@IPAddress", DbType.String, aCCPrePayableStatementDetailEntity.IPAddress);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCCPrePayableStatementDetailEntity.IsRemoved);	
                Database.AddInParameter(cmd, "@IsLocked", DbType.Boolean, aCCPrePayableStatementDetailEntity.IsLocked);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACCPrePayableStatementDetailEntity already exists. Please specify another ACCPrePayableStatementDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACCPrePayableStatementDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACCPrePayableStatementDetailEntity already exists. Please specify another ACCPrePayableStatementDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACCPrePayableStatementDetailEntity aCCPrePayableStatementDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACCPrePayableStatementDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "PrePayableStatementDetailID", db);

                db.AddInParameter(cmd, "@PrePayableStatementID", DbType.Int64, aCCPrePayableStatementDetailEntity.PrePayableStatementID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCCPrePayableStatementDetailEntity.ProjectID);
                db.AddInParameter(cmd, "@ProjectCode", DbType.String, aCCPrePayableStatementDetailEntity.ProjectCode);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCCPrePayableStatementDetailEntity.WorkOrderID);
                db.AddInParameter(cmd, "@WorkOrderNo", DbType.String, aCCPrePayableStatementDetailEntity.WorkOrderNo);
                db.AddInParameter(cmd, "@WorkOrderAmount", DbType.Decimal, aCCPrePayableStatementDetailEntity.WorkOrderAmount);
                db.AddInParameter(cmd, "@WorkOrderDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.WorkOrderDate);
                db.AddInParameter(cmd, "@PaidAmount", DbType.Decimal, aCCPrePayableStatementDetailEntity.PaidAmount);
                db.AddInParameter(cmd, "@SecurityMoney", DbType.Decimal, aCCPrePayableStatementDetailEntity.SecurityMoney);
                db.AddInParameter(cmd, "@TDSAmount", DbType.Decimal, aCCPrePayableStatementDetailEntity.TDSAmount);
                db.AddInParameter(cmd, "@PayableAgainstWorkOrder", DbType.Decimal, aCCPrePayableStatementDetailEntity.PayableAgainstWorkOrder);
                db.AddInParameter(cmd, "@ApprovedBillAmount", DbType.Decimal, aCCPrePayableStatementDetailEntity.ApprovedBillAmount);
                db.AddInParameter(cmd, "@NetPayableConsideringBillAndSecurity", DbType.Decimal, aCCPrePayableStatementDetailEntity.NetPayableConsideringBillAndSecurity);
                db.AddInParameter(cmd, "@PartyReconcile", DbType.Boolean, aCCPrePayableStatementDetailEntity.PartyReconcile);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCCPrePayableStatementDetailEntity.RequisitionID);
                db.AddInParameter(cmd, "@RequisitionNo", DbType.String, aCCPrePayableStatementDetailEntity.RequisitionNo);
                db.AddInParameter(cmd, "@RequisitionDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.RequisitionDate);
                db.AddInParameter(cmd, "@BillID", DbType.Int64, aCCPrePayableStatementDetailEntity.BillID);
                db.AddInParameter(cmd, "@BillNo", DbType.String, aCCPrePayableStatementDetailEntity.BillNo);
                db.AddInParameter(cmd, "@BillDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.BillDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, aCCPrePayableStatementDetailEntity.Remarks);
                db.AddInParameter(cmd, "@Ref", DbType.String, aCCPrePayableStatementDetailEntity.Ref);
                db.AddInParameter(cmd, "@VendorCategoryID", DbType.Int64, aCCPrePayableStatementDetailEntity.VendorCategoryID);
                db.AddInParameter(cmd, "@FromVendorID", DbType.Int64, aCCPrePayableStatementDetailEntity.FromVendorID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.CreateDate);
                db.AddInParameter(cmd, "@DueDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.DueDate);
                db.AddInParameter(cmd, "@PlannedDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.PlannedDate);
                db.AddInParameter(cmd, "@AdditionalRemarks", DbType.String, aCCPrePayableStatementDetailEntity.AdditionalRemarks);
                db.AddInParameter(cmd, "@ACCPayablePaymentStatusID", DbType.Int64, aCCPrePayableStatementDetailEntity.ACCPayablePaymentStatusID);
                db.AddInParameter(cmd, "@ACCPayableApprovalStatusID", DbType.Int64, aCCPrePayableStatementDetailEntity.ACCPayableApprovalStatusID);
                db.AddInParameter(cmd, "@AccountPaybleStatementDetailCategoryID", DbType.Int64, aCCPrePayableStatementDetailEntity.AccountPaybleStatementDetailCategoryID);
                db.AddInParameter(cmd, "@PayableClassificationID", DbType.Int64, aCCPrePayableStatementDetailEntity.PayableClassificationID);
                db.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, aCCPrePayableStatementDetailEntity.CreateByEmployeeID);
                db.AddInParameter(cmd, "@APPanelID", DbType.Int64, aCCPrePayableStatementDetailEntity.APPanelID);
                db.AddInParameter(cmd, "@IPAddress", DbType.String, aCCPrePayableStatementDetailEntity.IPAddress);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCCPrePayableStatementDetailEntity.IsRemoved);
                db.AddInParameter(cmd, "@IsLocked", DbType.Boolean, aCCPrePayableStatementDetailEntity.IsLocked);

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

        IList<Int64> IACCPrePayableStatementDetailDataAccess.Add(IList<ACCPrePayableStatementDetailEntity> aCCPrePayableStatementDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACCPrePayableStatementDetailEntity aCCPrePayableStatementDetailEntity in aCCPrePayableStatementDetailEntityList)
            {
                returnCode = (this as IACCPrePayableStatementDetailDataAccess).Add(aCCPrePayableStatementDetailEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACCPrePayableStatementDetailDataAccess.Update(ACCPrePayableStatementDetailEntity aCCPrePayableStatementDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCCPrePayableStatementDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCCPrePayableStatementDetailEntity, filterExpression, option);
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

        private Int64 Update(ACCPrePayableStatementDetailEntity aCCPrePayableStatementDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACCPrePayableStatementDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@PrePayableStatementDetailID", DbType.Int64, aCCPrePayableStatementDetailEntity.PrePayableStatementDetailID);
                Database.AddInParameter(cmd, "@PrePayableStatementID", DbType.Int64, aCCPrePayableStatementDetailEntity.PrePayableStatementID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCCPrePayableStatementDetailEntity.ProjectID);
                Database.AddInParameter(cmd, "@ProjectCode", DbType.String, aCCPrePayableStatementDetailEntity.ProjectCode);
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCCPrePayableStatementDetailEntity.WorkOrderID);
                Database.AddInParameter(cmd, "@WorkOrderNo", DbType.String, aCCPrePayableStatementDetailEntity.WorkOrderNo);
                Database.AddInParameter(cmd, "@WorkOrderAmount", DbType.Decimal, aCCPrePayableStatementDetailEntity.WorkOrderAmount);
                Database.AddInParameter(cmd, "@WorkOrderDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.WorkOrderDate);
                Database.AddInParameter(cmd, "@PaidAmount", DbType.Decimal, aCCPrePayableStatementDetailEntity.PaidAmount);
                Database.AddInParameter(cmd, "@SecurityMoney", DbType.Decimal, aCCPrePayableStatementDetailEntity.SecurityMoney);
                Database.AddInParameter(cmd, "@TDSAmount", DbType.Decimal, aCCPrePayableStatementDetailEntity.TDSAmount);
                Database.AddInParameter(cmd, "@PayableAgainstWorkOrder", DbType.Decimal, aCCPrePayableStatementDetailEntity.PayableAgainstWorkOrder);
                Database.AddInParameter(cmd, "@ApprovedBillAmount", DbType.Decimal, aCCPrePayableStatementDetailEntity.ApprovedBillAmount);
                Database.AddInParameter(cmd, "@NetPayableConsideringBillAndSecurity", DbType.Decimal, aCCPrePayableStatementDetailEntity.NetPayableConsideringBillAndSecurity);
                Database.AddInParameter(cmd, "@PartyReconcile", DbType.Boolean, aCCPrePayableStatementDetailEntity.PartyReconcile);
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCCPrePayableStatementDetailEntity.RequisitionID);
                Database.AddInParameter(cmd, "@RequisitionNo", DbType.String, aCCPrePayableStatementDetailEntity.RequisitionNo);
                Database.AddInParameter(cmd, "@RequisitionDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.RequisitionDate);
                Database.AddInParameter(cmd, "@BillID", DbType.Int64, aCCPrePayableStatementDetailEntity.BillID);
                Database.AddInParameter(cmd, "@BillNo", DbType.String, aCCPrePayableStatementDetailEntity.BillNo);
                Database.AddInParameter(cmd, "@BillDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.BillDate);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, aCCPrePayableStatementDetailEntity.Remarks);
                Database.AddInParameter(cmd, "@Ref", DbType.String, aCCPrePayableStatementDetailEntity.Ref);
                Database.AddInParameter(cmd, "@VendorCategoryID", DbType.Int64, aCCPrePayableStatementDetailEntity.VendorCategoryID);
                Database.AddInParameter(cmd, "@FromVendorID", DbType.Int64, aCCPrePayableStatementDetailEntity.FromVendorID);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.CreateDate);
                Database.AddInParameter(cmd, "@DueDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.DueDate);
                Database.AddInParameter(cmd, "@PlannedDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.PlannedDate);
                Database.AddInParameter(cmd, "@AdditionalRemarks", DbType.String, aCCPrePayableStatementDetailEntity.AdditionalRemarks);
                Database.AddInParameter(cmd, "@ACCPayablePaymentStatusID", DbType.Int64, aCCPrePayableStatementDetailEntity.ACCPayablePaymentStatusID);
                Database.AddInParameter(cmd, "@ACCPayableApprovalStatusID", DbType.Int64, aCCPrePayableStatementDetailEntity.ACCPayableApprovalStatusID);
                Database.AddInParameter(cmd, "@AccountPaybleStatementDetailCategoryID", DbType.Int64, aCCPrePayableStatementDetailEntity.AccountPaybleStatementDetailCategoryID);
                Database.AddInParameter(cmd, "@PayableClassificationID", DbType.Int64, aCCPrePayableStatementDetailEntity.PayableClassificationID);
                Database.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, aCCPrePayableStatementDetailEntity.CreateByEmployeeID);
                Database.AddInParameter(cmd, "@APPanelID", DbType.Int64, aCCPrePayableStatementDetailEntity.APPanelID);
                Database.AddInParameter(cmd, "@IPAddress", DbType.String, aCCPrePayableStatementDetailEntity.IPAddress);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCCPrePayableStatementDetailEntity.IsRemoved);
                Database.AddInParameter(cmd, "@IsLocked", DbType.Boolean, aCCPrePayableStatementDetailEntity.IsLocked);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACCPrePayableStatementDetailEntity already exists. Please specify another ACCPrePayableStatementDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACCPrePayableStatementDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACCPrePayableStatementDetailEntity already exists. Please specify another ACCPrePayableStatementDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACCPrePayableStatementDetailEntity aCCPrePayableStatementDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACCPrePayableStatementDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@PrePayableStatementDetailID", DbType.Int64, aCCPrePayableStatementDetailEntity.PrePayableStatementDetailID);
                db.AddInParameter(cmd, "@PrePayableStatementID", DbType.Int64, aCCPrePayableStatementDetailEntity.PrePayableStatementID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCCPrePayableStatementDetailEntity.ProjectID);
                db.AddInParameter(cmd, "@ProjectCode", DbType.String, aCCPrePayableStatementDetailEntity.ProjectCode);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCCPrePayableStatementDetailEntity.WorkOrderID);
                db.AddInParameter(cmd, "@WorkOrderNo", DbType.String, aCCPrePayableStatementDetailEntity.WorkOrderNo);
                db.AddInParameter(cmd, "@WorkOrderAmount", DbType.Decimal, aCCPrePayableStatementDetailEntity.WorkOrderAmount);
                db.AddInParameter(cmd, "@WorkOrderDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.WorkOrderDate);
                db.AddInParameter(cmd, "@PaidAmount", DbType.Decimal, aCCPrePayableStatementDetailEntity.PaidAmount);
                db.AddInParameter(cmd, "@SecurityMoney", DbType.Decimal, aCCPrePayableStatementDetailEntity.SecurityMoney);
                db.AddInParameter(cmd, "@TDSAmount", DbType.Decimal, aCCPrePayableStatementDetailEntity.TDSAmount);
                db.AddInParameter(cmd, "@PayableAgainstWorkOrder", DbType.Decimal, aCCPrePayableStatementDetailEntity.PayableAgainstWorkOrder);
                db.AddInParameter(cmd, "@ApprovedBillAmount", DbType.Decimal, aCCPrePayableStatementDetailEntity.ApprovedBillAmount);
                db.AddInParameter(cmd, "@NetPayableConsideringBillAndSecurity", DbType.Decimal, aCCPrePayableStatementDetailEntity.NetPayableConsideringBillAndSecurity);
                db.AddInParameter(cmd, "@PartyReconcile", DbType.Boolean, aCCPrePayableStatementDetailEntity.PartyReconcile);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCCPrePayableStatementDetailEntity.RequisitionID);
                db.AddInParameter(cmd, "@RequisitionNo", DbType.String, aCCPrePayableStatementDetailEntity.RequisitionNo);
                db.AddInParameter(cmd, "@RequisitionDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.RequisitionDate);
                db.AddInParameter(cmd, "@BillID", DbType.Int64, aCCPrePayableStatementDetailEntity.BillID);
                db.AddInParameter(cmd, "@BillNo", DbType.String, aCCPrePayableStatementDetailEntity.BillNo);
                db.AddInParameter(cmd, "@BillDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.BillDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, aCCPrePayableStatementDetailEntity.Remarks);
                db.AddInParameter(cmd, "@Ref", DbType.String, aCCPrePayableStatementDetailEntity.Ref);
                db.AddInParameter(cmd, "@VendorCategoryID", DbType.Int64, aCCPrePayableStatementDetailEntity.VendorCategoryID);
                db.AddInParameter(cmd, "@FromVendorID", DbType.Int64, aCCPrePayableStatementDetailEntity.FromVendorID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.CreateDate);
                db.AddInParameter(cmd, "@DueDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.DueDate);
                db.AddInParameter(cmd, "@PlannedDate", DbType.DateTime, aCCPrePayableStatementDetailEntity.PlannedDate);
                db.AddInParameter(cmd, "@AdditionalRemarks", DbType.String, aCCPrePayableStatementDetailEntity.AdditionalRemarks);
                db.AddInParameter(cmd, "@ACCPayablePaymentStatusID", DbType.Int64, aCCPrePayableStatementDetailEntity.ACCPayablePaymentStatusID);
                db.AddInParameter(cmd, "@ACCPayableApprovalStatusID", DbType.Int64, aCCPrePayableStatementDetailEntity.ACCPayableApprovalStatusID);
                db.AddInParameter(cmd, "@AccountPaybleStatementDetailCategoryID", DbType.Int64, aCCPrePayableStatementDetailEntity.AccountPaybleStatementDetailCategoryID);
                db.AddInParameter(cmd, "@PayableClassificationID", DbType.Int64, aCCPrePayableStatementDetailEntity.PayableClassificationID);
                db.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, aCCPrePayableStatementDetailEntity.CreateByEmployeeID);
                db.AddInParameter(cmd, "@APPanelID", DbType.Int64, aCCPrePayableStatementDetailEntity.APPanelID);
                db.AddInParameter(cmd, "@IPAddress", DbType.String, aCCPrePayableStatementDetailEntity.IPAddress);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCCPrePayableStatementDetailEntity.IsRemoved);
                db.AddInParameter(cmd, "@IsLocked", DbType.Boolean, aCCPrePayableStatementDetailEntity.IsLocked);

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

        IList<Int64> IACCPrePayableStatementDetailDataAccess.Update(IList<ACCPrePayableStatementDetailEntity> aCCPrePayableStatementDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACCPrePayableStatementDetailEntity aCCPrePayableStatementDetailEntity in aCCPrePayableStatementDetailEntityList)
            {
                returnCode = (this as IACCPrePayableStatementDetailDataAccess).Update(aCCPrePayableStatementDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACCPrePayableStatementDetailDataAccess.Delete(ACCPrePayableStatementDetailEntity aCCPrePayableStatementDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCCPrePayableStatementDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCCPrePayableStatementDetailEntity, filterExpression, option);
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

        private Int64 Delete(ACCPrePayableStatementDetailEntity aCCPrePayableStatementDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACCPrePayableStatementDetail_SET";

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
                                throw new ArgumentException("ACCPrePayableStatementDetailEntity already exists. Please specify another ACCPrePayableStatementDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACCPrePayableStatementDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACCPrePayableStatementDetailEntity already exists. Please specify another ACCPrePayableStatementDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACCPrePayableStatementDetailEntity aCCPrePayableStatementDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACCPrePayableStatementDetail_SET";

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

        IList<Int64> IACCPrePayableStatementDetailDataAccess.Delete(IList<ACCPrePayableStatementDetailEntity> aCCPrePayableStatementDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACCPrePayableStatementDetailEntity aCCPrePayableStatementDetailEntity in aCCPrePayableStatementDetailEntityList)
            {
                returnCode = (this as IACCPrePayableStatementDetailDataAccess).Delete(aCCPrePayableStatementDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACCPrePayableStatementDetailEntity> IACCPrePayableStatementDetailDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACCPrePayableStatementDetail_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACCPrePayableStatementDetailEntity> list = CreateEntityBuilder<ACCPrePayableStatementDetailEntity>().BuildEntities(reader);

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

        DataTable IACCPrePayableStatementDetailDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACCPrePayableStatementDetail_GET";

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
