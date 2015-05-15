// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Feb-2013, 11:30:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMBOQFloorDetail_DetailedBuilder : IEntityBuilder<PRMBOQFloorDetail_DetailedEntity>
    {
        IList<PRMBOQFloorDetail_DetailedEntity> IEntityBuilder<PRMBOQFloorDetail_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMBOQFloorDetail_DetailedEntity> PRMBOQFloorDetail_DetailedEntityList = new List<PRMBOQFloorDetail_DetailedEntity>();

            while (reader.Read())
            {
                PRMBOQFloorDetail_DetailedEntityList.Add(((IEntityBuilder<PRMBOQFloorDetail_DetailedEntity>)this).BuildEntity(reader));
            }

            return (PRMBOQFloorDetail_DetailedEntityList.Count > 0) ? PRMBOQFloorDetail_DetailedEntityList : null;
        }

        PRMBOQFloorDetail_DetailedEntity IEntityBuilder<PRMBOQFloorDetail_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BOQFLOORDETAILID = 0;
            const Int32 FLD_BOQDETAILID = 1;
            const Int32 FLD_PROJECTFLOORID = 2;
            const Int32 FLD_QTY = 3;
            const Int32 FLD_RATE = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_ENTRYDATE = 6;
            const Int32 FLD_PRMBOQDETAILBOQID = 7;
            const Int32 FLD_BDPROJECTFLOORNAME = 8;
            const Int32 FLD_ROWNUMBER = 9;

            PRMBOQFloorDetail_DetailedEntity pRMBOQFloorDetail_DetailedEntity = new PRMBOQFloorDetail_DetailedEntity();

            pRMBOQFloorDetail_DetailedEntity.BOQFloorDetailID = reader.GetInt64(FLD_BOQFLOORDETAILID);
            pRMBOQFloorDetail_DetailedEntity.BOQDetailID = reader.GetInt64(FLD_BOQDETAILID);
            pRMBOQFloorDetail_DetailedEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID);
            if (reader.IsDBNull(FLD_QTY)) { pRMBOQFloorDetail_DetailedEntity.Qty = null; } else { pRMBOQFloorDetail_DetailedEntity.Qty = reader.GetDecimal(FLD_QTY); }
            if (reader.IsDBNull(FLD_RATE)) { pRMBOQFloorDetail_DetailedEntity.Rate = null; } else { pRMBOQFloorDetail_DetailedEntity.Rate = reader.GetDecimal(FLD_RATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { pRMBOQFloorDetail_DetailedEntity.Remarks = String.Empty; } else { pRMBOQFloorDetail_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            pRMBOQFloorDetail_DetailedEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);
            if (reader.IsDBNull(FLD_PRMBOQDETAILBOQID)) { pRMBOQFloorDetail_DetailedEntity.PRMBOQDetailBOQID = null; } else { pRMBOQFloorDetail_DetailedEntity.PRMBOQDetailBOQID = reader.GetInt64(FLD_PRMBOQDETAILBOQID); }
            if (reader.IsDBNull(FLD_BDPROJECTFLOORNAME)) { pRMBOQFloorDetail_DetailedEntity.BDProjectFloorName = String.Empty; } else { pRMBOQFloorDetail_DetailedEntity.BDProjectFloorName = reader.GetString(FLD_BDPROJECTFLOORNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { pRMBOQFloorDetail_DetailedEntity.RowNumber = null; } else { pRMBOQFloorDetail_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return pRMBOQFloorDetail_DetailedEntity;
        }
    }
}
