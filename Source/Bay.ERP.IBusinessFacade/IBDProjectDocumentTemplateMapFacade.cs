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
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IBDProjectDocumentTemplateMapFacade

    [ServiceContract(Name = "IBDProjectDocumentTemplateMapFacade")]
    public partial interface IBDProjectDocumentTemplateMapFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<BDProjectDocumentTemplateMapEntity> bDProjectDocumentTemplateMapEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<BDProjectDocumentTemplateMapEntity> bDProjectDocumentTemplateMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<BDProjectDocumentTemplateMapEntity> bDProjectDocumentTemplateMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<BDProjectDocumentTemplateMapEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        BDProjectDocumentTemplateMapEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
