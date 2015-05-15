// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-May-2012, 05:15:27




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
    internal sealed partial class OTUpcomingIssue_RPTDataAccess : BaseDataAccess, IOTUpcomingIssue_RPTDataAccess
    {
        #region Constructors

        public OTUpcomingIssue_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<OTUpcomingIssue_RPTEntity> CreateEntityBuilder<OTUpcomingIssue_RPTEntity>()
        {
            return (new OTUpcomingIssue_RPTBuilder()) as IEntityBuilder<OTUpcomingIssue_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<OTUpcomingIssue_RPTEntity> IOTUpcomingIssue_RPTDataAccess.GetIL()
        {
            try
            {
                const string SP = "dbo.OTUpcomingIssue_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<OTUpcomingIssue_RPTEntity> list = CreateEntityBuilder<OTUpcomingIssue_RPTEntity>().BuildEntities(reader);

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

        DataTable IOTUpcomingIssue_RPTDataAccess.GetDT()
        {
            try
            {
                const string SP = "dbo.OTUpcomingIssue_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

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
