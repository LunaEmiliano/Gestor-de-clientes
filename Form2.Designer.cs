﻿namespace WindowsFormsApp1
{
    partial class Form2
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.btnBuscarOrden = new System.Windows.Forms.Button();
            this.btnAgregarOrden = new System.Windows.Forms.Button();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnBuscarOrden);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnAgregarOrden);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(489, 86);
            this.toolStripContainer1.Location = new System.Drawing.Point(164, 200);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(489, 111);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // btnBuscarOrden
            // 
            this.btnBuscarOrden.Location = new System.Drawing.Point(283, 28);
            this.btnBuscarOrden.Name = "btnBuscarOrden";
            this.btnBuscarOrden.Size = new System.Drawing.Size(112, 23);
            this.btnBuscarOrden.TabIndex = 6;
            this.btnBuscarOrden.Text = "Buscar orden";
            this.btnBuscarOrden.UseVisualStyleBackColor = true;
            // 
            // btnAgregarOrden
            // 
            this.btnAgregarOrden.Location = new System.Drawing.Point(54, 28);
            this.btnAgregarOrden.Name = "btnAgregarOrden";
            this.btnAgregarOrden.Size = new System.Drawing.Size(146, 23);
            this.btnAgregarOrden.TabIndex = 5;
            this.btnAgregarOrden.Text = "Argegar nueva orden";
            this.btnAgregarOrden.UseVisualStyleBackColor = true;
            this.btnAgregarOrden.Click += new System.EventHandler(this.btnAgregarOrden_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form2";
            this.Text = "Bienvenido";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button btnAgregarOrden;
        private System.Windows.Forms.Button btnBuscarOrden;
    }
}