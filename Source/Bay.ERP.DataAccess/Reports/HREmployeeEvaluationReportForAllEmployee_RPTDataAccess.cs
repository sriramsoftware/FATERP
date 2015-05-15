// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Dec-2013, 03:16:13




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
    internal sealed partial class HREmployeeEvaluationReportForAllEmployee_RPTDataAccess : BaseDataAccess, IHREmployeeEvaluationReportForAllEmployee_RPTDataAccess
    {
        #region Constructors

        public HREmployeeEvaluationReportForAllEmployee_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeEvaluationReportForAllEmployee_RPTEntity> CreateEntityBuilder<HREmployeeEvaluationReportForAllEmployee_RPTEntity>()
        {
            return (new HREmployeeEvaluationReportForAllEmployee_RPTBuilder()) as IEntityBuilder<HREmployeeEvaluationReportForAllEmployee_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<HREmployeeEvaluationReportForAllEmployee_RPTEntity> IHREmployeeEvaluationReportForAllEmployee_RPTDataAccess.GetIL(Int64 sessionID)
        {
            try
            {
                const string SP = "dbo.HREmployeeEvaluationReportForAllEmployee_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@SessionID", DbType.Int64, sessionID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeEvaluationReportForAllEmployee_RPTEntity> list = CreateEntityBuilder<HREmployeeEvaluationReportForAllEmployee_RPTEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeEvaluationReportForAllEmployee_RPTDataAccess.GetDT(Int64 sessionID)
        {
            try
            {
                const string SP = "dbo.HREmployeeEvaluationReportForAllEmployee_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@SessionID", DbType.Int64, sessionID);	

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
