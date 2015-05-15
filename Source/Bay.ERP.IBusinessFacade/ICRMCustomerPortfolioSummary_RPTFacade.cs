// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Jun-2013, 02:33:32




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region ICRMCustomerPortfolioSummary_RPTFacade

    [ServiceContract(Name = "ICRMCustomerPortfolioSummary_RPTFacade")]
    public partial interface ICRMCustomerPortfolioSummary_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<CRMCustomerPortfolioSummary_RPTEntity> GetIL(Int64 buyerBasicInfoID, Int64 projectFloorUnitID);

        [OperationContract]
        DataTable GetDT(Int64 buyerBasicInfoID, Int64 projectFloorUnitID);

        #endregion Get

    }
    #endregion
}
