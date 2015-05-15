using System;
using System.Collections.Specialized;
using System.Diagnostics;

namespace Bay.ERP.Common.Shared
{
    [Serializable]
    public sealed class PagedRequest
    {
        private int _pageIndex;
        private int _rowPerPage;
        private string _sortColumn;
        private string _sortOrder;
        private StringDictionary _conditions;

        public int PageIndex
        {
            [DebuggerStepThrough()]
            get
            {
                return _pageIndex;
            }
            [DebuggerStepThrough()]
            set
            {
                _pageIndex = value;
            }
        }

        public int RowPerPage
        {
            [DebuggerStepThrough()]
            get
            {
                return _rowPerPage;
            }
            [DebuggerStepThrough()]
            set
            {
                _rowPerPage = value;
            }
        }

        public StringDictionary Conditions
        {
            [DebuggerStepThrough()]
            get
            {
                if (_conditions == null)
                {
                    _conditions = new StringDictionary();
                }

                return _conditions;
            }
        }

        public string SortColumn
        {
            [DebuggerStepThrough()]
            get
            {
                return _sortColumn;
            }
            [DebuggerStepThrough()]
            set
            {
                _sortColumn = value;
            }
        }

        public string SortOrder
        {
            [DebuggerStepThrough()]
            get
            {
                return _sortOrder;
            }
            [DebuggerStepThrough()]
            set
            {
                _sortOrder = value;
            }
        }

        public PagedRequest()
        {
        }

        public PagedRequest(int pageIndex,
        int rowPerPage)
        {
            _pageIndex = pageIndex;
            _rowPerPage = rowPerPage;
        }
    }
}