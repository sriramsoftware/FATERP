// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
    internal sealed partial class CMProjectScheduleTemplateDataAccess : BaseDataAccess, ICMProjectScheduleTemplateDataAccess
    {
        #region Constructors

        public CMProjectScheduleTemplateDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMProjectScheduleTemplateEntity> CreateEntityBuilder<CMProjectScheduleTemplateEntity>()
        {
            return (new CMProjectScheduleTemplateBuilder()) as IEntityBuilder<CMProjectScheduleTemplateEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMProjectScheduleTemplateDataAccess.Add(CMProjectScheduleTemplateEntity cMProjectScheduleTemplateEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMProjectScheduleTemplateEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMProjectScheduleTemplateEntity, option);
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

        private Int64 Add(CMProjectScheduleTemplateEntity cMProjectScheduleTemplateEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMProjectScheduleTemplate_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectScheduleTemplateID");

                Database.AddInParameter(cmd, "@TemplateName", DbType.String, cMProjectScheduleTemplateEntity.TemplateName);	
                Database.AddInParameter(cmd, "@Description", DbType.String, cMProjectScheduleTemplateEntity.Description);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMProjectScheduleTemplateEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMProjectScheduleTemplateEntity already exists. Please specify another CMProjectScheduleTemplateEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMProjectScheduleTemplateEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMProjectScheduleTemplateEntity already exists. Please specify another CMProjectScheduleTemplateEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMProjectScheduleTemplateEntity cMProjectScheduleTemplateEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMProjectScheduleTemplate_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectScheduleTemplateID", db);

                db.AddInParameter(cmd, "@TemplateName", DbType.String, cMProjectScheduleTemplateEntity.TemplateName);
                db.AddInParameter(cmd, "@Description", DbType.String, cMProjectScheduleTemplateEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMProjectScheduleTemplateEntity.IsRemoved);

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

        IList<Int64> ICMProjectScheduleTemplateDataAccess.Add(IList<CMProjectScheduleTemplateEntity> cMProjectScheduleTemplateEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMProjectScheduleTemplateEntity cMProjectScheduleTemplateEntity in cMProjectScheduleTemplateEntityList)
            {
                returnCode = (this as ICMProjectScheduleTemplateDataAccess).Add(cMProjectScheduleTemplateEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMProjectScheduleTemplateDataAccess.Update(CMProjectScheduleTemplateEntity cMProjectScheduleTemplateEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMProjectScheduleTemplateEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMProjectScheduleTemplateEntity, filterExpression, option);
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

        private Int64 Update(CMProjectScheduleTemplateEntity cMProjectScheduleTemplateEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMProjectScheduleTemplate_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectScheduleTemplateID", DbType.Int64, cMProjectScheduleTemplateEntity.ProjectScheduleTemplateID);
                Database.AddInParameter(cmd, "@TemplateName", DbType.String, cMProjectScheduleTemplateEntity.TemplateName);
                Database.AddInParameter(cmd, "@Description", DbType.String, cMProjectScheduleTemplateEntity.Description);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMProjectScheduleTemplateEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMProjectScheduleTemplateEntity already exists. Please specify another CMProjectScheduleTemplateEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMProjectScheduleTemplateEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMProjectScheduleTemplateEntity already exists. Please specify another CMProjectScheduleTemplateEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMProjectScheduleTemplateEntity cMProjectScheduleTemplateEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMProjectScheduleTemplate_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectScheduleTemplateID", DbType.Int64, cMProjectScheduleTemplateEntity.ProjectScheduleTemplateID);
                db.AddInParameter(cmd, "@TemplateName", DbType.String, cMProjectScheduleTemplateEntity.TemplateName);
                db.AddInParameter(cmd, "@Description", DbType.String, cMProjectScheduleTemplateEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMProjectScheduleTemplateEntity.IsRemoved);

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

        IList<Int64> ICMProjectScheduleTemplateDataAccess.Update(IList<CMProjectScheduleTemplateEntity> cMProjectScheduleTemplateEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMProjectScheduleTemplateEntity cMProjectScheduleTemplateEntity in cMProjectScheduleTemplateEntityList)
            {
                returnCode = (this as ICMProjectScheduleTemplateDataAccess).Update(cMProjectScheduleTemplateEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMProjectScheduleTemplateDataAccess.Delete(CMProjectScheduleTemplateEntity cMProjectScheduleTemplateEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMProjectScheduleTemplateEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMProjectScheduleTemplateEntity, filterExpression, option);
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

        private Int64 Delete(CMProjectScheduleTemplateEntity cMProjectScheduleTemplateEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMProjectScheduleTemplate_SET";

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
                                throw new ArgumentException("CMProjectScheduleTemplateEntity already exists. Please specify another CMProjectScheduleTemplateEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMProjectScheduleTemplateEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMProjectScheduleTemplateEntity already exists. Please specify another CMProjectScheduleTemplateEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMProjectScheduleTemplateEntity cMProjectScheduleTemplateEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMProjectScheduleTemplate_SET";

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

        IList<Int64> ICMProjectScheduleTemplateDataAccess.Delete(IList<CMProjectScheduleTemplateEntity> cMProjectScheduleTemplateEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMProjectScheduleTemplateEntity cMProjectScheduleTemplateEntity in cMProjectScheduleTemplateEntityList)
            {
                returnCode = (this as ICMProjectScheduleTemplateDataAccess).Delete(cMProjectScheduleTemplateEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMProjectScheduleTemplateEntity> ICMProjectScheduleTemplateDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMProjectScheduleTemplate_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMProjectScheduleTemplateEntity> list = CreateEntityBuilder<CMProjectScheduleTemplateEntity>().BuildEntities(reader);

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

        DataTable ICMProjectScheduleTemplateDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMProjectScheduleTemplate_GET";

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
