// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-May-2012, 01:00:46




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IPRMBOQFloorDetailDataAccess

    public partial interface IPRMBOQFloorDetailDataAccess
    {
        #region Save Update Delete List

        Int64 Add(PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<PRMBOQFloorDetailEntity> pRMBOQFloorDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<PRMBOQFloorDetailEntity> pRMBOQFloorDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<PRMBOQFloorDetailEntity> pRMBOQFloorDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<PRMBOQFloorDetailEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
