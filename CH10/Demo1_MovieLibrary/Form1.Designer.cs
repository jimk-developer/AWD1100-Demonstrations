namespace Demo1_MovieLibrary
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblSelectMovie = new System.Windows.Forms.Label();
            this.cboMovies = new System.Windows.Forms.ComboBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitleValue = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblDirectorValue = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblYearValue = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblGenreValue = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblRatingValue = new System.Windows.Forms.Label();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectMovie
            // 
            this.lblSelectMovie.AutoSize = true;
            this.lblSelectMovie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSelectMovie.Location = new System.Drawing.Point(20, 20);
            this.lblSelectMovie.Name = "lblSelectMovie";
            this.lblSelectMovie.Size = new System.Drawing.Size(100, 19);
            this.lblSelectMovie.Text = "Select a Movie:";
            // 
            // cboMovies
            // 
            this.cboMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMovies.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMovies.Location = new System.Drawing.Point(20, 45);
            this.cboMovies.Name = "cboMovies";
            this.cboMovies.Size = new System.Drawing.Size(340, 25);
            this.cboMovies.SelectedIndexChanged += new System.EventHandler(this.cboMovies_SelectedIndexChanged);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.lblTitle);
            this.grpDetails.Controls.Add(this.lblTitleValue);
            this.grpDetails.Controls.Add(this.lblDirector);
            this.grpDetails.Controls.Add(this.lblDirectorValue);
            this.grpDetails.Controls.Add(this.lblYear);
            this.grpDetails.Controls.Add(this.lblYearValue);
            this.grpDetails.Controls.Add(this.lblGenre);
            this.grpDetails.Controls.Add(this.lblGenreValue);
            this.grpDetails.Controls.Add(this.lblRating);
            this.grpDetails.Controls.Add(this.lblRatingValue);
            this.grpDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDetails.Location = new System.Drawing.Point(20, 85);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(340, 230);
            this.grpDetails.Text = "Movie Details";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(15, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(40, 19);
            this.lblTitle.Text = "Title:";
            // 
            // lblTitleValue
            // 
            this.lblTitleValue.AutoSize = true;
            this.lblTitleValue.Location = new System.Drawing.Point(120, 35);
            this.lblTitleValue.Name = "lblTitleValue";
            this.lblTitleValue.Size = new System.Drawing.Size(0, 19);
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDirector.Location = new System.Drawing.Point(15, 70);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(62, 19);
            this.lblDirector.Text = "Director:";
            // 
            // lblDirectorValue
            // 
            this.lblDirectorValue.AutoSize = true;
            this.lblDirectorValue.Location = new System.Drawing.Point(120, 70);
            this.lblDirectorValue.Name = "lblDirectorValue";
            this.lblDirectorValue.Size = new System.Drawing.Size(0, 19);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblYear.Location = new System.Drawing.Point(15, 105);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(40, 19);
            this.lblYear.Text = "Year:";
            // 
            // lblYearValue
            // 
            this.lblYearValue.AutoSize = true;
            this.lblYearValue.Location = new System.Drawing.Point(120, 105);
            this.lblYearValue.Name = "lblYearValue";
            this.lblYearValue.Size = new System.Drawing.Size(0, 19);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGenre.Location = new System.Drawing.Point(15, 140);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(49, 19);
            this.lblGenre.Text = "Genre:";
            // 
            // lblGenreValue
            // 
            this.lblGenreValue.AutoSize = true;
            this.lblGenreValue.Location = new System.Drawing.Point(120, 140);
            this.lblGenreValue.Name = "lblGenreValue";
            this.lblGenreValue.Size = new System.Drawing.Size(0, 19);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRating.Location = new System.Drawing.Point(15, 175);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(53, 19);
            this.lblRating.Text = "Rating:";
            // 
            // lblRatingValue
            // 
            this.lblRatingValue.AutoSize = true;
            this.lblRatingValue.Location = new System.Drawing.Point(120, 175);
            this.lblRatingValue.Name = "lblRatingValue";
            this.lblRatingValue.Size = new System.Drawing.Size(0, 19);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.lblSelectMovie);
            this.Controls.Add(this.cboMovies);
            this.Controls.Add(this.grpDetails);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSelectMovie;
        private System.Windows.Forms.ComboBox cboMovies;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitleValue;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblDirectorValue;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblYearValue;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblGenreValue;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblRatingValue;
    }
}
