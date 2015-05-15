// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 12:52:14




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IINVStoreIssueNoteDataAccess

    public partial interface IINVStoreIssueNoteDataAccess
    {
        #region Save Update Delete List

        Int64 Add(INVStoreIssueNoteEntity iNVStoreIssueNoteEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(INVStoreIssueNoteEntity iNVStoreIssueNoteEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(INVStoreIssueNoteEntity iNVStoreIssueNoteEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<INVStoreIssueNoteEntity> iNVStoreIssueNoteEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<INVStoreIssueNoteEntity> iNVStoreIssueNoteEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<INVStoreIssueNoteEntity> iNVStoreIssueNoteEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<INVStoreIssueNoteEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
