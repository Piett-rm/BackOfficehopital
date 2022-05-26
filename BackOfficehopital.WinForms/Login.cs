using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using BackOfficeHopital.Core;
using Newtonsoft.Json;

namespace BackOfficehopital.WinForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_val_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_username.Text) || string.IsNullOrWhiteSpace(txt_password.Text) )
            {
                MessageBox.Show("Veuillez mettre une valeur dans les champs");
            }
            else
            {
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:8000/api/login_check");
                    request.Method = "POST";

                    var loginJwt = new LoginJWT(txt_username.Text, txt_password.Text);
                    var json = JsonConvert.SerializeObject(loginJwt);
                    // var jsonDes = JsonConvert.Deserialize<LoginJWT>(json);
                    byte[] byteArray = Encoding.UTF8.GetBytes(json);
                    request.ContentType = "application/json";
                    request.ContentLength = byteArray.Length;
            
                    var reqStream = request.GetRequestStream();
                    reqStream.Write(byteArray, 0, byteArray.Length);

                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    // MessageBox.Show($"La valeur est {response.StatusCode}");
                    // if (response.StatusCode === )
                    // {
                    //     MessageBox.Show("Le username ou le password est faux");
                    // }
                    var respStream = response.GetResponseStream();
                    

                    var reader = new StreamReader(respStream);
                    string data = reader.ReadToEnd();
                    string token = data.Substring(10, 838);
                    var classtoken = new Token(token);

                    if (data != null)
                    {
                        var accueil = new Accueil(classtoken);
                        Hide();
                        accueil.ShowDialog();
                        // MessageBox.Show($"La valeur est {token} et le json {data}", @"Debug", MessageBoxButtons.OK);
                    }
                }
                catch (WebException err)
                {
                    if (err.Status.ToString() == "ProtocolError")
                    {
                        MessageBox.Show("Password ou Mot de passe incorrect");
                    }
                }
                
            }
            //
            //string test = JsonConvert.DeserializeObject<string>(data);



            
        }
    }
}