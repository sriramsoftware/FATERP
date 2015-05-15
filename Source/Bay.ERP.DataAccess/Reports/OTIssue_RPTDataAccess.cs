// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Jan-2013, 12:26:55




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
    internal sealed partial class OTIssue_RPTDataAccess : BaseDataAccess, IOTIssue_RPTDataAccess
    {
        #region Constructors

        public OTIssue_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<OTIssue_RPTEntity> CreateEntityBuilder<OTIssue_RPTEntity>()
        {
            return (new OTIssue_RPTBuilder()) as IEntityBuilder<OTIssue_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<OTIssue_RPTEntity> IOTIssue_RPTDataAccess.GetIL(Int64 issueID)
        {
            try
            {
                const string SP = "dbo.OTIssue_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@IssueID", DbType.Int64, issueID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<OTIssue_RPTEntity> list = CreateEntityBuilder<OTIssue_RPTEntity>().BuildEntities(reader);

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

        DataTable IOTIssue_RPTDataAccess.GetDT(Int64 issueID)
        {
            try
            {
                const string SP = "dbo.OTIssue_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@IssueID", DbType.Int64, issueID);	

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
