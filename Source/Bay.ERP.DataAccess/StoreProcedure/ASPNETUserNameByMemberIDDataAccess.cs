// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:49:25




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
    internal sealed partial class ASPNETUserNameByMemberIDDataAccess : BaseDataAccess, IASPNETUserNameByMemberIDDataAccess
    {
        #region Constructors

        public ASPNETUserNameByMemberIDDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ASPNETUserNameByMemberIDEntity> CreateEntityBuilder<ASPNETUserNameByMemberIDEntity>()
        {
            return (new ASPNETUserNameByMemberIDBuilder()) as IEntityBuilder<ASPNETUserNameByMemberIDEntity>;
        }

        #endregion


        #region GetAll

        IList<ASPNETUserNameByMemberIDEntity> IASPNETUserNameByMemberIDDataAccess.GetIL(Int64 memberID)
        {
            try
            {
                const string SP = "dbo.ASPNETUserNameByMemberID";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@MemberID", DbType.Int64, memberID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ASPNETUserNameByMemberIDEntity> list = CreateEntityBuilder<ASPNETUserNameByMemberIDEntity>().BuildEntities(reader);

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

        DataTable IASPNETUserNameByMemberIDDataAccess.GetDT(Int64 memberID)
        {
            try
            {
                const string SP = "dbo.ASPNETUserNameByMemberID";

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
