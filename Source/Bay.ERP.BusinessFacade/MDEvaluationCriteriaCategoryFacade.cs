// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Sep-2013, 01:19:45




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
    public sealed partial class MDEvaluationCriteriaCategoryFacade : IMDEvaluationCriteriaCategoryFacade
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

        public MDEvaluationCriteriaCategoryFacade()
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

        ~MDEvaluationCriteriaCategoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDEvaluationCriteriaCategoryFacade.Add(MDEvaluationCriteriaCategoryEntity mDEvaluationCriteriaCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEvaluationCriteriaCategoryDataAccess().Add(mDEvaluationCriteriaCategoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDEvaluationCriteriaCategoryFacade.Update(MDEvaluationCriteriaCategoryEntity mDEvaluationCriteriaCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEvaluationCriteriaCategoryDataAccess().Update(mDEvaluationCriteriaCategoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDEvaluationCriteriaCategoryFacade.Delete(MDEvaluationCriteriaCategoryEntity mDEvaluationCriteriaCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEvaluationCriteriaCategoryDataAccess().Delete(mDEvaluationCriteriaCategoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDEvaluationCriteriaCategoryFacade.Add(IList<MDEvaluationCriteriaCategoryEntity> mDEvaluationCriteriaCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEvaluationCriteriaCategoryDataAccess().Add(mDEvaluationCriteriaCategoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDEvaluationCriteriaCategoryFacade.Update(IList<MDEvaluationCriteriaCategoryEntity> mDEvaluationCriteriaCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEvaluationCriteriaCategoryDataAccess().Update(mDEvaluationCriteriaCategoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDEvaluationCriteriaCategoryFacade.Delete(IList<MDEvaluationCriteriaCategoryEntity> mDEvaluationCriteriaCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEvaluationCriteriaCategoryDataAccess().Delete(mDEvaluationCriteriaCategoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDEvaluationCriteriaCategoryEntity> IMDEvaluationCriteriaCategoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDEvaluationCriteriaCategoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDEvaluationCriteriaCategoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDEvaluationCriteriaCategoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDEvaluationCriteriaCategoryEntity IMDEvaluationCriteriaCategoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEvaluationCriteriaCategoryEntity.FLD_NAME_EvaluationCriteriaCategoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDEvaluationCriteriaCategoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
