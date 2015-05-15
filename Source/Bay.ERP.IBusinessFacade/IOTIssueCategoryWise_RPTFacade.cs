// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Aug-2013, 10:45:50




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IOTIssueCategoryWise_RPTFacade

    [ServiceContract(Name = "IOTIssueCategoryWise_RPTFacade")]
    public partial interface IOTIssueCategoryWise_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<OTIssueCategoryWise_RPTEntity> GetIL(DateTime fromDate, DateTime toDate);

        [OperationContract]
        DataTable GetDT(DateTime fromDate, DateTime toDate);

        #endregion Get

    }
    #endregion
}
