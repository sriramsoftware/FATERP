// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Jul-2012, 03:04:56




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
    internal sealed partial class PRMWorkOrderPaymentTerm_RPTDataAccess : BaseDataAccess, IPRMWorkOrderPaymentTerm_RPTDataAccess
    {
        #region Constructors

        public PRMWorkOrderPaymentTerm_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMWorkOrderPaymentTerm_RPTEntity> CreateEntityBuilder<PRMWorkOrderPaymentTerm_RPTEntity>()
        {
            return (new PRMWorkOrderPaymentTerm_RPTBuilder()) as IEntityBuilder<PRMWorkOrderPaymentTerm_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<PRMWorkOrderPaymentTerm_RPTEntity> IPRMWorkOrderPaymentTerm_RPTDataAccess.GetIL(Int64 workOrderID)
        {
            try
            {
                const string SP = "dbo.PRMWorkOrderPaymentTerm_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, workOrderID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMWorkOrderPaymentTerm_RPTEntity> list = CreateEntityBuilder<PRMWorkOrderPaymentTerm_RPTEntity>().BuildEntities(reader);

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

        DataTable IPRMWorkOrderPaymentTerm_RPTDataAccess.GetDT(Int64 workOrderID)
        {
            try
            {
                const string SP = "dbo.PRMWorkOrderPaymentTerm_RPT";

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
