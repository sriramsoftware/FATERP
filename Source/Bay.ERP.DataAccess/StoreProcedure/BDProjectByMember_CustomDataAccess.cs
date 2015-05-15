// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jul-2012, 02:14:35




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
    internal sealed partial class BDProjectByMember_CustomDataAccess : BaseDataAccess, IBDProjectByMember_CustomDataAccess
    {
        #region Constructors

        public BDProjectByMember_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProjectByMember_CustomEntity> CreateEntityBuilder<BDProjectByMember_CustomEntity>()
        {
            return (new BDProjectByMember_CustomBuilder()) as IEntityBuilder<BDProjectByMember_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<BDProjectByMember_CustomEntity> IBDProjectByMember_CustomDataAccess.GetIL(Int64 memberID)
        {
            try
            {
                const string SP = "dbo.BDProjectByMember_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@MemberID", DbType.Int64, memberID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProjectByMember_CustomEntity> list = CreateEntityBuilder<BDProjectByMember_CustomEntity>().BuildEntities(reader);

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

        DataTable IBDProjectByMember_CustomDataAccess.GetDT(Int64 memberID)
        {
            try
            {
                const string SP = "dbo.BDProjectByMember_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@MemberID", DbType.Int64, memberID);	

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
