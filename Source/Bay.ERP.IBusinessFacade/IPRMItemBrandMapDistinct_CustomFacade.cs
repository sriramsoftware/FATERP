// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-May-2012, 03:36:37




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IPRMItemBrandMapDistinct_CustomFacade

    [ServiceContract(Name = "IPRMItemBrandMapDistinct_CustomFacade")]
    public partial interface IPRMItemBrandMapDistinct_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<PRMItemBrandMapDistinct_CustomEntity> GetIL(Int64 supplierID);

        [OperationContract]
        DataTable GetDT(Int64 supplierID);

        #endregion Get

    }
    #endregion
}
