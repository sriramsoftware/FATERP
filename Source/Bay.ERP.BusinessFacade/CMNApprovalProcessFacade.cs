// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:20:17




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
    public sealed partial class CMNApprovalProcessFacade : ICMNApprovalProcessFacade
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

        public CMNApprovalProcessFacade()
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

        ~CMNApprovalProcessFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMNApprovalProcessFacade.Add(CMNApprovalProcessEntity cMNApprovalProcessEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNApprovalProcessDataAccess().Add(cMNApprovalProcessEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMNApprovalProcessFacade.Update(CMNApprovalProcessEntity cMNApprovalProcessEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNApprovalProcessDataAccess().Update(cMNApprovalProcessEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMNApprovalProcessFacade.Delete(CMNApprovalProcessEntity cMNApprovalProcessEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNApprovalProcessDataAccess().Delete(cMNApprovalProcessEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMNApprovalProcessFacade.Add(IList<CMNApprovalProcessEntity> cMNApprovalProcessEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNApprovalProcessDataAccess().Add(cMNApprovalProcessEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMNApprovalProcessFacade.Update(IList<CMNApprovalProcessEntity> cMNApprovalProcessEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNApprovalProcessDataAccess().Update(cMNApprovalProcessEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMNApprovalProcessFacade.Delete(IList<CMNApprovalProcessEntity> cMNApprovalProcessEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNApprovalProcessDataAccess().Delete(cMNApprovalProcessEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMNApprovalProcessEntity> ICMNApprovalProcessFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMNApprovalProcessDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMNApprovalProcessFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMNApprovalProcessDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMNApprovalProcessEntity ICMNApprovalProcessFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNApprovalProcessEntity.FLD_NAME_ApprovalProcessID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMNApprovalProcessDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
