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
    internal sealed partial class PRMPreBOQTemplateItemMapDataAccess : BaseDataAccess, IPRMPreBOQTemplateItemMapDataAccess
    {
        #region Constructors

        public PRMPreBOQTemplateItemMapDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMPreBOQTemplateItemMapEntity> CreateEntityBuilder<PRMPreBOQTemplateItemMapEntity>()
        {
            return (new PRMPreBOQTemplateItemMapBuilder()) as IEntityBuilder<PRMPreBOQTemplateItemMapEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMPreBOQTemplateItemMapDataAccess.Add(PRMPreBOQTemplateItemMapEntity pRMPreBOQTemplateItemMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMPreBOQTemplateItemMapEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMPreBOQTemplateItemMapEntity, option);
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

        private Int64 Add(PRMPreBOQTemplateItemMapEntity pRMPreBOQTemplateItemMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQTemplateItemMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "PreBOQTemplateItemMapID");

                Database.AddInParameter(cmd, "@PreBOQTemplateID", DbType.Int64, pRMPreBOQTemplateItemMapEntity.PreBOQTemplateID);	
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, pRMPreBOQTemplateItemMapEntity.ItemID);	
                Database.AddInParameter(cmd, "@SequenceNo", DbType.Int32, pRMPreBOQTemplateItemMapEntity.SequenceNo);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMPreBOQTemplateItemMapEntity already exists. Please specify another PRMPreBOQTemplateItemMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMPreBOQTemplateItemMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMPreBOQTemplateItemMapEntity already exists. Please specify another PRMPreBOQTemplateItemMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMPreBOQTemplateItemMapEntity pRMPreBOQTemplateItemMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQTemplateItemMap_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "PreBOQTemplateItemMapID", db);

                db.AddInParameter(cmd, "@PreBOQTemplateID", DbType.Int64, pRMPreBOQTemplateItemMapEntity.PreBOQTemplateID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, pRMPreBOQTemplateItemMapEntity.ItemID);
                db.AddInParameter(cmd, "@SequenceNo", DbType.Int32, pRMPreBOQTemplateItemMapEntity.SequenceNo);

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

        IList<Int64> IPRMPreBOQTemplateItemMapDataAccess.Add(IList<PRMPreBOQTemplateItemMapEntity> pRMPreBOQTemplateItemMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMPreBOQTemplateItemMapEntity pRMPreBOQTemplateItemMapEntity in pRMPreBOQTemplateItemMapEntityList)
            {
                returnCode = (this as IPRMPreBOQTemplateItemMapDataAccess).Add(pRMPreBOQTemplateItemMapEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMPreBOQTemplateItemMapDataAccess.Update(PRMPreBOQTemplateItemMapEntity pRMPreBOQTemplateItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMPreBOQTemplateItemMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMPreBOQTemplateItemMapEntity, filterExpression, option);
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

        private Int64 Update(PRMPreBOQTemplateItemMapEntity pRMPreBOQTemplateItemMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQTemplateItemMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@PreBOQTemplateItemMapID", DbType.Int64, pRMPreBOQTemplateItemMapEntity.PreBOQTemplateItemMapID);
                Database.AddInParameter(cmd, "@PreBOQTemplateID", DbType.Int64, pRMPreBOQTemplateItemMapEntity.PreBOQTemplateID);
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, pRMPreBOQTemplateItemMapEntity.ItemID);
                Database.AddInParameter(cmd, "@SequenceNo", DbType.Int32, pRMPreBOQTemplateItemMapEntity.SequenceNo);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMPreBOQTemplateItemMapEntity already exists. Please specify another PRMPreBOQTemplateItemMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMPreBOQTemplateItemMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMPreBOQTemplateItemMapEntity already exists. Please specify another PRMPreBOQTemplateItemMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMPreBOQTemplateItemMapEntity pRMPreBOQTemplateItemMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQTemplateItemMap_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@PreBOQTemplateItemMapID", DbType.Int64, pRMPreBOQTemplateItemMapEntity.PreBOQTemplateItemMapID);
                db.AddInParameter(cmd, "@PreBOQTemplateID", DbType.Int64, pRMPreBOQTemplateItemMapEntity.PreBOQTemplateID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, pRMPreBOQTemplateItemMapEntity.ItemID);
                db.AddInParameter(cmd, "@SequenceNo", DbType.Int32, pRMPreBOQTemplateItemMapEntity.SequenceNo);

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

        IList<Int64> IPRMPreBOQTemplateItemMapDataAccess.Update(IList<PRMPreBOQTemplateItemMapEntity> pRMPreBOQTemplateItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMPreBOQTemplateItemMapEntity pRMPreBOQTemplateItemMapEntity in pRMPreBOQTemplateItemMapEntityList)
            {
                returnCode = (this as IPRMPreBOQTemplateItemMapDataAccess).Update(pRMPreBOQTemplateItemMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMPreBOQTemplateItemMapDataAccess.Delete(PRMPreBOQTemplateItemMapEntity pRMPreBOQTemplateItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMPreBOQTemplateItemMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMPreBOQTemplateItemMapEntity, filterExpression, option);
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

        private Int64 Delete(PRMPreBOQTemplateItemMapEntity pRMPreBOQTemplateItemMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQTemplateItemMap_SET";

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
                                throw new ArgumentException("PRMPreBOQTemplateItemMapEntity already exists. Please specify another PRMPreBOQTemplateItemMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMPreBOQTemplateItemMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMPreBOQTemplateItemMapEntity already exists. Please specify another PRMPreBOQTemplateItemMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMPreBOQTemplateItemMapEntity pRMPreBOQTemplateItemMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQTemplateItemMap_SET";

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

        IList<Int64> IPRMPreBOQTemplateItemMapDataAccess.Delete(IList<PRMPreBOQTemplateItemMapEntity> pRMPreBOQTemplateItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMPreBOQTemplateItemMapEntity pRMPreBOQTemplateItemMapEntity in pRMPreBOQTemplateItemMapEntityList)
            {
                returnCode = (this as IPRMPreBOQTemplateItemMapDataAccess).Delete(pRMPreBOQTemplateItemMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMPreBOQTemplateItemMapEntity> IPRMPreBOQTemplateItemMapDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMPreBOQTemplateItemMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMPreBOQTemplateItemMapEntity> list = CreateEntityBuilder<PRMPreBOQTemplateItemMapEntity>().BuildEntities(reader);

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

        DataTable IPRMPreBOQTemplateItemMapDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMPreBOQTemplateItemMap_GET";

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
