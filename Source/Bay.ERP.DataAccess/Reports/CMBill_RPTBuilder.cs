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
    internal sealed class CMBill_RPTBuilder : IEntityBuilder<CMBill_RPTEntity>
    {
        IList<CMBill_RPTEntity> IEntityBuilder<CMBill_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<CMBill_RPTEntity> CMBill_RPTEntityList = new List<CMBill_RPTEntity>();

            while (reader.Read())
            {
                CMBill_RPTEntityList.Add(((IEntityBuilder<CMBill_RPTEntity>)this).BuildEntity(reader));
            }

            return (CMBill_RPTEntityList.Count > 0) ? CMBill_RPTEntityList : null;
        }

        CMBill_RPTEntity IEntityBuilder<CMBill_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BILLID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_BILLNO = 2;
            const Int32 FLD_VENDORCATEGORY = 3;
            const Int32 FLD_VENDOR = 4;
            const Int32 FLD_WORKORDERID = 5;
            const Int32 FLD_DISCOUNTADDITION = 6;
            const Int32 FLD_VAT = 7;
            const Int32 FLD_TAX = 8;
            const Int32 FLD_CARRYINGCHARGE = 9;
            const Int32 FLD_AMOUNT = 10;
            const Int32 FLD_ADDITIONREMARKS = 11;
            const Int32 FLD_CREATEDATE = 12;
            const Int32 FLD_BILLDATE = 13;
            const Int32 FLD_REMARKS = 14;
            const Int32 FLD_BILLSTATUSID = 15;
            const Int32 FLD_BILLAPPROVALSTATUSID = 16;
            const Int32 FLD_BILLMATERIALRECEIVEMEASUREMENTBOOKMAPID = 17;
            const Int32 FLD_MATERIALRECEIVEID = 18;
            const Int32 FLD_MATERIALRECEIVEITEMMAPID = 19;
            const Int32 FLD_MEASUREMENTBOOKID = 20;
            const Int32 FLD_MEASUREMENTBOOKDETAILSID = 21;
            const Int32 FLD_BILLPRICE = 22;
            const Int32 FLD_BILLUPLOADINFOID = 23;
            const Int32 FLD_EXTENSION = 24;
            const Int32 FLD_BILLUPLOADINFOREMARKS = 25;
            //const Int32 FLD_FILEUPLOADREMARKS = 12;
            const Int32 FLD_PATH = 26;
            const Int32 FLD_ORIGINALFILENAME = 27;
            const Int32 FLD_CURRENTFILENAME = 28;
            const Int32 FLD_FILETYPE = 29;
            const Int32 FLD_PROJECTCODE = 30;
            const Int32 FLD_PROJECTNAME = 31;
            const Int32 FLD_SUPPLIERID = 32;
            const Int32 FLD_SUPPLIERCODE = 33;
            const Int32 FLD_SUPPLIERNAME = 34;
            const Int32 FLD_RELATIONSHIP = 35;
            const Int32 FLD_PHONE = 36;
            const Int32 FLD_MOBILENO = 37;
            const Int32 FLD_FAX = 38;
            const Int32 FLD_EMAIL = 39;
            const Int32 FLD_WEBLINK = 40;
            const Int32 FLD_SUPPLIERCREATEDATE = 41;
            const Int32 FLD_SUPPLIERREMARKS = 42;
            const Int32 FLD_SUPPLIERTYPEID = 43;
            const Int32 FLD_SUPPLIERSTATUSID = 44;
            const Int32 FLD_REASON = 45;
            const Int32 FLD_ISREMOVED = 46;
            const Int32 FLD_WORKORDERNO = 47;
            
            

            CMBill_RPTEntity cMBill_RPTEntity = new CMBill_RPTEntity();

            cMBill_RPTEntity.BillID = reader.GetInt64(FLD_BILLID);
            cMBill_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cMBill_RPTEntity.BillNo = reader.GetString(FLD_BILLNO);
            cMBill_RPTEntity.VendorCategory = reader.GetInt64(FLD_VENDORCATEGORY);
            cMBill_RPTEntity.Vendor = reader.GetInt64(FLD_VENDOR);
            cMBill_RPTEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            cMBill_RPTEntity.DiscountAddition = reader.GetInt64(FLD_DISCOUNTADDITION);
            cMBill_RPTEntity.Vat = reader.GetInt64(FLD_VAT);
            cMBill_RPTEntity.Tax = reader.GetInt64(FLD_TAX);
            cMBill_RPTEntity.CarryingCharge = reader.GetInt64(FLD_CARRYINGCHARGE);
            cMBill_RPTEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            cMBill_RPTEntity.AdditionRemarks = reader.GetString(FLD_ADDITIONREMARKS);
            cMBill_RPTEntity.BillNo = reader.GetString(FLD_BILLNO);
            cMBill_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cMBill_RPTEntity.BillDate = reader.GetDateTime(FLD_BILLDATE);
            if (reader.IsDBNull(FLD_REMARKS)) { cMBill_RPTEntity.Remarks = String.Empty; } else { cMBill_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cMBill_RPTEntity.BillStatusID = reader.GetInt64(FLD_BILLSTATUSID);
            cMBill_RPTEntity.BillApprovalStatusID = reader.GetInt64(FLD_BILLAPPROVALSTATUSID);
            cMBill_RPTEntity.BillMaterialReceiveMeasurementBookMapID = reader.GetInt64(FLD_BILLMATERIALRECEIVEMEASUREMENTBOOKMAPID);
            cMBill_RPTEntity.MaterialReceiveID = reader.GetInt64(FLD_MATERIALRECEIVEID);
            cMBill_RPTEntity.MaterialReceiveItemMapID = reader.GetInt64(FLD_MATERIALRECEIVEITEMMAPID);
            cMBill_RPTEntity.MeasurementBookID = reader.GetInt64(FLD_MEASUREMENTBOOKID);
            cMBill_RPTEntity.MeasurementBookDetailID = reader.GetInt64(FLD_MEASUREMENTBOOKDETAILSID);
            cMBill_RPTEntity.BillPrice = reader.GetInt64(FLD_BILLPRICE);
            if (reader.IsDBNull(FLD_BILLUPLOADINFOID)) { cMBill_RPTEntity.BillUploadInfoID = null; } else { cMBill_RPTEntity.BillUploadInfoID = reader.GetInt64(FLD_BILLUPLOADINFOID); }
            if (reader.IsDBNull(FLD_EXTENSION)) { cMBill_RPTEntity.Extension = String.Empty; } else { cMBill_RPTEntity.Extension = reader.GetString(FLD_EXTENSION); }
            if (reader.IsDBNull(FLD_BILLUPLOADINFOREMARKS)) { cMBill_RPTEntity.BillUploadInfoRemaks = String.Empty; } else { cMBill_RPTEntity.BillUploadInfoRemaks = reader.GetString(FLD_BILLUPLOADINFOREMARKS); }
            //if (reader.IsDBNull(FLD_FILEUPLOADREMARKS)) { cMBill_RPTEntity.FileUploadRemarks = String.Empty; } else { cMBill_RPTEntity.FileUploadRemarks = reader.GetString(FLD_FILEUPLOADREMARKS); }
            if (reader.IsDBNull(FLD_PATH)) { cMBill_RPTEntity.Path = String.Empty; } else { cMBill_RPTEntity.Path = reader.GetString(FLD_PATH); }
            if (reader.IsDBNull(FLD_ORIGINALFILENAME)) { cMBill_RPTEntity.OriginalFileName = String.Empty; } else { cMBill_RPTEntity.OriginalFileName = reader.GetString(FLD_ORIGINALFILENAME); }
            if (reader.IsDBNull(FLD_CURRENTFILENAME)) { cMBill_RPTEntity.CurrentFileName = String.Empty; } else { cMBill_RPTEntity.CurrentFileName = reader.GetString(FLD_CURRENTFILENAME); }
            if (reader.IsDBNull(FLD_FILETYPE)) { cMBill_RPTEntity.FileType = String.Empty; } else { cMBill_RPTEntity.FileType = reader.GetString(FLD_FILETYPE); }
            cMBill_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            cMBill_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            cMBill_RPTEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            if (reader.IsDBNull(FLD_SUPPLIERCODE)) { cMBill_RPTEntity.SupplierCode = String.Empty; } else { cMBill_RPTEntity.SupplierCode = reader.GetString(FLD_SUPPLIERCODE); }
            cMBill_RPTEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME);
            cMBill_RPTEntity.Relationship = reader.GetString(FLD_RELATIONSHIP);
            cMBill_RPTEntity.Phone = reader.GetString(FLD_PHONE);
            cMBill_RPTEntity.MobileNo = reader.GetString(FLD_MOBILENO);
            cMBill_RPTEntity.Fax = reader.GetString(FLD_FAX);
            cMBill_RPTEntity.Email = reader.GetString(FLD_EMAIL);
            cMBill_RPTEntity.WebLink = reader.GetString(FLD_WEBLINK);
            cMBill_RPTEntity.SupplierCreateDate = reader.GetDateTime(FLD_SUPPLIERCREATEDATE);
            cMBill_RPTEntity.SupplierRemarks = reader.GetString(FLD_SUPPLIERREMARKS);
            cMBill_RPTEntity.SupplierTypeID = reader.GetInt64(FLD_SUPPLIERTYPEID);
            cMBill_RPTEntity.SupplierStatusID = reader.GetInt64(FLD_SUPPLIERSTATUSID);
            cMBill_RPTEntity.Reason = reader.GetString(FLD_REASON);
            cMBill_RPTEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            cMBill_RPTEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO);

            return cMBill_RPTEntity;
        }
    }
}
