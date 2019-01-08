namespace WindowsFormsApp1
{
    partial class FrmCli
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
            this.btnAdcCli = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnRemCli = new DevExpress.XtraEditors.SimpleButton();
            this.btnAltCli = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdcCli
            // 
            this.btnAdcCli.Location = new System.Drawing.Point(3, 3);
            this.btnAdcCli.Name = "btnAdcCli";
            this.btnAdcCli.Size = new System.Drawing.Size(107, 23);
            this.btnAdcCli.TabIndex = 2;
            this.btnAdcCli.Text = "Adicionar Cliente";
            this.btnAdcCli.Click += new System.EventHandler(this.btnAdcCli_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(429, 261);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btnRemCli
            // 
            this.btnRemCli.Location = new System.Drawing.Point(116, 3);
            this.btnRemCli.Name = "btnRemCli";
            this.btnRemCli.Size = new System.Drawing.Size(107, 23);
            this.btnRemCli.TabIndex = 4;
            this.btnRemCli.Text = "Remover Cliente";
            // 
            // btnAltCli
            // 
            this.btnAltCli.Location = new System.Drawing.Point(229, 3);
            this.btnAltCli.Name = "btnAltCli";
            this.btnAltCli.Size = new System.Drawing.Size(107, 23);
            this.btnAltCli.TabIndex = 5;
            this.btnAltCli.Text = "Alterar Informações";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnAdcCli);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnAltCli);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnRemCli);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(429, 299);
            this.splitContainerControl1.SplitterPosition = 33;
            this.splitContainerControl1.TabIndex = 6;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // FrmCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 299);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmCli";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAdcCli;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnRemCli;
        private DevExpress.XtraEditors.SimpleButton btnAltCli;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}