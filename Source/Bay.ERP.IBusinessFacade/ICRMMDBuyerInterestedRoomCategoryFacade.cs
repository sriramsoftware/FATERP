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
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region ICRMMDBuyerInterestedRoomCategoryFacade

    [ServiceContract(Name = "ICRMMDBuyerInterestedRoomCategoryFacade")]
    public partial interface ICRMMDBuyerInterestedRoomCategoryFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(CRMMDBuyerInterestedRoomCategoryEntity cRMMDBuyerInterestedRoomCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(CRMMDBuyerInterestedRoomCategoryEntity cRMMDBuyerInterestedRoomCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(CRMMDBuyerInterestedRoomCategoryEntity cRMMDBuyerInterestedRoomCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<CRMMDBuyerInterestedRoomCategoryEntity> cRMMDBuyerInterestedRoomCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<CRMMDBuyerInterestedRoomCategoryEntity> cRMMDBuyerInterestedRoomCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<CRMMDBuyerInterestedRoomCategoryEntity> cRMMDBuyerInterestedRoomCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<CRMMDBuyerInterestedRoomCategoryEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        CRMMDBuyerInterestedRoomCategoryEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
