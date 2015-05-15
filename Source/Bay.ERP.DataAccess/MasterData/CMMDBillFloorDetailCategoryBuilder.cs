// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Aug-2013, 02:50:29




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMMDBillFloorDetailCategoryBuilder : IEntityBuilder<CMMDBillFloorDetailCategoryEntity>
    {
        IList<CMMDBillFloorDetailCategoryEntity> IEntityBuilder<CMMDBillFloorDetailCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<CMMDBillFloorDetailCategoryEntity> CMMDBillFloorDetailCategoryEntityList = new List<CMMDBillFloorDetailCategoryEntity>();

            while (reader.Read())
            {
                CMMDBillFloorDetailCategoryEntityList.Add(((IEntityBuilder<CMMDBillFloorDetailCategoryEntity>)this).BuildEntity(reader));
            }

            return (CMMDBillFloorDetailCategoryEntityList.Count > 0) ? CMMDBillFloorDetailCategoryEntityList : null;
        }

        CMMDBillFloorDetailCategoryEntity IEntityBuilder<CMMDBillFloorDetailCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BILLFLOORDETAILCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            CMMDBillFloorDetailCategoryEntity cMMDBillFloorDetailCategoryEntity = new CMMDBillFloorDetailCategoryEntity();

            cMMDBillFloorDetailCategoryEntity.BillFloorDetailCategoryID = reader.GetInt64(FLD_BILLFLOORDETAILCATEGORYID);
            cMMDBillFloorDetailCategoryEntity.Name = reader.GetString(FLD_NAME);
            cMMDBillFloorDetailCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cMMDBillFloorDetailCategoryEntity;
        }
    }
}
