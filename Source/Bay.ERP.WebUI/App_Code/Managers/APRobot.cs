using System.Diagnostics;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System;
using System.Linq;
using System.Linq.Expressions;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.BusinessEntities;

using System.Collections.Generic;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Shared;
using System.Text;
using Bay.ERP.Web.UI.Helper;

namespace Bay.ERP.Web.UI.Manager
{
    public static class APRobot
    {
        #region Properties

        public static String Subject = String.Empty;
        public static String MailBody = String.Empty;
        public static String[] MailNavUrl = new String[3];

        #endregion

        #region Methods

        #region Approval Process
        
        public static Boolean CreateApprovalProcessForNewRequisition(Int64 requisitionID)
        {
            Boolean result = false;

            APApprovalProcessEntity ent = CreateApprovalProcess(MasterDataConstants.APType.REQUISITION ,requisitionID);

            if (ent.APApprovalProcessID > 0)
            {
                result = true;
                UpdateRequisitionStatus(requisitionID, MasterDataConstants.RequisitionStatus.IN_APPROVE_PROCESS);
            }

            return result; 
        }

        public static Boolean ResetApprovalProcessForRequisition(Int64 requisitionID)
        {
            try
            {
                ResetApprovalProcess(MasterDataConstants.APType.REQUISITION, requisitionID);

                UpdateRequisitionStatus(requisitionID, MasterDataConstants.RequisitionStatus.IN_APPROVE_PROCESS);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public static Boolean ResetApprovalProcessForWorkOrder(Int64 workOrderID)
        {
            try
            {
                ResetApprovalProcess(MasterDataConstants.APType.WORK_ORDER, workOrderID);

                UpdateWorkOrderStatus(workOrderID, MasterDataConstants.WorkOrderStatus.IN_APPROVE_PROCESS);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public static Boolean ResetApprovalProcessForMRR(Int64 materialReceiveID)
        {
            try
            {
                ResetApprovalProcess(MasterDataConstants.APType.MRR, materialReceiveID);
                UpdateMaterialReceiveStatus(materialReceiveID, MasterDataConstants.MDMaterialReceiveApprovalStatus.IN_APPROVE_PROCESS);
                ResetAPForMRRQtyDeductionEntry(materialReceiveID);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public static Boolean CreateApprovalProcessForNewWorkWorder(Int64 workOrderID)
        {
            Boolean result = false;

            APApprovalProcessEntity ent = CreateApprovalProcess(MasterDataConstants.APType.WORK_ORDER, workOrderID);

            if (ent.APApprovalProcessID > 0)
            {
                result = true;
                UpdateWorkOrderStatus(workOrderID, MasterDataConstants.WorkOrderStatus.IN_APPROVE_PROCESS);
            }

            return result;
        }

        public static Boolean CreateApprovalProcessForNewTRF(Int64 invTransferID)
        {
            Boolean result = false;

            APApprovalProcessEntity ent = CreateApprovalProcess(MasterDataConstants.APType.TRF, invTransferID);

            if (ent.APApprovalProcessID > 0)
            {
                result = true;
                UpdateTRFStatus(invTransferID, MasterDataConstants.INVTransferApprovalStatus.IN_APPROVE_PROCESS);
            }

            return result;
        }


        // Additional Code - Bill Aproval Start

        public static Boolean CreateApprovalProcessForNewBill(Int64 billID,Int64 aPPanelID)
        {
            Boolean result = false;

            APApprovalProcessEntity ent = CreateApprovalProcess(MasterDataConstants.APType.BILL, billID, aPPanelID);

            if (ent.APApprovalProcessID > 0)
            {
                result = true;
                UpdateBillApprovalStatus(billID, MasterDataConstants.BillApprovalStatus.IN_APPROVE_PROCESS);
            }

            return result;
        }

        public static Boolean CreateApprovalProcessForNewPayableStatement(Int64 payableStatementDetailID, Int64 aPPanelID)
        {
            Boolean result = false;

            APApprovalProcessEntity ent = CreateApprovalProcess(MasterDataConstants.APType.PAYABLE_STATEMENT, payableStatementDetailID, aPPanelID);

            if (ent.APApprovalProcessID > 0)
            {
                result = true;
                UpdatePayableStatementDetailApprovalStatus(payableStatementDetailID, MasterDataConstants.ACCPrePayableStatementApprovalStatus.IN_APPROVE_PROCESS);
            }

            return result;
        }

        public static Boolean CreateApprovalProcessForNewBankDeposit(Int64 bankDepositID, Int64 aPPanelID)
        {
            Boolean result = false;

            APApprovalProcessEntity ent = CreateApprovalProcess(MasterDataConstants.APType.BANK_DEPOSIT, bankDepositID, aPPanelID);

            if (ent.APApprovalProcessID > 0)
            {
                result = true;
                UpdateBankDepositStatus(bankDepositID, MasterDataConstants.ACMDBankAccountDepositApprovalStatus.IN_APPROVE_PROCESS);
            }

            return result;
        }

        public static Boolean CreateApprovalProcessForNewBankPayment(Int64 bankPaymentID, Int64 aPPanelID)
        {
            Boolean result = false;

            APApprovalProcessEntity ent = CreateApprovalProcess(MasterDataConstants.APType.BANK_PAYMENT, bankPaymentID, aPPanelID);

            if (ent.APApprovalProcessID > 0)
            {
                result = true;
                UpdateBankPaymentStatus(bankPaymentID, MasterDataConstants.ACMDBankAccountPaymentApprovalStatus.IN_APPROVE_PROCESS);
            }

            return result;
        }

        public static Boolean CreateApprovalProcessForNewTemporaryJournal(Int64 temporaryJournalID, Int64 aPPanelID)
        {
            Boolean result = false;

            APApprovalProcessEntity ent = CreateApprovalProcess(MasterDataConstants.APType.TEMPORARY_JOURNAL, temporaryJournalID, aPPanelID);

            if (ent.APApprovalProcessID > 0)
            {
                result = true;
                UpdateTemporaryJournalStatus(temporaryJournalID, MasterDataConstants.ACMDTemporaryJournalApprovalStatus.IN_APPROVE_PROCESS);
            }

            return result;
        }

        public static Boolean CreateApprovalProcessForNewBankAccountTransfer(Int64 bankAccountTransferID, Int64 aPPanelID)
        {
            Boolean result = false;

            APApprovalProcessEntity ent = CreateApprovalProcess(MasterDataConstants.APType.BANK_ACCOUNT_TRANSFER, bankAccountTransferID, aPPanelID);

            if (ent.APApprovalProcessID > 0)
            {
                result = true;
                UpdateBankAccountTransferStatus(bankAccountTransferID, MasterDataConstants.ACMDBankAccountTransferApprovalStatus.IN_APPROVE_PROCESS);
            }

            return result;
        }

        public static Boolean CreateApprovalProcessForNewMRR(Int64 materialRecieveID, Int64 aPPanelID)
        {
            Boolean result = false;

            APApprovalProcessEntity ent = CreateApprovalProcess(MasterDataConstants.APType.MRR, materialRecieveID, aPPanelID);

            if (ent.APApprovalProcessID > 0)
            {
                result = true;
                UpdateMaterialReceiveStatus(materialRecieveID, MasterDataConstants.ACMDBankAccountTransferApprovalStatus.IN_APPROVE_PROCESS);
            }

            return result;
        }

        public static Boolean CreateApprovalProcessForNewAgreement(Int64 agreementID, Int64 aPPanelID)
        {
            Boolean result = false;

            APApprovalProcessEntity ent = CreateApprovalProcess(MasterDataConstants.APType.AGREEMENT, agreementID, aPPanelID);

            if (ent.APApprovalProcessID > 0)
            {
                result = true;
                UpdateAgreementStatus(agreementID, MasterDataConstants.CRMMDAgreementApprovalStatus.IN_APPROVE_PROCESS);
            }

            return result;
        }

        public static Boolean CreateApprovalProcessForNewContactList(Int64 processResourceID, Int64 aPPanelID)
        {
            Boolean result = false;

            APApprovalProcessEntity ent = CreateApprovalProcess(MasterDataConstants.APType.CONTACT_LIST, processResourceID, aPPanelID);

            if (ent.APApprovalProcessID > 0)
            {
                result = true;
                UpdateAssignedResourceProcessStatus(processResourceID, MasterDataConstants.BDMDProcessAssignedResourceApprovalStatus.IN_APPROVE_PROCESS);
            }

            return result;
        }

        public static Boolean CreateApprovalProcessForNewLeaveApplication(Int64 leaveApplicationID, Int64 aPPanelID)
        {
            Boolean result = false;

            APApprovalProcessEntity ent = CreateApprovalProcess(MasterDataConstants.APType.LEAVE_APPLICATION, leaveApplicationID, aPPanelID);

            if (ent.APApprovalProcessID > 0)
            {
                result = true;
                UpdateLeaveApplicationApprovalStatus(leaveApplicationID, MasterDataConstants.MDLeaveApplicatoinStatus.PENDING);
            }

            return result;
        }

        public static Boolean CreateApprovalProcessForNewLoanApplication(Int64 loanApplicationID, Int64 aPPanelID)
        {
            Boolean result = false;

            APApprovalProcessEntity ent = CreateApprovalProcess(MasterDataConstants.APType.LOAN_APPLICATION, loanApplicationID, aPPanelID);

            if (ent.APApprovalProcessID > 0)
            {
                result = true;
                UpdateLoanApplicationApprovalStatus(loanApplicationID, MasterDataConstants.MDLoanApplicatoinStatus.PENDING);
            }

            return result;
        }

        //This Method is applicable for Bill & Payable Statement with Approval Process
        public static APApprovalProcessEntity CreateApprovalProcess(Int64 approvalProcessType, Int64 referenceID, Int64 aPPanelID)
        {
            #region Gather Approval Process Data, then create Approval process

            APApprovalProcessEntity aPApprovalProcessEntity = new APApprovalProcessEntity();

            aPApprovalProcessEntity.APTypeID = approvalProcessType;
            aPApprovalProcessEntity.ReferenceID = referenceID;
            if (approvalProcessType == MasterDataConstants.APType.BILL)
            {
                CMBillEntity cMBillEnt = FCCCMBill.GetFacadeCreate().GetByID(referenceID);
                aPApprovalProcessEntity.Description = "Auto Generated Bill Approval Process";
                aPApprovalProcessEntity.Title = String.Format("Approval Process Type = {0}, Reference Number = {1}", "BILL", cMBillEnt.BillNo);
            }

            if (approvalProcessType == MasterDataConstants.APType.PAYABLE_STATEMENT)
            {
                ACCPostPayableStatementDetailEntity ACCpayableStatementEnt = FCCACCPostPayableStatementDetail.GetFacadeCreate().GetByID(referenceID);
                aPApprovalProcessEntity.Description = "Auto Generated Payable Statement Approval Process";
                aPApprovalProcessEntity.Title = String.Format("Approval Process Type = {0}, Reference Number = {1}", "Payable Statement - ", ACCpayableStatementEnt.BillNo.ToString()+" - " + ACCpayableStatementEnt.WorkOrderNo.ToString());
            }

            if (approvalProcessType == MasterDataConstants.APType.BANK_DEPOSIT)
            {
                ACBankAccountDepositEntity aCBankAccountDepositEntity = FCCACBankAccountDeposit.GetFacadeCreate().GetByID(referenceID);
                aPApprovalProcessEntity.Description = "Auto Generated Bank Account Deposit Approval Process";
                aPApprovalProcessEntity.Title = String.Format("Approval Process Type = {0}, Reference Number = {1}", "BANK_DEPOSIT",  aCBankAccountDepositEntity.DepositDate.ToString(UIConstants.SHORT_DATE_FORMAT));
            }

            if (approvalProcessType == MasterDataConstants.APType.BANK_PAYMENT)
            {
                ACBankAccountPaymentEntity aCBankAccountPaymentEntity = FCCACBankAccountPayment.GetFacadeCreate().GetByID(referenceID);
                aPApprovalProcessEntity.Description = "Auto Generated Bank Account Payment Approval Process";
                aPApprovalProcessEntity.Title = String.Format("Approval Process Type = {0}, Reference Number = {1}", "BANK_PAYMENT", aCBankAccountPaymentEntity.PaymentDate.ToString(UIConstants.SHORT_DATE_FORMAT));
            }

            if (approvalProcessType == MasterDataConstants.APType.TEMPORARY_JOURNAL)
            {
                ACTemporaryJournalMasterEntity ACCpayableStatementEnt = FCCACTemporaryJournalMaster.GetFacadeCreate().GetByID(referenceID);
                aPApprovalProcessEntity.Description = "Auto Generated Journal Statement Approval Process";
                aPApprovalProcessEntity.Title = String.Format("Approval Process Type = {0}, Reference Number = {1}", "JOURNAL_ENTRY", ACCpayableStatementEnt.CreateDate.ToString(UIConstants.SHORT_DATE_FORMAT));
            }

            if (approvalProcessType == MasterDataConstants.APType.BANK_ACCOUNT_TRANSFER)
            {
                ACBankAccountTransferEntity acBankAccountTransfer = FCCACBankAccountTransfer.GetFacadeCreate().GetByID(referenceID);
                aPApprovalProcessEntity.Description = "Auto Generated Bank Account Transfer Approval Process";
                aPApprovalProcessEntity.Title = String.Format("Approval Process Type = {0}, Reference Number = {1}", "BANK_ACCOUNT_TRANSFER", acBankAccountTransfer.TransferDate.ToString(UIConstants.SHORT_DATE_FORMAT));
            }

            if (approvalProcessType == MasterDataConstants.APType.MRR)
            {
                PRMMaterialReceiveEntity acMaterialReceiveEntity = FCCPRMMaterialReceive.GetFacadeCreate().GetByID(referenceID);
                aPApprovalProcessEntity.Description = "Auto Generated Material Receive Approval Process";
                aPApprovalProcessEntity.Title = String.Format("Approval Process Type = {0}, Reference Number = {1}", "MRR", acMaterialReceiveEntity.MRRNo);
            }

            if (approvalProcessType == MasterDataConstants.APType.AGREEMENT)
            {
                CRMAgreementEntity cRMAgreementEntity = FCCCRMAgreement.GetFacadeCreate().GetByID(referenceID);
                aPApprovalProcessEntity.Description = "Auto Generated Agreement Approval Process";
                aPApprovalProcessEntity.Title = String.Format("Approval Process Type = {0}, Reference Number = {1}", "AGREEMENT", cRMAgreementEntity.AgreementID);
            }

            if (approvalProcessType == MasterDataConstants.APType.CONTACT_LIST)
            {
                BDProcessAssignedResourceEntity bDProcessAssignedResourceEntity = FCCBDProcessAssignedResource.GetFacadeCreate().GetByID(referenceID);
                aPApprovalProcessEntity.Description = "Auto Generated Agreement Approval Process";
                aPApprovalProcessEntity.Title = String.Format("Approval Process Type = {0}, Reference Number = {1}", "CONTACT_LIST", bDProcessAssignedResourceEntity.ProcessAssignedResourceID);
            }

            if (approvalProcessType == MasterDataConstants.APType.LEAVE_APPLICATION)
            {
                HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity = FCCHREmployeeLeaveApplication.GetFacadeCreate().GetByID(referenceID);
                aPApprovalProcessEntity.Description = "Auto Generated Leave Approval Process";
                aPApprovalProcessEntity.Title = String.Format("Approval Process Type = {0}, Total Leave Request = {1}", "LEAVE_APPLICATION", hREmployeeLeaveApplicationEntity.TotalLeaveDays);
            }

            if (approvalProcessType == MasterDataConstants.APType.LOAN_APPLICATION)
            {
                HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity = FCCHREmployeeLoanApplication.GetFacadeCreate().GetByID(referenceID);
                aPApprovalProcessEntity.Description = "Auto Generated Loan Approval Process";
                aPApprovalProcessEntity.Title = String.Format("Approval Process Type = {0}, Applied Loan Amount = {1}", "LOAN_APPLICATION", hREmployeeLoanApplicationEntity.AppliedLoanAmount);
            }

            aPApprovalProcessEntity.CreateDate = DateTime.Now;
            aPApprovalProcessEntity.APStatusID = MasterDataConstants.APStatus.NEW;

            Int64 aPApprovalProcessID = FCCAPApprovalProcess.GetFacadeCreate().Add(aPApprovalProcessEntity, DatabaseOperationType.Add, TransactionRequired.No);

            #endregion

            if (aPApprovalProcessID > 0)
            {

                #region Find Panel Members

                IList<APPanelMemberEntity> panleMemberList = GetAllPanelMembersByPanelID(aPPanelID);

                #region Add Hod In panel by forced for Leave Application

                if (approvalProcessType == MasterDataConstants.APType.LEAVE_APPLICATION)
                {
                    String fe = "EmployeeLeaveApplicationID = "+referenceID+"";
                    IList<HREmployeeLeaveApplicationEntity> listOfHREmployeeLeaveApplication = FCCHREmployeeLeaveApplication.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    String fe2 = "EmployeeID =" + listOfHREmployeeLeaveApplication[0].EmployeeID + " and SessionCategoryID =" + MasterDataConstants.MDEvaluationSessionCategory.FISCAL_YEAR + "";
                    IList<HREmployeeSupervisorMapEntity> hREmployeeSupervisorMapList = FCCHREmployeeSupervisorMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe2, DatabaseOperationType.LoadWithFilterExpression);

                    if (hREmployeeSupervisorMapList != null && hREmployeeSupervisorMapList.Count > 0)
                    {
                        APPanelMemberEntity entity = new APPanelMemberEntity();
                        entity.APPanelID = aPPanelID;
                        entity.APPanelMemberID = panleMemberList[0].APPanelMemberID - 1;
                        entity.DepartmentID = panleMemberList[0].DepartmentID;
                        entity.EmployeeID = hREmployeeSupervisorMapList[0].SupervisorEmployeeID;
                        entity.SequenceNo = 1;
                        entity.ProxyEmployeeID = null;
                        entity.IsProxyEmployeeEnabled = false;
                        panleMemberList.Add(entity);
                    }
                }

                #endregion

                #endregion

                #region Enter data in feedback member table

                if (panleMemberList != null && panleMemberList.Count > 0)
                {
                    #region Panel Mapped with Approval Process
                    //Insert Data to the temporary Table

                    APApprovalProcessPanelMapEntity aPApprovalProcessPanelMapEntity = new APApprovalProcessPanelMapEntity();
                    aPApprovalProcessPanelMapEntity.APApprovalProcessID = aPApprovalProcessID;
                    aPApprovalProcessPanelMapEntity.APPanelID = aPPanelID;

                    FCCAPApprovalProcessPanelMap.GetFacadeCreate().Add(aPApprovalProcessPanelMapEntity, DatabaseOperationType.Add, TransactionRequired.No);

                    #endregion

                    foreach (APPanelMemberEntity ent in panleMemberList)
                    {
                        APMemberFeedbackEntity aPMemberFeedbackEntity = new APMemberFeedbackEntity();

                        aPMemberFeedbackEntity.APApprovalProcessID = aPApprovalProcessID;
                        aPMemberFeedbackEntity.DepartmentID = ent.DepartmentID;
                        aPMemberFeedbackEntity.EmployeeID = ent.EmployeeID;
                        aPMemberFeedbackEntity.SequenceNo = ent.SequenceNo;
                        aPMemberFeedbackEntity.APFeedbackID = MasterDataConstants.APFeedback.NOT_YET_REQUESTED;
                        aPMemberFeedbackEntity.FeedbackRequestDate = DateTime.Now;
                        aPMemberFeedbackEntity.FeedbackLastResponseDate = null;
                        aPMemberFeedbackEntity.FeedbackSubmitDate = null;
                        aPMemberFeedbackEntity.IsProxyEmployeeEnabled = ent.IsProxyEmployeeEnabled;

                        if (ent.IsProxyEmployeeEnabled == true)
                        {
                            aPMemberFeedbackEntity.ProxyEmployeeID = ent.ProxyEmployeeID;
                        }

                        Int64 aPMemberFeedbackID = FCCAPMemberFeedback.GetFacadeCreate().Add(aPMemberFeedbackEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                }

                else
                {

                    String fe_Delete = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APApprovalProcessID, aPApprovalProcessID.ToString(), SQLMatchType.Equal);
                    FCCAPApprovalProcess.GetFacadeCreate().Delete(aPApprovalProcessEntity, fe_Delete, DatabaseOperationType.Delete, TransactionRequired.No);
                    aPApprovalProcessEntity = new APApprovalProcessEntity();
                    return aPApprovalProcessEntity;
                    // Response."Work Order Item Map Information has been updated successfully.", false);
                }

                #endregion

                #region Send Notification to First Feedback Member

                UpdateApprovalProcessStatus(aPApprovalProcessID, MasterDataConstants.APStatus.IN_PROCESS);

                APMemberFeedbackEntity first_apmf = GetFirstMemberFeedbackByApprovalProcessID(aPApprovalProcessID);

                if (first_apmf.APMemberFeedbackID > 0)
                {
                    UpdateMemberFeedbackFeedback(first_apmf.APMemberFeedbackID, MasterDataConstants.APFeedback.FEEDBACK_REQUESTED);
                    
                    #region Send Mail

                    HREmployeeEntity _hREmployeeEntity=FCCHREmployee.GetFacadeCreate().GetByID(first_apmf.EmployeeID);

                    if(_hREmployeeEntity!=null)
                    {
                        String[] sendToMail=new String[]{_hREmployeeEntity.PrimaryEmail};
                        GenerateMailBodyLink(approvalProcessType, referenceID, first_apmf);
                        GenerateMailMessage(approvalProcessType, MasterDataConstants.APFeedback.APPROVED, MailNavUrl, referenceID);
                        MiscUtil.SendMail(sendToMail, Subject, MailBody);
                    }

                    #endregion
                    
                }

                #endregion

                aPApprovalProcessEntity = FCCAPApprovalProcess.GetFacadeCreate().GetByID(aPApprovalProcessID);
            }

            return aPApprovalProcessEntity;
        }

        // Additional Code - Bill Aproval End

        //This Method is applicable for Requisition and Work Order.
        public static APApprovalProcessEntity CreateApprovalProcess(Int64 approvalProcessType, Int64 referenceID)
        {
            #region Gather Approval Process Data, then create Approval process

            APApprovalProcessEntity aPApprovalProcessEntity = new APApprovalProcessEntity();

            aPApprovalProcessEntity.APTypeID = approvalProcessType;
            aPApprovalProcessEntity.ReferenceID = referenceID;
            if (approvalProcessType == MasterDataConstants.APType.REQUISITION)
            {
                REQRequisitionEntity reqEnt = FCCREQRequisition.GetFacadeCreate().GetByID(referenceID);
                aPApprovalProcessEntity.Description = "Auto Generated Requisition Approval Process";
                aPApprovalProcessEntity.Title = String.Format("Approval Process Type = {0}, Reference Number = {1}", "REQUISITION", reqEnt.RequisitionNo);
            }
            else if (approvalProcessType == MasterDataConstants.APType.WORK_ORDER) 
            {
                PRMWorkOrderEntity woEnt = FCCPRMWorkOrder.GetFacadeCreate().GetByID(referenceID);

                String reqNo = String.Empty;

                String fe_req = SqlExpressionBuilder.PrepareFilterExpression("PRMWorkOrderItemMap." + PRMWorkOrderItemMapEntity.FLD_NAME_WorkOrderID, referenceID.ToString(), SQLMatchType.Equal);
                IList<PRMWorkOrderItemMap_DetailedEntity> lstPRMWorkOrderItemMap = FCCPRMWorkOrderItemMap_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe_req);

                if (lstPRMWorkOrderItemMap != null && lstPRMWorkOrderItemMap.Count > 0)
                {

                    List<PRMWorkOrderItemMap_DetailedEntity> distinct =
                                       lstPRMWorkOrderItemMap
                                       .GroupBy(car => car.WorkOrderID)
                                       .Select(g => g.First())
                                       .ToList();

                    foreach (PRMWorkOrderItemMap_DetailedEntity pRMWorkOrderItemMapEntity in distinct)
                    {
                        reqNo += pRMWorkOrderItemMapEntity.RequisitionNo.ToString()+", ";
                    }
                }

                reqNo = reqNo.Substring(0, reqNo.Length - 2);

                aPApprovalProcessEntity.Description = "Auto Generated Work Order Approval Process";
                aPApprovalProcessEntity.Title = String.Format("Approval Process Type = {0}, Work Order = {1}, Requisiton = {2}", "WORK ORDER", woEnt.WorkOrderNo, reqNo);
            }
            else if (approvalProcessType == MasterDataConstants.APType.TRF)
            {
                INVTransferEntity invTransferEnt = FCCINVTransfer.GetFacadeCreate().GetByID(referenceID);
                aPApprovalProcessEntity.Description = "Auto Generated TRF Approval Process";
                aPApprovalProcessEntity.Title = String.Format("Approval Process Type = {0}, Reference Number = {1}", "TRF", invTransferEnt.TRFNo);
            }
            else
            {
                aPApprovalProcessEntity.Description = "Auto Generated Approval Process";
                aPApprovalProcessEntity.Title = String.Format("Approval Process Type = {0}, Reference Number = {1}", approvalProcessType, referenceID);
            }

            aPApprovalProcessEntity.CreateDate = DateTime.Now;
            aPApprovalProcessEntity.APStatusID = MasterDataConstants.APStatus.NEW;

            Int64 aPApprovalProcessID = FCCAPApprovalProcess.GetFacadeCreate().Add(aPApprovalProcessEntity, DatabaseOperationType.Add, TransactionRequired.No);

            #endregion

            if (aPApprovalProcessID > 0)
            {

                #region Find Approval Process Panel

                APPanelEntity aPPanelEntity = GetPanelByApprovalProcessType(approvalProcessType, referenceID);

                #endregion

                #region Find Panel Members

                IList<APPanelMemberEntity> panleMemberList = GetAllPanelMembersByPanelID(aPPanelEntity.APPanelID);

                #endregion

                Int64 aPMemberFeedbackCID = -1;

                #region Enter data in feedback member table

                if (panleMemberList != null && panleMemberList.Count > 0)
                {
                    Boolean panelmemberExists = false;
                
                    #region Prepared By Member

                    switch (approvalProcessType)
                    {
                        case MasterDataConstants.APType.REQUISITION:
                        case MasterDataConstants.APType.WORK_ORDER:

                            Int64 employeeID = 0;
                            IList<HREmployeeEntity> hREmployeeEntity=new List<HREmployeeEntity>();
                            if (approvalProcessType == MasterDataConstants.APType.REQUISITION)
                            {
                                REQRequisitionEntity rEQRequisitionEntity = FCCREQRequisition.GetFacadeCreate().GetByID(referenceID);


                                String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEntity.FLD_NAME_MemberID, rEQRequisitionEntity.PreparedByMemberID.ToString(), SQLMatchType.Equal);
                                hREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                                employeeID = hREmployeeEntity[0].EmployeeID;
                            }

                            else if (approvalProcessType == MasterDataConstants.APType.WORK_ORDER)
                            { 
                                PRMWorkOrderEntity pRMWorkOrderEntity=FCCPRMWorkOrder.GetFacadeCreate().GetByID(referenceID);
                                employeeID = pRMWorkOrderEntity.PreparedByID;
                            }

                            if (employeeID > 0)
                            {
                                var existPanelMember = (from s in panleMemberList
                                          where s.EmployeeID == employeeID
                                          select s).FirstOrDefault();

                                if (existPanelMember != null && existPanelMember.EmployeeID > 0)
                                {
                                    panelmemberExists = true;
                                }

                                else
                                {

                                    APMemberFeedbackEntity aPMemberEntity = new APMemberFeedbackEntity();

                                    aPMemberEntity.APApprovalProcessID = aPApprovalProcessID;
                                    aPMemberEntity.DepartmentID = 1; // Need to Change Here after making the HR Database
                                    aPMemberEntity.EmployeeID = employeeID;
                                    aPMemberEntity.SequenceNo = 1; // Sequence is here 1(HardCoded) because of prepared member will be the first person of approval process.
                                    aPMemberEntity.APFeedbackID = MasterDataConstants.APFeedback.APPROVED;
                                    aPMemberEntity.FeedbackRequestDate = DateTime.Now;
                                    aPMemberEntity.FeedbackRequestDate = DateTime.Now;
                                    aPMemberEntity.FeedbackLastResponseDate = DateTime.Now;
                                    aPMemberEntity.FeedbackSubmitDate = DateTime.Now;
                                    aPMemberEntity.IsProxyEmployeeEnabled = false;
                                    aPMemberEntity.ProxyEmployeeID = null;

                                    aPMemberFeedbackCID = FCCAPMemberFeedback.GetFacadeCreate().Add(aPMemberEntity, DatabaseOperationType.Add, TransactionRequired.No);
                                }
                            }
                            break;
                    }

                    #region Update All Info

                    foreach (APPanelMemberEntity ent in panleMemberList)
                    {
                        APMemberFeedbackEntity aPMemberFeedbackEntity = new APMemberFeedbackEntity();

                        aPMemberFeedbackEntity.APApprovalProcessID = aPApprovalProcessID;
                        aPMemberFeedbackEntity.DepartmentID = ent.DepartmentID;
                        aPMemberFeedbackEntity.EmployeeID = ent.EmployeeID;
                        aPMemberFeedbackEntity.SequenceNo = ent.SequenceNo;

                        if ((approvalProcessType == MasterDataConstants.APType.REQUISITION ||
                            approvalProcessType == MasterDataConstants.APType.WORK_ORDER) 
                            && panelmemberExists == false)
                        {
                            aPMemberFeedbackEntity.SequenceNo = ent.SequenceNo + 1;
                        }

                        aPMemberFeedbackEntity.APFeedbackID = MasterDataConstants.APFeedback.NOT_YET_REQUESTED;
                        //aPMemberFeedbackEntity.FeedbackRequestDate = DateTime.Now; Need to Change Because all Feedback is not requested at the same Time
                        aPMemberFeedbackEntity.FeedbackRequestDate = null;
                        aPMemberFeedbackEntity.FeedbackLastResponseDate = null;
                        aPMemberFeedbackEntity.FeedbackSubmitDate = null;
                        aPMemberFeedbackEntity.IsProxyEmployeeEnabled = ent.IsProxyEmployeeEnabled;

                        if (ent.IsProxyEmployeeEnabled == true)
                        {
                            aPMemberFeedbackEntity.ProxyEmployeeID = ent.ProxyEmployeeID;
                        }

                        Int64 aPMemberFeedbackID = FCCAPMemberFeedback.GetFacadeCreate().Add(aPMemberFeedbackEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }

                    #region Automatic First Person Remarks

                    if (aPMemberFeedbackCID > 0)
                    {
                        //UpdateApprovalProcessFeedback(aPMemberFeedbackCID, MasterDataConstants.APFeedback.APPROVED, MasterDataConstants.APType.REQUISITION, referenceID);

                        String remarks = "System Generated Comment: Document Initiated";
                        AddAPMemberFeedbackRemarks(aPMemberFeedbackCID, remarks);
                    }

                    #endregion

                    #endregion

                    #endregion
                }

                else
                {

                    String fe_Delete = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APApprovalProcessID, aPApprovalProcessID.ToString(), SQLMatchType.Equal);
                    FCCAPApprovalProcess.GetFacadeCreate().Delete(aPApprovalProcessEntity, fe_Delete, DatabaseOperationType.Delete, TransactionRequired.No);
                    aPApprovalProcessEntity = new APApprovalProcessEntity();
                    return aPApprovalProcessEntity;
                    // Response."Work Order Item Map Information has been updated successfully.", false);
                }

                #endregion

                #region Send Notification to First Feedback Member

                UpdateApprovalProcessStatus(aPApprovalProcessID, MasterDataConstants.APStatus.IN_PROCESS);

                APMemberFeedbackEntity first_apmf = GetFirstMemberFeedbackByApprovalProcessID(aPApprovalProcessID);

                if (aPMemberFeedbackCID > 0)
                {
                    first_apmf = GetFirstMemberFeedbackByApprovalProcessIDExceptPreparedBy(aPApprovalProcessID);
                }

                if (first_apmf.APMemberFeedbackID > 0)
                {
                    UpdateMemberFeedbackFeedback(first_apmf.APMemberFeedbackID, MasterDataConstants.APFeedback.FEEDBACK_REQUESTED);
                }

                #endregion

                #region Send Mail

                HREmployeeEntity _hREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(first_apmf.EmployeeID);

                if (_hREmployeeEntity != null)
                {
                    String[] sendToMail = new String[] { _hREmployeeEntity.PrimaryEmail };
                    GenerateMailBodyLink(approvalProcessType, referenceID, first_apmf);
                    GenerateMailMessage(approvalProcessType, MasterDataConstants.APFeedback.APPROVED,MailNavUrl,referenceID);
                    MiscUtil.SendMail(sendToMail, Subject, MailBody);
                }

                #endregion


                aPApprovalProcessEntity = FCCAPApprovalProcess.GetFacadeCreate().GetByID(aPApprovalProcessID);
            }

            return aPApprovalProcessEntity;
        }

       

        public static void ResetApprovalProcess(Int64 approvalProcessType, Int64 referenceID)
        {
            APApprovalProcessEntity aPApprovalProcessEntity = GetApprovalProcessByTypeAndReference(approvalProcessType, referenceID);

            IList<APMemberFeedbackEntity> feedbackList = GetAllMemberFeedbacks(aPApprovalProcessEntity.APApprovalProcessID);

            var ordered_list = feedbackList.OrderBy(x => x.SequenceNo);

            Boolean isFirstItem = true;

            foreach (APMemberFeedbackEntity ent in ordered_list)
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID, ent.APMemberFeedbackID.ToString(), SQLMatchType.Equal);

                if (isFirstItem == true)
                {
                    ent.APFeedbackID = MasterDataConstants.APFeedback.FEEDBACK_REQUESTED;
                }
                else
                {
                    ent.APFeedbackID = MasterDataConstants.APFeedback.NOT_YET_REQUESTED;
                }

                FCCAPMemberFeedback.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);

                isFirstItem = false;
            }

            UpdateApprovalProcessStatus(aPApprovalProcessEntity.APApprovalProcessID, MasterDataConstants.APStatus.IN_PROCESS);
        }

        public static IList<APApprovalProcessEntity> GetAllApprovalProcess()
        {
            IList<APApprovalProcessEntity> list = FCCAPApprovalProcess.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

            return list;
        }

        public static APApprovalProcessEntity GetApprovalProcessByTypeAndReference(Int64 approvalProcessType, Int64 referenceID)
        {
            APApprovalProcessEntity ent = new APApprovalProcessEntity();

            if (approvalProcessType == MasterDataConstants.APType.REQUISITION)
            {
                String fe_1 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APTypeID, approvalProcessType.ToString(), SQLMatchType.Equal);
                String fe_2 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_ReferenceID, referenceID.ToString(), SQLMatchType.Equal);
                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe_1, SQLJoinType.AND, fe_2);

