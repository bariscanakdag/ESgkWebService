using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESgk.WorkIn.ContractTypes;
using ESgk.WorkIn.Interfaces;
using ESgk.WorkIn.Model;
using ESgk.WorkIn.tr.gov.sgk.sgkt;
using kullaniciBilgileri = ESgk.WorkIn.tr.gov.sgk.sgkt.kullaniciBilgileri;
using tcKimliktenIseGirisSorParametre = ESgk.WorkIn.tr.gov.sgk.sgkt.tcKimliktenIseGirisSorParametre;


namespace ESgk.WorkIn.Services
{
    public class WorkInService : IWorkInService
    {
        public string GetWorkInStatus(WorkInQueriesModel workInQueriesModel)
        {

            tcKimliktenIseGirisSorParametre
                tckimlikNoileiseGirisSorgula = new tcKimliktenIseGirisSorParametre();
            tckimlikNoileiseGirisSorgula.kullaniciBilgileri =new kullaniciBilgileri();
            

            tckimlikNoileiseGirisSorgula.kullaniciBilgileri.kullaniciAdi =
                workInQueriesModel.kullaniciAdi;
            tckimlikNoileiseGirisSorgula.kullaniciBilgileri.isyeriKodu =
                workInQueriesModel.kullaniciAdi;
            tckimlikNoileiseGirisSorgula.kullaniciBilgileri.isyeriSicil =
                workInQueriesModel.isyeriSicil;
            tckimlikNoileiseGirisSorgula.kullaniciBilgileri.isyeriSifre =
                workInQueriesModel.isyeriSifre;
            tckimlikNoileiseGirisSorgula.kullaniciBilgileri.sistemSifre =
                workInQueriesModel.sistemSifre;
            tckimlikNoileiseGirisSorgula.tcKimlikNo = workInQueriesModel.tcKimlikNo;

            WS_SgkIseGirisService iseGiris = new WS_SgkIseGirisService();
            var response = iseGiris.tckimlikNoileiseGirisSorgula(tckimlikNoileiseGirisSorgula);

            iseGiris.tckimlikNoileiseGirisSorgula(tckimlikNoileiseGirisSorgula);





            return "geldi";
        }
    }
}
