using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuestionBank
{
    public partial class Preview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<QuestionBankClass> questions = Session["SelectedQuestions"] as List<QuestionBankClass>;

                if (questions != null)
                {
                    rptPreviewQuestions.DataSource = questions;
                    rptPreviewQuestions.DataBind();
                }
            }
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("QuestionPaperGenerator.aspx");
        }

      
    }
}