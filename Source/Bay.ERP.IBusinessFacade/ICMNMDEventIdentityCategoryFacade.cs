// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2013, 05:27:25




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region ICMNMDEventIdentityCategoryFacade

    [ServiceContract(Name = "ICMNMDEventIdentityCategoryFacade")]
    public partial interface ICMNMDEventIdentityCategoryFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(CMNMDEventIdentityCategoryEntity cMNMDEventIdentityCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(CMNMDEventIdentityCategoryEntity cMNMDEventIdentityCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(CMNMDEventIdentityCategoryEntity cMNMDEventIdentityCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<CMNMDEventIdentityCategoryEntity> cMNMDEventIdentityCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<CMNMDEventIdentityCategoryEntity> cMNMDEventIdentityCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<CMNMDEventIdentityCategoryEntity> cMNMDEventIdentityCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<CMNMDEventIdentityCategoryEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        CMNMDEventIdentityCategoryEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
