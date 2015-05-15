// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Aug-2013, 01:37:35




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class REQRequisitionItemFloorDetail_DetailedBuilder : IEntityBuilder<REQRequisitionItemFloorDetail_DetailedEntity>
    {
        IList<REQRequisitionItemFloorDetail_DetailedEntity> IEntityBuilder<REQRequisitionItemFloorDetail_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<REQRequisitionItemFloorDetail_DetailedEntity> REQRequisitionItemFloorDetail_DetailedEntityList = new List<REQRequisitionItemFloorDetail_DetailedEntity>();

            while (reader.Read())
            {
                REQRequisitionItemFloorDetail_DetailedEntityList.Add(((IEntityBuilder<REQRequisitionItemFloorDetail_DetailedEntity>)this).BuildEntity(reader));
            }

            return (REQRequisitionItemFloorDetail_DetailedEntityList.Count > 0) ? REQRequisitionItemFloorDetail_DetailedEntityList : null;
        }

        REQRequisitionItemFloorDetail_DetailedEntity IEntityBuilder<REQRequisitionItemFloorDetail_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_BDPROJECTFLOORNAME = 10;
            const Int32 FLD_ROWNUMBER = 11;

            REQRequisitionItemFloorDetail_DetailedEntity rEQRequisitionItemFloorDetail_DetailedEntity = new REQRequisitionItemFloorDetail_DetailedEntity();

            rEQRequisitionItemFloorDetail_DetailedEntity.RequisitionItemFloorDetailID = reader.GetInt64(FLD_REQUISITIONITEMFLOORDETAILID);
            rEQRequisitionItemFloorDetail_DetailedEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID);
            rEQRequisitionItemFloorDetail_DetailedEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            rEQRequisitionItemFloorDetail_DetailedEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID);
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { rEQRequisitionItemFloorDetail_DetailedEntity.ProjectFloorUnitID = null; } else { rEQRequisitionItemFloorDetail_DetailedEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_QTY)) { rEQRequisitionItemFloorDetail_DetailedEntity.Qty = null; } else { rEQRequisitionItemFloorDetail_DetailedEntity.Qty = reader.GetDecimal(FLD_QTY); }
            if (reader.IsDBNull(FLD_RATE)) { rEQRequisitionItemFloorDetail_DetailedEntity.Rate = null; } else { rEQRequisitionItemFloorDetail_DetailedEntity.Rate = reader.GetDecimal(FLD_RATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { rEQRequisitionItemFloorDetail_DetailedEntity.Remarks = String.Empty; } else { rEQRequisitionItemFloorDetail_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            rEQRequisitionItemFloorDetail_DetailedEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { rEQRequisitionItemFloorDetail_DetailedEntity.RequisitionNo = String.Empty; } else { rEQRequisitionItemFloorDetail_DetailedEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_BDPROJECTFLOORNAME)) { rEQRequisitionItemFloorDetail_DetailedEntity.BDProjectFloorName = String.Empty; } else { rEQRequisitionItemFloorDetail_DetailedEntity.BDProjectFloorName = reader.GetString(FLD_BDPROJECTFLOORNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { rEQRequisitionItemFloorDetail_DetailedEntity.RowNumber = null; } else { rEQRequisitionItemFloorDetail_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return rEQRequisitionItemFloorDetail_DetailedEntity;
        }
    }
}
