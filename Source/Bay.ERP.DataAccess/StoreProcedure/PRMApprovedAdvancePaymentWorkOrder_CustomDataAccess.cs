// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2013, 11:05:44




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
    internal sealed partial class PRMApprovedAdvancePaymentWorkOrder_CustomDataAccess : BaseDataAccess, IPRMApprovedAdvancePaymentWorkOrder_CustomDataAccess
    {
        #region Constructors

        public PRMApprovedAdvancePaymentWorkOrder_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMApprovedAdvancePaymentWorkOrder_CustomEntity> CreateEntityBuilder<PRMApprovedAdvancePaymentWorkOrder_CustomEntity>()
        {
            return (new PRMApprovedAdvancePaymentWorkOrder_CustomBuilder()) as IEntityBuilder<PRMApprovedAdvancePaymentWorkOrder_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<PRMApprovedAdvancePaymentWorkOrder_CustomEntity> IPRMApprovedAdvancePaymentWorkOrder_CustomDataAccess.GetIL()
        {
            try
            {
                const string SP = "dbo.PRMApprovedAdvancePaymentWorkOrder_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMApprovedAdvancePaymentWorkOrder_CustomEntity> list = CreateEntityBuilder<PRMApprovedAdvancePaymentWorkOrder_CustomEntity>().BuildEntities(reader);

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

        DataTable IPRMApprovedAdvancePaymentWorkOrder_CustomDataAccess.GetDT()
        {
            try
            {
                const string SP = "dbo.PRMApprovedAdvancePaymentWorkOrder_Custom";

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
