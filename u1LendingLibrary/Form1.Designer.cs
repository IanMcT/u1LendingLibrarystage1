namespace u1LendingLibrary
{
    partial class Form1
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
            this.btnItems = new System.Windows.Forms.Button();
            this.btnFriends = new System.Windows.Forms.Button();
            this.lbFriends = new System.Windows.Forms.ListBox();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.btnLend = new System.Windows.Forms.Button();
            this.lbLentItems = new System.Windows.Forms.ListBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnItems
            // 
            this.btnItems.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnItems.Location = new System.Drawing.Point(44, 54);
            this.btnItems.Margin = new System.Windows.Forms.Padding(2);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(183, 34);
            this.btnItems.TabIndex = 3;
            this.btnItems.Text = "Add/edit/delete Items";
            this.btnItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItems.UseVisualStyleBackColor = true;
            // 
            // btnFriends
            // 
            this.btnFriends.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFriends.Location = new System.Drawing.Point(44, 8);
            this.btnFriends.Margin = new System.Windows.Forms.Padding(2);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Size = new System.Drawing.Size(183, 34);
            this.btnFriends.TabIndex = 1;
            this.btnFriends.Text = "Add/edit/delete Friends";
            this.btnFriends.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFriends.UseVisualStyleBackColor = true;
            this.btnFriends.Click += new System.EventHandler(this.btnFriends_Click);
            // 
            // lbFriends
            // 
            this.lbFriends.FormattingEnabled = true;
            this.lbFriends.Location = new System.Drawing.Point(13, 114);
            this.lbFriends.Name = "lbFriends";
            this.lbFriends.Size = new System.Drawing.Size(120, 95);
            this.lbFriends.TabIndex = 5;
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(167, 114);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(120, 95);
            this.lbItems.TabIndex = 6;
            // 
            // btnLend
            // 
            this.btnLend.Location = new System.Drawing.Point(294, 185);
            this.btnLend.Name = "btnLend";
            this.btnLend.Size = new System.Drawing.Size(75, 23);
            this.btnLend.TabIndex = 7;
            this.btnLend.Text = "Lend";
            this.btnLend.UseVisualStyleBackColor = true;
            // 
            // lbLentItems
            // 
            this.lbLentItems.FormattingEnabled = true;
            this.lbLentItems.Location = new System.Drawing.Point(13, 226);
            this.lbLentItems.Name = "lbLentItems";
            this.lbLentItems.Size = new System.Drawing.Size(120, 95);
            this.lbLentItems.TabIndex = 8;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(294, 297);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 481);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lbLentItems);
            this.Controls.Add(this.btnLend);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.lbFriends);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnFriends);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFriends;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.ListBox lbFriends;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Button btnLend;
        private System.Windows.Forms.ListBox lbLentItems;
        private System.Windows.Forms.Button btnReturn;
    }
}

