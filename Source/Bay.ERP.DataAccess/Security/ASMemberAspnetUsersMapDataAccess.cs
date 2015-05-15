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
    internal sealed partial class ASMemberAspnetUsersMapDataAccess : BaseDataAccess, IASMemberAspnetUsersMapDataAccess
    {
        #region Constructors

        public ASMemberAspnetUsersMapDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ASMemberAspnetUsersMapEntity> CreateEntityBuilder<ASMemberAspnetUsersMapEntity>()
        {
            return (new ASMemberAspnetUsersMapBuilder()) as IEntityBuilder<ASMemberAspnetUsersMapEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IASMemberAspnetUsersMapDataAccess.Add(ASMemberAspnetUsersMapEntity aSMemberAspnetUsersMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aSMemberAspnetUsersMapEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aSMemberAspnetUsersMapEntity, option);
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

        private Int64 Add(ASMemberAspnetUsersMapEntity aSMemberAspnetUsersMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASMemberAspnetUsersMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ASMemberAspnetUsersMapID");

                Database.AddInParameter(cmd, "@MemberID", DbType.Int64, aSMemberAspnetUsersMapEntity.MemberID);	
                Database.AddInParameter(cmd, "@UserId", DbType.Guid, aSMemberAspnetUsersMapEntity.UserId);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ASMemberAspnetUsersMapEntity already exists. Please specify another ASMemberAspnetUsersMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ASMemberAspnetUsersMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ASMemberAspnetUsersMapEntity already exists. Please specify another ASMemberAspnetUsersMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ASMemberAspnetUsersMapEntity aSMemberAspnetUsersMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASMemberAspnetUsersMap_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ASMemberAspnetUsersMapID", db);

                db.AddInParameter(cmd, "@MemberID", DbType.Int64, aSMemberAspnetUsersMapEntity.MemberID);
                db.AddInParameter(cmd, "@UserId", DbType.Guid, aSMemberAspnetUsersMapEntity.UserId);

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

        IList<Int64> IASMemberAspnetUsersMapDataAccess.Add(IList<ASMemberAspnetUsersMapEntity> aSMemberAspnetUsersMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ASMemberAspnetUsersMapEntity aSMemberAspnetUsersMapEntity in aSMemberAspnetUsersMapEntityList)
            {
                returnCode = (this as IASMemberAspnetUsersMapDataAccess).Add(aSMemberAspnetUsersMapEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IASMemberAspnetUsersMapDataAccess.Update(ASMemberAspnetUsersMapEntity aSMemberAspnetUsersMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aSMemberAspnetUsersMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aSMemberAspnetUsersMapEntity, filterExpression, option);
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

        private Int64 Update(ASMemberAspnetUsersMapEntity aSMemberAspnetUsersMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASMemberAspnetUsersMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ASMemberAspnetUsersMapID", DbType.Int64, aSMemberAspnetUsersMapEntity.ASMemberAspnetUsersMapID);
                Database.AddInParameter(cmd, "@MemberID", DbType.Int64, aSMemberAspnetUsersMapEntity.MemberID);
                Database.AddInParameter(cmd, "@UserId", DbType.Guid, aSMemberAspnetUsersMapEntity.UserId);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ASMemberAspnetUsersMapEntity already exists. Please specify another ASMemberAspnetUsersMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ASMemberAspnetUsersMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ASMemberAspnetUsersMapEntity already exists. Please specify another ASMemberAspnetUsersMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ASMemberAspnetUsersMapEntity aSMemberAspnetUsersMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASMemberAspnetUsersMap_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ASMemberAspnetUsersMapID", DbType.Int64, aSMemberAspnetUsersMapEntity.ASMemberAspnetUsersMapID);
                db.AddInParameter(cmd, "@MemberID", DbType.Int64, aSMemberAspnetUsersMapEntity.MemberID);
                db.AddInParameter(cmd, "@UserId", DbType.Guid, aSMemberAspnetUsersMapEntity.UserId);

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

        IList<Int64> IASMemberAspnetUsersMapDataAccess.Update(IList<ASMemberAspnetUsersMapEntity> aSMemberAspnetUsersMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ASMemberAspnetUsersMapEntity aSMemberAspnetUsersMapEntity in aSMemberAspnetUsersMapEntityList)
            {
                returnCode = (this as IASMemberAspnetUsersMapDataAccess).Update(aSMemberAspnetUsersMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IASMemberAspnetUsersMapDataAccess.Delete(ASMemberAspnetUsersMapEntity aSMemberAspnetUsersMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aSMemberAspnetUsersMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aSMemberAspnetUsersMapEntity, filterExpression, option);
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

        private Int64 Delete(ASMemberAspnetUsersMapEntity aSMemberAspnetUsersMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASMemberAspnetUsersMap_SET";

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
                                throw new ArgumentException("ASMemberAspnetUsersMapEntity already exists. Please specify another ASMemberAspnetUsersMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ASMemberAspnetUsersMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ASMemberAspnetUsersMapEntity already exists. Please specify another ASMemberAspnetUsersMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ASMemberAspnetUsersMapEntity aSMemberAspnetUsersMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASMemberAspnetUsersMap_SET";

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

        IList<Int64> IASMemberAspnetUsersMapDataAccess.Delete(IList<ASMemberAspnetUsersMapEntity> aSMemberAspnetUsersMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ASMemberAspnetUsersMapEntity aSMemberAspnetUsersMapEntity in aSMemberAspnetUsersMapEntityList)
            {
                returnCode = (this as IASMemberAspnetUsersMapDataAccess).Delete(aSMemberAspnetUsersMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ASMemberAspnetUsersMapEntity> IASMemberAspnetUsersMapDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ASMemberAspnetUsersMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ASMemberAspnetUsersMapEntity> list = CreateEntityBuilder<ASMemberAspnetUsersMapEntity>().BuildEntities(reader);

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

        DataTable IASMemberAspnetUsersMapDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ASMemberAspnetUsersMap_GET";

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
