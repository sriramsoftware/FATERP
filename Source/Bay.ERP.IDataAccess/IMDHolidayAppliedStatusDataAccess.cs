// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IMDHolidayAppliedStatusDataAccess

    public partial interface IMDHolidayAppliedStatusDataAccess
    {
        #region Save Update Delete List

        Int64 Add(MDHolidayAppliedStatusEntity mDHolidayAppliedStatusEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(MDHolidayAppliedStatusEntity mDHolidayAppliedStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(MDHolidayAppliedStatusEntity mDHolidayAppliedStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<MDHolidayAppliedStatusEntity> mDHolidayAppliedStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<MDHolidayAppliedStatusEntity> mDHolidayAppliedStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<MDHolidayAppliedStatusEntity> mDHolidayAppliedStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<MDHolidayAppliedStatusEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
