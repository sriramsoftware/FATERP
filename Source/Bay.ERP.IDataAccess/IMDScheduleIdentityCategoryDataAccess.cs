// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IMDScheduleIdentityCategoryDataAccess

    public partial interface IMDScheduleIdentityCategoryDataAccess
    {
        #region Save Update Delete List

        Int64 Add(MDScheduleIdentityCategoryEntity mDScheduleIdentityCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(MDScheduleIdentityCategoryEntity mDScheduleIdentityCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(MDScheduleIdentityCategoryEntity mDScheduleIdentityCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<MDScheduleIdentityCategoryEntity> mDScheduleIdentityCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<MDScheduleIdentityCategoryEntity> mDScheduleIdentityCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<MDScheduleIdentityCategoryEntity> mDScheduleIdentityCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<MDScheduleIdentityCategoryEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}