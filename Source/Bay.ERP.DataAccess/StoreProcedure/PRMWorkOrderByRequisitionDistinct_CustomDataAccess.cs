// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Jul-2012, 03:56:56




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
    internal sealed partial class PRMWorkOrderByRequisitionDistinct_CustomDataAccess : BaseDataAccess, IPRMWorkOrderByRequisitionDistinct_CustomDataAccess
    {
        #region Constructors

        public PRMWorkOrderByRequisitionDistinct_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMWorkOrderByRequisitionDistinct_CustomEntity> CreateEntityBuilder<PRMWorkOrderByRequisitionDistinct_CustomEntity>()
        {
            return (new PRMWorkOrderByRequisitionDistinct_CustomBuilder()) as IEntityBuilder<PRMWorkOrderByRequisitionDistinct_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<PRMWorkOrderByRequisitionDistinct_CustomEntity> IPRMWorkOrderByRequisitionDistinct_CustomDataAccess.GetIL(Int64 requisitionID)
        {
            try
            {
                const string SP = "dbo.PRMWorkOrderByRequisitionDistinct_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, requisitionID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMWorkOrderByRequisitionDistinct_CustomEntity> list = CreateEntityBuilder<PRMWorkOrderByRequisitionDistinct_CustomEntity>().BuildEntities(reader);

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

        DataTable IPRMWorkOrderByRequisitionDistinct_CustomDataAccess.GetDT(Int64 requisitionID)
        {
            try
            {
                const string SP = "dbo.PRMWorkOrderByRequisitionDistinct_Custom";

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
