// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 03:53:48




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class APFeedbackBuilder : IEntityBuilder<APFeedbackEntity>
    {
        IList<APFeedbackEntity> IEntityBuilder<APFeedbackEntity>.BuildEntities(IDataReader reader)
        {
            List<APFeedbackEntity> APFeedbackEntityList = new List<APFeedbackEntity>();

            while (reader.Read())
            {
                APFeedbackEntityList.Add(((IEntityBuilder<APFeedbackEntity>)this).BuildEntity(reader));
            }

            return (APFeedbackEntityList.Count > 0) ? APFeedbackEntityList : null;
        }

        APFeedbackEntity IEntityBuilder<APFeedbackEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APFEEDBACKID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            APFeedbackEntity aPFeedbackEntity = new APFeedbackEntity();

            aPFeedbackEntity.APFeedbackID = reader.GetInt64(FLD_APFEEDBACKID);
            aPFeedbackEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aPFeedbackEntity.Description = String.Empty; } else { aPFeedbackEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aPFeedbackEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aPFeedbackEntity;
        }
    }
}
