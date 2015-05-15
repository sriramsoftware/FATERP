using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Bay.ERP.Common.Shared
{
    [Serializable]
    public sealed class PagedResponse<T>
    {
        private int _totalRow;
        private int _totalPage;
        private IList<T> _response;

        public int TotalRow
        {
            [DebuggerStepThrough()]
            get
            {
                return _totalRow;
            }
            [DebuggerStepThrough()]
            set
            {
                _totalRow = value;
            }
        }

        public int TotalPage
        {
            [DebuggerStepThrough()]
            get
            {
                return _totalPage;
            }
            [DebuggerStepThrough()]
            set
            {
                _totalPage = value;
            }
        }

        public IList<T> Response
        {
            [DebuggerStepThrough()]
            get
            {
                return _response;
            }
            [DebuggerStepThrough()]
            set
            {
                _response = value;
            }
        }

        public PagedResponse()
        {
        }
    }
}