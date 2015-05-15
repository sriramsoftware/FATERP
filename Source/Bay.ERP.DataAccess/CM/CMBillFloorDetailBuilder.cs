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
    internal sealed class CMBillFloorDetailBuilder : IEntityBuilder<CMBillFloorDetailEntity>
    {
        IList<CMBillFloorDetailEntity> IEntityBuilder<CMBillFloorDetailEntity>.BuildEntities(IDataReader reader)
        {
            List<CMBillFloorDetailEntity> CMBillFloorDetailEntityList = new List<CMBillFloorDetailEntity>();

            while (reader.Read())
            {
                CMBillFloorDetailEntityList.Add(((IEntityBuilder<CMBillFloorDetailEntity>)this).BuildEntity(reader));
            }

            return (CMBillFloorDetailEntityList.Count > 0) ? CMBillFloorDetailEntityList : null;
        }

        CMBillFloorDetailEntity IEntityBuilder<CMBillFloorDetailEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BILLFLOORDETAILID = 0;
            const Int32 FLD_BILLID = 1;
            const Int32 FLD_BILLFLOORDETAILCATEGORYID = 2;
            const Int32 FLD_PROJECTFLOORID = 3;
            const Int32 FLD_PROJECTFLOORUNITID = 4;
            const Int32 FLD_FLOORBILLAMOUNT = 5;
            const Int32 FLD_REMARKS = 6;
            const Int32 FLD_ENTRYDATE = 7;
            const Int32 FLD_EXTRA1 = 8;
            const Int32 FLD_EXTRA2 = 9;

            CMBillFloorDetailEntity cMBillFloorDetailEntity = new CMBillFloorDetailEntity();

            cMBillFloorDetailEntity.BillFloorDetailID = reader.GetInt64(FLD_BILLFLOORDETAILID);
            cMBillFloorDetailEntity.BillID = reader.GetInt64(FLD_BILLID);
            cMBillFloorDetailEntity.BillFloorDetailCategoryID = reader.GetInt64(FLD_BILLFLOORDETAILCATEGORYID);
            cMBillFloorDetailEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID);
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { cMBillFloorDetailEntity.ProjectFloorUnitID = null; } else { cMBillFloorDetailEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_FLOORBILLAMOUNT)) { cMBillFloorDetailEntity.FloorBillAmount = null; } else { cMBillFloorDetailEntity.FloorBillAmount = reader.GetDecimal(FLD_FLOORBILLAMOUNT); }
            if (reader.IsDBNull(FLD_REMARKS)) { cMBillFloorDetailEntity.Remarks = String.Empty; } else { cMBillFloorDetailEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cMBillFloorDetailEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);
            if (reader.IsDBNull(FLD_EXTRA1)) { cMBillFloorDetailEntity.Extra1 = String.Empty; } else { cMBillFloorDetailEntity.Extra1 = reader.GetString(FLD_EXTRA1); }
            if (reader.IsDBNull(FLD_EXTRA2)) { cMBillFloorDetailEntity.Extra2 = String.Empty; } else { cMBillFloorDetailEntity.Extra2 = reader.GetString(FLD_EXTRA2); }

            return cMBillFloorDetailEntity;
        }
    }
}
