namespace Lab5_WebScraper
{
    partial class FormWebScraper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelURL = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.buttonExtractImages = new System.Windows.Forms.Button();
            this.tableLayoutPanelImages = new System.Windows.Forms.TableLayoutPanel();
            this.labelImagesFound = new System.Windows.Forms.Label();
            this.buttonDownloadImages = new System.Windows.Forms.Button();
            this.richTextBoxLinks = new System.Windows.Forms.RichTextBox();
            this.labelImagesFoundCount = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 5;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanelMain.Controls.Add(this.labelURL, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxURL, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonExtractImages, 3, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelImages, 1, 2);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(-7, 12);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.41272F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.58727F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1499, 690);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // labelURL
            // 
            this.labelURL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelURL.AutoSize = true;
            this.labelURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURL.Location = new System.Drawing.Point(44, 76);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(118, 42);
            this.labelURL.TabIndex = 0;
            this.labelURL.Text = "URL: ";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxURL.Location = new System.Drawing.Point(169, 73);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(960, 49);
            this.textBoxURL.TabIndex = 1;
            // 
            // buttonExtractImages
            // 
            this.buttonExtractImages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExtractImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExtractImages.Location = new System.Drawing.Point(1146, 66);
            this.buttonExtractImages.Name = "buttonExtractImages";
            this.buttonExtractImages.Size = new System.Drawing.Size(280, 62);
            this.buttonExtractImages.TabIndex = 2;
            this.buttonExtractImages.Text = "Extract";
            this.buttonExtractImages.UseVisualStyleBackColor = true;
            this.buttonExtractImages.Click += new System.EventHandler(this.buttonExtractImages_Click);
            // 
            // tableLayoutPanelImages
            // 
            this.tableLayoutPanelImages.ColumnCount = 2;
            this.tableLayoutPanelMain.SetColumnSpan(this.tableLayoutPanelImages, 3);
            this.tableLayoutPanelImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelImages.Controls.Add(this.labelImagesFound, 0, 0);
            this.tableLayoutPanelImages.Controls.Add(this.buttonDownloadImages, 0, 1);
            this.tableLayoutPanelImages.Controls.Add(this.richTextBoxLinks, 1, 1);
            this.tableLayoutPanelImages.Controls.Add(this.labelImagesFoundCount, 1, 0);
            this.tableLayoutPanelImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelImages.Location = new System.Drawing.Point(43, 160);
            this.tableLayoutPanelImages.Name = "tableLayoutPanelImages";
            this.tableLayoutPanelImages.RowCount = 2;
            this.tableLayoutPanelMain.SetRowSpan(this.tableLayoutPanelImages, 2);
            this.tableLayoutPanelImages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelImages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanelImages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelImages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelImages.Size = new System.Drawing.Size(1392, 494);
            this.tableLayoutPanelImages.TabIndex = 3;
            this.tableLayoutPanelImages.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelImages_Paint);
            // 
            // labelImagesFound
            // 
            this.labelImagesFound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelImagesFound.AutoSize = true;
            this.labelImagesFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImagesFound.Location = new System.Drawing.Point(80, 37);
            this.labelImagesFound.Name = "labelImagesFound";
            this.labelImagesFound.Size = new System.Drawing.Size(404, 37);
            this.labelImagesFound.TabIndex = 0;
            this.labelImagesFound.Text = "Number of Images Found";
            // 
            // buttonDownloadImages
            // 
            this.buttonDownloadImages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDownloadImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadImages.Location = new System.Drawing.Point(84, 232);
            this.buttonDownloadImages.Name = "buttonDownloadImages";
            this.buttonDownloadImages.Size = new System.Drawing.Size(319, 103);
            this.buttonDownloadImages.TabIndex = 1;
            this.buttonDownloadImages.Text = "Save Images";
            this.buttonDownloadImages.UseVisualStyleBackColor = true;
            this.buttonDownloadImages.Click += new System.EventHandler(this.buttonDownloadImages_Click);
            // 
            // richTextBoxLinks
            // 
            this.richTextBoxLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLinks.Location = new System.Drawing.Point(490, 77);
            this.richTextBoxLinks.Name = "richTextBoxLinks";
            this.richTextBoxLinks.Size = new System.Drawing.Size(899, 414);
            this.richTextBoxLinks.TabIndex = 2;
            this.richTextBoxLinks.Text = "";
            // 
            // labelImagesFoundCount
            // 
            this.labelImagesFoundCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelImagesFoundCount.AutoSize = true;
            this.labelImagesFoundCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImagesFoundCount.Location = new System.Drawing.Point(490, 32);
            this.labelImagesFoundCount.Name = "labelImagesFoundCount";
            this.labelImagesFoundCount.Size = new System.Drawing.Size(0, 42);
            this.labelImagesFoundCount.TabIndex = 3;
            // 
            // FormWebScraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 704);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "FormWebScraper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormWebScraper";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.tableLayoutPanelImages.ResumeLayout(false);
            this.tableLayoutPanelImages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button buttonExtractImages;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelImages;
        private System.Windows.Forms.Label labelImagesFound;
        private System.Windows.Forms.Button buttonDownloadImages;
        private System.Windows.Forms.RichTextBox richTextBoxLinks;
        private System.Windows.Forms.Label labelImagesFoundCount;
    }
}

