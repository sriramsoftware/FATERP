// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Feb-2013, 10:55:37




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMBOQFloorDetailBuilder : IEntityBuilder<PRMBOQFloorDetailEntity>
    {
        IList<PRMBOQFloorDetailEntity> IEntityBuilder<PRMBOQFloorDetailEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMBOQFloorDetailEntity> PRMBOQFloorDetailEntityList = new List<PRMBOQFloorDetailEntity>();

            while (reader.Read())
            {
                PRMBOQFloorDetailEntityList.Add(((IEntityBuilder<PRMBOQFloorDetailEntity>)this).BuildEntity(reader));
            }

            return (PRMBOQFloorDetailEntityList.Count > 0) ? PRMBOQFloorDetailEntityList : null;
        }

        PRMBOQFloorDetailEntity IEntityBuilder<PRMBOQFloorDetailEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BOQFLOORDETAILID = 0;
            const Int32 FLD_BOQDETAILID = 1;
            const Int32 FLD_PROJECTFLOORID = 2;
            const Int32 FLD_QTY = 3;
            const Int32 FLD_RATE = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_ENTRYDATE = 6;

            PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity = new PRMBOQFloorDetailEntity();

            pRMBOQFloorDetailEntity.BOQFloorDetailID = reader.GetInt64(FLD_BOQFLOORDETAILID);
            pRMBOQFloorDetailEntity.BOQDetailID = reader.GetInt64(FLD_BOQDETAILID);
            pRMBOQFloorDetailEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID);
            if (reader.IsDBNull(FLD_QTY)) { pRMBOQFloorDetailEntity.Qty = null; } else { pRMBOQFloorDetailEntity.Qty = reader.GetDecimal(FLD_QTY); }
            if (reader.IsDBNull(FLD_RATE)) { pRMBOQFloorDetailEntity.Rate = null; } else { pRMBOQFloorDetailEntity.Rate = reader.GetDecimal(FLD_RATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { pRMBOQFloorDetailEntity.Remarks = String.Empty; } else { pRMBOQFloorDetailEntity.Remarks = reader.GetString(FLD_REMARKS); }
            pRMBOQFloorDetailEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);

            return pRMBOQFloorDetailEntity;
        }
    }
}
