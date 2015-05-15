// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
    public sealed partial class MDIssueCategoryFacade : IMDIssueCategoryFacade
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

        public MDIssueCategoryFacade()
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

        ~MDIssueCategoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDIssueCategoryFacade.Add(MDIssueCategoryEntity mDIssueCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDIssueCategoryDataAccess().Add(mDIssueCategoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDIssueCategoryFacade.Update(MDIssueCategoryEntity mDIssueCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDIssueCategoryDataAccess().Update(mDIssueCategoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDIssueCategoryFacade.Delete(MDIssueCategoryEntity mDIssueCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDIssueCategoryDataAccess().Delete(mDIssueCategoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDIssueCategoryFacade.Add(IList<MDIssueCategoryEntity> mDIssueCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDIssueCategoryDataAccess().Add(mDIssueCategoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDIssueCategoryFacade.Update(IList<MDIssueCategoryEntity> mDIssueCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDIssueCategoryDataAccess().Update(mDIssueCategoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDIssueCategoryFacade.Delete(IList<MDIssueCategoryEntity> mDIssueCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDIssueCategoryDataAccess().Delete(mDIssueCategoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDIssueCategoryEntity> IMDIssueCategoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDIssueCategoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDIssueCategoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDIssueCategoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDIssueCategoryEntity IMDIssueCategoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDIssueCategoryEntity.FLD_NAME_IssueCategoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDIssueCategoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
