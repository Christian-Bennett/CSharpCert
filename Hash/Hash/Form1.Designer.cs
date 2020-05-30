namespace Hash
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
            this.UserEntry = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SHA256 = new System.Windows.Forms.TextBox();
            this.SHA256Label = new System.Windows.Forms.Label();
            this.Salt = new System.Windows.Forms.TextBox();
            this.SaltLabel = new System.Windows.Forms.Label();
            this.SaltStore = new System.Windows.Forms.TextBox();
            this.SaltStoreLabel = new System.Windows.Forms.Label();
            this.SHA256StoreLabel = new System.Windows.Forms.Label();
            this.SHA256Store = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UserEntry
            // 
            this.UserEntry.Location = new System.Drawing.Point(12, 12);
            this.UserEntry.Multiline = true;
            this.UserEntry.Name = "UserEntry";
            this.UserEntry.Size = new System.Drawing.Size(185, 33);
            this.UserEntry.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hash";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SHA256
            // 
            this.SHA256.Location = new System.Drawing.Point(12, 94);
            this.SHA256.Multiline = true;
            this.SHA256.Name = "SHA256";
            this.SHA256.Size = new System.Drawing.Size(284, 33);
            this.SHA256.TabIndex = 2;
            // 
            // SHA256Label
            // 
            this.SHA256Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA256Label.Location = new System.Drawing.Point(315, 94);
            this.SHA256Label.Name = "SHA256Label";
            this.SHA256Label.Size = new System.Drawing.Size(114, 33);
            this.SHA256Label.TabIndex = 3;
            this.SHA256Label.Text = "SHA256";
            // 
            // Salt
            // 
            this.Salt.Location = new System.Drawing.Point(12, 55);
            this.Salt.Multiline = true;
            this.Salt.Name = "Salt";
            this.Salt.Size = new System.Drawing.Size(284, 33);
            this.Salt.TabIndex = 4;
            // 
            // SaltLabel
            // 
            this.SaltLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaltLabel.Location = new System.Drawing.Point(315, 55);
            this.SaltLabel.Name = "SaltLabel";
            this.SaltLabel.Size = new System.Drawing.Size(114, 33);
            this.SaltLabel.TabIndex = 5;
            this.SaltLabel.Text = "Salt";
            // 
            // SaltStore
            // 
            this.SaltStore.Location = new System.Drawing.Point(12, 133);
            this.SaltStore.Multiline = true;
            this.SaltStore.Name = "SaltStore";
            this.SaltStore.Size = new System.Drawing.Size(284, 33);
            this.SaltStore.TabIndex = 6;
            // 
            // SaltStoreLabel
            // 
            this.SaltStoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaltStoreLabel.Location = new System.Drawing.Point(315, 133);
            this.SaltStoreLabel.Name = "SaltStoreLabel";
            this.SaltStoreLabel.Size = new System.Drawing.Size(136, 33);
            this.SaltStoreLabel.TabIndex = 7;
            this.SaltStoreLabel.Text = "Salt_Store";
            // 
            // SHA256StoreLabel
            // 
            this.SHA256StoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA256StoreLabel.Location = new System.Drawing.Point(315, 178);
            this.SHA256StoreLabel.Name = "SHA256StoreLabel";
            this.SHA256StoreLabel.Size = new System.Drawing.Size(114, 33);
            this.SHA256StoreLabel.TabIndex = 8;
            this.SHA256StoreLabel.Text = "SHA256_Store";
            // 
            // SHA256Store
            // 
            this.SHA256Store.Location = new System.Drawing.Point(12, 172);
            this.SHA256Store.Multiline = true;
            this.SHA256Store.Name = "SHA256Store";
            this.SHA256Store.Size = new System.Drawing.Size(284, 33);
            this.SHA256Store.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SHA256Store);
            this.Controls.Add(this.SHA256StoreLabel);
            this.Controls.Add(this.SaltStoreLabel);
            this.Controls.Add(this.SaltStore);
            this.Controls.Add(this.SaltLabel);
            this.Controls.Add(this.Salt);
            this.Controls.Add(this.SHA256Label);
            this.Controls.Add(this.SHA256);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserEntry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserEntry;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SHA256;
        private System.Windows.Forms.Label SHA256Label;
        private System.Windows.Forms.TextBox Salt;
        private System.Windows.Forms.Label SaltLabel;
        private System.Windows.Forms.TextBox SaltStore;
        private System.Windows.Forms.Label SaltStoreLabel;
        private System.Windows.Forms.Label SHA256StoreLabel;
        private System.Windows.Forms.TextBox SHA256Store;
    }
}

