// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jun-2012, 05:50:09




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IPRMWorkOrderItemMapFacade

    [ServiceContract(Name = "IPRMWorkOrderItemMapFacade")]
    public partial interface IPRMWorkOrderItemMapFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<PRMWorkOrderItemMapEntity> pRMWorkOrderItemMapEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<PRMWorkOrderItemMapEntity> pRMWorkOrderItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<PRMWorkOrderItemMapEntity> pRMWorkOrderItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<PRMWorkOrderItemMapEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        PRMWorkOrderItemMapEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
