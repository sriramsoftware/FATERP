// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Nov-2013, 09:51:38




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDAssetBuilder : IEntityBuilder<MDAssetEntity>
    {
        IList<MDAssetEntity> IEntityBuilder<MDAssetEntity>.BuildEntities(IDataReader reader)
        {
            List<MDAssetEntity> MDAssetEntityList = new List<MDAssetEntity>();

            while (reader.Read())
            {
                MDAssetEntityList.Add(((IEntityBuilder<MDAssetEntity>)this).BuildEntity(reader));
            }

            return (MDAssetEntityList.Count > 0) ? MDAssetEntityList : null;
        }

        MDAssetEntity IEntityBuilder<MDAssetEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_PROJECTFLOORUNITID = 11;
            const Int32 FLD_PROJECTUNITLOCATIONID = 12;
            const Int32 FLD_ASSETOWNERTYPEID = 13;
            const Int32 FLD_OWNERREFERENCEID = 14;
            const Int32 FLD_CURRENTLOCATIONPROJECTID = 15;
            const Int32 FLD_INSURANCEINFORMATION = 16;
            const Int32 FLD_SERVICECONTRACTINFORMATION = 17;
            const Int32 FLD_PRICE = 18;
            const Int32 FLD_WORKORDERID = 19;
            const Int32 FLD_REMARKS = 20;
            const Int32 FLD_ASSETCONDITIONID = 21;
            const Int32 FLD_ISREMOVED = 22;
            const Int32 FLD_MEDIUM = 23;
            const Int32 FLD_WIDTH = 24;
            const Int32 FLD_HEIGHT = 25;
            const Int32 FLD_PRESENTBOOKVALUE = 26;

            MDAssetEntity mDAssetEntity = new MDAssetEntity();

            mDAssetEntity.AssetID = reader.GetInt64(FLD_ASSETID);
            mDAssetEntity.AssetCateogryID = reader.GetInt64(FLD_ASSETCATEOGRYID);
            mDAssetEntity.AssetCode = reader.GetString(FLD_ASSETCODE);
            mDAssetEntity.AssetName = reader.GetString(FLD_ASSETNAME);
            if (reader.IsDBNull(FLD_IMAGEURL)) { mDAssetEntity.ImageUrl = String.Empty; } else { mDAssetEntity.ImageUrl = reader.GetString(FLD_IMAGEURL); }
            if (reader.IsDBNull(FLD_UNITID)) { mDAssetEntity.UnitID = null; } else { mDAssetEntity.UnitID = reader.GetInt64(FLD_UNITID); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDAssetEntity.Description = String.Empty; } else { mDAssetEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_BRANDID)) { mDAssetEntity.BrandID = null; } else { mDAssetEntity.BrandID = reader.GetInt64(FLD_BRANDID); }
            if (reader.IsDBNull(FLD_SUPPLIERID)) { mDAssetEntity.SupplierID = null; } else { mDAssetEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID); }
            if (reader.IsDBNull(FLD_NEXTMAINTANANCEDATE)) { mDAssetEntity.NextMaintananceDate = null; } else { mDAssetEntity.NextMaintananceDate = reader.GetDateTime(FLD_NEXTMAINTANANCEDATE); }
            if (reader.IsDBNull(FLD_USEDORHANDELEDBY)) { mDAssetEntity.UsedOrHandeledBy = String.Empty; } else { mDAssetEntity.UsedOrHandeledBy = reader.GetString(FLD_USEDORHANDELEDBY); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { mDAssetEntity.ProjectFloorUnitID = null; } else { mDAssetEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_PROJECTUNITLOCATIONID)) { mDAssetEntity.ProjectUnitLocationID = null; } else { mDAssetEntity.ProjectUnitLocationID = reader.GetInt64(FLD_PROJECTUNITLOCATIONID); }
            mDAssetEntity.AssetOwnerTypeID = reader.GetInt64(FLD_ASSETOWNERTYPEID);
            if (reader.IsDBNull(FLD_OWNERREFERENCEID)) { mDAssetEntity.OwnerReferenceID = null; } else { mDAssetEntity.OwnerReferenceID = reader.GetInt64(FLD_OWNERREFERENCEID); }
            if (reader.IsDBNull(FLD_CURRENTLOCATIONPROJECTID)) { mDAssetEntity.CurrentLocationProjectID = null; } else { mDAssetEntity.CurrentLocationProjectID = reader.GetInt64(FLD_CURRENTLOCATIONPROJECTID); }
            if (reader.IsDBNull(FLD_INSURANCEINFORMATION)) { mDAssetEntity.InsuranceInformation = String.Empty; } else { mDAssetEntity.InsuranceInformation = reader.GetString(FLD_INSURANCEINFORMATION); }
            if (reader.IsDBNull(FLD_SERVICECONTRACTINFORMATION)) { mDAssetEntity.ServiceContractInformation = String.Empty; } else { mDAssetEntity.ServiceContractInformation = reader.GetString(FLD_SERVICECONTRACTINFORMATION); }
            mDAssetEntity.Price = reader.GetDecimal(FLD_PRICE);
            if (reader.IsDBNull(FLD_WORKORDERID)) { mDAssetEntity.WorkOrderID = null; } else { mDAssetEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_REMARKS)) { mDAssetEntity.Remarks = String.Empty; } else { mDAssetEntity.Remarks = reader.GetString(FLD_REMARKS); }
            mDAssetEntity.AssetConditionID = reader.GetInt64(FLD_ASSETCONDITIONID);
            mDAssetEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_MEDIUM)) { mDAssetEntity.Medium = null; } else { mDAssetEntity.Medium = reader.GetString(FLD_MEDIUM); }
            if (reader.IsDBNull(FLD_WIDTH)) { mDAssetEntity.Width = null; } else { mDAssetEntity.Width = reader.GetDecimal(FLD_WIDTH); }
            if (reader.IsDBNull(FLD_HEIGHT)) { mDAssetEntity.Height = null; } else { mDAssetEntity.Height = reader.GetDecimal(FLD_HEIGHT); }
            if (reader.IsDBNull(FLD_PRESENTBOOKVALUE)) { mDAssetEntity.PresentBookValue = null; } else { mDAssetEntity.PresentBookValue = reader.GetDecimal(FLD_PRESENTBOOKVALUE); }

            return mDAssetEntity;
        }
    }
}
