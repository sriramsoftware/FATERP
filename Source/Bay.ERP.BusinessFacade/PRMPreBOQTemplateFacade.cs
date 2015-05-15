// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




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
    public sealed partial class PRMPreBOQTemplateFacade : IPRMPreBOQTemplateFacade
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

        public PRMPreBOQTemplateFacade()
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

        ~PRMPreBOQTemplateFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IPRMPreBOQTemplateFacade.Add(PRMPreBOQTemplateEntity pRMPreBOQTemplateEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQTemplateDataAccess().Add(pRMPreBOQTemplateEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMPreBOQTemplateFacade.Update(PRMPreBOQTemplateEntity pRMPreBOQTemplateEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQTemplateDataAccess().Update(pRMPreBOQTemplateEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMPreBOQTemplateFacade.Delete(PRMPreBOQTemplateEntity pRMPreBOQTemplateEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQTemplateDataAccess().Delete(pRMPreBOQTemplateEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IPRMPreBOQTemplateFacade.Add(IList<PRMPreBOQTemplateEntity> pRMPreBOQTemplateEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQTemplateDataAccess().Add(pRMPreBOQTemplateEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMPreBOQTemplateFacade.Update(IList<PRMPreBOQTemplateEntity> pRMPreBOQTemplateEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQTemplateDataAccess().Update(pRMPreBOQTemplateEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMPreBOQTemplateFacade.Delete(IList<PRMPreBOQTemplateEntity> pRMPreBOQTemplateEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQTemplateDataAccess().Delete(pRMPreBOQTemplateEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<PRMPreBOQTemplateEntity> IPRMPreBOQTemplateFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMPreBOQTemplateDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IPRMPreBOQTemplateFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMPreBOQTemplateDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        PRMPreBOQTemplateEntity IPRMPreBOQTemplateFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQTemplateEntity.FLD_NAME_PreBOQTemplateID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreatePRMPreBOQTemplateDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
