using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi
{
    public class ReportManager
    {
        private ReportBuildBase builder;
        public ReportManager(ReportBuildBase reportBuildBase)
        {
            this.builder = reportBuildBase;
        }
        public string Build()
        {
            string product = builder.BuildOutput();
            return product;
        }
        public string BuildUpSideDown()
        {
            string product = builder.UpSideDownBuildOutput();
            return product;
        }
    }
}
