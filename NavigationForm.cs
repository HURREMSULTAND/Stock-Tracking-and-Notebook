using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformfs2
{
    public partial class NavigationForm : Form
    {
        UserLoginResponseDTO responseDTO;


        public NavigationForm(UserLoginResponseDTO responseDTO)
        {

            InitializeComponent();
            this.responseDTO = responseDTO;
            

            


        }

        private void btnpro_Click(object sender, EventArgs e)
        {
          
            

            Products form = new Products(responseDTO);
           
            form.Show();
            this.Hide();
        }


        private void btnnote_Click(object sender, EventArgs e)
        {
            NotesForm form = new NotesForm(responseDTO);
            form.Show();
            this.Hide();

        }

        private void NavigationForm_Load(object sender, EventArgs e)
        {
           // this.responseDTO = responseDTO;

        }
    }
}
