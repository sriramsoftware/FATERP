// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Feb-2013, 06:05:18




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IPRMMaterialRequisitionItem_CustomFacade

    [ServiceContract(Name = "IPRMMaterialRequisitionItem_CustomFacade")]
    public partial interface IPRMMaterialRequisitionItem_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<PRMMaterialRequisitionItem_CustomEntity> GetIL(String filterExpression);

        [OperationContract]
        DataTable GetDT(String filterExpression);

        #endregion Get

    }
    #endregion
}
