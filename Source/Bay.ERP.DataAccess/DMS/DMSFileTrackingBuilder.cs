// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Sep-2012, 10:06:41




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class DMSFileTrackingBuilder : IEntityBuilder<DMSFileTrackingEntity>
    {
        IList<DMSFileTrackingEntity> IEntityBuilder<DMSFileTrackingEntity>.BuildEntities(IDataReader reader)
        {
            List<DMSFileTrackingEntity> DMSFileTrackingEntityList = new List<DMSFileTrackingEntity>();

            while (reader.Read())
            {
                DMSFileTrackingEntityList.Add(((IEntityBuilder<DMSFileTrackingEntity>)this).BuildEntity(reader));
            }

            return (DMSFileTrackingEntityList.Count > 0) ? DMSFileTrackingEntityList : null;
        }

        DMSFileTrackingEntity IEntityBuilder<DMSFileTrackingEntity>.BuildEntity(IDataReader reader)
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

            DMSFileTrackingEntity dMSFileTrackingEntity = new DMSFileTrackingEntity();

            dMSFileTrackingEntity.FileTrackingID = reader.GetInt64(FLD_FILETRACKINGID);
            dMSFileTrackingEntity.FileNo = reader.GetString(FLD_FILENO);
            dMSFileTrackingEntity.FileName = reader.GetString(FLD_FILENAME);
            dMSFileTrackingEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID);
            dMSFileTrackingEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            dMSFileTrackingEntity.CreatedDateTime = reader.GetDateTime(FLD_CREATEDDATETIME);
            dMSFileTrackingEntity.FileParmanentPlace = reader.GetString(FLD_FILEPARMANENTPLACE);
            dMSFileTrackingEntity.FileCurrentPlace = reader.GetString(FLD_FILECURRENTPLACE);
            dMSFileTrackingEntity.FileType = reader.GetString(FLD_FILETYPE);
            if (reader.IsDBNull(FLD_SOFTFILENAME)) { dMSFileTrackingEntity.SoftFileName = String.Empty; } else { dMSFileTrackingEntity.SoftFileName = reader.GetString(FLD_SOFTFILENAME); }
            if (reader.IsDBNull(FLD_EXTENSION)) { dMSFileTrackingEntity.Extension = String.Empty; } else { dMSFileTrackingEntity.Extension = reader.GetString(FLD_EXTENSION); }
            if (reader.IsDBNull(FLD_PATH)) { dMSFileTrackingEntity.Path = String.Empty; } else { dMSFileTrackingEntity.Path = reader.GetString(FLD_PATH); }
            if (reader.IsDBNull(FLD_ORIGINALFILENAME)) { dMSFileTrackingEntity.OriginalFileName = String.Empty; } else { dMSFileTrackingEntity.OriginalFileName = reader.GetString(FLD_ORIGINALFILENAME); }
            if (reader.IsDBNull(FLD_CURRENTFILENAME)) { dMSFileTrackingEntity.CurrentFileName = String.Empty; } else { dMSFileTrackingEntity.CurrentFileName = reader.GetString(FLD_CURRENTFILENAME); }

            return dMSFileTrackingEntity;
        }
    }
}
