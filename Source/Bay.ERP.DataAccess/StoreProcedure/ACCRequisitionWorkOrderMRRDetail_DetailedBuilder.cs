// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2013, 04:58:29




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACCRequisitionWorkOrderMRRDetail_DetailedBuilder : IEntityBuilder<ACCRequisitionWorkOrderMRRDetail_DetailedEntity>
    {
        IList<ACCRequisitionWorkOrderMRRDetail_DetailedEntity> IEntityBuilder<ACCRequisitionWorkOrderMRRDetail_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<ACCRequisitionWorkOrderMRRDetail_DetailedEntity> ACCRequisitionWorkOrderMRRDetail_DetailedEntityList = new List<ACCRequisitionWorkOrderMRRDetail_DetailedEntity>();

            while (reader.Read())
            {
                ACCRequisitionWorkOrderMRRDetail_DetailedEntityList.Add(((IEntityBuilder<ACCRequisitionWorkOrderMRRDetail_DetailedEntity>)this).BuildEntity(reader));
            }

            return (ACCRequisitionWorkOrderMRRDetail_DetailedEntityList.Count > 0) ? ACCRequisitionWorkOrderMRRDetail_DetailedEntityList : null;
        }

        ACCRequisitionWorkOrderMRRDetail_DetailedEntity IEntityBuilder<ACCRequisitionWorkOrderMRRDetail_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REQUISITIONITEMID = 0;
            const Int32 FLD_PROJECTCODE = 1;
            const Int32 FLD_PROJECTNAME = 2;
            const Int32 FLD_REQUISITIONNO = 3;
            const Int32 FLD_REQUISITIONDATE = 4;
            const Int32 FLD_ITEMNAME = 5;
            const Int32 FLD_BRANDID = 6;
            const Int32 FLD_REGIONID = 7;
            const Int32 FLD_COUNTRYID = 8;
            const Int32 FLD_REQUISITIONQTY = 9;
            const Int32 FLD_WOREQUIREDQTY = 10;
            const Int32 FLD_MRRQTY = 11;
            const Int32 FLD_BRANDNAME = 12;
            const Int32 FLD_ORIGINREGIONNAME = 13;
            const Int32 FLD_ORIGINCOUNTRYNAME = 14;
            const Int32 FLD_ROWNUMBER = 15;

            ACCRequisitionWorkOrderMRRDetail_DetailedEntity aCCRequisitionWorkOrderMRRDetail_DetailedEntity = new ACCRequisitionWorkOrderMRRDetail_DetailedEntity();

            aCCRequisitionWorkOrderMRRDetail_DetailedEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID);
            aCCRequisitionWorkOrderMRRDetail_DetailedEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            aCCRequisitionWorkOrderMRRDetail_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            aCCRequisitionWorkOrderMRRDetail_DetailedEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO);
            aCCRequisitionWorkOrderMRRDetail_DetailedEntity.RequisitionDate = reader.GetDateTime(FLD_REQUISITIONDATE);
            aCCRequisitionWorkOrderMRRDetail_DetailedEntity.ItemName = reader.GetString(FLD_ITEMNAME);
            aCCRequisitionWorkOrderMRRDetail_DetailedEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            aCCRequisitionWorkOrderMRRDetail_DetailedEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            aCCRequisitionWorkOrderMRRDetail_DetailedEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            aCCRequisitionWorkOrderMRRDetail_DetailedEntity.RequisitionQty = reader.GetDecimal(FLD_REQUISITIONQTY);
            if (reader.IsDBNull(FLD_WOREQUIREDQTY)) { aCCRequisitionWorkOrderMRRDetail_DetailedEntity.WORequiredQty = null; } else { aCCRequisitionWorkOrderMRRDetail_DetailedEntity.WORequiredQty = reader.GetDecimal(FLD_WOREQUIREDQTY); }
            if (reader.IsDBNull(FLD_MRRQTY)) { aCCRequisitionWorkOrderMRRDetail_DetailedEntity.MRRQty = null; } else { aCCRequisitionWorkOrderMRRDetail_DetailedEntity.MRRQty = reader.GetDecimal(FLD_MRRQTY); }
            aCCRequisitionWorkOrderMRRDetail_DetailedEntity.BrandName = reader.GetString(FLD_BRANDNAME);
            aCCRequisitionWorkOrderMRRDetail_DetailedEntity.OriginRegionName = reader.GetString(FLD_ORIGINREGIONNAME);
            aCCRequisitionWorkOrderMRRDetail_DetailedEntity.OriginCountryName = reader.GetString(FLD_ORIGINCOUNTRYNAME);
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aCCRequisitionWorkOrderMRRDetail_DetailedEntity.RowNumber = null; } else { aCCRequisitionWorkOrderMRRDetail_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aCCRequisitionWorkOrderMRRDetail_DetailedEntity;
        }
    }
}
