// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Aug-2013, 11:09:08




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
    public sealed partial class CMMeasurementBookDetailFacade : ICMMeasurementBookDetailFacade
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

        public CMMeasurementBookDetailFacade()
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

        ~CMMeasurementBookDetailFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMMeasurementBookDetailFacade.Add(CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMMeasurementBookDetailDataAccess().Add(cMMeasurementBookDetailEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMMeasurementBookDetailFacade.Update(CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMMeasurementBookDetailDataAccess().Update(cMMeasurementBookDetailEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMMeasurementBookDetailFacade.Delete(CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMMeasurementBookDetailDataAccess().Delete(cMMeasurementBookDetailEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMMeasurementBookDetailFacade.Add(IList<CMMeasurementBookDetailEntity> cMMeasurementBookDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMMeasurementBookDetailDataAccess().Add(cMMeasurementBookDetailEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMMeasurementBookDetailFacade.Update(IList<CMMeasurementBookDetailEntity> cMMeasurementBookDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMMeasurementBookDetailDataAccess().Update(cMMeasurementBookDetailEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMMeasurementBookDetailFacade.Delete(IList<CMMeasurementBookDetailEntity> cMMeasurementBookDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMMeasurementBookDetailDataAccess().Delete(cMMeasurementBookDetailEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMMeasurementBookDetailEntity> ICMMeasurementBookDetailFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMMeasurementBookDetailDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMMeasurementBookDetailFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMMeasurementBookDetailDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMMeasurementBookDetailEntity ICMMeasurementBookDetailFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMMeasurementBookDetailEntity.FLD_NAME_MeasurementBookDetailID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMMeasurementBookDetailDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
