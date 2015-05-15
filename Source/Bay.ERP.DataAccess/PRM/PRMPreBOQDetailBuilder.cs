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
    internal sealed class PRMPreBOQDetailBuilder : IEntityBuilder<PRMPreBOQDetailEntity>
    {
        IList<PRMPreBOQDetailEntity> IEntityBuilder<PRMPreBOQDetailEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMPreBOQDetailEntity> PRMPreBOQDetailEntityList = new List<PRMPreBOQDetailEntity>();

            while (reader.Read())
            {
                PRMPreBOQDetailEntityList.Add(((IEntityBuilder<PRMPreBOQDetailEntity>)this).BuildEntity(reader));
            }

            return (PRMPreBOQDetailEntityList.Count > 0) ? PRMPreBOQDetailEntityList : null;
        }

        PRMPreBOQDetailEntity IEntityBuilder<PRMPreBOQDetailEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PREBOQDETAILID = 0;
            const Int32 FLD_PREBOQID = 1;
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

            PRMPreBOQDetailEntity pRMPreBOQDetailEntity = new PRMPreBOQDetailEntity();

            pRMPreBOQDetailEntity.PreBOQDetailID = reader.GetInt64(FLD_PREBOQDETAILID);
            pRMPreBOQDetailEntity.PreBOQID = reader.GetInt64(FLD_PREBOQID);
            pRMPreBOQDetailEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            pRMPreBOQDetailEntity.Rate = reader.GetDecimal(FLD_RATE);
            pRMPreBOQDetailEntity.TotalQty = reader.GetDecimal(FLD_TOTALQTY);
            if (reader.IsDBNull(FLD_REMARKS)) { pRMPreBOQDetailEntity.Remarks = String.Empty; } else { pRMPreBOQDetailEntity.Remarks = reader.GetString(FLD_REMARKS); }
            pRMPreBOQDetailEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            pRMPreBOQDetailEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);
            pRMPreBOQDetailEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            pRMPreBOQDetailEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMPreBOQDetailEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            pRMPreBOQDetailEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);

            return pRMPreBOQDetailEntity;
        }
    }
}
