// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Oct-2012, 11:18:20




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
    internal sealed partial class PRMWorkOrderItemByWorkOrder_CustomDataAccess : BaseDataAccess, IPRMWorkOrderItemByWorkOrder_CustomDataAccess
    {
        #region Constructors

        public PRMWorkOrderItemByWorkOrder_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMWorkOrderItemByWorkOrder_CustomEntity> CreateEntityBuilder<PRMWorkOrderItemByWorkOrder_CustomEntity>()
        {
            return (new PRMWorkOrderItemByWorkOrder_CustomBuilder()) as IEntityBuilder<PRMWorkOrderItemByWorkOrder_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<PRMWorkOrderItemByWorkOrder_CustomEntity> IPRMWorkOrderItemByWorkOrder_CustomDataAccess.GetIL(Int64 workOrderID)
        {
            try
            {
                const string SP = "dbo.PRMWorkOrderItemByWorkOrder_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, workOrderID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMWorkOrderItemByWorkOrder_CustomEntity> list = CreateEntityBuilder<PRMWorkOrderItemByWorkOrder_CustomEntity>().BuildEntities(reader);

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

        DataTable IPRMWorkOrderItemByWorkOrder_CustomDataAccess.GetDT(Int64 workOrderID)
        {
            try
            {
                const string SP = "dbo.PRMWorkOrderItemByWorkOrder_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, workOrderID);	

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
