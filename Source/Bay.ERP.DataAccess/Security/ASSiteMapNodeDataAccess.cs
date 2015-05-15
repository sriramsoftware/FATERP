// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:24:04




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
    internal sealed partial class ASSiteMapNodeDataAccess : BaseDataAccess, IASSiteMapNodeDataAccess
    {
        #region Constructors

        public ASSiteMapNodeDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ASSiteMapNodeEntity> CreateEntityBuilder<ASSiteMapNodeEntity>()
        {
            return (new ASSiteMapNodeBuilder()) as IEntityBuilder<ASSiteMapNodeEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IASSiteMapNodeDataAccess.Add(ASSiteMapNodeEntity aSSiteMapNodeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aSSiteMapNodeEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aSSiteMapNodeEntity, option);
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

        private Int64 Add(ASSiteMapNodeEntity aSSiteMapNodeEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASSiteMapNode_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ASSiteMapNodeID");

                Database.AddInParameter(cmd, "@ASSiteMapID", DbType.Int64, aSSiteMapNodeEntity.ASSiteMapID);	
                Database.AddInParameter(cmd, "@ASPhysicalSiteMapID", DbType.Int64, aSSiteMapNodeEntity.ASPhysicalSiteMapID);	
                Database.AddInParameter(cmd, "@MenuTitle", DbType.String, aSSiteMapNodeEntity.MenuTitle);	
                Database.AddInParameter(cmd, "@ToolTip", DbType.String, aSSiteMapNodeEntity.ToolTip);	
                Database.AddInParameter(cmd, "@UniqueKey", DbType.String, aSSiteMapNodeEntity.UniqueKey);	
                Database.AddInParameter(cmd, "@ParentASSiteMapNodeID", DbType.Int64, aSSiteMapNodeEntity.ParentASSiteMapNodeID);	
                Database.AddInParameter(cmd, "@SequenceNumber", DbType.Int64, aSSiteMapNodeEntity.SequenceNumber);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ASSiteMapNodeEntity already exists. Please specify another ASSiteMapNodeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ASSiteMapNodeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ASSiteMapNodeEntity already exists. Please specify another ASSiteMapNodeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ASSiteMapNodeEntity aSSiteMapNodeEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASSiteMapNode_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ASSiteMapNodeID", db);

                db.AddInParameter(cmd, "@ASSiteMapID", DbType.Int64, aSSiteMapNodeEntity.ASSiteMapID);
                db.AddInParameter(cmd, "@ASPhysicalSiteMapID", DbType.Int64, aSSiteMapNodeEntity.ASPhysicalSiteMapID);
                db.AddInParameter(cmd, "@MenuTitle", DbType.String, aSSiteMapNodeEntity.MenuTitle);
                db.AddInParameter(cmd, "@ToolTip", DbType.String, aSSiteMapNodeEntity.ToolTip);
                db.AddInParameter(cmd, "@UniqueKey", DbType.String, aSSiteMapNodeEntity.UniqueKey);
                db.AddInParameter(cmd, "@ParentASSiteMapNodeID", DbType.Int64, aSSiteMapNodeEntity.ParentASSiteMapNodeID);
                db.AddInParameter(cmd, "@SequenceNumber", DbType.Int64, aSSiteMapNodeEntity.SequenceNumber);

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

        IList<Int64> IASSiteMapNodeDataAccess.Add(IList<ASSiteMapNodeEntity> aSSiteMapNodeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ASSiteMapNodeEntity aSSiteMapNodeEntity in aSSiteMapNodeEntityList)
            {
                returnCode = (this as IASSiteMapNodeDataAccess).Add(aSSiteMapNodeEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IASSiteMapNodeDataAccess.Update(ASSiteMapNodeEntity aSSiteMapNodeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aSSiteMapNodeEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aSSiteMapNodeEntity, filterExpression, option);
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

        private Int64 Update(ASSiteMapNodeEntity aSSiteMapNodeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASSiteMapNode_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ASSiteMapNodeID", DbType.Int64, aSSiteMapNodeEntity.ASSiteMapNodeID);
                Database.AddInParameter(cmd, "@ASSiteMapID", DbType.Int64, aSSiteMapNodeEntity.ASSiteMapID);
                Database.AddInParameter(cmd, "@ASPhysicalSiteMapID", DbType.Int64, aSSiteMapNodeEntity.ASPhysicalSiteMapID);
                Database.AddInParameter(cmd, "@MenuTitle", DbType.String, aSSiteMapNodeEntity.MenuTitle);
                Database.AddInParameter(cmd, "@ToolTip", DbType.String, aSSiteMapNodeEntity.ToolTip);
                Database.AddInParameter(cmd, "@UniqueKey", DbType.String, aSSiteMapNodeEntity.UniqueKey);
                Database.AddInParameter(cmd, "@ParentASSiteMapNodeID", DbType.Int64, aSSiteMapNodeEntity.ParentASSiteMapNodeID);
                Database.AddInParameter(cmd, "@SequenceNumber", DbType.Int64, aSSiteMapNodeEntity.SequenceNumber);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ASSiteMapNodeEntity already exists. Please specify another ASSiteMapNodeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ASSiteMapNodeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ASSiteMapNodeEntity already exists. Please specify another ASSiteMapNodeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ASSiteMapNodeEntity aSSiteMapNodeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASSiteMapNode_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ASSiteMapNodeID", DbType.Int64, aSSiteMapNodeEntity.ASSiteMapNodeID);
                db.AddInParameter(cmd, "@ASSiteMapID", DbType.Int64, aSSiteMapNodeEntity.ASSiteMapID);
                db.AddInParameter(cmd, "@ASPhysicalSiteMapID", DbType.Int64, aSSiteMapNodeEntity.ASPhysicalSiteMapID);
                db.AddInParameter(cmd, "@MenuTitle", DbType.String, aSSiteMapNodeEntity.MenuTitle);
                db.AddInParameter(cmd, "@ToolTip", DbType.String, aSSiteMapNodeEntity.ToolTip);
                db.AddInParameter(cmd, "@UniqueKey", DbType.String, aSSiteMapNodeEntity.UniqueKey);
                db.AddInParameter(cmd, "@ParentASSiteMapNodeID", DbType.Int64, aSSiteMapNodeEntity.ParentASSiteMapNodeID);
                db.AddInParameter(cmd, "@SequenceNumber", DbType.Int64, aSSiteMapNodeEntity.SequenceNumber);

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

        IList<Int64> IASSiteMapNodeDataAccess.Update(IList<ASSiteMapNodeEntity> aSSiteMapNodeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ASSiteMapNodeEntity aSSiteMapNodeEntity in aSSiteMapNodeEntityList)
            {
                returnCode = (this as IASSiteMapNodeDataAccess).Update(aSSiteMapNodeEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IASSiteMapNodeDataAccess.Delete(ASSiteMapNodeEntity aSSiteMapNodeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aSSiteMapNodeEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aSSiteMapNodeEntity, filterExpression, option);
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

        private Int64 Delete(ASSiteMapNodeEntity aSSiteMapNodeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASSiteMapNode_SET";

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
                                throw new ArgumentException("ASSiteMapNodeEntity already exists. Please specify another ASSiteMapNodeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ASSiteMapNodeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ASSiteMapNodeEntity already exists. Please specify another ASSiteMapNodeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ASSiteMapNodeEntity aSSiteMapNodeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASSiteMapNode_SET";

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

        IList<Int64> IASSiteMapNodeDataAccess.Delete(IList<ASSiteMapNodeEntity> aSSiteMapNodeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ASSiteMapNodeEntity aSSiteMapNodeEntity in aSSiteMapNodeEntityList)
            {
                returnCode = (this as IASSiteMapNodeDataAccess).Delete(aSSiteMapNodeEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ASSiteMapNodeEntity> IASSiteMapNodeDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ASSiteMapNode_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ASSiteMapNodeEntity> list = CreateEntityBuilder<ASSiteMapNodeEntity>().BuildEntities(reader);

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

        DataTable IASSiteMapNodeDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ASSiteMapNode_GET";

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
