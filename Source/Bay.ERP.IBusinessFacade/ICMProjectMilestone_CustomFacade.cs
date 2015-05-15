// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Jan-2012, 02:37:47




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region ICMProjectMilestone_CustomFacade

    [ServiceContract(Name = "ICMProjectMilestone_CustomFacade")]
    public partial interface ICMProjectMilestone_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<CMProjectMilestone_CustomEntity> GetIL(Int64 projectID);

        [OperationContract]
        DataTable GetDT(Int64 projectID);

        #endregion Get

    }
    #endregion
}
