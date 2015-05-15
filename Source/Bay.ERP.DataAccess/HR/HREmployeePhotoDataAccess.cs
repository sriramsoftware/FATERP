// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




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
    internal sealed partial class HREmployeePhotoDataAccess : BaseDataAccess, IHREmployeePhotoDataAccess
    {
        #region Constructors

        public HREmployeePhotoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeePhotoEntity> CreateEntityBuilder<HREmployeePhotoEntity>()
        {
            return (new HREmployeePhotoBuilder()) as IEntityBuilder<HREmployeePhotoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeePhotoDataAccess.Add(HREmployeePhotoEntity hREmployeePhotoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeePhotoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeePhotoEntity, option);
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

        private Int64 Add(HREmployeePhotoEntity hREmployeePhotoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeePhoto_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeePhotoID");

                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeePhotoEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, hREmployeePhotoEntity.CurrentFileName);	
                Database.AddInParameter(cmd, "@Extension", DbType.String, hREmployeePhotoEntity.Extension);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeePhotoEntity.Remarks);	
                Database.AddInParameter(cmd, "@Path", DbType.String, hREmployeePhotoEntity.Path);	
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, hREmployeePhotoEntity.OriginalFileName);	
                Database.AddInParameter(cmd, "@FileType", DbType.String, hREmployeePhotoEntity.FileType);	
                Database.AddInParameter(cmd, "@IsCurrent", DbType.Boolean, hREmployeePhotoEntity.IsCurrent);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeePhotoEntity already exists. Please specify another HREmployeePhotoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeePhotoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeePhotoEntity already exists. Please specify another HREmployeePhotoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeePhotoEntity hREmployeePhotoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeePhoto_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeePhotoID", db);

                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeePhotoEntity.EmployeeID);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, hREmployeePhotoEntity.CurrentFileName);
                db.AddInParameter(cmd, "@Extension", DbType.String, hREmployeePhotoEntity.Extension);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeePhotoEntity.Remarks);
                db.AddInParameter(cmd, "@Path", DbType.String, hREmployeePhotoEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, hREmployeePhotoEntity.OriginalFileName);
                db.AddInParameter(cmd, "@FileType", DbType.String, hREmployeePhotoEntity.FileType);
                db.AddInParameter(cmd, "@IsCurrent", DbType.Boolean, hREmployeePhotoEntity.IsCurrent);

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

        IList<Int64> IHREmployeePhotoDataAccess.Add(IList<HREmployeePhotoEntity> hREmployeePhotoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeePhotoEntity hREmployeePhotoEntity in hREmployeePhotoEntityList)
            {
                returnCode = (this as IHREmployeePhotoDataAccess).Add(hREmployeePhotoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeePhotoDataAccess.Update(HREmployeePhotoEntity hREmployeePhotoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeePhotoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeePhotoEntity, filterExpression, option);
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

        private Int64 Update(HREmployeePhotoEntity hREmployeePhotoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeePhoto_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeePhotoID", DbType.Int64, hREmployeePhotoEntity.EmployeePhotoID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeePhotoEntity.EmployeeID);
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, hREmployeePhotoEntity.CurrentFileName);
                Database.AddInParameter(cmd, "@Extension", DbType.String, hREmployeePhotoEntity.Extension);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeePhotoEntity.Remarks);
                Database.AddInParameter(cmd, "@Path", DbType.String, hREmployeePhotoEntity.Path);
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, hREmployeePhotoEntity.OriginalFileName);
                Database.AddInParameter(cmd, "@FileType", DbType.String, hREmployeePhotoEntity.FileType);
                Database.AddInParameter(cmd, "@IsCurrent", DbType.Boolean, hREmployeePhotoEntity.IsCurrent);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeePhotoEntity already exists. Please specify another HREmployeePhotoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeePhotoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeePhotoEntity already exists. Please specify another HREmployeePhotoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeePhotoEntity hREmployeePhotoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeePhoto_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeePhotoID", DbType.Int64, hREmployeePhotoEntity.EmployeePhotoID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeePhotoEntity.EmployeeID);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, hREmployeePhotoEntity.CurrentFileName);
                db.AddInParameter(cmd, "@Extension", DbType.String, hREmployeePhotoEntity.Extension);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeePhotoEntity.Remarks);
                db.AddInParameter(cmd, "@Path", DbType.String, hREmployeePhotoEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, hREmployeePhotoEntity.OriginalFileName);
                db.AddInParameter(cmd, "@FileType", DbType.String, hREmployeePhotoEntity.FileType);
                db.AddInParameter(cmd, "@IsCurrent", DbType.Boolean, hREmployeePhotoEntity.IsCurrent);

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

        IList<Int64> IHREmployeePhotoDataAccess.Update(IList<HREmployeePhotoEntity> hREmployeePhotoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeePhotoEntity hREmployeePhotoEntity in hREmployeePhotoEntityList)
            {
                returnCode = (this as IHREmployeePhotoDataAccess).Update(hREmployeePhotoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeePhotoDataAccess.Delete(HREmployeePhotoEntity hREmployeePhotoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeePhotoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeePhotoEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeePhotoEntity hREmployeePhotoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeePhoto_SET";

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
                                throw new ArgumentException("HREmployeePhotoEntity already exists. Please specify another HREmployeePhotoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeePhotoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeePhotoEntity already exists. Please specify another HREmployeePhotoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeePhotoEntity hREmployeePhotoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeePhoto_SET";

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

        IList<Int64> IHREmployeePhotoDataAccess.Delete(IList<HREmployeePhotoEntity> hREmployeePhotoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeePhotoEntity hREmployeePhotoEntity in hREmployeePhotoEntityList)
            {
                returnCode = (this as IHREmployeePhotoDataAccess).Delete(hREmployeePhotoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeePhotoEntity> IHREmployeePhotoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeePhoto_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeePhotoEntity> list = CreateEntityBuilder<HREmployeePhotoEntity>().BuildEntities(reader);

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

        DataTable IHREmployeePhotoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeePhoto_GET";

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
