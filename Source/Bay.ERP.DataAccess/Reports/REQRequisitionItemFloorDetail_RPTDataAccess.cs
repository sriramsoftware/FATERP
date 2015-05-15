// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Aug-2013, 03:30:14




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
    internal sealed partial class REQRequisitionItemFloorDetail_RPTDataAccess : BaseDataAccess, IREQRequisitionItemFloorDetail_RPTDataAccess
    {
        #region Constructors

        public REQRequisitionItemFloorDetail_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<REQRequisitionItemFloorDetail_RPTEntity> CreateEntityBuilder<REQRequisitionItemFloorDetail_RPTEntity>()
        {
            return (new REQRequisitionItemFloorDetail_RPTBuilder()) as IEntityBuilder<REQRequisitionItemFloorDetail_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<REQRequisitionItemFloorDetail_RPTEntity> IREQRequisitionItemFloorDetail_RPTDataAccess.GetIL(Int64 requisitionID)
        {
            try
            {
                const string SP = "dbo.REQRequisitionItemFloorDetail_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, requisitionID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<REQRequisitionItemFloorDetail_RPTEntity> list = CreateEntityBuilder<REQRequisitionItemFloorDetail_RPTEntity>().BuildEntities(reader);

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

        DataTable IREQRequisitionItemFloorDetail_RPTDataAccess.GetDT(Int64 requisitionID)
        {
            try
            {
                const string SP = "dbo.REQRequisitionItemFloorDetail_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, requisitionID);	

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
