// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Nov-2013, 10:23:55




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class REQRequisitionItemFloorDetailBuilder : IEntityBuilder<REQRequisitionItemFloorDetailEntity>
    {
        IList<REQRequisitionItemFloorDetailEntity> IEntityBuilder<REQRequisitionItemFloorDetailEntity>.BuildEntities(IDataReader reader)
        {
            List<REQRequisitionItemFloorDetailEntity> REQRequisitionItemFloorDetailEntityList = new List<REQRequisitionItemFloorDetailEntity>();

            while (reader.Read())
            {
                REQRequisitionItemFloorDetailEntityList.Add(((IEntityBuilder<REQRequisitionItemFloorDetailEntity>)this).BuildEntity(reader));
            }

            return (REQRequisitionItemFloorDetailEntityList.Count > 0) ? REQRequisitionItemFloorDetailEntityList : null;
        }

        REQRequisitionItemFloorDetailEntity IEntityBuilder<REQRequisitionItemFloorDetailEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REQUISITIONITEMFLOORDETAILID = 0;
            const Int32 FLD_REQUISITIONID = 1;
            const Int32 FLD_REQUISITIONITEMID = 2;
            const Int32 FLD_PROJECTFLOORID = 3;
            const Int32 FLD_PROJECTFLOORUNITID = 4;
            const Int32 FLD_PROJECTUNITLOCATIONID = 5;
            const Int32 FLD_QTY = 6;
            const Int32 FLD_RATE = 7;
            const Int32 FLD_REMARKS = 8;
            const Int32 FLD_ENTRYDATE = 9;

            REQRequisitionItemFloorDetailEntity rEQRequisitionItemFloorDetailEntity = new REQRequisitionItemFloorDetailEntity();

            rEQRequisitionItemFloorDetailEntity.RequisitionItemFloorDetailID = reader.GetInt64(FLD_REQUISITIONITEMFLOORDETAILID);
            rEQRequisitionItemFloorDetailEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            rEQRequisitionItemFloorDetailEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID);
            rEQRequisitionItemFloorDetailEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID);
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { rEQRequisitionItemFloorDetailEntity.ProjectFloorUnitID = null; } else { rEQRequisitionItemFloorDetailEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_PROJECTUNITLOCATIONID)) { rEQRequisitionItemFloorDetailEntity.ProjectUnitLocationID = null; } else { rEQRequisitionItemFloorDetailEntity.ProjectUnitLocationID = reader.GetInt64(FLD_PROJECTUNITLOCATIONID); }
            if (reader.IsDBNull(FLD_QTY)) { rEQRequisitionItemFloorDetailEntity.Qty = null; } else { rEQRequisitionItemFloorDetailEntity.Qty = reader.GetDecimal(FLD_QTY); }
            if (reader.IsDBNull(FLD_RATE)) { rEQRequisitionItemFloorDetailEntity.Rate = null; } else { rEQRequisitionItemFloorDetailEntity.Rate = reader.GetDecimal(FLD_RATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { rEQRequisitionItemFloorDetailEntity.Remarks = String.Empty; } else { rEQRequisitionItemFloorDetailEntity.Remarks = reader.GetString(FLD_REMARKS); }
            rEQRequisitionItemFloorDetailEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);

            return rEQRequisitionItemFloorDetailEntity;
        }
    }
}
