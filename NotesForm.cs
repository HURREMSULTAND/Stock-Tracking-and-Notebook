using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winformfs2.Entities;
using winformfs2.NewFolder;

namespace winformfs2
{
    public partial class NotesForm : Form
    {
        UserLoginResponseDTO responseDTO;

        Note selectedNote = null;

        public NotesForm(UserLoginResponseDTO responseDTO)
        {
            InitializeComponent();
            this.responseDTO = responseDTO;
            // Reload();
        }

        private void Reload()
        {
            var notes = ListNote();
            listnot.DataSource = null;
            listnot.DataSource = notes;
            listnot.DisplayMember = "Description";
            listnot.ValueMember = "Id";

        }
        private void ClearText()
        {
            rtxtnotes.Text = string.Empty;

        }



        private List<Note> ListNote()

        {
            var notes = new List<Note>();
            if (responseDTO != null)
            {
                SqlConnection connection = new SqlConnection
("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText =
     "select * from Notes where UserId=@userId";
                command.Parameters.AddWithValue("@userId", responseDTO.Id);


                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var note = new Note();
                    note.Id = Convert.ToInt32(reader[0]);
                    note.Description = Convert.ToString(reader[1]);
                    note.UserId = Convert.ToInt32(reader[2]);

                    notes.Add(note);


                }
                reader.Close();
                connection.Close();
                command.Parameters.Clear();

            }
            return notes;


        }

        private void NotesForm_Load(object sender, EventArgs e)
        {
            Reload();
            lblUser.Text = responseDTO.Fullname;
        }

        private void NotesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtxtnotes.Text) &&
                responseDTO != null)
            {
                SqlConnection connection = new SqlConnection
("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText =
 "insert into Notes values (@description,@userId)";

                command.Parameters.AddWithValue("@description", rtxtnotes.Text);
                command.Parameters.AddWithValue("@userId", responseDTO.Id);

                connection.Open();
                var effectedRows = command.ExecuteNonQuery();
                command.Parameters.Clear();
                connection.Close();

                if (effectedRows > 0)
                {
                    MessageBox.Show(MessageDefaults.SUCCSESFULY_ADD);
                    Reload();
                    ClearText();

                }



            }
        }

      
        private void listnot_SelectedIndexChanged(object sender, EventArgs e)
        {



            if (listnot.SelectedItem != null)
            {
                selectedNote = listnot.SelectedItem as Note;
                rtxtnotes.Text = selectedNote.Description;
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearText();
            selectedNote = null;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedNote != null && !string.IsNullOrEmpty(rtxtnotes.Text))
            {
                SqlConnection connection = new SqlConnection
   ("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText =
    "update Notes set Description=@description where Id=@id";

                command.Parameters.AddWithValue("@description", rtxtnotes.Text);
                command.Parameters.AddWithValue("@id", selectedNote.Id);

                connection.Open();
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                connection.Close();

                Reload();
                ClearText();


            }
            else
            {
                MessageBox.Show(MessageDefaults.NOTE_NOT_SELECTED);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigationForm form = new NavigationForm(responseDTO);
            form.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //   

        //}
    }
}
