// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Jul-2012, 05:23:43




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IMDProjectAssignedPersonTeamRoleDataAccess

    public partial interface IMDProjectAssignedPersonTeamRoleDataAccess
    {
        #region Save Update Delete List

        Int64 Add(MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<MDProjectAssignedPersonTeamRoleEntity> mDProjectAssignedPersonTeamRoleEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<MDProjectAssignedPersonTeamRoleEntity> mDProjectAssignedPersonTeamRoleEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<MDProjectAssignedPersonTeamRoleEntity> mDProjectAssignedPersonTeamRoleEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<MDProjectAssignedPersonTeamRoleEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
