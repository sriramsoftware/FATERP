// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Jul-2013, 09:56:00




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{
    #region ICRMSurveyMaster_RPTFacade

    [ServiceContract(Name = "ICRMSurveyMaster_RPTFacade")]
    public partial interface ICRMSurveyMaster_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<CRMSurveyMaster_RPTEntity> GetIL(Int64 surveyMasterID);

        [OperationContract]
        DataTable GetDT(Int64 surveyMasterID);

        #endregion Get

    }
    #endregion
}
