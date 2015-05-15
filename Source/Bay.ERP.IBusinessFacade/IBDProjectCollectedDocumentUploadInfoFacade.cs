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
    #region IBDProjectCollectedDocumentUploadInfoFacade

    [ServiceContract(Name = "IBDProjectCollectedDocumentUploadInfoFacade")]
    public partial interface IBDProjectCollectedDocumentUploadInfoFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<BDProjectCollectedDocumentUploadInfoEntity> bDProjectCollectedDocumentUploadInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<BDProjectCollectedDocumentUploadInfoEntity> bDProjectCollectedDocumentUploadInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<BDProjectCollectedDocumentUploadInfoEntity> bDProjectCollectedDocumentUploadInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<BDProjectCollectedDocumentUploadInfoEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        BDProjectCollectedDocumentUploadInfoEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
