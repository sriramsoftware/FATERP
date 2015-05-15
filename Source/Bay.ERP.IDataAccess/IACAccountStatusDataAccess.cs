// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2013, 03:28:28




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IACAccountStatusDataAccess

    public partial interface IACAccountStatusDataAccess
    {
        #region Save Update Delete List

        Int64 Add(ACAccountStatusEntity aCAccountStatusEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(ACAccountStatusEntity aCAccountStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(ACAccountStatusEntity aCAccountStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<ACAccountStatusEntity> aCAccountStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<ACAccountStatusEntity> aCAccountStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<ACAccountStatusEntity> aCAccountStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<ACAccountStatusEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}