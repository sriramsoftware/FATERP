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
    public sealed partial class CMNApprovalPanelFacade : ICMNApprovalPanelFacade
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

        public CMNApprovalPanelFacade()
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

        ~CMNApprovalPanelFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMNApprovalPanelFacade.Add(CMNApprovalPanelEntity cMNApprovalPanelEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNApprovalPanelDataAccess().Add(cMNApprovalPanelEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMNApprovalPanelFacade.Update(CMNApprovalPanelEntity cMNApprovalPanelEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNApprovalPanelDataAccess().Update(cMNApprovalPanelEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMNApprovalPanelFacade.Delete(CMNApprovalPanelEntity cMNApprovalPanelEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNApprovalPanelDataAccess().Delete(cMNApprovalPanelEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMNApprovalPanelFacade.Add(IList<CMNApprovalPanelEntity> cMNApprovalPanelEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNApprovalPanelDataAccess().Add(cMNApprovalPanelEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMNApprovalPanelFacade.Update(IList<CMNApprovalPanelEntity> cMNApprovalPanelEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNApprovalPanelDataAccess().Update(cMNApprovalPanelEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMNApprovalPanelFacade.Delete(IList<CMNApprovalPanelEntity> cMNApprovalPanelEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNApprovalPanelDataAccess().Delete(cMNApprovalPanelEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMNApprovalPanelEntity> ICMNApprovalPanelFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMNApprovalPanelDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMNApprovalPanelFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMNApprovalPanelDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMNApprovalPanelEntity ICMNApprovalPanelFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNApprovalPanelEntity.FLD_NAME_ApprovalPanelID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMNApprovalPanelDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
