// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Oct-2013, 12:51:37




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
    public sealed partial class CRMSurveyOwnerFacade : ICRMSurveyOwnerFacade
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

        public CRMSurveyOwnerFacade()
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

        ~CRMSurveyOwnerFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMSurveyOwnerFacade.Add(CRMSurveyOwnerEntity cRMSurveyOwnerEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMSurveyOwnerDataAccess().Add(cRMSurveyOwnerEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMSurveyOwnerFacade.Update(CRMSurveyOwnerEntity cRMSurveyOwnerEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMSurveyOwnerDataAccess().Update(cRMSurveyOwnerEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMSurveyOwnerFacade.Delete(CRMSurveyOwnerEntity cRMSurveyOwnerEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMSurveyOwnerDataAccess().Delete(cRMSurveyOwnerEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMSurveyOwnerFacade.Add(IList<CRMSurveyOwnerEntity> cRMSurveyOwnerEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMSurveyOwnerDataAccess().Add(cRMSurveyOwnerEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMSurveyOwnerFacade.Update(IList<CRMSurveyOwnerEntity> cRMSurveyOwnerEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMSurveyOwnerDataAccess().Update(cRMSurveyOwnerEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMSurveyOwnerFacade.Delete(IList<CRMSurveyOwnerEntity> cRMSurveyOwnerEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMSurveyOwnerDataAccess().Delete(cRMSurveyOwnerEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMSurveyOwnerEntity> ICRMSurveyOwnerFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMSurveyOwnerDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMSurveyOwnerFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMSurveyOwnerDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMSurveyOwnerEntity ICRMSurveyOwnerFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMSurveyOwnerEntity.FLD_NAME_SurveyOwnerID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMSurveyOwnerDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
