// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Apr-2013, 12:14:24




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMMDPaymentCategoryBuilder : IEntityBuilder<CRMMDPaymentCategoryEntity>
    {
        IList<CRMMDPaymentCategoryEntity> IEntityBuilder<CRMMDPaymentCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMMDPaymentCategoryEntity> CRMMDPaymentCategoryEntityList = new List<CRMMDPaymentCategoryEntity>();

            while (reader.Read())
            {
                CRMMDPaymentCategoryEntityList.Add(((IEntityBuilder<CRMMDPaymentCategoryEntity>)this).BuildEntity(reader));
            }

            return (CRMMDPaymentCategoryEntityList.Count > 0) ? CRMMDPaymentCategoryEntityList : null;
        }

        CRMMDPaymentCategoryEntity IEntityBuilder<CRMMDPaymentCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PAYMENTCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            CRMMDPaymentCategoryEntity cRMMDPaymentCategoryEntity = new CRMMDPaymentCategoryEntity();

            cRMMDPaymentCategoryEntity.PaymentCategoryID = reader.GetInt64(FLD_PAYMENTCATEGORYID);
            cRMMDPaymentCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cRMMDPaymentCategoryEntity.Description = String.Empty; } else { cRMMDPaymentCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cRMMDPaymentCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cRMMDPaymentCategoryEntity;
        }
    }
}
