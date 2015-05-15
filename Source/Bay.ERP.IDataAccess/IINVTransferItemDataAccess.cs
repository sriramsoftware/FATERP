// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Dec-2012, 01:46:09




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IINVTransferItemDataAccess

    public partial interface IINVTransferItemDataAccess
    {
        #region Save Update Delete List

        Int64 Add(INVTransferItemEntity iNVTransferItemEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(INVTransferItemEntity iNVTransferItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(INVTransferItemEntity iNVTransferItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<INVTransferItemEntity> iNVTransferItemEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<INVTransferItemEntity> iNVTransferItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<INVTransferItemEntity> iNVTransferItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<INVTransferItemEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
