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
    #region IHREmployeeMonthlyTimeSheetDataAccess

    public partial interface IHREmployeeMonthlyTimeSheetDataAccess
    {
        #region Save Update Delete List

        Int64 Add(HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<HREmployeeMonthlyTimeSheetEntity> hREmployeeMonthlyTimeSheetEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<HREmployeeMonthlyTimeSheetEntity> hREmployeeMonthlyTimeSheetEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<HREmployeeMonthlyTimeSheetEntity> hREmployeeMonthlyTimeSheetEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<HREmployeeMonthlyTimeSheetEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
