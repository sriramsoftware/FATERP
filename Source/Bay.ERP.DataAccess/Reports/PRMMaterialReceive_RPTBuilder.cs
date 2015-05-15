// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jul-2012, 11:22:51




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMMaterialReceive_RPTBuilder : IEntityBuilder<PRMMaterialReceive_RPTEntity>
    {
        IList<PRMMaterialReceive_RPTEntity> IEntityBuilder<PRMMaterialReceive_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMMaterialReceive_RPTEntity> PRMMaterialReceive_RPTEntityList = new List<PRMMaterialReceive_RPTEntity>();

            while (reader.Read())
            {
                PRMMaterialReceive_RPTEntityList.Add(((IEntityBuilder<PRMMaterialReceive_RPTEntity>)this).BuildEntity(reader));
            }

            return (PRMMaterialReceive_RPTEntityList.Count > 0) ? PRMMaterialReceive_RPTEntityList : null;
        }

        PRMMaterialReceive_RPTEntity IEntityBuilder<PRMMaterialReceive_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MATERIALRECEIVEID = 0;
            const Int32 FLD_MRRDATE = 1;
            const Int32 FLD_MRRNO = 2;
            const Int32 FLD_PROJECTID = 3;
            const Int32 FLD_REMARKS = 4;
            const Int32 FLD_SUPPLIERID = 5;
            const Int32 FLD_WORKORDERID = 6;
            const Int32 FLD_MATERIALRECEIVEITEMMAPID = 7;
            const Int32 FLD_RECEIVEDATE = 8;
            const Int32 FLD_REQUISITIONITEMID = 9;
            const Int32 FLD_CHALLANNO = 10;
            const Int32 FLD_RECEIVEQTY = 11;
            const Int32 FLD_PROJECTCODE = 12;
            const Int32 FLD_PROJECTNAME = 13;
            const Int32 FLD_SUPPLIERCODE = 14;
            const Int32 FLD_SUPPLIERNAME = 15;
            const Int32 FLD_PHONE = 16;
            const Int32 FLD_MOBILENO = 17;
            const Int32 FLD_WORKORDERNO = 18;
            const Int32 FLD_WORKORDERDATE = 19;
            const Int32 FLD_REQUISITIONNO = 20;
            const Int32 FLD_REQUISITIONDATE = 21;
            const Int32 FLD_ITEMID = 22;
            const Int32 FLD_BRANDID = 23;
            const Int32 FLD_COUNTRYID = 24;
            const Int32 FLD_REGIONID = 25;
            const Int32 FLD_ITEMNAME = 26;
            const Int32 FLD_BRANDNAME = 27;
            const Int32 FLD_ORIGINCOUNTRYNAME = 28;
            const Int32 FLD_ORIGINREGIONNAME = 29;
            const Int32 FLD_UNITNAME = 30;
            const Int32 FLD_ADDRESSLINE1 = 31;

            PRMMaterialReceive_RPTEntity pRMMaterialReceive_RPTEntity = new PRMMaterialReceive_RPTEntity();

            pRMMaterialReceive_RPTEntity.MaterialReceiveID = reader.GetInt64(FLD_MATERIALRECEIVEID);
            pRMMaterialReceive_RPTEntity.MRRDate = reader.GetDateTime(FLD_MRRDATE);
            pRMMaterialReceive_RPTEntity.MRRNo = reader.GetString(FLD_MRRNO);
            pRMMaterialReceive_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            if (reader.IsDBNull(FLD_REMARKS)) { pRMMaterialReceive_RPTEntity.Remarks = String.Empty; } else { pRMMaterialReceive_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            pRMMaterialReceive_RPTEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMMaterialReceive_RPTEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            if (reader.IsDBNull(FLD_MATERIALRECEIVEITEMMAPID)) { pRMMaterialReceive_RPTEntity.MaterialReceiveItemMapID = null; } else { pRMMaterialReceive_RPTEntity.MaterialReceiveItemMapID = reader.GetInt64(FLD_MATERIALRECEIVEITEMMAPID); }
            if (reader.IsDBNull(FLD_RECEIVEDATE)) { pRMMaterialReceive_RPTEntity.ReceiveDate = null; } else { pRMMaterialReceive_RPTEntity.ReceiveDate = reader.GetDateTime(FLD_RECEIVEDATE); }
            if (reader.IsDBNull(FLD_REQUISITIONITEMID)) { pRMMaterialReceive_RPTEntity.RequisitionItemID = null; } else { pRMMaterialReceive_RPTEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID); }
            if (reader.IsDBNull(FLD_CHALLANNO)) { pRMMaterialReceive_RPTEntity.ChallanNo = String.Empty; } else { pRMMaterialReceive_RPTEntity.ChallanNo = reader.GetString(FLD_CHALLANNO); }
            if (reader.IsDBNull(FLD_RECEIVEQTY)) { pRMMaterialReceive_RPTEntity.ReceiveQty = null; } else { pRMMaterialReceive_RPTEntity.ReceiveQty = reader.GetDecimal(FLD_RECEIVEQTY); }
            pRMMaterialReceive_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            pRMMaterialReceive_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            if (reader.IsDBNull(FLD_SUPPLIERCODE)) { pRMMaterialReceive_RPTEntity.SupplierCode = String.Empty; } else { pRMMaterialReceive_RPTEntity.SupplierCode = reader.GetString(FLD_SUPPLIERCODE); }
            pRMMaterialReceive_RPTEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME);
            if (reader.IsDBNull(FLD_PHONE)) { pRMMaterialReceive_RPTEntity.Phone = String.Empty; } else { pRMMaterialReceive_RPTEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_MOBILENO)) { pRMMaterialReceive_RPTEntity.MobileNo = String.Empty; } else { pRMMaterialReceive_RPTEntity.MobileNo = reader.GetString(FLD_MOBILENO); }
            pRMMaterialReceive_RPTEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO);
            pRMMaterialReceive_RPTEntity.WorkOrderDate = reader.GetDateTime(FLD_WORKORDERDATE);
            pRMMaterialReceive_RPTEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO);
            pRMMaterialReceive_RPTEntity.RequisitionDate = reader.GetDateTime(FLD_REQUISITIONDATE);
            if (reader.IsDBNull(FLD_ITEMID)) { pRMMaterialReceive_RPTEntity.ItemID = null; } else { pRMMaterialReceive_RPTEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            if (reader.IsDBNull(FLD_BRANDID)) { pRMMaterialReceive_RPTEntity.BrandID = null; } else { pRMMaterialReceive_RPTEntity.BrandID = reader.GetInt64(FLD_BRANDID); }
            if (reader.IsDBNull(FLD_COUNTRYID)) { pRMMaterialReceive_RPTEntity.CountryID = null; } else { pRMMaterialReceive_RPTEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_REGIONID)) { pRMMaterialReceive_RPTEntity.RegionID = null; } else { pRMMaterialReceive_RPTEntity.RegionID = reader.GetInt64(FLD_REGIONID); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { pRMMaterialReceive_RPTEntity.ItemName = String.Empty; } else { pRMMaterialReceive_RPTEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_BRANDNAME)) { pRMMaterialReceive_RPTEntity.BrandName = String.Empty; } else { pRMMaterialReceive_RPTEntity.BrandName = reader.GetString(FLD_BRANDNAME); }
            if (reader.IsDBNull(FLD_ORIGINCOUNTRYNAME)) { pRMMaterialReceive_RPTEntity.OriginCountryName = String.Empty; } else { pRMMaterialReceive_RPTEntity.OriginCountryName = reader.GetString(FLD_ORIGINCOUNTRYNAME); }
            if (reader.IsDBNull(FLD_ORIGINREGIONNAME)) { pRMMaterialReceive_RPTEntity.OriginRegionName = String.Empty; } else { pRMMaterialReceive_RPTEntity.OriginRegionName = reader.GetString(FLD_ORIGINREGIONNAME); }
            if (reader.IsDBNull(FLD_UNITNAME)) { pRMMaterialReceive_RPTEntity.UnitName = String.Empty; } else { pRMMaterialReceive_RPTEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_ADDRESSLINE1)) { pRMMaterialReceive_RPTEntity.AddressLine1 = String.Empty; } else { pRMMaterialReceive_RPTEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1); }

            return pRMMaterialReceive_RPTEntity;
        }
    }
}
