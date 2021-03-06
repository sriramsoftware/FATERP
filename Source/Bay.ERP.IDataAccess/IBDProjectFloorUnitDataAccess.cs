// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2013, 03:32:47




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IBDProjectFloorUnitDataAccess

    public partial interface IBDProjectFloorUnitDataAccess
    {
        #region Save Update Delete List

        Int64 Add(BDProjectFloorUnitEntity bDProjectFloorUnitEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(BDProjectFloorUnitEntity bDProjectFloorUnitEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(BDProjectFloorUnitEntity bDProjectFloorUnitEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<BDProjectFloorUnitEntity> bDProjectFloorUnitEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<BDProjectFloorUnitEntity> bDProjectFloorUnitEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<BDProjectFloorUnitEntity> bDProjectFloorUnitEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<BDProjectFloorUnitEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
