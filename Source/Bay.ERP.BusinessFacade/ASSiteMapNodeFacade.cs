// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:24:04




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
    public sealed partial class ASSiteMapNodeFacade : IASSiteMapNodeFacade
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

        public ASSiteMapNodeFacade()
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

        ~ASSiteMapNodeFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IASSiteMapNodeFacade.Add(ASSiteMapNodeEntity aSSiteMapNodeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASSiteMapNodeDataAccess().Add(aSSiteMapNodeEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IASSiteMapNodeFacade.Update(ASSiteMapNodeEntity aSSiteMapNodeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASSiteMapNodeDataAccess().Update(aSSiteMapNodeEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IASSiteMapNodeFacade.Delete(ASSiteMapNodeEntity aSSiteMapNodeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASSiteMapNodeDataAccess().Delete(aSSiteMapNodeEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IASSiteMapNodeFacade.Add(IList<ASSiteMapNodeEntity> aSSiteMapNodeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASSiteMapNodeDataAccess().Add(aSSiteMapNodeEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IASSiteMapNodeFacade.Update(IList<ASSiteMapNodeEntity> aSSiteMapNodeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASSiteMapNodeDataAccess().Update(aSSiteMapNodeEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IASSiteMapNodeFacade.Delete(IList<ASSiteMapNodeEntity> aSSiteMapNodeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASSiteMapNodeDataAccess().Delete(aSSiteMapNodeEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ASSiteMapNodeEntity> IASSiteMapNodeFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateASSiteMapNodeDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IASSiteMapNodeFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateASSiteMapNodeDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ASSiteMapNodeEntity IASSiteMapNodeFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ASSiteMapNodeID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateASSiteMapNodeDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
