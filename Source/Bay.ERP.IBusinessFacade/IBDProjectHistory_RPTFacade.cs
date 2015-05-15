// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jan-2012, 09:58:11




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IBDProjectHistory_RPTFacade

    [ServiceContract(Name = "IBDProjectHistory_RPTFacade")]
    public partial interface IBDProjectHistory_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<BDProjectHistory_RPTEntity> GetIL(Int64 projectID);

        [OperationContract]
        DataTable GetDT(Int64 projectID);

        #endregion Get

    }
    #endregion
}
