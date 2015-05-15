// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-May-2012, 05:15:27




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IOTUpcomingIssue_RPTFacade

    [ServiceContract(Name = "IOTUpcomingIssue_RPTFacade")]
    public partial interface IOTUpcomingIssue_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<OTUpcomingIssue_RPTEntity> GetIL();

        [OperationContract]
        DataTable GetDT();

        #endregion Get

    }
    #endregion
}
