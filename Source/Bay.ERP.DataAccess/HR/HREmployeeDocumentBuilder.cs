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
    internal sealed class HREmployeeDocumentBuilder : IEntityBuilder<HREmployeeDocumentEntity>
    {
        IList<HREmployeeDocumentEntity> IEntityBuilder<HREmployeeDocumentEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeDocumentEntity> HREmployeeDocumentEntityList = new List<HREmployeeDocumentEntity>();

            while (reader.Read())
            {
                HREmployeeDocumentEntityList.Add(((IEntityBuilder<HREmployeeDocumentEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeDocumentEntityList.Count > 0) ? HREmployeeDocumentEntityList : null;
        }

        HREmployeeDocumentEntity IEntityBuilder<HREmployeeDocumentEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEDOCUMENTID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_DOCUMENTCATEGORYID = 2;
            const Int32 FLD_EXTENSION = 3;
            const Int32 FLD_REMARKS = 4;
            const Int32 FLD_PATH = 5;
            const Int32 FLD_ORIGINALFILENAME = 6;
            const Int32 FLD_CURRENTFILENAME = 7;
            const Int32 FLD_FILETYPE = 8;

            HREmployeeDocumentEntity hREmployeeDocumentEntity = new HREmployeeDocumentEntity();

            hREmployeeDocumentEntity.EmployeeDocumentID = reader.GetInt64(FLD_EMPLOYEEDOCUMENTID);
            hREmployeeDocumentEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeDocumentEntity.DocumentCategoryID = reader.GetInt64(FLD_DOCUMENTCATEGORYID);
            hREmployeeDocumentEntity.Extension = reader.GetString(FLD_EXTENSION);
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeDocumentEntity.Remarks = String.Empty; } else { hREmployeeDocumentEntity.Remarks = reader.GetString(FLD_REMARKS); }
            hREmployeeDocumentEntity.Path = reader.GetString(FLD_PATH);
            hREmployeeDocumentEntity.OriginalFileName = reader.GetString(FLD_ORIGINALFILENAME);
            hREmployeeDocumentEntity.CurrentFileName = reader.GetString(FLD_CURRENTFILENAME);
            hREmployeeDocumentEntity.FileType = reader.GetString(FLD_FILETYPE);

            return hREmployeeDocumentEntity;
        }
    }
}
