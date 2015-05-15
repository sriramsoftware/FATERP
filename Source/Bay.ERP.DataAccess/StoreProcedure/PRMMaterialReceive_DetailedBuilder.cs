// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Aug-2013, 05:29:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMMaterialReceive_DetailedBuilder : IEntityBuilder<PRMMaterialReceive_DetailedEntity>
    {
        IList<PRMMaterialReceive_DetailedEntity> IEntityBuilder<PRMMaterialReceive_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMMaterialReceive_DetailedEntity> PRMMaterialReceive_DetailedEntityList = new List<PRMMaterialReceive_DetailedEntity>();

            while (reader.Read())
            {
                PRMMaterialReceive_DetailedEntityList.Add(((IEntityBuilder<PRMMaterialReceive_DetailedEntity>)this).BuildEntity(reader));
            }

            return (PRMMaterialReceive_DetailedEntityList.Count > 0) ? PRMMaterialReceive_DetailedEntityList : null;
        }

        PRMMaterialReceive_DetailedEntity IEntityBuilder<PRMMaterialReceive_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MATERIALRECEIVEID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_SUPPLIERID = 2;
            const Int32 FLD_REQUISITIONID = 3;
            const Int32 FLD_WORKORDERID = 4;
            const Int32 FLD_MRRNO = 5;
            const Int32 FLD_MRRDATE = 6;
            const Int32 FLD_REMARKS = 7;
            const Int32 FLD_MATERIALRECEIVEAPPROVALSTATUSID = 8;
            const Int32 FLD_BDPROJECTPROJECTNAME = 9;
            const Int32 FLD_PRMSUPPLIERSUPPLIERNAME = 10;
            const Int32 FLD_MATERIALRECEIVEAPPROVALSTATUSNAME = 11;
            const Int32 FLD_REQUISITIONNO = 12;
            const Int32 FLD_WORKORDERNO = 13;
            const Int32 FLD_ROWNUMBER = 14;

            PRMMaterialReceive_DetailedEntity pRMMaterialReceive_DetailedEntity = new PRMMaterialReceive_DetailedEntity();

            pRMMaterialReceive_DetailedEntity.MaterialReceiveID = reader.GetInt64(FLD_MATERIALRECEIVEID);
            pRMMaterialReceive_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            pRMMaterialReceive_DetailedEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMMaterialReceive_DetailedEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            pRMMaterialReceive_DetailedEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            pRMMaterialReceive_DetailedEntity.MRRNo = reader.GetString(FLD_MRRNO);
            pRMMaterialReceive_DetailedEntity.MRRDate = reader.GetDateTime(FLD_MRRDATE);
            if (reader.IsDBNull(FLD_REMARKS)) { pRMMaterialReceive_DetailedEntity.Remarks = String.Empty; } else { pRMMaterialReceive_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            pRMMaterialReceive_DetailedEntity.MaterialReceiveApprovalStatusID = reader.GetInt64(FLD_MATERIALRECEIVEAPPROVALSTATUSID);
            if (reader.IsDBNull(FLD_BDPROJECTPROJECTNAME)) { pRMMaterialReceive_DetailedEntity.BDProjectProjectName = String.Empty; } else { pRMMaterialReceive_DetailedEntity.BDProjectProjectName = reader.GetString(FLD_BDPROJECTPROJECTNAME); }
            if (reader.IsDBNull(FLD_PRMSUPPLIERSUPPLIERNAME)) { pRMMaterialReceive_DetailedEntity.PRMSupplierSupplierName = String.Empty; } else { pRMMaterialReceive_DetailedEntity.PRMSupplierSupplierName = reader.GetString(FLD_PRMSUPPLIERSUPPLIERNAME); }
            if (reader.IsDBNull(FLD_MATERIALRECEIVEAPPROVALSTATUSNAME)) { pRMMaterialReceive_DetailedEntity.MaterialReceiveApprovalStatusName = String.Empty; } else { pRMMaterialReceive_DetailedEntity.MaterialReceiveApprovalStatusName = reader.GetString(FLD_MATERIALRECEIVEAPPROVALSTATUSNAME); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { pRMMaterialReceive_DetailedEntity.RequisitionNo = String.Empty; } else { pRMMaterialReceive_DetailedEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { pRMMaterialReceive_DetailedEntity.WorkOrderNo = String.Empty; } else { pRMMaterialReceive_DetailedEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { pRMMaterialReceive_DetailedEntity.RowNumber = null; } else { pRMMaterialReceive_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return pRMMaterialReceive_DetailedEntity;
        }
    }
}
