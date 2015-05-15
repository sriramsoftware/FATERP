// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Sep-2012, 10:06:41




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IDMSReferenceLibraryDataAccess

    public partial interface IDMSReferenceLibraryDataAccess
    {
        #region Save Update Delete List

        Int64 Add(DMSReferenceLibraryEntity dMSReferenceLibraryEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(DMSReferenceLibraryEntity dMSReferenceLibraryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(DMSReferenceLibraryEntity dMSReferenceLibraryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<DMSReferenceLibraryEntity> dMSReferenceLibraryEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<DMSReferenceLibraryEntity> dMSReferenceLibraryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<DMSReferenceLibraryEntity> dMSReferenceLibraryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<DMSReferenceLibraryEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
