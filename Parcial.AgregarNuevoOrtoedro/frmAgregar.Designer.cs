
namespace Parcial.AgregarNuevoOrtoedro
{
    partial class frmAgregar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aristaAtextBox = new System.Windows.Forms.TextBox();
            this.aristaBtextBox = new System.Windows.Forms.TextBox();
            this.aristaCtextBox = new System.Windows.Forms.TextBox();
            this.colorcomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ortoedroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ortoedroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la primer arista:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese la segunda arista:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ingrese la tercera arista:";
            // 
            // aristaAtextBox
            // 
            this.aristaAtextBox.Location = new System.Drawing.Point(139, 6);
            this.aristaAtextBox.Name = "aristaAtextBox";
            this.aristaAtextBox.Size = new System.Drawing.Size(100, 20);
            this.aristaAtextBox.TabIndex = 1;
            // 
            // aristaBtextBox
            // 
            this.aristaBtextBox.Location = new System.Drawing.Point(139, 43);
            this.aristaBtextBox.Name = "aristaBtextBox";
            this.aristaBtextBox.Size = new System.Drawing.Size(100, 20);
            this.aristaBtextBox.TabIndex = 1;
            // 
            // aristaCtextBox
            // 
            this.aristaCtextBox.Location = new System.Drawing.Point(139, 83);
            this.aristaCtextBox.Name = "aristaCtextBox";
            this.aristaCtextBox.Size = new System.Drawing.Size(100, 20);
            this.aristaCtextBox.TabIndex = 1;
            // 
            // colorcomboBox
            // 
            this.colorcomboBox.FormattingEnabled = true;
            this.colorcomboBox.Location = new System.Drawing.Point(118, 127);
            this.colorcomboBox.Name = "colorcomboBox";
            this.colorcomboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colorcomboBox.Size = new System.Drawing.Size(121, 21);
            this.colorcomboBox.TabIndex = 2;
            this.colorcomboBox.SelectedIndexChanged += new System.EventHandler(this.colorcomboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seleccione el color:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ortoedroBindingSource
            // 
            this.ortoedroBindingSource.DataSource = typeof(Parcial.Entidades.Ortoedro);
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 293);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colorcomboBox);
            this.Controls.Add(this.aristaCtextBox);
            this.Controls.Add(this.aristaBtextBox);
            this.Controls.Add(this.aristaAtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregando nuevo ortoedro...";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ortoedroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aristaAtextBox;
        private System.Windows.Forms.TextBox aristaBtextBox;
        private System.Windows.Forms.TextBox aristaCtextBox;
        private System.Windows.Forms.ComboBox colorcomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource ortoedroBindingSource;
    }
}

