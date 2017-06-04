using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuilderPattern.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Pattern.Tests
{
    [TestClass()]
    public class ReportBuilderTests
    {
        [TestMethod()]
        public void Test_BuildReports()
        {
            Report currentMonthTaxReport =
                ReportBuilder.CreateMonthTaxReport(5, 2017);

            Report currentYearTaxReport =
                ReportBuilder.CreateYearTaxReport(2017);

            Report currentMonthCommissionReport =
                ReportBuilder.CreateMonthCommissionReport(5, 2017);

            Report currentYearCommissionReport =
                ReportBuilder.CreateYearCommissionReport(2017);
        }
    }
}