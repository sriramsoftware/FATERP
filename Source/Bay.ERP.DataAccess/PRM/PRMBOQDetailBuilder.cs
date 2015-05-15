// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMBOQDetailBuilder : IEntityBuilder<PRMBOQDetailEntity>
    {
        IList<PRMBOQDetailEntity> IEntityBuilder<PRMBOQDetailEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMBOQDetailEntity> PRMBOQDetailEntityList = new List<PRMBOQDetailEntity>();

            while (reader.Read())
            {
                PRMBOQDetailEntityList.Add(((IEntityBuilder<PRMBOQDetailEntity>)this).BuildEntity(reader));
            }

            return (PRMBOQDetailEntityList.Count > 0) ? PRMBOQDetailEntityList : null;
        }

        PRMBOQDetailEntity IEntityBuilder<PRMBOQDetailEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BOQDETAILID = 0;
            const Int32 FLD_BOQID = 1;
            const Int32 FLD_ITEMID = 2;
            const Int32 FLD_RATE = 3;
            const Int32 FLD_TOTALQTY = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_ISREMOVED = 6;
            const Int32 FLD_ENTRYDATE = 7;
            const Int32 FLD_BRANDID = 8;
            const Int32 FLD_SUPPLIERID = 9;
            const Int32 FLD_REGIONID = 10;
            const Int32 FLD_COUNTRYID = 11;

            PRMBOQDetailEntity pRMBOQDetailEntity = new PRMBOQDetailEntity();

            pRMBOQDetailEntity.BOQDetailID = reader.GetInt64(FLD_BOQDETAILID);
            pRMBOQDetailEntity.BOQID = reader.GetInt64(FLD_BOQID);
            pRMBOQDetailEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            pRMBOQDetailEntity.Rate = reader.GetDecimal(FLD_RATE);
            pRMBOQDetailEntity.TotalQty = reader.GetDecimal(FLD_TOTALQTY);
            if (reader.IsDBNull(FLD_REMARKS)) { pRMBOQDetailEntity.Remarks = String.Empty; } else { pRMBOQDetailEntity.Remarks = reader.GetString(FLD_REMARKS); }
            pRMBOQDetailEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            pRMBOQDetailEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);
            pRMBOQDetailEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            pRMBOQDetailEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMBOQDetailEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            pRMBOQDetailEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);

            return pRMBOQDetailEntity;
        }
    }
}
