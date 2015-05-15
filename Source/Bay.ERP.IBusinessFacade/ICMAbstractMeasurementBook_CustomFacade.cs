// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2012, 03:02:08




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region ICMAbstractMeasurementBook_CustomFacade

    [ServiceContract(Name = "ICMAbstractMeasurementBook_CustomFacade")]
    public partial interface ICMAbstractMeasurementBook_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<CMAbstractMeasurementBook_CustomEntity> GetIL(Int64 projectID);

        [OperationContract]
        DataTable GetDT(Int64 projectID);

        #endregion Get

    }
    #endregion
}
