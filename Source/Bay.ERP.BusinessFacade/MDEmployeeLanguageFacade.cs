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
    public sealed partial class MDEmployeeLanguageFacade : IMDEmployeeLanguageFacade
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

        public MDEmployeeLanguageFacade()
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

        ~MDEmployeeLanguageFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDEmployeeLanguageFacade.Add(MDEmployeeLanguageEntity mDEmployeeLanguageEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeLanguageDataAccess().Add(mDEmployeeLanguageEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDEmployeeLanguageFacade.Update(MDEmployeeLanguageEntity mDEmployeeLanguageEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeLanguageDataAccess().Update(mDEmployeeLanguageEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDEmployeeLanguageFacade.Delete(MDEmployeeLanguageEntity mDEmployeeLanguageEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeLanguageDataAccess().Delete(mDEmployeeLanguageEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDEmployeeLanguageFacade.Add(IList<MDEmployeeLanguageEntity> mDEmployeeLanguageEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeLanguageDataAccess().Add(mDEmployeeLanguageEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDEmployeeLanguageFacade.Update(IList<MDEmployeeLanguageEntity> mDEmployeeLanguageEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeLanguageDataAccess().Update(mDEmployeeLanguageEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDEmployeeLanguageFacade.Delete(IList<MDEmployeeLanguageEntity> mDEmployeeLanguageEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeLanguageDataAccess().Delete(mDEmployeeLanguageEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDEmployeeLanguageEntity> IMDEmployeeLanguageFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDEmployeeLanguageDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDEmployeeLanguageFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDEmployeeLanguageDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDEmployeeLanguageEntity IMDEmployeeLanguageFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeLanguageEntity.FLD_NAME_EmployeeLanguageID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDEmployeeLanguageDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