                IList<APApprovalProcessEntity> list = FCCAPApprovalProcess.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (list != null && list.Count > 0)
                {
                    ent = list[0];
                }
            }
            else if (approvalProcessType == MasterDataConstants.APType.WORK_ORDER)
            {
                String fe_1 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APTypeID, approvalProcessType.ToString(), SQLMatchType.Equal);
                String fe_2 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_ReferenceID, referenceID.ToString(), SQLMatchType.Equal);
                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe_1, SQLJoinType.AND, fe_2);

                IList<APApprovalProcessEntity> list = FCCAPApprovalProcess.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (list != null && list.Count > 0)
                {
                    ent = list[0];
                }
            }

            else if (approvalProcessType == MasterDataConstants.APType.MRR)
            {
                String fe_1 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APTypeID, approvalProcessType.ToString(), SQLMatchType.Equal);
                String fe_2 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_ReferenceID, referenceID.ToString(), SQLMatchType.Equal);
                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe_1, SQLJoinType.AND, fe_2);

                IList<APApprovalProcessEntity> list = FCCAPApprovalProcess.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (list != null && list.Count > 0)
                {
                    ent = list[0];
                }
            }
            else if (approvalProcessType == MasterDataConstants.APType.CUSTOM)
            {
                // need to implement
            }

            else if (approvalProcessType == MasterDataConstants.APType.BILL)
            {
                String fe_1 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APTypeID, approvalProcessType.ToString(), SQLMatchType.Equal);
                String fe_2 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_ReferenceID, referenceID.ToString(), SQLMatchType.Equal);
                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe_1, SQLJoinType.AND, fe_2);

                IList<APApprovalProcessEntity> list = FCCAPApprovalProcess.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (list != null && list.Count > 0)
                {
                    ent = list[0];
                }
            }

            else if (approvalProcessType == MasterDataConstants.APType.PAYABLE_STATEMENT)
            {
                String fe_1 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APTypeID, approvalProcessType.ToString(), SQLMatchType.Equal);
                String fe_2 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_ReferenceID, referenceID.ToString(), SQLMatchType.Equal);
                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe_1, SQLJoinType.AND, fe_2);

                IList<APApprovalProcessEntity> list = FCCAPApprovalProcess.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (list != null && list.Count > 0)
                {
                    ent = list[0];
                }
            }

            else if (approvalProcessType == MasterDataConstants.APType.TRF)
            {
                String fe_1 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APTypeID, approvalProcessType.ToString(), SQLMatchType.Equal);
                String fe_2 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_ReferenceID, referenceID.ToString(), SQLMatchType.Equal);
                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe_1, SQLJoinType.AND, fe_2);

                IList<APApprovalProcessEntity> list = FCCAPApprovalProcess.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (list != null && list.Count > 0)
                {
                    ent = list[0];
                }
            }

            else if (approvalProcessType == MasterDataConstants.APType.BANK_DEPOSIT)
            {
                String fe_1 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APTypeID, approvalProcessType.ToString(), SQLMatchType.Equal);
                String fe_2 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_ReferenceID, referenceID.ToString(), SQLMatchType.Equal);
                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe_1, SQLJoinType.AND, fe_2);

                IList<APApprovalProcessEntity> list = FCCAPApprovalProcess.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (list != null && list.Count > 0)
                {
                    ent = list[0];
                }
            }

            else if (approvalProcessType == MasterDataConstants.APType.BANK_PAYMENT)
            {
                String fe_1 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APTypeID, approvalProcessType.ToString(), SQLMatchType.Equal);
                String fe_2 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_ReferenceID, referenceID.ToString(), SQLMatchType.Equal);
                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe_1, SQLJoinType.AND, fe_2);

                IList<APApprovalProcessEntity> list = FCCAPApprovalProcess.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (list != null && list.Count > 0)
                {
                    ent = list[0];
                }
            }

            else if (approvalProcessType == MasterDataConstants.APType.TEMPORARY_JOURNAL)
            {
                String fe_1 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APTypeID, approvalProcessType.ToString(), SQLMatchType.Equal);
                String fe_2 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_ReferenceID, referenceID.ToString(), SQLMatchType.Equal);
                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe_1, SQLJoinType.AND, fe_2);

                IList<APApprovalProcessEntity> list = FCCAPApprovalProcess.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (list != null && list.Count > 0)
                {
                    ent = list[0];
                }
            }

            else if (approvalProcessType == MasterDataConstants.APType.BANK_ACCOUNT_TRANSFER)
            {
                String fe_1 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APTypeID, approvalProcessType.ToString(), SQLMatchType.Equal);
                String fe_2 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_ReferenceID, referenceID.ToString(), SQLMatchType.Equal);
                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe_1, SQLJoinType.AND, fe_2);

                IList<APApprovalProcessEntity> list = FCCAPApprovalProcess.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (list != null && list.Count > 0)
                {
                    ent = list[0];
                }
            }

            else if (approvalProcessType == MasterDataConstants.APType.MRR)
            {
                String fe_1 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APTypeID, approvalProcessType.ToString(), SQLMatchType.Equal);
                String fe_2 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_ReferenceID, referenceID.ToString(), SQLMatchType.Equal);
                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe_1, SQLJoinType.AND, fe_2);

                IList<APApprovalProcessEntity> list = FCCAPApprovalProcess.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (list != null && list.Count > 0)
                {
                    ent = list[0];
                }
            }

            else if (approvalProcessType == MasterDataConstants.APType.AGREEMENT)
            {
                String fe_1 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APTypeID, approvalProcessType.ToString(), SQLMatchType.Equal);
                String fe_2 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_ReferenceID, referenceID.ToString(), SQLMatchType.Equal);
                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe_1, SQLJoinType.AND, fe_2);

                IList<APApprovalProcessEntity> list = FCCAPApprovalProcess.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (list != null && list.Count > 0)
                {
                    ent = list[0];
                }
            }

            else if (approvalProcessType == MasterDataConstants.APType.CONTACT_LIST||
                approvalProcessType == MasterDataConstants.APType.LOAN_APPLICATION||
                approvalProcessType == MasterDataConstants.APType.LEAVE_APPLICATION)
            {
                String fe_1 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APTypeID, approvalProcessType.ToString(), SQLMatchType.Equal);
                String fe_2 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_ReferenceID, referenceID.ToString(), SQLMatchType.Equal);
                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe_1, SQLJoinType.AND, fe_2);

                IList<APApprovalProcessEntity> list = FCCAPApprovalProcess.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (list != null && list.Count > 0)
                {
                    ent = list[0];
                }
            }
            else
            {
                // need to implement
            }

            return ent;
        }

        public static IList<APApprovalProcessEntity> GetAllApprovalProcessByStatus(Int64 status)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APStatusID, status.ToString(), SQLMatchType.Equal);
            IList<APApprovalProcessEntity> list = FCCAPApprovalProcess.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            return list;
        }

        public static APApprovalProcessEntity GetApprovalProcessByID(Int64 approvalProcessID)
        {
            return FCCAPApprovalProcess.GetFacadeCreate().GetByID(approvalProcessID);
        }

        public static Boolean UpdateApprovalProcessStatus(Int64 approvalProcessID, Int64 status)
        {
            APApprovalProcessEntity ent = FCCAPApprovalProcess.GetFacadeCreate().GetByID(approvalProcessID);

            if (ent.APApprovalProcessID > 0)
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APApprovalProcessID, approvalProcessID.ToString(), SQLMatchType.Equal);

                ent.APStatusID = status;

                Int64 result = FCCAPApprovalProcess.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);

                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region AP Member Feedback

        public static void UpdateApprovalProcessFeedback(Int64 aPMemberFeedbackID, Int64 aPFeedback, Int64 approvalProcessType, Int64 referenceID)
        {
            UpdateApprovalProcessFeedback(aPMemberFeedbackID, aPFeedback, approvalProcessType, referenceID, 0);
        }

        public static void UpdateApprovalProcessFeedback(Int64 aPMemberFeedbackID, Int64 aPFeedback, Int64 approvalProcessType, Int64 referenceID, Int64 rejectToAPMemberFeedbackID)
        {
            UpdateMemberFeedbackFeedback(aPMemberFeedbackID, aPFeedback);
            UpdateMemberFeedbackLastResponseDate(aPMemberFeedbackID, DateTime.Now);

            #region Approve

            if (aPFeedback == MasterDataConstants.APFeedback.APPROVED)
            {
                UpdateMemberFeedbackSubmitDate(aPMemberFeedbackID, DateTime.Now);

                if (IsLastMemberFeedback(aPMemberFeedbackID))
                {
                    if (approvalProcessType == MasterDataConstants.APType.REQUISITION)
                    {
                        UpdateRequisitionStatus(referenceID, MasterDataConstants.RequisitionStatus.APPROVED);
                        //UpdateBOQorProjectCostQty(referenceID); //This code is comments according to the last requirement of SEN
                    }
                    else if (approvalProcessType == MasterDataConstants.APType.WORK_ORDER)
                    {
                        UpdateWorkOrderStatus(referenceID, MasterDataConstants.WorkOrderStatus.APPROVED);
                    }
                    else if (approvalProcessType == MasterDataConstants.APType.BILL)
                    {
                        UpdateBillApprovalStatus(referenceID, MasterDataConstants.WorkOrderStatus.APPROVED);
                        BillNotification(referenceID);
                       
                    }
                    else if (approvalProcessType == MasterDataConstants.APType.PAYABLE_STATEMENT)
                    {
                        UpdatePayableStatementDetailApprovalStatus(referenceID, MasterDataConstants.ACCPrePayableStatementApprovalStatus.APPROVED);
                    }
                    else if (approvalProcessType == MasterDataConstants.APType.BANK_DEPOSIT)
                    {
                        UpdateBankDepositStatus(referenceID, MasterDataConstants.ACMDBankAccountDepositApprovalStatus.APPROVED);
                        BankAccountDepositJournalEntry(referenceID);
                    }
                    else if (approvalProcessType == MasterDataConstants.APType.BANK_PAYMENT)
                    {
                        UpdateBankPaymentStatus(referenceID, MasterDataConstants.ACMDBankAccountPaymentApprovalStatus.APPROVED);
                        BankAccountPaymentJournalEntry(referenceID);
                    }
                    else if (approvalProcessType == MasterDataConstants.APType.TEMPORARY_JOURNAL)
                    {
                        UpdateTemporaryJournalStatus(referenceID, MasterDataConstants.ACMDTemporaryJournalApprovalStatus.APPROVED);
                        TemporaryJournalEntry(referenceID);
                    }

                    else if (approvalProcessType == MasterDataConstants.APType.TRF)
                    {
                        UpdateTRFStatus(referenceID, MasterDataConstants.INVTransferApprovalStatus.APPROVED);
                        AutoGenerateSINFromTRF(referenceID);
                    }

                    else if (approvalProcessType == MasterDataConstants.APType.BANK_ACCOUNT_TRANSFER)
                    {
                        UpdateBankAccountTransferStatus(referenceID, MasterDataConstants.ACMDBankAccountTransferApprovalStatus.APPROVED);
                        AutoBankAccountTransferJournalEntry(referenceID);
                    }

                    else if (approvalProcessType == MasterDataConstants.APType.MRR)
                    {
                        UpdateMaterialReceiveStatus(referenceID, MasterDataConstants.MDMaterialReceiveApprovalStatus.APPROVED);
                        AutoInventoryEntry(referenceID);
                        DeductBOQorProjectCostQty(referenceID);
                        //UpdateBOQorProjectCostQty(referenceID);
                    }

                    else if (approvalProcessType == MasterDataConstants.APType.AGREEMENT)
                    {
                        AgreementText(referenceID);
                        UpdateAgreementStatus(referenceID, MasterDataConstants.CRMMDAgreementApprovalStatus.APPROVED);
                    }

                    else if (approvalProcessType == MasterDataConstants.APType.CONTACT_LIST)
                    {   
                        UpdateAssignedResourceProcessStatus(referenceID, MasterDataConstants.BDMDProcessAssignedResourceApprovalStatus.APPROVED);
                    }
                    else if (approvalProcessType == MasterDataConstants.APType.LOAN_APPLICATION)
                    {
                        UpdateLoanApplicationApprovalStatus(referenceID, MasterDataConstants.MDLoanApplicatoinStatus.APPROVED);
                    }
                    else if (approvalProcessType == MasterDataConstants.APType.LEAVE_APPLICATION)
                    {
                        UpdateLeaveApplicationApprovalStatus(referenceID, MasterDataConstants.MDLeaveApplicatoinStatus.APPROVED);
                    }

                    else if (approvalProcessType == MasterDataConstants.APType.CUSTOM)
                    {
                    }

                    APMemberFeedbackEntity ent = FCCAPMemberFeedback.GetFacadeCreate().GetByID(aPMemberFeedbackID);

                    if (ent != null && ent.APApprovalProcessID > 0)
                    {
                        UpdateApprovalProcessStatus(ent.APApprovalProcessID, MasterDataConstants.APStatus.COMPLETED);
                    }
                }
                else
                {
                    APMemberFeedbackEntity next_APMemberFeedbackEntity = GetNextMemberFeedback(aPMemberFeedbackID);

                    UpdateMemberFeedbackFeedback(next_APMemberFeedbackEntity.APMemberFeedbackID, MasterDataConstants.APFeedback.FEEDBACK_REQUESTED);

                    #region Send Mail

                    if (approvalProcessType == MasterDataConstants.APType.BILL ||
                        approvalProcessType == MasterDataConstants.APType.REQUISITION ||
                        approvalProcessType == MasterDataConstants.APType.WORK_ORDER ||
                        approvalProcessType == MasterDataConstants.APType.BANK_DEPOSIT ||
                        approvalProcessType == MasterDataConstants.APType.BANK_PAYMENT ||
                        approvalProcessType == MasterDataConstants.APType.TEMPORARY_JOURNAL||
                        approvalProcessType == MasterDataConstants.APType.BANK_ACCOUNT_TRANSFER||
                        approvalProcessType == MasterDataConstants.APType.AGREEMENT||
                        approvalProcessType == MasterDataConstants.APType.CONTACT_LIST ) // This filter is used for testing or Bill Approval Process
                    {

                        HREmployeeEntity _hREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(next_APMemberFeedbackEntity.EmployeeID);

                        if (_hREmployeeEntity != null)
                        {
                            String[] sendToMail = new String[] { _hREmployeeEntity.PrimaryEmail };
                            GenerateMailBodyLink(approvalProcessType, referenceID, next_APMemberFeedbackEntity);
                            GenerateMailMessage(approvalProcessType,aPFeedback,MailNavUrl,referenceID);
                            MiscUtil.SendMail(sendToMail, Subject, MailBody);
                        }
                    }

                    #endregion

                }
            }

            #endregion

            #region Reject

            else if (aPFeedback == MasterDataConstants.APFeedback.REJECTED)            
            {
                UpdateMemberFeedbackSubmitDate(aPMemberFeedbackID, DateTime.Now);

                if (IsFirstMemberFeedback(aPMemberFeedbackID))
                {
                    if (approvalProcessType == MasterDataConstants.APType.REQUISITION)
                    {
                        UpdateRequisitionStatus(referenceID, MasterDataConstants.RequisitionStatus.REJECTED);
                    }
                    else if (approvalProcessType == MasterDataConstants.APType.WORK_ORDER)
                    {
                        UpdateWorkOrderStatus(referenceID, MasterDataConstants.WorkOrderStatus.REJECTED);
                    }
                    else if (approvalProcessType == MasterDataConstants.APType.LEAVE_APPLICATION)
                    {
                        UpdateLeaveApplicationApprovalStatus(referenceID, MasterDataConstants.MDLeaveApplicatoinStatus.DECLINED);
                    }
                    else if (approvalProcessType == MasterDataConstants.APType.LOAN_APPLICATION)
                    {
                        UpdateLeaveApplicationApprovalStatus(referenceID, MasterDataConstants.MDLoanApplicatoinStatus.DECLINED);
                    }
                    else if (approvalProcessType == MasterDataConstants.APType.CUSTOM)
                    {
                    }
                }
                else
                {
                    Int64 tempAPMemberFeedbackID = 0;

                    if(rejectToAPMemberFeedbackID > 0)
                    {
                        tempAPMemberFeedbackID = rejectToAPMemberFeedbackID;
                    }
                    else
                    {
                        APMemberFeedbackEntity prev_APMemberFeedbackEntity = GetPreviousMemberFeedback(aPMemberFeedbackID);
                        tempAPMemberFeedbackID = prev_APMemberFeedbackEntity.APMemberFeedbackID;
                    }

                    UpdateMemberFeedbackFeedback(tempAPMemberFeedbackID, MasterDataConstants.APFeedback.FEEDBACK_REQUESTED);

                    #region Send Mail

                    if (approvalProcessType == MasterDataConstants.APType.BILL || approvalProcessType == MasterDataConstants.APType.REQUISITION || approvalProcessType == MasterDataConstants.APType.WORK_ORDER || approvalProcessType == MasterDataConstants.APType.PAYABLE_STATEMENT) 
                    {
                        if (rejectToAPMemberFeedbackID > 0)
                        {

                            APMemberFeedbackEntity Current_APMemberFeedbackEntity = FCCAPMemberFeedback.GetFacadeCreate().GetByID(rejectToAPMemberFeedbackID);

                            //String fe = SqlExpressionBuilder.PrepareFilterExpression(HRMemberEntity.FLD_NAME_MemberID, aPMemberFeedbackID.ToString(), SQLMatchType.Equal);
                            //IList<HREmployeeEntity> lstEmployee = FCCHREmployee.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                            if (Current_APMemberFeedbackEntity != null)
                            {
                                HREmployeeEntity lstEmployee = FCCHREmployee.GetFacadeCreate().GetByID(Current_APMemberFeedbackEntity.EmployeeID);


                                if (lstEmployee != null)
                                {
                                    String[] sendToMail = new String[] { lstEmployee.PrimaryEmail };
                                    GenerateMailBodyLink(approvalProcessType, referenceID, Current_APMemberFeedbackEntity);
                                    GenerateMailMessage(approvalProcessType, aPFeedback,MailNavUrl,referenceID);
                                    MiscUtil.SendMail(sendToMail, Subject, MailBody);
                                }
                            }
                        }
                    }

                    #endregion

                }
            }

            #endregion
        }

        #endregion

        #region AP Member Feedback Remarks

        public static Int64 AddAPMemberFeedbackRemarks(Int64 aPMemberFeedbackID, String remarks)
        {
            APMemberFeedbackEntity ent = GetAPMemberFeedbackByID(aPMemberFeedbackID);

            return AddAPMemberFeedbackRemarks(ent.APApprovalProcessID, remarks, ent.EmployeeID, ent.APFeedbackID);
        }

        public static Int64 AddAPMemberFeedbackRemarks(Int64 aPApprovalProcessID, String remarks, Int64 employeeID, Int64 aPFeedbackID)
        {
            APMemberFeedbackRemarksEntity aPMemberFeedbackRemarksEntity = new APMemberFeedbackRemarksEntity();

            aPMemberFeedbackRemarksEntity.APApprovalProcessID = aPApprovalProcessID;
            aPMemberFeedbackRemarksEntity.Remarks = remarks;
            aPMemberFeedbackRemarksEntity.RemarksDateTime = DateTime.Now;
            aPMemberFeedbackRemarksEntity.EmployeeID = employeeID;
            aPMemberFeedbackRemarksEntity.APFeedbackID = aPFeedbackID;

            Int64 result = FCCAPMemberFeedbackRemarks.GetFacadeCreate().Add(aPMemberFeedbackRemarksEntity, DatabaseOperationType.Add, TransactionRequired.No);

            return result; 
        }

        public static IList<APMemberFeedbackRemarks_DetailedEntity> GetMemberFeedbackRemarks_DetailedByApprovalProcessID(Int64 approvalProcessID)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("APMemberFeedbackRemarks." + APMemberFeedbackRemarks_DetailedEntity.FLD_NAME_APApprovalProcessID, approvalProcessID.ToString(), SQLMatchType.Equal);
            IList<APMemberFeedbackRemarks_DetailedEntity> list = FCCAPMemberFeedbackRemarks_Detailed.GetFacadeCreate().GetIL(100000, 1, String.Empty, fe);

            return list;
        }

        #endregion

        #region AP Panel

        public static IList<APPanelEntity> GetAllPanels() 
        {
            IList<APPanelEntity> list = FCCAPPanel.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

            return list;
        }

        public static APPanelEntity GetPanelByApprovalProcessType(Int64 approvalProcessType, Int64 referenceID) 
        {
            APPanelEntity aPPanel = new APPanelEntity();

            if(approvalProcessType == MasterDataConstants.APType.REQUISITION)
            {
                #region Requisition

                // Getting requisition Items
                String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionID, referenceID.ToString(), SQLMatchType.Equal);
                IList<REQRequisitionItemEntity> list = FCCREQRequisitionItem.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                
                if(list != null && list.Count > 0)
                {
                    // Getting requisition Item info for Item category
                    MDItemEntity ent  = FCCMDItem.GetFacadeCreate().GetByID(list[0].ItemID);

                    if(ent.ItemID > 0)
                    {
                        // Getting requisition Items
                        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(APPanelItemCategoryMapEntity.FLD_NAME_ItemCategoryID, ent.ItemCategoryID.ToString(), SQLMatchType.Equal);
                        IList<APPanelItemCategoryMapEntity> list1 = FCCAPPanelItemCategoryMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe1, DatabaseOperationType.LoadWithFilterExpression);

                        if(list1 != null && list1.Count > 0)
                        {
                            aPPanel = FCCAPPanel.GetFacadeCreate().GetByID(list1[0].APPanelID);
                        }
                    }
                }

                #endregion Requisition
            }
            else if(approvalProcessType == MasterDataConstants.APType.WORK_ORDER)
            {
                #region Work Order

                // Getting requisition Items
                String fe_wo = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemMapEntity.FLD_NAME_WorkOrderID, referenceID.ToString(), SQLMatchType.Equal);
                IList<PRMWorkOrderItemMapEntity> list_wo = FCCPRMWorkOrderItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_wo, DatabaseOperationType.LoadWithFilterExpression);

                if (list_wo != null && list_wo.Count > 0)
                {
                    // Getting requisition Item info for Item category
                    REQRequisitionEntity req = FCCREQRequisition.GetFacadeCreate().GetByID(list_wo[0].RequisitionID);

                    if (req.RequisitionID > 0)
                    {
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionID, req.RequisitionID.ToString(), SQLMatchType.Equal);
                        IList<REQRequisitionItemEntity> list = FCCREQRequisitionItem.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                        if (list != null && list.Count > 0)
                        {
                            // Getting requisition Item info for Item category
                            MDItemEntity ent = FCCMDItem.GetFacadeCreate().GetByID(list[0].ItemID);

                            if (ent.ItemID > 0)
                            {
                                // Getting requisition Items
                                String fe1 = SqlExpressionBuilder.PrepareFilterExpression(APWOPanelItemCategoryMapEntity.FLD_NAME_ItemCategoryID, ent.ItemCategoryID.ToString(), SQLMatchType.Equal);
                                IList<APWOPanelItemCategoryMapEntity> list1 = FCCAPWOPanelItemCategoryMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe1, DatabaseOperationType.LoadWithFilterExpression);

                                if (list1 != null && list1.Count > 0)
                                {
                                    aPPanel = FCCAPPanel.GetFacadeCreate().GetByID(list1[0].APPanelID);
                                }
                            }
                        }
                        
                    }
                }

                #endregion Work Order
            }

            else if (approvalProcessType == MasterDataConstants.APType.TRF)
            {
                #region Requisition

                // Getting requisition Items
                String fe = SqlExpressionBuilder.PrepareFilterExpression(INVTransferItemEntity.FLD_NAME_TransferID, referenceID.ToString(), SQLMatchType.Equal);
                IList<INVTransferItemEntity> list = FCCINVTransferItem.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (list != null && list.Count > 0)
                {
                    // Getting requisition Item info for Item category
                    MDItemEntity ent = FCCMDItem.GetFacadeCreate().GetByID(list[0].ItemID);

                    if (ent.ItemID > 0)
                    {
                        // Getting requisition Items
                        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(APPanelItemCategoryMapEntity.FLD_NAME_ItemCategoryID, ent.ItemCategoryID.ToString(), SQLMatchType.Equal);
                        IList<APPanelItemCategoryMapEntity> list1 = FCCAPPanelItemCategoryMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe1, DatabaseOperationType.LoadWithFilterExpression);

                        if (list1 != null && list1.Count > 0)
                        {
                            aPPanel = FCCAPPanel.GetFacadeCreate().GetByID(list1[0].APPanelID);
                        }
                    }
                }

                #endregion Requisition
            }

            else if (approvalProcessType == MasterDataConstants.APType.BANK_DEPOSIT||
                approvalProcessType == MasterDataConstants.APType.BANK_PAYMENT||
                approvalProcessType == MasterDataConstants.APType.BANK_ACCOUNT_TRANSFER||
                approvalProcessType == MasterDataConstants.APType.AGREEMENT||
                approvalProcessType == MasterDataConstants.APType.BILL||
                approvalProcessType == MasterDataConstants.APType.CONTACT_LIST||
                approvalProcessType == MasterDataConstants.APType.MRR||
                approvalProcessType == MasterDataConstants.APType.PAYABLE_STATEMENT||
                approvalProcessType == MasterDataConstants.APType.TEMPORARY_JOURNAL)
            {
                #region Only From Approval Panel

                String fe1 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APTypeID, approvalProcessType.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_ReferenceID, referenceID.ToString(), SQLMatchType.Equal);

                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                IList<APApprovalProcessEntity> lstAPApprovalProcess = FCCAPApprovalProcess.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (lstAPApprovalProcess != null && lstAPApprovalProcess.Count > 0)
                {
                    //Get PanelID From the temporary Table

                    String fe_Panel=SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessPanelMapEntity.FLD_NAME_APApprovalProcessID,lstAPApprovalProcess[0].APApprovalProcessID.ToString(),SQLMatchType.Equal);
                    IList<APApprovalProcessPanelMapEntity> lstAPApprovalProcessPanelMap = FCCAPApprovalProcessPanelMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_Panel, DatabaseOperationType.LoadWithFilterExpression);

                    if (lstAPApprovalProcessPanelMap != null && lstAPApprovalProcessPanelMap.Count > 0)
                    {
                        aPPanel = FCCAPPanel.GetFacadeCreate().GetByID(lstAPApprovalProcessPanelMap[0].APPanelID);
                    }
                }

                #endregion Only From Approval Panel
            }

            else if (approvalProcessType == MasterDataConstants.APType.CUSTOM)
            {
                // need to implement
            }
            else
            {
                // need to implement
            }

            return aPPanel;
        }
      
        #endregion

        #region AP Panel Members

        public static IList<APPanelMemberEntity> GetAllPanelMembersByPanelID(Int64 panelID)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(APPanelMemberEntity.FLD_NAME_APPanelID, panelID.ToString(), SQLMatchType.Equal);
            String se = SqlExpressionBuilder.PrepareSortExpression(APPanelMemberEntity.FLD_NAME_SequenceNo, SQLSortOrderType.Assending);
            IList<APPanelMemberEntity> list = FCCAPPanelMember.GetFacadeCreate().GetIL(null, null, se, fe, DatabaseOperationType.LoadWithFilterAndSortExpression);

            return list;
        }

        public static void SavePanelMembersSequence(IList<APPanelMemberEntity> list) 
        {
            foreach (APPanelMemberEntity ent in list)
            {
                APPanelMemberEntity new_ent = FCCAPPanelMember.GetFacadeCreate().GetByID(ent.APPanelMemberID);

                if (new_ent.APPanelMemberID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(APPanelMemberEntity.FLD_NAME_APPanelMemberID, new_ent.APPanelMemberID.ToString(), SQLMatchType.Equal);

                    new_ent.SequenceNo = ent.SequenceNo;

                    FCCAPPanelMember.GetFacadeCreate().Update(new_ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
                }
            }
        }

        #endregion

        #region AP Member Feedback

        public static IList<APMemberFeedbackEntity> GetAllMemberFeedbacks(Int64 approvalProcessID) 
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID, approvalProcessID.ToString(), SQLMatchType.Equal);
            IList<APMemberFeedbackEntity> list = FCCAPMemberFeedback.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            return list;
        }
        
        public static IList<APMemberFeedback_DetailedEntity> GetAllMemberFeedbacks_Detailed(Int64 approvalProcessID)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("APMemberFeedback." + APMemberFeedback_DetailedEntity.FLD_NAME_APApprovalProcessID, approvalProcessID.ToString(), SQLMatchType.Equal);
            //Should Change here according to Sequence Number.
            String se = SqlExpressionBuilder.PrepareSortExpression("APMemberFeedback." + APMemberFeedback_DetailedEntity.FLD_NAME_SequenceNo, SQLSortOrderType.Assending);
            IList<APMemberFeedback_DetailedEntity> list = FCCAPMemberFeedback_Detailed.GetFacadeCreate().GetIL(100000, 1, se, fe);

            return list;
        }

        public static APMemberFeedback_DetailedEntity GetMemberFeedback_DetailedByAPMemberFeedbackID(Int64 aPMemberFeedbackID)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("APMemberFeedback." + APMemberFeedback_DetailedEntity.FLD_NAME_APMemberFeedbackID, aPMemberFeedbackID.ToString(), SQLMatchType.Equal);
            IList<APMemberFeedback_DetailedEntity> list = FCCAPMemberFeedback_Detailed.GetFacadeCreate().GetIL(1, 1, String.Empty, fe);

            APMemberFeedback_DetailedEntity ent = new APMemberFeedback_DetailedEntity();

            if (list != null && list.Count > 0)
            {
                ent = list[0];
            }
            return ent;
        }

        public static IList<APMemberFeedback_DetailedEntity> GetRejectToMemberFeedbacks_Detailed(Int64 approvalProcessID, Int64 employeeID)
        {
            IList<APMemberFeedback_DetailedEntity> returnList = new List<APMemberFeedback_DetailedEntity>();

            String fe = SqlExpressionBuilder.PrepareFilterExpression("APMemberFeedback." + APMemberFeedback_DetailedEntity.FLD_NAME_APApprovalProcessID, approvalProcessID.ToString(), SQLMatchType.Equal);
            String se = SqlExpressionBuilder.PrepareSortExpression(APMemberFeedback_DetailedEntity.FLD_NAME_SequenceNo, SQLSortOrderType.Assending);
            IList<APMemberFeedback_DetailedEntity> list = FCCAPMemberFeedback_Detailed.GetFacadeCreate().GetIL(100000, 1, se, fe);
            
            foreach (APMemberFeedback_DetailedEntity item in list)
            {
                if (item.EmployeeID == employeeID)
                {
                    break;
                }

                returnList.Add(item);
            }

            return returnList;
        }

        public static APMemberFeedbackEntity GetAPMemberFeedbackByID(Int64 memberFeedbackID)
        {
            return FCCAPMemberFeedback.GetFacadeCreate().GetByID(memberFeedbackID);
        }
        
        public static Boolean CanModifyMembersFeedbackSequence(Int64 approvalProcessID) 
        {
            Boolean result = false;

            APApprovalProcessEntity ent = FCCAPApprovalProcess.GetFacadeCreate().GetByID(approvalProcessID);

            if (ent.APApprovalProcessID > 0)            
            {
                if (ent.APStatusID == MasterDataConstants.APStatus.NEW)
                {
                    result = true;
                }
            }

            return result;
        }

        public static APMemberFeedbackEntity GetNextMemberFeedback(Int64 memberFeedbackID) 
        {
            APMemberFeedbackEntity next_ent = new APMemberFeedbackEntity();

            if (!IsLastMemberFeedback(memberFeedbackID))
            {
                APMemberFeedbackEntity ent = FCCAPMemberFeedback.GetFacadeCreate().GetByID(memberFeedbackID);

                if (ent.APMemberFeedbackID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID, ent.APApprovalProcessID.ToString(), SQLMatchType.Equal);
                    IList<APMemberFeedbackEntity> list = FCCAPMemberFeedback.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (list != null && list.Count > 0)
                    {
                        var ordered_list = list.OrderByDescending(x => x.SequenceNo);

                        foreach (APMemberFeedbackEntity item in ordered_list)
                        {
                            if (ent.SequenceNo == item.SequenceNo)
                            {
                                break;
                            }

                            next_ent = item;
                        }                         
                    } 
                }
 
            }

            return next_ent; 
        }

        public static APMemberFeedbackEntity GetPreviousMemberFeedback(Int64 memberFeedbackID)
        {
            APMemberFeedbackEntity prev_ent = new APMemberFeedbackEntity();

            if (!IsFirstMemberFeedback(memberFeedbackID))
            {
                APMemberFeedbackEntity ent = FCCAPMemberFeedback.GetFacadeCreate().GetByID(memberFeedbackID);

                if (ent.APMemberFeedbackID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID, ent.APApprovalProcessID.ToString(), SQLMatchType.Equal);
                    IList<APMemberFeedbackEntity> list = FCCAPMemberFeedback.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (list != null && list.Count > 0)
                    {
                        var ordered_list = list.OrderByDescending(x => x.SequenceNo);
                        Boolean currentMemberFound = false;

                        foreach (APMemberFeedbackEntity item in ordered_list)
                        {
                            if (currentMemberFound == true)
                            {
                                prev_ent = item;

                                break;
                            }
                            if (ent.SequenceNo == item.SequenceNo)
                            {
                                currentMemberFound = true;
                            }
                            
                        }
                    }
                }

            }

            return prev_ent;
        }

        public static APMemberFeedbackEntity GetFirstMemberFeedbackByApprovalProcessIDExceptPreparedBy(Int64 approvalProcessID)
        {
            APMemberFeedbackEntity aPMemberFeedbackEntity = new APMemberFeedbackEntity();

            IList<APMemberFeedbackEntity> list = GetAllMemberFeedbacks(approvalProcessID);

            if (list != null && list.Count > 0)
            {
                aPMemberFeedbackEntity = (from s in list
                                          where s.SequenceNo == 2
                                          select s).FirstOrDefault();
            }

            return aPMemberFeedbackEntity;
        }

        public static APMemberFeedbackEntity GetFirstMemberFeedbackByApprovalProcessID(Int64 approvalProcessID)
        {
            APMemberFeedbackEntity aPMemberFeedbackEntity = new APMemberFeedbackEntity();

            IList<APMemberFeedbackEntity> list = GetAllMemberFeedbacks(approvalProcessID);

            if (list != null && list.Count > 0)
            {
                aPMemberFeedbackEntity = list.OrderByDescending(x => x.SequenceNo).Last(); 
            }

            return aPMemberFeedbackEntity;
        }

        public static Boolean IsFirstMemberFeedback(Int64 memberFeedbackID) 
        {
            Boolean result = false;

            APMemberFeedbackEntity ent = FCCAPMemberFeedback.GetFacadeCreate().GetByID(memberFeedbackID);

            if (ent.APMemberFeedbackID > 0)
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID, ent.APApprovalProcessID.ToString(), SQLMatchType.Equal);
                IList<APMemberFeedbackEntity> list = FCCAPMemberFeedback.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (list != null && list.Count > 0)
                {
                    APMemberFeedbackEntity item = list.OrderByDescending(x => x.SequenceNo).Last();

                    if (ent.SequenceNo == item.SequenceNo)
                    {
                        result = true;
                    }
                }
            }

            return result;
        }

        public static Boolean IsLastMemberFeedback(Int64 memberFeedbackID)
        {
            Boolean result = false;

            APMemberFeedbackEntity ent = FCCAPMemberFeedback.GetFacadeCreate().GetByID(memberFeedbackID);

            if (ent.APMemberFeedbackID > 0)
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID, ent.APApprovalProcessID.ToString(), SQLMatchType.Equal);
                IList<APMemberFeedbackEntity> list = FCCAPMemberFeedback.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (list != null && list.Count > 0)
                {
                    APMemberFeedbackEntity item = list.OrderByDescending(x => x.SequenceNo).First();

                    if (ent.SequenceNo == item.SequenceNo)
                    {
                        result = true;
                    }
                }
            }

            return result;
        }
        
        public static Boolean UpdateMemberFeedbackLastResponseDate(Int64 memberFeedbackID, DateTime date) 
        {
            Boolean result = false;

            APMemberFeedbackEntity ent = FCCAPMemberFeedback.GetFacadeCreate().GetByID(memberFeedbackID);

            if (ent.APMemberFeedbackID > 0)
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID, memberFeedbackID.ToString(), SQLMatchType.Equal);

                ent.FeedbackLastResponseDate = date;

                if (FCCAPMemberFeedback.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No) > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        public static Boolean UpdateMemberFeedbackSubmitDate(Int64 memberFeedbackID, DateTime date) 
        {
            Boolean result = false;

            APMemberFeedbackEntity ent = FCCAPMemberFeedback.GetFacadeCreate().GetByID(memberFeedbackID);

            if (ent.APMemberFeedbackID > 0)
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID, memberFeedbackID.ToString(), SQLMatchType.Equal);

                ent.FeedbackSubmitDate = date;

                if (FCCAPMemberFeedback.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No) > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        public static Boolean UpdateMemberFeedbackFeedback(Int64 memberFeedbackID, Int64 feedbackID) 
        {
            Boolean result = false;

            APMemberFeedbackEntity ent = FCCAPMemberFeedback.GetFacadeCreate().GetByID(memberFeedbackID);

            if (ent.APMemberFeedbackID > 0)
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID, memberFeedbackID.ToString(), SQLMatchType.Equal);

                if (!ent.FeedbackRequestDate.HasValue)
                {
                    ent.FeedbackRequestDate = DateTime.Now; //Write additional Code Here - Raju Dutta.
                }
                ent.APFeedbackID = feedbackID;

                if (FCCAPMemberFeedback.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No) > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        public static void SaveMembersFeedbackSequence(IList<APMemberFeedbackEntity> list)
        {
            foreach (APMemberFeedbackEntity ent in list)
            {
                APMemberFeedbackEntity new_ent = FCCAPMemberFeedback.GetFacadeCreate().GetByID(ent.APMemberFeedbackID);

                if (new_ent.APMemberFeedbackID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID, new_ent.APMemberFeedbackID.ToString(), SQLMatchType.Equal);

                    new_ent.SequenceNo = ent.SequenceNo;

                    FCCAPMemberFeedback.GetFacadeCreate().Update(new_ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
                }
            }
        }

        public static void GetAllowedFeedbacksForMemberFeedback() 
        {
            IList<APFeedbackEntity> approved_list  = new List<APFeedbackEntity>();

            IList<APFeedbackEntity> list = FCCAPFeedback.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load); 

            foreach(APFeedbackEntity ent in list)
            {
                if(!(ent.APFeedbackID == MasterDataConstants.APFeedback.NOT_YET_REQUESTED ||
                        ent.APFeedbackID == MasterDataConstants.APFeedback.FEEDBACK_REQUESTED ||
                        ent.APFeedbackID == MasterDataConstants.APFeedback.CANCELED))
                {
                    approved_list.Add(ent);
                }
            }
        }

        public static IList<APMemberFeedbackEntity> GetApprovalRequestsByMemberAndStatus(Int64 employeeID, Int64 feedbackID)
        {
            String fe_1 = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_EmployeeID, employeeID.ToString(), SQLMatchType.Equal);
            String fe_2 = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APFeedbackID, feedbackID.ToString(), SQLMatchType.Equal);
            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe_1, SQLJoinType.AND, fe_2);

            IList<APMemberFeedbackEntity> list = FCCAPMemberFeedback.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            return list;
        }
        public static IList<APMemberFeedback_DetailedEntity> GetApprovalRequests_DetailedByMemberAndStatus(Int64 employeeID, Int64 feedbackID)
        {
            String fe_1 = SqlExpressionBuilder.PrepareFilterExpression("APMemberFeedback." + APMemberFeedback_DetailedEntity.FLD_NAME_EmployeeID, employeeID.ToString(), SQLMatchType.Equal);
            String fe_2 = SqlExpressionBuilder.PrepareFilterExpression("APMemberFeedback." + APMemberFeedback_DetailedEntity.FLD_NAME_APFeedbackID, feedbackID.ToString(), SQLMatchType.Equal);
            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe_1, SQLJoinType.AND, fe_2);
            String se = SqlExpressionBuilder.PrepareSortExpression(APMemberFeedback_DetailedEntity.FLD_NAME_FeedbackSubmitDate, SQLSortOrderType.Decending);
            IList<APMemberFeedback_DetailedEntity> list = FCCAPMemberFeedback_Detailed.GetFacadeCreate().GetIL(100000, 1, se, fe);

            return list;
        }
        public static IList<APMemberFeedback_DetailedEntity> GetApprovalRequests_DetailedByProxyMember(Int64 employeeID)
        {
            String fe_1 = SqlExpressionBuilder.PrepareFilterExpression("APMemberFeedback." + APMemberFeedback_DetailedEntity.FLD_NAME_ProxyEmployeeID, employeeID.ToString(), SQLMatchType.Equal);
            String fe_2 = SqlExpressionBuilder.PrepareFilterExpression("APMemberFeedback." + APMemberFeedback_DetailedEntity.FLD_NAME_IsProxyEmployeeEnabled, "1", SQLMatchType.Equal);
            //New Added Logic Here - By Raju Dutta(10-Jul-2013) fe_3
            //Proxy Member can do proxy with feedback requested process only
            String fe_3 = SqlExpressionBuilder.PrepareFilterExpression("APMemberFeedback." + APMemberFeedbackEntity.FLD_NAME_APFeedbackID, MasterDataConstants.APFeedback.FEEDBACK_REQUESTED.ToString(), SQLMatchType.Equal);
            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe_1, SQLJoinType.AND, fe_2);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe_3);
            IList<APMemberFeedback_DetailedEntity> list = FCCAPMemberFeedback_Detailed.GetFacadeCreate().GetIL(100000, 1, String.Empty, fe);

            return list;
        }

        public static IList<APMemberFeedbackEntity> GetApprovalRequestsByMember(Int64 employeeID)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_EmployeeID, employeeID.ToString(), SQLMatchType.Equal);
            IList<APMemberFeedbackEntity> list = FCCAPMemberFeedback.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            return list;
        }
        public static IList<APMemberFeedback_DetailedEntity> GetApprovalRequests_DetailedByMember(Int64 employeeID)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("APMemberFeedback." + APMemberFeedback_DetailedEntity.FLD_NAME_EmployeeID, employeeID.ToString(), SQLMatchType.Equal);
            IList<APMemberFeedback_DetailedEntity> list = FCCAPMemberFeedback_Detailed.GetFacadeCreate().GetIL(100000, 1, String.Empty, fe);

            return list;
        }

        public static IList<APMemberFeedbackEntity> GetAllApprovalRequestsToMemberFeedback(Int64 employeeID)
        {
            String fe_1 = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_EmployeeID, employeeID.ToString(), SQLMatchType.Equal);
            String fe_2 = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APFeedbackID, MasterDataConstants.APFeedback.FEEDBACK_REQUESTED.ToString(), SQLMatchType.Equal);
            String fe_3 = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APFeedbackID, MasterDataConstants.APFeedback.ON_HOLD_BY_APPROVAL_PANEL_MEMBER.ToString(), SQLMatchType.Equal);            
            String fe_4 = SqlExpressionBuilder.PrepareFilterExpression(fe_2, SQLJoinType.OR, fe_3);
            String fe_5 = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APFeedbackID, MasterDataConstants.APFeedback.WORKING_ON_FEEDBACK.ToString(), SQLMatchType.Equal);
            String fe_6 = SqlExpressionBuilder.PrepareFilterExpression(fe_4, SQLJoinType.OR, fe_5);

            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe_1, SQLJoinType.AND, fe_6);
            
            IList<APMemberFeedbackEntity> list = FCCAPMemberFeedback.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            return list;
        }
        public static IList<APMemberFeedback_DetailedEntity> GetAllApprovalRequests_DetailedToMemberFeedback(Int64 employeeID)
        {
            String fe_1 = SqlExpressionBuilder.PrepareFilterExpression("APMemberFeedback." + APMemberFeedback_DetailedEntity.FLD_NAME_EmployeeID, employeeID.ToString(), SQLMatchType.Equal);
            String fe_2 = SqlExpressionBuilder.PrepareFilterExpression("APMemberFeedback." + APMemberFeedback_DetailedEntity.FLD_NAME_APFeedbackID, MasterDataConstants.APFeedback.FEEDBACK_REQUESTED.ToString(), SQLMatchType.Equal);
            String fe_3 = SqlExpressionBuilder.PrepareFilterExpression("APMemberFeedback." + APMemberFeedback_DetailedEntity.FLD_NAME_APFeedbackID, MasterDataConstants.APFeedback.ON_HOLD_BY_APPROVAL_PANEL_MEMBER.ToString(), SQLMatchType.Equal);
            String fe_4 = SqlExpressionBuilder.PrepareFilterExpression(fe_2, SQLJoinType.OR, fe_3);
            String fe_5 = SqlExpressionBuilder.PrepareFilterExpression("APMemberFeedback." + APMemberFeedback_DetailedEntity.FLD_NAME_APFeedbackID, MasterDataConstants.APFeedback.WORKING_ON_FEEDBACK.ToString(), SQLMatchType.Equal);
            String fe_6 = SqlExpressionBuilder.PrepareFilterExpression(fe_4, SQLJoinType.OR, fe_5);
            //String fe_7 = SqlExpressionBuilder.PrepareFilterExpression("APMemberFeedback." + APMemberFeedback_DetailedEntity.FLD_NAME_APFeedbackID, MasterDataConstants.APFeedback.FORWARDED.ToString(), SQLMatchType.Equal);
           // String fe_8 = SqlExpressionBuilder.PrepareFilterExpression(fe_6, SQLJoinType.OR, fe_7);
            String fe_9 = SqlExpressionBuilder.PrepareFilterExpression("APMemberFeedback." + APMemberFeedback_DetailedEntity.FLD_NAME_APFeedbackID, MasterDataConstants.APFeedback.FORWARD_RESPONSE_RECEIVED.ToString(), SQLMatchType.Equal);
            String fe_10 = SqlExpressionBuilder.PrepareFilterExpression(fe_6, SQLJoinType.OR, fe_9);

            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe_1, SQLJoinType.AND, fe_10);

            IList<APMemberFeedback_DetailedEntity> list = FCCAPMemberFeedback_Detailed.GetFacadeCreate().GetIL(100000, 1, String.Empty, fe);

            return list;
        }

        public static IList<APMemberFeedbackEntity> GetNewApprovalRequestsToMemberFeedback(Int64 employeeID) 
        {
            String fe_1 = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_EmployeeID, employeeID.ToString(), SQLMatchType.Equal);
            String fe_2 = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APFeedbackID, MasterDataConstants.APFeedback.FEEDBACK_REQUESTED.ToString(), SQLMatchType.Equal);
            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe_1, SQLJoinType.AND, fe_2);
            
            IList<APMemberFeedbackEntity> list = FCCAPMemberFeedback.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            return list;
        }

        #endregion

        #region AP Panel Forward Member

        public static APPanelForwardMemberEntity GetAPPanelForwardMemberByID(Int64 aPPanelForwardMemberID)
        {
            return FCCAPPanelForwardMember.GetFacadeCreate().GetByID(aPPanelForwardMemberID);
        }

        public static IList<APPanelForwardMember_DetailedEntity> GetAPPanelForwardMemberByApprovalProcessTypeAndReferenceID(Int64 approvalProcessType, Int64 referenceID)
        {
            APPanelEntity panel = APRobot.GetPanelByApprovalProcessType(approvalProcessType, referenceID);

            String fe = SqlExpressionBuilder.PrepareFilterExpression("APPanelForwardMember." + APPanelForwardMember_DetailedEntity.FLD_NAME_APPanelID, panel.APPanelID.ToString(), SQLMatchType.Equal); 

            IList<APPanelForwardMember_DetailedEntity> list = FCCAPPanelForwardMember_Detailed.GetFacadeCreate().GetIL(1000, 1, String.Empty, fe);

            return list;
        }

        #endregion

        #region AP Forward Info

        public static APForwardInfo_DetailedEntity GetAPForwardInfo_DetailedByRemarksID(Int64 aPMemberFeedbackRemarksID)             
        {
            APForwardInfo_DetailedEntity ent = new APForwardInfo_DetailedEntity();

            String fe = SqlExpressionBuilder.PrepareFilterExpression("APForwardInfo." + APForwardInfo_DetailedEntity.FLD_NAME_APMemberFeedbackRemarksID, aPMemberFeedbackRemarksID.ToString(), SQLMatchType.Equal);

            IList<APForwardInfo_DetailedEntity> list = FCCAPForwardInfo_Detailed.GetFacadeCreate().GetIL(1, 1, String.Empty, fe);

            if (list != null && list.Count > 0)
            {
                ent = list[0];
            }

            return ent;
        }

        public static IList<APForwardInfo_DetailedEntity> GetAPForwardInfo_DetailedByEmployee(Int64 employeeID)
        {
            APForwardInfo_DetailedEntity ent = new APForwardInfo_DetailedEntity();

            String fe = SqlExpressionBuilder.PrepareFilterExpression("APForwardInfo." + APForwardInfo_DetailedEntity.FLD_NAME_EmployeeID, employeeID.ToString(), SQLMatchType.Equal);
            String fe1="APForwardInfo.CommentSubmitDate is null";

            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);

            String fe3 = "APApprovalProcessID in(Select APApprovalProcessID from APApprovalProcess where APStatusID<>" + MasterDataConstants.APStatus.COMPLETED + " AND APApprovalProcess.APApprovalProcessID=APForwardInfo.APApprovalProcessID)";

            fe = SqlExpressionBuilder.PrepareFilterExpression(fe2, SQLJoinType.AND, fe3);

            IList<APForwardInfo_DetailedEntity> list = FCCAPForwardInfo_Detailed.GetFacadeCreate().GetIL(100000, 1, String.Empty, fe);

            return list;
        }

        public static IList<APForwardInfo_DetailedEntity> GetMyAPForwardInfo_DetailedByEmployee(Int64 employeeID)
        {
            APForwardInfo_DetailedEntity ent = new APForwardInfo_DetailedEntity();

            String fe = SqlExpressionBuilder.PrepareFilterExpression("APForwardInfo." + APForwardInfo_DetailedEntity.FLD_NAME_EmployeeID, employeeID.ToString(), SQLMatchType.Equal);
            String fe1 = "APForwardInfo.CommentSubmitDate is not null";

            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
            String se = SqlExpressionBuilder.PrepareSortExpression(APForwardInfo_DetailedEntity.FLD_NAME_CommentSubmitDate, SQLSortOrderType.Decending);
            //String fe3 = "APApprovalProcessID in(Select APApprovalProcessID from APApprovalProcess where APStatusID<>" + MasterDataConstants.APStatus.COMPLETED + " AND APApprovalProcess.APApprovalProcessID=APForwardInfo.APApprovalProcessID)";

            //fe = SqlExpressionBuilder.PrepareFilterExpression(fe2, SQLJoinType.AND, fe3);
            fe = fe2;
            IList<APForwardInfo_DetailedEntity> list = FCCAPForwardInfo_Detailed.GetFacadeCreate().GetIL(100000, 1, se, fe);

            return list;
        }


        public static Boolean UpdateAPForwardInfo(Int64 aPForwardInfoID, String forwardMemberComment)
        {
            APForwardInfoEntity ent = FCCAPForwardInfo.GetFacadeCreate().GetByID(aPForwardInfoID);

            ent.APForwardMemberComment = forwardMemberComment;
            ent.CommentSubmitDate = DateTime.Now;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(APForwardInfoEntity.FLD_NAME_APForwardInfoID, ent.APForwardInfoID.ToString(), SQLMatchType.Equal);

            Int64 result = FCCAPForwardInfo.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        #endregion

        #region Requisition

        public static void UpdateRequisitionStatus(Int64 requisitionID, Int64 requisitionStatus)
        {
            REQRequisitionEntity ent = FCCREQRequisition.GetFacadeCreate().GetByID(requisitionID);

            ent.RequisitionStatusID = requisitionStatus;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionEntity.FLD_NAME_RequisitionID, requisitionID.ToString(), SQLMatchType.Equal);

            FCCREQRequisition.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
        }

        #endregion

        #region Work Order

        public static void UpdateWorkOrderStatus(Int64 workOrderID, Int64 workOrderStatus)
        {
            PRMWorkOrderEntity ent = FCCPRMWorkOrder.GetFacadeCreate().GetByID(workOrderID);

            ent.WorkOrderStatusID = workOrderStatus;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderEntity.FLD_NAME_WorkOrderID, workOrderID.ToString(), SQLMatchType.Equal);

            FCCPRMWorkOrder.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
        }

        #endregion

        #region Bill

        public static void UpdateBillApprovalStatus(Int64 billID, Int64 billApprovalStatus)
        {
            CMBillEntity ent = FCCCMBill.GetFacadeCreate().GetByID(billID);

            ent.BillApprovalStatusID = billApprovalStatus;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(CMBillEntity.FLD_NAME_BillID, billID.ToString(), SQLMatchType.Equal);

            FCCCMBill.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
        }

        #endregion

        #region TRF

        public static void UpdateTRFStatus(Int64 invTransferID, Int64 invtransferStatus)
        {
            INVTransferEntity ent = FCCINVTransfer.GetFacadeCreate().GetByID(invTransferID);

            ent.InventoryTransferStatusID = invtransferStatus;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(INVTransferEntity.FLD_NAME_TransferID, invTransferID.ToString(), SQLMatchType.Equal);

            FCCINVTransfer.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
        }

        #endregion

        #region PayableStatement Detail

        public static void UpdatePayableStatementDetailApprovalStatus(Int64 payableStatementDetailID, Int64 payableStatementApprovalStatus)
        {
            ACCPostPayableStatementDetailEntity ent = FCCACCPostPayableStatementDetail.GetFacadeCreate().GetByID(payableStatementDetailID);

            ent.ACCPayableApprovalStatusID = payableStatementApprovalStatus;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCPostPayableStatementDetailEntity.FLD_NAME_PostPayableStatementDetailID, payableStatementDetailID.ToString(), SQLMatchType.Equal);

            FCCACCPostPayableStatementDetail.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
        }

        #endregion

        #region Bank Deposit

        public static void UpdateBankDepositStatus(Int64 bankDepositID, Int64 bankDepositStatus)
        {
            ACBankAccountDepositEntity ent = FCCACBankAccountDeposit.GetFacadeCreate().GetByID(bankDepositID);

            ent.BankAccountDepositApprovalStatusID = bankDepositStatus;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountDepositEntity.FLD_NAME_BankAccountDepositID, bankDepositID.ToString(), SQLMatchType.Equal);

            FCCACBankAccountDeposit.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
        }

        #endregion

        #region Bank Payment

        public static void UpdateBankPaymentStatus(Int64 bankPaymentID, Int64 bankPaymentStatus)
        {
            ACBankAccountPaymentEntity ent = FCCACBankAccountPayment.GetFacadeCreate().GetByID(bankPaymentID);

            ent.BankAccountPaymentApprovalStatusID = bankPaymentStatus;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountPaymentEntity.FLD_NAME_BankAccountPaymentID, bankPaymentID.ToString(), SQLMatchType.Equal);

            FCCACBankAccountPayment.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
        }

        #endregion

        #region Temporary Journal 

        public static void UpdateTemporaryJournalStatus(Int64 temporaryJournalID, Int64 temporaryJournalStatus)
        {
            ACTemporaryJournalMasterEntity ent = FCCACTemporaryJournalMaster.GetFacadeCreate().GetByID(temporaryJournalID);

            ent.TemporyJournalApprovalStatusID = temporaryJournalStatus;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(ACTemporaryJournalMasterEntity.FLD_NAME_TemporaryJournalMasterID, temporaryJournalID.ToString(), SQLMatchType.Equal);

            FCCACTemporaryJournalMaster.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
        }

        #endregion

        #region Bank Account Transfer

        public static void UpdateBankAccountTransferStatus(Int64 bankAccountTransferID, Int64 bankAccountTransferStatus)
        {
            ACBankAccountTransferEntity ent = FCCACBankAccountTransfer.GetFacadeCreate().GetByID(bankAccountTransferID);

            ent.BankAccountTransferApprovalStatusID = bankAccountTransferStatus;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountTransferEntity.FLD_NAME_BankAccountTransferID, bankAccountTransferID.ToString(), SQLMatchType.Equal);

            FCCACBankAccountTransfer.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
        }

        #endregion

        #region MRR

        public static void UpdateMaterialReceiveStatus(Int64 materialReceiveID, Int64 materialReceiveApprovalStatus)
        {
            PRMMaterialReceiveEntity ent = FCCPRMMaterialReceive.GetFacadeCreate().GetByID(materialReceiveID);

            ent.MaterialReceiveApprovalStatusID = materialReceiveApprovalStatus;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveEntity.FLD_NAME_MaterialReceiveID, materialReceiveID.ToString(), SQLMatchType.Equal);

            FCCPRMMaterialReceive.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
        }

        #endregion

        #region Agreement

        public static void UpdateAgreementStatus(Int64 agreementID, Int64 agreementStatus)
        {
            CRMAgreementEntity ent = FCCCRMAgreement.GetFacadeCreate().GetByID(agreementID);

            ent.AgreementApprovalStatusID = agreementStatus;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementEntity.FLD_NAME_AgreementID, agreementID.ToString(), SQLMatchType.Equal);

            FCCCRMAgreement.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
        }

        #endregion

        #region Agreement

        public static void UpdateAssignedResourceProcessStatus(Int64 processResourceID, Int64 approvalStatus)
        {
            BDProcessAssignedResourceEntity ent = FCCBDProcessAssignedResource.GetFacadeCreate().GetByID(processResourceID);

            ent.ProcessAssignedResourceApprovalStatusID = approvalStatus;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceEntity.FLD_NAME_ProcessAssignedResourceID, processResourceID.ToString(), SQLMatchType.Equal);

            FCCBDProcessAssignedResource.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
        }

        #endregion

        #region Loan Application

        public static void UpdateLoanApplicationApprovalStatus(Int64 LoanApplicationID, Int64 approvalStatus)
        {
            HREmployeeLoanApplicationEntity ent = FCCHREmployeeLoanApplication.GetFacadeCreate().GetByID(LoanApplicationID);

            ent.EmployeeLoanApprovalStatusID = approvalStatus;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeLoanApplicationEntity.FLD_NAME_EmployeeLoanApplicationID, LoanApplicationID.ToString(), SQLMatchType.Equal);

            FCCHREmployeeLoanApplication.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
        }

        #endregion


        #region Leave Application

        public static void UpdateLeaveApplicationApprovalStatus(Int64 LeaveApplicationID, Int64 approvalStatus)
        {
            HREmployeeLeaveApplicationEntity ent = FCCHREmployeeLeaveApplication.GetFacadeCreate().GetByID(LeaveApplicationID);

            ent.LeaveApplicationApplicationStatusID = approvalStatus;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeLeaveApplicationEntity.FLD_NAME_EmployeeLeaveApplicationID, LeaveApplicationID.ToString(), SQLMatchType.Equal);

            FCCHREmployeeLeaveApplication.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
        }

        #endregion

        #region Duduction Requisiton Qty

        public static void UpdateBOQorProjectCostQty(Int64 materialReceiveID)
        {
            PRMMaterialReceiveEntity pRMMaterialReceiveEntity = FCCPRMMaterialReceive.GetFacadeCreate().GetByID(materialReceiveID);

            if (pRMMaterialReceiveEntity != null && pRMMaterialReceiveEntity.MaterialReceiveID > 0)
            {
                Int64 requisitionID = pRMMaterialReceiveEntity.RequisitionID;
                REQRequisitionEntity _rEQrequisitonEntity = FCCREQRequisition.GetFacadeCreate().GetByID(requisitionID);

                if (_rEQrequisitonEntity != null)
                {
                    String fe_requistionItem = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionID, requisitionID.ToString(), SQLMatchType.Equal);
                    IList<REQRequisitionItemEntity> lstRequisitionItem = FCCREQRequisitionItem.GetFacadeCreate().GetIL(null, null, String.Empty, fe_requistionItem, DatabaseOperationType.LoadWithFilterExpression);

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_ProjectID, _rEQrequisitonEntity.ProjectID.ToString(), SQLMatchType.Equal);
                    IList<PRMPreBOQEntity> preBOQList = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (preBOQList != null && preBOQList.Count > 0)
                    {
                        PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity = new PRMAvailableBOQQtyForRequisitionEntity();

                        if (preBOQList[0].IsLocked == false)
                        {
                            pRMAvailableBOQQtyForRequisitionEntity.IsBOQ = false;

                            #region PreBOQ Qty Update

                            if (lstRequisitionItem != null && lstRequisitionItem.Count > 0)
                            {
                                String fe_PreBOQDetail = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_PreBOQID, preBOQList[0].PreBOQID.ToString(), SQLMatchType.Equal);
                                IList<PRMPreBOQDetailEntity> lstPreBOQDetail = FCCPRMPreBOQDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_PreBOQDetail, DatabaseOperationType.LoadWithFilterExpression);

                                if (lstPreBOQDetail != null && lstPreBOQDetail.Count > 0)
                                {
                                   

                                    foreach (REQRequisitionItemEntity ent in lstRequisitionItem)
                                    {
                                        PRMPreBOQDetailEntity _PRMPreBOQDetailEntity = (from s in lstPreBOQDetail
                                                                                        where s.ItemID == ent.ItemID
                                                                                        select s).First();

                                        if (_PRMPreBOQDetailEntity != null)
                                        {
                                            Decimal requisitionPresentRequiredQty, prmPreBOQTotalQty, resultQty;
                                            Decimal.TryParse(ent.PresentRequiredQty.ToString(), out requisitionPresentRequiredQty);
                                            Decimal.TryParse(_PRMPreBOQDetailEntity.TotalQty.ToString(), out prmPreBOQTotalQty);
                                            resultQty = prmPreBOQTotalQty - requisitionPresentRequiredQty;
                                            _PRMPreBOQDetailEntity.TotalQty = resultQty;
                                            String fe_PreBOQDetailUpdate = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_PreBOQDetailID, _PRMPreBOQDetailEntity.PreBOQDetailID.ToString(), SQLMatchType.Equal);
                                            Int64 resultPreBOQDetail = FCCPRMPreBOQDetail.GetFacadeCreate().Update(_PRMPreBOQDetailEntity, fe_PreBOQDetailUpdate, DatabaseOperationType.Update, TransactionRequired.No);

                                            if (resultPreBOQDetail > 0)
                                            {
                                                #region PreBOQ Floor Detail

                                                String fe_projectFloor = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQFloorDetailEntity.FLD_NAME_PreBOQDetailID, resultPreBOQDetail.ToString(), SQLMatchType.Equal);
                                                IList<PRMPreBOQFloorDetailEntity> lstPRMPreBOQFloorDetail = FCCPRMPreBOQFloorDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_projectFloor, DatabaseOperationType.LoadWithFilterExpression);

                                                if (lstPRMPreBOQFloorDetail != null && lstPRMPreBOQFloorDetail.Count > 0)
                                                {
                                                    Int64 totalfloorCount = lstPRMPreBOQFloorDetail.Count;
                                                    Decimal avgQty = resultQty / totalfloorCount;

                                                    foreach (PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity in lstPRMPreBOQFloorDetail)
                                                    {
                                                        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQFloorDetailEntity.FLD_NAME_PreBOQFloorDetailID, pRMPreBOQFloorDetailEntity.PreBOQFloorDetailID.ToString(), SQLMatchType.Equal);
                                                        pRMPreBOQFloorDetailEntity.Qty = avgQty;
                                                        FCCPRMPreBOQFloorDetail.GetFacadeCreate().Update(pRMPreBOQFloorDetailEntity, fe1, DatabaseOperationType.Update, TransactionRequired.No);
                                                    }
                                                }

                                                #endregion
                                            }
                                        }

                                    }
                                }
                            }

                            #endregion
                        }
                        else if (preBOQList[0].IsLocked == true)
                        {
                            pRMAvailableBOQQtyForRequisitionEntity.IsBOQ = true;

                            #region BOQ Qty Update

                            String fe_BOQ = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQEntity.FLD_NAME_PreBOQID, preBOQList[0].PreBOQID.ToString(), SQLMatchType.Equal);
                            IList<PRMBOQEntity> lstBOQ = FCCPRMBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe_BOQ, DatabaseOperationType.LoadWithFilterExpression);

                            if (lstRequisitionItem != null && lstRequisitionItem.Count > 0)
                            {
                                String fe_BOQDetail = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_BOQID, lstBOQ[0].BOQID.ToString(), SQLMatchType.Equal);
                                IList<PRMBOQDetailEntity> lstBOQDetail = FCCPRMBOQDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_BOQDetail, DatabaseOperationType.LoadWithFilterExpression);

                                if (lstBOQDetail != null && lstBOQDetail.Count > 0)
                                {
                                    foreach (REQRequisitionItemEntity ent in lstRequisitionItem)
                                    {
                                        PRMBOQDetailEntity _PRMBOQDetailEntity = (from s in lstBOQDetail
                                                                                  where s.ItemID == ent.ItemID
                                                                                  select s).First();

                                        if (_PRMBOQDetailEntity != null)
                                        {
                                            Decimal requisitionPresentRequiredQty, prmPreBOQTotalQty, resultQty;
                                            Decimal.TryParse(ent.PresentRequiredQty.ToString(), out requisitionPresentRequiredQty);
                                            Decimal.TryParse(_PRMBOQDetailEntity.TotalQty.ToString(), out prmPreBOQTotalQty);
                                            resultQty = prmPreBOQTotalQty - requisitionPresentRequiredQty;
                                            _PRMBOQDetailEntity.TotalQty = resultQty;
                                            String fe_BOQDetailUpdate = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_BOQDetailID, _PRMBOQDetailEntity.BOQDetailID.ToString(), SQLMatchType.Equal);
                                            Int64 boqDetailID = FCCPRMBOQDetail.GetFacadeCreate().Update(_PRMBOQDetailEntity, fe_BOQDetailUpdate, DatabaseOperationType.Update, TransactionRequired.No);

                                            if (boqDetailID > 0)
                                            {
                                                #region BOQ Floor Detail

                                                String fe_projectFloor = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQFloorDetailEntity.FLD_NAME_BOQDetailID, boqDetailID.ToString(), SQLMatchType.Equal);
                                                IList<PRMBOQFloorDetailEntity> lstPRMBOQFloorDetail = FCCPRMBOQFloorDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_projectFloor, DatabaseOperationType.LoadWithFilterExpression);

                                                if (lstPRMBOQFloorDetail != null && lstPRMBOQFloorDetail.Count > 0)
                                                {
                                                    Int64 totalfloorCount = lstPRMBOQFloorDetail.Count;
                                                    Decimal avgQty = resultQty / totalfloorCount;

                                                    foreach (PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity in lstPRMBOQFloorDetail)
                                                    {
                                                        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQFloorDetailEntity.FLD_NAME_BOQFloorDetailID, pRMBOQFloorDetailEntity.BOQFloorDetailID.ToString(), SQLMatchType.Equal);
                                                        pRMBOQFloorDetailEntity.Qty = avgQty;
                                                        FCCPRMBOQFloorDetail.GetFacadeCreate().Update(pRMBOQFloorDetailEntity, fe1, DatabaseOperationType.Update, TransactionRequired.No);
                                                    }
                                                }

                                                #endregion
                                            }
                                        }

                                    }
                                }
                            }

                            #endregion
                        }

                        //Will need to implement this section when available qty applicable for requisition

                        //pRMAvailableBOQQtyForRequisitionEntity.Qty = -pRMMaterialReceiveItemMapEntity.ReceiveQty;
                        //pRMAvailableBOQQtyForRequisitionEntity.CreateDate = DateTime.Now;
                        //pRMAvailableBOQQtyForRequisitionEntity.CreatedByEmployeeID = 168;//Not So valuable Here, It'll replaced by system Admin
                        //pRMAvailableBOQQtyForRequisitionEntity.ProjectID = _rEQrequisitonEntity.ProjectID;
                        //Int64 result = -1;
                        //result = FCCPRMAvailableBOQQtyForRequisition.GetFacadeCreate().Add(pRMAvailableBOQQtyForRequisitionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                }
            }
        }

        #endregion

        #region Generate Mail Message

        public static void GenerateMailMessage(Int64 approvalProcessType, Int64 aPFeedback, String[] premLink = null, Int64 referenceID=0)
        {
            StringBuilder sb = new StringBuilder();

            REQRequisitionEntity rEQRequisitionEntity = new REQRequisitionEntity();
            PRMWorkOrderEntity pRMWorkOrderEntity = new PRMWorkOrderEntity();
            CMBillEntity cMBillEntity = new CMBillEntity();
            INVTransferEntity iNVTransferEntity = new INVTransferEntity();
            ACCPrePayableStatementDetailEntity aCCPrePayableStatementDetailEntity = new ACCPrePayableStatementDetailEntity();
            ACBankAccountDepositEntity aCBankAccountDepositEntity = new ACBankAccountDepositEntity();
            ACBankAccountPaymentEntity aCBankAccountPaymentEntity = new ACBankAccountPaymentEntity();
            PRMMaterialReceiveEntity pRMMaterialReceiveEntity = new PRMMaterialReceiveEntity();
            CRMAgreementEntity cRMAgreementEntity = new CRMAgreementEntity();
            BDProcessAssignedResourceEntity bDProcessAssignedResourceEntity = new BDProcessAssignedResourceEntity();
            ACTemporaryJournalEntity aCTemporaryJournalEntity = new ACTemporaryJournalEntity();
            ACBankAccountTransferEntity aCBankAccountTransferEntity = new ACBankAccountTransferEntity();
            HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity = new HREmployeeLeaveApplicationEntity();
            HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity = new HREmployeeLoanApplicationEntity();
            //ACTemp
            //ACCPay

            switch (approvalProcessType)
            {
                case MasterDataConstants.APType.REQUISITION:
                    rEQRequisitionEntity = FCCREQRequisition.GetFacadeCreate().GetByID(referenceID);
                    break;
                case MasterDataConstants.APType.WORK_ORDER:
                    pRMWorkOrderEntity = FCCPRMWorkOrder.GetFacadeCreate().GetByID(referenceID);
                    break;
                case MasterDataConstants.APType.BILL:
                    cMBillEntity = FCCCMBill.GetFacadeCreate().GetByID(referenceID);
                    break;
                case MasterDataConstants.APType.CUSTOM:
                    break;
                case MasterDataConstants.APType.PAYABLE_STATEMENT:
                    aCCPrePayableStatementDetailEntity = FCCACCPrePayableStatementDetail.GetFacadeCreate().GetByID(referenceID);
                    break;
                case MasterDataConstants.APType.TRF:
                    iNVTransferEntity = FCCINVTransfer.GetFacadeCreate().GetByID(referenceID);
                    break;
                case MasterDataConstants.APType.BANK_DEPOSIT:
                    aCBankAccountDepositEntity = FCCACBankAccountDeposit.GetFacadeCreate().GetByID(referenceID);
                    break;
                case MasterDataConstants.APType.BANK_PAYMENT:
                    aCBankAccountPaymentEntity = FCCACBankAccountPayment.GetFacadeCreate().GetByID(referenceID);
                    break;
                case MasterDataConstants.APType.TEMPORARY_JOURNAL:
                    aCTemporaryJournalEntity = FCCACTemporaryJournal.GetFacadeCreate().GetByID(referenceID);
                    break;
                case MasterDataConstants.APType.BANK_ACCOUNT_TRANSFER:
                    aCBankAccountTransferEntity = FCCACBankAccountTransfer.GetFacadeCreate().GetByID(referenceID);
                    break;
                case MasterDataConstants.APType.MRR:
                    pRMMaterialReceiveEntity = FCCPRMMaterialReceive.GetFacadeCreate().GetByID(referenceID);
                    break;
                case MasterDataConstants.APType.AGREEMENT:
                    cRMAgreementEntity = FCCCRMAgreement.GetFacadeCreate().GetByID(referenceID);
                    break;
                case MasterDataConstants.APType.CONTACT_LIST:
                    bDProcessAssignedResourceEntity = FCCBDProcessAssignedResource.GetFacadeCreate().GetByID(referenceID);
                    break;
                case MasterDataConstants.APType.LEAVE_APPLICATION:
                    hREmployeeLeaveApplicationEntity = FCCHREmployeeLeaveApplication.GetFacadeCreate().GetByID(referenceID);
                    break;
                case MasterDataConstants.APType.LOAN_APPLICATION:
                    hREmployeeLoanApplicationEntity = FCCHREmployeeLoanApplication.GetFacadeCreate().GetByID(referenceID);
                    break;
            }


            #region Approved

            if (approvalProcessType == MasterDataConstants.APType.REQUISITION && aPFeedback == MasterDataConstants.APFeedback.APPROVED)
            {
                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Requisition Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='"+premLink[0]+"'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                Subject = "ERP, Requisition "+ rEQRequisitionEntity.RequisitionNo + " , Approval Request";
                MailBody = sb.ToString();
            }

            else if (approvalProcessType == MasterDataConstants.APType.WORK_ORDER && aPFeedback == MasterDataConstants.APFeedback.APPROVED)
            {
                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A WorkOrder Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network, Please click the following link");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, WorkOrder "+pRMWorkOrderEntity.WorkOrderNo + " , Approval Request";
                
            }

            else if (approvalProcessType == MasterDataConstants.APType.BILL && aPFeedback == MasterDataConstants.APFeedback.APPROVED)
            {
                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Bill Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Bill "+cMBillEntity.BillNo+" , Approval Request";
                
            }

            else if (approvalProcessType == MasterDataConstants.APType.CUSTOM && aPFeedback == MasterDataConstants.APFeedback.APPROVED)
            {
                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Custom Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, CUSTOM, Approval Request";
            }

            else if (approvalProcessType == MasterDataConstants.APType.PAYABLE_STATEMENT && aPFeedback == MasterDataConstants.APFeedback.APPROVED)
            {
                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Payable Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Payable "+aCCPrePayableStatementDetailEntity.AccountPaybleStatementDetailCategoryID+" , Approval Request";
            }

            else if (approvalProcessType == MasterDataConstants.APType.TRF && aPFeedback == MasterDataConstants.APFeedback.APPROVED)
            {
                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A TRF Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, TRF "+ iNVTransferEntity.TRFNo + " , Approval Request";
            }

            else if (approvalProcessType == MasterDataConstants.APType.BANK_DEPOSIT && aPFeedback == MasterDataConstants.APFeedback.APPROVED)
            {
                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Bank Account Deposit Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Bank Account Deposit "+ aCBankAccountDepositEntity.Reference +" , Approval Request";
            }

            else if (approvalProcessType == MasterDataConstants.APType.BANK_PAYMENT && aPFeedback == MasterDataConstants.APFeedback.APPROVED)
            {
                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Bank Account Payment Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Bank Account Payment "+aCBankAccountPaymentEntity.Reference+" , Approval Request";
            }

            else if (approvalProcessType == MasterDataConstants.APType.TEMPORARY_JOURNAL && aPFeedback == MasterDataConstants.APFeedback.APPROVED)
            {
                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Journal Entry Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Journal Entry "+aCTemporaryJournalEntity.ReferenceOrMemoOrID+" , Approval Request";
            }

            else if (approvalProcessType == MasterDataConstants.APType.BANK_ACCOUNT_TRANSFER && aPFeedback == MasterDataConstants.APFeedback.APPROVED)
            {
                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Bank Account Transfer Entry Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Bank Account Transfer Entry "+ aCBankAccountTransferEntity.Memo+" , Approval Request";
            }

            else if (approvalProcessType == MasterDataConstants.APType.MRR && aPFeedback == MasterDataConstants.APFeedback.APPROVED)
            {
                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A MRR Entry Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, MRR "+pRMMaterialReceiveEntity.MRRNo+" , Approval Request";
            }

            else if (approvalProcessType == MasterDataConstants.APType.AGREEMENT && aPFeedback == MasterDataConstants.APFeedback.APPROVED)
            {
                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Agreement Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, AGREEMENT "+cRMAgreementEntity.AgreementDate+" , Approval Request";
            }

            else if (approvalProcessType == MasterDataConstants.APType.CONTACT_LIST && aPFeedback == MasterDataConstants.APFeedback.APPROVED)
            {
                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Contact List Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Contact List "+bDProcessAssignedResourceEntity.Title +" , Approval Request";
            }

            else if (approvalProcessType == MasterDataConstants.APType.LEAVE_APPLICATION && aPFeedback == MasterDataConstants.APFeedback.APPROVED)
            {
                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Leave Application Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Leave Application , Approval Request";
            }

            else if (approvalProcessType == MasterDataConstants.APType.LOAN_APPLICATION && aPFeedback == MasterDataConstants.APFeedback.APPROVED)
            {
                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Loan Application Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Loan Application , Approval Request";
            }

            #endregion

            #region Rejected

            if (approvalProcessType == MasterDataConstants.APType.REQUISITION && aPFeedback == MasterDataConstants.APFeedback.REJECTED)
            {
                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Requisition Request is  canceled / rejected by the seniors");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Requisition" + rEQRequisitionEntity.RequisitionNo + " , Rejected";
            }

            else if (approvalProcessType == MasterDataConstants.APType.WORK_ORDER && aPFeedback == MasterDataConstants.APFeedback.REJECTED)
            {

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A WorkOrder Request is  canceled / rejected by the seniors");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, WorkOrder " + pRMWorkOrderEntity.WorkOrderNo + " , Update";
            }

            else if (approvalProcessType == MasterDataConstants.APType.BILL && aPFeedback == MasterDataConstants.APFeedback.REJECTED)
            {

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Bill Request is  canceled / rejected by the seniors");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Bill " + cMBillEntity.BillNo + " , Update";
                MailBody = @"Please note that a Bill that you have applied has been canceled / rejected by the seniors.Your application has been archived.-Thanks ERP System";
            }

            else if (approvalProcessType == MasterDataConstants.APType.TRF && aPFeedback == MasterDataConstants.APFeedback.REJECTED)
            {

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A TRF Request is  canceled / rejected by the seniors");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, TRF " + iNVTransferEntity.TRFNo + " , Update";
                MailBody = @"Please note that a TRF that you have applied has been canceled / rejected by the seniors.Your application has been archived.-Thanks ERP System";
            }

            else if (approvalProcessType == MasterDataConstants.APType.CUSTOM && aPFeedback == MasterDataConstants.APFeedback.REJECTED)
            {

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Custom Request is  canceled / rejected by the seniors");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, CUSTOM, Update";
            }

            else if (approvalProcessType == MasterDataConstants.APType.PAYABLE_STATEMENT && aPFeedback == MasterDataConstants.APFeedback.REJECTED)
            {

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Payable Request is  canceled / rejected by the seniors");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Payable " + aCCPrePayableStatementDetailEntity.AccountPaybleStatementDetailCategoryID + " , Update";
            }

            else if (approvalProcessType == MasterDataConstants.APType.BANK_DEPOSIT && aPFeedback == MasterDataConstants.APFeedback.REJECTED)
            {

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Bank Account Deposit Request is  canceled / rejected by the seniors");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Bank Account Deposit " + aCBankAccountDepositEntity.Reference + " , Update";
            }

            else if (approvalProcessType == MasterDataConstants.APType.BANK_PAYMENT && aPFeedback == MasterDataConstants.APFeedback.REJECTED)
            {

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Bank Account Payment Request is  canceled / rejected by the seniors");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Bank Account Payment " + aCBankAccountPaymentEntity.Reference + " , Update";
            }

            else if (approvalProcessType == MasterDataConstants.APType.TEMPORARY_JOURNAL && aPFeedback == MasterDataConstants.APFeedback.REJECTED)
            {

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Bank Journal Request is  canceled / rejected by the seniors");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Journal Entry " + aCTemporaryJournalEntity.ReferenceOrMemoOrID + " , Update";
            }

            else if (approvalProcessType == MasterDataConstants.APType.BANK_ACCOUNT_TRANSFER && aPFeedback == MasterDataConstants.APFeedback.REJECTED)
            {

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Bank Account Transfer Request is  canceled / rejected by the seniors");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Bank Account Transfer Entry " + aCBankAccountTransferEntity.Memo + " , Update";
            }

            else if (approvalProcessType == MasterDataConstants.APType.MRR && aPFeedback == MasterDataConstants.APFeedback.REJECTED)
            {

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A MRR Request is  canceled / rejected by the seniors");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, MRR " + pRMMaterialReceiveEntity.MRRNo + " , Update";
            }

            else if (approvalProcessType == MasterDataConstants.APType.AGREEMENT && aPFeedback == MasterDataConstants.APFeedback.REJECTED)
            {

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Agreement Request is  canceled / rejected by the seniors");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, AGREEMENT " + cRMAgreementEntity.AgreementDate + " , Update";
            }

            else if (approvalProcessType == MasterDataConstants.APType.AGREEMENT && aPFeedback == MasterDataConstants.APFeedback.REJECTED)
            {

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Contact List Request is  canceled / rejected by the seniors");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Contact List " + bDProcessAssignedResourceEntity.Title + " , Update";
            }

            else if (approvalProcessType == MasterDataConstants.APType.LEAVE_APPLICATION && aPFeedback == MasterDataConstants.APFeedback.REJECTED)
            {

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Leave Application Request is  canceled / rejected by the seniors");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Leave Application , Update";
            }

            else if (approvalProcessType == MasterDataConstants.APType.LOAN_APPLICATION && aPFeedback == MasterDataConstants.APFeedback.REJECTED)
            {

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Loan Application Request is  canceled / rejected by the seniors");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Loan Application , Update";
            }

            #endregion

            #region Forwarded

            if (approvalProcessType == MasterDataConstants.APType.REQUISITION && aPFeedback == MasterDataConstants.APFeedback.FORWARDED)
            {
                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Requisition Forwarded Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Requsition, Forwarded";
            }

            else if (approvalProcessType == MasterDataConstants.APType.WORK_ORDER && aPFeedback == MasterDataConstants.APFeedback.FORWARDED)
            {

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A WorkOrder Forwarded Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, WorkOrder, Forwarded";
            }

            else if (approvalProcessType == MasterDataConstants.APType.BILL && aPFeedback == MasterDataConstants.APFeedback.FORWARDED)
            {

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Bill Request is Forwarded Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Bill, Forwarded";
                MailBody = @"Please note that a Bill is Forwarded.-Thanks ERP System";
            }

            else if (approvalProcessType == MasterDataConstants.APType.TRF && aPFeedback == MasterDataConstants.APFeedback.FORWARDED)
            {

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A TRF Request Forwarded Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, TRF, Forwarded";
                MailBody = @"Please note that a TRF is forwarded.-Thanks ERP System";
            }

            else if (approvalProcessType == MasterDataConstants.APType.CUSTOM && aPFeedback == MasterDataConstants.APFeedback.FORWARDED)
            {

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Custom Request Forwarded Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, CUSTOM, Forwarded";
            }

            else if (approvalProcessType == MasterDataConstants.APType.PAYABLE_STATEMENT && aPFeedback == MasterDataConstants.APFeedback.FORWARDED)
            {

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Payable Request Forwarded Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<a href='" + premLink[0] + "'>View in Local Network</a>");
                sb.Append("<br/>");
                sb.Append("If you're outside of office network: ");
                sb.Append("<a href='" + premLink[1] + "'>View Here</a>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Payable, Forwarded";
            }

            #endregion

        }

        #endregion

        #region Auto Generated SIN

        public static void AutoGenerateSINFromTRF(Int64 transferID)
        {
            if (transferID > 0)
            {
                INVTransferEntity entTransfer = FCCINVTransfer.GetFacadeCreate().GetByID(transferID);

                #region Create SIN

                if (entTransfer != null)
                {
                    INVStoreEntity entStore=FCCINVStore.GetFacadeCreate().GetByID(entTransfer.TransferFromStoreID);
                    INVStoreIssueNoteEntity iNVStoreIssueNoteEntity = new INVStoreIssueNoteEntity();
                    iNVStoreIssueNoteEntity.ProjectID = entStore.ProjectID;
                    iNVStoreIssueNoteEntity.StoreIssueNoteNo = "TRF";
                    iNVStoreIssueNoteEntity.SRFNo = "Auto Generated SRF No";
                    iNVStoreIssueNoteEntity.RequestedByEmployeeID = entTransfer.RequestedByEmployeeID;
                    iNVStoreIssueNoteEntity.RequestDate = System.DateTime.Now;
                    iNVStoreIssueNoteEntity.Remarks = "Auto Generated SIN for Approval TRF";
                    iNVStoreIssueNoteEntity.StoreIssueNoteApprovalStatusID = MasterDataConstants.INVStoreIssueNoteApprovalStatus.REQUESTED;
                    iNVStoreIssueNoteEntity.IsRemoved = false;

                    Int64 result = FCCINVStoreIssueNote.GetFacadeCreate().Add(iNVStoreIssueNoteEntity, DatabaseOperationType.Add, TransactionRequired.No);

                #endregion

                    #region Create SIN Item Map

                    if (result > 0)
                    {
                        String fe=SqlExpressionBuilder.PrepareFilterExpression(INVTransferItemEntity.FLD_NAME_TransferID,entTransfer.TransferID.ToString(),SQLMatchType.Equal);
                        IList<INVTransferItemEntity> lstTransferItem = FCCINVTransferItem.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                        if (lstTransferItem != null && lstTransferItem.Count > 0)
                        {
                            foreach (INVTransferItemEntity ent in lstTransferItem)
                            {
                                INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity = new INVStoreIssueNoteItemMapEntity();
                                iNVStoreIssueNoteItemMapEntity.StoreIssueNoteID = result;
                                iNVStoreIssueNoteItemMapEntity.ItemID = ent.ItemID;
                                iNVStoreIssueNoteItemMapEntity.RequestQty = ent.RequestQty;
                                iNVStoreIssueNoteItemMapEntity.PurposeOfWorks = ent.Remarks;
                                iNVStoreIssueNoteItemMapEntity.IssueQty = null;
                                iNVStoreIssueNoteItemMapEntity.BatchNo = null;
                                iNVStoreIssueNoteItemMapEntity.IssuedFromStoreID = entTransfer.TransferFromStoreID;
                                iNVStoreIssueNoteItemMapEntity.IssuedFromStoreUnitID = entTransfer.TransferFromStoreUnitID;
                                iNVStoreIssueNoteItemMapEntity.ReceivedDate = null;
                                iNVStoreIssueNoteItemMapEntity.ReceivedByEmployeeID = null;
                                iNVStoreIssueNoteItemMapEntity.ReceivedByEmployeeID = null;
                                iNVStoreIssueNoteItemMapEntity.ReturnQty = null;
                                iNVStoreIssueNoteItemMapEntity.ReturnDate = null;
                                iNVStoreIssueNoteItemMapEntity.ReturnToStoreID = null;
                                iNVStoreIssueNoteItemMapEntity.ReturnToStoreUnitID = null;
                                iNVStoreIssueNoteItemMapEntity.ReturnedByEmployeeID = null;
                                iNVStoreIssueNoteItemMapEntity.Amount = null;

                                FCCINVStoreIssueNoteItemMap.GetFacadeCreate().Add(iNVStoreIssueNoteItemMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                            }
                        }
                    }

                    #endregion

                    #region Create TRF and SIN Map

                    INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity = new INVTRFStoreIssueNoteMapEntity();
                    iNVTRFStoreIssueNoteMapEntity.StoreIssueNoteID = result;
                    iNVTRFStoreIssueNoteMapEntity.TransferID = transferID;
                    iNVTRFStoreIssueNoteMapEntity.Remarks = "Auto Generated TRF and SIN Map";
                    iNVTRFStoreIssueNoteMapEntity.IsRemoved = false;

                    FCCINVTRFStoreIssueNoteMap.GetFacadeCreate().Add(iNVTRFStoreIssueNoteMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                }

                #endregion
            }
        }

        #endregion

        #region Generate Mail Body Link

        public static void GenerateMailBodyLink(Int64 approvalProcessType, Int64 referenceID, APMemberFeedbackEntity ent)
        {
            switch (approvalProcessType)
            {
                    
                case MasterDataConstants.APType.REQUISITION:
                    MailNavUrl[0] = UrlHelper.BuildSecureUrl(MasterDataConstants.ERPDeploymentAddressIP.LOCAL_IP.ToString()+"/REQ/REQRequisitionDetailsWithApproval.aspx",
                   string.Empty,
                   UrlConstants.REQUISITION_ID,
                   referenceID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                   ent.APMemberFeedbackID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                   ent.APApprovalProcessID.ToString()
                   ).ToString();

                  MailNavUrl[1] = UrlHelper.BuildSecureUrl(MasterDataConstants.ERPDeploymentAddressIP.REAL_IP.ToString() + "/REQ/REQRequisitionDetailsWithApproval.aspx",
                  string.Empty,
                  UrlConstants.REQUISITION_ID,
                  referenceID.ToString(),
                  APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                  ent.APMemberFeedbackID.ToString(),
                  APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                  ent.APApprovalProcessID.ToString()
                  ).ToString();
                    break;

                case MasterDataConstants.APType.WORK_ORDER:
                    MailNavUrl[0] = UrlHelper.BuildSecureUrl(
                   MasterDataConstants.ERPDeploymentAddressIP.LOCAL_IP + "/PRM/PRMWorkOrderViewWithApproval.aspx",
                   string.Empty,
                   UrlConstants.OVERVIEW_WORKORDER_ID,
                   referenceID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                   ent.APMemberFeedbackID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                   ent.APApprovalProcessID.ToString()
                   ).ToString();

                    MailNavUrl[1] = UrlHelper.BuildSecureUrl(
                   MasterDataConstants.ERPDeploymentAddressIP.REAL_IP + "/PRM/PRMWorkOrderViewWithApproval.aspx",
                   string.Empty,
                   UrlConstants.OVERVIEW_WORKORDER_ID,
                   referenceID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                   ent.APMemberFeedbackID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                   ent.APApprovalProcessID.ToString()
                   ).ToString();
                    break;

                case MasterDataConstants.APType.BILL:
                    MailNavUrl[0] = UrlHelper.BuildSecureUrl(
                    MasterDataConstants.ERPDeploymentAddressIP.LOCAL_IP + "/CM/CMBillDetailsWithApproval.aspx",
                    string.Empty,
                    UrlConstants.OVERVIEW_CM_BILL_ID,
                    referenceID.ToString(),
                    APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                    ent.APMemberFeedbackID.ToString(),
                    APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                    ent.APApprovalProcessID.ToString()
                    ).ToString();

                    MailNavUrl[1] = UrlHelper.BuildSecureUrl(
                   MasterDataConstants.ERPDeploymentAddressIP.REAL_IP + "/CM/CMBillDetailsWithApproval.aspx",
                   string.Empty,
                   UrlConstants.OVERVIEW_CM_BILL_ID,
                   referenceID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                   ent.APMemberFeedbackID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                   ent.APApprovalProcessID.ToString()
                   ).ToString();

                    break;

                case MasterDataConstants.APType.PAYABLE_STATEMENT:
                    MailNavUrl[0] = UrlHelper.BuildSecureUrl(
                   MasterDataConstants.ERPDeploymentAddressIP.LOCAL_IP + "/ACC/ACCPostPayableStatementDetailWithApproval.aspx",
                   string.Empty,
                   UrlConstants.OVERVIEW_POST_PAYABLE_STATEMENT_DETAIL_ID,
                   referenceID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                   ent.APMemberFeedbackID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                   ent.APApprovalProcessID.ToString()
                   ).ToString();

                    MailNavUrl[1] = UrlHelper.BuildSecureUrl(
                   MasterDataConstants.ERPDeploymentAddressIP.REAL_IP + "/ACC/ACCPostPayableStatementDetailWithApproval.aspx",
                   string.Empty,
                   UrlConstants.OVERVIEW_POST_PAYABLE_STATEMENT_DETAIL_ID,
                   referenceID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                   ent.APMemberFeedbackID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                   ent.APApprovalProcessID.ToString()
                   ).ToString();

                    break;

                case MasterDataConstants.APType.TRF:
                    MailNavUrl[0] = UrlHelper.BuildSecureUrl(
                   MasterDataConstants.ERPDeploymentAddressIP.LOCAL_IP + "/INV/INVTransferItemDetailsWithApproval.aspx",
                   string.Empty,
                   UrlConstants.OVERVIEW_TRANSFER_ID,
                   referenceID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                   ent.APMemberFeedbackID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                   ent.APApprovalProcessID.ToString()
                   ).ToString();

                     MailNavUrl[1] = UrlHelper.BuildSecureUrl(
                   MasterDataConstants.ERPDeploymentAddressIP.REAL_IP + "/INV/INVTransferItemDetailsWithApproval.aspx",
                   string.Empty,
                   UrlConstants.OVERVIEW_TRANSFER_ID,
                   referenceID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                   ent.APMemberFeedbackID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                   ent.APApprovalProcessID.ToString()
                   ).ToString();

                    break;

                case MasterDataConstants.APType.AGREEMENT:
                    MailNavUrl[0] = UrlHelper.BuildSecureUrl(
                   MasterDataConstants.ERPDeploymentAddressIP.LOCAL_IP + "/CRM/CRMAgreementDetailsWithApproval.aspx",
                   string.Empty,
                   UrlConstants.OVERVIEW_AGREEMENT_ID,
                   referenceID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                   ent.APMemberFeedbackID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                   ent.APApprovalProcessID.ToString()
                   ).ToString();

                    MailNavUrl[1] = UrlHelper.BuildSecureUrl(
                  MasterDataConstants.ERPDeploymentAddressIP.REAL_IP + "/CRM/CRMAgreementDetailsWithApproval.aspx",
                  string.Empty,
                  UrlConstants.OVERVIEW_AGREEMENT_ID,
                  referenceID.ToString(),
                  APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                  ent.APMemberFeedbackID.ToString(),
                  APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                  ent.APApprovalProcessID.ToString()
                  ).ToString();

                    break;

                case MasterDataConstants.APType.BANK_DEPOSIT:
                    MailNavUrl[0] = UrlHelper.BuildSecureUrl(
                   MasterDataConstants.ERPDeploymentAddressIP.LOCAL_IP + "/AC/ACBankAccountDepositDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_BANK_ACCOUNT_DEPOSIT_ID,
                        referenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();

                    MailNavUrl[1] = UrlHelper.BuildSecureUrl(
                  MasterDataConstants.ERPDeploymentAddressIP.REAL_IP + "/AC/ACBankAccountDepositDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_BANK_ACCOUNT_DEPOSIT_ID,
                        referenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();

                    break;

                case MasterDataConstants.APType.BANK_PAYMENT:
                    MailNavUrl[0] = UrlHelper.BuildSecureUrl(
                   MasterDataConstants.ERPDeploymentAddressIP.LOCAL_IP + "/AC/ACBankAccountPaymentDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_BANK_ACCOUNT_PAYMENT_ID,
                        referenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();

                    MailNavUrl[1] = UrlHelper.BuildSecureUrl(
                  MasterDataConstants.ERPDeploymentAddressIP.REAL_IP + "~/AC/ACBankAccountPaymentDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_BANK_ACCOUNT_PAYMENT_ID,
                        referenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();

                    break;

                case MasterDataConstants.APType.TEMPORARY_JOURNAL:
                    MailNavUrl[0] = UrlHelper.BuildSecureUrl(
                   MasterDataConstants.ERPDeploymentAddressIP.LOCAL_IP + "/AC/ACJournalDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_TEMPORARY_JOURNAL_ID,
                        referenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();

                    MailNavUrl[1] = UrlHelper.BuildSecureUrl(
                  MasterDataConstants.ERPDeploymentAddressIP.REAL_IP + "~/AC/ACJournalDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_TEMPORARY_JOURNAL_ID,
                        referenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();

                    break;

                case MasterDataConstants.APType.BANK_ACCOUNT_TRANSFER:
                    MailNavUrl[0] = UrlHelper.BuildSecureUrl(
                   MasterDataConstants.ERPDeploymentAddressIP.LOCAL_IP + "/CRM/CRMAgreementDetailsWithApproval.aspx",
                   string.Empty,
                   UrlConstants.OVERVIEW_AGREEMENT_ID,
                   referenceID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                   ent.APMemberFeedbackID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                   ent.APApprovalProcessID.ToString()
                   ).ToString();

                    MailNavUrl[1] = UrlHelper.BuildSecureUrl(
                  MasterDataConstants.ERPDeploymentAddressIP.REAL_IP + "/CRM/CRMAgreementDetailsWithApproval.aspx",
                   string.Empty,
                   UrlConstants.OVERVIEW_AGREEMENT_ID,
                   referenceID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                   ent.APMemberFeedbackID.ToString(),
                   APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                   ent.APApprovalProcessID.ToString()
                   ).ToString();

                    break;

                case MasterDataConstants.APType.MRR:
                    MailNavUrl[0] = UrlHelper.BuildSecureUrl(
                   MasterDataConstants.ERPDeploymentAddressIP.LOCAL_IP + "/PRM/PRMMaterialReceiveDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID,
                        referenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();

                    MailNavUrl[1] = UrlHelper.BuildSecureUrl(
                  MasterDataConstants.ERPDeploymentAddressIP.REAL_IP + "/PRM/PRMMaterialReceiveDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID,
                        referenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();

                    break;

                case MasterDataConstants.APType.CONTACT_LIST:
                    MailNavUrl[0] = UrlHelper.BuildSecureUrl(
                   MasterDataConstants.ERPDeploymentAddressIP.LOCAL_IP + "/BD/BDProcessAssignedResourceDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_PROCESS_ASSIGNED_RESOURCE_ID,
                        referenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();

                    MailNavUrl[1] = UrlHelper.BuildSecureUrl(
                  MasterDataConstants.ERPDeploymentAddressIP.REAL_IP + "/BD/BDProcessAssignedResourceDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_PROCESS_ASSIGNED_RESOURCE_ID,
                        referenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();

                    break;


                case MasterDataConstants.APType.LOAN_APPLICATION:
                    MailNavUrl[0] = UrlHelper.BuildSecureUrl(
                   MasterDataConstants.ERPDeploymentAddressIP.LOCAL_IP + "/HR/HREmployeeLoanApplicationDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_LOAN_APPLICATION_ID,
                        referenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();

                    MailNavUrl[1] = UrlHelper.BuildSecureUrl(
                  MasterDataConstants.ERPDeploymentAddressIP.REAL_IP + "/HR/HREmployeeLoanApplicationDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_LOAN_APPLICATION_ID,
                        referenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();

                    break;

                case MasterDataConstants.APType.LEAVE_APPLICATION:
                    MailNavUrl[0] = UrlHelper.BuildSecureUrl(
                   MasterDataConstants.ERPDeploymentAddressIP.LOCAL_IP + "/HR/HREmployeeLeaveApplicationWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_LOAN_APPLICATION_ID,
                        referenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();

                    MailNavUrl[1] = UrlHelper.BuildSecureUrl(
                  MasterDataConstants.ERPDeploymentAddressIP.REAL_IP + "/HR/HREmployeeLeaveApplicationWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_LOAN_APPLICATION_ID,
                        referenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();

                    break;

                case MasterDataConstants.APType.CUSTOM:
                    break;
            }
        }

        #endregion

        #region Journal Entry

        #region Bank Account Desposit Journal Entry

        public static void BankAccountDepositJournalEntry(Int64 bankAccountDepositID)
        {
   
                //Find Bank Account
                //Then Add Debit all of summation amount

                //credit Individual Amount

                try
                {
                    //String fe_BankAccount = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountEntity.FLD_NAME_IsDefaultCurrencyAccount, "1", SQLMatchType.Equal);
                    ACBankAccountDepositEntity aCBankAccountDepositEntity = FCCACBankAccountDeposit.GetFacadeCreate().GetByID(bankAccountDepositID);

                    if (aCBankAccountDepositEntity != null && aCBankAccountDepositEntity.BankAccountDepositID > 0)
                    {
                        Decimal totalAmount = 0;

                        String fe_bankaccountDeposit = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountDepositItemEntity.FLD_NAME_BankAccountDepositID, bankAccountDepositID.ToString(), SQLMatchType.Equal);
                        IList<ACBankAccountDepositItemEntity> lstACBankAccountDepositItem = FCCACBankAccountDepositItem.GetFacadeCreate().GetIL(null, null, String.Empty, fe_bankaccountDeposit, DatabaseOperationType.LoadWithFilterExpression);

                        if (lstACBankAccountDepositItem != null && lstACBankAccountDepositItem.Count > 0)
                        {
                            var transinfo = (from transaction in lstACBankAccountDepositItem
                                             select transaction.Amount).Sum(val => val);

                            Decimal.TryParse(transinfo.ToString(), out totalAmount);
                        }


                        ACBankAccountDepositEntity acBankAccountDepositEntity = FCCACBankAccountDeposit.GetFacadeCreate().GetByID(bankAccountDepositID);

                        #region Account(Debit Entry)


                        ACJournalEntity acJournalEntity = new ACJournalEntity();

                        String fe_account = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccount." + ACAccountsHelper_CustomEntity.FLD_NAME_BankAccountID, aCBankAccountDepositEntity.BankAccountID.ToString(), SQLMatchType.Equal);
                        IList<ACAccountsHelper_CustomEntity> lst = FCCACAccountsHelper_Custom.GetFacadeCreate().GetIL(1000, 1, fe_account);

                        if (lst != null && lst.Count > 0)
                        {
                            acJournalEntity.AccountID = lst[0].AccountID;
                            acJournalEntity.AccountGroupID = lst[0].AccountGroupID;
                            acJournalEntity.ClassID = lst[0].ClassID;
                            acJournalEntity.ClassTypeID = lst[0].ClassTypeID;
                        }

                        String fe_fiscalYear = SqlExpressionBuilder.PrepareFilterExpression(ACFiscalYearEntity.FLD_NAME_IsClosed, "0", SQLMatchType.Equal);
                        IList<ACFiscalYearEntity> lstFiscalYear = FCCACFiscalYear.GetFacadeCreate().GetIL(null, null, String.Empty, fe_fiscalYear, DatabaseOperationType.LoadWithFilterExpression);

                        if (lstFiscalYear != null && lstFiscalYear.Count > 0)
                        {
                            acJournalEntity.FiscalYearID = lstFiscalYear[0].FiscalYearID;
                        }

                        acJournalEntity.TransactionDateTime = acBankAccountDepositEntity.DepositDate;
                        acJournalEntity.Amount = totalAmount;
                        acJournalEntity.EnteredByEmployeeID = acBankAccountDepositEntity.PreparedByEmployeeID;
                        acJournalEntity.ReferenceOrMemoOrID = acBankAccountDepositEntity.Reference;
                        acJournalEntity.Note = acBankAccountDepositEntity.Memo;
                        acJournalEntity.MDDebitCreditID = MasterDataConstants.MDDebitCredit.DEBIT;
                        acJournalEntity.DimensionID = null;
                        acJournalEntity.VoucherType = "Bank Deposit";
                        //acJournalEntity.ItemID = ent.ItemID;
                        //acJournalEntity.RequisitionID = ent.RequisitionID;
                        //acJournalEntity.WorkOrderID = ent.WorkOrderID;
                        //acJournalEntity.BillID = ent.BillID;
                        //acJournalEntity.ProjectID = ent.ProjectID;
                        //acJournalEntity.ProjectFloorID = ent.ProjectFloorID;
                        //acJournalEntity.ProjectFloorUnitID = ent.ProjectFloorUnitID;

                        //if (acBankAccountDepositEntity.ProjectID > 0)
                        //{
                        //    acJournalEntity.ProjectID = acBankAccountDepositEntity.ProjectID;
                        //}

                        //else
                        //{
                        //    acJournalEntity.ProjectID = null;
                        //}

                        acJournalEntity.IsReverseTransaction = false;

                        FCCACJournal.GetFacadeCreate().Add(acJournalEntity, DatabaseOperationType.Add, TransactionRequired.No);

                        #endregion

                        #region Account(Credit Entry)

                        if (lstACBankAccountDepositItem != null && lstACBankAccountDepositItem.Count > 0)
                        {
                            foreach (ACBankAccountDepositItemEntity ent in lstACBankAccountDepositItem)
                            {

                                String fe_BankAccountPayment = SqlExpressionBuilder.PrepareFilterExpression("ACAccount." + ACAccountsHelper_CustomEntity.FLD_NAME_AccountID, ent.AccountID.ToString(), SQLMatchType.Equal);
                                IList<ACAccountsHelper_CustomEntity> lstBankAccountPayment = FCCACAccountsHelper_Custom.GetFacadeCreate().GetIL(10000, 1, fe_BankAccountPayment);

                                if (lstBankAccountPayment != null && lstBankAccountPayment.Count > 0)
                                {
                                    acJournalEntity.AccountID = lstBankAccountPayment[0].AccountID;
                                    acJournalEntity.AccountGroupID = lstBankAccountPayment[0].AccountGroupID;
                                    acJournalEntity.ClassID = lstBankAccountPayment[0].ClassID;
                                    acJournalEntity.ClassTypeID = lstBankAccountPayment[0].ClassTypeID;
                                }

                                acJournalEntity.TransactionDateTime = acBankAccountDepositEntity.DepositDate;
                                acJournalEntity.Amount = ent.Amount;
                                acJournalEntity.EnteredByEmployeeID = acBankAccountDepositEntity.PreparedByEmployeeID;
                                acJournalEntity.ReferenceOrMemoOrID = acBankAccountDepositEntity.Reference;
                                acJournalEntity.Note = ent.Memo;
                                acJournalEntity.MDDebitCreditID = MasterDataConstants.MDDebitCredit.CREDIT;
                                acJournalEntity.DimensionID = ent.DimensionID; acJournalEntity.ItemID = ent.ItemID;
                                acJournalEntity.RequisitionID = ent.RequisitionID;
                                acJournalEntity.WorkOrderID = ent.WorkOrderID;
                                acJournalEntity.BillID = ent.BillID;
                                acJournalEntity.ProjectID = ent.ProjectID;
                                acJournalEntity.ProjectFloorID = ent.ProjectFloorID;
                                acJournalEntity.ProjectFloorUnitID = ent.ProjectFloorUnitID;
                                acJournalEntity.IsReverseTransaction = false;
                                acJournalEntity.VoucherType = "Bank Deposit";

                                FCCACJournal.GetFacadeCreate().Add(acJournalEntity, DatabaseOperationType.Add, TransactionRequired.No);
                            }
                        }

                        #endregion

                        acJournalEntity = new ACJournalEntity();
                    }

                }
                catch (Exception ex)
                {
                   
                }
            }

        #endregion

        #region Bank Account Payment Journal Entry

        public static void BankAccountPaymentJournalEntry(Int64 bankAccountPaymentID)
        {

            //Find Bank Account
            //Then Add Credit all of summation amount

            //Debit Individual Amount
            try
            {
                //String fe_BankAccount = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountEntity.FLD_NAME_IsDefaultCurrencyAccount, "1", SQLMatchType.Equal);
                ACBankAccountPaymentEntity aCBankAccountPayment = FCCACBankAccountPayment.GetFacadeCreate().GetByID(bankAccountPaymentID);

                if (aCBankAccountPayment != null && aCBankAccountPayment.BankAccountPaymentID > 0)
                {
                    Decimal totalAmount = 0;

                    String fe_bankaccountPayment = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountPaymentEntity.FLD_NAME_BankAccountPaymentID, bankAccountPaymentID.ToString(), SQLMatchType.Equal);
                    IList<ACBankAccountPaymentItemEntity> lstACBankAccountPaymentItem = FCCACBankAccountPaymentItem.GetFacadeCreate().GetIL(null, null, String.Empty, fe_bankaccountPayment, DatabaseOperationType.LoadWithFilterExpression);

                    if (lstACBankAccountPaymentItem != null && lstACBankAccountPaymentItem.Count > 0)
                    {
                        var transinfo = (from transaction in lstACBankAccountPaymentItem
                                         select transaction.Amount).Sum(val => val);

                        Decimal.TryParse(transinfo.ToString(), out totalAmount);
                    }


                    ACBankAccountPaymentEntity acBankAccountPaymentEntity = FCCACBankAccountPayment.GetFacadeCreate().GetByID(bankAccountPaymentID);

                    #region Account(Credit Entry)


                    ACJournalEntity acJournalEntity = new ACJournalEntity();

                    String fe_account = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccount." + ACAccountsHelper_CustomEntity.FLD_NAME_BankAccountID, aCBankAccountPayment.BankAccountID.ToString(), SQLMatchType.Equal);
                    IList<ACAccountsHelper_CustomEntity> lst = FCCACAccountsHelper_Custom.GetFacadeCreate().GetIL(1000, 1, fe_account);

                    if (lst != null && lst.Count > 0)
                    {
                        acJournalEntity.AccountID = lst[0].AccountID;
                        acJournalEntity.AccountGroupID = lst[0].AccountGroupID;
                        acJournalEntity.ClassID = lst[0].ClassID;
                        acJournalEntity.ClassTypeID = lst[0].ClassTypeID;
                    }

                    String fe_fiscalYear = SqlExpressionBuilder.PrepareFilterExpression(ACFiscalYearEntity.FLD_NAME_IsClosed, "0", SQLMatchType.Equal);
                    IList<ACFiscalYearEntity> lstFiscalYear = FCCACFiscalYear.GetFacadeCreate().GetIL(null, null, String.Empty, fe_fiscalYear, DatabaseOperationType.LoadWithFilterExpression);

                    if (lstFiscalYear != null && lstFiscalYear.Count > 0)
                    {
                        acJournalEntity.FiscalYearID = lstFiscalYear[0].FiscalYearID;
                    }

                    acJournalEntity.TransactionDateTime = acBankAccountPaymentEntity.PaymentDate;
                    acJournalEntity.Amount = totalAmount;
                    acJournalEntity.EnteredByEmployeeID = acBankAccountPaymentEntity.PreparedByEmployeeID;
                    acJournalEntity.ReferenceOrMemoOrID = acBankAccountPaymentEntity.Reference;
                    acJournalEntity.Note = acBankAccountPaymentEntity.Memo;
                    acJournalEntity.MDDebitCreditID = MasterDataConstants.MDDebitCredit.CREDIT;
                    acJournalEntity.DimensionID = null;
                    acJournalEntity.VoucherType = "Bank Payment";
                    

                    acJournalEntity.IsReverseTransaction = false;

                    FCCACJournal.GetFacadeCreate().Add(acJournalEntity, DatabaseOperationType.Add, TransactionRequired.No);

                    #endregion

                    #region Account(Debit Entry)

                    if (lstACBankAccountPaymentItem != null && lstACBankAccountPaymentItem.Count > 0)
                    {
                        foreach (ACBankAccountPaymentItemEntity ent in lstACBankAccountPaymentItem)
                        {

                            String fe_BankAccountPayment = SqlExpressionBuilder.PrepareFilterExpression("ACAccount." + ACAccountsHelper_CustomEntity.FLD_NAME_AccountID, ent.AccountID.ToString(), SQLMatchType.Equal);
                            IList<ACAccountsHelper_CustomEntity> lstBankAccountPayment = FCCACAccountsHelper_Custom.GetFacadeCreate().GetIL(10000, 1, fe_BankAccountPayment);

                            if (lstBankAccountPayment != null && lstBankAccountPayment.Count > 0)
                            {
                                acJournalEntity.AccountID = lstBankAccountPayment[0].AccountID;
                                acJournalEntity.AccountGroupID = lstBankAccountPayment[0].AccountGroupID;
                                acJournalEntity.ClassID = lstBankAccountPayment[0].ClassID;
                                acJournalEntity.ClassTypeID = lstBankAccountPayment[0].ClassTypeID;
                            }

                            acJournalEntity.TransactionDateTime = acBankAccountPaymentEntity.PaymentDate;
                            acJournalEntity.Amount = ent.Amount;
                            acJournalEntity.EnteredByEmployeeID = acBankAccountPaymentEntity.PreparedByEmployeeID;
                            acJournalEntity.ReferenceOrMemoOrID = acBankAccountPaymentEntity.Reference;
                            acJournalEntity.Note = ent.Memo;
                            acJournalEntity.MDDebitCreditID = MasterDataConstants.MDDebitCredit.DEBIT;
                            acJournalEntity.DimensionID = ent.DimensionID;
                            acJournalEntity.ItemID = ent.ItemID;
                            acJournalEntity.RequisitionID = ent.RequisitionID;
                            acJournalEntity.WorkOrderID = ent.WorkOrderID;
                            acJournalEntity.BillID = ent.BillID;
                            acJournalEntity.ProjectID = ent.ProjectID;
                            acJournalEntity.ProjectFloorID = ent.ProjectFloorID;
                            acJournalEntity.ProjectFloorUnitID = ent.ProjectFloorUnitID;
                            acJournalEntity.IsReverseTransaction = false;
                            acJournalEntity.VoucherType = "Bank Payment";

                            FCCACJournal.GetFacadeCreate().Add(acJournalEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                    }

                    #endregion

                    acJournalEntity = new ACJournalEntity();
                }

            }
            catch (Exception ex)
            {
                
            }
        }

        #endregion

        #region Manual Journal Entry

        public static void TemporaryJournalEntry(Int64 temporaryJournalMasterID)
        {
            try
            {
                ACTemporaryJournalMasterEntity aCTemporaryJournalMasterEntity = FCCACTemporaryJournalMaster.GetFacadeCreate().GetByID(temporaryJournalMasterID);

                String fe_temporaryJournal = SqlExpressionBuilder.PrepareFilterExpression(ACTemporaryJournalEntity.FLD_NAME_TemporaryJournalMasterID, temporaryJournalMasterID.ToString(), SQLMatchType.Equal);

                IList<ACTemporaryJournalEntity> lstTemporaryJournal = FCCACTemporaryJournal.GetFacadeCreate().GetIL(null, null, String.Empty, fe_temporaryJournal, DatabaseOperationType.LoadWithFilterExpression);

                if (lstTemporaryJournal != null && lstTemporaryJournal.Count > 0)
                {

                    foreach (ACTemporaryJournalEntity ent in lstTemporaryJournal)
                    {
                        ACJournalEntity acJournalEntity = new ACJournalEntity();
                        acJournalEntity.AccountID = ent.AccountID;
                        acJournalEntity.AccountGroupID = ent.AccountGroupID;
                        acJournalEntity.ClassID = ent.ClassID;
                        acJournalEntity.ClassTypeID = ent.ClassTypeID;
                        acJournalEntity.FiscalYearID = ent.FiscalYearID;
                        acJournalEntity.TransactionDateTime = ent.TransactionDateTime;
                        acJournalEntity.Amount = ent.Amount;
                        acJournalEntity.EnteredByEmployeeID = ent.EnteredByEmployeeID;
                        acJournalEntity.ReferenceOrMemoOrID = ent.ReferenceOrMemoOrID;
                        acJournalEntity.Note = ent.Note;
                        acJournalEntity.MDDebitCreditID = ent.MDDebitCreditID;
                        acJournalEntity.DimensionID = ent.DimensionID;
                        acJournalEntity.ProjectID = ent.ProjectID;
                        acJournalEntity.ItemID = ent.ItemID;
                        acJournalEntity.RequisitionID = ent.RequisitionID;
                        acJournalEntity.WorkOrderID = ent.WorkOrderID;
                        acJournalEntity.BillID = ent.BillID;
                        acJournalEntity.ProjectFloorID = ent.ProjectFloorID;
                        acJournalEntity.ProjectFloorUnitID = ent.ProjectFloorUnitID;
                        acJournalEntity.IsReverseTransaction = ent.IsReverseTransaction;
                        acJournalEntity.VoucherType = "Journal Voucher";

                        FCCACJournal.GetFacadeCreate().Add(acJournalEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                }
            }
            catch (Exception ex)
            {
             
            }
        }

        #endregion

        #region Bank Account Transfer Journal Entry

        public static void AutoBankAccountTransferJournalEntry(Int64 bankAccountTransferID)
        {
            try
            {
                #region Journal Entry

                //Bank To Bank Tranfer amount 
                //Normal Trnasaction without Charge
                //===================================
                //    From Current amount to pretty cash
                //    Current Accont (-) Credit
                //    Petty Cash Account(+) Debit
                //====================================

                //Transaction with Charge
                //===================================
                //    From Current amount to pretty cash
                //    sum of amount transfer + Charge	Current Accont (-) Credit
                //    Petty Cash Account(+) Debit
                //    Charge also (+) Debit but different account Head {Interest and Bank Charges}

                ACBankAccountTransferEntity acBankAccountTransferEntity = FCCACBankAccountTransfer.GetFacadeCreate().GetByID(bankAccountTransferID);

                if (acBankAccountTransferEntity != null && acBankAccountTransferEntity.BankAccountTransferID > 0)
                {
                    Decimal amount, charge, totalAmount;
                    Decimal.TryParse(acBankAccountTransferEntity.Amount.ToString(), out amount);
                    Decimal.TryParse(acBankAccountTransferEntity.BankCharge.ToString(), out charge);

                    totalAmount = amount + charge;

                    if (amount > 0)
                    {
                        #region From Account(Credit Entry)

                        ACJournalEntity acJournalEntity = new ACJournalEntity();

                        String fe_account = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccount." + ACAccountsHelper_CustomEntity.FLD_NAME_BankAccountID, acBankAccountTransferEntity.FromBankAccountID.ToString(), SQLMatchType.Equal);
                        IList<ACAccountsHelper_CustomEntity> lst = FCCACAccountsHelper_Custom.GetFacadeCreate().GetIL(1000, 1, fe_account);

                        if (lst != null && lst.Count > 0)
                        {
                            acJournalEntity.AccountID = lst[0].AccountID;
                            acJournalEntity.AccountGroupID = lst[0].AccountGroupID;
                            acJournalEntity.ClassID = lst[0].ClassID;
                            acJournalEntity.ClassTypeID = lst[0].ClassTypeID;
                        }

                        String fe_fiscalYear = SqlExpressionBuilder.PrepareFilterExpression(ACFiscalYearEntity.FLD_NAME_IsClosed, "0", SQLMatchType.Equal);
                        IList<ACFiscalYearEntity> lstFiscalYear = FCCACFiscalYear.GetFacadeCreate().GetIL(null, null, String.Empty, fe_fiscalYear, DatabaseOperationType.LoadWithFilterExpression);

                        if (lstFiscalYear != null && lstFiscalYear.Count > 0)
                        {
                            acJournalEntity.FiscalYearID = lstFiscalYear[0].FiscalYearID;
                        }

                        acJournalEntity.TransactionDateTime = acBankAccountTransferEntity.TransferDate;
                        acJournalEntity.Amount = totalAmount;
                        acJournalEntity.EnteredByEmployeeID = acBankAccountTransferEntity.CreatedByEmployeeID;
                        acJournalEntity.ReferenceOrMemoOrID = acBankAccountTransferEntity.Memo;
                        acJournalEntity.Note = acBankAccountTransferEntity.Remarks;
                        acJournalEntity.MDDebitCreditID = MasterDataConstants.MDDebitCredit.CREDIT;
                        acJournalEntity.DimensionID = null;
                        acJournalEntity.ProjectID = null;
                        acJournalEntity.IsReverseTransaction = false;
                        acJournalEntity.VoucherType = "Account Transfer";

                        FCCACJournal.GetFacadeCreate().Add(acJournalEntity, DatabaseOperationType.Add, TransactionRequired.No);

                        #endregion

                        #region To Account(Debit Entry)

                        String fe_TobankAccount = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccount." + ACAccountsHelper_CustomEntity.FLD_NAME_BankAccountID, acBankAccountTransferEntity.ToBankAccountID.ToString(), SQLMatchType.Equal);
                        IList<ACAccountsHelper_CustomEntity> lstTobankAccount = FCCACAccountsHelper_Custom.GetFacadeCreate().GetIL(10000, 1, fe_TobankAccount);

                        if (lstTobankAccount != null && lstTobankAccount.Count > 0)
                        {
                            acJournalEntity.AccountID = lstTobankAccount[0].AccountID;
                            acJournalEntity.AccountGroupID = lstTobankAccount[0].AccountGroupID;
                            acJournalEntity.ClassID = lstTobankAccount[0].ClassID;
                            acJournalEntity.ClassTypeID = lstTobankAccount[0].ClassTypeID;
                        }

                        acJournalEntity.TransactionDateTime = acBankAccountTransferEntity.TransferDate;
                        acJournalEntity.Amount = amount;
                        acJournalEntity.EnteredByEmployeeID = acBankAccountTransferEntity.CreatedByEmployeeID;
                        acJournalEntity.ReferenceOrMemoOrID = acBankAccountTransferEntity.Memo;
                        acJournalEntity.Note = acBankAccountTransferEntity.Remarks;
                        acJournalEntity.MDDebitCreditID = MasterDataConstants.MDDebitCredit.DEBIT;
                        acJournalEntity.DimensionID = null;
                        acJournalEntity.ProjectID = null;
                        acJournalEntity.IsReverseTransaction = false;
                        acJournalEntity.VoucherType = "Account Transfer";

                        FCCACJournal.GetFacadeCreate().Add(acJournalEntity, DatabaseOperationType.Add, TransactionRequired.No);

                        if (charge > 0)
                        {
                            acJournalEntity.Amount = charge;
                            acJournalEntity.AccountID = 23;//Should Change Here For Intrest and Loan
                            
                            String fe_ChargeAccount = SqlExpressionBuilder.PrepareFilterExpression("ACAccount." + ACAccountsHelper_CustomEntity.FLD_NAME_AccountID, "23".ToString(), SQLMatchType.Equal);
                            IList<ACAccountsHelper_CustomEntity> lstChargeAccount = FCCACAccountsHelper_Custom.GetFacadeCreate().GetIL(10000, 1, fe_ChargeAccount);

                            if (lstTobankAccount != null && lstTobankAccount.Count > 0)
                            {
                                acJournalEntity.AccountID = 23;//Should Change Here For Intrest and Loan
                                acJournalEntity.AccountGroupID = lstChargeAccount[0].AccountGroupID;
                                acJournalEntity.ClassID = lstChargeAccount[0].ClassID;
                                acJournalEntity.ClassTypeID = lstChargeAccount[0].ClassTypeID;
                            }
                            acJournalEntity.VoucherType = "Account Transfer";
                            acJournalEntity.MDDebitCreditID = MasterDataConstants.MDDebitCredit.DEBIT;
                            FCCACJournal.GetFacadeCreate().Add(acJournalEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        }

                        #endregion

                        acJournalEntity = new ACJournalEntity();
                    }
                }

                #endregion
            }
            catch (Exception ex)
            {
                
            }
        }

        #endregion

        #endregion

        #region Inventory Input From MRR

        public static void AutoInventoryEntry(Int64 materialReceiveID)
        {
            try
            {
                #region Inventory

                String fe_MRR = SqlExpressionBuilder.PrepareFilterExpression("PRMMaterialReceive." + PRMMaterialReceiveEntity.FLD_NAME_MaterialReceiveID, materialReceiveID.ToString(), SQLMatchType.Equal);

                IList<PRMMaterialReceive_DetailedEntity> lstprmMaterialReceive = FCCPRMMaterialReceive_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe_MRR);

                if (lstprmMaterialReceive != null && lstprmMaterialReceive.Count > 0)
                {

                    PRMMaterialReceiveEntity pRMMaterialReceiveEntity = FCCPRMMaterialReceive.GetFacadeCreate().GetByID(materialReceiveID);

                    Int64 _employeeID = Int64.Parse(pRMMaterialReceiveEntity.CreatedByEmployeeID.ToString());
                    Int64 _projectID = lstprmMaterialReceive[0].ProjectID;

                    String fe_MMRItem = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveItemMapEntity.FLD_NAME_MaterialReceiveID, materialReceiveID.ToString(), SQLMatchType.Equal);

                    IList<PRMMaterialReceiveItemMapEntity> lstMRRItem = FCCPRMMaterialReceiveItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_MMRItem, DatabaseOperationType.LoadWithFilterExpression);

                    INVStoreEntity storeEntity = INVManager.GetDefaultStore(_projectID);
                    Int64 storeID = storeEntity.StoreID;

                    INVStoreUnitEntity storeUnitEntity = INVManager.GetDefaultStoreUnit(storeID);
                    Int64 storeUnitID = storeUnitEntity.StoreUnitID;

                    if (lstMRRItem != null && lstMRRItem.Count > 0)
                    {
                        foreach (PRMMaterialReceiveItemMapEntity ent in lstMRRItem)
                        {
                            String fe_requisitionItem = SqlExpressionBuilder.PrepareFilterExpression("REQRequisitionItem." + REQRequisitionItemEntity.FLD_NAME_RequisitionItemID, ent.RequisitionItemID.ToString(), SQLMatchType.Equal);
                            IList<REQRequisitionItem_DetailedEntity> lst = FCCREQRequisitionItem_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe_requisitionItem);

                            Int64 _itemID = 0;
                            Decimal _rate = 0;
                            Int64 brandID = 0;
                            Int64 regionID = 0;
                            Int64 countryID = 0;

                            if (lst != null && lst.Count > 0)
                            {
                                _itemID = lst[0].ItemID;
                                brandID = (Int64)lst[0].BrandID;
                                regionID = (Int64)lst[0].RegionID;
                                countryID = (Int64)lst[0].CountryID;

                                String fe_WOItemID = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemMapEntity.FLD_NAME_RequisitionItemID, lst[0].RequisitionItemID.ToString(), SQLMatchType.Equal);
                                String fe_WOID = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemMapEntity.FLD_NAME_WorkOrderID, lstprmMaterialReceive[0].WorkOrderID.ToString(), SQLMatchType.Equal);

                                String fe_WOItemMap = SqlExpressionBuilder.PrepareFilterExpression(fe_WOItemID, SQLJoinType.AND, fe_WOID);

                                IList<PRMWorkOrderItemMapEntity> lstWOItem = FCCPRMWorkOrderItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_WOItemMap, DatabaseOperationType.LoadWithFilterExpression);

                                if (lstWOItem != null && lstWOItem.Count > 0)
                                {
                                    Decimal.TryParse(lstWOItem[0].Rate.ToString(), out _rate);
                                }
                            }

                            Int64 receiveQty, projectID;

                            receiveQty = (Int64)ent.ReceiveQty;

                            //Int64.TryParse(ent.ReceiveQty.ToString(), out receiveQty);
                            //Int64.TryParse(lstprmMaterialReceive[0].ProjectID.ToString(), out projectID);

                            Boolean invResult = INVManager.AddItemsToStoreUnit(_itemID, brandID, regionID, countryID, "", receiveQty, MiscUtil.GetLocalIP(), _employeeID, _rate, lstprmMaterialReceive[0].RequisitionNo.ToString(), lstprmMaterialReceive[0].WorkOrderNo.ToString(), lstprmMaterialReceive[0].MaterialReceiveID.ToString(), "", lstprmMaterialReceive[0].ProjectID, storeID, storeUnitID);
                        }
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {

            }
        }

        public static void ResetAPForMRRQtyDeductionEntry(Int64 materialReceiveID)
        {
            try
            {
                #region Inventory

                String fe_MRR = SqlExpressionBuilder.PrepareFilterExpression("PRMMaterialReceive." + PRMMaterialReceiveEntity.FLD_NAME_MaterialReceiveID, materialReceiveID.ToString(), SQLMatchType.Equal);

                IList<PRMMaterialReceive_DetailedEntity> lstprmMaterialReceive = FCCPRMMaterialReceive_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe_MRR);

                if (lstprmMaterialReceive != null && lstprmMaterialReceive.Count > 0)
                {

                    PRMMaterialReceiveEntity pRMMaterialReceiveEntity = FCCPRMMaterialReceive.GetFacadeCreate().GetByID(materialReceiveID);

                    Int64 _employeeID = Int64.Parse(pRMMaterialReceiveEntity.CreatedByEmployeeID.ToString());
                    Int64 _projectID = lstprmMaterialReceive[0].ProjectID;

                    String fe_MMRItem = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveItemMapEntity.FLD_NAME_MaterialReceiveID, materialReceiveID.ToString(), SQLMatchType.Equal);

                    IList<PRMMaterialReceiveItemMapEntity> lstMRRItem = FCCPRMMaterialReceiveItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_MMRItem, DatabaseOperationType.LoadWithFilterExpression);

                    INVStoreEntity storeEntity = INVManager.GetDefaultStore(_projectID);
                    Int64 storeID = storeEntity.StoreID;

                    INVStoreUnitEntity storeUnitEntity = INVManager.GetDefaultStoreUnit(storeID);
                    Int64 storeUnitID = storeUnitEntity.StoreUnitID;

                    if (lstMRRItem != null && lstMRRItem.Count > 0)
                    {
                        foreach (PRMMaterialReceiveItemMapEntity ent in lstMRRItem)
                        {
                            String fe_requisitionItem = SqlExpressionBuilder.PrepareFilterExpression("REQRequisitionItem." + REQRequisitionItemEntity.FLD_NAME_RequisitionItemID, ent.RequisitionItemID.ToString(), SQLMatchType.Equal);
                            IList<REQRequisitionItem_DetailedEntity> lst = FCCREQRequisitionItem_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe_requisitionItem);

                            Int64 _itemID = 0;
                            Decimal _rate = 0;
                            Int64 brandID = 0;
                            Int64 regionID = 0;
                            Int64 countryID = 0;

                            if (lst != null && lst.Count > 0)
                            {
                                _itemID = lst[0].ItemID;
                                brandID = (Int64)lst[0].BrandID;
                                regionID = (Int64)lst[0].RegionID;
                                countryID = (Int64)lst[0].CountryID;

                                String fe_WOItemID = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemMapEntity.FLD_NAME_RequisitionItemID, lst[0].RequisitionItemID.ToString(), SQLMatchType.Equal);
                                String fe_WOID = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemMapEntity.FLD_NAME_WorkOrderID, lstprmMaterialReceive[0].WorkOrderID.ToString(), SQLMatchType.Equal);

                                String fe_WOItemMap = SqlExpressionBuilder.PrepareFilterExpression(fe_WOItemID, SQLJoinType.AND, fe_WOID);

                                IList<PRMWorkOrderItemMapEntity> lstWOItem = FCCPRMWorkOrderItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_WOItemMap, DatabaseOperationType.LoadWithFilterExpression);

                                if (lstWOItem != null && lstWOItem.Count > 0)
                                {
                                    Decimal.TryParse(lstWOItem[0].Rate.ToString(), out _rate);
                                }
                            }

                            Int64 receiveQty, projectID;

                            receiveQty = (Int64)ent.ReceiveQty;

                            //Int64.TryParse(ent.ReceiveQty.ToString(), out receiveQty);
                            //Int64.TryParse(lstprmMaterialReceive[0].ProjectID.ToString(), out projectID);

                            Boolean invResult = INVManager.RemoveItemsFromStoreUnit(_itemID, brandID, regionID, countryID, "", receiveQty, MiscUtil.GetLocalIP(), _employeeID, _rate, lstprmMaterialReceive[0].RequisitionNo.ToString(), lstprmMaterialReceive[0].WorkOrderNo.ToString(), lstprmMaterialReceive[0].MaterialReceiveID.ToString(), "Negative MRR Entry", lstprmMaterialReceive[0].ProjectID, storeID, storeUnitID);
                        }
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {

            }
        }

        #endregion

        #region Update Agreement Text

        public static void AgreementText(Int64 agreementID)
        {
            try
            {
                CRMAgreementEntity cRMAgreementEntity = FCCCRMAgreement.GetFacadeCreate().GetByID(agreementID);

                if (cRMAgreementEntity != null && cRMAgreementEntity.AgreementID > 0)
                {
                    String input = cRMAgreementEntity.Text.ToString();

                    String newOutPut = String.Empty;

                    String fe_agreement = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementVariableMapEntity.FLD_NAME_AgreementID, agreementID.ToString(), SQLMatchType.Equal);
                    IList<CRMAgreementVariableMapEntity> cRMAgreementVariableMapList = FCCCRMAgreementVariableMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_agreement, DatabaseOperationType.LoadWithFilterExpression);

                    if (cRMAgreementVariableMapList != null && cRMAgreementVariableMapList.Count > 0)
                    {
                        foreach (CRMAgreementVariableMapEntity ent in cRMAgreementVariableMapList)
                        {
                            if (input.Contains(ent.Name))
                            {
                                newOutPut = MiscUtil.ReplaceFullWords(input, ent.Name, ent.Value.ToString());
                                input = newOutPut;
                            }
                        }
                    }

                    cRMAgreementEntity.Text = newOutPut;
                    FCCCRMAgreement.GetFacadeCreate().Update(cRMAgreementEntity, fe_agreement, DatabaseOperationType.Update, TransactionRequired.No);
                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion

        #region Bill(Notification)

        public static void BillNotification(Int64 billID)
        {
            CMBillEntity cMBillEntity = FCCCMBill.GetFacadeCreate().GetByID(billID);

            if (cMBillEntity != null && cMBillEntity.BillID > 0)
            {
                String[] sendToMail = new String[] { "accounts@baydevelopments.com" };
                //String[] sendToMail = new String[] { "ajay.dutta@b2b-erp.com" };

                #region Bill Notification Body

                String MailBody = String.Empty;
                String Subject = String.Empty;

                StringBuilder sb = new StringBuilder();

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Bill Approved.");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("<u>Bill Details</u>");
                sb.Append("<br/>");
                sb.Append("Bill No:&nbsp;" + cMBillEntity.BillNo.ToString());
                sb.Append("<br/>");
                sb.Append("Due Date:&nbsp;" + cMBillEntity.BillDate.ToString(UIConstants.SHORT_DATE_FORMAT));
                sb.Append("<br/>");
                sb.Append("Bill Amount:&nbsp;" + cMBillEntity.Amount.ToString());
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Bill " + cMBillEntity.BillNo.ToString() + " , Approved";

                #endregion

                MiscUtil.SendMail(sendToMail, Subject, MailBody);
            }
        }

        #endregion

        #region Deduct MRR Qty

        public static void DeductBOQorProjectCostQty(Int64 materialReceiveID)
        {
            String fe_MRRItemMap = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveItemMapEntity.FLD_NAME_MaterialReceiveID, materialReceiveID.ToString(), SQLMatchType.Equal);
            IList<PRMMaterialReceiveItemMapEntity> lstPRMMaterialReceiveItemMapEntity = FCCPRMMaterialReceiveItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_MRRItemMap, DatabaseOperationType.LoadWithFilterExpression);

            if (lstPRMMaterialReceiveItemMapEntity != null && lstPRMMaterialReceiveItemMapEntity.Count > 0)
            {
                foreach (PRMMaterialReceiveItemMapEntity pRMMaterialReceiveItemMapEntity in lstPRMMaterialReceiveItemMapEntity)
                {
                    REQRequisitionItemEntity rEQRequisitionItemEntity = FCCREQRequisitionItem.GetFacadeCreate().GetByID(pRMMaterialReceiveItemMapEntity.RequisitionItemID);

                    if (rEQRequisitionItemEntity != null && rEQRequisitionItemEntity.RequisitionID > 0)
                    {
                        REQRequisitionEntity _rEQrequisitonEntity = FCCREQRequisition.GetFacadeCreate().GetByID(rEQRequisitionItemEntity.RequisitionID);

                        if (_rEQrequisitonEntity != null && _rEQrequisitonEntity.RequisitionID > 0)
                        {

                            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_ProjectID, _rEQrequisitonEntity.ProjectID.ToString(), SQLMatchType.Equal);
                            IList<PRMPreBOQEntity> preBOQList = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                            if (preBOQList != null && preBOQList.Count > 0)
                            {
                                PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity = new PRMAvailableBOQQtyForRequisitionEntity();

                                pRMAvailableBOQQtyForRequisitionEntity.ItemID = rEQRequisitionItemEntity.ItemID;

                                if (preBOQList[0].IsLocked == false)
                                {
                                    pRMAvailableBOQQtyForRequisitionEntity.IsBOQ = false;

                                    #region PreBOQ Info

                                    String fe_PreboqID = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_PreBOQID, preBOQList[0].PreBOQID.ToString(), SQLMatchType.Equal);
                                    String fe_itemID = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_ItemID, rEQRequisitionItemEntity.ItemID.ToString(), SQLMatchType.Equal);
                                    String fe_PreBOQDetail = SqlExpressionBuilder.PrepareFilterExpression(fe_PreboqID, SQLJoinType.AND, fe_itemID);
                                    IList<PRMPreBOQDetailEntity> lstPreBOQDetail = FCCPRMPreBOQDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_PreBOQDetail, DatabaseOperationType.LoadWithFilterExpression);

                                    if (lstPreBOQDetail != null && lstPreBOQDetail.Count > 0)
                                    {
                                        pRMAvailableBOQQtyForRequisitionEntity.PreBOQOrBOQDetailID = lstPreBOQDetail[0].PreBOQDetailID;
                                    }

                                    #endregion
                                }

                                else if (preBOQList[0].IsLocked == true)
                                {
                                    pRMAvailableBOQQtyForRequisitionEntity.IsBOQ = true;

                                    #region BOQ Qty Info

                                    String fe_BOQ = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQEntity.FLD_NAME_PreBOQID, preBOQList[0].PreBOQID.ToString(), SQLMatchType.Equal);
                                    IList<PRMBOQEntity> lstBOQ = FCCPRMBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe_BOQ, DatabaseOperationType.LoadWithFilterExpression);

                                    if (lstBOQ != null && lstBOQ.Count > 0)
                                    {
                                        String fe_boqID = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_BOQID, lstBOQ[0].BOQID.ToString(), SQLMatchType.Equal);
                                        String fe_itemID = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_ItemID, rEQRequisitionItemEntity.ItemID.ToString(), SQLMatchType.Equal);
                                        String fe_BOQDetail = SqlExpressionBuilder.PrepareFilterExpression(fe_boqID, SQLJoinType.AND, fe_itemID);

                                        IList<PRMBOQDetailEntity> lstBOQDetail = FCCPRMBOQDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_BOQDetail, DatabaseOperationType.LoadWithFilterExpression);

                                        if (lstBOQDetail != null && lstBOQDetail.Count > 0)
                                        {
                                            pRMAvailableBOQQtyForRequisitionEntity.PreBOQOrBOQDetailID = lstBOQDetail[0].BOQDetailID;
                                        }
                                    }

                                    #endregion
                                }

                                pRMAvailableBOQQtyForRequisitionEntity.Qty = -pRMMaterialReceiveItemMapEntity.ReceiveQty;
                                pRMAvailableBOQQtyForRequisitionEntity.CreateDate = DateTime.Now;
                                pRMAvailableBOQQtyForRequisitionEntity.CreatedByEmployeeID = 168;//Not So valuable Here, It'll replaced by system Admin
                                pRMAvailableBOQQtyForRequisitionEntity.ProjectID = _rEQrequisitonEntity.ProjectID;
                                Int64 result = -1;
                                result = FCCPRMAvailableBOQQtyForRequisition.GetFacadeCreate().Add(pRMAvailableBOQQtyForRequisitionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #endregion

    }
}