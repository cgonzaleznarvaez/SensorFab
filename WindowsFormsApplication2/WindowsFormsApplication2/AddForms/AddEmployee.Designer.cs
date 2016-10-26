namespace WindowsFormsApplication2
{
    partial class AddEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.yesRadBtn = new System.Windows.Forms.RadioButton();
            this.noRadBtn = new System.Windows.Forms.RadioButton();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de empleado";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(92, 85);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(61, 13);
            this.passLabel.TabIndex = 2;
            this.passLabel.Text = "Contraseña";
            this.passLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Privilegios para editar";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(159, 28);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(130, 20);
            this.idTxt.TabIndex = 4;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(159, 55);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(130, 20);
            this.nameTxt.TabIndex = 5;
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(159, 82);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(130, 20);
            this.passTxt.TabIndex = 6;
            this.passTxt.Visible = false;
            // 
            // yesRadBtn
            // 
            this.yesRadBtn.AutoSize = true;
            this.yesRadBtn.Location = new System.Drawing.Point(159, 108);
            this.yesRadBtn.Name = "yesRadBtn";
            this.yesRadBtn.Size = new System.Drawing.Size(36, 17);
            this.yesRadBtn.TabIndex = 7;
            this.yesRadBtn.TabStop = true;
            this.yesRadBtn.Text = "Sí";
            this.yesRadBtn.UseVisualStyleBackColor = true;
            this.yesRadBtn.CheckedChanged += new System.EventHandler(this.yesRadBtn_CheckedChanged);
            // 
            // noRadBtn
            // 
            this.noRadBtn.AutoSize = true;
            this.noRadBtn.Location = new System.Drawing.Point(159, 132);
            this.noRadBtn.Name = "noRadBtn";
            this.noRadBtn.Size = new System.Drawing.Size(39, 17);
            this.noRadBtn.TabIndex = 8;
            this.noRadBtn.TabStop = true;
            this.noRadBtn.Text = "No";
            this.noRadBtn.UseVisualStyleBackColor = true;
            this.noRadBtn.CheckedChanged += new System.EventHandler(this.noRadBtn_CheckedChanged);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(95, 168);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 23);
            this.acceptBtn.TabIndex = 9;
            this.acceptBtn.Text = "Aceptar";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(177, 168);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 216);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.noRadBtn);
            this.Controls.Add(this.yesRadBtn);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.RadioButton yesRadBtn;
        private System.Windows.Forms.RadioButton noRadBtn;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}