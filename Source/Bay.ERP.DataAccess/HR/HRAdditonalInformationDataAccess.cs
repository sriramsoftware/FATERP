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
    internal sealed partial class HRAdditonalInformationDataAccess : BaseDataAccess, IHRAdditonalInformationDataAccess
    {
        #region Constructors

        public HRAdditonalInformationDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HRAdditonalInformationEntity> CreateEntityBuilder<HRAdditonalInformationEntity>()
        {
            return (new HRAdditonalInformationBuilder()) as IEntityBuilder<HRAdditonalInformationEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHRAdditonalInformationDataAccess.Add(HRAdditonalInformationEntity hRAdditonalInformationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hRAdditonalInformationEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hRAdditonalInformationEntity, option);
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

        private Int64 Add(HRAdditonalInformationEntity hRAdditonalInformationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRAdditonalInformation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "AdditonalInformationID");

                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hRAdditonalInformationEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@EmployeeAdditionalInformationCategoryID", DbType.Int64, hRAdditonalInformationEntity.EmployeeAdditionalInformationCategoryID);	
                Database.AddInParameter(cmd, "@Value", DbType.Decimal, hRAdditonalInformationEntity.Value);	
                Database.AddInParameter(cmd, "@ExtraStringColumn", DbType.String, hRAdditonalInformationEntity.ExtraStringColumn);	
                Database.AddInParameter(cmd, "@ExtraField1", DbType.String, hRAdditonalInformationEntity.ExtraField1);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hRAdditonalInformationEntity.Remarks);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HRAdditonalInformationEntity already exists. Please specify another HRAdditonalInformationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRAdditonalInformationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRAdditonalInformationEntity already exists. Please specify another HRAdditonalInformationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HRAdditonalInformationEntity hRAdditonalInformationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRAdditonalInformation_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "AdditonalInformationID", db);

                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hRAdditonalInformationEntity.EmployeeID);
                db.AddInParameter(cmd, "@EmployeeAdditionalInformationCategoryID", DbType.Int64, hRAdditonalInformationEntity.EmployeeAdditionalInformationCategoryID);
                db.AddInParameter(cmd, "@Value", DbType.Decimal, hRAdditonalInformationEntity.Value);
                db.AddInParameter(cmd, "@ExtraStringColumn", DbType.String, hRAdditonalInformationEntity.ExtraStringColumn);
                db.AddInParameter(cmd, "@ExtraField1", DbType.String, hRAdditonalInformationEntity.ExtraField1);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hRAdditonalInformationEntity.Remarks);

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

        IList<Int64> IHRAdditonalInformationDataAccess.Add(IList<HRAdditonalInformationEntity> hRAdditonalInformationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HRAdditonalInformationEntity hRAdditonalInformationEntity in hRAdditonalInformationEntityList)
            {
                returnCode = (this as IHRAdditonalInformationDataAccess).Add(hRAdditonalInformationEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHRAdditonalInformationDataAccess.Update(HRAdditonalInformationEntity hRAdditonalInformationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hRAdditonalInformationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hRAdditonalInformationEntity, filterExpression, option);
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

        private Int64 Update(HRAdditonalInformationEntity hRAdditonalInformationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRAdditonalInformation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@AdditonalInformationID", DbType.Int64, hRAdditonalInformationEntity.AdditonalInformationID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hRAdditonalInformationEntity.EmployeeID);
                Database.AddInParameter(cmd, "@EmployeeAdditionalInformationCategoryID", DbType.Int64, hRAdditonalInformationEntity.EmployeeAdditionalInformationCategoryID);
                Database.AddInParameter(cmd, "@Value", DbType.Decimal, hRAdditonalInformationEntity.Value);
                Database.AddInParameter(cmd, "@ExtraStringColumn", DbType.String, hRAdditonalInformationEntity.ExtraStringColumn);
                Database.AddInParameter(cmd, "@ExtraField1", DbType.String, hRAdditonalInformationEntity.ExtraField1);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hRAdditonalInformationEntity.Remarks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HRAdditonalInformationEntity already exists. Please specify another HRAdditonalInformationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRAdditonalInformationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRAdditonalInformationEntity already exists. Please specify another HRAdditonalInformationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HRAdditonalInformationEntity hRAdditonalInformationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRAdditonalInformation_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@AdditonalInformationID", DbType.Int64, hRAdditonalInformationEntity.AdditonalInformationID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hRAdditonalInformationEntity.EmployeeID);
                db.AddInParameter(cmd, "@EmployeeAdditionalInformationCategoryID", DbType.Int64, hRAdditonalInformationEntity.EmployeeAdditionalInformationCategoryID);
                db.AddInParameter(cmd, "@Value", DbType.Decimal, hRAdditonalInformationEntity.Value);
                db.AddInParameter(cmd, "@ExtraStringColumn", DbType.String, hRAdditonalInformationEntity.ExtraStringColumn);
                db.AddInParameter(cmd, "@ExtraField1", DbType.String, hRAdditonalInformationEntity.ExtraField1);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hRAdditonalInformationEntity.Remarks);

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

        IList<Int64> IHRAdditonalInformationDataAccess.Update(IList<HRAdditonalInformationEntity> hRAdditonalInformationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HRAdditonalInformationEntity hRAdditonalInformationEntity in hRAdditonalInformationEntityList)
            {
                returnCode = (this as IHRAdditonalInformationDataAccess).Update(hRAdditonalInformationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHRAdditonalInformationDataAccess.Delete(HRAdditonalInformationEntity hRAdditonalInformationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hRAdditonalInformationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hRAdditonalInformationEntity, filterExpression, option);
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

        private Int64 Delete(HRAdditonalInformationEntity hRAdditonalInformationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRAdditonalInformation_SET";

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
                                throw new ArgumentException("HRAdditonalInformationEntity already exists. Please specify another HRAdditonalInformationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRAdditonalInformationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRAdditonalInformationEntity already exists. Please specify another HRAdditonalInformationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HRAdditonalInformationEntity hRAdditonalInformationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRAdditonalInformation_SET";

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

        IList<Int64> IHRAdditonalInformationDataAccess.Delete(IList<HRAdditonalInformationEntity> hRAdditonalInformationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HRAdditonalInformationEntity hRAdditonalInformationEntity in hRAdditonalInformationEntityList)
            {
                returnCode = (this as IHRAdditonalInformationDataAccess).Delete(hRAdditonalInformationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HRAdditonalInformationEntity> IHRAdditonalInformationDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HRAdditonalInformation_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HRAdditonalInformationEntity> list = CreateEntityBuilder<HRAdditonalInformationEntity>().BuildEntities(reader);

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

        DataTable IHRAdditonalInformationDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HRAdditonalInformation_GET";

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
