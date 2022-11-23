
namespace Parcial.Windows
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AgregartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.GuardartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OrtoedrosdataGridView = new System.Windows.Forms.DataGridView();
            this.colAristaA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAristaB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAristaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVolumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.contadottextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrtoedrosdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregartoolStripButton,
            this.BorrartoolStripButton,
            this.EditartoolStripButton,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.GuardartoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(622, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AgregartoolStripButton
            // 
            this.AgregartoolStripButton.Image = global::Parcial.Windows.Properties.Resources._117885;
            this.AgregartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AgregartoolStripButton.Name = "AgregartoolStripButton";
            this.AgregartoolStripButton.Size = new System.Drawing.Size(53, 35);
            this.AgregartoolStripButton.Text = "Agregar";
            this.AgregartoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AgregartoolStripButton.Click += new System.EventHandler(this.AgregartoolStripButton_Click);
            // 
            // BorrartoolStripButton
            // 
            this.BorrartoolStripButton.Image = global::Parcial.Windows.Properties.Resources.pngtree_vector_garbage_icon_png_image_695738;
            this.BorrartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrartoolStripButton.Name = "BorrartoolStripButton";
            this.BorrartoolStripButton.Size = new System.Drawing.Size(43, 35);
            this.BorrartoolStripButton.Text = "Borrar";
            this.BorrartoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrartoolStripButton.Click += new System.EventHandler(this.BorrartoolStripButton_Click);
            // 
            // EditartoolStripButton
            // 
            this.EditartoolStripButton.Image = global::Parcial.Windows.Properties.Resources._1159633;
            this.EditartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditartoolStripButton.Name = "EditartoolStripButton";
            this.EditartoolStripButton.Size = new System.Drawing.Size(41, 35);
            this.EditartoolStripButton.Text = "Editar";
            this.EditartoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // GuardartoolStripButton
            // 
            this.GuardartoolStripButton.Image = global::Parcial.Windows.Properties.Resources.Icono_guardar;
            this.GuardartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardartoolStripButton.Name = "GuardartoolStripButton";
            this.GuardartoolStripButton.Size = new System.Drawing.Size(53, 35);
            this.GuardartoolStripButton.Text = "Guardar";
            this.GuardartoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardartoolStripButton.Click += new System.EventHandler(this.GuardartoolStripButton_Click);
            // 
            // OrtoedrosdataGridView
            // 
            this.OrtoedrosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrtoedrosdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAristaA,
            this.colAristaB,
            this.colAristaC,
            this.colArea,
            this.colVolumen,
            this.colColor});
            this.OrtoedrosdataGridView.Location = new System.Drawing.Point(0, 41);
            this.OrtoedrosdataGridView.MultiSelect = false;
            this.OrtoedrosdataGridView.Name = "OrtoedrosdataGridView";
            this.OrtoedrosdataGridView.ReadOnly = true;
            this.OrtoedrosdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrtoedrosdataGridView.Size = new System.Drawing.Size(621, 219);
            this.OrtoedrosdataGridView.TabIndex = 1;
            // 
            // colAristaA
            // 
            this.colAristaA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAristaA.HeaderText = "Arista 1";
            this.colAristaA.Name = "colAristaA";
            this.colAristaA.ReadOnly = true;
            // 
            // colAristaB
            // 
            this.colAristaB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAristaB.HeaderText = "Arista 2";
            this.colAristaB.Name = "colAristaB";
            this.colAristaB.ReadOnly = true;
            // 
            // colAristaC
            // 
            this.colAristaC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAristaC.HeaderText = "Arista 3";
            this.colAristaC.Name = "colAristaC";
            this.colAristaC.ReadOnly = true;
            // 
            // colArea
            // 
            this.colArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colArea.HeaderText = "Área";
            this.colArea.Name = "colArea";
            this.colArea.ReadOnly = true;
            // 
            // colVolumen
            // 
            this.colVolumen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVolumen.HeaderText = "Volumen";
            this.colVolumen.Name = "colVolumen";
            this.colVolumen.ReadOnly = true;
            // 
            // colColor
            // 
            this.colColor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colColor.HeaderText = "Color";
            this.colColor.Name = "colColor";
            this.colColor.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contador:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contadottextBox
            // 
            this.contadottextBox.Location = new System.Drawing.Point(72, 275);
            this.contadottextBox.Name = "contadottextBox";
            this.contadottextBox.ReadOnly = true;
            this.contadottextBox.Size = new System.Drawing.Size(24, 20);
            this.contadottextBox.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 303);
            this.Controls.Add(this.contadottextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrtoedrosdataGridView);
            this.Controls.Add(this.toolStrip1);
            this.MaximumSize = new System.Drawing.Size(638, 342);
            this.MinimumSize = new System.Drawing.Size(638, 342);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de ortoedros";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrtoedrosdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AgregartoolStripButton;
        private System.Windows.Forms.ToolStripButton BorrartoolStripButton;
        private System.Windows.Forms.ToolStripButton EditartoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton GuardartoolStripButton;
        private System.Windows.Forms.DataGridView OrtoedrosdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAristaA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAristaB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAristaC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVolumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contadottextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

