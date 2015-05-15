// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Feb-2012, 06:02:47




using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.IO;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;
using Bay.ERP.DataAccess;

namespace Bay.ERP.DataAccess
{
    internal sealed partial class CMNDashboardItemDataAccess : BaseDataAccess, ICMNDashboardItemDataAccess
    {
        #region Constructors

        public CMNDashboardItemDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMNDashboardItemEntity> CreateEntityBuilder<CMNDashboardItemEntity>()
        {
            return (new CMNDashboardItemBuilder()) as IEntityBuilder<CMNDashboardItemEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMNDashboardItemDataAccess.Add(CMNDashboardItemEntity cMNDashboardItemEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMNDashboardItemEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMNDashboardItemEntity, option);
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

        private Int64 Add(CMNDashboardItemEntity cMNDashboardItemEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNDashboardItem_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "DashboardItemID");

                Database.AddInParameter(cmd, "@ParentDashboardItemID", DbType.Int64, cMNDashboardItemEntity.ParentDashboardItemID);	
                Database.AddInParameter(cmd, "@Title", DbType.String, cMNDashboardItemEntity.Title);	
                Database.AddInParameter(cmd, "@TittleColor", DbType.String, cMNDashboardItemEntity.TittleColor);	
                Database.AddInParameter(cmd, "@Description", DbType.String, cMNDashboardItemEntity.Description);	
                Database.AddInParameter(cmd, "@DescriptionColor", DbType.String, cMNDashboardItemEntity.DescriptionColor);	
                Database.AddInParameter(cmd, "@ImageUrl", DbType.String, cMNDashboardItemEntity.ImageUrl);	
                Database.AddInParameter(cmd, "@HoverImageUrl", DbType.String, cMNDashboardItemEntity.HoverImageUrl);	
                Database.AddInParameter(cmd, "@NavigationUrl", DbType.String, cMNDashboardItemEntity.NavigationUrl);	
                Database.AddInParameter(cmd, "@IsPopup", DbType.Boolean, cMNDashboardItemEntity.IsPopup);	
                Database.AddInParameter(cmd, "@HoverMessage", DbType.String, cMNDashboardItemEntity.HoverMessage);	
                Database.AddInParameter(cmd, "@SequenceID", DbType.Int32, cMNDashboardItemEntity.SequenceID);	
                Database.AddInParameter(cmd, "@ImageWidth", DbType.Int32, cMNDashboardItemEntity.ImageWidth);	
                Database.AddInParameter(cmd, "@ImageHeight", DbType.Int32, cMNDashboardItemEntity.ImageHeight);	
                Database.AddInParameter(cmd, "@DashboardItemWidth", DbType.Int32, cMNDashboardItemEntity.DashboardItemWidth);	
                Database.AddInParameter(cmd, "@DashboardItemHeight", DbType.Int32, cMNDashboardItemEntity.DashboardItemHeight);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMNDashboardItemEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMNDashboardItemEntity already exists. Please specify another CMNDashboardItemEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNDashboardItemEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNDashboardItemEntity already exists. Please specify another CMNDashboardItemEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMNDashboardItemEntity cMNDashboardItemEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNDashboardItem_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "DashboardItemID", db);

