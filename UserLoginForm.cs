using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using winformfs2.Entities;
using winformfs2.NewFolder;
using winformfs2KOPYAA.NewFolder;

namespace winformfs2
{
    public partial class UserLoginForm : Form
    {


        public UserLoginForm()
        {
            InitializeComponent();
        }




        private UserLoginResponseDTO GetUser(string username, string password)
        {

            SqlConnection connection = new SqlConnection
("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText =
          "select * from Users where Username=@username and Password=@password ";

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            connection.Open();
            var reader = command.ExecuteReader();
            command.Parameters.Clear();


            var id = 0;
            string fullname = "";
            string passwordHS = "";


            UserLoginResponseDTO responseDto = null;
            while (reader.Read())
            {
                responseDto = new UserLoginResponseDTO();
                responseDto.Id = Convert.ToInt32(reader[0]);
                responseDto.Fullname = Convert.ToString(reader[3]);
                responseDto.PasswordHS = Convert.ToString(reader[5]);




            }
            reader.Close();
            connection.Close();
            return responseDto;



        }




        private void btngiriş_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAd.Text) &&
              !string.IsNullOrEmpty(txtPas.Text))

            {

                var response = GetUser(txtAd.Text, txtPas.Text);

                if (response != null)

                {
                    string hashedPassword = Sha256Converter.ComputeSha256Hash(txtPas.Text);
                    // MessageBox.Show(hashedPassword);
                    //benim programımda normal şifreden oluşturduğum sha256 kodu
                    // MessageBox.Show(response.PasswordH);
                    //if (hashedPassword,response.PasswordH))


                    if (response.PasswordHS == hashedPassword)
                    {
                        NavigationForm form = new NavigationForm(response);
                        // MessageBox.Show("Hash doğru");
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hash yanlış");
                    }
                }
                else
                {

                    MessageBox.Show(MessageDefaults.WRONG_EXİT);

                }
            }



        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Üzgünüz:( Bu control yapım aşamasındadır.Lütfen şifrenizi hatırlayınız!");
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}













