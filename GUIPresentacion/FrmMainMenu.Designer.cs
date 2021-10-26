
namespace GUIPresentacion
{
    partial class FrmMainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrarAfiliado = new System.Windows.Forms.Button();
            this.panelChild = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegistroLiquidacion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnRegistroLiquidacion);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRegistrarAfiliado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnRegistrarAfiliado
            // 
            this.btnRegistrarAfiliado.Location = new System.Drawing.Point(3, 76);
            this.btnRegistrarAfiliado.Name = "btnRegistrarAfiliado";
            this.btnRegistrarAfiliado.Size = new System.Drawing.Size(194, 48);
            this.btnRegistrarAfiliado.TabIndex = 1;
            this.btnRegistrarAfiliado.Text = "Registrar Afiliado";
            this.btnRegistrarAfiliado.UseVisualStyleBackColor = true;
            this.btnRegistrarAfiliado.Click += new System.EventHandler(this.btnRegistrarAfiliado_Click);
            // 
            // panelChild
            // 
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(200, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(600, 450);
            this.panelChild.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Consultar Afiliados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistroLiquidacion
            // 
            this.btnRegistroLiquidacion.Location = new System.Drawing.Point(3, 184);
            this.btnRegistroLiquidacion.Name = "btnRegistroLiquidacion";
            this.btnRegistroLiquidacion.Size = new System.Drawing.Size(194, 48);
            this.btnRegistroLiquidacion.TabIndex = 3;
            this.btnRegistroLiquidacion.Text = "Registrar liquidaciones";
            this.btnRegistroLiquidacion.UseVisualStyleBackColor = true;
            this.btnRegistroLiquidacion.Click += new System.EventHandler(this.btnRegistroLiquidacion_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMainMenu";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegistrarAfiliado;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegistroLiquidacion;
    }
}

