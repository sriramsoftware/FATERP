// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Sep-2012, 10:20:04




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
    public sealed partial class DMSDocumentNodeFacade : IDMSDocumentNodeFacade
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

        public DMSDocumentNodeFacade()
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

        ~DMSDocumentNodeFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IDMSDocumentNodeFacade.Add(DMSDocumentNodeEntity dMSDocumentNodeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSDocumentNodeDataAccess().Add(dMSDocumentNodeEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IDMSDocumentNodeFacade.Update(DMSDocumentNodeEntity dMSDocumentNodeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSDocumentNodeDataAccess().Update(dMSDocumentNodeEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IDMSDocumentNodeFacade.Delete(DMSDocumentNodeEntity dMSDocumentNodeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSDocumentNodeDataAccess().Delete(dMSDocumentNodeEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IDMSDocumentNodeFacade.Add(IList<DMSDocumentNodeEntity> dMSDocumentNodeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSDocumentNodeDataAccess().Add(dMSDocumentNodeEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IDMSDocumentNodeFacade.Update(IList<DMSDocumentNodeEntity> dMSDocumentNodeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSDocumentNodeDataAccess().Update(dMSDocumentNodeEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IDMSDocumentNodeFacade.Delete(IList<DMSDocumentNodeEntity> dMSDocumentNodeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSDocumentNodeDataAccess().Delete(dMSDocumentNodeEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<DMSDocumentNodeEntity> IDMSDocumentNodeFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateDMSDocumentNodeDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IDMSDocumentNodeFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateDMSDocumentNodeDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DMSDocumentNodeEntity IDMSDocumentNodeFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(DMSDocumentNodeEntity.FLD_NAME_DocumentNodeID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateDMSDocumentNodeDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
