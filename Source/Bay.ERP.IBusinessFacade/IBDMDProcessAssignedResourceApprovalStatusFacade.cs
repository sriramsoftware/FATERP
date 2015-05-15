// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IBDMDProcessAssignedResourceApprovalStatusFacade

    [ServiceContract(Name = "IBDMDProcessAssignedResourceApprovalStatusFacade")]
    public partial interface IBDMDProcessAssignedResourceApprovalStatusFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<BDMDProcessAssignedResourceApprovalStatusEntity> bDMDProcessAssignedResourceApprovalStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<BDMDProcessAssignedResourceApprovalStatusEntity> bDMDProcessAssignedResourceApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<BDMDProcessAssignedResourceApprovalStatusEntity> bDMDProcessAssignedResourceApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<BDMDProcessAssignedResourceApprovalStatusEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        BDMDProcessAssignedResourceApprovalStatusEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
