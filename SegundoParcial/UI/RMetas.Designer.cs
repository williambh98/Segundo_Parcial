namespace SegundoParcial.UI
{
    partial class RMetas
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
            this.label3 = new System.Windows.Forms.Label();
            this.MetaIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.CuotanumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MetaIDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuotanumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MetaID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cuota";
            // 
            // MetaIDnumericUpDown
            // 
            this.MetaIDnumericUpDown.Location = new System.Drawing.Point(156, 78);
            this.MetaIDnumericUpDown.Name = "MetaIDnumericUpDown";
            this.MetaIDnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.MetaIDnumericUpDown.TabIndex = 3;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(156, 123);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(120, 22);
            this.DescripciontextBox.TabIndex = 4;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(310, 72);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 49);
            this.Guardarbutton.TabIndex = 6;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // CuotanumericUpDown
            // 
            this.CuotanumericUpDown.DecimalPlaces = 2;
            this.CuotanumericUpDown.Location = new System.Drawing.Point(156, 170);
            this.CuotanumericUpDown.Name = "CuotanumericUpDown";
            this.CuotanumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.CuotanumericUpDown.TabIndex = 7;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(310, 139);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 53);
            this.Buscarbutton.TabIndex = 8;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // RMetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 238);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.CuotanumericUpDown);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.MetaIDnumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RMetas";
            this.Text = "RMetas";
            ((System.ComponentModel.ISupportInitialize)(this.MetaIDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuotanumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MetaIDnumericUpDown;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.NumericUpDown CuotanumericUpDown;
        private System.Windows.Forms.Button Buscarbutton;
    }
}