namespace PracticaMiguelGaibor
{
    partial class PrincipalCiudadano
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLoginC = new System.Windows.Forms.Label();
            this.dgvBuscarC = new System.Windows.Forms.DataGridView();
            this.btnBuscarC = new System.Windows.Forms.Button();
            this.lblEstadoUS = new System.Windows.Forms.Label();
            this.lblAbre = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarC)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.lblLogin, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(183, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(14, 120);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "label1";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.Location = new System.Drawing.Point(3, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(14, 30);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.12335F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.86539F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01125F));
            this.tableLayoutPanel2.Controls.Add(this.lblLoginC, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvBuscarC, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnBuscarC, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblEstadoUS, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblAbre, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(801, 438);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblLoginC
            // 
            this.lblLoginC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoginC.AutoSize = true;
            this.lblLoginC.Location = new System.Drawing.Point(785, 0);
            this.lblLoginC.Name = "lblLoginC";
            this.lblLoginC.Size = new System.Drawing.Size(13, 20);
            this.lblLoginC.TabIndex = 1;
            this.lblLoginC.Text = " ";
            // 
            // dgvBuscarC
            // 
            this.dgvBuscarC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuscarC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.dgvBuscarC, 3);
            this.dgvBuscarC.Location = new System.Drawing.Point(3, 89);
            this.dgvBuscarC.Name = "dgvBuscarC";
            this.dgvBuscarC.RowHeadersWidth = 51;
            this.dgvBuscarC.RowTemplate.Height = 29;
            this.dgvBuscarC.Size = new System.Drawing.Size(795, 346);
            this.dgvBuscarC.TabIndex = 2;
            // 
            // btnBuscarC
            // 
            this.btnBuscarC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarC.Location = new System.Drawing.Point(3, 54);
            this.btnBuscarC.Name = "btnBuscarC";
            this.btnBuscarC.Size = new System.Drawing.Size(99, 29);
            this.btnBuscarC.TabIndex = 0;
            this.btnBuscarC.Text = "Buscar";
            this.btnBuscarC.UseVisualStyleBackColor = true;
            this.btnBuscarC.Click += new System.EventHandler(this.btnBuscarC_Click);
            // 
            // lblEstadoUS
            // 
            this.lblEstadoUS.AutoSize = true;
            this.lblEstadoUS.Location = new System.Drawing.Point(3, 0);
            this.lblEstadoUS.Name = "lblEstadoUS";
            this.lblEstadoUS.Size = new System.Drawing.Size(0, 20);
            this.lblEstadoUS.TabIndex = 3;
            // 
            // lblAbre
            // 
            this.lblAbre.AutoSize = true;
            this.lblAbre.Location = new System.Drawing.Point(108, 0);
            this.lblAbre.Name = "lblAbre";
            this.lblAbre.Size = new System.Drawing.Size(0, 20);
            this.lblAbre.TabIndex = 4;
            this.lblAbre.Visible = false;
            // 
            // PrincipalCiudadano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "PrincipalCiudadano";
            this.Text = "PrincipalCiudadano";
            this.Load += new System.EventHandler(this.PrincipalCiudadano_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        public Label lblLogin;
        private Button btnBuscar;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnBuscarC;
        private DataGridView dgvBuscarC;
        public Label lblEstadoUS;
        public Label lblAbre;
        public Label lblLoginC;
    }
}