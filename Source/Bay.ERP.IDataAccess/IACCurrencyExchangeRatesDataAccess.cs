// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 02:50:43




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IACCurrencyExchangeRatesDataAccess

    public partial interface IACCurrencyExchangeRatesDataAccess
    {
        #region Save Update Delete List

        Int64 Add(ACCurrencyExchangeRatesEntity aCCurrencyExchangeRatesEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(ACCurrencyExchangeRatesEntity aCCurrencyExchangeRatesEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(ACCurrencyExchangeRatesEntity aCCurrencyExchangeRatesEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<ACCurrencyExchangeRatesEntity> aCCurrencyExchangeRatesEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<ACCurrencyExchangeRatesEntity> aCCurrencyExchangeRatesEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<ACCurrencyExchangeRatesEntity> aCCurrencyExchangeRatesEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<ACCurrencyExchangeRatesEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
