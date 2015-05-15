// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jun-2012, 11:27:18




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
    internal sealed partial class OTResourceIssueSchedule_CustomDataAccess : BaseDataAccess, IOTResourceIssueSchedule_CustomDataAccess
    {
        #region Constructors

        public OTResourceIssueSchedule_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<OTResourceIssueSchedule_CustomEntity> CreateEntityBuilder<OTResourceIssueSchedule_CustomEntity>()
        {
            return (new OTResourceIssueSchedule_CustomBuilder()) as IEntityBuilder<OTResourceIssueSchedule_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<OTResourceIssueSchedule_CustomEntity> IOTResourceIssueSchedule_CustomDataAccess.GetIL(Int64 resourceID, Int64 resourceCategoryID)
        {
            try
            {
                const string SP = "dbo.OTResourceIssueSchedule_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ResourceID", DbType.Int64, resourceID);	
				    Database.AddInParameter(cmd, "@ResourceCategoryID", DbType.Int64, resourceCategoryID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<OTResourceIssueSchedule_CustomEntity> list = CreateEntityBuilder<OTResourceIssueSchedule_CustomEntity>().BuildEntities(reader);

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

        DataTable IOTResourceIssueSchedule_CustomDataAccess.GetDT(Int64 resourceID, Int64 resourceCategoryID)
        {
            try
            {
                const string SP = "dbo.OTResourceIssueSchedule_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ResourceID", DbType.Int64, resourceID);	
				    Database.AddInParameter(cmd, "@ResourceCategoryID", DbType.Int64, resourceCategoryID);	

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
