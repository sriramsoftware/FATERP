// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-May-2013, 04:56:23




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
    internal sealed partial class CRMBookingStatus_RPTDataAccess : BaseDataAccess, ICRMBookingStatus_RPTDataAccess
    {
        #region Constructors

        public CRMBookingStatus_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMBookingStatus_RPTEntity> CreateEntityBuilder<CRMBookingStatus_RPTEntity>()
        {
            return (new CRMBookingStatus_RPTBuilder()) as IEntityBuilder<CRMBookingStatus_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<CRMBookingStatus_RPTEntity> ICRMBookingStatus_RPTDataAccess.GetIL()
        {
            try
            {
                const string SP = "dbo.CRMBookingStatus_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMBookingStatus_RPTEntity> list = CreateEntityBuilder<CRMBookingStatus_RPTEntity>().BuildEntities(reader);

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

        DataTable ICRMBookingStatus_RPTDataAccess.GetDT()
        {
            try
            {
                const string SP = "dbo.CRMBookingStatus_RPT";

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
