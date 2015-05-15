// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Aug-2013, 01:19:26




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDFloorWiseWOBillDetail_RPTBuilder : IEntityBuilder<BDFloorWiseWOBillDetail_RPTEntity>
    {
        IList<BDFloorWiseWOBillDetail_RPTEntity> IEntityBuilder<BDFloorWiseWOBillDetail_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<BDFloorWiseWOBillDetail_RPTEntity> BDFloorWiseWOBillDetail_RPTEntityList = new List<BDFloorWiseWOBillDetail_RPTEntity>();

            while (reader.Read())
            {
                BDFloorWiseWOBillDetail_RPTEntityList.Add(((IEntityBuilder<BDFloorWiseWOBillDetail_RPTEntity>)this).BuildEntity(reader));
            }

            return (BDFloorWiseWOBillDetail_RPTEntityList.Count > 0) ? BDFloorWiseWOBillDetail_RPTEntityList : null;
        }

        BDFloorWiseWOBillDetail_RPTEntity IEntityBuilder<BDFloorWiseWOBillDetail_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTID = 0;
            const Int32 FLD_PROJECTCODE = 1;
            const Int32 FLD_PROJECTNAME = 2;
            const Int32 FLD_FLOORNAME = 3;
            const Int32 FLD_PROJECTFLOORUNITNAME = 4;
            const Int32 FLD_PROJECTFLOORID = 5;
            const Int32 FLD_PROJECTFLOORUNITID = 6;
            const Int32 FLD_TOTALWOVALUE = 7;
            const Int32 FLD_FLOORWISEWOVALUE = 8;
            const Int32 FLD_WORKORDERSTATUSID = 9;
            const Int32 FLD_TOTALFLOORBILLAMOUNT = 10;
            const Int32 FLD_BILLAPPROVALSTATUSID = 11;

            BDFloorWiseWOBillDetail_RPTEntity bDFloorWiseWOBillDetail_RPTEntity = new BDFloorWiseWOBillDetail_RPTEntity();

            if (reader.IsDBNull(FLD_PROJECTID)) { bDFloorWiseWOBillDetail_RPTEntity.ProjectID = null; } else { bDFloorWiseWOBillDetail_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            bDFloorWiseWOBillDetail_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            bDFloorWiseWOBillDetail_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            if (reader.IsDBNull(FLD_FLOORNAME)) { bDFloorWiseWOBillDetail_RPTEntity.FloorName = String.Empty; } else { bDFloorWiseWOBillDetail_RPTEntity.FloorName = reader.GetString(FLD_FLOORNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITNAME)) { bDFloorWiseWOBillDetail_RPTEntity.ProjectFloorUnitName = String.Empty; } else { bDFloorWiseWOBillDetail_RPTEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORID)) { bDFloorWiseWOBillDetail_RPTEntity.ProjectFloorID = null; } else { bDFloorWiseWOBillDetail_RPTEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { bDFloorWiseWOBillDetail_RPTEntity.ProjectFloorUnitID = null; } else { bDFloorWiseWOBillDetail_RPTEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_TOTALWOVALUE)) { bDFloorWiseWOBillDetail_RPTEntity.TotalWOValue = null; } else { bDFloorWiseWOBillDetail_RPTEntity.TotalWOValue = reader.GetDecimal(FLD_TOTALWOVALUE); }
            if (reader.IsDBNull(FLD_FLOORWISEWOVALUE)) { bDFloorWiseWOBillDetail_RPTEntity.FloorWiseWOValue = null; } else { bDFloorWiseWOBillDetail_RPTEntity.FloorWiseWOValue = reader.GetDecimal(FLD_FLOORWISEWOVALUE); }
            bDFloorWiseWOBillDetail_RPTEntity.WorkOrderStatusID = reader.GetInt64(FLD_WORKORDERSTATUSID);
            if (reader.IsDBNull(FLD_TOTALFLOORBILLAMOUNT)) { bDFloorWiseWOBillDetail_RPTEntity.TotalFloorBillAmount = null; } else { bDFloorWiseWOBillDetail_RPTEntity.TotalFloorBillAmount = reader.GetDecimal(FLD_TOTALFLOORBILLAMOUNT); }
            if (reader.IsDBNull(FLD_BILLAPPROVALSTATUSID)) { bDFloorWiseWOBillDetail_RPTEntity.BillApprovalStatusID = null; } else { bDFloorWiseWOBillDetail_RPTEntity.BillApprovalStatusID = reader.GetInt64(FLD_BILLAPPROVALSTATUSID); }

            return bDFloorWiseWOBillDetail_RPTEntity;
        }
    }
}
