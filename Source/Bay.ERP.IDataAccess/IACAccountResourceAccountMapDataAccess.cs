// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jun-2013, 03:54:41




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IACAccountResourceAccountMapDataAccess

    public partial interface IACAccountResourceAccountMapDataAccess
    {
        #region Save Update Delete List

        Int64 Add(ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<ACAccountResourceAccountMapEntity> aCAccountResourceAccountMapEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<ACAccountResourceAccountMapEntity> aCAccountResourceAccountMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<ACAccountResourceAccountMapEntity> aCAccountResourceAccountMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<ACAccountResourceAccountMapEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
