// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:24:04




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IASMemberAspnetUsersMapFacade

    [ServiceContract(Name = "ICommonDA_SPFacade")]
    public partial interface ICommonDA_SPFacade : IDisposable
    {        
        #region Get

        [OperationContract]
        DataTable GetDT(String xVar, Int32 action);

        #endregion Get

    }
    #endregion
}
