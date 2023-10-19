namespace Connecting_Library_Application_to_SQL_Server
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTitleID = new System.Windows.Forms.Label();
            this.titleIDTextBox = new System.Windows.Forms.TextBox();
            this.lblTitleName = new System.Windows.Forms.Label();
            this.lblTitleType = new System.Windows.Forms.Label();
            this.lblPublisherID = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPublishDate = new System.Windows.Forms.Label();
            this.titleNameTextBox = new System.Windows.Forms.TextBox();
            this.titleTypeTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.pubdateTextBox = new System.Windows.Forms.TextBox();
            this.pubbid = new System.Windows.Forms.ComboBox();
            this.pubsDataSet = new Connecting_Library_Application_to_SQL_Server.pubsDataSet();
            this.pubsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(324, 355);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTitleID
            // 
            this.lblTitleID.AutoSize = true;
            this.lblTitleID.Location = new System.Drawing.Point(181, 78);
            this.lblTitleID.Name = "lblTitleID";
            this.lblTitleID.Size = new System.Drawing.Size(41, 13);
            this.lblTitleID.TabIndex = 1;
            this.lblTitleID.Text = "Title ID";
            this.lblTitleID.Click += new System.EventHandler(this.label1_Click);
            // 
            // titleIDTextBox
            // 
            this.titleIDTextBox.Location = new System.Drawing.Point(303, 71);
            this.titleIDTextBox.Name = "titleIDTextBox";
            this.titleIDTextBox.Size = new System.Drawing.Size(184, 20);
            this.titleIDTextBox.TabIndex = 2;
            // 
            // lblTitleName
            // 
            this.lblTitleName.AutoSize = true;
            this.lblTitleName.Location = new System.Drawing.Point(181, 115);
            this.lblTitleName.Name = "lblTitleName";
            this.lblTitleName.Size = new System.Drawing.Size(58, 13);
            this.lblTitleName.TabIndex = 1;
            this.lblTitleName.Text = "Title Name";
            this.lblTitleName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitleType
            // 
            this.lblTitleType.AutoSize = true;
            this.lblTitleType.Location = new System.Drawing.Point(181, 159);
            this.lblTitleType.Name = "lblTitleType";
            this.lblTitleType.Size = new System.Drawing.Size(54, 13);
            this.lblTitleType.TabIndex = 1;
            this.lblTitleType.Text = "Title Type";
            this.lblTitleType.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPublisherID
            // 
            this.lblPublisherID.AutoSize = true;
            this.lblPublisherID.Location = new System.Drawing.Point(181, 196);
            this.lblPublisherID.Name = "lblPublisherID";
            this.lblPublisherID.Size = new System.Drawing.Size(64, 13);
            this.lblPublisherID.TabIndex = 1;
            this.lblPublisherID.Text = "Publisher ID";
            this.lblPublisherID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(181, 239);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price";
            this.lblPrice.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPublishDate
            // 
            this.lblPublishDate.AutoSize = true;
            this.lblPublishDate.Location = new System.Drawing.Point(181, 284);
            this.lblPublishDate.Name = "lblPublishDate";
            this.lblPublishDate.Size = new System.Drawing.Size(67, 13);
            this.lblPublishDate.TabIndex = 1;
            this.lblPublishDate.Text = "Publish Date";
            this.lblPublishDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // titleNameTextBox
            // 
            this.titleNameTextBox.Location = new System.Drawing.Point(303, 112);
            this.titleNameTextBox.Name = "titleNameTextBox";
            this.titleNameTextBox.Size = new System.Drawing.Size(184, 20);
            this.titleNameTextBox.TabIndex = 2;
            this.titleNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // titleTypeTextBox
            // 
            this.titleTypeTextBox.Location = new System.Drawing.Point(303, 152);
            this.titleTypeTextBox.Name = "titleTypeTextBox";
            this.titleTypeTextBox.Size = new System.Drawing.Size(184, 20);
            this.titleTypeTextBox.TabIndex = 2;
            this.titleTypeTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(303, 232);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(184, 20);
            this.priceTextBox.TabIndex = 2;
            this.priceTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pubdateTextBox
            // 
            this.pubdateTextBox.Location = new System.Drawing.Point(303, 277);
            this.pubdateTextBox.Name = "pubdateTextBox";
            this.pubdateTextBox.Size = new System.Drawing.Size(184, 20);
            this.pubdateTextBox.TabIndex = 2;
            this.pubdateTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pubbid
            // 
            this.pubbid.DataSource = this.pubsDataSetBindingSource;
            this.pubbid.FormattingEnabled = true;
            this.pubbid.Location = new System.Drawing.Point(303, 193);
            this.pubbid.Name = "pubbid";
            this.pubbid.Size = new System.Drawing.Size(184, 21);
            this.pubbid.TabIndex = 3;
            // 
            // pubsDataSet
            // 
            this.pubsDataSet.DataSetName = "pubsDataSet";
            this.pubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pubsDataSetBindingSource
            // 
            this.pubsDataSetBindingSource.DataSource = this.pubsDataSet;
            this.pubsDataSetBindingSource.Position = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pubbid);
            this.Controls.Add(this.pubdateTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.titleTypeTextBox);
            this.Controls.Add(this.titleNameTextBox);
            this.Controls.Add(this.titleIDTextBox);
            this.Controls.Add(this.lblPublishDate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPublisherID);
            this.Controls.Add(this.lblTitleType);
            this.Controls.Add(this.lblTitleName);
            this.Controls.Add(this.lblTitleID);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form2";
            this.Text = "Add Title";
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTitleID;
        private System.Windows.Forms.TextBox titleIDTextBox;
        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.Label lblTitleType;
        private System.Windows.Forms.Label lblPublisherID;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPublishDate;
        private System.Windows.Forms.TextBox titleNameTextBox;
        private System.Windows.Forms.TextBox titleTypeTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox pubdateTextBox;
        private System.Windows.Forms.ComboBox pubbid;
        private System.Windows.Forms.BindingSource pubsDataSetBindingSource;
        private pubsDataSet pubsDataSet;
    }
}