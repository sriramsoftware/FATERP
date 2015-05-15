// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IBDProcessAssignedResourceDataAccess

    public partial interface IBDProcessAssignedResourceDataAccess
    {
        #region Save Update Delete List

        Int64 Add(BDProcessAssignedResourceEntity bDProcessAssignedResourceEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(BDProcessAssignedResourceEntity bDProcessAssignedResourceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(BDProcessAssignedResourceEntity bDProcessAssignedResourceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<BDProcessAssignedResourceEntity> bDProcessAssignedResourceEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<BDProcessAssignedResourceEntity> bDProcessAssignedResourceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<BDProcessAssignedResourceEntity> bDProcessAssignedResourceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<BDProcessAssignedResourceEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}