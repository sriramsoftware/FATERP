// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IBDProjectDocumentTemplateMapDataAccess

    public partial interface IBDProjectDocumentTemplateMapDataAccess
    {
        #region Save Update Delete List

        Int64 Add(BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<BDProjectDocumentTemplateMapEntity> bDProjectDocumentTemplateMapEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<BDProjectDocumentTemplateMapEntity> bDProjectDocumentTemplateMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<BDProjectDocumentTemplateMapEntity> bDProjectDocumentTemplateMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<BDProjectDocumentTemplateMapEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
