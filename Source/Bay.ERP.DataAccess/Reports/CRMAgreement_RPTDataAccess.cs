// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2013, 01:42:12




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
    internal sealed partial class CRMAgreement_RPTDataAccess : BaseDataAccess, ICRMAgreement_RPTDataAccess
    {
        #region Constructors

        public CRMAgreement_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMAgreement_RPTEntity> CreateEntityBuilder<CRMAgreement_RPTEntity>()
        {
            return (new CRMAgreement_RPTBuilder()) as IEntityBuilder<CRMAgreement_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<CRMAgreement_RPTEntity> ICRMAgreement_RPTDataAccess.GetIL(Int64 agreementID)
        {
            try
            {
                const string SP = "dbo.CRMAgreement_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@AgreementID", DbType.Int64, agreementID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMAgreement_RPTEntity> list = CreateEntityBuilder<CRMAgreement_RPTEntity>().BuildEntities(reader);

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

        DataTable ICRMAgreement_RPTDataAccess.GetDT(Int64 agreementID)
        {
            try
            {
                const string SP = "dbo.CRMAgreement_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@AgreementID", DbType.Int64, agreementID);	

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
