// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




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
    internal sealed partial class CommonDA_SPDataAccess : BaseDataAccess, ICommonDA_SPDataAccess
    {
        #region Constructors

        public CommonDA_SPDataAccess(Context context)
            : base(context)
        {
        }

        // this one is just to make the code error free
        protected override IEntityBuilder<MDAddressTypeEntity> CreateEntityBuilder<MDAddressTypeEntity>()
        {
            return (new MDAddressTypeBuilder()) as IEntityBuilder<MDAddressTypeEntity>;
        }

        #endregion

        #region GetAll

        DataTable ICommonDA_SPDataAccess.GetDT(String xVar, Int32 action)
        {
            try
            {
                const string SP = "dbo.CommonDA_SP";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@xVar", DbType.Xml, xVar);	
				    Database.AddInParameter(cmd, "@TableInfo", DbType.Int32, action);	

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
