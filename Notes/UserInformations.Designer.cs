namespace Notes
{
    partial class UserInformations
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
            this.listViewUser = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewUser
            // 
            this.listViewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewUser.HideSelection = false;
            this.listViewUser.Location = new System.Drawing.Point(12, 12);
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.Size = new System.Drawing.Size(291, 415);
            this.listViewUser.TabIndex = 0;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.View = System.Windows.Forms.View.List;
            // 
            // UserInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 439);
            this.Controls.Add(this.listViewUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserInformations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Informations";
            this.Load += new System.EventHandler(this.UserInformations_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewUser;
    }
}