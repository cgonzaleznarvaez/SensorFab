﻿namespace WindowsFormsApplication2
{
    partial class AddPrimeMatter
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
            this.substrateRadBtn = new System.Windows.Forms.RadioButton();
            this.diafragmRadBtn = new System.Windows.Forms.RadioButton();
            this.primeMatterTxt = new System.Windows.Forms.TextBox();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // substrateRadBtn
            // 
            this.substrateRadBtn.AutoSize = true;
            this.substrateRadBtn.Location = new System.Drawing.Point(187, 30);
            this.substrateRadBtn.Name = "substrateRadBtn";
            this.substrateRadBtn.Size = new System.Drawing.Size(70, 17);
            this.substrateRadBtn.TabIndex = 0;
            this.substrateRadBtn.TabStop = true;
            this.substrateRadBtn.Text = "Substrato";
            this.substrateRadBtn.UseVisualStyleBackColor = true;
            // 
            // diafragmRadBtn
            // 
            this.diafragmRadBtn.AutoSize = true;
            this.diafragmRadBtn.Location = new System.Drawing.Point(187, 54);
            this.diafragmRadBtn.Name = "diafragmRadBtn";
            this.diafragmRadBtn.Size = new System.Drawing.Size(73, 17);
            this.diafragmRadBtn.TabIndex = 1;
            this.diafragmRadBtn.TabStop = true;
            this.diafragmRadBtn.Text = "Diafragma";
            this.diafragmRadBtn.UseVisualStyleBackColor = true;
            // 
            // primeMatterTxt
            // 
            this.primeMatterTxt.Location = new System.Drawing.Point(81, 41);
            this.primeMatterTxt.Name = "primeMatterTxt";
            this.primeMatterTxt.Size = new System.Drawing.Size(100, 20);
            this.primeMatterTxt.TabIndex = 2;
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(37, 107);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 23);
            this.acceptBtn.TabIndex = 3;
            this.acceptBtn.Text = "Aceptar";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(119, 107);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Materia Prima";
            // 
            // AddPrimeMatter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 168);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.primeMatterTxt);
            this.Controls.Add(this.diafragmRadBtn);
            this.Controls.Add(this.substrateRadBtn);
            this.Name = "AddPrimeMatter";
            this.Text = "AddPrimeMatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton substrateRadBtn;
        private System.Windows.Forms.RadioButton diafragmRadBtn;
        private System.Windows.Forms.TextBox primeMatterTxt;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
    }
}