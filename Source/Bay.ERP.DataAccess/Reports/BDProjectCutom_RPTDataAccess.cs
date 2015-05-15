// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Jun-2013, 04:10:14




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
    internal sealed partial class BDProjectCutom_RPTDataAccess : BaseDataAccess, IBDProjectCutom_RPTDataAccess
    {
        #region Constructors

        public BDProjectCutom_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProjectCutom_RPTEntity> CreateEntityBuilder<BDProjectCutom_RPTEntity>()
        {
            return (new BDProjectCutom_RPTBuilder()) as IEntityBuilder<BDProjectCutom_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<BDProjectCutom_RPTEntity> IBDProjectCutom_RPTDataAccess.GetIL(Int64 projectID)
        {
            try
            {
                const string SP = "dbo.BDProjectCutom_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, projectID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProjectCutom_RPTEntity> list = CreateEntityBuilder<BDProjectCutom_RPTEntity>().BuildEntities(reader);

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

        DataTable IBDProjectCutom_RPTDataAccess.GetDT(Int64 projectID)
        {
            try
            {
                const string SP = "dbo.BDProjectCutom_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, projectID);	

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
