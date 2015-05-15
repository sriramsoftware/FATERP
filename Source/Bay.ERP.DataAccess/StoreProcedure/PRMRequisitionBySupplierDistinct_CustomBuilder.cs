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
    internal sealed class PRMRequisitionBySupplierDistinct_CustomBuilder : IEntityBuilder<PRMRequisitionBySupplierDistinct_CustomEntity>
    {
        IList<PRMRequisitionBySupplierDistinct_CustomEntity> IEntityBuilder<PRMRequisitionBySupplierDistinct_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMRequisitionBySupplierDistinct_CustomEntity> PRMRequisitionBySupplierDistinct_CustomEntityList = new List<PRMRequisitionBySupplierDistinct_CustomEntity>();

            while (reader.Read())
            {
                PRMRequisitionBySupplierDistinct_CustomEntityList.Add(((IEntityBuilder<PRMRequisitionBySupplierDistinct_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMRequisitionBySupplierDistinct_CustomEntityList.Count > 0) ? PRMRequisitionBySupplierDistinct_CustomEntityList : null;
        }

        PRMRequisitionBySupplierDistinct_CustomEntity IEntityBuilder<PRMRequisitionBySupplierDistinct_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REQUISITIONID = 0;
            const Int32 FLD_REQUISITIONNO = 1;
            const Int32 FLD_SUPPLIERID = 2;

            PRMRequisitionBySupplierDistinct_CustomEntity pRMRequisitionBySupplierDistinct_CustomEntity = new PRMRequisitionBySupplierDistinct_CustomEntity();

            pRMRequisitionBySupplierDistinct_CustomEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { pRMRequisitionBySupplierDistinct_CustomEntity.RequisitionNo = String.Empty; } else { pRMRequisitionBySupplierDistinct_CustomEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            pRMRequisitionBySupplierDistinct_CustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);

            return pRMRequisitionBySupplierDistinct_CustomEntity;
        }
    }
}
