using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi
{
    public class JsonReportBuilder : ReportBuildBase
    {
        public JsonReportBuilder(ReportInfoDB reportInfo) : base(reportInfo)
        {

        }

        public override string BuildHeader()
        {
            return string.Format("<h1>{0}</h1>", this.reportInfo.title);
        }
        public override string BuildContent1()
        {
            return string.Format("<div>{0}</div>", this.reportInfo.KisiselBilgi);
        }
        public override string BuildContent2()
        {
            return string.Format("<div>{0}</div>", this.reportInfo.DiyetBilgi);
        }
    }
}
