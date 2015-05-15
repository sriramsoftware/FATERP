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
    public sealed partial class MDEvaluationSessionCategoryFacade : IMDEvaluationSessionCategoryFacade
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

        public MDEvaluationSessionCategoryFacade()
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

        ~MDEvaluationSessionCategoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDEvaluationSessionCategoryFacade.Add(MDEvaluationSessionCategoryEntity mDEvaluationSessionCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEvaluationSessionCategoryDataAccess().Add(mDEvaluationSessionCategoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDEvaluationSessionCategoryFacade.Update(MDEvaluationSessionCategoryEntity mDEvaluationSessionCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEvaluationSessionCategoryDataAccess().Update(mDEvaluationSessionCategoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDEvaluationSessionCategoryFacade.Delete(MDEvaluationSessionCategoryEntity mDEvaluationSessionCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEvaluationSessionCategoryDataAccess().Delete(mDEvaluationSessionCategoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDEvaluationSessionCategoryFacade.Add(IList<MDEvaluationSessionCategoryEntity> mDEvaluationSessionCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEvaluationSessionCategoryDataAccess().Add(mDEvaluationSessionCategoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDEvaluationSessionCategoryFacade.Update(IList<MDEvaluationSessionCategoryEntity> mDEvaluationSessionCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEvaluationSessionCategoryDataAccess().Update(mDEvaluationSessionCategoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDEvaluationSessionCategoryFacade.Delete(IList<MDEvaluationSessionCategoryEntity> mDEvaluationSessionCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEvaluationSessionCategoryDataAccess().Delete(mDEvaluationSessionCategoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDEvaluationSessionCategoryEntity> IMDEvaluationSessionCategoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDEvaluationSessionCategoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDEvaluationSessionCategoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDEvaluationSessionCategoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDEvaluationSessionCategoryEntity IMDEvaluationSessionCategoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEvaluationSessionCategoryEntity.FLD_NAME_SessionCategoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDEvaluationSessionCategoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
