// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Aug-2013, 02:50:29




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMMaterialReceiveBuilder : IEntityBuilder<PRMMaterialReceiveEntity>
    {
        IList<PRMMaterialReceiveEntity> IEntityBuilder<PRMMaterialReceiveEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMMaterialReceiveEntity> PRMMaterialReceiveEntityList = new List<PRMMaterialReceiveEntity>();

            while (reader.Read())
            {
                PRMMaterialReceiveEntityList.Add(((IEntityBuilder<PRMMaterialReceiveEntity>)this).BuildEntity(reader));
            }

            return (PRMMaterialReceiveEntityList.Count > 0) ? PRMMaterialReceiveEntityList : null;
        }

        PRMMaterialReceiveEntity IEntityBuilder<PRMMaterialReceiveEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MATERIALRECEIVEID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_SUPPLIERID = 2;
            const Int32 FLD_REQUISITIONID = 3;
            const Int32 FLD_WORKORDERID = 4;
            const Int32 FLD_MRRNO = 5;
            const Int32 FLD_MRRDATE = 6;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 7;
            const Int32 FLD_REMARKS = 8;
            const Int32 FLD_MATERIALRECEIVEAPPROVALSTATUSID = 9;

            PRMMaterialReceiveEntity pRMMaterialReceiveEntity = new PRMMaterialReceiveEntity();

            pRMMaterialReceiveEntity.MaterialReceiveID = reader.GetInt64(FLD_MATERIALRECEIVEID);
            pRMMaterialReceiveEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            pRMMaterialReceiveEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMMaterialReceiveEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            pRMMaterialReceiveEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            pRMMaterialReceiveEntity.MRRNo = reader.GetString(FLD_MRRNO);
            pRMMaterialReceiveEntity.MRRDate = reader.GetDateTime(FLD_MRRDATE);
            if (reader.IsDBNull(FLD_CREATEDBYEMPLOYEEID)) { pRMMaterialReceiveEntity.CreatedByEmployeeID = null; } else { pRMMaterialReceiveEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID); }
            if (reader.IsDBNull(FLD_REMARKS)) { pRMMaterialReceiveEntity.Remarks = String.Empty; } else { pRMMaterialReceiveEntity.Remarks = reader.GetString(FLD_REMARKS); }
            pRMMaterialReceiveEntity.MaterialReceiveApprovalStatusID = reader.GetInt64(FLD_MATERIALRECEIVEAPPROVALSTATUSID);

            return pRMMaterialReceiveEntity;
        }
    }
}
