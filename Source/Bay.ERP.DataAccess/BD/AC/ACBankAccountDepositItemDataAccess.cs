// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jul-2013, 11:20:53




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
    internal sealed partial class ACBankAccountDepositItemDataAccess : BaseDataAccess, IACBankAccountDepositItemDataAccess
    {
        #region Constructors

        public ACBankAccountDepositItemDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACBankAccountDepositItemEntity> CreateEntityBuilder<ACBankAccountDepositItemEntity>()
        {
            return (new ACBankAccountDepositItemBuilder()) as IEntityBuilder<ACBankAccountDepositItemEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACBankAccountDepositItemDataAccess.Add(ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCBankAccountDepositItemEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCBankAccountDepositItemEntity, option);
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

        private Int64 Add(ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountDepositItem_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "BankAccountDepositItemID");

                Database.AddInParameter(cmd, "@BankAccountDepositID", DbType.Int64, aCBankAccountDepositItemEntity.BankAccountDepositID);	
                Database.AddInParameter(cmd, "@AccountID", DbType.Int64, aCBankAccountDepositItemEntity.AccountID);	
                Database.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCBankAccountDepositItemEntity.DimensionID);	
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, aCBankAccountDepositItemEntity.ItemID);	
                Database.AddInParameter(cmd, "@Amount", DbType.Decimal, aCBankAccountDepositItemEntity.Amount);	
                Database.AddInParameter(cmd, "@Memo", DbType.String, aCBankAccountDepositItemEntity.Memo);	
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCBankAccountDepositItemEntity.ProjectID);	
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCBankAccountDepositItemEntity.RequisitionID);	
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCBankAccountDepositItemEntity.WorkOrderID);	
                Database.AddInParameter(cmd, "@BillID", DbType.Int64, aCBankAccountDepositItemEntity.BillID);	
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, aCBankAccountDepositItemEntity.ProjectFloorID);	
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, aCBankAccountDepositItemEntity.ProjectFloorUnitID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACBankAccountDepositItemEntity already exists. Please specify another ACBankAccountDepositItemEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACBankAccountDepositItemEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACBankAccountDepositItemEntity already exists. Please specify another ACBankAccountDepositItemEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountDepositItem_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "BankAccountDepositItemID", db);

                db.AddInParameter(cmd, "@BankAccountDepositID", DbType.Int64, aCBankAccountDepositItemEntity.BankAccountDepositID);
                db.AddInParameter(cmd, "@AccountID", DbType.Int64, aCBankAccountDepositItemEntity.AccountID);
                db.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCBankAccountDepositItemEntity.DimensionID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, aCBankAccountDepositItemEntity.ItemID);
                db.AddInParameter(cmd, "@Amount", DbType.Decimal, aCBankAccountDepositItemEntity.Amount);
                db.AddInParameter(cmd, "@Memo", DbType.String, aCBankAccountDepositItemEntity.Memo);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCBankAccountDepositItemEntity.ProjectID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCBankAccountDepositItemEntity.RequisitionID);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCBankAccountDepositItemEntity.WorkOrderID);
                db.AddInParameter(cmd, "@BillID", DbType.Int64, aCBankAccountDepositItemEntity.BillID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, aCBankAccountDepositItemEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, aCBankAccountDepositItemEntity.ProjectFloorUnitID);

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

        IList<Int64> IACBankAccountDepositItemDataAccess.Add(IList<ACBankAccountDepositItemEntity> aCBankAccountDepositItemEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity in aCBankAccountDepositItemEntityList)
            {
                returnCode = (this as IACBankAccountDepositItemDataAccess).Add(aCBankAccountDepositItemEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACBankAccountDepositItemDataAccess.Update(ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCBankAccountDepositItemEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCBankAccountDepositItemEntity, filterExpression, option);
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

        private Int64 Update(ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountDepositItem_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@BankAccountDepositItemID", DbType.Int64, aCBankAccountDepositItemEntity.BankAccountDepositItemID);
                Database.AddInParameter(cmd, "@BankAccountDepositID", DbType.Int64, aCBankAccountDepositItemEntity.BankAccountDepositID);
                Database.AddInParameter(cmd, "@AccountID", DbType.Int64, aCBankAccountDepositItemEntity.AccountID);
                Database.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCBankAccountDepositItemEntity.DimensionID);
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, aCBankAccountDepositItemEntity.ItemID);
                Database.AddInParameter(cmd, "@Amount", DbType.Decimal, aCBankAccountDepositItemEntity.Amount);
                Database.AddInParameter(cmd, "@Memo", DbType.String, aCBankAccountDepositItemEntity.Memo);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCBankAccountDepositItemEntity.ProjectID);
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCBankAccountDepositItemEntity.RequisitionID);
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCBankAccountDepositItemEntity.WorkOrderID);
                Database.AddInParameter(cmd, "@BillID", DbType.Int64, aCBankAccountDepositItemEntity.BillID);
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, aCBankAccountDepositItemEntity.ProjectFloorID);
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, aCBankAccountDepositItemEntity.ProjectFloorUnitID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACBankAccountDepositItemEntity already exists. Please specify another ACBankAccountDepositItemEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACBankAccountDepositItemEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACBankAccountDepositItemEntity already exists. Please specify another ACBankAccountDepositItemEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountDepositItem_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@BankAccountDepositItemID", DbType.Int64, aCBankAccountDepositItemEntity.BankAccountDepositItemID);
                db.AddInParameter(cmd, "@BankAccountDepositID", DbType.Int64, aCBankAccountDepositItemEntity.BankAccountDepositID);
                db.AddInParameter(cmd, "@AccountID", DbType.Int64, aCBankAccountDepositItemEntity.AccountID);
                db.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCBankAccountDepositItemEntity.DimensionID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, aCBankAccountDepositItemEntity.ItemID);
                db.AddInParameter(cmd, "@Amount", DbType.Decimal, aCBankAccountDepositItemEntity.Amount);
                db.AddInParameter(cmd, "@Memo", DbType.String, aCBankAccountDepositItemEntity.Memo);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCBankAccountDepositItemEntity.ProjectID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCBankAccountDepositItemEntity.RequisitionID);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCBankAccountDepositItemEntity.WorkOrderID);
                db.AddInParameter(cmd, "@BillID", DbType.Int64, aCBankAccountDepositItemEntity.BillID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, aCBankAccountDepositItemEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, aCBankAccountDepositItemEntity.ProjectFloorUnitID);

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

        IList<Int64> IACBankAccountDepositItemDataAccess.Update(IList<ACBankAccountDepositItemEntity> aCBankAccountDepositItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity in aCBankAccountDepositItemEntityList)
            {
                returnCode = (this as IACBankAccountDepositItemDataAccess).Update(aCBankAccountDepositItemEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACBankAccountDepositItemDataAccess.Delete(ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCBankAccountDepositItemEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCBankAccountDepositItemEntity, filterExpression, option);
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

        private Int64 Delete(ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountDepositItem_SET";

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
                                throw new ArgumentException("ACBankAccountDepositItemEntity already exists. Please specify another ACBankAccountDepositItemEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACBankAccountDepositItemEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACBankAccountDepositItemEntity already exists. Please specify another ACBankAccountDepositItemEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountDepositItem_SET";

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

        IList<Int64> IACBankAccountDepositItemDataAccess.Delete(IList<ACBankAccountDepositItemEntity> aCBankAccountDepositItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity in aCBankAccountDepositItemEntityList)
            {
                returnCode = (this as IACBankAccountDepositItemDataAccess).Delete(aCBankAccountDepositItemEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACBankAccountDepositItemEntity> IACBankAccountDepositItemDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACBankAccountDepositItem_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACBankAccountDepositItemEntity> list = CreateEntityBuilder<ACBankAccountDepositItemEntity>().BuildEntities(reader);

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

        DataTable IACBankAccountDepositItemDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACBankAccountDepositItem_GET";

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
