// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jan-2012, 06:06:50




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMConstructionToolDetailBuilder : IEntityBuilder<CMConstructionToolDetailEntity>
    {
        IList<CMConstructionToolDetailEntity> IEntityBuilder<CMConstructionToolDetailEntity>.BuildEntities(IDataReader reader)
        {
            List<CMConstructionToolDetailEntity> CMConstructionToolDetailEntityList = new List<CMConstructionToolDetailEntity>();

            while (reader.Read())
            {
                CMConstructionToolDetailEntityList.Add(((IEntityBuilder<CMConstructionToolDetailEntity>)this).BuildEntity(reader));
            }

            return (CMConstructionToolDetailEntityList.Count > 0) ? CMConstructionToolDetailEntityList : null;
        }

        CMConstructionToolDetailEntity IEntityBuilder<CMConstructionToolDetailEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONSTRUCTIONTOOLDETAILID = 0;
            const Int32 FLD_CONSTRUCTIONTOOLID = 1;
            const Int32 FLD_SPECIFICATION = 2;
            const Int32 FLD_CONSTRUCTIONTOOLWORKINGCONDITIONID = 3;
            const Int32 FLD_BRANDID = 4;
            const Int32 FLD_SUPPLIERID = 5;
            const Int32 FLD_NEXTMAINTANANCEDATE = 6;
            const Int32 FLD_USEDORHANDELEDBY = 7;
            const Int32 FLD_PROJECTID = 8;
            const Int32 FLD_REMARKS = 9;
            const Int32 FLD_ISREMOVED = 10;

            CMConstructionToolDetailEntity cMConstructionToolDetailEntity = new CMConstructionToolDetailEntity();

            cMConstructionToolDetailEntity.ConstructionToolDetailID = reader.GetInt64(FLD_CONSTRUCTIONTOOLDETAILID);
            cMConstructionToolDetailEntity.ConstructionToolID = reader.GetInt64(FLD_CONSTRUCTIONTOOLID);
            cMConstructionToolDetailEntity.Specification = reader.GetString(FLD_SPECIFICATION);
            cMConstructionToolDetailEntity.ConstructionToolWorkingConditionID = reader.GetInt64(FLD_CONSTRUCTIONTOOLWORKINGCONDITIONID);
            if (reader.IsDBNull(FLD_BRANDID)) { cMConstructionToolDetailEntity.BrandID = null; } else { cMConstructionToolDetailEntity.BrandID = reader.GetInt64(FLD_BRANDID); }
            if (reader.IsDBNull(FLD_SUPPLIERID)) { cMConstructionToolDetailEntity.SupplierID = null; } else { cMConstructionToolDetailEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID); }
            if (reader.IsDBNull(FLD_NEXTMAINTANANCEDATE)) { cMConstructionToolDetailEntity.NextMaintananceDate = null; } else { cMConstructionToolDetailEntity.NextMaintananceDate = reader.GetDateTime(FLD_NEXTMAINTANANCEDATE); }
            if (reader.IsDBNull(FLD_USEDORHANDELEDBY)) { cMConstructionToolDetailEntity.UsedOrHandeledBy = String.Empty; } else { cMConstructionToolDetailEntity.UsedOrHandeledBy = reader.GetString(FLD_USEDORHANDELEDBY); }
            if (reader.IsDBNull(FLD_PROJECTID)) { cMConstructionToolDetailEntity.ProjectID = null; } else { cMConstructionToolDetailEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_REMARKS)) { cMConstructionToolDetailEntity.Remarks = String.Empty; } else { cMConstructionToolDetailEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cMConstructionToolDetailEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cMConstructionToolDetailEntity;
        }
    }
}
