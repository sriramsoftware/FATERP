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
    public sealed partial class BDProjectDocumentTemplateFacade : IBDProjectDocumentTemplateFacade
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

        public BDProjectDocumentTemplateFacade()
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

        ~BDProjectDocumentTemplateFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IBDProjectDocumentTemplateFacade.Add(BDProjectDocumentTemplateEntity bDProjectDocumentTemplateEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectDocumentTemplateDataAccess().Add(bDProjectDocumentTemplateEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProjectDocumentTemplateFacade.Update(BDProjectDocumentTemplateEntity bDProjectDocumentTemplateEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectDocumentTemplateDataAccess().Update(bDProjectDocumentTemplateEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProjectDocumentTemplateFacade.Delete(BDProjectDocumentTemplateEntity bDProjectDocumentTemplateEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectDocumentTemplateDataAccess().Delete(bDProjectDocumentTemplateEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IBDProjectDocumentTemplateFacade.Add(IList<BDProjectDocumentTemplateEntity> bDProjectDocumentTemplateEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectDocumentTemplateDataAccess().Add(bDProjectDocumentTemplateEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProjectDocumentTemplateFacade.Update(IList<BDProjectDocumentTemplateEntity> bDProjectDocumentTemplateEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectDocumentTemplateDataAccess().Update(bDProjectDocumentTemplateEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProjectDocumentTemplateFacade.Delete(IList<BDProjectDocumentTemplateEntity> bDProjectDocumentTemplateEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectDocumentTemplateDataAccess().Delete(bDProjectDocumentTemplateEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<BDProjectDocumentTemplateEntity> IBDProjectDocumentTemplateFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProjectDocumentTemplateDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IBDProjectDocumentTemplateFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProjectDocumentTemplateDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        BDProjectDocumentTemplateEntity IBDProjectDocumentTemplateFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectDocumentTemplateEntity.FLD_NAME_ProjectDocumentTemplateID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateBDProjectDocumentTemplateDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
