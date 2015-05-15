// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Nov-2013, 12:21:52




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
    internal sealed partial class CMNEventInvitationInformationDataAccess : BaseDataAccess, ICMNEventInvitationInformationDataAccess
    {
        #region Constructors

        public CMNEventInvitationInformationDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMNEventInvitationInformationEntity> CreateEntityBuilder<CMNEventInvitationInformationEntity>()
        {
            return (new CMNEventInvitationInformationBuilder()) as IEntityBuilder<CMNEventInvitationInformationEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMNEventInvitationInformationDataAccess.Add(CMNEventInvitationInformationEntity cMNEventInvitationInformationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMNEventInvitationInformationEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMNEventInvitationInformationEntity, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Add(CMNEventInvitationInformationEntity cMNEventInvitationInformationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNEventInvitationInformation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EventInvitationInformationID");

                Database.AddInParameter(cmd, "@EventID", DbType.Int64, cMNEventInvitationInformationEntity.EventID);	
                Database.AddInParameter(cmd, "@InitationGivenByMemberID", DbType.Int64, cMNEventInvitationInformationEntity.InitationGivenByMemberID);	
                Database.AddInParameter(cmd, "@SharedDateTime", DbType.DateTime, cMNEventInvitationInformationEntity.SharedDateTime);	
                Database.AddInParameter(cmd, "@Message", DbType.String, cMNEventInvitationInformationEntity.Message);	
                Database.AddInParameter(cmd, "@InitationGivenToMemberID", DbType.Int64, cMNEventInvitationInformationEntity.InitationGivenToMemberID);	
                Database.AddInParameter(cmd, "@EventInvitatedPersonTypeID", DbType.Int64, cMNEventInvitationInformationEntity.EventInvitatedPersonTypeID);	
                Database.AddInParameter(cmd, "@IsGuestGoing", DbType.Boolean, cMNEventInvitationInformationEntity.IsGuestGoing);	
                Database.AddInParameter(cmd, "@IP", DbType.String, cMNEventInvitationInformationEntity.IP);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMNEventInvitationInformationEntity already exists. Please specify another CMNEventInvitationInformationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNEventInvitationInformationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNEventInvitationInformationEntity already exists. Please specify another CMNEventInvitationInformationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMNEventInvitationInformationEntity cMNEventInvitationInformationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNEventInvitationInformation_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EventInvitationInformationID", db);

                db.AddInParameter(cmd, "@EventID", DbType.Int64, cMNEventInvitationInformationEntity.EventID);
                db.AddInParameter(cmd, "@InitationGivenByMemberID", DbType.Int64, cMNEventInvitationInformationEntity.InitationGivenByMemberID);
                db.AddInParameter(cmd, "@SharedDateTime", DbType.DateTime, cMNEventInvitationInformationEntity.SharedDateTime);
                db.AddInParameter(cmd, "@Message", DbType.String, cMNEventInvitationInformationEntity.Message);
                db.AddInParameter(cmd, "@InitationGivenToMemberID", DbType.Int64, cMNEventInvitationInformationEntity.InitationGivenToMemberID);
                db.AddInParameter(cmd, "@EventInvitatedPersonTypeID", DbType.Int64, cMNEventInvitationInformationEntity.EventInvitatedPersonTypeID);
                db.AddInParameter(cmd, "@IsGuestGoing", DbType.Boolean, cMNEventInvitationInformationEntity.IsGuestGoing);
                db.AddInParameter(cmd, "@IP", DbType.String, cMNEventInvitationInformationEntity.IP);

                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    returnCode = db.ExecuteNonQuery(cmd, transaction);

                    returnCode = GetReturnCodeFromParameter(cmd, db);

                    if (returnCode > 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Add Operation

        #region Add List Operation

        IList<Int64> ICMNEventInvitationInformationDataAccess.Add(IList<CMNEventInvitationInformationEntity> cMNEventInvitationInformationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMNEventInvitationInformationEntity cMNEventInvitationInformationEntity in cMNEventInvitationInformationEntityList)
            {
                returnCode = (this as ICMNEventInvitationInformationDataAccess).Add(cMNEventInvitationInformationEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMNEventInvitationInformationDataAccess.Update(CMNEventInvitationInformationEntity cMNEventInvitationInformationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMNEventInvitationInformationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMNEventInvitationInformationEntity, filterExpression, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Update(CMNEventInvitationInformationEntity cMNEventInvitationInformationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNEventInvitationInformation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EventInvitationInformationID", DbType.Int64, cMNEventInvitationInformationEntity.EventInvitationInformationID);
                Database.AddInParameter(cmd, "@EventID", DbType.Int64, cMNEventInvitationInformationEntity.EventID);
                Database.AddInParameter(cmd, "@InitationGivenByMemberID", DbType.Int64, cMNEventInvitationInformationEntity.InitationGivenByMemberID);
                Database.AddInParameter(cmd, "@SharedDateTime", DbType.DateTime, cMNEventInvitationInformationEntity.SharedDateTime);
                Database.AddInParameter(cmd, "@Message", DbType.String, cMNEventInvitationInformationEntity.Message);
                Database.AddInParameter(cmd, "@InitationGivenToMemberID", DbType.Int64, cMNEventInvitationInformationEntity.InitationGivenToMemberID);
                Database.AddInParameter(cmd, "@EventInvitatedPersonTypeID", DbType.Int64, cMNEventInvitationInformationEntity.EventInvitatedPersonTypeID);
                Database.AddInParameter(cmd, "@IsGuestGoing", DbType.Boolean, cMNEventInvitationInformationEntity.IsGuestGoing);
                Database.AddInParameter(cmd, "@IP", DbType.String, cMNEventInvitationInformationEntity.IP);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMNEventInvitationInformationEntity already exists. Please specify another CMNEventInvitationInformationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNEventInvitationInformationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNEventInvitationInformationEntity already exists. Please specify another CMNEventInvitationInformationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMNEventInvitationInformationEntity cMNEventInvitationInformationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNEventInvitationInformation_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EventInvitationInformationID", DbType.Int64, cMNEventInvitationInformationEntity.EventInvitationInformationID);
                db.AddInParameter(cmd, "@EventID", DbType.Int64, cMNEventInvitationInformationEntity.EventID);
                db.AddInParameter(cmd, "@InitationGivenByMemberID", DbType.Int64, cMNEventInvitationInformationEntity.InitationGivenByMemberID);
                db.AddInParameter(cmd, "@SharedDateTime", DbType.DateTime, cMNEventInvitationInformationEntity.SharedDateTime);
                db.AddInParameter(cmd, "@Message", DbType.String, cMNEventInvitationInformationEntity.Message);
                db.AddInParameter(cmd, "@InitationGivenToMemberID", DbType.Int64, cMNEventInvitationInformationEntity.InitationGivenToMemberID);
                db.AddInParameter(cmd, "@EventInvitatedPersonTypeID", DbType.Int64, cMNEventInvitationInformationEntity.EventInvitatedPersonTypeID);
                db.AddInParameter(cmd, "@IsGuestGoing", DbType.Boolean, cMNEventInvitationInformationEntity.IsGuestGoing);
                db.AddInParameter(cmd, "@IP", DbType.String, cMNEventInvitationInformationEntity.IP);

                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (IDataReader reader = db.ExecuteReader(cmd, transaction))
                    {
                        returnCode = GetReturnCodeFromParameter(cmd);
                    }                    

                    if (returnCode > 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Update Operation

        #region Update List Operation

        IList<Int64> ICMNEventInvitationInformationDataAccess.Update(IList<CMNEventInvitationInformationEntity> cMNEventInvitationInformationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMNEventInvitationInformationEntity cMNEventInvitationInformationEntity in cMNEventInvitationInformationEntityList)
            {
                returnCode = (this as ICMNEventInvitationInformationDataAccess).Update(cMNEventInvitationInformationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMNEventInvitationInformationDataAccess.Delete(CMNEventInvitationInformationEntity cMNEventInvitationInformationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMNEventInvitationInformationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMNEventInvitationInformationEntity, filterExpression, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Delete(CMNEventInvitationInformationEntity cMNEventInvitationInformationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNEventInvitationInformation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);


                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMNEventInvitationInformationEntity already exists. Please specify another CMNEventInvitationInformationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNEventInvitationInformationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNEventInvitationInformationEntity already exists. Please specify another CMNEventInvitationInformationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMNEventInvitationInformationEntity cMNEventInvitationInformationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNEventInvitationInformation_SET";

            Database db = DatabaseFactory.CreateDatabase();


            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd, db);
                AddFilterExpressionParameter(cmd, filterExpression, db);


                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (IDataReader reader = db.ExecuteReader(cmd, transaction))
                    {
                        returnCode = GetReturnCodeFromParameter(cmd);
                    }

                    if (returnCode >= 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Delete Operation

        #region Delete List Operation

        IList<Int64> ICMNEventInvitationInformationDataAccess.Delete(IList<CMNEventInvitationInformationEntity> cMNEventInvitationInformationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMNEventInvitationInformationEntity cMNEventInvitationInformationEntity in cMNEventInvitationInformationEntityList)
            {
                returnCode = (this as ICMNEventInvitationInformationDataAccess).Delete(cMNEventInvitationInformationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMNEventInvitationInformationEntity> ICMNEventInvitationInformationDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMNEventInvitationInformation_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMNEventInvitationInformationEntity> list = CreateEntityBuilder<CMNEventInvitationInformationEntity>().BuildEntities(reader);

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

        DataTable ICMNEventInvitationInformationDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMNEventInvitationInformation_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddCurrentPageParameter(cmd, currentPage);
                    AddPageSizeParameter(cmd, pageSize);
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

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
