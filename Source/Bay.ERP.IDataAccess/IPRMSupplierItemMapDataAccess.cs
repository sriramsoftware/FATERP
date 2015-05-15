// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IPRMSupplierItemMapDataAccess

    public partial interface IPRMSupplierItemMapDataAccess
    {
        #region Save Update Delete List

        Int64 Add(PRMSupplierItemMapEntity pRMSupplierItemMapEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(PRMSupplierItemMapEntity pRMSupplierItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(PRMSupplierItemMapEntity pRMSupplierItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<PRMSupplierItemMapEntity> pRMSupplierItemMapEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<PRMSupplierItemMapEntity> pRMSupplierItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<PRMSupplierItemMapEntity> pRMSupplierItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<PRMSupplierItemMapEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
