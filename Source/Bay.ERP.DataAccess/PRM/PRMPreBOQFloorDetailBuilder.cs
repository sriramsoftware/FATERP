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
    internal sealed class PRMPreBOQFloorDetailBuilder : IEntityBuilder<PRMPreBOQFloorDetailEntity>
    {
        IList<PRMPreBOQFloorDetailEntity> IEntityBuilder<PRMPreBOQFloorDetailEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMPreBOQFloorDetailEntity> PRMPreBOQFloorDetailEntityList = new List<PRMPreBOQFloorDetailEntity>();

            while (reader.Read())
            {
                PRMPreBOQFloorDetailEntityList.Add(((IEntityBuilder<PRMPreBOQFloorDetailEntity>)this).BuildEntity(reader));
            }

            return (PRMPreBOQFloorDetailEntityList.Count > 0) ? PRMPreBOQFloorDetailEntityList : null;
        }

        PRMPreBOQFloorDetailEntity IEntityBuilder<PRMPreBOQFloorDetailEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PREBOQFLOORDETAILID = 0;
            const Int32 FLD_PREBOQDETAILID = 1;
            const Int32 FLD_PROJECTFLOORID = 2;
            const Int32 FLD_QTY = 3;
            const Int32 FLD_RATE = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_ENTRYDATE = 6;

            PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity = new PRMPreBOQFloorDetailEntity();

            pRMPreBOQFloorDetailEntity.PreBOQFloorDetailID = reader.GetInt64(FLD_PREBOQFLOORDETAILID);
            pRMPreBOQFloorDetailEntity.PreBOQDetailID = reader.GetInt64(FLD_PREBOQDETAILID);
            pRMPreBOQFloorDetailEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID);
            if (reader.IsDBNull(FLD_QTY)) { pRMPreBOQFloorDetailEntity.Qty = null; } else { pRMPreBOQFloorDetailEntity.Qty = reader.GetDecimal(FLD_QTY); }
            if (reader.IsDBNull(FLD_RATE)) { pRMPreBOQFloorDetailEntity.Rate = null; } else { pRMPreBOQFloorDetailEntity.Rate = reader.GetDecimal(FLD_RATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { pRMPreBOQFloorDetailEntity.Remarks = String.Empty; } else { pRMPreBOQFloorDetailEntity.Remarks = reader.GetString(FLD_REMARKS); }
            pRMPreBOQFloorDetailEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);

            return pRMPreBOQFloorDetailEntity;
        }
    }
}
