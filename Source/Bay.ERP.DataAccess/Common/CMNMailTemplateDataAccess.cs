// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Oct-2013, 12:17:51




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
    internal sealed partial class CMNMailTemplateDataAccess : BaseDataAccess, ICMNMailTemplateDataAccess
    {
        #region Constructors

        public CMNMailTemplateDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMNMailTemplateEntity> CreateEntityBuilder<CMNMailTemplateEntity>()
        {
            return (new CMNMailTemplateBuilder()) as IEntityBuilder<CMNMailTemplateEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMNMailTemplateDataAccess.Add(CMNMailTemplateEntity cMNMailTemplateEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMNMailTemplateEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMNMailTemplateEntity, option);
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

        private Int64 Add(CMNMailTemplateEntity cMNMailTemplateEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNMailTemplate_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "MailTemplateID");

                Database.AddInParameter(cmd, "@MailTemplateTypeID", DbType.Int64, cMNMailTemplateEntity.MailTemplateTypeID);	
                Database.AddInParameter(cmd, "@TemplateName", DbType.String, cMNMailTemplateEntity.TemplateName);	
                Database.AddInParameter(cmd, "@Subject", DbType.String, cMNMailTemplateEntity.Subject);	
                Database.AddInParameter(cmd, "@BodyMessage", DbType.String, cMNMailTemplateEntity.BodyMessage);	
                Database.AddInParameter(cmd, "@Signature", DbType.String, cMNMailTemplateEntity.Signature);	
                Database.AddInParameter(cmd, "@MailTextTypeID", DbType.Int64, cMNMailTemplateEntity.MailTextTypeID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMNMailTemplateEntity.Remarks);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMNMailTemplateEntity already exists. Please specify another CMNMailTemplateEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNMailTemplateEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNMailTemplateEntity already exists. Please specify another CMNMailTemplateEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMNMailTemplateEntity cMNMailTemplateEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNMailTemplate_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "MailTemplateID", db);

                db.AddInParameter(cmd, "@MailTemplateTypeID", DbType.Int64, cMNMailTemplateEntity.MailTemplateTypeID);
                db.AddInParameter(cmd, "@TemplateName", DbType.String, cMNMailTemplateEntity.TemplateName);
                db.AddInParameter(cmd, "@Subject", DbType.String, cMNMailTemplateEntity.Subject);
                db.AddInParameter(cmd, "@BodyMessage", DbType.String, cMNMailTemplateEntity.BodyMessage);
                db.AddInParameter(cmd, "@Signature", DbType.String, cMNMailTemplateEntity.Signature);
                db.AddInParameter(cmd, "@MailTextTypeID", DbType.Int64, cMNMailTemplateEntity.MailTextTypeID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMNMailTemplateEntity.Remarks);

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

        IList<Int64> ICMNMailTemplateDataAccess.Add(IList<CMNMailTemplateEntity> cMNMailTemplateEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMNMailTemplateEntity cMNMailTemplateEntity in cMNMailTemplateEntityList)
            {
                returnCode = (this as ICMNMailTemplateDataAccess).Add(cMNMailTemplateEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMNMailTemplateDataAccess.Update(CMNMailTemplateEntity cMNMailTemplateEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMNMailTemplateEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMNMailTemplateEntity, filterExpression, option);
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

        private Int64 Update(CMNMailTemplateEntity cMNMailTemplateEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNMailTemplate_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@MailTemplateID", DbType.Int64, cMNMailTemplateEntity.MailTemplateID);
                Database.AddInParameter(cmd, "@MailTemplateTypeID", DbType.Int64, cMNMailTemplateEntity.MailTemplateTypeID);
                Database.AddInParameter(cmd, "@TemplateName", DbType.String, cMNMailTemplateEntity.TemplateName);
                Database.AddInParameter(cmd, "@Subject", DbType.String, cMNMailTemplateEntity.Subject);
                Database.AddInParameter(cmd, "@BodyMessage", DbType.String, cMNMailTemplateEntity.BodyMessage);
                Database.AddInParameter(cmd, "@Signature", DbType.String, cMNMailTemplateEntity.Signature);
                Database.AddInParameter(cmd, "@MailTextTypeID", DbType.Int64, cMNMailTemplateEntity.MailTextTypeID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMNMailTemplateEntity.Remarks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMNMailTemplateEntity already exists. Please specify another CMNMailTemplateEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNMailTemplateEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNMailTemplateEntity already exists. Please specify another CMNMailTemplateEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMNMailTemplateEntity cMNMailTemplateEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNMailTemplate_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@MailTemplateID", DbType.Int64, cMNMailTemplateEntity.MailTemplateID);
                db.AddInParameter(cmd, "@MailTemplateTypeID", DbType.Int64, cMNMailTemplateEntity.MailTemplateTypeID);
                db.AddInParameter(cmd, "@TemplateName", DbType.String, cMNMailTemplateEntity.TemplateName);
                db.AddInParameter(cmd, "@Subject", DbType.String, cMNMailTemplateEntity.Subject);
                db.AddInParameter(cmd, "@BodyMessage", DbType.String, cMNMailTemplateEntity.BodyMessage);
                db.AddInParameter(cmd, "@Signature", DbType.String, cMNMailTemplateEntity.Signature);
                db.AddInParameter(cmd, "@MailTextTypeID", DbType.Int64, cMNMailTemplateEntity.MailTextTypeID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMNMailTemplateEntity.Remarks);

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

        IList<Int64> ICMNMailTemplateDataAccess.Update(IList<CMNMailTemplateEntity> cMNMailTemplateEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMNMailTemplateEntity cMNMailTemplateEntity in cMNMailTemplateEntityList)
            {
                returnCode = (this as ICMNMailTemplateDataAccess).Update(cMNMailTemplateEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMNMailTemplateDataAccess.Delete(CMNMailTemplateEntity cMNMailTemplateEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMNMailTemplateEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMNMailTemplateEntity, filterExpression, option);
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

        private Int64 Delete(CMNMailTemplateEntity cMNMailTemplateEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNMailTemplate_SET";

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
                                throw new ArgumentException("CMNMailTemplateEntity already exists. Please specify another CMNMailTemplateEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNMailTemplateEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNMailTemplateEntity already exists. Please specify another CMNMailTemplateEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMNMailTemplateEntity cMNMailTemplateEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNMailTemplate_SET";

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

        IList<Int64> ICMNMailTemplateDataAccess.Delete(IList<CMNMailTemplateEntity> cMNMailTemplateEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMNMailTemplateEntity cMNMailTemplateEntity in cMNMailTemplateEntityList)
            {
                returnCode = (this as ICMNMailTemplateDataAccess).Delete(cMNMailTemplateEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMNMailTemplateEntity> ICMNMailTemplateDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMNMailTemplate_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMNMailTemplateEntity> list = CreateEntityBuilder<CMNMailTemplateEntity>().BuildEntities(reader);

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

        DataTable ICMNMailTemplateDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMNMailTemplate_GET";

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
