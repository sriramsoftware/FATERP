// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jan-2012, 03:00:49




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IMDConstructionToolWorkingConditionDataAccess

    public partial interface IMDConstructionToolWorkingConditionDataAccess
    {
        #region Save Update Delete List

        Int64 Add(MDConstructionToolWorkingConditionEntity mDConstructionToolWorkingConditionEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(MDConstructionToolWorkingConditionEntity mDConstructionToolWorkingConditionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(MDConstructionToolWorkingConditionEntity mDConstructionToolWorkingConditionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<MDConstructionToolWorkingConditionEntity> mDConstructionToolWorkingConditionEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<MDConstructionToolWorkingConditionEntity> mDConstructionToolWorkingConditionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<MDConstructionToolWorkingConditionEntity> mDConstructionToolWorkingConditionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<MDConstructionToolWorkingConditionEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
