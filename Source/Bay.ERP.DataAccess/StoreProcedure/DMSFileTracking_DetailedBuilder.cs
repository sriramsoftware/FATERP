// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Sep-2012, 10:36:26




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class DMSFileTracking_DetailedBuilder : IEntityBuilder<DMSFileTracking_DetailedEntity>
    {
        IList<DMSFileTracking_DetailedEntity> IEntityBuilder<DMSFileTracking_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<DMSFileTracking_DetailedEntity> DMSFileTracking_DetailedEntityList = new List<DMSFileTracking_DetailedEntity>();

            while (reader.Read())
            {
                DMSFileTracking_DetailedEntityList.Add(((IEntityBuilder<DMSFileTracking_DetailedEntity>)this).BuildEntity(reader));
            }

            return (DMSFileTracking_DetailedEntityList.Count > 0) ? DMSFileTracking_DetailedEntityList : null;
        }

        DMSFileTracking_DetailedEntity IEntityBuilder<DMSFileTracking_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_FILETRACKINGID = 0;
            const Int32 FLD_FILENO = 1;
            const Int32 FLD_FILENAME = 2;
            const Int32 FLD_DEPARTMENTID = 3;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 4;
            const Int32 FLD_CREATEDDATETIME = 5;
            const Int32 FLD_FILEPARMANENTPLACE = 6;
            const Int32 FLD_FILECURRENTPLACE = 7;
            const Int32 FLD_FILETYPE = 8;
            const Int32 FLD_SOFTFILENAME = 9;
            const Int32 FLD_EXTENSION = 10;
            const Int32 FLD_PATH = 11;
            const Int32 FLD_ORIGINALFILENAME = 12;
            const Int32 FLD_CURRENTFILENAME = 13;
            const Int32 FLD_DEPARTMENTNAME = 14;
            const Int32 FLD_CREATEDBYFULLNAME = 15;
            const Int32 FLD_ROWNUMBER = 16;

            DMSFileTracking_DetailedEntity dMSFileTracking_DetailedEntity = new DMSFileTracking_DetailedEntity();

            dMSFileTracking_DetailedEntity.FileTrackingID = reader.GetInt64(FLD_FILETRACKINGID);
            dMSFileTracking_DetailedEntity.FileNo = reader.GetString(FLD_FILENO);
            dMSFileTracking_DetailedEntity.FileName = reader.GetString(FLD_FILENAME);
            dMSFileTracking_DetailedEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID);
            dMSFileTracking_DetailedEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            dMSFileTracking_DetailedEntity.CreatedDateTime = reader.GetDateTime(FLD_CREATEDDATETIME);
            dMSFileTracking_DetailedEntity.FileParmanentPlace = reader.GetString(FLD_FILEPARMANENTPLACE);
            dMSFileTracking_DetailedEntity.FileCurrentPlace = reader.GetString(FLD_FILECURRENTPLACE);
            dMSFileTracking_DetailedEntity.FileType = reader.GetString(FLD_FILETYPE);
            if (reader.IsDBNull(FLD_SOFTFILENAME)) { dMSFileTracking_DetailedEntity.SoftFileName = String.Empty; } else { dMSFileTracking_DetailedEntity.SoftFileName = reader.GetString(FLD_SOFTFILENAME); }
            if (reader.IsDBNull(FLD_EXTENSION)) { dMSFileTracking_DetailedEntity.Extension = String.Empty; } else { dMSFileTracking_DetailedEntity.Extension = reader.GetString(FLD_EXTENSION); }
            if (reader.IsDBNull(FLD_PATH)) { dMSFileTracking_DetailedEntity.Path = String.Empty; } else { dMSFileTracking_DetailedEntity.Path = reader.GetString(FLD_PATH); }
            if (reader.IsDBNull(FLD_ORIGINALFILENAME)) { dMSFileTracking_DetailedEntity.OriginalFileName = String.Empty; } else { dMSFileTracking_DetailedEntity.OriginalFileName = reader.GetString(FLD_ORIGINALFILENAME); }
            if (reader.IsDBNull(FLD_CURRENTFILENAME)) { dMSFileTracking_DetailedEntity.CurrentFileName = String.Empty; } else { dMSFileTracking_DetailedEntity.CurrentFileName = reader.GetString(FLD_CURRENTFILENAME); }
            if (reader.IsDBNull(FLD_DEPARTMENTNAME)) { dMSFileTracking_DetailedEntity.DepartmentName = String.Empty; } else { dMSFileTracking_DetailedEntity.DepartmentName = reader.GetString(FLD_DEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_CREATEDBYFULLNAME)) { dMSFileTracking_DetailedEntity.CreatedByFullName = String.Empty; } else { dMSFileTracking_DetailedEntity.CreatedByFullName = reader.GetString(FLD_CREATEDBYFULLNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { dMSFileTracking_DetailedEntity.RowNumber = null; } else { dMSFileTracking_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return dMSFileTracking_DetailedEntity;
        }
    }
}
