// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jan-2012, 12:40:04




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IMDItem_RPTFacade

    [ServiceContract(Name = "IMDItem_RPTFacade")]
    public partial interface IMDItem_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<MDItem_RPTEntity> GetIL(Int64 parentCategoryID, Int64 subCategoryID);

        [OperationContract]
        DataTable GetDT(Int64 parentCategoryID, Int64 subCategoryID);

        #endregion Get

    }
    #endregion
}
