// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jul-2013, 11:20:53




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IACBankAccountDepositItemDataAccess

    public partial interface IACBankAccountDepositItemDataAccess
    {
        #region Save Update Delete List

        Int64 Add(ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<ACBankAccountDepositItemEntity> aCBankAccountDepositItemEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<ACBankAccountDepositItemEntity> aCBankAccountDepositItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<ACBankAccountDepositItemEntity> aCBankAccountDepositItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<ACBankAccountDepositItemEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
