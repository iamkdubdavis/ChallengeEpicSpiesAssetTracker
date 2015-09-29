using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                double[] elections = new double[0];
                ViewState.Add("Elections", elections);

                double[] subterfuge = new double[0];
                ViewState.Add("Subterfuge", subterfuge);

                string[] asset = new string[0];
                ViewState.Add("Asset", asset);
            }
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            double[] elections = (double[])ViewState["Elections"];
            double[] subterfuge = (double[])ViewState["Subterfuge"];
            string[] asset = (string[])ViewState["Asset"];

            Array.Resize(ref elections, elections.Length + 1);
            Array.Resize(ref subterfuge, subterfuge.Length + 1);
            Array.Resize(ref asset, asset.Length + 1);

            int newestElecItem = elections.GetUpperBound(0);
            elections[newestElecItem] = double.Parse(electionsTextBox.Text);
            ViewState["Elections"] = elections;

            int newestSubItem = subterfuge.GetUpperBound(0);
            subterfuge[newestSubItem] = double.Parse(subTextBox.Text);
            ViewState["Subterfuge"] = subterfuge;

            int newestAssetItem = asset.GetUpperBound(0);
            asset[newestAssetItem] = assetTextBox.Text;
            ViewState["Asset"] = asset;


            resultLabel.Text = String.Format("Total Elections Rigged: {0:N2}<br />Average Acts of Subterfuge per Asset: {1:N2}<br />(Last Asset you Added: {2})",
                elections.Sum(),
                subterfuge.Average(),
                asset[newestAssetItem]);

            assetTextBox.Text = " ";
            electionsTextBox.Text = " ";
            subTextBox.Text = " ";
        }
    }
}