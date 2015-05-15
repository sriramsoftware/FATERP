// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jun-2012, 11:27:18




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IOTResourceIssueSchedule_CustomFacade

    [ServiceContract(Name = "IOTResourceIssueSchedule_CustomFacade")]
    public partial interface IOTResourceIssueSchedule_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<OTResourceIssueSchedule_CustomEntity> GetIL(Int64 resourceID, Int64 resourceCategoryID);

        [OperationContract]
        DataTable GetDT(Int64 resourceID, Int64 resourceCategoryID);

        #endregion Get

    }
    #endregion
}
