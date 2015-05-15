// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Dec-2012, 08:03:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDACCPayablePaymentStatusBuilder : IEntityBuilder<MDACCPayablePaymentStatusEntity>
    {
        IList<MDACCPayablePaymentStatusEntity> IEntityBuilder<MDACCPayablePaymentStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDACCPayablePaymentStatusEntity> MDACCPayablePaymentStatusEntityList = new List<MDACCPayablePaymentStatusEntity>();

            while (reader.Read())
            {
                MDACCPayablePaymentStatusEntityList.Add(((IEntityBuilder<MDACCPayablePaymentStatusEntity>)this).BuildEntity(reader));
            }

            return (MDACCPayablePaymentStatusEntityList.Count > 0) ? MDACCPayablePaymentStatusEntityList : null;
        }

        MDACCPayablePaymentStatusEntity IEntityBuilder<MDACCPayablePaymentStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ACCPAYABLEPAYMENTSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDACCPayablePaymentStatusEntity mDACCPayablePaymentStatusEntity = new MDACCPayablePaymentStatusEntity();

            mDACCPayablePaymentStatusEntity.ACCPayablePaymentStatusID = reader.GetInt64(FLD_ACCPAYABLEPAYMENTSTATUSID);
            mDACCPayablePaymentStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDACCPayablePaymentStatusEntity.Description = String.Empty; } else { mDACCPayablePaymentStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDACCPayablePaymentStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDACCPayablePaymentStatusEntity;
        }
    }
}
