// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Jul-2012, 02:21:44




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IPRMOriginRegionByBrandItemDistinct_CustomFacade

    [ServiceContract(Name = "IPRMOriginRegionByBrandItemDistinct_CustomFacade")]
    public partial interface IPRMOriginRegionByBrandItemDistinct_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<PRMOriginRegionByBrandItemDistinct_CustomEntity> GetIL(Int64 itemID, Int64 brandID);

        [OperationContract]
        DataTable GetDT(Int64 itemID, Int64 brandID);

        #endregion Get

    }
    #endregion
}
