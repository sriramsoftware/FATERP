// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2013, 01:41:30




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
    internal sealed partial class CMConsultantDataAccess : BaseDataAccess, ICMConsultantDataAccess
    {
        #region Constructors

        public CMConsultantDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMConsultantEntity> CreateEntityBuilder<CMConsultantEntity>()
        {
            return (new CMConsultantBuilder()) as IEntityBuilder<CMConsultantEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMConsultantDataAccess.Add(CMConsultantEntity cMConsultantEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMConsultantEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMConsultantEntity, option);
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

        private Int64 Add(CMConsultantEntity cMConsultantEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConsultant_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ConsultantID");

                Database.AddInParameter(cmd, "@MemberID", DbType.Int64, cMConsultantEntity.MemberID);	
                Database.AddInParameter(cmd, "@OutsourceCategoryID", DbType.Int64, cMConsultantEntity.OutsourceCategoryID);	
                Database.AddInParameter(cmd, "@Name", DbType.String, cMConsultantEntity.Name);	
                Database.AddInParameter(cmd, "@ImageUrl", DbType.String, cMConsultantEntity.ImageUrl);	
                Database.AddInParameter(cmd, "@CurrentPosition", DbType.String, cMConsultantEntity.CurrentPosition);	
                Database.AddInParameter(cmd, "@InstitueName", DbType.String, cMConsultantEntity.InstitueName);	
                Database.AddInParameter(cmd, "@EmailAddress1", DbType.String, cMConsultantEntity.EmailAddress1);	
                Database.AddInParameter(cmd, "@EmailAddress2", DbType.String, cMConsultantEntity.EmailAddress2);	
                Database.AddInParameter(cmd, "@ContactNo1", DbType.String, cMConsultantEntity.ContactNo1);	
                Database.AddInParameter(cmd, "@ContactNo2", DbType.String, cMConsultantEntity.ContactNo2);	
                Database.AddInParameter(cmd, "@Phone", DbType.String, cMConsultantEntity.Phone);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMConsultantEntity.Remarks);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMConsultantEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMConsultantEntity already exists. Please specify another CMConsultantEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMConsultantEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMConsultantEntity already exists. Please specify another CMConsultantEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMConsultantEntity cMConsultantEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConsultant_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ConsultantID", db);

                db.AddInParameter(cmd, "@MemberID", DbType.Int64, cMConsultantEntity.MemberID);
                db.AddInParameter(cmd, "@OutsourceCategoryID", DbType.Int64, cMConsultantEntity.OutsourceCategoryID);
                db.AddInParameter(cmd, "@Name", DbType.String, cMConsultantEntity.Name);
                db.AddInParameter(cmd, "@ImageUrl", DbType.String, cMConsultantEntity.ImageUrl);
                db.AddInParameter(cmd, "@CurrentPosition", DbType.String, cMConsultantEntity.CurrentPosition);
                db.AddInParameter(cmd, "@InstitueName", DbType.String, cMConsultantEntity.InstitueName);
                db.AddInParameter(cmd, "@EmailAddress1", DbType.String, cMConsultantEntity.EmailAddress1);
                db.AddInParameter(cmd, "@EmailAddress2", DbType.String, cMConsultantEntity.EmailAddress2);
                db.AddInParameter(cmd, "@ContactNo1", DbType.String, cMConsultantEntity.ContactNo1);
                db.AddInParameter(cmd, "@ContactNo2", DbType.String, cMConsultantEntity.ContactNo2);
                db.AddInParameter(cmd, "@Phone", DbType.String, cMConsultantEntity.Phone);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMConsultantEntity.Remarks);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMConsultantEntity.IsRemoved);

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

        IList<Int64> ICMConsultantDataAccess.Add(IList<CMConsultantEntity> cMConsultantEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMConsultantEntity cMConsultantEntity in cMConsultantEntityList)
            {
                returnCode = (this as ICMConsultantDataAccess).Add(cMConsultantEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMConsultantDataAccess.Update(CMConsultantEntity cMConsultantEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMConsultantEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMConsultantEntity, filterExpression, option);
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

        private Int64 Update(CMConsultantEntity cMConsultantEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConsultant_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ConsultantID", DbType.Int64, cMConsultantEntity.ConsultantID);
                Database.AddInParameter(cmd, "@MemberID", DbType.Int64, cMConsultantEntity.MemberID);
                Database.AddInParameter(cmd, "@OutsourceCategoryID", DbType.Int64, cMConsultantEntity.OutsourceCategoryID);
                Database.AddInParameter(cmd, "@Name", DbType.String, cMConsultantEntity.Name);
                Database.AddInParameter(cmd, "@ImageUrl", DbType.String, cMConsultantEntity.ImageUrl);
                Database.AddInParameter(cmd, "@CurrentPosition", DbType.String, cMConsultantEntity.CurrentPosition);
                Database.AddInParameter(cmd, "@InstitueName", DbType.String, cMConsultantEntity.InstitueName);
                Database.AddInParameter(cmd, "@EmailAddress1", DbType.String, cMConsultantEntity.EmailAddress1);
                Database.AddInParameter(cmd, "@EmailAddress2", DbType.String, cMConsultantEntity.EmailAddress2);
                Database.AddInParameter(cmd, "@ContactNo1", DbType.String, cMConsultantEntity.ContactNo1);
                Database.AddInParameter(cmd, "@ContactNo2", DbType.String, cMConsultantEntity.ContactNo2);
                Database.AddInParameter(cmd, "@Phone", DbType.String, cMConsultantEntity.Phone);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMConsultantEntity.Remarks);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMConsultantEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMConsultantEntity already exists. Please specify another CMConsultantEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMConsultantEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMConsultantEntity already exists. Please specify another CMConsultantEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMConsultantEntity cMConsultantEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConsultant_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ConsultantID", DbType.Int64, cMConsultantEntity.ConsultantID);
                db.AddInParameter(cmd, "@MemberID", DbType.Int64, cMConsultantEntity.MemberID);
                db.AddInParameter(cmd, "@OutsourceCategoryID", DbType.Int64, cMConsultantEntity.OutsourceCategoryID);
                db.AddInParameter(cmd, "@Name", DbType.String, cMConsultantEntity.Name);
                db.AddInParameter(cmd, "@ImageUrl", DbType.String, cMConsultantEntity.ImageUrl);
                db.AddInParameter(cmd, "@CurrentPosition", DbType.String, cMConsultantEntity.CurrentPosition);
                db.AddInParameter(cmd, "@InstitueName", DbType.String, cMConsultantEntity.InstitueName);
                db.AddInParameter(cmd, "@EmailAddress1", DbType.String, cMConsultantEntity.EmailAddress1);
                db.AddInParameter(cmd, "@EmailAddress2", DbType.String, cMConsultantEntity.EmailAddress2);
                db.AddInParameter(cmd, "@ContactNo1", DbType.String, cMConsultantEntity.ContactNo1);
                db.AddInParameter(cmd, "@ContactNo2", DbType.String, cMConsultantEntity.ContactNo2);
                db.AddInParameter(cmd, "@Phone", DbType.String, cMConsultantEntity.Phone);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMConsultantEntity.Remarks);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMConsultantEntity.IsRemoved);

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

        IList<Int64> ICMConsultantDataAccess.Update(IList<CMConsultantEntity> cMConsultantEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMConsultantEntity cMConsultantEntity in cMConsultantEntityList)
            {
                returnCode = (this as ICMConsultantDataAccess).Update(cMConsultantEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMConsultantDataAccess.Delete(CMConsultantEntity cMConsultantEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMConsultantEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMConsultantEntity, filterExpression, option);
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

        private Int64 Delete(CMConsultantEntity cMConsultantEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConsultant_SET";

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
                                throw new ArgumentException("CMConsultantEntity already exists. Please specify another CMConsultantEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMConsultantEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMConsultantEntity already exists. Please specify another CMConsultantEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMConsultantEntity cMConsultantEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConsultant_SET";

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

        IList<Int64> ICMConsultantDataAccess.Delete(IList<CMConsultantEntity> cMConsultantEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMConsultantEntity cMConsultantEntity in cMConsultantEntityList)
            {
                returnCode = (this as ICMConsultantDataAccess).Delete(cMConsultantEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMConsultantEntity> ICMConsultantDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMConsultant_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMConsultantEntity> list = CreateEntityBuilder<CMConsultantEntity>().BuildEntities(reader);

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

        DataTable ICMConsultantDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMConsultant_GET";

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
