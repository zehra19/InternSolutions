using RestSharp;
using SosyalYardimApi.Controllers;
using SosyalYardimPaymentForm.DTO;
using System.Threading;

namespace SosyalYardimPaymentForm
{
    public partial class MainForm : Form
    {
        private readonly string _endpoint = "https://localhost:7150/api/";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            GetAll();

        }

        private void GetAll()
        {
            var client = new RestClient(_endpoint);
            var request = new RestRequest("SosyalOdeme", Method.Get);
            request.AddParameter("TCKN", tbTckn.Text);
            var queryResult = client.Execute<List<ApiSosyalOdeme>>(request).Data;
            dataGridView1.DataSource = queryResult;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tbTckn_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         /* var x = dataGridView1.CurrentRow.Cells[0].Value.ToString();
          var y = dataGridView1.CurrentRow.Cells[1].Value.ToString();
          var z = dataGridView1.CurrentRow.Cells[2].Value.ToString();
          var t = dataGridView1.CurrentRow.Cells[3].Value.ToString();
          var a = dataGridView1.CurrentRow.Cells[4].Value.ToString();
          var b = dataGridView1.CurrentRow.Cells[5].Value.ToString();
          var c = dataGridView1.CurrentRow.Cells[6].Value.ToString();*/

            DialogResult sonuc;
            sonuc = MessageBox.Show("Ödemeyi onaylýyor musunuz?", "ÖDEME ONAYI", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);


           


            if (sonuc == DialogResult.Yes)
            {
                var client = new RestClient(_endpoint);
                var request = new RestRequest("SosyalOdeme?tckn=" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "&odemeNo=" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()), Method.Put);
              
                //Console.Write(request);

               //  request.AddParameter("ODEME_KD", dataGridView1.CurrentRow.Cells[4].Value.ToString());
              
                var queryResult2 = client.Execute<bool>(request);
                //Console.Write(request);
                if (queryResult2.StatusCode == System.Net.HttpStatusCode.Accepted)
                {
                    MessageBox.Show("Geçersiz Ödeme");

                }
                else if (queryResult2.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Ödemeniz Gerçekleþtirildi");
                }

                //  SosyalOdemeController islem = new SosyalOdemeController();
                // var aaa =islem.Put(dataGridView1.CurrentRow.Cells[1].Value.ToString(),Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                GetAll();
                

            }
            


        }


    }
}