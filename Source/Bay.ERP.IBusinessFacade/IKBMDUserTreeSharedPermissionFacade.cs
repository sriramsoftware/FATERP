// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IKBMDUserTreeSharedPermissionFacade

    [ServiceContract(Name = "IKBMDUserTreeSharedPermissionFacade")]
    public partial interface IKBMDUserTreeSharedPermissionFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(KBMDUserTreeSharedPermissionEntity kBMDUserTreeSharedPermissionEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(KBMDUserTreeSharedPermissionEntity kBMDUserTreeSharedPermissionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(KBMDUserTreeSharedPermissionEntity kBMDUserTreeSharedPermissionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<KBMDUserTreeSharedPermissionEntity> kBMDUserTreeSharedPermissionEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<KBMDUserTreeSharedPermissionEntity> kBMDUserTreeSharedPermissionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<KBMDUserTreeSharedPermissionEntity> kBMDUserTreeSharedPermissionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<KBMDUserTreeSharedPermissionEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        KBMDUserTreeSharedPermissionEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
