// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 12:52:14




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IMDStoreIssueNoteApprovalStatusFacade

    [ServiceContract(Name = "IMDStoreIssueNoteApprovalStatusFacade")]
    public partial interface IMDStoreIssueNoteApprovalStatusFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<MDStoreIssueNoteApprovalStatusEntity> mDStoreIssueNoteApprovalStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<MDStoreIssueNoteApprovalStatusEntity> mDStoreIssueNoteApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<MDStoreIssueNoteApprovalStatusEntity> mDStoreIssueNoteApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<MDStoreIssueNoteApprovalStatusEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        MDStoreIssueNoteApprovalStatusEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
