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
    internal sealed partial class CRMSurveyMaster_RPTDataAccess : BaseDataAccess, ICRMSurveyMaster_RPTDataAccess
    {
        #region Constructors

        public CRMSurveyMaster_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMSurveyMaster_RPTEntity> CreateEntityBuilder<CRMSurveyMaster_RPTEntity>()
        {
            return (new CRMSurveyMaster_RPTBuilder()) as IEntityBuilder<CRMSurveyMaster_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<CRMSurveyMaster_RPTEntity> ICRMSurveyMaster_RPTDataAccess.GetIL(Int64 surveyMasterID)
        {
            try
            {
                const string SP = "dbo.CRMSurveyMaster_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@SurveyMasterID", DbType.Int64, surveyMasterID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMSurveyMaster_RPTEntity> list = CreateEntityBuilder<CRMSurveyMaster_RPTEntity>().BuildEntities(reader);

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

        DataTable ICRMSurveyMaster_RPTDataAccess.GetDT(Int64 surveyMasterID)
        {
            try
            {
                const string SP = "dbo.CRMSurveyMaster_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@SurveyMasterID", DbType.Int64, surveyMasterID);

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
