// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Oct-2013, 01:39:59




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
    public sealed partial class MDArtGalleriaLocationFacade : IMDArtGalleriaLocationFacade
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

        public MDArtGalleriaLocationFacade()
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

        ~MDArtGalleriaLocationFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDArtGalleriaLocationFacade.Add(MDArtGalleriaLocationEntity mDArtGalleriaLocationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDArtGalleriaLocationDataAccess().Add(mDArtGalleriaLocationEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDArtGalleriaLocationFacade.Update(MDArtGalleriaLocationEntity mDArtGalleriaLocationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDArtGalleriaLocationDataAccess().Update(mDArtGalleriaLocationEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDArtGalleriaLocationFacade.Delete(MDArtGalleriaLocationEntity mDArtGalleriaLocationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDArtGalleriaLocationDataAccess().Delete(mDArtGalleriaLocationEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDArtGalleriaLocationFacade.Add(IList<MDArtGalleriaLocationEntity> mDArtGalleriaLocationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDArtGalleriaLocationDataAccess().Add(mDArtGalleriaLocationEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDArtGalleriaLocationFacade.Update(IList<MDArtGalleriaLocationEntity> mDArtGalleriaLocationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDArtGalleriaLocationDataAccess().Update(mDArtGalleriaLocationEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDArtGalleriaLocationFacade.Delete(IList<MDArtGalleriaLocationEntity> mDArtGalleriaLocationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDArtGalleriaLocationDataAccess().Delete(mDArtGalleriaLocationEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDArtGalleriaLocationEntity> IMDArtGalleriaLocationFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDArtGalleriaLocationDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDArtGalleriaLocationFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDArtGalleriaLocationDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDArtGalleriaLocationEntity IMDArtGalleriaLocationFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDArtGalleriaLocationEntity.FLD_NAME_ArtGalleriaLocationID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDArtGalleriaLocationDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
