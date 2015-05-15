// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2013, 01:29:48




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
    internal sealed partial class CMApprovedBillExceptACCPrePayable_CustomDataAccess : BaseDataAccess, ICMApprovedBillExceptACCPrePayable_CustomDataAccess
    {
        #region Constructors

        public CMApprovedBillExceptACCPrePayable_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMApprovedBillExceptACCPrePayable_CustomEntity> CreateEntityBuilder<CMApprovedBillExceptACCPrePayable_CustomEntity>()
        {
            return (new CMApprovedBillExceptACCPrePayable_CustomBuilder()) as IEntityBuilder<CMApprovedBillExceptACCPrePayable_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<CMApprovedBillExceptACCPrePayable_CustomEntity> ICMApprovedBillExceptACCPrePayable_CustomDataAccess.GetIL()
        {
            try
            {
                const string SP = "dbo.CMApprovedBillExceptACCPrePayable_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMApprovedBillExceptACCPrePayable_CustomEntity> list = CreateEntityBuilder<CMApprovedBillExceptACCPrePayable_CustomEntity>().BuildEntities(reader);

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

        DataTable ICMApprovedBillExceptACCPrePayable_CustomDataAccess.GetDT()
        {
            try
            {
                const string SP = "dbo.CMApprovedBillExceptACCPrePayable_Custom";

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
