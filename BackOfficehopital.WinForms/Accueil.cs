using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using BackOfficeHopital.Core;
using Newtonsoft.Json;

namespace BackOfficehopital.WinForms
{
    public partial class Accueil : Form
    {
        public Accueil(Token token)
        {
            InitializeComponent();
            TokenHeader = token;
            
        }
        
        public Token TokenHeader { get; set; }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            var stockPage = new Stock();
            stockPage.ShowDialog();
            

        }

        private void debug_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(TokenHeader.token);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:8000/api/vaccin_types");
                request.Method = "GET";
                request.Headers["Authorization"] = $"Bearer {TokenHeader.token}";
                request.ContentType = "application/json";
                MessageBox.Show(request.Headers["Authorization"]);
                
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    var respStream = response.GetResponseStream();
                    

                    var reader = new StreamReader(respStream);
                    string data = reader.ReadToEnd();
                    lb_debug.Text = data;

            }
            catch (WebException exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            
            
        }
    }
}