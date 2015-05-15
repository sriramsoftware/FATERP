// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Aug-2013, 02:50:29




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
    public sealed partial class PRMMaterialReceiveItemMapFacade : IPRMMaterialReceiveItemMapFacade
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

        public PRMMaterialReceiveItemMapFacade()
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

        ~PRMMaterialReceiveItemMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IPRMMaterialReceiveItemMapFacade.Add(PRMMaterialReceiveItemMapEntity pRMMaterialReceiveItemMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMMaterialReceiveItemMapDataAccess().Add(pRMMaterialReceiveItemMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMMaterialReceiveItemMapFacade.Update(PRMMaterialReceiveItemMapEntity pRMMaterialReceiveItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMMaterialReceiveItemMapDataAccess().Update(pRMMaterialReceiveItemMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMMaterialReceiveItemMapFacade.Delete(PRMMaterialReceiveItemMapEntity pRMMaterialReceiveItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMMaterialReceiveItemMapDataAccess().Delete(pRMMaterialReceiveItemMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IPRMMaterialReceiveItemMapFacade.Add(IList<PRMMaterialReceiveItemMapEntity> pRMMaterialReceiveItemMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMMaterialReceiveItemMapDataAccess().Add(pRMMaterialReceiveItemMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMMaterialReceiveItemMapFacade.Update(IList<PRMMaterialReceiveItemMapEntity> pRMMaterialReceiveItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMMaterialReceiveItemMapDataAccess().Update(pRMMaterialReceiveItemMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMMaterialReceiveItemMapFacade.Delete(IList<PRMMaterialReceiveItemMapEntity> pRMMaterialReceiveItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMMaterialReceiveItemMapDataAccess().Delete(pRMMaterialReceiveItemMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<PRMMaterialReceiveItemMapEntity> IPRMMaterialReceiveItemMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMMaterialReceiveItemMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IPRMMaterialReceiveItemMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMMaterialReceiveItemMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        PRMMaterialReceiveItemMapEntity IPRMMaterialReceiveItemMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveItemMapEntity.FLD_NAME_MaterialReceiveItemMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreatePRMMaterialReceiveItemMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
