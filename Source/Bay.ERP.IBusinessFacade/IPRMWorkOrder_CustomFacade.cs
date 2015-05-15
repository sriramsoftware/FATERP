// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Sep-2012, 03:05:38




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IPRMWorkOrder_CustomFacade

    [ServiceContract(Name = "IPRMWorkOrder_CustomFacade")]
    public partial interface IPRMWorkOrder_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<PRMWorkOrder_CustomEntity> GetIL(String filterExpression);

        [OperationContract]
        DataTable GetDT(String filterExpression);

        #endregion Get

    }
    #endregion
}
