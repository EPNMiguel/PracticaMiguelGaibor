using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaMiguelGaibor
{
    public partial class PrincipalCiudadano : Form
    {
        public PrincipalCiudadano()
        {
            InitializeComponent();
        }

        private void PrincipalCiudadano_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cierraVentana);
        }

        private async void cierraVentana(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private async void btnBuscarC_Click(object sender, EventArgs e)
        {
            Log logger = Log.getInstance();
            logger.logea(lblLoginC.Text, 2, "");
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://api.covidtracking.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("https://api.covidtracking.com/v1/states/daily.json");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var stateInfo = System.Text.Json.JsonSerializer.Deserialize<List<StateInfo>>(json);
                    if (stateInfo != null)
                    {
                        foreach (var estado in stateInfo.ToList())
                        {
                            DateTime oDate = DateTime.ParseExact(estado.date.ToString(), "yyyyMMdd", null);
                            estado.dateFormarted = oDate.ToString("yyyy-MM-dd");
                            if (!estado.state.Equals(lblAbre.Text))
                            {
                                stateInfo.Remove(estado);

                            }
                        }

                        dgvBuscarC.AutoGenerateColumns = true;
                        dgvBuscarC.DataSource = stateInfo;

                        dgvBuscarC.Columns["date"].Visible = false;
                        dgvBuscarC.Columns["hash"].Visible = false;
                        dgvBuscarC.Columns[0].HeaderCell.Value = "Fecha";
                    }

                }
            }
            catch (Exception ex) { }

        }
    }
}
