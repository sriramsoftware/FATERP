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
    internal sealed class REQRequisitionUploadInfoBuilder : IEntityBuilder<REQRequisitionUploadInfoEntity>
    {
        IList<REQRequisitionUploadInfoEntity> IEntityBuilder<REQRequisitionUploadInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<REQRequisitionUploadInfoEntity> REQRequisitionUploadInfoEntityList = new List<REQRequisitionUploadInfoEntity>();

            while (reader.Read())
            {
                REQRequisitionUploadInfoEntityList.Add(((IEntityBuilder<REQRequisitionUploadInfoEntity>)this).BuildEntity(reader));
            }

            return (REQRequisitionUploadInfoEntityList.Count > 0) ? REQRequisitionUploadInfoEntityList : null;
        }

        REQRequisitionUploadInfoEntity IEntityBuilder<REQRequisitionUploadInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REQUISITIONUPLOADINFOID = 0;
            const Int32 FLD_REQUISITIONID = 1;
            const Int32 FLD_EXTENSION = 2;
            const Int32 FLD_REMARKS = 3;
            const Int32 FLD_PATH = 4;
            const Int32 FLD_ORIGINALFILENAME = 5;
            const Int32 FLD_CURRENTFILENAME = 6;
            const Int32 FLD_FILETYPE = 7;

            REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity = new REQRequisitionUploadInfoEntity();

            rEQRequisitionUploadInfoEntity.RequisitionUploadInfoID = reader.GetInt64(FLD_REQUISITIONUPLOADINFOID);
            rEQRequisitionUploadInfoEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            rEQRequisitionUploadInfoEntity.Extension = reader.GetString(FLD_EXTENSION);
            if (reader.IsDBNull(FLD_REMARKS)) { rEQRequisitionUploadInfoEntity.Remarks = String.Empty; } else { rEQRequisitionUploadInfoEntity.Remarks = reader.GetString(FLD_REMARKS); }
            rEQRequisitionUploadInfoEntity.Path = reader.GetString(FLD_PATH);
            rEQRequisitionUploadInfoEntity.OriginalFileName = reader.GetString(FLD_ORIGINALFILENAME);
            rEQRequisitionUploadInfoEntity.CurrentFileName = reader.GetString(FLD_CURRENTFILENAME);
            rEQRequisitionUploadInfoEntity.FileType = reader.GetString(FLD_FILETYPE);

            return rEQRequisitionUploadInfoEntity;
        }
    }
}
