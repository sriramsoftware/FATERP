// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Dec-2013, 10:06:11




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
    internal sealed partial class HREmployeeEvaluationReport_RPTDataAccess : BaseDataAccess, IHREmployeeEvaluationReport_RPTDataAccess
    {
        #region Constructors

        public HREmployeeEvaluationReport_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeEvaluationReport_RPTEntity> CreateEntityBuilder<HREmployeeEvaluationReport_RPTEntity>()
        {
            return (new HREmployeeEvaluationReport_RPTBuilder()) as IEntityBuilder<HREmployeeEvaluationReport_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<HREmployeeEvaluationReport_RPTEntity> IHREmployeeEvaluationReport_RPTDataAccess.GetIL(Int64 employeeID, Int64 sessionID)
        {
            try
            {
                const string SP = "dbo.HREmployeeEvaluationReport_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, employeeID);	
				    Database.AddInParameter(cmd, "@SessionID", DbType.Int64, sessionID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeEvaluationReport_RPTEntity> list = CreateEntityBuilder<HREmployeeEvaluationReport_RPTEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeEvaluationReport_RPTDataAccess.GetDT(Int64 employeeID, Int64 sessionID)
        {
            try
            {
                const string SP = "dbo.HREmployeeEvaluationReport_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, employeeID);	
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
