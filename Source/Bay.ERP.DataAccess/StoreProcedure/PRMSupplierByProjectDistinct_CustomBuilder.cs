// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Jul-2012, 03:56:56




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMSupplierByProjectDistinct_CustomBuilder : IEntityBuilder<PRMSupplierByProjectDistinct_CustomEntity>
    {
        IList<PRMSupplierByProjectDistinct_CustomEntity> IEntityBuilder<PRMSupplierByProjectDistinct_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMSupplierByProjectDistinct_CustomEntity> PRMSupplierByProjectDistinct_CustomEntityList = new List<PRMSupplierByProjectDistinct_CustomEntity>();

            while (reader.Read())
            {
                PRMSupplierByProjectDistinct_CustomEntityList.Add(((IEntityBuilder<PRMSupplierByProjectDistinct_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMSupplierByProjectDistinct_CustomEntityList.Count > 0) ? PRMSupplierByProjectDistinct_CustomEntityList : null;
        }

        PRMSupplierByProjectDistinct_CustomEntity IEntityBuilder<PRMSupplierByProjectDistinct_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SUPPLIERID = 0;
            const Int32 FLD_SUPPLIERNAME = 1;
            const Int32 FLD_PROJECTID = 2;

            PRMSupplierByProjectDistinct_CustomEntity pRMSupplierByProjectDistinct_CustomEntity = new PRMSupplierByProjectDistinct_CustomEntity();

            pRMSupplierByProjectDistinct_CustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { pRMSupplierByProjectDistinct_CustomEntity.SupplierName = String.Empty; } else { pRMSupplierByProjectDistinct_CustomEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_PROJECTID)) { pRMSupplierByProjectDistinct_CustomEntity.ProjectID = null; } else { pRMSupplierByProjectDistinct_CustomEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }

            return pRMSupplierByProjectDistinct_CustomEntity;
        }
    }
}
