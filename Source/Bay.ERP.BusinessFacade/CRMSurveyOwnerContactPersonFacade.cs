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
    public sealed partial class CRMSurveyOwnerContactPersonFacade : ICRMSurveyOwnerContactPersonFacade
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

        public CRMSurveyOwnerContactPersonFacade()
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

        ~CRMSurveyOwnerContactPersonFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMSurveyOwnerContactPersonFacade.Add(CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMSurveyOwnerContactPersonDataAccess().Add(cRMSurveyOwnerContactPersonEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMSurveyOwnerContactPersonFacade.Update(CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMSurveyOwnerContactPersonDataAccess().Update(cRMSurveyOwnerContactPersonEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMSurveyOwnerContactPersonFacade.Delete(CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMSurveyOwnerContactPersonDataAccess().Delete(cRMSurveyOwnerContactPersonEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMSurveyOwnerContactPersonFacade.Add(IList<CRMSurveyOwnerContactPersonEntity> cRMSurveyOwnerContactPersonEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMSurveyOwnerContactPersonDataAccess().Add(cRMSurveyOwnerContactPersonEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMSurveyOwnerContactPersonFacade.Update(IList<CRMSurveyOwnerContactPersonEntity> cRMSurveyOwnerContactPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMSurveyOwnerContactPersonDataAccess().Update(cRMSurveyOwnerContactPersonEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMSurveyOwnerContactPersonFacade.Delete(IList<CRMSurveyOwnerContactPersonEntity> cRMSurveyOwnerContactPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMSurveyOwnerContactPersonDataAccess().Delete(cRMSurveyOwnerContactPersonEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMSurveyOwnerContactPersonEntity> ICRMSurveyOwnerContactPersonFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMSurveyOwnerContactPersonDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMSurveyOwnerContactPersonFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMSurveyOwnerContactPersonDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMSurveyOwnerContactPersonEntity ICRMSurveyOwnerContactPersonFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMSurveyOwnerContactPersonEntity.FLD_NAME_SurveyOwnerContactPersonID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMSurveyOwnerContactPersonDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
