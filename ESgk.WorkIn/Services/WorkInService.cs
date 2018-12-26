using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESgk.WorkIn.Interfaces;
using ESgk.WorkIn.Model;
using ESgk.WorkIn.SgkService;

namespace ESgk.WorkIn.Services
{
    public class WorkInService : IWorkInService
    {
        public string GetWorkInStatus(WorkInQueriesModel workInQueriesModel)
        {

            tckimlikNoileiseGirisSorgulaRequest
                tckimlikNoileiseGirisSorgula = new tckimlikNoileiseGirisSorgulaRequest();
            tckimlikNoileiseGirisSorgula.tcKimliktenIseGirisSorParametre = new tcKimliktenIseGirisSorParametre();
            tckimlikNoileiseGirisSorgula.tcKimliktenIseGirisSorParametre.kullaniciBilgileri = new kullaniciBilgileri();

            tckimlikNoileiseGirisSorgula.tcKimliktenIseGirisSorParametre.kullaniciBilgileri.kullaniciAdi =
                workInQueriesModel.kullaniciAdi;
            tckimlikNoileiseGirisSorgula.tcKimliktenIseGirisSorParametre.kullaniciBilgileri.isyeriKodu =
                workInQueriesModel.kullaniciAdi;
            tckimlikNoileiseGirisSorgula.tcKimliktenIseGirisSorParametre.kullaniciBilgileri.isyeriSicil =
                workInQueriesModel.isyeriSicil;
            tckimlikNoileiseGirisSorgula.tcKimliktenIseGirisSorParametre.kullaniciBilgileri.isyeriSifre =
                workInQueriesModel.isyeriSifre;
            tckimlikNoileiseGirisSorgula.tcKimliktenIseGirisSorParametre.kullaniciBilgileri.sistemSifre =
                workInQueriesModel.sistemSifre;
            tckimlikNoileiseGirisSorgula.tcKimliktenIseGirisSorParametre.tcKimlikNo = workInQueriesModel.tcKimlikNo;

            WS_SgkIseGiris iseGiris = new WS_SgkIseGirisClient();
            var response = iseGiris.tckimlikNoileiseGirisSorgula(tckimlikNoileiseGirisSorgula);







            return "geldi";
        }
    }
}
