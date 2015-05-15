// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IPRMPreBOQDetailFacade

    [ServiceContract(Name = "IPRMPreBOQDetailFacade")]
    public partial interface IPRMPreBOQDetailFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(PRMPreBOQDetailEntity pRMPreBOQDetailEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(PRMPreBOQDetailEntity pRMPreBOQDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(PRMPreBOQDetailEntity pRMPreBOQDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<PRMPreBOQDetailEntity> pRMPreBOQDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<PRMPreBOQDetailEntity> pRMPreBOQDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<PRMPreBOQDetailEntity> pRMPreBOQDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<PRMPreBOQDetailEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        PRMPreBOQDetailEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
