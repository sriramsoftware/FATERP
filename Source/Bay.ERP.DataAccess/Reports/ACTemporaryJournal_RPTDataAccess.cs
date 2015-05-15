// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Feb-2013, 11:43:49




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
    internal sealed partial class ACTemporaryJournal_RPTDataAccess : BaseDataAccess, IACTemporaryJournal_RPTDataAccess
    {
        #region Constructors

        public ACTemporaryJournal_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACTemporaryJournal_RPTEntity> CreateEntityBuilder<ACTemporaryJournal_RPTEntity>()
        {
            return (new ACTemporaryJournal_RPTBuilder()) as IEntityBuilder<ACTemporaryJournal_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<ACTemporaryJournal_RPTEntity> IACTemporaryJournal_RPTDataAccess.GetIL(Int64 temporaryJournalMasterID)
        {
            try
            {
                const string SP = "dbo.ACTemporaryJournal_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@TemporaryJournalMasterID", DbType.Int64, temporaryJournalMasterID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACTemporaryJournal_RPTEntity> list = CreateEntityBuilder<ACTemporaryJournal_RPTEntity>().BuildEntities(reader);

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

        DataTable IACTemporaryJournal_RPTDataAccess.GetDT(Int64 temporaryJournalMasterID)
        {
            try
            {
                const string SP = "dbo.ACTemporaryJournal_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@TemporaryJournalMasterID", DbType.Int64, temporaryJournalMasterID);	

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
