// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Sep-2012, 12:46:09




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IMDDocumentStorageTypeDataAccess

    public partial interface IMDDocumentStorageTypeDataAccess
    {
        #region Save Update Delete List

        Int64 Add(MDDocumentStorageTypeEntity mDDocumentStorageTypeEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(MDDocumentStorageTypeEntity mDDocumentStorageTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(MDDocumentStorageTypeEntity mDDocumentStorageTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<MDDocumentStorageTypeEntity> mDDocumentStorageTypeEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<MDDocumentStorageTypeEntity> mDDocumentStorageTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<MDDocumentStorageTypeEntity> mDDocumentStorageTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<MDDocumentStorageTypeEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
