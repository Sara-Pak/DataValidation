
namespace IT391_Unit6Assignment_SaraPak
{
    partial class BackgrounndImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackgrounndImage));
            this.FullName = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.AgeField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.AgeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AgeError)).BeginInit();
            this.SuspendLayout();
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.FullName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(107)))));
            this.FullName.Location = new System.Drawing.Point(323, 179);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(201, 29);
            this.FullName.TabIndex = 0;
            this.FullName.Text = "Enter your age:";
            this.FullName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(107)))));
            this.Email.Location = new System.Drawing.Point(309, 265);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(229, 29);
            this.Email.TabIndex = 1;
            this.Email.Text = "Enter your e-mail:";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // AgeField
            // 
            this.AgeField.Location = new System.Drawing.Point(378, 218);
            this.AgeField.Name = "AgeField";
            this.AgeField.Size = new System.Drawing.Size(90, 22);
            this.AgeField.TabIndex = 2;
            this.AgeField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.AgeField.Validating += new System.ComponentModel.CancelEventHandler(this.AgeField_Validating);
            // 
            // EmailField
            // 
            this.EmailField.Location = new System.Drawing.Point(276, 305);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(295, 22);
            this.EmailField.TabIndex = 3;
            this.EmailField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(107)))));
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(107)))));
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(361, 352);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(126, 44);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // AgeError
            // 
            this.AgeError.ContainerControl = this;
            // 
            // BackgrounndImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(858, 483);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.AgeField);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.FullName);
            this.Name = "BackgrounndImage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox AgeField;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ErrorProvider AgeError;
    }
}

