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
    internal sealed class MDItemDefaultBuilder : IEntityBuilder<MDItemDefaultEntity>
    {
        IList<MDItemDefaultEntity> IEntityBuilder<MDItemDefaultEntity>.BuildEntities(IDataReader reader)
        {
            List<MDItemDefaultEntity> MDItemDefaultEntityList = new List<MDItemDefaultEntity>();

            while (reader.Read())
            {
                MDItemDefaultEntityList.Add(((IEntityBuilder<MDItemDefaultEntity>)this).BuildEntity(reader));
            }

            return (MDItemDefaultEntityList.Count > 0) ? MDItemDefaultEntityList : null;
        }

        MDItemDefaultEntity IEntityBuilder<MDItemDefaultEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ITEMDEFAULTID = 0;
            const Int32 FLD_ITEMID = 1;
            const Int32 FLD_BRANDID = 2;
            const Int32 FLD_SUPPLIERID = 3;
            const Int32 FLD_REGIONID = 4;
            const Int32 FLD_COUNTRYID = 5;

            MDItemDefaultEntity mDItemDefaultEntity = new MDItemDefaultEntity();

            mDItemDefaultEntity.ItemDefaultID = reader.GetInt64(FLD_ITEMDEFAULTID);
            mDItemDefaultEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            mDItemDefaultEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            mDItemDefaultEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            mDItemDefaultEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            mDItemDefaultEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);

            return mDItemDefaultEntity;
        }
    }
}
