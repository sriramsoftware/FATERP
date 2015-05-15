// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region ICRMMDBuyerInterestedRoomCategoryDataAccess

    public partial interface ICRMMDBuyerInterestedRoomCategoryDataAccess
    {
        #region Save Update Delete List

        Int64 Add(CRMMDBuyerInterestedRoomCategoryEntity cRMMDBuyerInterestedRoomCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(CRMMDBuyerInterestedRoomCategoryEntity cRMMDBuyerInterestedRoomCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(CRMMDBuyerInterestedRoomCategoryEntity cRMMDBuyerInterestedRoomCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<CRMMDBuyerInterestedRoomCategoryEntity> cRMMDBuyerInterestedRoomCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<CRMMDBuyerInterestedRoomCategoryEntity> cRMMDBuyerInterestedRoomCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<CRMMDBuyerInterestedRoomCategoryEntity> cRMMDBuyerInterestedRoomCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<CRMMDBuyerInterestedRoomCategoryEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
