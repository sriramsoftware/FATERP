// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Jan-2014, 11:30:08




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
    public sealed partial class MDAllowanceCategoryFacade : IMDAllowanceCategoryFacade
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

        public MDAllowanceCategoryFacade()
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

        ~MDAllowanceCategoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDAllowanceCategoryFacade.Add(MDAllowanceCategoryEntity mDAllowanceCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAllowanceCategoryDataAccess().Add(mDAllowanceCategoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDAllowanceCategoryFacade.Update(MDAllowanceCategoryEntity mDAllowanceCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAllowanceCategoryDataAccess().Update(mDAllowanceCategoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDAllowanceCategoryFacade.Delete(MDAllowanceCategoryEntity mDAllowanceCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAllowanceCategoryDataAccess().Delete(mDAllowanceCategoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDAllowanceCategoryFacade.Add(IList<MDAllowanceCategoryEntity> mDAllowanceCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAllowanceCategoryDataAccess().Add(mDAllowanceCategoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDAllowanceCategoryFacade.Update(IList<MDAllowanceCategoryEntity> mDAllowanceCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAllowanceCategoryDataAccess().Update(mDAllowanceCategoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDAllowanceCategoryFacade.Delete(IList<MDAllowanceCategoryEntity> mDAllowanceCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAllowanceCategoryDataAccess().Delete(mDAllowanceCategoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDAllowanceCategoryEntity> IMDAllowanceCategoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDAllowanceCategoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDAllowanceCategoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDAllowanceCategoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDAllowanceCategoryEntity IMDAllowanceCategoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDAllowanceCategoryEntity.FLD_NAME_AllowanceCategoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDAllowanceCategoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
