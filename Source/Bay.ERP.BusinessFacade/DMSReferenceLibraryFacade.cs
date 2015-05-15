// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Sep-2012, 10:06:41




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
    public sealed partial class DMSReferenceLibraryFacade : IDMSReferenceLibraryFacade
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

        public DMSReferenceLibraryFacade()
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

        ~DMSReferenceLibraryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IDMSReferenceLibraryFacade.Add(DMSReferenceLibraryEntity dMSReferenceLibraryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSReferenceLibraryDataAccess().Add(dMSReferenceLibraryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IDMSReferenceLibraryFacade.Update(DMSReferenceLibraryEntity dMSReferenceLibraryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSReferenceLibraryDataAccess().Update(dMSReferenceLibraryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IDMSReferenceLibraryFacade.Delete(DMSReferenceLibraryEntity dMSReferenceLibraryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSReferenceLibraryDataAccess().Delete(dMSReferenceLibraryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IDMSReferenceLibraryFacade.Add(IList<DMSReferenceLibraryEntity> dMSReferenceLibraryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSReferenceLibraryDataAccess().Add(dMSReferenceLibraryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IDMSReferenceLibraryFacade.Update(IList<DMSReferenceLibraryEntity> dMSReferenceLibraryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSReferenceLibraryDataAccess().Update(dMSReferenceLibraryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IDMSReferenceLibraryFacade.Delete(IList<DMSReferenceLibraryEntity> dMSReferenceLibraryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSReferenceLibraryDataAccess().Delete(dMSReferenceLibraryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<DMSReferenceLibraryEntity> IDMSReferenceLibraryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateDMSReferenceLibraryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IDMSReferenceLibraryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateDMSReferenceLibraryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DMSReferenceLibraryEntity IDMSReferenceLibraryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(DMSReferenceLibraryEntity.FLD_NAME_ReferenceLibraryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateDMSReferenceLibraryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
