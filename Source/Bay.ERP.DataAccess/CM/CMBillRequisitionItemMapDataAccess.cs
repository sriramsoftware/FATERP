// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Jan-2013, 11:55:33




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
    internal sealed partial class CMBillRequisitionItemMapDataAccess : BaseDataAccess, ICMBillRequisitionItemMapDataAccess
    {
        #region Constructors

        public CMBillRequisitionItemMapDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMBillRequisitionItemMapEntity> CreateEntityBuilder<CMBillRequisitionItemMapEntity>()
        {
            return (new CMBillRequisitionItemMapBuilder()) as IEntityBuilder<CMBillRequisitionItemMapEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMBillRequisitionItemMapDataAccess.Add(CMBillRequisitionItemMapEntity cMBillRequisitionItemMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMBillRequisitionItemMapEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMBillRequisitionItemMapEntity, option);
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

        private Int64 Add(CMBillRequisitionItemMapEntity cMBillRequisitionItemMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillRequisitionItemMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "BillRequisitionItemMapID");

                Database.AddInParameter(cmd, "@BillID", DbType.Int64, cMBillRequisitionItemMapEntity.BillID);	
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, cMBillRequisitionItemMapEntity.RequisitionID);	
                Database.AddInParameter(cmd, "@RequisitionItemID", DbType.Int64, cMBillRequisitionItemMapEntity.RequisitionItemID);	
                Database.AddInParameter(cmd, "@RequisitionPrice", DbType.Decimal, cMBillRequisitionItemMapEntity.RequisitionPrice);	
                Database.AddInParameter(cmd, "@BillPrice", DbType.Decimal, cMBillRequisitionItemMapEntity.BillPrice);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMBillRequisitionItemMapEntity already exists. Please specify another CMBillRequisitionItemMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMBillRequisitionItemMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMBillRequisitionItemMapEntity already exists. Please specify another CMBillRequisitionItemMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMBillRequisitionItemMapEntity cMBillRequisitionItemMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillRequisitionItemMap_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "BillRequisitionItemMapID", db);

                db.AddInParameter(cmd, "@BillID", DbType.Int64, cMBillRequisitionItemMapEntity.BillID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, cMBillRequisitionItemMapEntity.RequisitionID);
                db.AddInParameter(cmd, "@RequisitionItemID", DbType.Int64, cMBillRequisitionItemMapEntity.RequisitionItemID);
                db.AddInParameter(cmd, "@RequisitionPrice", DbType.Decimal, cMBillRequisitionItemMapEntity.RequisitionPrice);
                db.AddInParameter(cmd, "@BillPrice", DbType.Decimal, cMBillRequisitionItemMapEntity.BillPrice);

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

        IList<Int64> ICMBillRequisitionItemMapDataAccess.Add(IList<CMBillRequisitionItemMapEntity> cMBillRequisitionItemMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMBillRequisitionItemMapEntity cMBillRequisitionItemMapEntity in cMBillRequisitionItemMapEntityList)
            {
                returnCode = (this as ICMBillRequisitionItemMapDataAccess).Add(cMBillRequisitionItemMapEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMBillRequisitionItemMapDataAccess.Update(CMBillRequisitionItemMapEntity cMBillRequisitionItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMBillRequisitionItemMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMBillRequisitionItemMapEntity, filterExpression, option);
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

        private Int64 Update(CMBillRequisitionItemMapEntity cMBillRequisitionItemMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillRequisitionItemMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@BillRequisitionItemMapID", DbType.Int64, cMBillRequisitionItemMapEntity.BillRequisitionItemMapID);
                Database.AddInParameter(cmd, "@BillID", DbType.Int64, cMBillRequisitionItemMapEntity.BillID);
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, cMBillRequisitionItemMapEntity.RequisitionID);
                Database.AddInParameter(cmd, "@RequisitionItemID", DbType.Int64, cMBillRequisitionItemMapEntity.RequisitionItemID);
                Database.AddInParameter(cmd, "@RequisitionPrice", DbType.Decimal, cMBillRequisitionItemMapEntity.RequisitionPrice);
                Database.AddInParameter(cmd, "@BillPrice", DbType.Decimal, cMBillRequisitionItemMapEntity.BillPrice);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMBillRequisitionItemMapEntity already exists. Please specify another CMBillRequisitionItemMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMBillRequisitionItemMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMBillRequisitionItemMapEntity already exists. Please specify another CMBillRequisitionItemMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMBillRequisitionItemMapEntity cMBillRequisitionItemMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillRequisitionItemMap_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@BillRequisitionItemMapID", DbType.Int64, cMBillRequisitionItemMapEntity.BillRequisitionItemMapID);
                db.AddInParameter(cmd, "@BillID", DbType.Int64, cMBillRequisitionItemMapEntity.BillID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, cMBillRequisitionItemMapEntity.RequisitionID);
                db.AddInParameter(cmd, "@RequisitionItemID", DbType.Int64, cMBillRequisitionItemMapEntity.RequisitionItemID);
                db.AddInParameter(cmd, "@RequisitionPrice", DbType.Decimal, cMBillRequisitionItemMapEntity.RequisitionPrice);
                db.AddInParameter(cmd, "@BillPrice", DbType.Decimal, cMBillRequisitionItemMapEntity.BillPrice);

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

        IList<Int64> ICMBillRequisitionItemMapDataAccess.Update(IList<CMBillRequisitionItemMapEntity> cMBillRequisitionItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMBillRequisitionItemMapEntity cMBillRequisitionItemMapEntity in cMBillRequisitionItemMapEntityList)
            {
                returnCode = (this as ICMBillRequisitionItemMapDataAccess).Update(cMBillRequisitionItemMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMBillRequisitionItemMapDataAccess.Delete(CMBillRequisitionItemMapEntity cMBillRequisitionItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMBillRequisitionItemMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMBillRequisitionItemMapEntity, filterExpression, option);
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

        private Int64 Delete(CMBillRequisitionItemMapEntity cMBillRequisitionItemMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillRequisitionItemMap_SET";

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
                                throw new ArgumentException("CMBillRequisitionItemMapEntity already exists. Please specify another CMBillRequisitionItemMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMBillRequisitionItemMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMBillRequisitionItemMapEntity already exists. Please specify another CMBillRequisitionItemMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMBillRequisitionItemMapEntity cMBillRequisitionItemMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillRequisitionItemMap_SET";

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

        IList<Int64> ICMBillRequisitionItemMapDataAccess.Delete(IList<CMBillRequisitionItemMapEntity> cMBillRequisitionItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMBillRequisitionItemMapEntity cMBillRequisitionItemMapEntity in cMBillRequisitionItemMapEntityList)
            {
                returnCode = (this as ICMBillRequisitionItemMapDataAccess).Delete(cMBillRequisitionItemMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMBillRequisitionItemMapEntity> ICMBillRequisitionItemMapDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMBillRequisitionItemMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMBillRequisitionItemMapEntity> list = CreateEntityBuilder<CMBillRequisitionItemMapEntity>().BuildEntities(reader);

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

        DataTable ICMBillRequisitionItemMapDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMBillRequisitionItemMap_GET";

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
