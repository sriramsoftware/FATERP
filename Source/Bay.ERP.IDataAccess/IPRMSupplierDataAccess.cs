// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-May-2012, 11:02:33




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IPRMSupplierDataAccess

    public partial interface IPRMSupplierDataAccess
    {
        #region Save Update Delete List

        Int64 Add(PRMSupplierEntity pRMSupplierEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(PRMSupplierEntity pRMSupplierEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(PRMSupplierEntity pRMSupplierEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<PRMSupplierEntity> pRMSupplierEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<PRMSupplierEntity> pRMSupplierEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<PRMSupplierEntity> pRMSupplierEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<PRMSupplierEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
