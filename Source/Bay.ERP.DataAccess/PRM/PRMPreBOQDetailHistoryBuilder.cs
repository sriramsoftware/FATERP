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
    internal sealed class PRMPreBOQDetailHistoryBuilder : IEntityBuilder<PRMPreBOQDetailHistoryEntity>
    {
        IList<PRMPreBOQDetailHistoryEntity> IEntityBuilder<PRMPreBOQDetailHistoryEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMPreBOQDetailHistoryEntity> PRMPreBOQDetailHistoryEntityList = new List<PRMPreBOQDetailHistoryEntity>();

            while (reader.Read())
            {
                PRMPreBOQDetailHistoryEntityList.Add(((IEntityBuilder<PRMPreBOQDetailHistoryEntity>)this).BuildEntity(reader));
            }

            return (PRMPreBOQDetailHistoryEntityList.Count > 0) ? PRMPreBOQDetailHistoryEntityList : null;
        }

        PRMPreBOQDetailHistoryEntity IEntityBuilder<PRMPreBOQDetailHistoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PRMPREBOQDETAILHISTORYID = 0;
            const Int32 FLD_PREBOQDETAILID = 1;
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

            PRMPreBOQDetailHistoryEntity pRMPreBOQDetailHistoryEntity = new PRMPreBOQDetailHistoryEntity();

            pRMPreBOQDetailHistoryEntity.PRMPreBOQDetailHistoryID = reader.GetInt64(FLD_PRMPREBOQDETAILHISTORYID);
            pRMPreBOQDetailHistoryEntity.PreBOQDetailID = reader.GetInt64(FLD_PREBOQDETAILID);
            pRMPreBOQDetailHistoryEntity.Rate = reader.GetDecimal(FLD_RATE);
            pRMPreBOQDetailHistoryEntity.TotalQty = reader.GetDecimal(FLD_TOTALQTY);
            pRMPreBOQDetailHistoryEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);
            pRMPreBOQDetailHistoryEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            pRMPreBOQDetailHistoryEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMPreBOQDetailHistoryEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            pRMPreBOQDetailHistoryEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            pRMPreBOQDetailHistoryEntity.MemberID = reader.GetInt64(FLD_MEMBERID);
            pRMPreBOQDetailHistoryEntity.UserPCIP = reader.GetString(FLD_USERPCIP);
            pRMPreBOQDetailHistoryEntity.UpdatedDate = reader.GetDateTime(FLD_UPDATEDDATE);

            return pRMPreBOQDetailHistoryEntity;
        }
    }
}
