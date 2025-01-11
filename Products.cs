using System.Data;
using System.Data.SqlClient;
using winformfs2.Entities;
using winformfs2.NewFolder;

namespace winformfs2
{
    public partial class Products : Form
    {
        UserLoginResponseDTO responseDTO;
        string userFullname;

        Product selectedProduct = null;


        public Products(UserLoginResponseDTO responseDTO)
        {

            InitializeComponent();

            this.responseDTO = responseDTO;
            Reload();
        }
        public void Reload()
        {
            var notes = ListProduct();
            listBox1.DataSource = null;
            listBox1.DataSource = notes;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";
            //listBox1.Items.Clear();
            //listBox1.Items.AddRange(notes.ToArray());
            //listBox1.DisplayMember = "Name";
            //listBox1.ValueMember = "Id";

        }

        private void Product_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            Reload();
            lblUser.Text = responseDTO.Fullname;
            //var Ýtem = listBox1.SelectedItem as Product;
            //  lbltest.Text = Ýtem.Stock.ToString();


            lblUser.Text = userFullname;
        }



        private List<Product> ListProduct()
        {

            var productList = new List<Product>();

            SqlConnection connection = new SqlConnection
    ("server=.\\SQLExpress; database =TutorialDb; integrated security=true;");

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
            command.CommandText = "select * from Products";

            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var product = new Product();

                product.Id = Convert.ToInt32(reader[0]);
                product.Name = Convert.ToString(reader[1]);
                product.Stock = Convert.ToInt32(reader[2]);

                productList.Add(product);

            }

            reader.Close();
            connection.Close();

            return productList;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {

                selectedProduct = listBox1.SelectedItem as Product;
                txtStock.Text = selectedProduct.Stock + "";
                rtxtname.Text = selectedProduct.Name;
                lblstok.Text = selectedProduct.Stock.ToString();


            }



        }
        private void ClearText()
        {
            rtxtname.Text = string.Empty;
            txtStock.Text = string.Empty;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                if (!string.IsNullOrEmpty(rtxtname.Text) &&
                !string.IsNullOrEmpty(txtStock.Text))
                {
                    UpdateProduct(new Product { Name = rtxtname.Text, Stock = int.Parse(txtStock.Text), Id = selectedProduct.Id });
                    Reload();
                }
            }
            else
            {
                MessageBox.Show(MessageDefaults.PRODUCT_NOT_SELECT);
            }
        }

        private int UpdateProduct(Product updatedProduct)
        {
            SqlConnection connection = new SqlConnection
      ("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "Update Products set Name=@name, Stock=@stock where Id=@id";

            command.Parameters.AddWithValue("@name", updatedProduct.Name);
            command.Parameters.AddWithValue("@stock", updatedProduct.Stock);
            command.Parameters.AddWithValue("@id", updatedProduct.Id);

            connection.Open();
            int effectedRows = command.ExecuteNonQuery();
            return effectedRows;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearText();
            selectedProduct = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtxtname.Text) &&
                !string.IsNullOrEmpty(txtStock.Text))
            {
                SqlConnection connection = new SqlConnection
       ("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "insert into Products values(@name,@stock)";

                var stock = int.Parse(txtStock.Text);

                command.Parameters.AddWithValue("@name", rtxtname.Text);
                command.Parameters.AddWithValue("@stock", stock);

                connection.Open();
                var effectedRows = command.ExecuteNonQuery();
                command.Parameters.Clear();
                connection.Close();
                if (effectedRows > 0)
                {
                    MessageBox.Show("kayýt baþarýlý bir þekilde eklendi");
                    Reload();
                    ClearText();

                }
            }
            else
            {
                MessageBox.Show("alanlarý boþ býrakmayýnýz");
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                SqlConnection connection = new SqlConnection
     ("server=.\\SQLExpress;database=TutorialDb; integrated security=true;");
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "delete from Products where Id=@id";

                command.Parameters.AddWithValue("@id", selectedProduct.Id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                command.Parameters.Clear();
                Reload();
                ClearText();

            }
            else
            {
                MessageBox.Show(MessageDefaults.PRODUCT_NOT_SELECT);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            NavigationForm form = new NavigationForm(responseDTO);
            form.Show();
            this.Close();





        }


        //private void button1_Click(object sender, EventArgs e)
        //{

        //    

        //}
    }
}