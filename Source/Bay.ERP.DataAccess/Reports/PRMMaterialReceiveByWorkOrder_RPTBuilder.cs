// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Oct-2012, 01:00:56




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMMaterialReceiveByWorkOrder_RPTBuilder : IEntityBuilder<PRMMaterialReceiveByWorkOrder_RPTEntity>
    {
        IList<PRMMaterialReceiveByWorkOrder_RPTEntity> IEntityBuilder<PRMMaterialReceiveByWorkOrder_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMMaterialReceiveByWorkOrder_RPTEntity> PRMMaterialReceiveByWorkOrder_RPTEntityList = new List<PRMMaterialReceiveByWorkOrder_RPTEntity>();

            while (reader.Read())
            {
                PRMMaterialReceiveByWorkOrder_RPTEntityList.Add(((IEntityBuilder<PRMMaterialReceiveByWorkOrder_RPTEntity>)this).BuildEntity(reader));
            }

            return (PRMMaterialReceiveByWorkOrder_RPTEntityList.Count > 0) ? PRMMaterialReceiveByWorkOrder_RPTEntityList : null;
        }

        PRMMaterialReceiveByWorkOrder_RPTEntity IEntityBuilder<PRMMaterialReceiveByWorkOrder_RPTEntity>.BuildEntity(IDataReader reader)
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

            PRMMaterialReceiveByWorkOrder_RPTEntity pRMMaterialReceiveByWorkOrder_RPTEntity = new PRMMaterialReceiveByWorkOrder_RPTEntity();

            pRMMaterialReceiveByWorkOrder_RPTEntity.MaterialReceiveID = reader.GetInt64(FLD_MATERIALRECEIVEID);
            pRMMaterialReceiveByWorkOrder_RPTEntity.MRRDate = reader.GetDateTime(FLD_MRRDATE);
            pRMMaterialReceiveByWorkOrder_RPTEntity.MRRNo = reader.GetString(FLD_MRRNO);
            pRMMaterialReceiveByWorkOrder_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            if (reader.IsDBNull(FLD_REMARKS)) { pRMMaterialReceiveByWorkOrder_RPTEntity.Remarks = String.Empty; } else { pRMMaterialReceiveByWorkOrder_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            pRMMaterialReceiveByWorkOrder_RPTEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMMaterialReceiveByWorkOrder_RPTEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            if (reader.IsDBNull(FLD_MATERIALRECEIVEITEMMAPID)) { pRMMaterialReceiveByWorkOrder_RPTEntity.MaterialReceiveItemMapID = null; } else { pRMMaterialReceiveByWorkOrder_RPTEntity.MaterialReceiveItemMapID = reader.GetInt64(FLD_MATERIALRECEIVEITEMMAPID); }
            if (reader.IsDBNull(FLD_RECEIVEDATE)) { pRMMaterialReceiveByWorkOrder_RPTEntity.ReceiveDate = null; } else { pRMMaterialReceiveByWorkOrder_RPTEntity.ReceiveDate = reader.GetDateTime(FLD_RECEIVEDATE); }
            if (reader.IsDBNull(FLD_REQUISITIONITEMID)) { pRMMaterialReceiveByWorkOrder_RPTEntity.RequisitionItemID = null; } else { pRMMaterialReceiveByWorkOrder_RPTEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID); }
            if (reader.IsDBNull(FLD_CHALLANNO)) { pRMMaterialReceiveByWorkOrder_RPTEntity.ChallanNo = String.Empty; } else { pRMMaterialReceiveByWorkOrder_RPTEntity.ChallanNo = reader.GetString(FLD_CHALLANNO); }
            if (reader.IsDBNull(FLD_RECEIVEQTY)) { pRMMaterialReceiveByWorkOrder_RPTEntity.ReceiveQty = null; } else { pRMMaterialReceiveByWorkOrder_RPTEntity.ReceiveQty = reader.GetDecimal(FLD_RECEIVEQTY); }
            pRMMaterialReceiveByWorkOrder_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            pRMMaterialReceiveByWorkOrder_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            if (reader.IsDBNull(FLD_SUPPLIERCODE)) { pRMMaterialReceiveByWorkOrder_RPTEntity.SupplierCode = String.Empty; } else { pRMMaterialReceiveByWorkOrder_RPTEntity.SupplierCode = reader.GetString(FLD_SUPPLIERCODE); }
            pRMMaterialReceiveByWorkOrder_RPTEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME);
            if (reader.IsDBNull(FLD_PHONE)) { pRMMaterialReceiveByWorkOrder_RPTEntity.Phone = String.Empty; } else { pRMMaterialReceiveByWorkOrder_RPTEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_MOBILENO)) { pRMMaterialReceiveByWorkOrder_RPTEntity.MobileNo = String.Empty; } else { pRMMaterialReceiveByWorkOrder_RPTEntity.MobileNo = reader.GetString(FLD_MOBILENO); }
            pRMMaterialReceiveByWorkOrder_RPTEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO);
            pRMMaterialReceiveByWorkOrder_RPTEntity.WorkOrderDate = reader.GetDateTime(FLD_WORKORDERDATE);
            pRMMaterialReceiveByWorkOrder_RPTEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO);
            pRMMaterialReceiveByWorkOrder_RPTEntity.RequisitionDate = reader.GetDateTime(FLD_REQUISITIONDATE);
            if (reader.IsDBNull(FLD_ITEMID)) { pRMMaterialReceiveByWorkOrder_RPTEntity.ItemID = null; } else { pRMMaterialReceiveByWorkOrder_RPTEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            if (reader.IsDBNull(FLD_BRANDID)) { pRMMaterialReceiveByWorkOrder_RPTEntity.BrandID = null; } else { pRMMaterialReceiveByWorkOrder_RPTEntity.BrandID = reader.GetInt64(FLD_BRANDID); }
            if (reader.IsDBNull(FLD_COUNTRYID)) { pRMMaterialReceiveByWorkOrder_RPTEntity.CountryID = null; } else { pRMMaterialReceiveByWorkOrder_RPTEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_REGIONID)) { pRMMaterialReceiveByWorkOrder_RPTEntity.RegionID = null; } else { pRMMaterialReceiveByWorkOrder_RPTEntity.RegionID = reader.GetInt64(FLD_REGIONID); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { pRMMaterialReceiveByWorkOrder_RPTEntity.ItemName = String.Empty; } else { pRMMaterialReceiveByWorkOrder_RPTEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_BRANDNAME)) { pRMMaterialReceiveByWorkOrder_RPTEntity.BrandName = String.Empty; } else { pRMMaterialReceiveByWorkOrder_RPTEntity.BrandName = reader.GetString(FLD_BRANDNAME); }
            if (reader.IsDBNull(FLD_ORIGINCOUNTRYNAME)) { pRMMaterialReceiveByWorkOrder_RPTEntity.OriginCountryName = String.Empty; } else { pRMMaterialReceiveByWorkOrder_RPTEntity.OriginCountryName = reader.GetString(FLD_ORIGINCOUNTRYNAME); }
            if (reader.IsDBNull(FLD_ORIGINREGIONNAME)) { pRMMaterialReceiveByWorkOrder_RPTEntity.OriginRegionName = String.Empty; } else { pRMMaterialReceiveByWorkOrder_RPTEntity.OriginRegionName = reader.GetString(FLD_ORIGINREGIONNAME); }
            if (reader.IsDBNull(FLD_UNITNAME)) { pRMMaterialReceiveByWorkOrder_RPTEntity.UnitName = String.Empty; } else { pRMMaterialReceiveByWorkOrder_RPTEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_ADDRESSLINE1)) { pRMMaterialReceiveByWorkOrder_RPTEntity.AddressLine1 = String.Empty; } else { pRMMaterialReceiveByWorkOrder_RPTEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1); }

            return pRMMaterialReceiveByWorkOrder_RPTEntity;
        }
    }
}
