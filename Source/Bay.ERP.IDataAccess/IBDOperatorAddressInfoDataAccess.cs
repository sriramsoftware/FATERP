// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-May-2015, 08:31:04




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IBDOperatorAddressInfoDataAccess

    public partial interface IBDOperatorAddressInfoDataAccess
    {
        #region Save Update Delete List

        Int64 Add(BDOperatorAddressInfoEntity bDOperatorAddressInfoEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(BDOperatorAddressInfoEntity bDOperatorAddressInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(BDOperatorAddressInfoEntity bDOperatorAddressInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<BDOperatorAddressInfoEntity> bDOperatorAddressInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<BDOperatorAddressInfoEntity> bDOperatorAddressInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<BDOperatorAddressInfoEntity> bDOperatorAddressInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<BDOperatorAddressInfoEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
