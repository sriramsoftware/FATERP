// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jun-2013, 12:21:34




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IPRMAvailableBOQQtyForRequisitionFacade

    [ServiceContract(Name = "IPRMAvailableBOQQtyForRequisitionFacade")]
    public partial interface IPRMAvailableBOQQtyForRequisitionFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<PRMAvailableBOQQtyForRequisitionEntity> pRMAvailableBOQQtyForRequisitionEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<PRMAvailableBOQQtyForRequisitionEntity> pRMAvailableBOQQtyForRequisitionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<PRMAvailableBOQQtyForRequisitionEntity> pRMAvailableBOQQtyForRequisitionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<PRMAvailableBOQQtyForRequisitionEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        PRMAvailableBOQQtyForRequisitionEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
