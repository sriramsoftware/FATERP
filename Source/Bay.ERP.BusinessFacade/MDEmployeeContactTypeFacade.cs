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
    public sealed partial class MDEmployeeContactTypeFacade : IMDEmployeeContactTypeFacade
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

        public MDEmployeeContactTypeFacade()
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

        ~MDEmployeeContactTypeFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDEmployeeContactTypeFacade.Add(MDEmployeeContactTypeEntity mDEmployeeContactTypeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeContactTypeDataAccess().Add(mDEmployeeContactTypeEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDEmployeeContactTypeFacade.Update(MDEmployeeContactTypeEntity mDEmployeeContactTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeContactTypeDataAccess().Update(mDEmployeeContactTypeEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDEmployeeContactTypeFacade.Delete(MDEmployeeContactTypeEntity mDEmployeeContactTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeContactTypeDataAccess().Delete(mDEmployeeContactTypeEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDEmployeeContactTypeFacade.Add(IList<MDEmployeeContactTypeEntity> mDEmployeeContactTypeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeContactTypeDataAccess().Add(mDEmployeeContactTypeEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDEmployeeContactTypeFacade.Update(IList<MDEmployeeContactTypeEntity> mDEmployeeContactTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeContactTypeDataAccess().Update(mDEmployeeContactTypeEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDEmployeeContactTypeFacade.Delete(IList<MDEmployeeContactTypeEntity> mDEmployeeContactTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeContactTypeDataAccess().Delete(mDEmployeeContactTypeEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDEmployeeContactTypeEntity> IMDEmployeeContactTypeFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDEmployeeContactTypeDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDEmployeeContactTypeFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDEmployeeContactTypeDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDEmployeeContactTypeEntity IMDEmployeeContactTypeFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeContactTypeEntity.FLD_NAME_EmployeeContactTypeID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDEmployeeContactTypeDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
