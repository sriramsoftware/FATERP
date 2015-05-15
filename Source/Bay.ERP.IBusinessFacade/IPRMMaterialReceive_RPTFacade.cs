// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jul-2012, 11:22:51




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IPRMMaterialReceive_RPTFacade

    [ServiceContract(Name = "IPRMMaterialReceive_RPTFacade")]
    public partial interface IPRMMaterialReceive_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<PRMMaterialReceive_RPTEntity> GetIL(Int64 materialReceiveID);

        [OperationContract]
        DataTable GetDT(Int64 materialReceiveID);

        #endregion Get

    }
    #endregion
}
