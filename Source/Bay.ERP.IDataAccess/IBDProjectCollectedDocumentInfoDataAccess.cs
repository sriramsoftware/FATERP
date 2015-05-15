// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Mar-2012, 03:28:59




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IBDProjectCollectedDocumentInfoDataAccess

    public partial interface IBDProjectCollectedDocumentInfoDataAccess
    {
        #region Save Update Delete List

        Int64 Add(BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<BDProjectCollectedDocumentInfoEntity> bDProjectCollectedDocumentInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<BDProjectCollectedDocumentInfoEntity> bDProjectCollectedDocumentInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<BDProjectCollectedDocumentInfoEntity> bDProjectCollectedDocumentInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<BDProjectCollectedDocumentInfoEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
