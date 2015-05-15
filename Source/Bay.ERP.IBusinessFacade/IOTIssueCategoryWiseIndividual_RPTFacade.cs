// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Aug-2013, 03:52:52




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IOTIssueCategoryWiseIndividual_RPTFacade

    [ServiceContract(Name = "IOTIssueCategoryWiseIndividual_RPTFacade")]
    public partial interface IOTIssueCategoryWiseIndividual_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<OTIssueCategoryWiseIndividual_RPTEntity> GetIL(DateTime fromDate, DateTime toDate, Int64 assingedEmployeeID);

        [OperationContract]
        DataTable GetDT(DateTime fromDate, DateTime toDate, Int64 assingedEmployeeID);

        #endregion Get

    }
    #endregion
}
