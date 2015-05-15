// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Sep-2013, 11:07:00




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IHREmployeeEvaluationResultDataAccess

    public partial interface IHREmployeeEvaluationResultDataAccess
    {
        #region Save Update Delete List

        Int64 Add(HREmployeeEvaluationResultEntity hREmployeeEvaluationResultEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(HREmployeeEvaluationResultEntity hREmployeeEvaluationResultEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(HREmployeeEvaluationResultEntity hREmployeeEvaluationResultEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<HREmployeeEvaluationResultEntity> hREmployeeEvaluationResultEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<HREmployeeEvaluationResultEntity> hREmployeeEvaluationResultEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<HREmployeeEvaluationResultEntity> hREmployeeEvaluationResultEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<HREmployeeEvaluationResultEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
