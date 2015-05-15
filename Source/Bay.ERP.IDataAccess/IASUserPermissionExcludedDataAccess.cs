// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:24:04




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IASUserPermissionExcludedDataAccess

    public partial interface IASUserPermissionExcludedDataAccess
    {
        #region Save Update Delete List

        Int64 Add(ASUserPermissionExcludedEntity aSUserPermissionExcludedEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(ASUserPermissionExcludedEntity aSUserPermissionExcludedEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(ASUserPermissionExcludedEntity aSUserPermissionExcludedEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<ASUserPermissionExcludedEntity> aSUserPermissionExcludedEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<ASUserPermissionExcludedEntity> aSUserPermissionExcludedEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<ASUserPermissionExcludedEntity> aSUserPermissionExcludedEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<ASUserPermissionExcludedEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
