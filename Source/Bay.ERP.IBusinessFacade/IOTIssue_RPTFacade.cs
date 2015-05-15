// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Jun-2012, 12:03:16




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IOTIssue_RPTFacade

    [ServiceContract(Name = "IOTIssue_RPTFacade")]
    public partial interface IOTIssue_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<OTIssue_RPTEntity> GetIL(Int64 issueID);

        [OperationContract]
        DataTable GetDT(Int64 issueID);

        #endregion Get

    }
    #endregion
}