                db.AddInParameter(cmd, "@ParentDashboardItemID", DbType.Int64, cMNDashboardItemEntity.ParentDashboardItemID);
                db.AddInParameter(cmd, "@Title", DbType.String, cMNDashboardItemEntity.Title);
                db.AddInParameter(cmd, "@TittleColor", DbType.String, cMNDashboardItemEntity.TittleColor);
                db.AddInParameter(cmd, "@Description", DbType.String, cMNDashboardItemEntity.Description);
                db.AddInParameter(cmd, "@DescriptionColor", DbType.String, cMNDashboardItemEntity.DescriptionColor);
                db.AddInParameter(cmd, "@ImageUrl", DbType.String, cMNDashboardItemEntity.ImageUrl);
                db.AddInParameter(cmd, "@HoverImageUrl", DbType.String, cMNDashboardItemEntity.HoverImageUrl);
                db.AddInParameter(cmd, "@NavigationUrl", DbType.String, cMNDashboardItemEntity.NavigationUrl);
                db.AddInParameter(cmd, "@IsPopup", DbType.Boolean, cMNDashboardItemEntity.IsPopup);
                db.AddInParameter(cmd, "@HoverMessage", DbType.String, cMNDashboardItemEntity.HoverMessage);
                db.AddInParameter(cmd, "@SequenceID", DbType.Int32, cMNDashboardItemEntity.SequenceID);
                db.AddInParameter(cmd, "@ImageWidth", DbType.Int32, cMNDashboardItemEntity.ImageWidth);
                db.AddInParameter(cmd, "@ImageHeight", DbType.Int32, cMNDashboardItemEntity.ImageHeight);
                db.AddInParameter(cmd, "@DashboardItemWidth", DbType.Int32, cMNDashboardItemEntity.DashboardItemWidth);
                db.AddInParameter(cmd, "@DashboardItemHeight", DbType.Int32, cMNDashboardItemEntity.DashboardItemHeight);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMNDashboardItemEntity.IsRemoved);

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

