// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Nov-2013, 09:51:38




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
    public sealed partial class MDLeavePolicyFacade : IMDLeavePolicyFacade
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

        public MDLeavePolicyFacade(): base()
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

        ~MDLeavePolicyFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDLeavePolicyFacade.Add(MDLeavePolicyEntity mDLeavePolicyEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDLeavePolicyDataAccess().Add(mDLeavePolicyEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDLeavePolicyFacade.Update(MDLeavePolicyEntity mDLeavePolicyEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDLeavePolicyDataAccess().Update(mDLeavePolicyEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDLeavePolicyFacade.Delete(MDLeavePolicyEntity mDLeavePolicyEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDLeavePolicyDataAccess().Delete(mDLeavePolicyEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDLeavePolicyFacade.Add(IList<MDLeavePolicyEntity> mDLeavePolicyEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDLeavePolicyDataAccess().Add(mDLeavePolicyEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDLeavePolicyFacade.Update(IList<MDLeavePolicyEntity> mDLeavePolicyEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDLeavePolicyDataAccess().Update(mDLeavePolicyEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDLeavePolicyFacade.Delete(IList<MDLeavePolicyEntity> mDLeavePolicyEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDLeavePolicyDataAccess().Delete(mDLeavePolicyEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDLeavePolicyEntity> IMDLeavePolicyFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDLeavePolicyDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDLeavePolicyFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDLeavePolicyDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDLeavePolicyEntity IMDLeavePolicyFacade.GetByID(Int64 iD)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(MDLeavePolicyEntity.FLD_NAME_LeavePolicyID, iD.ToString(), SQLMatchType.Equal);

            return DataAccessFactory.CreateMDLeavePolicyDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
