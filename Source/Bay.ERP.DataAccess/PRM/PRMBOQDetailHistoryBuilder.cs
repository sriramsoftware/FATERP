// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Sep-2012, 11:06:52




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMBOQDetailHistoryBuilder : IEntityBuilder<PRMBOQDetailHistoryEntity>
    {
        IList<PRMBOQDetailHistoryEntity> IEntityBuilder<PRMBOQDetailHistoryEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMBOQDetailHistoryEntity> PRMBOQDetailHistoryEntityList = new List<PRMBOQDetailHistoryEntity>();

            while (reader.Read())
            {
                PRMBOQDetailHistoryEntityList.Add(((IEntityBuilder<PRMBOQDetailHistoryEntity>)this).BuildEntity(reader));
            }

            return (PRMBOQDetailHistoryEntityList.Count > 0) ? PRMBOQDetailHistoryEntityList : null;
        }

        PRMBOQDetailHistoryEntity IEntityBuilder<PRMBOQDetailHistoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BOQDETAILHISTORYID = 0;
            const Int32 FLD_BOQDETAILID = 1;
            const Int32 FLD_RATE = 2;
            const Int32 FLD_TOTALQTY = 3;
            const Int32 FLD_ENTRYDATE = 4;
            const Int32 FLD_BRANDID = 5;
            const Int32 FLD_SUPPLIERID = 6;
            const Int32 FLD_REGIONID = 7;
            const Int32 FLD_COUNTRYID = 8;
            const Int32 FLD_MEMBERID = 9;
            const Int32 FLD_USERPCIP = 10;
            const Int32 FLD_UPDATEDDATE = 11;

            PRMBOQDetailHistoryEntity pRMBOQDetailHistoryEntity = new PRMBOQDetailHistoryEntity();

            pRMBOQDetailHistoryEntity.BOQDetailHistoryID = reader.GetInt64(FLD_BOQDETAILHISTORYID);
            pRMBOQDetailHistoryEntity.BOQDetailID = reader.GetInt64(FLD_BOQDETAILID);
            pRMBOQDetailHistoryEntity.Rate = reader.GetDecimal(FLD_RATE);
            pRMBOQDetailHistoryEntity.TotalQty = reader.GetDecimal(FLD_TOTALQTY);
            pRMBOQDetailHistoryEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);
            pRMBOQDetailHistoryEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            pRMBOQDetailHistoryEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMBOQDetailHistoryEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            pRMBOQDetailHistoryEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            pRMBOQDetailHistoryEntity.MemberID = reader.GetInt64(FLD_MEMBERID);
            pRMBOQDetailHistoryEntity.UserPCIP = reader.GetString(FLD_USERPCIP);
            pRMBOQDetailHistoryEntity.UpdatedDate = reader.GetDateTime(FLD_UPDATEDDATE);

            return pRMBOQDetailHistoryEntity;
        }
    }
}
