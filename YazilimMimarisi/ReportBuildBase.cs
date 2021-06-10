using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi
{
    public abstract class ReportBuildBase
    {
        protected ReportInfoDB reportInfo;
        public ReportBuildBase(ReportInfoDB reportInfo)
        {
            this.reportInfo = reportInfo;
        }
        // Rapor iki farklı içerikten oluşuyor Kişisel Bilgiler ve Diyet Bilgileri
        // İsteğe göre içerik sırası değiştirişebiliyor

        // Kişisel bilgi, Diyet bilgisi
        public string BuildOutput()
        {
            string output = BuildHeader();
            output += BuildContent1();
            output += BuildContent2();
            return output;
        }

        // Diyet bilgi, Kişisel bilgi
        public string UpSideDownBuildOutput()
        {
            string output = BuildHeader();
            output += BuildContent2();
            output += BuildContent1();
            return output;
        }

        public abstract string BuildHeader();
        public abstract string BuildContent1();
        public abstract string BuildContent2();

    }
}
