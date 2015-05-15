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
    internal sealed class DMSReferenceLibraryBuilder : IEntityBuilder<DMSReferenceLibraryEntity>
    {
        IList<DMSReferenceLibraryEntity> IEntityBuilder<DMSReferenceLibraryEntity>.BuildEntities(IDataReader reader)
        {
            List<DMSReferenceLibraryEntity> DMSReferenceLibraryEntityList = new List<DMSReferenceLibraryEntity>();

            while (reader.Read())
            {
                DMSReferenceLibraryEntityList.Add(((IEntityBuilder<DMSReferenceLibraryEntity>)this).BuildEntity(reader));
            }

            return (DMSReferenceLibraryEntityList.Count > 0) ? DMSReferenceLibraryEntityList : null;
        }

        DMSReferenceLibraryEntity IEntityBuilder<DMSReferenceLibraryEntity>.BuildEntity(IDataReader reader)
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

            DMSReferenceLibraryEntity dMSReferenceLibraryEntity = new DMSReferenceLibraryEntity();

            dMSReferenceLibraryEntity.ReferenceLibraryID = reader.GetInt64(FLD_REFERENCELIBRARYID);
            dMSReferenceLibraryEntity.ReferenceLibraryCategoryID = reader.GetInt64(FLD_REFERENCELIBRARYCATEGORYID);
            dMSReferenceLibraryEntity.Url = reader.GetString(FLD_URL);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { dMSReferenceLibraryEntity.Description = String.Empty; } else { dMSReferenceLibraryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_FILENAME)) { dMSReferenceLibraryEntity.FileName = String.Empty; } else { dMSReferenceLibraryEntity.FileName = reader.GetString(FLD_FILENAME); }
            dMSReferenceLibraryEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_REFERENCEDBYEMPLOYEEID)) { dMSReferenceLibraryEntity.ReferencedByEmployeeID = null; } else { dMSReferenceLibraryEntity.ReferencedByEmployeeID = reader.GetInt64(FLD_REFERENCEDBYEMPLOYEEID); }
            dMSReferenceLibraryEntity.Extension = reader.GetString(FLD_EXTENSION);
            if (reader.IsDBNull(FLD_REMARKS)) { dMSReferenceLibraryEntity.Remarks = String.Empty; } else { dMSReferenceLibraryEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_PATH)) { dMSReferenceLibraryEntity.Path = String.Empty; } else { dMSReferenceLibraryEntity.Path = reader.GetString(FLD_PATH); }
            if (reader.IsDBNull(FLD_ORIGINALFILENAME)) { dMSReferenceLibraryEntity.OriginalFileName = String.Empty; } else { dMSReferenceLibraryEntity.OriginalFileName = reader.GetString(FLD_ORIGINALFILENAME); }
            if (reader.IsDBNull(FLD_CURRENTFILENAME)) { dMSReferenceLibraryEntity.CurrentFileName = String.Empty; } else { dMSReferenceLibraryEntity.CurrentFileName = reader.GetString(FLD_CURRENTFILENAME); }
            if (reader.IsDBNull(FLD_FILETYPE)) { dMSReferenceLibraryEntity.FileType = String.Empty; } else { dMSReferenceLibraryEntity.FileType = reader.GetString(FLD_FILETYPE); }

            return dMSReferenceLibraryEntity;
        }
    }
}
