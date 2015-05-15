// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDDrivingLicenseCategoryBuilder : IEntityBuilder<MDDrivingLicenseCategoryEntity>
    {
        IList<MDDrivingLicenseCategoryEntity> IEntityBuilder<MDDrivingLicenseCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDDrivingLicenseCategoryEntity> MDDrivingLicenseCategoryEntityList = new List<MDDrivingLicenseCategoryEntity>();

            while (reader.Read())
            {
                MDDrivingLicenseCategoryEntityList.Add(((IEntityBuilder<MDDrivingLicenseCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDDrivingLicenseCategoryEntityList.Count > 0) ? MDDrivingLicenseCategoryEntityList : null;
        }

        MDDrivingLicenseCategoryEntity IEntityBuilder<MDDrivingLicenseCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_DRIVINGLICENSECATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDDrivingLicenseCategoryEntity mDDrivingLicenseCategoryEntity = new MDDrivingLicenseCategoryEntity();

            mDDrivingLicenseCategoryEntity.DrivingLicenseCategoryID = reader.GetInt64(FLD_DRIVINGLICENSECATEGORYID);
            mDDrivingLicenseCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_REMARKS)) { mDDrivingLicenseCategoryEntity.Remarks = String.Empty; } else { mDDrivingLicenseCategoryEntity.Remarks = reader.GetString(FLD_REMARKS); }
            mDDrivingLicenseCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDDrivingLicenseCategoryEntity;
        }
    }
}
