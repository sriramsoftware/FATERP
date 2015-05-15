// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:24:04




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IASPhysicalSiteMapControlFacade

    [ServiceContract(Name = "IASPhysicalSiteMapControlFacade")]
    public partial interface IASPhysicalSiteMapControlFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<ASPhysicalSiteMapControlEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        ASPhysicalSiteMapControlEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
