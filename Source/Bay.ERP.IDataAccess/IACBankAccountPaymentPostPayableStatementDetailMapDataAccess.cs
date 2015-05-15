// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jun-2013, 02:26:08




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IACBankAccountPaymentPostPayableStatementDetailMapDataAccess

    public partial interface IACBankAccountPaymentPostPayableStatementDetailMapDataAccess
    {
        #region Save Update Delete List

        Int64 Add(ACBankAccountPaymentPostPayableStatementDetailMapEntity aCBankAccountPaymentPostPayableStatementDetailMapEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(ACBankAccountPaymentPostPayableStatementDetailMapEntity aCBankAccountPaymentPostPayableStatementDetailMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(ACBankAccountPaymentPostPayableStatementDetailMapEntity aCBankAccountPaymentPostPayableStatementDetailMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<ACBankAccountPaymentPostPayableStatementDetailMapEntity> aCBankAccountPaymentPostPayableStatementDetailMapEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<ACBankAccountPaymentPostPayableStatementDetailMapEntity> aCBankAccountPaymentPostPayableStatementDetailMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<ACBankAccountPaymentPostPayableStatementDetailMapEntity> aCBankAccountPaymentPostPayableStatementDetailMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<ACBankAccountPaymentPostPayableStatementDetailMapEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
