// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Jul-2013, 09:56:00




using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;
using Bay.ERP.DataAccess;

namespace Bay.ERP.DataAccess
{
    internal sealed partial class CRMSurvey_RPTDataAccess : BaseDataAccess, ICRMSurvey_RPTDataAccess
    {
        #region Constructors

        public CRMSurvey_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMSurvey_RPTEntity> CreateEntityBuilder<CRMSurvey_RPTEntity>()
        {
            return (new CRMSurvey_RPTBuilder()) as IEntityBuilder<CRMSurvey_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<CRMSurvey_RPTEntity> ICRMSurvey_RPTDataAccess.GetIL(Int64 surveyOwnerID)
        {
            try
            {
                const string SP = "dbo.CRMSurvey_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@SurveyOwnerID", DbType.Int64, surveyOwnerID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMSurvey_RPTEntity> list = CreateEntityBuilder<CRMSurvey_RPTEntity>().BuildEntities(reader);

                        if (list != null && list.Count > 0)
                        {
                            if ((reader.NextResult()) && (reader.Read()))
                            {
                                list[0].TotalRowCount = reader.GetInt32(0);
                            }
                        }

                        return list;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        DataTable ICRMSurvey_RPTDataAccess.GetDT(Int64 surveyOwnerID)
        {
            try
            {
                const string SP = "dbo.CRMSurvey_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@SurveyOwnerID", DbType.Int64, surveyOwnerID);

                    DataSet ds = new DataSet();
                    ds = Database.ExecuteDataSet(cmd);

                    if (ds.Tables.Count > 0)
                    {
                        return (ds.Tables[0]);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
