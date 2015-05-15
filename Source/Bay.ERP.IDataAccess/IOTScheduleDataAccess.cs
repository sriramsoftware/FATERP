// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IOTScheduleDataAccess

    public partial interface IOTScheduleDataAccess
    {
        #region Save Update Delete List

        Int64 Add(OTScheduleEntity oTScheduleEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(OTScheduleEntity oTScheduleEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(OTScheduleEntity oTScheduleEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<OTScheduleEntity> oTScheduleEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<OTScheduleEntity> oTScheduleEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<OTScheduleEntity> oTScheduleEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<OTScheduleEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
