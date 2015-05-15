// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Jan-2012, 02:37:47




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
    internal sealed partial class CMProjectMilestone_CustomDataAccess : BaseDataAccess, ICMProjectMilestone_CustomDataAccess
    {
        #region Constructors

        public CMProjectMilestone_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMProjectMilestone_CustomEntity> CreateEntityBuilder<CMProjectMilestone_CustomEntity>()
        {
            return (new CMProjectMilestone_CustomBuilder()) as IEntityBuilder<CMProjectMilestone_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<CMProjectMilestone_CustomEntity> ICMProjectMilestone_CustomDataAccess.GetIL(Int64 projectID)
        {
            try
            {
                const string SP = "dbo.CMProjectMilestone_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, projectID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMProjectMilestone_CustomEntity> list = CreateEntityBuilder<CMProjectMilestone_CustomEntity>().BuildEntities(reader);

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

        DataTable ICMProjectMilestone_CustomDataAccess.GetDT(Int64 projectID)
        {
            try
            {
                const string SP = "dbo.CMProjectMilestone_Custom";

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
