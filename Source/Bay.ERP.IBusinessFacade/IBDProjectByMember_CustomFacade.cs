// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jul-2012, 02:14:35




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IBDProjectByMember_CustomFacade

    [ServiceContract(Name = "IBDProjectByMember_CustomFacade")]
    public partial interface IBDProjectByMember_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<BDProjectByMember_CustomEntity> GetIL(Int64 memberID);

        [OperationContract]
        DataTable GetDT(Int64 memberID);

        #endregion Get

    }
    #endregion
}
