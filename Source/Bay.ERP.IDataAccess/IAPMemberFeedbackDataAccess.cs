// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Oct-2012, 11:32:20




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IAPMemberFeedbackDataAccess

    public partial interface IAPMemberFeedbackDataAccess
    {
        #region Save Update Delete List

        Int64 Add(APMemberFeedbackEntity aPMemberFeedbackEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(APMemberFeedbackEntity aPMemberFeedbackEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(APMemberFeedbackEntity aPMemberFeedbackEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<APMemberFeedbackEntity> aPMemberFeedbackEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<APMemberFeedbackEntity> aPMemberFeedbackEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<APMemberFeedbackEntity> aPMemberFeedbackEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<APMemberFeedbackEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
