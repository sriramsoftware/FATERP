// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Mar-2012, 11:45:48




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region ICMNDashboardItemQuicklinkDataAccess

    public partial interface ICMNDashboardItemQuicklinkDataAccess
    {
        #region Save Update Delete List

        Int64 Add(CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<CMNDashboardItemQuicklinkEntity> cMNDashboardItemQuicklinkEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<CMNDashboardItemQuicklinkEntity> cMNDashboardItemQuicklinkEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<CMNDashboardItemQuicklinkEntity> cMNDashboardItemQuicklinkEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<CMNDashboardItemQuicklinkEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
