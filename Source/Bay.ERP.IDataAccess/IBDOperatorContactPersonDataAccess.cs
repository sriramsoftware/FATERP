// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2015, 12:50:36




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IBDOperatorContactPersonDataAccess

    public partial interface IBDOperatorContactPersonDataAccess
    {
        #region Save Update Delete List

        Int64 Add(BDOperatorContactPersonEntity bDOperatorContactPersonEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(BDOperatorContactPersonEntity bDOperatorContactPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(BDOperatorContactPersonEntity bDOperatorContactPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<BDOperatorContactPersonEntity> bDOperatorContactPersonEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<BDOperatorContactPersonEntity> bDOperatorContactPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<BDOperatorContactPersonEntity> bDOperatorContactPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<BDOperatorContactPersonEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
