// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Aug-2013, 03:30:14




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class REQRequisitionItemFloorDetail_RPTBuilder : IEntityBuilder<REQRequisitionItemFloorDetail_RPTEntity>
    {
        IList<REQRequisitionItemFloorDetail_RPTEntity> IEntityBuilder<REQRequisitionItemFloorDetail_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<REQRequisitionItemFloorDetail_RPTEntity> REQRequisitionItemFloorDetail_RPTEntityList = new List<REQRequisitionItemFloorDetail_RPTEntity>();

            while (reader.Read())
            {
                REQRequisitionItemFloorDetail_RPTEntityList.Add(((IEntityBuilder<REQRequisitionItemFloorDetail_RPTEntity>)this).BuildEntity(reader));
            }

            return (REQRequisitionItemFloorDetail_RPTEntityList.Count > 0) ? REQRequisitionItemFloorDetail_RPTEntityList : null;
        }

        REQRequisitionItemFloorDetail_RPTEntity IEntityBuilder<REQRequisitionItemFloorDetail_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REQUISITIONITEMFLOORDETAILID = 0;
            const Int32 FLD_REQUISITIONITEMID = 1;
            const Int32 FLD_REQUISITIONID = 2;
            const Int32 FLD_PROJECTFLOORID = 3;
            const Int32 FLD_PROJECTFLOORUNITID = 4;
            const Int32 FLD_QTY = 5;
            const Int32 FLD_RATE = 6;
            const Int32 FLD_REMARKS = 7;
            const Int32 FLD_ENTRYDATE = 8;
            const Int32 FLD_REQUISITIONNO = 9;
            const Int32 FLD_PROJECTCODE = 10;
            const Int32 FLD_PROJECTNAME = 11;
            const Int32 FLD_BDPROJECTFLOORNAME = 12;
            const Int32 FLD_ITEMNAME = 13;
            const Int32 FLD_ITEMID = 14;

            REQRequisitionItemFloorDetail_RPTEntity rEQRequisitionItemFloorDetail_RPTEntity = new REQRequisitionItemFloorDetail_RPTEntity();

            rEQRequisitionItemFloorDetail_RPTEntity.RequisitionItemFloorDetailID = reader.GetInt64(FLD_REQUISITIONITEMFLOORDETAILID);
            rEQRequisitionItemFloorDetail_RPTEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID);
            rEQRequisitionItemFloorDetail_RPTEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            rEQRequisitionItemFloorDetail_RPTEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID);
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { rEQRequisitionItemFloorDetail_RPTEntity.ProjectFloorUnitID = null; } else { rEQRequisitionItemFloorDetail_RPTEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_QTY)) { rEQRequisitionItemFloorDetail_RPTEntity.Qty = null; } else { rEQRequisitionItemFloorDetail_RPTEntity.Qty = reader.GetDecimal(FLD_QTY); }
            if (reader.IsDBNull(FLD_RATE)) { rEQRequisitionItemFloorDetail_RPTEntity.Rate = null; } else { rEQRequisitionItemFloorDetail_RPTEntity.Rate = reader.GetDecimal(FLD_RATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { rEQRequisitionItemFloorDetail_RPTEntity.Remarks = String.Empty; } else { rEQRequisitionItemFloorDetail_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            rEQRequisitionItemFloorDetail_RPTEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { rEQRequisitionItemFloorDetail_RPTEntity.RequisitionNo = String.Empty; } else { rEQRequisitionItemFloorDetail_RPTEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { rEQRequisitionItemFloorDetail_RPTEntity.ProjectCode = String.Empty; } else { rEQRequisitionItemFloorDetail_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { rEQRequisitionItemFloorDetail_RPTEntity.ProjectName = String.Empty; } else { rEQRequisitionItemFloorDetail_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_BDPROJECTFLOORNAME)) { rEQRequisitionItemFloorDetail_RPTEntity.BDProjectFloorName = String.Empty; } else { rEQRequisitionItemFloorDetail_RPTEntity.BDProjectFloorName = reader.GetString(FLD_BDPROJECTFLOORNAME); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { rEQRequisitionItemFloorDetail_RPTEntity.ItemName = String.Empty; } else { rEQRequisitionItemFloorDetail_RPTEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_ITEMID)) { rEQRequisitionItemFloorDetail_RPTEntity.ItemID = null; } else { rEQRequisitionItemFloorDetail_RPTEntity.ItemID = reader.GetInt64(FLD_ITEMID); }

            return rEQRequisitionItemFloorDetail_RPTEntity;
        }
    }
}
