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
    public sealed partial class DMSFileMovementRegisterFacade : IDMSFileMovementRegisterFacade
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

        public DMSFileMovementRegisterFacade()
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

        ~DMSFileMovementRegisterFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IDMSFileMovementRegisterFacade.Add(DMSFileMovementRegisterEntity dMSFileMovementRegisterEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSFileMovementRegisterDataAccess().Add(dMSFileMovementRegisterEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IDMSFileMovementRegisterFacade.Update(DMSFileMovementRegisterEntity dMSFileMovementRegisterEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSFileMovementRegisterDataAccess().Update(dMSFileMovementRegisterEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IDMSFileMovementRegisterFacade.Delete(DMSFileMovementRegisterEntity dMSFileMovementRegisterEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSFileMovementRegisterDataAccess().Delete(dMSFileMovementRegisterEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IDMSFileMovementRegisterFacade.Add(IList<DMSFileMovementRegisterEntity> dMSFileMovementRegisterEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSFileMovementRegisterDataAccess().Add(dMSFileMovementRegisterEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IDMSFileMovementRegisterFacade.Update(IList<DMSFileMovementRegisterEntity> dMSFileMovementRegisterEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSFileMovementRegisterDataAccess().Update(dMSFileMovementRegisterEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IDMSFileMovementRegisterFacade.Delete(IList<DMSFileMovementRegisterEntity> dMSFileMovementRegisterEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSFileMovementRegisterDataAccess().Delete(dMSFileMovementRegisterEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<DMSFileMovementRegisterEntity> IDMSFileMovementRegisterFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateDMSFileMovementRegisterDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IDMSFileMovementRegisterFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateDMSFileMovementRegisterDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DMSFileMovementRegisterEntity IDMSFileMovementRegisterFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(DMSFileMovementRegisterEntity.FLD_NAME_FileMovementRegisterID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateDMSFileMovementRegisterDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
