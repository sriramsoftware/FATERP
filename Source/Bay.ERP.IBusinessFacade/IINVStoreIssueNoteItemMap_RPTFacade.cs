// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Dec-2013, 10:00:46




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IINVStoreIssueNoteItemMap_RPTFacade

    [ServiceContract(Name = "IINVStoreIssueNoteItemMap_RPTFacade")]
    public partial interface IINVStoreIssueNoteItemMap_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<INVStoreIssueNoteItemMap_RPTEntity> GetIL(Int32 pageSize, Int32 currentPage, String sortExpression, String filterExpression);

        [OperationContract]
        DataTable GetDT(Int32 pageSize, Int32 currentPage, String sortExpression, String filterExpression);

        #endregion Get

    }
    #endregion
}
