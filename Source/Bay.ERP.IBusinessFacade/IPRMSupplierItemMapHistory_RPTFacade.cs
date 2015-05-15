// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Apr-2012, 10:30:24




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IPRMSupplierItemMapHistory_RPTFacade

    [ServiceContract(Name = "IPRMSupplierItemMapHistory_RPTFacade")]
    public partial interface IPRMSupplierItemMapHistory_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<PRMSupplierItemMapHistory_RPTEntity> GetIL(Int64 itemID);

        [OperationContract]
        DataTable GetDT(Int64 itemID);

        #endregion Get

    }
    #endregion
}
