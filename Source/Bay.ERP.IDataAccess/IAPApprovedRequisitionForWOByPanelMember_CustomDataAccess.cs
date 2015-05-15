// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Jan-2013, 11:24:12




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IAPApprovedRequisitionForWOByPanelMember_CustomDataAccess

    public partial interface IAPApprovedRequisitionForWOByPanelMember_CustomDataAccess
    {
        #region Get

        IList<APApprovedRequisitionForWOByPanelMember_CustomEntity> GetIL(Int64 employeeID);

        DataTable GetDT(Int64 employeeID);

        #endregion Get

    }
    #endregion
}
