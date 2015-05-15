// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




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
    public sealed partial class CRMLandCurrentStatusFacade : ICRMLandCurrentStatusFacade
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

        public CRMLandCurrentStatusFacade()
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

        ~CRMLandCurrentStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMLandCurrentStatusFacade.Add(CRMLandCurrentStatusEntity cRMLandCurrentStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMLandCurrentStatusDataAccess().Add(cRMLandCurrentStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMLandCurrentStatusFacade.Update(CRMLandCurrentStatusEntity cRMLandCurrentStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMLandCurrentStatusDataAccess().Update(cRMLandCurrentStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMLandCurrentStatusFacade.Delete(CRMLandCurrentStatusEntity cRMLandCurrentStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMLandCurrentStatusDataAccess().Delete(cRMLandCurrentStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMLandCurrentStatusFacade.Add(IList<CRMLandCurrentStatusEntity> cRMLandCurrentStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMLandCurrentStatusDataAccess().Add(cRMLandCurrentStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMLandCurrentStatusFacade.Update(IList<CRMLandCurrentStatusEntity> cRMLandCurrentStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMLandCurrentStatusDataAccess().Update(cRMLandCurrentStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMLandCurrentStatusFacade.Delete(IList<CRMLandCurrentStatusEntity> cRMLandCurrentStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMLandCurrentStatusDataAccess().Delete(cRMLandCurrentStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMLandCurrentStatusEntity> ICRMLandCurrentStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMLandCurrentStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMLandCurrentStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMLandCurrentStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMLandCurrentStatusEntity ICRMLandCurrentStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMLandCurrentStatusEntity.FLD_NAME_LandCurrentStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMLandCurrentStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
