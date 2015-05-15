// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jan-2012, 09:58:11




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
    internal sealed partial class BDProject_RPTDataAccess : BaseDataAccess, IBDProject_RPTDataAccess
    {
        #region Constructors

        public BDProject_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProject_RPTEntity> CreateEntityBuilder<BDProject_RPTEntity>()
        {
            return (new BDProject_RPTBuilder()) as IEntityBuilder<BDProject_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<BDProject_RPTEntity> IBDProject_RPTDataAccess.GetIL(Int64 projectID)
        {
            try
            {
                const string SP = "dbo.BDProject_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, projectID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProject_RPTEntity> list = CreateEntityBuilder<BDProject_RPTEntity>().BuildEntities(reader);

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

        DataTable IBDProject_RPTDataAccess.GetDT(Int64 projectID)
        {
            try
            {
                const string SP = "dbo.BDProject_RPT";

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
