// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 03:53:48




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IAPPanelItemCategoryMapFacade

    [ServiceContract(Name = "IAPPanelItemCategoryMapFacade")]
    public partial interface IAPPanelItemCategoryMapFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(APPanelItemCategoryMapEntity aPPanelItemCategoryMapEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(APPanelItemCategoryMapEntity aPPanelItemCategoryMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(APPanelItemCategoryMapEntity aPPanelItemCategoryMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<APPanelItemCategoryMapEntity> aPPanelItemCategoryMapEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<APPanelItemCategoryMapEntity> aPPanelItemCategoryMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<APPanelItemCategoryMapEntity> aPPanelItemCategoryMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<APPanelItemCategoryMapEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        APPanelItemCategoryMapEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
