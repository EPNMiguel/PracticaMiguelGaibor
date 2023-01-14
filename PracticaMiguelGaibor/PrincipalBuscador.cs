using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaMiguelGaibor
{
    public partial class PrincipalBuscador : Form
    {
        public PrincipalBuscador()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            Log logger = Log.getInstance();
             
            logger.logea(lblLogin.Text, 1, "");
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://api.covidtracking.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("https://api.covidtracking.com/v1/us/daily.json");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var countryInfo = System.Text.Json.JsonSerializer.Deserialize<List<CountryInfo>>(json);
                    if (countryInfo != null)
                    {
                        foreach ( var country in countryInfo ) {
                            DateTime oDate = DateTime.ParseExact(country.date.ToString(), "yyyyMMdd", null);
                            country.dateFormarted = oDate.ToString("yyyy-MM-dd");
                        }
                        dgvBuscador.AutoGenerateColumns= true;  
                        dgvBuscador.DataSource= countryInfo;
                        dgvBuscador.Columns["date"].Visible = false; 
                        dgvBuscador.Columns["hash"].Visible = false;
                        dgvBuscador.Columns[0].HeaderCell.Value = "Fecha";
                    }

                }
            }catch(Exception ex) { }
        }

        private void PrincipalBuscador_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cierraVentana);
        }

        private void cierraVentana(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
