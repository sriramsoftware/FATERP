// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Mar-2012, 11:45:48




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
    internal sealed partial class CMNDashboardItemQuicklinkDataAccess : BaseDataAccess, ICMNDashboardItemQuicklinkDataAccess
    {
        #region Constructors

        public CMNDashboardItemQuicklinkDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMNDashboardItemQuicklinkEntity> CreateEntityBuilder<CMNDashboardItemQuicklinkEntity>()
        {
            return (new CMNDashboardItemQuicklinkBuilder()) as IEntityBuilder<CMNDashboardItemQuicklinkEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMNDashboardItemQuicklinkDataAccess.Add(CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMNDashboardItemQuicklinkEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMNDashboardItemQuicklinkEntity, option);
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

        private Int64 Add(CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNDashboardItemQuicklink_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "DashboardItemQuicklinkID");

                Database.AddInParameter(cmd, "@DashboardItemID", DbType.Int64, cMNDashboardItemQuicklinkEntity.DashboardItemID);	
                Database.AddInParameter(cmd, "@Name", DbType.String, cMNDashboardItemQuicklinkEntity.Name);	
                Database.AddInParameter(cmd, "@NavigationUrl", DbType.String, cMNDashboardItemQuicklinkEntity.NavigationUrl);	
                Database.AddInParameter(cmd, "@HoverMessage", DbType.String, cMNDashboardItemQuicklinkEntity.HoverMessage);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMNDashboardItemQuicklinkEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMNDashboardItemQuicklinkEntity already exists. Please specify another CMNDashboardItemQuicklinkEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNDashboardItemQuicklinkEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNDashboardItemQuicklinkEntity already exists. Please specify another CMNDashboardItemQuicklinkEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNDashboardItemQuicklink_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "DashboardItemQuicklinkID", db);

                db.AddInParameter(cmd, "@DashboardItemID", DbType.Int64, cMNDashboardItemQuicklinkEntity.DashboardItemID);
                db.AddInParameter(cmd, "@Name", DbType.String, cMNDashboardItemQuicklinkEntity.Name);
                db.AddInParameter(cmd, "@NavigationUrl", DbType.String, cMNDashboardItemQuicklinkEntity.NavigationUrl);
                db.AddInParameter(cmd, "@HoverMessage", DbType.String, cMNDashboardItemQuicklinkEntity.HoverMessage);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMNDashboardItemQuicklinkEntity.IsRemoved);

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

        IList<Int64> ICMNDashboardItemQuicklinkDataAccess.Add(IList<CMNDashboardItemQuicklinkEntity> cMNDashboardItemQuicklinkEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity in cMNDashboardItemQuicklinkEntityList)
            {
                returnCode = (this as ICMNDashboardItemQuicklinkDataAccess).Add(cMNDashboardItemQuicklinkEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMNDashboardItemQuicklinkDataAccess.Update(CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMNDashboardItemQuicklinkEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMNDashboardItemQuicklinkEntity, filterExpression, option);
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

        private Int64 Update(CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNDashboardItemQuicklink_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@DashboardItemQuicklinkID", DbType.Int64, cMNDashboardItemQuicklinkEntity.DashboardItemQuicklinkID);
                Database.AddInParameter(cmd, "@DashboardItemID", DbType.Int64, cMNDashboardItemQuicklinkEntity.DashboardItemID);
                Database.AddInParameter(cmd, "@Name", DbType.String, cMNDashboardItemQuicklinkEntity.Name);
                Database.AddInParameter(cmd, "@NavigationUrl", DbType.String, cMNDashboardItemQuicklinkEntity.NavigationUrl);
                Database.AddInParameter(cmd, "@HoverMessage", DbType.String, cMNDashboardItemQuicklinkEntity.HoverMessage);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMNDashboardItemQuicklinkEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMNDashboardItemQuicklinkEntity already exists. Please specify another CMNDashboardItemQuicklinkEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNDashboardItemQuicklinkEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNDashboardItemQuicklinkEntity already exists. Please specify another CMNDashboardItemQuicklinkEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNDashboardItemQuicklink_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@DashboardItemQuicklinkID", DbType.Int64, cMNDashboardItemQuicklinkEntity.DashboardItemQuicklinkID);
                db.AddInParameter(cmd, "@DashboardItemID", DbType.Int64, cMNDashboardItemQuicklinkEntity.DashboardItemID);
                db.AddInParameter(cmd, "@Name", DbType.String, cMNDashboardItemQuicklinkEntity.Name);
                db.AddInParameter(cmd, "@NavigationUrl", DbType.String, cMNDashboardItemQuicklinkEntity.NavigationUrl);
                db.AddInParameter(cmd, "@HoverMessage", DbType.String, cMNDashboardItemQuicklinkEntity.HoverMessage);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMNDashboardItemQuicklinkEntity.IsRemoved);

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

        IList<Int64> ICMNDashboardItemQuicklinkDataAccess.Update(IList<CMNDashboardItemQuicklinkEntity> cMNDashboardItemQuicklinkEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity in cMNDashboardItemQuicklinkEntityList)
            {
                returnCode = (this as ICMNDashboardItemQuicklinkDataAccess).Update(cMNDashboardItemQuicklinkEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMNDashboardItemQuicklinkDataAccess.Delete(CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMNDashboardItemQuicklinkEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMNDashboardItemQuicklinkEntity, filterExpression, option);
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

        private Int64 Delete(CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNDashboardItemQuicklink_SET";

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
                                throw new ArgumentException("CMNDashboardItemQuicklinkEntity already exists. Please specify another CMNDashboardItemQuicklinkEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNDashboardItemQuicklinkEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNDashboardItemQuicklinkEntity already exists. Please specify another CMNDashboardItemQuicklinkEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNDashboardItemQuicklink_SET";

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

        IList<Int64> ICMNDashboardItemQuicklinkDataAccess.Delete(IList<CMNDashboardItemQuicklinkEntity> cMNDashboardItemQuicklinkEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity in cMNDashboardItemQuicklinkEntityList)
            {
                returnCode = (this as ICMNDashboardItemQuicklinkDataAccess).Delete(cMNDashboardItemQuicklinkEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMNDashboardItemQuicklinkEntity> ICMNDashboardItemQuicklinkDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMNDashboardItemQuicklink_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMNDashboardItemQuicklinkEntity> list = CreateEntityBuilder<CMNDashboardItemQuicklinkEntity>().BuildEntities(reader);

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

        DataTable ICMNDashboardItemQuicklinkDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMNDashboardItemQuicklink_GET";

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
