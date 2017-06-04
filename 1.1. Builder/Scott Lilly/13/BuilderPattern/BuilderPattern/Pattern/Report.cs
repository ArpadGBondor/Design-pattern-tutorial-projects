using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Pattern
{
    public class Report
    {
        public enum SortingMethod
        {
            BySalesPerson,
            ByTaxCategory
        }

        private DateTime _fromDate;
        private DateTime _toDate;
        private bool _IncludeReturnedOrders;
        private bool _includeUnshippedOrders;
        private SortingMethod _sortBy;

        public Report(
            DateTime from,
            DateTime to,
            bool includeReturnedOrders,
            bool includeUnshippedOrders,
            SortingMethod sortBy)
        {
            _fromDate = from;
            _toDate = to;
            _IncludeReturnedOrders = includeReturnedOrders;
            _includeUnshippedOrders = includeUnshippedOrders;
            _sortBy = sortBy;
        }

        public object CreatePDFReport()
        {
            // Pretend this object is a PDF report,
            // build for the sales that match the passed-in constructor parameters

            return new object();
        }
    }
}
