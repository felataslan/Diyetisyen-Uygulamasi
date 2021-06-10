using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi
{
    class Factory
    {

        //İstemciden gelen string'e göre IHastalik Nesnesi oluşturma
        public IHastalikTipi HastalikNesnesiOlustur(string hastalikTipi)
        {
            if (hastalikTipi=="obez")
            {
                return new Obez();
            }
            else if (hastalikTipi == "çölyak")
            {
                return new Colyak();
            }
            else if (hastalikTipi == "şeker")
            {
                return new Seker();
            }
            else
            {
                return null;
            }
        }

        // İstemciden gelen string'e göre IDiyetTipi nesnesi oluşturma
        public IDiyetTipi DiyetNesnesiOlustur(string diyetTipi)
        {
            if (diyetTipi== "akdeniz")
            {
                return new AkdenizDiet();
            }
            else if (diyetTipi == "gluten free")
            {
                return new GlutenFreeDiet();
            }
            else if (diyetTipi== "deniz ürünleri")
            {
                return new DenizUrunleriDiet();
            }
            else if (diyetTipi== "yeşillik dünyası")
            {
                return new YesillikDunyasiDiet();
            }
            else
            {
                return null;
            }
        }
    }
}