        IList<Int64> ICMNDashboardItemDataAccess.Add(IList<CMNDashboardItemEntity> cMNDashboardItemEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMNDashboardItemEntity cMNDashboardItemEntity in cMNDashboardItemEntityList)
            {
                returnCode = (this as ICMNDashboardItemDataAccess).Add(cMNDashboardItemEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMNDashboardItemDataAccess.Update(CMNDashboardItemEntity cMNDashboardItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMNDashboardItemEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMNDashboardItemEntity, filterExpression, option);
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

        private Int64 Update(CMNDashboardItemEntity cMNDashboardItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNDashboardItem_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@DashboardItemID", DbType.Int64, cMNDashboardItemEntity.DashboardItemID);
                Database.AddInParameter(cmd, "@ParentDashboardItemID", DbType.Int64, cMNDashboardItemEntity.ParentDashboardItemID);
                Database.AddInParameter(cmd, "@Title", DbType.String, cMNDashboardItemEntity.Title);
                Database.AddInParameter(cmd, "@TittleColor", DbType.String, cMNDashboardItemEntity.TittleColor);
                Database.AddInParameter(cmd, "@Description", DbType.String, cMNDashboardItemEntity.Description);
                Database.AddInParameter(cmd, "@DescriptionColor", DbType.String, cMNDashboardItemEntity.DescriptionColor);
                Database.AddInParameter(cmd, "@ImageUrl", DbType.String, cMNDashboardItemEntity.ImageUrl);
                Database.AddInParameter(cmd, "@HoverImageUrl", DbType.String, cMNDashboardItemEntity.HoverImageUrl);
                Database.AddInParameter(cmd, "@NavigationUrl", DbType.String, cMNDashboardItemEntity.NavigationUrl);
                Database.AddInParameter(cmd, "@IsPopup", DbType.Boolean, cMNDashboardItemEntity.IsPopup);
                Database.AddInParameter(cmd, "@HoverMessage", DbType.String, cMNDashboardItemEntity.HoverMessage);
                Database.AddInParameter(cmd, "@SequenceID", DbType.Int32, cMNDashboardItemEntity.SequenceID);
                Database.AddInParameter(cmd, "@ImageWidth", DbType.Int32, cMNDashboardItemEntity.ImageWidth);
                Database.AddInParameter(cmd, "@ImageHeight", DbType.Int32, cMNDashboardItemEntity.ImageHeight);
                Database.AddInParameter(cmd, "@DashboardItemWidth", DbType.Int32, cMNDashboardItemEntity.DashboardItemWidth);
                Database.AddInParameter(cmd, "@DashboardItemHeight", DbType.Int32, cMNDashboardItemEntity.DashboardItemHeight);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMNDashboardItemEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMNDashboardItemEntity already exists. Please specify another CMNDashboardItemEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNDashboardItemEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNDashboardItemEntity already exists. Please specify another CMNDashboardItemEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMNDashboardItemEntity cMNDashboardItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNDashboardItem_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@DashboardItemID", DbType.Int64, cMNDashboardItemEntity.DashboardItemID);
                db.AddInParameter(cmd, "@ParentDashboardItemID", DbType.Int64, cMNDashboardItemEntity.ParentDashboardItemID);
                db.AddInParameter(cmd, "@Title", DbType.String, cMNDashboardItemEntity.Title);
                db.AddInParameter(cmd, "@TittleColor", DbType.String, cMNDashboardItemEntity.TittleColor);
                db.AddInParameter(cmd, "@Description", DbType.String, cMNDashboardItemEntity.Description);
                db.AddInParameter(cmd, "@DescriptionColor", DbType.String, cMNDashboardItemEntity.DescriptionColor);
                db.AddInParameter(cmd, "@ImageUrl", DbType.String, cMNDashboardItemEntity.ImageUrl);
                db.AddInParameter(cmd, "@HoverImageUrl", DbType.String, cMNDashboardItemEntity.HoverImageUrl);
                db.AddInParameter(cmd, "@NavigationUrl", DbType.String, cMNDashboardItemEntity.NavigationUrl);
                db.AddInParameter(cmd, "@IsPopup", DbType.Boolean, cMNDashboardItemEntity.IsPopup);
                db.AddInParameter(cmd, "@HoverMessage", DbType.String, cMNDashboardItemEntity.HoverMessage);
                db.AddInParameter(cmd, "@SequenceID", DbType.Int32, cMNDashboardItemEntity.SequenceID);
                db.AddInParameter(cmd, "@ImageWidth", DbType.Int32, cMNDashboardItemEntity.ImageWidth);
                db.AddInParameter(cmd, "@ImageHeight", DbType.Int32, cMNDashboardItemEntity.ImageHeight);
                db.AddInParameter(cmd, "@DashboardItemWidth", DbType.Int32, cMNDashboardItemEntity.DashboardItemWidth);
                db.AddInParameter(cmd, "@DashboardItemHeight", DbType.Int32, cMNDashboardItemEntity.DashboardItemHeight);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMNDashboardItemEntity.IsRemoved);

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

        IList<Int64> ICMNDashboardItemDataAccess.Update(IList<CMNDashboardItemEntity> cMNDashboardItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMNDashboardItemEntity cMNDashboardItemEntity in cMNDashboardItemEntityList)
            {
                returnCode = (this as ICMNDashboardItemDataAccess).Update(cMNDashboardItemEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMNDashboardItemDataAccess.Delete(CMNDashboardItemEntity cMNDashboardItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMNDashboardItemEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMNDashboardItemEntity, filterExpression, option);
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

        private Int64 Delete(CMNDashboardItemEntity cMNDashboardItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNDashboardItem_SET";

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
                                throw new ArgumentException("CMNDashboardItemEntity already exists. Please specify another CMNDashboardItemEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNDashboardItemEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNDashboardItemEntity already exists. Please specify another CMNDashboardItemEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMNDashboardItemEntity cMNDashboardItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNDashboardItem_SET";

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

        IList<Int64> ICMNDashboardItemDataAccess.Delete(IList<CMNDashboardItemEntity> cMNDashboardItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMNDashboardItemEntity cMNDashboardItemEntity in cMNDashboardItemEntityList)
            {
                returnCode = (this as ICMNDashboardItemDataAccess).Delete(cMNDashboardItemEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMNDashboardItemEntity> ICMNDashboardItemDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMNDashboardItem_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMNDashboardItemEntity> list = CreateEntityBuilder<CMNDashboardItemEntity>().BuildEntities(reader);

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

        DataTable ICMNDashboardItemDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMNDashboardItem_GET";

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
