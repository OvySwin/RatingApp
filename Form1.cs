using Humanizer;
using Newtonsoft.Json;

namespace RatingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStar1_Click(object sender, EventArgs e)
        {
            ShowRating(1);
        }

        private void btnStar2_Click(object sender, EventArgs e)
        {
            ShowRating(2);
        }

        private void btnStar3_Click(object sender, EventArgs e)
        {
            ShowRating(3);
        }

        private void btnStar4_Click(object sender, EventArgs e)
        {
            ShowRating(4);
        }

        private void btnStar5_Click(object sender, EventArgs e)
        {
            ShowRating(5);
        }

        private void ShowRating(int rating)
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show(
                    "Please enter your name first.",
                    "Name Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtName.Focus();
                return;
            }

            // Humanizer dependency:
            // Converts 1, 2, 3 etc. into one, two, three...
            string ratingInWords = rating.ToWords();

            lblResult.Text =
                $"Thanks {name}! You rated this app {ratingInWords} out of five stars.";

            // Newtonsoft.Json dependency:
            // Converts the rating information into JSON.
            var ratingData = new
            {
                Name = name,
                Rating = rating,
                RatingInWords = ratingInWords,
                SubmittedAt = DateTime.Now
            };

            string json = JsonConvert.SerializeObject(
                ratingData,
                Formatting.Indented);

            MessageBox.Show(
                json,
                "Rating Data (JSON)",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}