// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Jul-2013, 09:56:00




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
    internal sealed partial class ACAccount_RPTDataAccess : BaseDataAccess, IACAccount_RPTDataAccess
    {
        #region Constructors

        public ACAccount_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACAccount_RPTEntity> CreateEntityBuilder<ACAccount_RPTEntity>()
        {
            return (new ACAccount_RPTBuilder()) as IEntityBuilder<ACAccount_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<ACAccount_RPTEntity> IACAccount_RPTDataAccess.GetIL()
        {
            try
            {
                const string SP = "dbo.ACAccount_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACAccount_RPTEntity> list = CreateEntityBuilder<ACAccount_RPTEntity>().BuildEntities(reader);

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

        DataTable IACAccount_RPTDataAccess.GetDT()
        {
            try
            {
                const string SP = "dbo.ACAccount_RPT";

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
