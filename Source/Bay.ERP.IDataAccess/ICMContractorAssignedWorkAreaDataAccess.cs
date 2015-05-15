// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Jun-2012, 10:26:50




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region ICMContractorAssignedWorkAreaDataAccess

    public partial interface ICMContractorAssignedWorkAreaDataAccess
    {
        #region Save Update Delete List

        Int64 Add(CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<CMContractorAssignedWorkAreaEntity> cMContractorAssignedWorkAreaEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<CMContractorAssignedWorkAreaEntity> cMContractorAssignedWorkAreaEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<CMContractorAssignedWorkAreaEntity> cMContractorAssignedWorkAreaEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<CMContractorAssignedWorkAreaEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
