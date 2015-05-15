// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;
using System.Diagnostics;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.DataAccess;
using Bay.ERP.BusinessFacade;
using Bay.ERP.Common.Shared;
using Bay.ERP.Common.Helper;

namespace Bay.ERP.BusinessFacade
{
    public sealed partial class MDAccountPaybleStatementDetailCategoryFacade : IMDAccountPaybleStatementDetailCategoryFacade
    {

        #region Instance Variables

        private bool _isDisposed;
        private Context _currentContext;

        private BaseDataAccessFactory _dataAccessFactory;

        #endregion

        #region Private Properties

        private Context CurrentContext
        {
            [DebuggerStepThrough()]
            get
            {
                if (_currentContext == null)
                {
                    _currentContext = new Context();
                }

                return _currentContext;
            }
        }

        private BaseDataAccessFactory DataAccessFactory
        {
            [DebuggerStepThrough()]
            get
            {
                if (_dataAccessFactory == null)
                {
                    _dataAccessFactory = BaseDataAccessFactory.Create(CurrentContext);
                }

                return _dataAccessFactory;
            }
        }

        #endregion

        #region Constructer & Destructor

        public MDAccountPaybleStatementDetailCategoryFacade()
            : base()
        {
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    if (_currentContext != null)
                    {
                        _currentContext.Dispose();
                    }
                }
            }

            _isDisposed = true;
        }

        ~MDAccountPaybleStatementDetailCategoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDAccountPaybleStatementDetailCategoryFacade.Add(MDAccountPaybleStatementDetailCategoryEntity mDAccountPaybleStatementDetailCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAccountPaybleStatementDetailCategoryDataAccess().Add(mDAccountPaybleStatementDetailCategoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDAccountPaybleStatementDetailCategoryFacade.Update(MDAccountPaybleStatementDetailCategoryEntity mDAccountPaybleStatementDetailCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAccountPaybleStatementDetailCategoryDataAccess().Update(mDAccountPaybleStatementDetailCategoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDAccountPaybleStatementDetailCategoryFacade.Delete(MDAccountPaybleStatementDetailCategoryEntity mDAccountPaybleStatementDetailCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAccountPaybleStatementDetailCategoryDataAccess().Delete(mDAccountPaybleStatementDetailCategoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDAccountPaybleStatementDetailCategoryFacade.Add(IList<MDAccountPaybleStatementDetailCategoryEntity> mDAccountPaybleStatementDetailCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAccountPaybleStatementDetailCategoryDataAccess().Add(mDAccountPaybleStatementDetailCategoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDAccountPaybleStatementDetailCategoryFacade.Update(IList<MDAccountPaybleStatementDetailCategoryEntity> mDAccountPaybleStatementDetailCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAccountPaybleStatementDetailCategoryDataAccess().Update(mDAccountPaybleStatementDetailCategoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDAccountPaybleStatementDetailCategoryFacade.Delete(IList<MDAccountPaybleStatementDetailCategoryEntity> mDAccountPaybleStatementDetailCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAccountPaybleStatementDetailCategoryDataAccess().Delete(mDAccountPaybleStatementDetailCategoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDAccountPaybleStatementDetailCategoryEntity> IMDAccountPaybleStatementDetailCategoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDAccountPaybleStatementDetailCategoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDAccountPaybleStatementDetailCategoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDAccountPaybleStatementDetailCategoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDAccountPaybleStatementDetailCategoryEntity IMDAccountPaybleStatementDetailCategoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDAccountPaybleStatementDetailCategoryEntity.FLD_NAME_AccountPaybleStatementDetailCategoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDAccountPaybleStatementDetailCategoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
