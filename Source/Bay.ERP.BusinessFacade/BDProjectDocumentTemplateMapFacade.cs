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
    public sealed partial class BDProjectDocumentTemplateMapFacade : IBDProjectDocumentTemplateMapFacade
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

        public BDProjectDocumentTemplateMapFacade()
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

        ~BDProjectDocumentTemplateMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IBDProjectDocumentTemplateMapFacade.Add(BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectDocumentTemplateMapDataAccess().Add(bDProjectDocumentTemplateMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProjectDocumentTemplateMapFacade.Update(BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectDocumentTemplateMapDataAccess().Update(bDProjectDocumentTemplateMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProjectDocumentTemplateMapFacade.Delete(BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectDocumentTemplateMapDataAccess().Delete(bDProjectDocumentTemplateMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IBDProjectDocumentTemplateMapFacade.Add(IList<BDProjectDocumentTemplateMapEntity> bDProjectDocumentTemplateMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectDocumentTemplateMapDataAccess().Add(bDProjectDocumentTemplateMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProjectDocumentTemplateMapFacade.Update(IList<BDProjectDocumentTemplateMapEntity> bDProjectDocumentTemplateMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectDocumentTemplateMapDataAccess().Update(bDProjectDocumentTemplateMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProjectDocumentTemplateMapFacade.Delete(IList<BDProjectDocumentTemplateMapEntity> bDProjectDocumentTemplateMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectDocumentTemplateMapDataAccess().Delete(bDProjectDocumentTemplateMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<BDProjectDocumentTemplateMapEntity> IBDProjectDocumentTemplateMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProjectDocumentTemplateMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IBDProjectDocumentTemplateMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProjectDocumentTemplateMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        BDProjectDocumentTemplateMapEntity IBDProjectDocumentTemplateMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectDocumentTemplateMapEntity.FLD_NAME_ProjectDocumentTemplateMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateBDProjectDocumentTemplateMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
