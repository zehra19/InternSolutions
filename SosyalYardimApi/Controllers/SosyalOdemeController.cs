using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SosyalYardimApi.Operations;
using System.Data.SqlClient;
using System.Data;

namespace SosyalYardimApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SosyalOdemeController : ControllerBase
    {
        private int odemeKd;
        private object sosyalOdemeleri;
        private object parameters;
        private object dbOperations;
        private object sosyalOdeme;
        private object command;
        private object cmd;
        
       
        public bool Boolean { get; private set; }
        public int OdemeKd { get; private set; }

    [HttpGet(Name = "SorgulaSosyalOdeme")]
        public ActionResult<List<SosyalOdeme>> Get(string tckn)
        {
            try
            {
                //Yapılacak: Tckn 11 karakterli mi kontrolü yapılacak değilse dönüş olacak,
                //return Ok("TCKN Hatalı");
                if (tckn.Length == 11)
                {
                    List<SosyalOdeme> sosyalOdemeleri = new List<SosyalOdeme>();

                    DbOperations dbOperations = new DbOperations();

                    var parameters = new List<SqlParameter>();
                    var param = new SqlParameter("TCKN", tckn);
                    parameters.Add(param);
                    DataTable dtSonuc = dbOperations.GetData("MUSTERI_SELECT", parameters);


                    for (int i = 0; i < dtSonuc.Rows.Count; i++)
                    {
                        SosyalOdeme sosyalOdeme = new SosyalOdeme();

                        sosyalOdeme.OdemeNo = Convert.ToInt32(dtSonuc.Rows[i]["ODEMENO"]);
                        sosyalOdeme.Tckn = Convert.ToString(dtSonuc.Rows[i]["TCKIMLIKNO"]);
                        sosyalOdeme.Adi = dtSonuc.Rows[i]["MUSTERIAD"].ToString();
                        sosyalOdeme.SoyAdi = dtSonuc.Rows[i]["MUSTERISOYAD"].ToString();
                        sosyalOdeme.OdemeKd = Convert.ToInt32(dtSonuc.Rows[i]["ODEME_KD"]);
                        sosyalOdeme.OdenecekTtr = Convert.ToDecimal(dtSonuc.Rows[i]["ODENECEK_TTR"]);
                        if (dtSonuc.Rows[i]["ODEME_TR"] != DBNull.Value)
                            sosyalOdeme.OdenecekDt = Convert.ToDateTime(dtSonuc.Rows[i]["ODEME_TR"]);

                        sosyalOdemeleri.Add(sosyalOdeme);
                    }

                    return Ok(sosyalOdemeleri);
                }
                else return Ok("hatalı tckn girdiniz");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut(Name = "OdemeYapildiSosyalOdeme")]

        public ActionResult<bool> Put(string tckn, int odemeNo)
        {
            try
            {
                List<SosyalOdeme> sosyalOdemeleri = new List<SosyalOdeme>();

                DbOperations dbOperations = new DbOperations();


                var parameters = new List<SqlParameter>();
                var param1 = new SqlParameter("TCKN", tckn);
                parameters.Add(param1);

                var param2 = new SqlParameter("ODEMENO", odemeNo);
                parameters.Add(param2);

                DataTable dtSonuc = dbOperations.GetData("KD", parameters);


                for (int i = 0; i < dtSonuc.Rows.Count; i++)

                {
                    SosyalOdeme sosyalOdeme = new SosyalOdeme();

                    sosyalOdeme.OdemeNo = Convert.ToInt32(dtSonuc.Rows[i]["ODEMENO"]);
                    sosyalOdeme.Tckn = Convert.ToString(dtSonuc.Rows[i]["TCKIMLIKNO"]);
                    sosyalOdeme.Adi = dtSonuc.Rows[i]["MUSTERIAD"].ToString();
                    sosyalOdeme.SoyAdi = dtSonuc.Rows[i]["MUSTERISOYAD"].ToString();
                    sosyalOdeme.OdemeKd = Convert.ToInt32(dtSonuc.Rows[i]["ODEME_KD"]);
                    sosyalOdeme.OdenecekTtr = Convert.ToDecimal(dtSonuc.Rows[i]["ODENECEK_TTR"]);
                    if (dtSonuc.Rows[i]["ODEME_TR"] != DBNull.Value)
                        sosyalOdeme.OdenecekDt = Convert.ToDateTime(dtSonuc.Rows[i]["ODEME_TR"]);

                    sosyalOdemeleri.Add(sosyalOdeme);
                    odemeKd = sosyalOdeme.OdemeKd;

                }

                //Yapılacak: Odeme no ve tckn e ait ödemeyi bul
                //Ödemenin durum kontrolü yap  =0 ise 
                //eğer kontrolden başarılı geçmez ise false dön işlemi kes


                 if (odemeKd == 0)
                 {
                    List<SqlParameter> parametreler = new List<SqlParameter>();
                    SqlParameter par1 = new SqlParameter("TCKN", tckn);
                    parametreler.Add(par1);
                    //parametre atamalarında çakışma olduğu için tekrar parametre atadık
                    SqlParameter par2 = new SqlParameter("ODEMENO", odemeNo);
                    parametreler.Add(par2);
                    dbOperations.ExecuteNonQuery("ODEME_YAP", parametreler);

                    //return Ok(sosyalOdeme);
                    return Ok(true);

                 }

                 else
                 {
                    //return Ok(sosyalOdemeleri);
                    return Accepted();
                 }

               
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
    }



    
