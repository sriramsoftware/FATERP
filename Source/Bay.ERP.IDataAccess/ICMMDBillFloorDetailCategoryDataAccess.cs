// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Aug-2013, 02:50:29




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region ICMMDBillFloorDetailCategoryDataAccess

    public partial interface ICMMDBillFloorDetailCategoryDataAccess
    {
        #region Save Update Delete List

        Int64 Add(CMMDBillFloorDetailCategoryEntity cMMDBillFloorDetailCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(CMMDBillFloorDetailCategoryEntity cMMDBillFloorDetailCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(CMMDBillFloorDetailCategoryEntity cMMDBillFloorDetailCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<CMMDBillFloorDetailCategoryEntity> cMMDBillFloorDetailCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<CMMDBillFloorDetailCategoryEntity> cMMDBillFloorDetailCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<CMMDBillFloorDetailCategoryEntity> cMMDBillFloorDetailCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<CMMDBillFloorDetailCategoryEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
