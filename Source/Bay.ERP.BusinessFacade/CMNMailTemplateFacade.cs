// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Oct-2013, 12:17:51




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
    public sealed partial class CMNMailTemplateFacade : ICMNMailTemplateFacade
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

        public CMNMailTemplateFacade()
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

        ~CMNMailTemplateFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMNMailTemplateFacade.Add(CMNMailTemplateEntity cMNMailTemplateEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNMailTemplateDataAccess().Add(cMNMailTemplateEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMNMailTemplateFacade.Update(CMNMailTemplateEntity cMNMailTemplateEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNMailTemplateDataAccess().Update(cMNMailTemplateEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMNMailTemplateFacade.Delete(CMNMailTemplateEntity cMNMailTemplateEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNMailTemplateDataAccess().Delete(cMNMailTemplateEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMNMailTemplateFacade.Add(IList<CMNMailTemplateEntity> cMNMailTemplateEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNMailTemplateDataAccess().Add(cMNMailTemplateEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMNMailTemplateFacade.Update(IList<CMNMailTemplateEntity> cMNMailTemplateEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNMailTemplateDataAccess().Update(cMNMailTemplateEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMNMailTemplateFacade.Delete(IList<CMNMailTemplateEntity> cMNMailTemplateEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNMailTemplateDataAccess().Delete(cMNMailTemplateEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMNMailTemplateEntity> ICMNMailTemplateFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMNMailTemplateDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMNMailTemplateFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMNMailTemplateDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMNMailTemplateEntity ICMNMailTemplateFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNMailTemplateEntity.FLD_NAME_MailTemplateID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMNMailTemplateDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
