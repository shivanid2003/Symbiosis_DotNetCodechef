using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuestionBank
{
    public partial class QuestionPaperGenerator : System.Web.UI.Page
    {
        private static List<QuestionBankClass> selectedQuestions;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            List<QuestionBankClass> questions = GetRandomQuestions();
            selectedQuestions = questions;

            rptQuestions.DataSource = questions;
            rptQuestions.DataBind();
            pnlQuestions.Visible = true;
        }

        protected void btnPreview_Click(object sender, EventArgs e)
        {
            Session["SelectedQuestions"] = selectedQuestions;
            Response.Redirect("Preview.aspx");
        }
        private List<QuestionBankClass> GetRandomQuestions()
        {
            List<QuestionBankClass> questions = new List<QuestionBankClass>();
            string connectionString = ConfigurationManager.ConnectionStrings["QuestionBankDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 5 * FROM QuestionPaper ORDER BY NEWID()";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    questions.Add(new QuestionBankClass
                    {
                        QId = Convert.ToInt32(reader["q_id"]),
                        Question = reader["question"].ToString(),
                        OptionA = reader["optionA"].ToString(),
                        OptionB = reader["optionB"].ToString(),
                        OptionC = reader["optionC"].ToString(),
                        OptionD = reader["optionD"].ToString(),
                        CorrectOption = reader["correctOption"].ToString()
                    });
                }
            }

            return questions;
        }

    }

    public class QuestionBankClass
    {
        public int QId { get; set; }
        public string Question { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectOption { get; set; }
    }

}