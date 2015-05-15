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
    internal sealed partial class ACCPostPayableStatementDetailDataAccess : BaseDataAccess, IACCPostPayableStatementDetailDataAccess
    {
        #region Constructors

        public ACCPostPayableStatementDetailDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACCPostPayableStatementDetailEntity> CreateEntityBuilder<ACCPostPayableStatementDetailEntity>()
        {
            return (new ACCPostPayableStatementDetailBuilder()) as IEntityBuilder<ACCPostPayableStatementDetailEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACCPostPayableStatementDetailDataAccess.Add(ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCCPostPayableStatementDetailEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCCPostPayableStatementDetailEntity, option);
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

        private Int64 Add(ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACCPostPayableStatementDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "PostPayableStatementDetailID");

                Database.AddInParameter(cmd, "@PostPayableStatementID", DbType.Int64, aCCPostPayableStatementDetailEntity.PostPayableStatementID);	
                Database.AddInParameter(cmd, "@PrePayableStatementDetailID", DbType.Int64, aCCPostPayableStatementDetailEntity.PrePayableStatementDetailID);	
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCCPostPayableStatementDetailEntity.ProjectID);	
                Database.AddInParameter(cmd, "@ProjectCode", DbType.String, aCCPostPayableStatementDetailEntity.ProjectCode);	
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCCPostPayableStatementDetailEntity.WorkOrderID);	
                Database.AddInParameter(cmd, "@WorkOrderNo", DbType.String, aCCPostPayableStatementDetailEntity.WorkOrderNo);	
                Database.AddInParameter(cmd, "@WorkOrderAmount", DbType.Decimal, aCCPostPayableStatementDetailEntity.WorkOrderAmount);	
                Database.AddInParameter(cmd, "@WorkOrderDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.WorkOrderDate);	
                Database.AddInParameter(cmd, "@PaidAmount", DbType.Decimal, aCCPostPayableStatementDetailEntity.PaidAmount);	
                Database.AddInParameter(cmd, "@SecurityMoney", DbType.Decimal, aCCPostPayableStatementDetailEntity.SecurityMoney);	
                Database.AddInParameter(cmd, "@TDSAmount", DbType.Decimal, aCCPostPayableStatementDetailEntity.TDSAmount);	
                Database.AddInParameter(cmd, "@PayableAgainstWorkOrder", DbType.Decimal, aCCPostPayableStatementDetailEntity.PayableAgainstWorkOrder);	
                Database.AddInParameter(cmd, "@ApprovedBillAmount", DbType.Decimal, aCCPostPayableStatementDetailEntity.ApprovedBillAmount);	
                Database.AddInParameter(cmd, "@NetPayableConsideringBillAndSecurity", DbType.Decimal, aCCPostPayableStatementDetailEntity.NetPayableConsideringBillAndSecurity);	
                Database.AddInParameter(cmd, "@PartyReconcile", DbType.Boolean, aCCPostPayableStatementDetailEntity.PartyReconcile);	
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCCPostPayableStatementDetailEntity.RequisitionID);	
                Database.AddInParameter(cmd, "@RequisitionNo", DbType.String, aCCPostPayableStatementDetailEntity.RequisitionNo);	
                Database.AddInParameter(cmd, "@RequisitionDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.RequisitionDate);	
                Database.AddInParameter(cmd, "@BillID", DbType.Int64, aCCPostPayableStatementDetailEntity.BillID);	
                Database.AddInParameter(cmd, "@BillNo", DbType.String, aCCPostPayableStatementDetailEntity.BillNo);	
                Database.AddInParameter(cmd, "@BillDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.BillDate);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, aCCPostPayableStatementDetailEntity.Remarks);	
                Database.AddInParameter(cmd, "@Ref", DbType.String, aCCPostPayableStatementDetailEntity.Ref);	
                Database.AddInParameter(cmd, "@VendorCategoryID", DbType.Int64, aCCPostPayableStatementDetailEntity.VendorCategoryID);	
                Database.AddInParameter(cmd, "@FromVendorID", DbType.Int64, aCCPostPayableStatementDetailEntity.FromVendorID);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.CreateDate);	
                Database.AddInParameter(cmd, "@DueDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.DueDate);	
                Database.AddInParameter(cmd, "@PlannedDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.PlannedDate);	
                Database.AddInParameter(cmd, "@AdditionalRemarks", DbType.String, aCCPostPayableStatementDetailEntity.AdditionalRemarks);	
                Database.AddInParameter(cmd, "@ACCPayablePaymentStatusID", DbType.Int64, aCCPostPayableStatementDetailEntity.ACCPayablePaymentStatusID);	
                Database.AddInParameter(cmd, "@ACCPayableApprovalStatusID", DbType.Int64, aCCPostPayableStatementDetailEntity.ACCPayableApprovalStatusID);	
                Database.AddInParameter(cmd, "@AccountPaybleStatementDetailCategoryID", DbType.Int64, aCCPostPayableStatementDetailEntity.AccountPaybleStatementDetailCategoryID);	
                Database.AddInParameter(cmd, "@PayableClassificationID", DbType.Int64, aCCPostPayableStatementDetailEntity.PayableClassificationID);	
                Database.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, aCCPostPayableStatementDetailEntity.CreateByEmployeeID);	
                Database.AddInParameter(cmd, "@APPanelID", DbType.Int64, aCCPostPayableStatementDetailEntity.APPanelID);	
                Database.AddInParameter(cmd, "@IPAddress", DbType.String, aCCPostPayableStatementDetailEntity.IPAddress);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCCPostPayableStatementDetailEntity.IsRemoved);	
                Database.AddInParameter(cmd, "@IsLocked", DbType.Boolean, aCCPostPayableStatementDetailEntity.IsLocked);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACCPostPayableStatementDetailEntity already exists. Please specify another ACCPostPayableStatementDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACCPostPayableStatementDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACCPostPayableStatementDetailEntity already exists. Please specify another ACCPostPayableStatementDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACCPostPayableStatementDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "PostPayableStatementDetailID", db);

                db.AddInParameter(cmd, "@PostPayableStatementID", DbType.Int64, aCCPostPayableStatementDetailEntity.PostPayableStatementID);
                db.AddInParameter(cmd, "@PrePayableStatementDetailID", DbType.Int64, aCCPostPayableStatementDetailEntity.PrePayableStatementDetailID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCCPostPayableStatementDetailEntity.ProjectID);
                db.AddInParameter(cmd, "@ProjectCode", DbType.String, aCCPostPayableStatementDetailEntity.ProjectCode);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCCPostPayableStatementDetailEntity.WorkOrderID);
                db.AddInParameter(cmd, "@WorkOrderNo", DbType.String, aCCPostPayableStatementDetailEntity.WorkOrderNo);
                db.AddInParameter(cmd, "@WorkOrderAmount", DbType.Decimal, aCCPostPayableStatementDetailEntity.WorkOrderAmount);
                db.AddInParameter(cmd, "@WorkOrderDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.WorkOrderDate);
                db.AddInParameter(cmd, "@PaidAmount", DbType.Decimal, aCCPostPayableStatementDetailEntity.PaidAmount);
                db.AddInParameter(cmd, "@SecurityMoney", DbType.Decimal, aCCPostPayableStatementDetailEntity.SecurityMoney);
                db.AddInParameter(cmd, "@TDSAmount", DbType.Decimal, aCCPostPayableStatementDetailEntity.TDSAmount);
                db.AddInParameter(cmd, "@PayableAgainstWorkOrder", DbType.Decimal, aCCPostPayableStatementDetailEntity.PayableAgainstWorkOrder);
                db.AddInParameter(cmd, "@ApprovedBillAmount", DbType.Decimal, aCCPostPayableStatementDetailEntity.ApprovedBillAmount);
                db.AddInParameter(cmd, "@NetPayableConsideringBillAndSecurity", DbType.Decimal, aCCPostPayableStatementDetailEntity.NetPayableConsideringBillAndSecurity);
                db.AddInParameter(cmd, "@PartyReconcile", DbType.Boolean, aCCPostPayableStatementDetailEntity.PartyReconcile);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCCPostPayableStatementDetailEntity.RequisitionID);
                db.AddInParameter(cmd, "@RequisitionNo", DbType.String, aCCPostPayableStatementDetailEntity.RequisitionNo);
                db.AddInParameter(cmd, "@RequisitionDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.RequisitionDate);
                db.AddInParameter(cmd, "@BillID", DbType.Int64, aCCPostPayableStatementDetailEntity.BillID);
                db.AddInParameter(cmd, "@BillNo", DbType.String, aCCPostPayableStatementDetailEntity.BillNo);
                db.AddInParameter(cmd, "@BillDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.BillDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, aCCPostPayableStatementDetailEntity.Remarks);
                db.AddInParameter(cmd, "@Ref", DbType.String, aCCPostPayableStatementDetailEntity.Ref);
                db.AddInParameter(cmd, "@VendorCategoryID", DbType.Int64, aCCPostPayableStatementDetailEntity.VendorCategoryID);
                db.AddInParameter(cmd, "@FromVendorID", DbType.Int64, aCCPostPayableStatementDetailEntity.FromVendorID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.CreateDate);
                db.AddInParameter(cmd, "@DueDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.DueDate);
                db.AddInParameter(cmd, "@PlannedDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.PlannedDate);
                db.AddInParameter(cmd, "@AdditionalRemarks", DbType.String, aCCPostPayableStatementDetailEntity.AdditionalRemarks);
                db.AddInParameter(cmd, "@ACCPayablePaymentStatusID", DbType.Int64, aCCPostPayableStatementDetailEntity.ACCPayablePaymentStatusID);
                db.AddInParameter(cmd, "@ACCPayableApprovalStatusID", DbType.Int64, aCCPostPayableStatementDetailEntity.ACCPayableApprovalStatusID);
                db.AddInParameter(cmd, "@AccountPaybleStatementDetailCategoryID", DbType.Int64, aCCPostPayableStatementDetailEntity.AccountPaybleStatementDetailCategoryID);
                db.AddInParameter(cmd, "@PayableClassificationID", DbType.Int64, aCCPostPayableStatementDetailEntity.PayableClassificationID);
                db.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, aCCPostPayableStatementDetailEntity.CreateByEmployeeID);
                db.AddInParameter(cmd, "@APPanelID", DbType.Int64, aCCPostPayableStatementDetailEntity.APPanelID);
                db.AddInParameter(cmd, "@IPAddress", DbType.String, aCCPostPayableStatementDetailEntity.IPAddress);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCCPostPayableStatementDetailEntity.IsRemoved);
                db.AddInParameter(cmd, "@IsLocked", DbType.Boolean, aCCPostPayableStatementDetailEntity.IsLocked);

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

        IList<Int64> IACCPostPayableStatementDetailDataAccess.Add(IList<ACCPostPayableStatementDetailEntity> aCCPostPayableStatementDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity in aCCPostPayableStatementDetailEntityList)
            {
                returnCode = (this as IACCPostPayableStatementDetailDataAccess).Add(aCCPostPayableStatementDetailEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACCPostPayableStatementDetailDataAccess.Update(ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCCPostPayableStatementDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCCPostPayableStatementDetailEntity, filterExpression, option);
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

        private Int64 Update(ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACCPostPayableStatementDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@PostPayableStatementDetailID", DbType.Int64, aCCPostPayableStatementDetailEntity.PostPayableStatementDetailID);
                Database.AddInParameter(cmd, "@PostPayableStatementID", DbType.Int64, aCCPostPayableStatementDetailEntity.PostPayableStatementID);
                Database.AddInParameter(cmd, "@PrePayableStatementDetailID", DbType.Int64, aCCPostPayableStatementDetailEntity.PrePayableStatementDetailID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCCPostPayableStatementDetailEntity.ProjectID);
                Database.AddInParameter(cmd, "@ProjectCode", DbType.String, aCCPostPayableStatementDetailEntity.ProjectCode);
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCCPostPayableStatementDetailEntity.WorkOrderID);
                Database.AddInParameter(cmd, "@WorkOrderNo", DbType.String, aCCPostPayableStatementDetailEntity.WorkOrderNo);
                Database.AddInParameter(cmd, "@WorkOrderAmount", DbType.Decimal, aCCPostPayableStatementDetailEntity.WorkOrderAmount);
                Database.AddInParameter(cmd, "@WorkOrderDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.WorkOrderDate);
                Database.AddInParameter(cmd, "@PaidAmount", DbType.Decimal, aCCPostPayableStatementDetailEntity.PaidAmount);
                Database.AddInParameter(cmd, "@SecurityMoney", DbType.Decimal, aCCPostPayableStatementDetailEntity.SecurityMoney);
                Database.AddInParameter(cmd, "@TDSAmount", DbType.Decimal, aCCPostPayableStatementDetailEntity.TDSAmount);
                Database.AddInParameter(cmd, "@PayableAgainstWorkOrder", DbType.Decimal, aCCPostPayableStatementDetailEntity.PayableAgainstWorkOrder);
                Database.AddInParameter(cmd, "@ApprovedBillAmount", DbType.Decimal, aCCPostPayableStatementDetailEntity.ApprovedBillAmount);
                Database.AddInParameter(cmd, "@NetPayableConsideringBillAndSecurity", DbType.Decimal, aCCPostPayableStatementDetailEntity.NetPayableConsideringBillAndSecurity);
                Database.AddInParameter(cmd, "@PartyReconcile", DbType.Boolean, aCCPostPayableStatementDetailEntity.PartyReconcile);
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCCPostPayableStatementDetailEntity.RequisitionID);
                Database.AddInParameter(cmd, "@RequisitionNo", DbType.String, aCCPostPayableStatementDetailEntity.RequisitionNo);
                Database.AddInParameter(cmd, "@RequisitionDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.RequisitionDate);
                Database.AddInParameter(cmd, "@BillID", DbType.Int64, aCCPostPayableStatementDetailEntity.BillID);
                Database.AddInParameter(cmd, "@BillNo", DbType.String, aCCPostPayableStatementDetailEntity.BillNo);
                Database.AddInParameter(cmd, "@BillDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.BillDate);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, aCCPostPayableStatementDetailEntity.Remarks);
                Database.AddInParameter(cmd, "@Ref", DbType.String, aCCPostPayableStatementDetailEntity.Ref);
                Database.AddInParameter(cmd, "@VendorCategoryID", DbType.Int64, aCCPostPayableStatementDetailEntity.VendorCategoryID);
                Database.AddInParameter(cmd, "@FromVendorID", DbType.Int64, aCCPostPayableStatementDetailEntity.FromVendorID);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.CreateDate);
                Database.AddInParameter(cmd, "@DueDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.DueDate);
                Database.AddInParameter(cmd, "@PlannedDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.PlannedDate);
                Database.AddInParameter(cmd, "@AdditionalRemarks", DbType.String, aCCPostPayableStatementDetailEntity.AdditionalRemarks);
                Database.AddInParameter(cmd, "@ACCPayablePaymentStatusID", DbType.Int64, aCCPostPayableStatementDetailEntity.ACCPayablePaymentStatusID);
                Database.AddInParameter(cmd, "@ACCPayableApprovalStatusID", DbType.Int64, aCCPostPayableStatementDetailEntity.ACCPayableApprovalStatusID);
                Database.AddInParameter(cmd, "@AccountPaybleStatementDetailCategoryID", DbType.Int64, aCCPostPayableStatementDetailEntity.AccountPaybleStatementDetailCategoryID);
                Database.AddInParameter(cmd, "@PayableClassificationID", DbType.Int64, aCCPostPayableStatementDetailEntity.PayableClassificationID);
                Database.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, aCCPostPayableStatementDetailEntity.CreateByEmployeeID);
                Database.AddInParameter(cmd, "@APPanelID", DbType.Int64, aCCPostPayableStatementDetailEntity.APPanelID);
                Database.AddInParameter(cmd, "@IPAddress", DbType.String, aCCPostPayableStatementDetailEntity.IPAddress);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCCPostPayableStatementDetailEntity.IsRemoved);
                Database.AddInParameter(cmd, "@IsLocked", DbType.Boolean, aCCPostPayableStatementDetailEntity.IsLocked);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACCPostPayableStatementDetailEntity already exists. Please specify another ACCPostPayableStatementDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACCPostPayableStatementDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACCPostPayableStatementDetailEntity already exists. Please specify another ACCPostPayableStatementDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACCPostPayableStatementDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@PostPayableStatementDetailID", DbType.Int64, aCCPostPayableStatementDetailEntity.PostPayableStatementDetailID);
                db.AddInParameter(cmd, "@PostPayableStatementID", DbType.Int64, aCCPostPayableStatementDetailEntity.PostPayableStatementID);
                db.AddInParameter(cmd, "@PrePayableStatementDetailID", DbType.Int64, aCCPostPayableStatementDetailEntity.PrePayableStatementDetailID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCCPostPayableStatementDetailEntity.ProjectID);
                db.AddInParameter(cmd, "@ProjectCode", DbType.String, aCCPostPayableStatementDetailEntity.ProjectCode);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCCPostPayableStatementDetailEntity.WorkOrderID);
                db.AddInParameter(cmd, "@WorkOrderNo", DbType.String, aCCPostPayableStatementDetailEntity.WorkOrderNo);
                db.AddInParameter(cmd, "@WorkOrderAmount", DbType.Decimal, aCCPostPayableStatementDetailEntity.WorkOrderAmount);
                db.AddInParameter(cmd, "@WorkOrderDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.WorkOrderDate);
                db.AddInParameter(cmd, "@PaidAmount", DbType.Decimal, aCCPostPayableStatementDetailEntity.PaidAmount);
                db.AddInParameter(cmd, "@SecurityMoney", DbType.Decimal, aCCPostPayableStatementDetailEntity.SecurityMoney);
                db.AddInParameter(cmd, "@TDSAmount", DbType.Decimal, aCCPostPayableStatementDetailEntity.TDSAmount);
                db.AddInParameter(cmd, "@PayableAgainstWorkOrder", DbType.Decimal, aCCPostPayableStatementDetailEntity.PayableAgainstWorkOrder);
                db.AddInParameter(cmd, "@ApprovedBillAmount", DbType.Decimal, aCCPostPayableStatementDetailEntity.ApprovedBillAmount);
                db.AddInParameter(cmd, "@NetPayableConsideringBillAndSecurity", DbType.Decimal, aCCPostPayableStatementDetailEntity.NetPayableConsideringBillAndSecurity);
                db.AddInParameter(cmd, "@PartyReconcile", DbType.Boolean, aCCPostPayableStatementDetailEntity.PartyReconcile);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCCPostPayableStatementDetailEntity.RequisitionID);
                db.AddInParameter(cmd, "@RequisitionNo", DbType.String, aCCPostPayableStatementDetailEntity.RequisitionNo);
                db.AddInParameter(cmd, "@RequisitionDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.RequisitionDate);
                db.AddInParameter(cmd, "@BillID", DbType.Int64, aCCPostPayableStatementDetailEntity.BillID);
                db.AddInParameter(cmd, "@BillNo", DbType.String, aCCPostPayableStatementDetailEntity.BillNo);
                db.AddInParameter(cmd, "@BillDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.BillDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, aCCPostPayableStatementDetailEntity.Remarks);
                db.AddInParameter(cmd, "@Ref", DbType.String, aCCPostPayableStatementDetailEntity.Ref);
                db.AddInParameter(cmd, "@VendorCategoryID", DbType.Int64, aCCPostPayableStatementDetailEntity.VendorCategoryID);
                db.AddInParameter(cmd, "@FromVendorID", DbType.Int64, aCCPostPayableStatementDetailEntity.FromVendorID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.CreateDate);
                db.AddInParameter(cmd, "@DueDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.DueDate);
                db.AddInParameter(cmd, "@PlannedDate", DbType.DateTime, aCCPostPayableStatementDetailEntity.PlannedDate);
                db.AddInParameter(cmd, "@AdditionalRemarks", DbType.String, aCCPostPayableStatementDetailEntity.AdditionalRemarks);
                db.AddInParameter(cmd, "@ACCPayablePaymentStatusID", DbType.Int64, aCCPostPayableStatementDetailEntity.ACCPayablePaymentStatusID);
                db.AddInParameter(cmd, "@ACCPayableApprovalStatusID", DbType.Int64, aCCPostPayableStatementDetailEntity.ACCPayableApprovalStatusID);
                db.AddInParameter(cmd, "@AccountPaybleStatementDetailCategoryID", DbType.Int64, aCCPostPayableStatementDetailEntity.AccountPaybleStatementDetailCategoryID);
                db.AddInParameter(cmd, "@PayableClassificationID", DbType.Int64, aCCPostPayableStatementDetailEntity.PayableClassificationID);
                db.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, aCCPostPayableStatementDetailEntity.CreateByEmployeeID);
                db.AddInParameter(cmd, "@APPanelID", DbType.Int64, aCCPostPayableStatementDetailEntity.APPanelID);
                db.AddInParameter(cmd, "@IPAddress", DbType.String, aCCPostPayableStatementDetailEntity.IPAddress);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCCPostPayableStatementDetailEntity.IsRemoved);
                db.AddInParameter(cmd, "@IsLocked", DbType.Boolean, aCCPostPayableStatementDetailEntity.IsLocked);

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

        IList<Int64> IACCPostPayableStatementDetailDataAccess.Update(IList<ACCPostPayableStatementDetailEntity> aCCPostPayableStatementDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity in aCCPostPayableStatementDetailEntityList)
            {
                returnCode = (this as IACCPostPayableStatementDetailDataAccess).Update(aCCPostPayableStatementDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACCPostPayableStatementDetailDataAccess.Delete(ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCCPostPayableStatementDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCCPostPayableStatementDetailEntity, filterExpression, option);
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

        private Int64 Delete(ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACCPostPayableStatementDetail_SET";

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
                                throw new ArgumentException("ACCPostPayableStatementDetailEntity already exists. Please specify another ACCPostPayableStatementDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACCPostPayableStatementDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACCPostPayableStatementDetailEntity already exists. Please specify another ACCPostPayableStatementDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACCPostPayableStatementDetail_SET";

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

        IList<Int64> IACCPostPayableStatementDetailDataAccess.Delete(IList<ACCPostPayableStatementDetailEntity> aCCPostPayableStatementDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity in aCCPostPayableStatementDetailEntityList)
            {
                returnCode = (this as IACCPostPayableStatementDetailDataAccess).Delete(aCCPostPayableStatementDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACCPostPayableStatementDetailEntity> IACCPostPayableStatementDetailDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACCPostPayableStatementDetail_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACCPostPayableStatementDetailEntity> list = CreateEntityBuilder<ACCPostPayableStatementDetailEntity>().BuildEntities(reader);

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

        DataTable IACCPostPayableStatementDetailDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACCPostPayableStatementDetail_GET";

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
