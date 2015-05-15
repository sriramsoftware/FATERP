// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




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
    public sealed partial class CMCriterionStatusRemarksFacade : ICMCriterionStatusRemarksFacade
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

        public CMCriterionStatusRemarksFacade()
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

        ~CMCriterionStatusRemarksFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMCriterionStatusRemarksFacade.Add(CMCriterionStatusRemarksEntity cMCriterionStatusRemarksEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMCriterionStatusRemarksDataAccess().Add(cMCriterionStatusRemarksEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMCriterionStatusRemarksFacade.Update(CMCriterionStatusRemarksEntity cMCriterionStatusRemarksEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMCriterionStatusRemarksDataAccess().Update(cMCriterionStatusRemarksEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMCriterionStatusRemarksFacade.Delete(CMCriterionStatusRemarksEntity cMCriterionStatusRemarksEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMCriterionStatusRemarksDataAccess().Delete(cMCriterionStatusRemarksEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMCriterionStatusRemarksFacade.Add(IList<CMCriterionStatusRemarksEntity> cMCriterionStatusRemarksEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMCriterionStatusRemarksDataAccess().Add(cMCriterionStatusRemarksEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMCriterionStatusRemarksFacade.Update(IList<CMCriterionStatusRemarksEntity> cMCriterionStatusRemarksEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMCriterionStatusRemarksDataAccess().Update(cMCriterionStatusRemarksEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMCriterionStatusRemarksFacade.Delete(IList<CMCriterionStatusRemarksEntity> cMCriterionStatusRemarksEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMCriterionStatusRemarksDataAccess().Delete(cMCriterionStatusRemarksEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMCriterionStatusRemarksEntity> ICMCriterionStatusRemarksFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMCriterionStatusRemarksDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMCriterionStatusRemarksFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMCriterionStatusRemarksDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMCriterionStatusRemarksEntity ICMCriterionStatusRemarksFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMCriterionStatusRemarksEntity.FLD_NAME_CriterionStatusRemarksID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMCriterionStatusRemarksDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
