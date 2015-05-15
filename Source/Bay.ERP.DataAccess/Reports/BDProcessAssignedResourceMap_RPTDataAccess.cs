// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Jul-2013, 01:40:47




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
    internal sealed partial class BDProcessAssignedResourceMap_RPTDataAccess : BaseDataAccess, IBDProcessAssignedResourceMap_RPTDataAccess
    {
        #region Constructors

        public BDProcessAssignedResourceMap_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProcessAssignedResourceMap_RPTEntity> CreateEntityBuilder<BDProcessAssignedResourceMap_RPTEntity>()
        {
            return (new BDProcessAssignedResourceMap_RPTBuilder()) as IEntityBuilder<BDProcessAssignedResourceMap_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<BDProcessAssignedResourceMap_RPTEntity> IBDProcessAssignedResourceMap_RPTDataAccess.GetIL(Int64 processAssignedResourceMapID)
        {
            try
            {
                const string SP = "dbo.BDProcessAssignedResourceMap_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ProcessAssignedResourceMapID", DbType.Int64, processAssignedResourceMapID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProcessAssignedResourceMap_RPTEntity> list = CreateEntityBuilder<BDProcessAssignedResourceMap_RPTEntity>().BuildEntities(reader);

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

        DataTable IBDProcessAssignedResourceMap_RPTDataAccess.GetDT(Int64 processAssignedResourceMapID)
        {
            try
            {
                const string SP = "dbo.BDProcessAssignedResourceMap_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ProcessAssignedResourceMapID", DbType.Int64, processAssignedResourceMapID);	

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
