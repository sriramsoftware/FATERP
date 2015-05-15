// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2013, 10:33:28




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
    internal sealed partial class CRMAdvertisementRequisition_RPTDataAccess : BaseDataAccess, ICRMAdvertisementRequisition_RPTDataAccess
    {
        #region Constructors

        public CRMAdvertisementRequisition_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMAdvertisementRequisition_RPTEntity> CreateEntityBuilder<CRMAdvertisementRequisition_RPTEntity>()
        {
            return (new CRMAdvertisementRequisition_RPTBuilder()) as IEntityBuilder<CRMAdvertisementRequisition_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<CRMAdvertisementRequisition_RPTEntity> ICRMAdvertisementRequisition_RPTDataAccess.GetIL(Int64 requisitionID)
        {
            try
            {
                const string SP = "dbo.CRMAdvertisementRequisition_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, requisitionID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMAdvertisementRequisition_RPTEntity> list = CreateEntityBuilder<CRMAdvertisementRequisition_RPTEntity>().BuildEntities(reader);

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

        DataTable ICRMAdvertisementRequisition_RPTDataAccess.GetDT(Int64 requisitionID)
        {
            try
            {
                const string SP = "dbo.CRMAdvertisementRequisition_RPT";

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
