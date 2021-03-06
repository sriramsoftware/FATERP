// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Apr-2013, 12:14:24




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region ICRMPaymentCollectionDataAccess

    public partial interface ICRMPaymentCollectionDataAccess
    {
        #region Save Update Delete List

        Int64 Add(CRMPaymentCollectionEntity cRMPaymentCollectionEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(CRMPaymentCollectionEntity cRMPaymentCollectionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(CRMPaymentCollectionEntity cRMPaymentCollectionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<CRMPaymentCollectionEntity> cRMPaymentCollectionEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<CRMPaymentCollectionEntity> cRMPaymentCollectionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<CRMPaymentCollectionEntity> cRMPaymentCollectionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<CRMPaymentCollectionEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
