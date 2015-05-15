// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Feb-2013, 12:00:20




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IACMDBankAccountPaymentApprovalStatusFacade

    [ServiceContract(Name = "IACMDBankAccountPaymentApprovalStatusFacade")]
    public partial interface IACMDBankAccountPaymentApprovalStatusFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(ACMDBankAccountPaymentApprovalStatusEntity aCMDBankAccountPaymentApprovalStatusEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(ACMDBankAccountPaymentApprovalStatusEntity aCMDBankAccountPaymentApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(ACMDBankAccountPaymentApprovalStatusEntity aCMDBankAccountPaymentApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<ACMDBankAccountPaymentApprovalStatusEntity> aCMDBankAccountPaymentApprovalStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<ACMDBankAccountPaymentApprovalStatusEntity> aCMDBankAccountPaymentApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<ACMDBankAccountPaymentApprovalStatusEntity> aCMDBankAccountPaymentApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<ACMDBankAccountPaymentApprovalStatusEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        ACMDBankAccountPaymentApprovalStatusEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
