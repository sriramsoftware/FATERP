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
    internal sealed class DMSReferenceLibrary_DetailedBuilder : IEntityBuilder<DMSReferenceLibrary_DetailedEntity>
    {
        IList<DMSReferenceLibrary_DetailedEntity> IEntityBuilder<DMSReferenceLibrary_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<DMSReferenceLibrary_DetailedEntity> DMSReferenceLibrary_DetailedEntityList = new List<DMSReferenceLibrary_DetailedEntity>();

            while (reader.Read())
            {
                DMSReferenceLibrary_DetailedEntityList.Add(((IEntityBuilder<DMSReferenceLibrary_DetailedEntity>)this).BuildEntity(reader));
            }

            return (DMSReferenceLibrary_DetailedEntityList.Count > 0) ? DMSReferenceLibrary_DetailedEntityList : null;
        }

        DMSReferenceLibrary_DetailedEntity IEntityBuilder<DMSReferenceLibrary_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REFERENCELIBRARYID = 0;
            const Int32 FLD_REFERENCELIBRARYCATEGORYID = 1;
            const Int32 FLD_URL = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_FILENAME = 4;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 5;
            const Int32 FLD_REFERENCEDBYEMPLOYEEID = 6;
            const Int32 FLD_EXTENSION = 7;
            const Int32 FLD_REMARKS = 8;
            const Int32 FLD_PATH = 9;
            const Int32 FLD_ORIGINALFILENAME = 10;
            const Int32 FLD_CURRENTFILENAME = 11;
            const Int32 FLD_FILETYPE = 12;
            const Int32 FLD_REFERENCELIBRARYCATEGORYNAME = 13;
            const Int32 FLD_CREATEDBYFULLNAME = 14;
            const Int32 FLD_REFERENCEDBYFULLNAME = 15;
            const Int32 FLD_ROWNUMBER = 16;

            DMSReferenceLibrary_DetailedEntity dMSReferenceLibrary_DetailedEntity = new DMSReferenceLibrary_DetailedEntity();

            dMSReferenceLibrary_DetailedEntity.ReferenceLibraryID = reader.GetInt64(FLD_REFERENCELIBRARYID);
            dMSReferenceLibrary_DetailedEntity.ReferenceLibraryCategoryID = reader.GetInt64(FLD_REFERENCELIBRARYCATEGORYID);
            dMSReferenceLibrary_DetailedEntity.Url = reader.GetString(FLD_URL);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { dMSReferenceLibrary_DetailedEntity.Description = String.Empty; } else { dMSReferenceLibrary_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_FILENAME)) { dMSReferenceLibrary_DetailedEntity.FileName = String.Empty; } else { dMSReferenceLibrary_DetailedEntity.FileName = reader.GetString(FLD_FILENAME); }
            dMSReferenceLibrary_DetailedEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_REFERENCEDBYEMPLOYEEID)) { dMSReferenceLibrary_DetailedEntity.ReferencedByEmployeeID = null; } else { dMSReferenceLibrary_DetailedEntity.ReferencedByEmployeeID = reader.GetInt64(FLD_REFERENCEDBYEMPLOYEEID); }
            dMSReferenceLibrary_DetailedEntity.Extension = reader.GetString(FLD_EXTENSION);
            if (reader.IsDBNull(FLD_REMARKS)) { dMSReferenceLibrary_DetailedEntity.Remarks = String.Empty; } else { dMSReferenceLibrary_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_PATH)) { dMSReferenceLibrary_DetailedEntity.Path = String.Empty; } else { dMSReferenceLibrary_DetailedEntity.Path = reader.GetString(FLD_PATH); }
            if (reader.IsDBNull(FLD_ORIGINALFILENAME)) { dMSReferenceLibrary_DetailedEntity.OriginalFileName = String.Empty; } else { dMSReferenceLibrary_DetailedEntity.OriginalFileName = reader.GetString(FLD_ORIGINALFILENAME); }
            if (reader.IsDBNull(FLD_CURRENTFILENAME)) { dMSReferenceLibrary_DetailedEntity.CurrentFileName = String.Empty; } else { dMSReferenceLibrary_DetailedEntity.CurrentFileName = reader.GetString(FLD_CURRENTFILENAME); }
            if (reader.IsDBNull(FLD_FILETYPE)) { dMSReferenceLibrary_DetailedEntity.FileType = String.Empty; } else { dMSReferenceLibrary_DetailedEntity.FileType = reader.GetString(FLD_FILETYPE); }
            if (reader.IsDBNull(FLD_REFERENCELIBRARYCATEGORYNAME)) { dMSReferenceLibrary_DetailedEntity.ReferenceLibraryCategoryName = String.Empty; } else { dMSReferenceLibrary_DetailedEntity.ReferenceLibraryCategoryName = reader.GetString(FLD_REFERENCELIBRARYCATEGORYNAME); }
            if (reader.IsDBNull(FLD_CREATEDBYFULLNAME)) { dMSReferenceLibrary_DetailedEntity.CreatedByFullName = String.Empty; } else { dMSReferenceLibrary_DetailedEntity.CreatedByFullName = reader.GetString(FLD_CREATEDBYFULLNAME); }
            if (reader.IsDBNull(FLD_REFERENCEDBYFULLNAME)) { dMSReferenceLibrary_DetailedEntity.ReferencedByFullName = String.Empty; } else { dMSReferenceLibrary_DetailedEntity.ReferencedByFullName = reader.GetString(FLD_REFERENCEDBYFULLNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { dMSReferenceLibrary_DetailedEntity.RowNumber = null; } else { dMSReferenceLibrary_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return dMSReferenceLibrary_DetailedEntity;
        }
    }
}
