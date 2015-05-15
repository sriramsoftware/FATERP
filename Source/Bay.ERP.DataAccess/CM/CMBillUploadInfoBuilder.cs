// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2012, 11:26:30




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMBillUploadInfoBuilder : IEntityBuilder<CMBillUploadInfoEntity>
    {
        IList<CMBillUploadInfoEntity> IEntityBuilder<CMBillUploadInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<CMBillUploadInfoEntity> CMBillUploadInfoEntityList = new List<CMBillUploadInfoEntity>();

            while (reader.Read())
            {
                CMBillUploadInfoEntityList.Add(((IEntityBuilder<CMBillUploadInfoEntity>)this).BuildEntity(reader));
            }

            return (CMBillUploadInfoEntityList.Count > 0) ? CMBillUploadInfoEntityList : null;
        }

        CMBillUploadInfoEntity IEntityBuilder<CMBillUploadInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BILLUPLOADINFOID = 0;
            const Int32 FLD_BILLID = 1;
            const Int32 FLD_EXTENSION = 2;
            const Int32 FLD_REMARKS = 3;
            const Int32 FLD_PATH = 4;
            const Int32 FLD_ORIGINALFILENAME = 5;
            const Int32 FLD_CURRENTFILENAME = 6;
            const Int32 FLD_FILETYPE = 7;

            CMBillUploadInfoEntity cMBillUploadInfoEntity = new CMBillUploadInfoEntity();

            cMBillUploadInfoEntity.BillUploadInfoID = reader.GetInt64(FLD_BILLUPLOADINFOID);
            cMBillUploadInfoEntity.BillID = reader.GetInt64(FLD_BILLID);
            cMBillUploadInfoEntity.Extension = reader.GetString(FLD_EXTENSION);
            if (reader.IsDBNull(FLD_REMARKS)) { cMBillUploadInfoEntity.Remarks = String.Empty; } else { cMBillUploadInfoEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cMBillUploadInfoEntity.Path = reader.GetString(FLD_PATH);
            cMBillUploadInfoEntity.OriginalFileName = reader.GetString(FLD_ORIGINALFILENAME);
            cMBillUploadInfoEntity.CurrentFileName = reader.GetString(FLD_CURRENTFILENAME);
            cMBillUploadInfoEntity.FileType = reader.GetString(FLD_FILETYPE);

            return cMBillUploadInfoEntity;
        }
    }
}
