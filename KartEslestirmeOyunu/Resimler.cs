using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartEslestirmeOyunu
{
   public class Resimler
    {    
        public Image[] cicekler= //resim dizisi
        {
            Properties.Resources.gelincik,
            Properties.Resources.ayçiçeği,
            Properties.Resources.bokeh,
            Properties.Resources.dalya,
            Properties.Resources.gül,
            Properties.Resources.karahindiba,
            Properties.Resources.lale,
            Properties.Resources.lotus,
            Properties.Resources.papatya,
            Properties.Resources.petal,
            Properties.Resources.pixabay,
            Properties.Resources.anthony,
            Properties.Resources.portakal_çiçeği,
            Properties.Resources.orkide,

        };

        public Image[] hayvanlar = //resim dizisi
        {
            Properties.Resources.fil,
            Properties.Resources.koala,
            Properties.Resources.kuş,
            Properties.Resources.penguen,
            Properties.Resources.kelebek,
            Properties.Resources.kaplumbağa,
            Properties.Resources.tavşan,
            Properties.Resources.zürafa,

        };

        public Image[] meslekler = //resim dizisi
        {
            Properties.Resources.açşı,
            Properties.Resources.doktor,
            Properties.Resources.avukat,
            Properties.Resources.itfaiyeci,
            Properties.Resources.mühendis,
            Properties.Resources.kaptan,
            Properties.Resources.spiker,
            Properties.Resources.şarkıcı,
            Properties.Resources.kimyager,
            Properties.Resources.pilot,
            Properties.Resources.öğretmen,

        };
    }
}
