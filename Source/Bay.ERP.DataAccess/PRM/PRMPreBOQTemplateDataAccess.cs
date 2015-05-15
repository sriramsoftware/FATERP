// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




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
    internal sealed partial class PRMPreBOQTemplateDataAccess : BaseDataAccess, IPRMPreBOQTemplateDataAccess
    {
        #region Constructors

        public PRMPreBOQTemplateDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMPreBOQTemplateEntity> CreateEntityBuilder<PRMPreBOQTemplateEntity>()
        {
            return (new PRMPreBOQTemplateBuilder()) as IEntityBuilder<PRMPreBOQTemplateEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMPreBOQTemplateDataAccess.Add(PRMPreBOQTemplateEntity pRMPreBOQTemplateEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMPreBOQTemplateEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMPreBOQTemplateEntity, option);
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

        private Int64 Add(PRMPreBOQTemplateEntity pRMPreBOQTemplateEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQTemplate_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "PreBOQTemplateID");

                Database.AddInParameter(cmd, "@TemplateName", DbType.String, pRMPreBOQTemplateEntity.TemplateName);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMPreBOQTemplateEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMPreBOQTemplateEntity already exists. Please specify another PRMPreBOQTemplateEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMPreBOQTemplateEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMPreBOQTemplateEntity already exists. Please specify another PRMPreBOQTemplateEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMPreBOQTemplateEntity pRMPreBOQTemplateEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQTemplate_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "PreBOQTemplateID", db);

                db.AddInParameter(cmd, "@TemplateName", DbType.String, pRMPreBOQTemplateEntity.TemplateName);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMPreBOQTemplateEntity.IsRemoved);

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

        IList<Int64> IPRMPreBOQTemplateDataAccess.Add(IList<PRMPreBOQTemplateEntity> pRMPreBOQTemplateEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMPreBOQTemplateEntity pRMPreBOQTemplateEntity in pRMPreBOQTemplateEntityList)
            {
                returnCode = (this as IPRMPreBOQTemplateDataAccess).Add(pRMPreBOQTemplateEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMPreBOQTemplateDataAccess.Update(PRMPreBOQTemplateEntity pRMPreBOQTemplateEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMPreBOQTemplateEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMPreBOQTemplateEntity, filterExpression, option);
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

        private Int64 Update(PRMPreBOQTemplateEntity pRMPreBOQTemplateEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQTemplate_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@PreBOQTemplateID", DbType.Int64, pRMPreBOQTemplateEntity.PreBOQTemplateID);
                Database.AddInParameter(cmd, "@TemplateName", DbType.String, pRMPreBOQTemplateEntity.TemplateName);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMPreBOQTemplateEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMPreBOQTemplateEntity already exists. Please specify another PRMPreBOQTemplateEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMPreBOQTemplateEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMPreBOQTemplateEntity already exists. Please specify another PRMPreBOQTemplateEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMPreBOQTemplateEntity pRMPreBOQTemplateEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQTemplate_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@PreBOQTemplateID", DbType.Int64, pRMPreBOQTemplateEntity.PreBOQTemplateID);
                db.AddInParameter(cmd, "@TemplateName", DbType.String, pRMPreBOQTemplateEntity.TemplateName);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMPreBOQTemplateEntity.IsRemoved);

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

        IList<Int64> IPRMPreBOQTemplateDataAccess.Update(IList<PRMPreBOQTemplateEntity> pRMPreBOQTemplateEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMPreBOQTemplateEntity pRMPreBOQTemplateEntity in pRMPreBOQTemplateEntityList)
            {
                returnCode = (this as IPRMPreBOQTemplateDataAccess).Update(pRMPreBOQTemplateEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMPreBOQTemplateDataAccess.Delete(PRMPreBOQTemplateEntity pRMPreBOQTemplateEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMPreBOQTemplateEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMPreBOQTemplateEntity, filterExpression, option);
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

        private Int64 Delete(PRMPreBOQTemplateEntity pRMPreBOQTemplateEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQTemplate_SET";

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
                                throw new ArgumentException("PRMPreBOQTemplateEntity already exists. Please specify another PRMPreBOQTemplateEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMPreBOQTemplateEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMPreBOQTemplateEntity already exists. Please specify another PRMPreBOQTemplateEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMPreBOQTemplateEntity pRMPreBOQTemplateEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQTemplate_SET";

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

        IList<Int64> IPRMPreBOQTemplateDataAccess.Delete(IList<PRMPreBOQTemplateEntity> pRMPreBOQTemplateEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMPreBOQTemplateEntity pRMPreBOQTemplateEntity in pRMPreBOQTemplateEntityList)
            {
                returnCode = (this as IPRMPreBOQTemplateDataAccess).Delete(pRMPreBOQTemplateEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMPreBOQTemplateEntity> IPRMPreBOQTemplateDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMPreBOQTemplate_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMPreBOQTemplateEntity> list = CreateEntityBuilder<PRMPreBOQTemplateEntity>().BuildEntities(reader);

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

        DataTable IPRMPreBOQTemplateDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMPreBOQTemplate_GET";

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
