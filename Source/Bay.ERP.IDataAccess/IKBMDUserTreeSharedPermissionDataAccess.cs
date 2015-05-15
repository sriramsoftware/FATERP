// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IKBMDUserTreeSharedPermissionDataAccess

    public partial interface IKBMDUserTreeSharedPermissionDataAccess
    {
        #region Save Update Delete List

        Int64 Add(KBMDUserTreeSharedPermissionEntity kBMDUserTreeSharedPermissionEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(KBMDUserTreeSharedPermissionEntity kBMDUserTreeSharedPermissionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(KBMDUserTreeSharedPermissionEntity kBMDUserTreeSharedPermissionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<KBMDUserTreeSharedPermissionEntity> kBMDUserTreeSharedPermissionEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<KBMDUserTreeSharedPermissionEntity> kBMDUserTreeSharedPermissionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<KBMDUserTreeSharedPermissionEntity> kBMDUserTreeSharedPermissionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<KBMDUserTreeSharedPermissionEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
