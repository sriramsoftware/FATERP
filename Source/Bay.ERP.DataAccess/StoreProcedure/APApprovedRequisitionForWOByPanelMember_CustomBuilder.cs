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
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class APApprovedRequisitionForWOByPanelMember_CustomBuilder : IEntityBuilder<APApprovedRequisitionForWOByPanelMember_CustomEntity>
    {
        IList<APApprovedRequisitionForWOByPanelMember_CustomEntity> IEntityBuilder<APApprovedRequisitionForWOByPanelMember_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<APApprovedRequisitionForWOByPanelMember_CustomEntity> APApprovedRequisitionForWOByPanelMember_CustomEntityList = new List<APApprovedRequisitionForWOByPanelMember_CustomEntity>();

            while (reader.Read())
            {
                APApprovedRequisitionForWOByPanelMember_CustomEntityList.Add(((IEntityBuilder<APApprovedRequisitionForWOByPanelMember_CustomEntity>)this).BuildEntity(reader));
            }

            return (APApprovedRequisitionForWOByPanelMember_CustomEntityList.Count > 0) ? APApprovedRequisitionForWOByPanelMember_CustomEntityList : null;
        }

        APApprovedRequisitionForWOByPanelMember_CustomEntity IEntityBuilder<APApprovedRequisitionForWOByPanelMember_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REFERENCEID = 0;
            const Int32 FLD_EMPLOYEEID = 1;

            APApprovedRequisitionForWOByPanelMember_CustomEntity aPApprovedRequisitionForWOByPanelMember_CustomEntity = new APApprovedRequisitionForWOByPanelMember_CustomEntity();

            if (reader.IsDBNull(FLD_REFERENCEID)) { aPApprovedRequisitionForWOByPanelMember_CustomEntity.ReferenceID = null; } else { aPApprovedRequisitionForWOByPanelMember_CustomEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            if (reader.IsDBNull(FLD_EMPLOYEEID)) { aPApprovedRequisitionForWOByPanelMember_CustomEntity.EmployeeID = null; } else { aPApprovedRequisitionForWOByPanelMember_CustomEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID); }

            return aPApprovedRequisitionForWOByPanelMember_CustomEntity;
        }
    }
}
