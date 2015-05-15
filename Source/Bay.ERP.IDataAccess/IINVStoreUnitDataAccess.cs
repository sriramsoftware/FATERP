// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 02:43:44




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IINVStoreUnitDataAccess

    public partial interface IINVStoreUnitDataAccess
    {
        #region Save Update Delete List

        Int64 Add(INVStoreUnitEntity iNVStoreUnitEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(INVStoreUnitEntity iNVStoreUnitEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(INVStoreUnitEntity iNVStoreUnitEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<INVStoreUnitEntity> iNVStoreUnitEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<INVStoreUnitEntity> iNVStoreUnitEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<INVStoreUnitEntity> iNVStoreUnitEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<INVStoreUnitEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
