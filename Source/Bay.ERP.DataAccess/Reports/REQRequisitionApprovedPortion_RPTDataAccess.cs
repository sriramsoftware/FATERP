// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jul-2012, 11:43:31




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
    internal sealed partial class REQRequisitionApprovedPortion_RPTDataAccess : BaseDataAccess, IREQRequisitionApprovedPortion_RPTDataAccess
    {
        #region Constructors

        public REQRequisitionApprovedPortion_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<REQRequisitionApprovedPortion_RPTEntity> CreateEntityBuilder<REQRequisitionApprovedPortion_RPTEntity>()
        {
            return (new REQRequisitionApprovedPortion_RPTBuilder()) as IEntityBuilder<REQRequisitionApprovedPortion_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<REQRequisitionApprovedPortion_RPTEntity> IREQRequisitionApprovedPortion_RPTDataAccess.GetIL(Int64 projectID)
        {
            try
            {
                const string SP = "dbo.REQRequisitionApprovedPortion_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, projectID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<REQRequisitionApprovedPortion_RPTEntity> list = CreateEntityBuilder<REQRequisitionApprovedPortion_RPTEntity>().BuildEntities(reader);

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

        DataTable IREQRequisitionApprovedPortion_RPTDataAccess.GetDT(Int64 projectID)
        {
            try
            {
                const string SP = "dbo.REQRequisitionApprovedPortion_RPT";

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
