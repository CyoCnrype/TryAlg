using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TryAlg
{
    public partial class Alg1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }      
        protected void btnCoculate_Click(object sender, EventArgs e)
        {
            #region 宣告class
            //宣告使用者資訊
            UserInfo userInfo = new UserInfo();
            //宣告演算法參數
            AlgorithmParameter algP = new AlgorithmParameter();
            #endregion

            #region 抓取age相關資訊
            userInfo.Age = Convert.ToInt32(txtUerAge.Text);
            algP.age_targetAgeButtom = Convert.ToInt32(txt_age_targetAgeButtom.Text);
            algP.age_targetAgeTop = Convert.ToInt32(txt_age_targetAgeTop.Text);
            algP.age_direction = Convert.ToInt32(txt_age_direction.Text);
            #endregion

            #region 抓取job相關資訊
            userInfo.Job = txtUserJob.Text;
            algP.job_dict = new Dictionary<string, double>();
            algP.job_dict.Add("醫護人員", 1);
            algP.job_dict.Add("防疫人員", 0.9);
            algP.job_dict.Add("政府職員", 0.8);
            algP.job_dict.Add("航空從業者", 0.7);
            algP.job_dict.Add("長照", 0.6);
            algP.job_dict.Add("軍警", 0.5);
            algP.job_dict.Add("教師", 0.4);
            algP.job_dict.Add("學生", 0.3);
            algP.job_dict.Add("有職業其他", 0.2);
            algP.job_dict.Add("無職業", 0.1);
            #endregion

            #region 抓取state相關資訊
            userInfo.Status = txtUserState.Text;
            algP.state_dict = new Dictionary<string, double>();
            algP.state_dict.Add("因公出國", 2);

            #endregion

            #region 抓取Ordinal 相關資訊
            userInfo.DoseCount = Convert.ToInt32(txtUerDoseCount.Text);
            algP.ordinal_dict = Convert.ToInt32(txt_ordinal.Text);
            #endregion

            #region 抓取Area 相關資訊
            userInfo.Area = txtUerArea.Text;
            algP.area_area = txt_area.Text;
            #endregion

            #region 執行演算
            var result = AlgHelper.GetTotalScore(userInfo, algP);
            ltShow.Text = result.ToString();
            #endregion

        }
    }
}