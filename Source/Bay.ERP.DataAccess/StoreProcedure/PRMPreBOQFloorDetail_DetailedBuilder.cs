// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Aug-2013, 05:14:41




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMPreBOQFloorDetail_DetailedBuilder : IEntityBuilder<PRMPreBOQFloorDetail_DetailedEntity>
    {
        IList<PRMPreBOQFloorDetail_DetailedEntity> IEntityBuilder<PRMPreBOQFloorDetail_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMPreBOQFloorDetail_DetailedEntity> PRMPreBOQFloorDetail_DetailedEntityList = new List<PRMPreBOQFloorDetail_DetailedEntity>();

            while (reader.Read())
            {
                PRMPreBOQFloorDetail_DetailedEntityList.Add(((IEntityBuilder<PRMPreBOQFloorDetail_DetailedEntity>)this).BuildEntity(reader));
            }

            return (PRMPreBOQFloorDetail_DetailedEntityList.Count > 0) ? PRMPreBOQFloorDetail_DetailedEntityList : null;
        }

        PRMPreBOQFloorDetail_DetailedEntity IEntityBuilder<PRMPreBOQFloorDetail_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PREBOQFLOORDETAILID = 0;
            const Int32 FLD_PREBOQDETAILID = 1;
            const Int32 FLD_PROJECTFLOORID = 2;
            const Int32 FLD_QTY = 3;
            const Int32 FLD_RATE = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_ENTRYDATE = 6;
            const Int32 FLD_PRMPREBOQDETAILPREBOQID = 7;
            const Int32 FLD_BDPROJECTFLOORNAME = 8;
            const Int32 FLD_ROWNUMBER = 9;

            PRMPreBOQFloorDetail_DetailedEntity pRMPreBOQFloorDetail_DetailedEntity = new PRMPreBOQFloorDetail_DetailedEntity();

            pRMPreBOQFloorDetail_DetailedEntity.PreBOQFloorDetailID = reader.GetInt64(FLD_PREBOQFLOORDETAILID);
            pRMPreBOQFloorDetail_DetailedEntity.PreBOQDetailID = reader.GetInt64(FLD_PREBOQDETAILID);
            pRMPreBOQFloorDetail_DetailedEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID);
            if (reader.IsDBNull(FLD_QTY)) { pRMPreBOQFloorDetail_DetailedEntity.Qty = null; } else { pRMPreBOQFloorDetail_DetailedEntity.Qty = reader.GetDecimal(FLD_QTY); }
            if (reader.IsDBNull(FLD_RATE)) { pRMPreBOQFloorDetail_DetailedEntity.Rate = null; } else { pRMPreBOQFloorDetail_DetailedEntity.Rate = reader.GetDecimal(FLD_RATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { pRMPreBOQFloorDetail_DetailedEntity.Remarks = String.Empty; } else { pRMPreBOQFloorDetail_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            pRMPreBOQFloorDetail_DetailedEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);
            if (reader.IsDBNull(FLD_PRMPREBOQDETAILPREBOQID)) { pRMPreBOQFloorDetail_DetailedEntity.PRMPreBOQDetailPreBOQID = null; } else { pRMPreBOQFloorDetail_DetailedEntity.PRMPreBOQDetailPreBOQID = reader.GetInt64(FLD_PRMPREBOQDETAILPREBOQID); }
            if (reader.IsDBNull(FLD_BDPROJECTFLOORNAME)) { pRMPreBOQFloorDetail_DetailedEntity.BDProjectFloorName = String.Empty; } else { pRMPreBOQFloorDetail_DetailedEntity.BDProjectFloorName = reader.GetString(FLD_BDPROJECTFLOORNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { pRMPreBOQFloorDetail_DetailedEntity.RowNumber = null; } else { pRMPreBOQFloorDetail_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return pRMPreBOQFloorDetail_DetailedEntity;
        }
    }
}
