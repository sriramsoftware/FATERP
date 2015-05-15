// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Sep-2013, 12:39:02




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
    internal sealed partial class HREvaluation_RPTDataAccess : BaseDataAccess, IHREvaluation_RPTDataAccess
    {
        #region Constructors

        public HREvaluation_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREvaluation_RPTEntity> CreateEntityBuilder<HREvaluation_RPTEntity>()
        {
            return (new HREvaluation_RPTBuilder()) as IEntityBuilder<HREvaluation_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<HREvaluation_RPTEntity> IHREvaluation_RPTDataAccess.GetIL(Int64 employeeID, Int64 sessionID)
        {
            try
            {
                const string SP = "dbo.HREvaluation_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, employeeID);	
				    Database.AddInParameter(cmd, "@SessionID", DbType.Int64, sessionID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREvaluation_RPTEntity> list = CreateEntityBuilder<HREvaluation_RPTEntity>().BuildEntities(reader);

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

        DataTable IHREvaluation_RPTDataAccess.GetDT(Int64 employeeID, Int64 sessionID)
        {
            try
            {
                const string SP = "dbo.HREvaluation_RPT";

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
