using DotNetWebSearchAnalyticsAPI.Shared;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace DotNetWebSearchAnalyticsAPI.Client
{
    public partial class APIForm : Form
    {
        public APIForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HttpClient lHttpClient = new HttpClient(); ;

                var lModel = new RegisterViewModel
                {
                    Email = txtNewUserUsername.Text,
                    Password = txtNewUserPassword.Text,
                    ConfirmPassword = txtNewUserConfirmPassword.Text
                };

                var jSonData = JsonConvert.SerializeObject(lModel);

                StringContent lStringContent = new StringContent(jSonData, Encoding.UTF8, "application/json");

                HttpResponseMessage lHttpResponse = await lHttpClient.PostAsync($"{txtAPIAddress.Text}/api/Auth/Register", lStringContent);

                string lHttpContent = await lHttpResponse.Content.ReadAsStringAsync();

                try
                {
                    var lResponseObject = JsonConvert.DeserializeObject<UserManagerResponse>(lHttpContent);

                    if (lResponseObject.isSuccess)
                        MessageBox.Show("Your account has been created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(lResponseObject.Errors.FirstOrDefault(), "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception prException)
                {
                    MessageBox.Show(lHttpContent, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception prException)
            {
                MessageBox.Show(prException.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNewUserUsername.Text = "";
            txtNewUserPassword.Text = "";
            txtNewUserConfirmPassword.Text = "";
            txtNewUserUsername.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtLoginUsername.Text = "";
            txtLoginPassword.Text = "";
            txtLoginUsername.Focus();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                HttpClient lHttpClient = new HttpClient(); ;

                var lModel = new LoginViewModel
                {
                    Email = txtLoginUsername.Text,
                    Password = txtLoginPassword.Text
                };

                var jSonData = JsonConvert.SerializeObject(lModel);

                StringContent lStringContent = new StringContent(jSonData, Encoding.UTF8, "application/json");

                HttpResponseMessage lHttpResponse = await lHttpClient.PostAsync($"{txtAPIAddress.Text}/api/Auth/Login", lStringContent);

                string lHttpContent = await lHttpResponse.Content.ReadAsStringAsync();

                try
                {
                    var lResponseObject = JsonConvert.DeserializeObject<UserManagerResponse>(lHttpContent);

                    if (lResponseObject.isSuccess)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtJWBToken.Text = lResponseObject.Message;
                    }
                    else
                        MessageBox.Show(lResponseObject.Errors.FirstOrDefault(), "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception prException)
                {
                    MessageBox.Show(lHttpContent, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception prException)
            {
                MessageBox.Show(prException.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtJWBToken.Text))
                System.Windows.Forms.Clipboard.SetText(txtJWBToken.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    HttpClient lHttpClient = new HttpClient(); ;

                    HttpResponseMessage lHttpResponse = await lHttpClient.GetAsync($"{txtAPIAddress.Text}/");

                    string lHttpContent = await lHttpResponse.Content.ReadAsStringAsync();
                    MessageBox.Show(lHttpContent, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception prException)
                {
                    MessageBox.Show(prException.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception prException)
            {
                MessageBox.Show(prException.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void btnClearNewUser_Click(object sender, EventArgs e)
        {
            txtNewUserUsername.Text = "";
            txtNewUserPassword.Text = "";
            txtNewUserConfirmPassword.Text = "";
            txtNewUserUsername.Focus();
        }

        private void APIForm_Load(object sender, EventArgs e)
        {

        }
    }
}