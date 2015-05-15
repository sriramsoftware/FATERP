// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Sep-2012, 02:08:47




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IDMSFileTrackingDepartmentDistinct_CustomFacade

    [ServiceContract(Name = "IDMSFileTrackingDepartmentDistinct_CustomFacade")]
    public partial interface IDMSFileTrackingDepartmentDistinct_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<DMSFileTrackingDepartmentDistinct_CustomEntity> GetIL();

        [OperationContract]
        DataTable GetDT();

        #endregion Get

    }
    #endregion
}
