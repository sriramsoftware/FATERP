// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Mar-2013, 10:27:29




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IACBankAccountTransferDataAccess

    public partial interface IACBankAccountTransferDataAccess
    {
        #region Save Update Delete List

        Int64 Add(ACBankAccountTransferEntity aCBankAccountTransferEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(ACBankAccountTransferEntity aCBankAccountTransferEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(ACBankAccountTransferEntity aCBankAccountTransferEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<ACBankAccountTransferEntity> aCBankAccountTransferEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<ACBankAccountTransferEntity> aCBankAccountTransferEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<ACBankAccountTransferEntity> aCBankAccountTransferEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<ACBankAccountTransferEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}