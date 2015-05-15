// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Oct-2013, 01:03:02




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class REQRequisitionBuilder : IEntityBuilder<REQRequisitionEntity>
    {
        IList<REQRequisitionEntity> IEntityBuilder<REQRequisitionEntity>.BuildEntities(IDataReader reader)
        {
            List<REQRequisitionEntity> REQRequisitionEntityList = new List<REQRequisitionEntity>();

            while (reader.Read())
            {
                REQRequisitionEntityList.Add(((IEntityBuilder<REQRequisitionEntity>)this).BuildEntity(reader));
            }

            return (REQRequisitionEntityList.Count > 0) ? REQRequisitionEntityList : null;
        }

        REQRequisitionEntity IEntityBuilder<REQRequisitionEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REQUISITIONID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_REQUISITIONNO = 2;
            const Int32 FLD_REQUISITIONDATE = 3;
            const Int32 FLD_REMARKS = 4;
            const Int32 FLD_REQUISITIONSTATUSID = 5;
            const Int32 FLD_PREPAREDBYMEMBERID = 6;
            const Int32 FLD_ISCASHPAYMENT = 7;
            const Int32 FLD_ISACCOUNTSMADEPAYMENT = 8;
            const Int32 FLD_ISRCS = 9;

            REQRequisitionEntity rEQRequisitionEntity = new REQRequisitionEntity();

            rEQRequisitionEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            rEQRequisitionEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            rEQRequisitionEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO);
            rEQRequisitionEntity.RequisitionDate = reader.GetDateTime(FLD_REQUISITIONDATE);
            if (reader.IsDBNull(FLD_REMARKS)) { rEQRequisitionEntity.Remarks = String.Empty; } else { rEQRequisitionEntity.Remarks = reader.GetString(FLD_REMARKS); }
            rEQRequisitionEntity.RequisitionStatusID = reader.GetInt64(FLD_REQUISITIONSTATUSID);
            rEQRequisitionEntity.PreparedByMemberID = reader.GetInt64(FLD_PREPAREDBYMEMBERID);
            rEQRequisitionEntity.IsCashPayment = reader.GetBoolean(FLD_ISCASHPAYMENT);
            rEQRequisitionEntity.IsAccountsMadePayment = reader.GetBoolean(FLD_ISACCOUNTSMADEPAYMENT);
            rEQRequisitionEntity.IsRCS = reader.GetBoolean(FLD_ISRCS);

            return rEQRequisitionEntity;
        }
    }
}
