// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Oct-2012, 01:09:23




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IPRMBOQRequisitionItem_CustomFacade

    [ServiceContract(Name = "IPRMBOQRequisitionItem_CustomFacade")]
    public partial interface IPRMBOQRequisitionItem_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<PRMBOQRequisitionItem_CustomEntity> GetIL(Int64 projectID, Int64 itemCategoryID);

        [OperationContract]
        DataTable GetDT(Int64 projectID, Int64 itemCategoryID);

        #endregion Get

    }
    #endregion
}
