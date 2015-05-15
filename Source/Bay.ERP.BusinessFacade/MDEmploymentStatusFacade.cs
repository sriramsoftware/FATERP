// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    public sealed partial class MDEmploymentStatusFacade : IMDEmploymentStatusFacade
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

        public MDEmploymentStatusFacade()
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

        ~MDEmploymentStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDEmploymentStatusFacade.Add(MDEmploymentStatusEntity mDEmploymentStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmploymentStatusDataAccess().Add(mDEmploymentStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDEmploymentStatusFacade.Update(MDEmploymentStatusEntity mDEmploymentStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmploymentStatusDataAccess().Update(mDEmploymentStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDEmploymentStatusFacade.Delete(MDEmploymentStatusEntity mDEmploymentStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmploymentStatusDataAccess().Delete(mDEmploymentStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDEmploymentStatusFacade.Add(IList<MDEmploymentStatusEntity> mDEmploymentStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmploymentStatusDataAccess().Add(mDEmploymentStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDEmploymentStatusFacade.Update(IList<MDEmploymentStatusEntity> mDEmploymentStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmploymentStatusDataAccess().Update(mDEmploymentStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDEmploymentStatusFacade.Delete(IList<MDEmploymentStatusEntity> mDEmploymentStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmploymentStatusDataAccess().Delete(mDEmploymentStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDEmploymentStatusEntity> IMDEmploymentStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDEmploymentStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDEmploymentStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDEmploymentStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDEmploymentStatusEntity IMDEmploymentStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEmploymentStatusEntity.FLD_NAME_EmploymentStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDEmploymentStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
