// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IHRSalaryAdjustmentDataAccess

    public partial interface IHRSalaryAdjustmentDataAccess
    {
        #region Save Update Delete List

        Int64 Add(HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<HRSalaryAdjustmentEntity> hRSalaryAdjustmentEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<HRSalaryAdjustmentEntity> hRSalaryAdjustmentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<HRSalaryAdjustmentEntity> hRSalaryAdjustmentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<HRSalaryAdjustmentEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
