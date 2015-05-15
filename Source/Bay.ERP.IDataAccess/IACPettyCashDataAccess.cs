// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IACPettyCashDataAccess

    public partial interface IACPettyCashDataAccess
    {
        #region Save Update Delete List

        Int64 Add(ACPettyCashEntity aCPettyCashEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(ACPettyCashEntity aCPettyCashEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(ACPettyCashEntity aCPettyCashEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<ACPettyCashEntity> aCPettyCashEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<ACPettyCashEntity> aCPettyCashEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<ACPettyCashEntity> aCPettyCashEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<ACPettyCashEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
