using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using BackOfficeHopital.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BackOfficehopital.WinForms
{
    public partial class Accueil : Form
    {
        
        BindingList<VaccinTypes> tabVaccinTypesList= new BindingList<VaccinTypes>();
        
        public Accueil(Token token)
        {
            InitializeComponent();
            TokenHeader = token;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:8000/api/vaccin_types");
                request.Method = "GET";
                request.Headers["Authorization"] = $"Bearer {TokenHeader.token}";
                request.ContentType = "application/json";
                
                
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                var respStream = response.GetResponseStream();
                    

                var reader = new StreamReader(respStream);
                string data = reader.ReadToEnd();
                JObject json = JObject.Parse(data);
                var jsonVaccinTypes = json["hydra:member"];
                
                foreach (var oneVaccinTypes in jsonVaccinTypes)
                {
                    VaccinTypes vaccinTypes = new VaccinTypes(oneVaccinTypes["id"].ToString(),oneVaccinTypes["nom"].ToString(), int.Parse(oneVaccinTypes["stock"].ToString()));
                    tabVaccinTypesList.Add(vaccinTypes);
                    if (vaccinTypes.stock < 100)
                    {
                        MessageBox.Show($"Le vaccin {vaccinTypes.nom} possède un stock bas ({vaccinTypes.stock})");
                    }
                }

                listVaccinType.DataSource = tabVaccinTypesList;
                

            }
            catch (WebException exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            
            
        }
        
        public Token TokenHeader { get; set; }
        

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            var modifierVaccinType = new ModifierVaccinType((VaccinTypes) listVaccinType.SelectedItem, TokenHeader);
            modifierVaccinType.ShowDialog();
            tabVaccinTypesList.ResetBindings();

        }
    }
}