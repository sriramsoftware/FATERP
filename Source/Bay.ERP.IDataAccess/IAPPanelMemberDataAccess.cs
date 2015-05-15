// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Oct-2012, 11:32:20




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IAPPanelMemberDataAccess

    public partial interface IAPPanelMemberDataAccess
    {
        #region Save Update Delete List

        Int64 Add(APPanelMemberEntity aPPanelMemberEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(APPanelMemberEntity aPPanelMemberEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(APPanelMemberEntity aPPanelMemberEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<APPanelMemberEntity> aPPanelMemberEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<APPanelMemberEntity> aPPanelMemberEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<APPanelMemberEntity> aPPanelMemberEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<APPanelMemberEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
