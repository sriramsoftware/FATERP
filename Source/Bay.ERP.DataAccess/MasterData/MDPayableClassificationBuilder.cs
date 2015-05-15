// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDPayableClassificationBuilder : IEntityBuilder<MDPayableClassificationEntity>
    {
        IList<MDPayableClassificationEntity> IEntityBuilder<MDPayableClassificationEntity>.BuildEntities(IDataReader reader)
        {
            List<MDPayableClassificationEntity> MDPayableClassificationEntityList = new List<MDPayableClassificationEntity>();

            while (reader.Read())
            {
                MDPayableClassificationEntityList.Add(((IEntityBuilder<MDPayableClassificationEntity>)this).BuildEntity(reader));
            }

            return (MDPayableClassificationEntityList.Count > 0) ? MDPayableClassificationEntityList : null;
        }

        MDPayableClassificationEntity IEntityBuilder<MDPayableClassificationEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PAYABLECLASSIFICATIONID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_NARRATION = 2;
            const Int32 FLD_PAYMENTMODE = 3;
            const Int32 FLD_PAYMENTCHENNAL = 4;
            const Int32 FLD_SECURITYMONEY = 5;
            const Int32 FLD_TAXDEDUCTION = 6;
            const Int32 FLD_REMARKS = 7;
            const Int32 FLD_ISREMOVED = 8;

            MDPayableClassificationEntity mDPayableClassificationEntity = new MDPayableClassificationEntity();

            mDPayableClassificationEntity.PayableClassificationID = reader.GetInt64(FLD_PAYABLECLASSIFICATIONID);
            mDPayableClassificationEntity.Name = reader.GetString(FLD_NAME);
            mDPayableClassificationEntity.Narration = reader.GetString(FLD_NARRATION);
            mDPayableClassificationEntity.PaymentMode = reader.GetString(FLD_PAYMENTMODE);
            mDPayableClassificationEntity.PaymentChennal = reader.GetString(FLD_PAYMENTCHENNAL);
            mDPayableClassificationEntity.SecurityMoney = reader.GetString(FLD_SECURITYMONEY);
            mDPayableClassificationEntity.TaxDeduction = reader.GetString(FLD_TAXDEDUCTION);
            if (reader.IsDBNull(FLD_REMARKS)) { mDPayableClassificationEntity.Remarks = String.Empty; } else { mDPayableClassificationEntity.Remarks = reader.GetString(FLD_REMARKS); }
            mDPayableClassificationEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDPayableClassificationEntity;
        }
    }
}
