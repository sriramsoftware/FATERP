// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:20:17




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region ICMNApprovalProcessDataAccess

    public partial interface ICMNApprovalProcessDataAccess
    {
        #region Save Update Delete List

        Int64 Add(CMNApprovalProcessEntity cMNApprovalProcessEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(CMNApprovalProcessEntity cMNApprovalProcessEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(CMNApprovalProcessEntity cMNApprovalProcessEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<CMNApprovalProcessEntity> cMNApprovalProcessEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<CMNApprovalProcessEntity> cMNApprovalProcessEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<CMNApprovalProcessEntity> cMNApprovalProcessEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<CMNApprovalProcessEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
