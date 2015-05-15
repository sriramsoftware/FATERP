// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Apr-2013, 03:35:56




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
    internal sealed partial class CRMCommunicationDataAccess : BaseDataAccess, ICRMCommunicationDataAccess
    {
        #region Constructors

        public CRMCommunicationDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMCommunicationEntity> CreateEntityBuilder<CRMCommunicationEntity>()
        {
            return (new CRMCommunicationBuilder()) as IEntityBuilder<CRMCommunicationEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICRMCommunicationDataAccess.Add(CRMCommunicationEntity cRMCommunicationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cRMCommunicationEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cRMCommunicationEntity, option);
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

        private Int64 Add(CRMCommunicationEntity cRMCommunicationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMCommunication_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "CommunicationID");

                Database.AddInParameter(cmd, "@ProcessCategoryID", DbType.Int64, cRMCommunicationEntity.ProcessCategoryID);	
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, cRMCommunicationEntity.ReferenceID);	
                Database.AddInParameter(cmd, "@CommuicationDiscussionTypeID", DbType.Int64, cRMCommunicationEntity.CommuicationDiscussionTypeID);	
                Database.AddInParameter(cmd, "@DiscussionDate", DbType.DateTime, cRMCommunicationEntity.DiscussionDate);	
                Database.AddInParameter(cmd, "@CommunicateByEmployeeID", DbType.Int64, cRMCommunicationEntity.CommunicateByEmployeeID);	
                Database.AddInParameter(cmd, "@Topics", DbType.String, cRMCommunicationEntity.Topics);	
                Database.AddInParameter(cmd, "@Note", DbType.String, cRMCommunicationEntity.Note);	
                Database.AddInParameter(cmd, "@IsFollowUpNeeded", DbType.Boolean, cRMCommunicationEntity.IsFollowUpNeeded);	
                Database.AddInParameter(cmd, "@IsIWillCall", DbType.Boolean, cRMCommunicationEntity.IsIWillCall);	
                Database.AddInParameter(cmd, "@IsField1", DbType.Boolean, cRMCommunicationEntity.IsField1);	
                Database.AddInParameter(cmd, "@NextAction", DbType.String, cRMCommunicationEntity.NextAction);	
                Database.AddInParameter(cmd, "@NextCommunicationDate", DbType.DateTime, cRMCommunicationEntity.NextCommunicationDate);	
                Database.AddInParameter(cmd, "@CommunicationStatusID", DbType.Int64, cRMCommunicationEntity.CommunicationStatusID);	
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMCommunicationEntity.CreatedByEmployeeID);	
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMCommunicationEntity.IP);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMCommunicationEntity.CreateDate);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMCommunicationEntity already exists. Please specify another CRMCommunicationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMCommunicationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMCommunicationEntity already exists. Please specify another CRMCommunicationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CRMCommunicationEntity cRMCommunicationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMCommunication_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "CommunicationID", db);

                db.AddInParameter(cmd, "@ProcessCategoryID", DbType.Int64, cRMCommunicationEntity.ProcessCategoryID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, cRMCommunicationEntity.ReferenceID);
                db.AddInParameter(cmd, "@CommuicationDiscussionTypeID", DbType.Int64, cRMCommunicationEntity.CommuicationDiscussionTypeID);
                db.AddInParameter(cmd, "@DiscussionDate", DbType.DateTime, cRMCommunicationEntity.DiscussionDate);
                db.AddInParameter(cmd, "@CommunicateByEmployeeID", DbType.Int64, cRMCommunicationEntity.CommunicateByEmployeeID);
                db.AddInParameter(cmd, "@Topics", DbType.String, cRMCommunicationEntity.Topics);
                db.AddInParameter(cmd, "@Note", DbType.String, cRMCommunicationEntity.Note);
                db.AddInParameter(cmd, "@IsFollowUpNeeded", DbType.Boolean, cRMCommunicationEntity.IsFollowUpNeeded);
                db.AddInParameter(cmd, "@IsIWillCall", DbType.Boolean, cRMCommunicationEntity.IsIWillCall);
                db.AddInParameter(cmd, "@IsField1", DbType.Boolean, cRMCommunicationEntity.IsField1);
                db.AddInParameter(cmd, "@NextAction", DbType.String, cRMCommunicationEntity.NextAction);
                db.AddInParameter(cmd, "@NextCommunicationDate", DbType.DateTime, cRMCommunicationEntity.NextCommunicationDate);
                db.AddInParameter(cmd, "@CommunicationStatusID", DbType.Int64, cRMCommunicationEntity.CommunicationStatusID);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMCommunicationEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMCommunicationEntity.IP);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMCommunicationEntity.CreateDate);

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

        IList<Int64> ICRMCommunicationDataAccess.Add(IList<CRMCommunicationEntity> cRMCommunicationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CRMCommunicationEntity cRMCommunicationEntity in cRMCommunicationEntityList)
            {
                returnCode = (this as ICRMCommunicationDataAccess).Add(cRMCommunicationEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICRMCommunicationDataAccess.Update(CRMCommunicationEntity cRMCommunicationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cRMCommunicationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cRMCommunicationEntity, filterExpression, option);
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

        private Int64 Update(CRMCommunicationEntity cRMCommunicationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMCommunication_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@CommunicationID", DbType.Int64, cRMCommunicationEntity.CommunicationID);
                Database.AddInParameter(cmd, "@ProcessCategoryID", DbType.Int64, cRMCommunicationEntity.ProcessCategoryID);
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, cRMCommunicationEntity.ReferenceID);
                Database.AddInParameter(cmd, "@CommuicationDiscussionTypeID", DbType.Int64, cRMCommunicationEntity.CommuicationDiscussionTypeID);
                Database.AddInParameter(cmd, "@DiscussionDate", DbType.DateTime, cRMCommunicationEntity.DiscussionDate);
                Database.AddInParameter(cmd, "@CommunicateByEmployeeID", DbType.Int64, cRMCommunicationEntity.CommunicateByEmployeeID);
                Database.AddInParameter(cmd, "@Topics", DbType.String, cRMCommunicationEntity.Topics);
                Database.AddInParameter(cmd, "@Note", DbType.String, cRMCommunicationEntity.Note);
                Database.AddInParameter(cmd, "@IsFollowUpNeeded", DbType.Boolean, cRMCommunicationEntity.IsFollowUpNeeded);
                Database.AddInParameter(cmd, "@IsIWillCall", DbType.Boolean, cRMCommunicationEntity.IsIWillCall);
                Database.AddInParameter(cmd, "@IsField1", DbType.Boolean, cRMCommunicationEntity.IsField1);
                Database.AddInParameter(cmd, "@NextAction", DbType.String, cRMCommunicationEntity.NextAction);
                Database.AddInParameter(cmd, "@NextCommunicationDate", DbType.DateTime, cRMCommunicationEntity.NextCommunicationDate);
                Database.AddInParameter(cmd, "@CommunicationStatusID", DbType.Int64, cRMCommunicationEntity.CommunicationStatusID);
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMCommunicationEntity.CreatedByEmployeeID);
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMCommunicationEntity.IP);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMCommunicationEntity.CreateDate);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMCommunicationEntity already exists. Please specify another CRMCommunicationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMCommunicationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMCommunicationEntity already exists. Please specify another CRMCommunicationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CRMCommunicationEntity cRMCommunicationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMCommunication_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@CommunicationID", DbType.Int64, cRMCommunicationEntity.CommunicationID);
                db.AddInParameter(cmd, "@ProcessCategoryID", DbType.Int64, cRMCommunicationEntity.ProcessCategoryID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, cRMCommunicationEntity.ReferenceID);
                db.AddInParameter(cmd, "@CommuicationDiscussionTypeID", DbType.Int64, cRMCommunicationEntity.CommuicationDiscussionTypeID);
                db.AddInParameter(cmd, "@DiscussionDate", DbType.DateTime, cRMCommunicationEntity.DiscussionDate);
                db.AddInParameter(cmd, "@CommunicateByEmployeeID", DbType.Int64, cRMCommunicationEntity.CommunicateByEmployeeID);
                db.AddInParameter(cmd, "@Topics", DbType.String, cRMCommunicationEntity.Topics);
                db.AddInParameter(cmd, "@Note", DbType.String, cRMCommunicationEntity.Note);
                db.AddInParameter(cmd, "@IsFollowUpNeeded", DbType.Boolean, cRMCommunicationEntity.IsFollowUpNeeded);
                db.AddInParameter(cmd, "@IsIWillCall", DbType.Boolean, cRMCommunicationEntity.IsIWillCall);
                db.AddInParameter(cmd, "@IsField1", DbType.Boolean, cRMCommunicationEntity.IsField1);
                db.AddInParameter(cmd, "@NextAction", DbType.String, cRMCommunicationEntity.NextAction);
                db.AddInParameter(cmd, "@NextCommunicationDate", DbType.DateTime, cRMCommunicationEntity.NextCommunicationDate);
                db.AddInParameter(cmd, "@CommunicationStatusID", DbType.Int64, cRMCommunicationEntity.CommunicationStatusID);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMCommunicationEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMCommunicationEntity.IP);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMCommunicationEntity.CreateDate);

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

        IList<Int64> ICRMCommunicationDataAccess.Update(IList<CRMCommunicationEntity> cRMCommunicationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CRMCommunicationEntity cRMCommunicationEntity in cRMCommunicationEntityList)
            {
                returnCode = (this as ICRMCommunicationDataAccess).Update(cRMCommunicationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICRMCommunicationDataAccess.Delete(CRMCommunicationEntity cRMCommunicationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cRMCommunicationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cRMCommunicationEntity, filterExpression, option);
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

        private Int64 Delete(CRMCommunicationEntity cRMCommunicationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMCommunication_SET";

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
                                throw new ArgumentException("CRMCommunicationEntity already exists. Please specify another CRMCommunicationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMCommunicationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMCommunicationEntity already exists. Please specify another CRMCommunicationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CRMCommunicationEntity cRMCommunicationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMCommunication_SET";

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

        IList<Int64> ICRMCommunicationDataAccess.Delete(IList<CRMCommunicationEntity> cRMCommunicationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CRMCommunicationEntity cRMCommunicationEntity in cRMCommunicationEntityList)
            {
                returnCode = (this as ICRMCommunicationDataAccess).Delete(cRMCommunicationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CRMCommunicationEntity> ICRMCommunicationDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMCommunication_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMCommunicationEntity> list = CreateEntityBuilder<CRMCommunicationEntity>().BuildEntities(reader);

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

        DataTable ICRMCommunicationDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMCommunication_GET";

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
