// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeePhotoBuilder : IEntityBuilder<HREmployeePhotoEntity>
    {
        IList<HREmployeePhotoEntity> IEntityBuilder<HREmployeePhotoEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeePhotoEntity> HREmployeePhotoEntityList = new List<HREmployeePhotoEntity>();

            while (reader.Read())
            {
                HREmployeePhotoEntityList.Add(((IEntityBuilder<HREmployeePhotoEntity>)this).BuildEntity(reader));
            }

            return (HREmployeePhotoEntityList.Count > 0) ? HREmployeePhotoEntityList : null;
        }

        HREmployeePhotoEntity IEntityBuilder<HREmployeePhotoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEPHOTOID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_CURRENTFILENAME = 2;
            const Int32 FLD_EXTENSION = 3;
            const Int32 FLD_REMARKS = 4;
            const Int32 FLD_PATH = 5;
            const Int32 FLD_ORIGINALFILENAME = 6;
            const Int32 FLD_FILETYPE = 7;
            const Int32 FLD_ISCURRENT = 8;

            HREmployeePhotoEntity hREmployeePhotoEntity = new HREmployeePhotoEntity();

            hREmployeePhotoEntity.EmployeePhotoID = reader.GetInt64(FLD_EMPLOYEEPHOTOID);
            hREmployeePhotoEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeePhotoEntity.CurrentFileName = reader.GetString(FLD_CURRENTFILENAME);
            hREmployeePhotoEntity.Extension = reader.GetString(FLD_EXTENSION);
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeePhotoEntity.Remarks = String.Empty; } else { hREmployeePhotoEntity.Remarks = reader.GetString(FLD_REMARKS); }
            hREmployeePhotoEntity.Path = reader.GetString(FLD_PATH);
            hREmployeePhotoEntity.OriginalFileName = reader.GetString(FLD_ORIGINALFILENAME);
            hREmployeePhotoEntity.FileType = reader.GetString(FLD_FILETYPE);
            hREmployeePhotoEntity.IsCurrent = reader.GetBoolean(FLD_ISCURRENT);

            return hREmployeePhotoEntity;
        }
    }
}
