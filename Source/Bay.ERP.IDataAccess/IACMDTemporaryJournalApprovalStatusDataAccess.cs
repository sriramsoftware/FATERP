// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Feb-2013, 12:50:45




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IACMDTemporaryJournalApprovalStatusDataAccess

    public partial interface IACMDTemporaryJournalApprovalStatusDataAccess
    {
        #region Save Update Delete List

        Int64 Add(ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<ACMDTemporaryJournalApprovalStatusEntity> aCMDTemporaryJournalApprovalStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<ACMDTemporaryJournalApprovalStatusEntity> aCMDTemporaryJournalApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<ACMDTemporaryJournalApprovalStatusEntity> aCMDTemporaryJournalApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<ACMDTemporaryJournalApprovalStatusEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
