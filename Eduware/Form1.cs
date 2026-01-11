using Eduware.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eduware
{
    public partial class form_login : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EduwareDB.mdb";

        public form_login()
        {
            InitializeComponent();
            ToolTipMessage();
            timer.Start();
        }

        private void ToolTipMessage()
        {
            tt.SetToolTip(pbx_information, "Boş");
            tt.SetToolTip(pbx_link, "Go to the website");
        }

        #region Events

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnl_window_control_button_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pbx_link_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://kaaner4mir.github.io/Bio/",
                UseShellExecute = true
            });
        }

        #endregion

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userNumber = tbx_usernumber.Text;
            string password = tbx_password.Text;
            string userRole = "";

            if (userNumber != "" && password != "")
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string queryStringStudent = "SELECT * FROM Students WHERE Number = @number AND Password = @password";

                    using (OleDbCommand command = new OleDbCommand(queryStringStudent, connection))
                    {
                        command.Parameters.AddWithValue("@number", userNumber);
                        command.Parameters.AddWithValue("@password", password);

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userRole = "Student";
                                form_student fStudent = new form_student();
                                this.Hide();
                                fStudent.ShowDialog();
                            }
                        }
                    }

                    if (userRole == "")
                    {
                        string queryStringLecturer = "SELECT * FROM Lecturers WHERE Number = @number AND Password = @password";

                        using (OleDbCommand command = new OleDbCommand(queryStringLecturer, connection))
                        {
                            command.Parameters.AddWithValue("@number", userNumber);
                            command.Parameters.AddWithValue("@password", password);

                            using (OleDbDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    userRole = "Lecturer";
                                    form_lecturer fLecturer = new form_lecturer();
                                    this.Hide();
                                    fLecturer.ShowDialog();
                                }
                            }
                        }
                    }

                    if (userRole == "")
                    {
                        string queryStringAuthor = "SELECT * FROM Authors WHERE Number = @number AND Password = @password";

                        using (OleDbCommand command = new OleDbCommand(queryStringAuthor, connection))
                        {
                            command.Parameters.AddWithValue("@number", userNumber);
                            command.Parameters.AddWithValue("@password", password);

                            using (OleDbDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    userRole = "Author";
                                    form_author fAuthor = new form_author();
                                    this.Hide();
                                    fAuthor.ShowDialog();
                                }
                            }
                        }
                    }

                    if (userRole == "")
                    {
                        userNumber = "";
                        password = "";
                        MessageBox.Show("User not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("The user number or password cannot be empty.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void form_login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.tbx_usernumber;
        }
    }
}
