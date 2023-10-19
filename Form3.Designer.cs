namespace Connecting_Library_Application_to_SQL_Server
{
    partial class Form3
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.oldid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.oldname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tname = new System.Windows.Forms.TextBox();
            this.Ttype = new System.Windows.Forms.TextBox();
            this.Tprice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(369, 317);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title ID";
            // 
            // oldid
            // 
            this.oldid.Location = new System.Drawing.Point(220, 89);
            this.oldid.Name = "oldid";
            this.oldid.Size = new System.Drawing.Size(100, 20);
            this.oldid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title name";
            // 
            // oldname
            // 
            this.oldname.Location = new System.Drawing.Point(220, 157);
            this.oldname.Name = "oldname";
            this.oldname.Size = new System.Drawing.Size(100, 20);
            this.oldname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "New Title Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "New Title Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "New Title Price";
            // 
            // Tname
            // 
            this.Tname.Location = new System.Drawing.Point(565, 96);
            this.Tname.Name = "Tname";
            this.Tname.Size = new System.Drawing.Size(100, 20);
            this.Tname.TabIndex = 2;
            this.Tname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Ttype
            // 
            this.Ttype.Location = new System.Drawing.Point(565, 153);
            this.Ttype.Name = "Ttype";
            this.Ttype.Size = new System.Drawing.Size(100, 20);
            this.Ttype.TabIndex = 2;
            this.Ttype.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Tprice
            // 
            this.Tprice.Location = new System.Drawing.Point(565, 227);
            this.Tprice.Name = "Tprice";
            this.Tprice.Size = new System.Drawing.Size(100, 20);
            this.Tprice.TabIndex = 2;
            this.Tprice.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.oldname);
            this.Controls.Add(this.Tprice);
            this.Controls.Add(this.Ttype);
            this.Controls.Add(this.Tname);
            this.Controls.Add(this.oldid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Name = "Form3";
            this.Text = "Edit Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tname;
        private System.Windows.Forms.TextBox Ttype;
        private System.Windows.Forms.TextBox Tprice;
    }
}