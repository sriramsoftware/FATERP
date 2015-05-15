// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Jun-2013, 12:21:21




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class REQRequisition_DetailedBuilder : IEntityBuilder<REQRequisition_DetailedEntity>
    {
        IList<REQRequisition_DetailedEntity> IEntityBuilder<REQRequisition_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<REQRequisition_DetailedEntity> REQRequisition_DetailedEntityList = new List<REQRequisition_DetailedEntity>();

            while (reader.Read())
            {
                REQRequisition_DetailedEntityList.Add(((IEntityBuilder<REQRequisition_DetailedEntity>)this).BuildEntity(reader));
            }

            return (REQRequisition_DetailedEntityList.Count > 0) ? REQRequisition_DetailedEntityList : null;
        }

        REQRequisition_DetailedEntity IEntityBuilder<REQRequisition_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REQUISITIONID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_REQUISITIONNO = 2;
            const Int32 FLD_REQUISITIONDATE = 3;
            const Int32 FLD_REMARKS = 4;
            const Int32 FLD_REQUISITIONSTATUSID = 5;
            const Int32 FLD_ISCASHPAYMENT = 6;
            const Int32 FLD_ISACCOUNTSMADEPAYMENT = 7;
            const Int32 FLD_PROJECTNAME = 8;
            const Int32 FLD_PROJECTCODE = 9;
            const Int32 FLD_REQUISITIONSTATUSNAME = 10;
            const Int32 FLD_ROWNUMBER = 11;

            REQRequisition_DetailedEntity rEQRequisition_DetailedEntity = new REQRequisition_DetailedEntity();

            rEQRequisition_DetailedEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            rEQRequisition_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            rEQRequisition_DetailedEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO);
            rEQRequisition_DetailedEntity.RequisitionDate = reader.GetDateTime(FLD_REQUISITIONDATE);
            if (reader.IsDBNull(FLD_REMARKS)) { rEQRequisition_DetailedEntity.Remarks = String.Empty; } else { rEQRequisition_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            rEQRequisition_DetailedEntity.RequisitionStatusID = reader.GetInt64(FLD_REQUISITIONSTATUSID);
            rEQRequisition_DetailedEntity.IsCashPayment = reader.GetBoolean(FLD_ISCASHPAYMENT);
            rEQRequisition_DetailedEntity.IsAccountsMadePayment = reader.GetBoolean(FLD_ISACCOUNTSMADEPAYMENT);
            if (reader.IsDBNull(FLD_PROJECTNAME)) { rEQRequisition_DetailedEntity.ProjectName = String.Empty; } else { rEQRequisition_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { rEQRequisition_DetailedEntity.ProjectCode = String.Empty; } else { rEQRequisition_DetailedEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_REQUISITIONSTATUSNAME)) { rEQRequisition_DetailedEntity.RequisitionStatusName = String.Empty; } else { rEQRequisition_DetailedEntity.RequisitionStatusName = reader.GetString(FLD_REQUISITIONSTATUSNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { rEQRequisition_DetailedEntity.RowNumber = null; } else { rEQRequisition_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return rEQRequisition_DetailedEntity;
        }
    }
}
