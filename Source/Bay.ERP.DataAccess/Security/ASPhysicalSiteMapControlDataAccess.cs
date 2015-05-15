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
    internal sealed partial class ASPhysicalSiteMapControlDataAccess : BaseDataAccess, IASPhysicalSiteMapControlDataAccess
    {
        #region Constructors

        public ASPhysicalSiteMapControlDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ASPhysicalSiteMapControlEntity> CreateEntityBuilder<ASPhysicalSiteMapControlEntity>()
        {
            return (new ASPhysicalSiteMapControlBuilder()) as IEntityBuilder<ASPhysicalSiteMapControlEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IASPhysicalSiteMapControlDataAccess.Add(ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aSPhysicalSiteMapControlEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aSPhysicalSiteMapControlEntity, option);
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

        private Int64 Add(ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASPhysicalSiteMapControl_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ASPhysicalSiteMapControlID");

                Database.AddInParameter(cmd, "@ASPhysicalSiteMapID", DbType.Int64, aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapID);	
                Database.AddInParameter(cmd, "@ControlId", DbType.String, aSPhysicalSiteMapControlEntity.ControlId);	
                Database.AddInParameter(cmd, "@ControlName", DbType.String, aSPhysicalSiteMapControlEntity.ControlName);	
                Database.AddInParameter(cmd, "@UniqueKey", DbType.String, aSPhysicalSiteMapControlEntity.UniqueKey);	
                Database.AddInParameter(cmd, "@MDASControlTypeID", DbType.Int64, aSPhysicalSiteMapControlEntity.MDASControlTypeID);	
                Database.AddInParameter(cmd, "@ParentASPhysicalSiteMapControlID", DbType.Int64, aSPhysicalSiteMapControlEntity.ParentASPhysicalSiteMapControlID);	
                Database.AddInParameter(cmd, "@TabPageReferenceUniqueKey", DbType.String, aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ASPhysicalSiteMapControlEntity already exists. Please specify another ASPhysicalSiteMapControlEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ASPhysicalSiteMapControlEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ASPhysicalSiteMapControlEntity already exists. Please specify another ASPhysicalSiteMapControlEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASPhysicalSiteMapControl_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ASPhysicalSiteMapControlID", db);

                db.AddInParameter(cmd, "@ASPhysicalSiteMapID", DbType.Int64, aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapID);
                db.AddInParameter(cmd, "@ControlId", DbType.String, aSPhysicalSiteMapControlEntity.ControlId);
                db.AddInParameter(cmd, "@ControlName", DbType.String, aSPhysicalSiteMapControlEntity.ControlName);
                db.AddInParameter(cmd, "@UniqueKey", DbType.String, aSPhysicalSiteMapControlEntity.UniqueKey);
                db.AddInParameter(cmd, "@MDASControlTypeID", DbType.Int64, aSPhysicalSiteMapControlEntity.MDASControlTypeID);
                db.AddInParameter(cmd, "@ParentASPhysicalSiteMapControlID", DbType.Int64, aSPhysicalSiteMapControlEntity.ParentASPhysicalSiteMapControlID);
                db.AddInParameter(cmd, "@TabPageReferenceUniqueKey", DbType.String, aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey);

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

        IList<Int64> IASPhysicalSiteMapControlDataAccess.Add(IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity in aSPhysicalSiteMapControlEntityList)
            {
                returnCode = (this as IASPhysicalSiteMapControlDataAccess).Add(aSPhysicalSiteMapControlEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IASPhysicalSiteMapControlDataAccess.Update(ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aSPhysicalSiteMapControlEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aSPhysicalSiteMapControlEntity, filterExpression, option);
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

        private Int64 Update(ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASPhysicalSiteMapControl_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ASPhysicalSiteMapControlID", DbType.Int64, aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapControlID);
                Database.AddInParameter(cmd, "@ASPhysicalSiteMapID", DbType.Int64, aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapID);
                Database.AddInParameter(cmd, "@ControlId", DbType.String, aSPhysicalSiteMapControlEntity.ControlId);
                Database.AddInParameter(cmd, "@ControlName", DbType.String, aSPhysicalSiteMapControlEntity.ControlName);
                Database.AddInParameter(cmd, "@UniqueKey", DbType.String, aSPhysicalSiteMapControlEntity.UniqueKey);
                Database.AddInParameter(cmd, "@MDASControlTypeID", DbType.Int64, aSPhysicalSiteMapControlEntity.MDASControlTypeID);
                Database.AddInParameter(cmd, "@ParentASPhysicalSiteMapControlID", DbType.Int64, aSPhysicalSiteMapControlEntity.ParentASPhysicalSiteMapControlID);
                Database.AddInParameter(cmd, "@TabPageReferenceUniqueKey", DbType.String, aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ASPhysicalSiteMapControlEntity already exists. Please specify another ASPhysicalSiteMapControlEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ASPhysicalSiteMapControlEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ASPhysicalSiteMapControlEntity already exists. Please specify another ASPhysicalSiteMapControlEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASPhysicalSiteMapControl_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ASPhysicalSiteMapControlID", DbType.Int64, aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapControlID);
                db.AddInParameter(cmd, "@ASPhysicalSiteMapID", DbType.Int64, aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapID);
                db.AddInParameter(cmd, "@ControlId", DbType.String, aSPhysicalSiteMapControlEntity.ControlId);
                db.AddInParameter(cmd, "@ControlName", DbType.String, aSPhysicalSiteMapControlEntity.ControlName);
                db.AddInParameter(cmd, "@UniqueKey", DbType.String, aSPhysicalSiteMapControlEntity.UniqueKey);
                db.AddInParameter(cmd, "@MDASControlTypeID", DbType.Int64, aSPhysicalSiteMapControlEntity.MDASControlTypeID);
                db.AddInParameter(cmd, "@ParentASPhysicalSiteMapControlID", DbType.Int64, aSPhysicalSiteMapControlEntity.ParentASPhysicalSiteMapControlID);
                db.AddInParameter(cmd, "@TabPageReferenceUniqueKey", DbType.String, aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey);

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

        IList<Int64> IASPhysicalSiteMapControlDataAccess.Update(IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity in aSPhysicalSiteMapControlEntityList)
            {
                returnCode = (this as IASPhysicalSiteMapControlDataAccess).Update(aSPhysicalSiteMapControlEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IASPhysicalSiteMapControlDataAccess.Delete(ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aSPhysicalSiteMapControlEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aSPhysicalSiteMapControlEntity, filterExpression, option);
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

        private Int64 Delete(ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASPhysicalSiteMapControl_SET";

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
                                throw new ArgumentException("ASPhysicalSiteMapControlEntity already exists. Please specify another ASPhysicalSiteMapControlEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ASPhysicalSiteMapControlEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ASPhysicalSiteMapControlEntity already exists. Please specify another ASPhysicalSiteMapControlEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASPhysicalSiteMapControl_SET";

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

        IList<Int64> IASPhysicalSiteMapControlDataAccess.Delete(IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity in aSPhysicalSiteMapControlEntityList)
            {
                returnCode = (this as IASPhysicalSiteMapControlDataAccess).Delete(aSPhysicalSiteMapControlEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ASPhysicalSiteMapControlEntity> IASPhysicalSiteMapControlDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ASPhysicalSiteMapControl_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ASPhysicalSiteMapControlEntity> list = CreateEntityBuilder<ASPhysicalSiteMapControlEntity>().BuildEntities(reader);

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

        DataTable IASPhysicalSiteMapControlDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ASPhysicalSiteMapControl_GET";

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
