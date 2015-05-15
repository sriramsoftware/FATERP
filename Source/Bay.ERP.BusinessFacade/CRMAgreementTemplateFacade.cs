// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Apr-2013, 01:28:07




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
    public sealed partial class CRMAgreementTemplateFacade : ICRMAgreementTemplateFacade
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

        public CRMAgreementTemplateFacade()
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

        ~CRMAgreementTemplateFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMAgreementTemplateFacade.Add(CRMAgreementTemplateEntity cRMAgreementTemplateEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMAgreementTemplateDataAccess().Add(cRMAgreementTemplateEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMAgreementTemplateFacade.Update(CRMAgreementTemplateEntity cRMAgreementTemplateEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMAgreementTemplateDataAccess().Update(cRMAgreementTemplateEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMAgreementTemplateFacade.Delete(CRMAgreementTemplateEntity cRMAgreementTemplateEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMAgreementTemplateDataAccess().Delete(cRMAgreementTemplateEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMAgreementTemplateFacade.Add(IList<CRMAgreementTemplateEntity> cRMAgreementTemplateEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMAgreementTemplateDataAccess().Add(cRMAgreementTemplateEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMAgreementTemplateFacade.Update(IList<CRMAgreementTemplateEntity> cRMAgreementTemplateEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMAgreementTemplateDataAccess().Update(cRMAgreementTemplateEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMAgreementTemplateFacade.Delete(IList<CRMAgreementTemplateEntity> cRMAgreementTemplateEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMAgreementTemplateDataAccess().Delete(cRMAgreementTemplateEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMAgreementTemplateEntity> ICRMAgreementTemplateFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMAgreementTemplateDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMAgreementTemplateFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMAgreementTemplateDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMAgreementTemplateEntity ICRMAgreementTemplateFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementTemplateEntity.FLD_NAME_AgreementTemplateID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMAgreementTemplateDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
