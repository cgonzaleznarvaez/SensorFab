namespace WindowsFormsApplication2
{
    partial class AddCompound
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
            this.compoundTxt = new System.Windows.Forms.TextBox();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.goldBackRadBtn = new System.Windows.Forms.RadioButton();
            this.goldFrontRadBtn = new System.Windows.Forms.RadioButton();
            this.pinkGlassRadBtn = new System.Windows.Forms.RadioButton();
            this.glassRadBtn = new System.Windows.Forms.RadioButton();
            this.conductorRadBtn = new System.Windows.Forms.RadioButton();
            this.fritRadBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // compoundTxt
            // 
            this.compoundTxt.Location = new System.Drawing.Point(161, 27);
            this.compoundTxt.Name = "compoundTxt";
            this.compoundTxt.Size = new System.Drawing.Size(100, 20);
            this.compoundTxt.TabIndex = 0;
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(79, 153);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 23);
            this.acceptBtn.TabIndex = 7;
            this.acceptBtn.Text = "Aceptar";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(161, 153);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre de Pasta";
            // 
            // goldBackRadBtn
            // 
            this.goldBackRadBtn.AutoSize = true;
            this.goldBackRadBtn.Location = new System.Drawing.Point(33, 82);
            this.goldBackRadBtn.Name = "goldBackRadBtn";
            this.goldBackRadBtn.Size = new System.Drawing.Size(75, 17);
            this.goldBackRadBtn.TabIndex = 1;
            this.goldBackRadBtn.TabStop = true;
            this.goldBackRadBtn.Text = "Gold Back";
            this.goldBackRadBtn.UseVisualStyleBackColor = true;
            // 
            // goldFrontRadBtn
            // 
            this.goldFrontRadBtn.AutoSize = true;
            this.goldFrontRadBtn.Location = new System.Drawing.Point(33, 106);
            this.goldFrontRadBtn.Name = "goldFrontRadBtn";
            this.goldFrontRadBtn.Size = new System.Drawing.Size(74, 17);
            this.goldFrontRadBtn.TabIndex = 2;
            this.goldFrontRadBtn.TabStop = true;
            this.goldFrontRadBtn.Text = "Gold Front";
            this.goldFrontRadBtn.UseVisualStyleBackColor = true;
            // 
            // pinkGlassRadBtn
            // 
            this.pinkGlassRadBtn.AutoSize = true;
            this.pinkGlassRadBtn.Location = new System.Drawing.Point(124, 106);
            this.pinkGlassRadBtn.Name = "pinkGlassRadBtn";
            this.pinkGlassRadBtn.Size = new System.Drawing.Size(75, 17);
            this.pinkGlassRadBtn.TabIndex = 3;
            this.pinkGlassRadBtn.TabStop = true;
            this.pinkGlassRadBtn.Text = "Pink Glass";
            this.pinkGlassRadBtn.UseVisualStyleBackColor = true;
            // 
            // glassRadBtn
            // 
            this.glassRadBtn.AutoSize = true;
            this.glassRadBtn.Location = new System.Drawing.Point(124, 83);
            this.glassRadBtn.Name = "glassRadBtn";
            this.glassRadBtn.Size = new System.Drawing.Size(51, 17);
            this.glassRadBtn.TabIndex = 4;
            this.glassRadBtn.TabStop = true;
            this.glassRadBtn.Text = "Glass";
            this.glassRadBtn.UseVisualStyleBackColor = true;
            // 
            // conductorRadBtn
            // 
            this.conductorRadBtn.AutoSize = true;
            this.conductorRadBtn.Location = new System.Drawing.Point(215, 82);
            this.conductorRadBtn.Name = "conductorRadBtn";
            this.conductorRadBtn.Size = new System.Drawing.Size(74, 17);
            this.conductorRadBtn.TabIndex = 5;
            this.conductorRadBtn.TabStop = true;
            this.conductorRadBtn.Text = "Conductor";
            this.conductorRadBtn.UseVisualStyleBackColor = true;
            // 
            // fritRadBtn
            // 
            this.fritRadBtn.AutoSize = true;
            this.fritRadBtn.Location = new System.Drawing.Point(215, 106);
            this.fritRadBtn.Name = "fritRadBtn";
            this.fritRadBtn.Size = new System.Drawing.Size(39, 17);
            this.fritRadBtn.TabIndex = 6;
            this.fritRadBtn.TabStop = true;
            this.fritRadBtn.Text = "Frit";
            this.fritRadBtn.UseVisualStyleBackColor = true;
            // 
            // AddCompound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.fritRadBtn);
            this.Controls.Add(this.conductorRadBtn);
            this.Controls.Add(this.glassRadBtn);
            this.Controls.Add(this.pinkGlassRadBtn);
            this.Controls.Add(this.goldFrontRadBtn);
            this.Controls.Add(this.goldBackRadBtn);
            this.Controls.Add(this.compoundTxt);
            this.Name = "AddCompound";
            this.Text = "Agregar Pasta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox compoundTxt;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton goldBackRadBtn;
        private System.Windows.Forms.RadioButton goldFrontRadBtn;
        private System.Windows.Forms.RadioButton pinkGlassRadBtn;
        private System.Windows.Forms.RadioButton glassRadBtn;
        private System.Windows.Forms.RadioButton conductorRadBtn;
        private System.Windows.Forms.RadioButton fritRadBtn;
    }
}