// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Nov-2013, 11:23:45




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDAsset_DetailedBuilder : IEntityBuilder<MDAsset_DetailedEntity>
    {
        IList<MDAsset_DetailedEntity> IEntityBuilder<MDAsset_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<MDAsset_DetailedEntity> MDAsset_DetailedEntityList = new List<MDAsset_DetailedEntity>();

            while (reader.Read())
            {
                MDAsset_DetailedEntityList.Add(((IEntityBuilder<MDAsset_DetailedEntity>)this).BuildEntity(reader));
            }

            return (MDAsset_DetailedEntityList.Count > 0) ? MDAsset_DetailedEntityList : null;
        }

        MDAsset_DetailedEntity IEntityBuilder<MDAsset_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ASSETID = 0;
            const Int32 FLD_ASSETCATEOGRYID = 1;
            const Int32 FLD_ASSETCODE = 2;
            const Int32 FLD_ASSETNAME = 3;
            const Int32 FLD_IMAGEURL = 4;
            const Int32 FLD_UNITID = 5;
            const Int32 FLD_DESCRIPTION = 6;
            const Int32 FLD_BRANDID = 7;
            const Int32 FLD_SUPPLIERID = 8;
            const Int32 FLD_NEXTMAINTANANCEDATE = 9;
            const Int32 FLD_USEDORHANDELEDBY = 10;
            const Int32 FLD_ASSETOWNERTYPEID = 11;
            const Int32 FLD_OWNERREFERENCEID = 12;
            const Int32 FLD_CURRENTLOCATIONPROJECTID = 13;
            const Int32 FLD_INSURANCEINFORMATION = 14;
            const Int32 FLD_SERVICECONTRACTINFORMATION = 15;
            const Int32 FLD_PRICE = 16;
            const Int32 FLD_WORKORDERID = 17;
            const Int32 FLD_ASSETCONDITIONID = 18;
            const Int32 FLD_ISREMOVED = 19;
            const Int32 FLD_UNITNAME = 20;
            const Int32 FLD_BRANDNAME = 21;
            const Int32 FLD_ASSETCATEOGRYNAME = 22;
            const Int32 FLD_SUPPLIERNAME = 23;
            const Int32 FLD_ASSETOWNERTYPENAME = 24;
            const Int32 FLD_PROJECTNAME = 25;
            const Int32 FLD_PROJECTCODE = 26;
            const Int32 FLD_OWNERREFERENCENAME = 27;
            const Int32 FLD_WORKORDERNO = 28;
            const Int32 FLD_ASSETCONDITIONNAME = 29;
            const Int32 FLD_REMARKS = 30;
            const Int32 FLD_MEDIUM = 31;
            const Int32 FLD_WIDTH = 32;
            const Int32 FLD_HEIGHT = 33;
            const Int32 FLD_PRESENTBOOKVALUE = 34;
            const Int32 FLD_PROJECTFLOORUNITNAME = 35;


            MDAsset_DetailedEntity mDAsset_DetailedEntity = new MDAsset_DetailedEntity();

            mDAsset_DetailedEntity.AssetID = reader.GetInt64(FLD_ASSETID);
            mDAsset_DetailedEntity.AssetCateogryID = reader.GetInt64(FLD_ASSETCATEOGRYID);
            mDAsset_DetailedEntity.AssetCode = reader.GetString(FLD_ASSETCODE);
            mDAsset_DetailedEntity.AssetName = reader.GetString(FLD_ASSETNAME);
            if (reader.IsDBNull(FLD_IMAGEURL)) { mDAsset_DetailedEntity.ImageUrl = String.Empty; } else { mDAsset_DetailedEntity.ImageUrl = reader.GetString(FLD_IMAGEURL); }
            if (reader.IsDBNull(FLD_UNITID)) { mDAsset_DetailedEntity.UnitID = null; } else { mDAsset_DetailedEntity.UnitID = reader.GetInt64(FLD_UNITID); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDAsset_DetailedEntity.Description = String.Empty; } else { mDAsset_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_BRANDID)) { mDAsset_DetailedEntity.BrandID = null; } else { mDAsset_DetailedEntity.BrandID = reader.GetInt64(FLD_BRANDID); }
            if (reader.IsDBNull(FLD_SUPPLIERID)) { mDAsset_DetailedEntity.SupplierID = null; } else { mDAsset_DetailedEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID); }
            if (reader.IsDBNull(FLD_NEXTMAINTANANCEDATE)) { mDAsset_DetailedEntity.NextMaintananceDate = null; } else { mDAsset_DetailedEntity.NextMaintananceDate = reader.GetDateTime(FLD_NEXTMAINTANANCEDATE); }
            if (reader.IsDBNull(FLD_USEDORHANDELEDBY)) { mDAsset_DetailedEntity.UsedOrHandeledBy = String.Empty; } else { mDAsset_DetailedEntity.UsedOrHandeledBy = reader.GetString(FLD_USEDORHANDELEDBY); }
            if (reader.IsDBNull(FLD_ASSETOWNERTYPEID)) { mDAsset_DetailedEntity.AssetOwnerTypeID = null; } else { mDAsset_DetailedEntity.AssetOwnerTypeID = reader.GetInt64(FLD_ASSETOWNERTYPEID); }
            if (reader.IsDBNull(FLD_OWNERREFERENCEID)) { mDAsset_DetailedEntity.OwnerReferenceID = null; } else { mDAsset_DetailedEntity.OwnerReferenceID = reader.GetInt64(FLD_OWNERREFERENCEID); }
            if (reader.IsDBNull(FLD_CURRENTLOCATIONPROJECTID)) { mDAsset_DetailedEntity.CurrentLocationProjectID = null; } else { mDAsset_DetailedEntity.CurrentLocationProjectID = reader.GetInt64(FLD_CURRENTLOCATIONPROJECTID); }
            if (reader.IsDBNull(FLD_INSURANCEINFORMATION)) { mDAsset_DetailedEntity.InsuranceInformation = String.Empty; } else { mDAsset_DetailedEntity.InsuranceInformation = reader.GetString(FLD_INSURANCEINFORMATION); }
            if (reader.IsDBNull(FLD_SERVICECONTRACTINFORMATION)) { mDAsset_DetailedEntity.ServiceContractInformation = String.Empty; } else { mDAsset_DetailedEntity.ServiceContractInformation = reader.GetString(FLD_SERVICECONTRACTINFORMATION); }
            mDAsset_DetailedEntity.Price = reader.GetDecimal(FLD_PRICE);
            if (reader.IsDBNull(FLD_WORKORDERID)) { mDAsset_DetailedEntity.WorkOrderID = null; } else { mDAsset_DetailedEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            mDAsset_DetailedEntity.AssetConditionID = reader.GetInt64(FLD_ASSETCONDITIONID);
            mDAsset_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_UNITNAME)) { mDAsset_DetailedEntity.UnitName = String.Empty; } else { mDAsset_DetailedEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_BRANDNAME)) { mDAsset_DetailedEntity.BrandName = String.Empty; } else { mDAsset_DetailedEntity.BrandName = reader.GetString(FLD_BRANDNAME); }
            if (reader.IsDBNull(FLD_ASSETCATEOGRYNAME)) { mDAsset_DetailedEntity.AssetCateogryName = String.Empty; } else { mDAsset_DetailedEntity.AssetCateogryName = reader.GetString(FLD_ASSETCATEOGRYNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { mDAsset_DetailedEntity.SupplierName = String.Empty; } else { mDAsset_DetailedEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_ASSETOWNERTYPENAME)) { mDAsset_DetailedEntity.AssetOwnerTypeName = String.Empty; } else { mDAsset_DetailedEntity.AssetOwnerTypeName = reader.GetString(FLD_ASSETOWNERTYPENAME); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { mDAsset_DetailedEntity.ProjectName = String.Empty; } else { mDAsset_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { mDAsset_DetailedEntity.ProjectCode = String.Empty; } else { mDAsset_DetailedEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_OWNERREFERENCENAME)) { mDAsset_DetailedEntity.OwnerReferenceName = String.Empty; } else { mDAsset_DetailedEntity.OwnerReferenceName = reader.GetString(FLD_OWNERREFERENCENAME); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { mDAsset_DetailedEntity.WorkOrderNo = String.Empty; } else { mDAsset_DetailedEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_ASSETCONDITIONNAME)) { mDAsset_DetailedEntity.AssetConditionName = String.Empty; } else { mDAsset_DetailedEntity.AssetConditionName = reader.GetString(FLD_ASSETCONDITIONNAME); }
            if (reader.IsDBNull(FLD_REMARKS)) { mDAsset_DetailedEntity.Remarks = String.Empty; } else { mDAsset_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_MEDIUM)) { mDAsset_DetailedEntity.Medium = null; } else { mDAsset_DetailedEntity.Medium = reader.GetString(FLD_MEDIUM); }
            if (reader.IsDBNull(FLD_WIDTH)) { mDAsset_DetailedEntity.Width = null; } else { mDAsset_DetailedEntity.Width = reader.GetDecimal(FLD_WIDTH); }
            if (reader.IsDBNull(FLD_HEIGHT)) { mDAsset_DetailedEntity.Height = null; } else { mDAsset_DetailedEntity.Height = reader.GetDecimal(FLD_HEIGHT); }
            if (reader.IsDBNull(FLD_PRESENTBOOKVALUE)) { mDAsset_DetailedEntity.PresentBookValue = null; } else { mDAsset_DetailedEntity.PresentBookValue = reader.GetDecimal(FLD_PRESENTBOOKVALUE); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITNAME)) { mDAsset_DetailedEntity.ProjectFloorUnitName = String.Empty; } else { mDAsset_DetailedEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME); }

            return mDAsset_DetailedEntity;
        }
    }
}
