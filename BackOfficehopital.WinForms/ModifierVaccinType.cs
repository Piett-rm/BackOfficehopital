using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using BackOfficeHopital.Core;
using Newtonsoft.Json;

namespace BackOfficehopital.WinForms
{
    public partial class ModifierVaccinType : Form
    {
        public ModifierVaccinType(VaccinTypes vaccinTypes, Token token)
        {
            InitializeComponent();
            Text = $"Modifier le vaccin {vaccinTypes.nom}";
            txt_nom.Text = vaccinTypes.nom;
            num_stock.Value = (int) vaccinTypes.stock;
            textBox1.Text = vaccinTypes.id;
            textBox2.Text = token.token;
            VaccinTypesImporte = vaccinTypes;
        }
        public VaccinTypes VaccinTypesImporte { get; set; }

        private void bt_val_Click(object sender, EventArgs e)
        {
            VaccinTypesImporte.stock = (int) num_stock.Value;
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"http://localhost:8000/api/vaccin_types/{textBox1.Text}");
            request.Method = "PUT";

            var vaccinType = new VaccinTypes(textBox1.Text, txt_nom.Text, (int) num_stock.Value);
            var json = JsonConvert.SerializeObject(vaccinType);
            // var jsonDes = JsonConvert.Deserialize<LoginJWT>(json);
            byte[] byteArray = Encoding.UTF8.GetBytes(json);
            request.Headers["Authorization"] = $"Bearer {textBox2.Text}";
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;
            
            
            var reqStream = request.GetRequestStream();
            reqStream.Write(byteArray, 0, byteArray.Length);

            MessageBox.Show("Modification enregistrées");
            Close();
        }
    }
}