namespace WindowsFormsApplication2
{
    partial class MainForm
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
        /// 
        private void InitializeComponent()
        {
            
            this.exit = new System.Windows.Forms.Button();
            this.printTag = new System.Windows.Forms.Button();
            this.addWorkOrder = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signInMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFamilyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPrimeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCompoundMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addModelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFamilyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePrimeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCompoundMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeModelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEmployeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(100, 208);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(320, 50);
            this.exit.TabIndex = 5;
            this.exit.Text = "Salir";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // printTag
            // 
            this.printTag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.printTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printTag.Location = new System.Drawing.Point(100, 138);
            this.printTag.Name = "printTag";
            this.printTag.Size = new System.Drawing.Size(320, 50);
            this.printTag.TabIndex = 4;
            this.printTag.Text = "Imprimir etiquetas de identificación";
            this.printTag.UseVisualStyleBackColor = true;
            // 
            // addWorkOrder
            // 
            this.addWorkOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWorkOrder.Location = new System.Drawing.Point(100, 68);
            this.addWorkOrder.Name = "addWorkOrder";
            this.addWorkOrder.Size = new System.Drawing.Size(320, 50);
            this.addWorkOrder.TabIndex = 3;
            this.addWorkOrder.Text = "Ingresar número de Work Order";
            this.addWorkOrder.UseVisualStyleBackColor = true;
            this.addWorkOrder.Click += new System.EventHandler(this.addWorkOrder_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuMenuItem
            // 
            this.menuMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signInMenuItem,
            this.addMenuItem,
            this.removeMenuItem});
            this.menuMenuItem.Name = "menuMenuItem";
            this.menuMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuMenuItem.Text = "Menú";
            // 
            // signInMenuItem
            // 
            this.signInMenuItem.Name = "signInMenuItem";
            this.signInMenuItem.Size = new System.Drawing.Size(152, 22);
            this.signInMenuItem.Text = "Iniciar sesión";
            this.signInMenuItem.Click += new System.EventHandler(this.iniciarSesiónToolStripMenuItem_Click);
            // 
            // addMenuItem
            // 
            this.addMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFamilyMenuItem,
            this.addPrimeMenuItem,
            this.addCompoundMenuItem,
            this.addModelMenuItem,
            this.addEmployeeStripMenuItem});
            this.addMenuItem.Name = "addMenuItem";
            this.addMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addMenuItem.Text = "Agregar";
            // 
            // addFamilyMenuItem
            // 
            this.addFamilyMenuItem.Name = "addFamilyMenuItem";
            this.addFamilyMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addFamilyMenuItem.Text = "Familia";
            // 
            // addPrimeMenuItem
            // 
            this.addPrimeMenuItem.Name = "addPrimeMenuItem";
            this.addPrimeMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addPrimeMenuItem.Text = "Materia prima";
            // 
            // addCompoundMenuItem
            // 
            this.addCompoundMenuItem.Name = "addCompoundMenuItem";
            this.addCompoundMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addCompoundMenuItem.Text = "Pasta";
            // 
            // addModelMenuItem
            // 
            this.addModelMenuItem.Name = "addModelMenuItem";
            this.addModelMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addModelMenuItem.Text = "Modelo";
            // 
            // addEmployeeStripMenuItem
            // 
            this.addEmployeeStripMenuItem.Name = "addEmployeeStripMenuItem";
            this.addEmployeeStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addEmployeeStripMenuItem.Text = "Empleado";
            // 
            // removeMenuItem
            // 
            this.removeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFamilyMenuItem,
            this.removePrimeMenuItem,
            this.removeCompoundMenuItem,
            this.removeModelMenuItem,
            this.removeEmployeeMenuItem});
            this.removeMenuItem.Name = "removeMenuItem";
            this.removeMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeMenuItem.Text = "Remover";
            // 
            // removeFamilyMenuItem
            // 
            this.removeFamilyMenuItem.Name = "removeFamilyMenuItem";
            this.removeFamilyMenuItem.Size = new System.Drawing.Size(148, 22);
            this.removeFamilyMenuItem.Text = "Familia";
            // 
            // removePrimeMenuItem
            // 
            this.removePrimeMenuItem.Name = "removePrimeMenuItem";
            this.removePrimeMenuItem.Size = new System.Drawing.Size(148, 22);
            this.removePrimeMenuItem.Text = "Materia Prima";
            // 
            // removeCompoundMenuItem
            // 
            this.removeCompoundMenuItem.Name = "removeCompoundMenuItem";
            this.removeCompoundMenuItem.Size = new System.Drawing.Size(148, 22);
            this.removeCompoundMenuItem.Text = "Pasta";
            // 
            // removeModelMenuItem
            // 
            this.removeModelMenuItem.Name = "removeModelMenuItem";
            this.removeModelMenuItem.Size = new System.Drawing.Size(148, 22);
            this.removeModelMenuItem.Text = "Modelo";
            // 
            // removeEmployeeMenuItem
            // 
            this.removeEmployeeMenuItem.Name = "removeEmployeeMenuItem";
            this.removeEmployeeMenuItem.Size = new System.Drawing.Size(148, 22);
            this.removeEmployeeMenuItem.Text = "Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.printTag);
            this.Controls.Add(this.addWorkOrder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button printTag;
        private System.Windows.Forms.Button addWorkOrder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signInMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFamilyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPrimeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCompoundMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addModelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFamilyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePrimeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCompoundMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeModelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeEmployeeMenuItem;
        private System.Windows.Forms.Label label1;

        public static int editor = 0;
    }
}

