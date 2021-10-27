
namespace ETFZiraat
{
    partial class MusteriKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriKayit));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CARI_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARI_AD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VERGI_D = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VERGI_N = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEL1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEL2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ADRES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ILCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GLN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TC_KIMLIK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EFATURAMI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EFATURA_GB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EFATURA_PK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YETKILI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridListe = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridListe)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.toggleSwitch1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridListe);
            this.splitContainer1.Size = new System.Drawing.Size(1153, 612);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 2;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(90, 12);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "Tüzel";
            this.toggleSwitch1.Properties.OnText = "Bireysel";
            this.toggleSwitch1.Size = new System.Drawing.Size(95, 18);
            this.toggleSwitch1.TabIndex = 20;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Kayıt Türü";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(12, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 174);
            this.panel3.TabIndex = 72;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(18, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(96, 35);
            this.simpleButton1.TabIndex = 70;
            this.simpleButton1.Text = "Kaydet";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(150, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(96, 35);
            this.simpleButton2.TabIndex = 71;
            this.simpleButton2.Text = "Düzenle";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(287, 3);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton3.Size = new System.Drawing.Size(96, 35);
            this.simpleButton3.TabIndex = 72;
            this.simpleButton3.Text = "Rapor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panel2.Controls.Add(this.simpleButton3);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1153, 41);
            this.panel2.TabIndex = 71;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CARI_ID,
            this.CARI_AD,
            this.VERGI_D,
            this.VERGI_N,
            this.TEL1,
            this.TEL2,
            this.ADRES,
            this.IL,
            this.ILCE,
            this.GLN,
            this.TC_KIMLIK,
            this.EMAIL,
            this.EFATURAMI,
            this.EFATURA_GB,
            this.EFATURA_PK,
            this.YETKILI});
            this.gridView1.GridControl = this.GridListe;
            this.gridView1.Name = "gridView1";
            // 
            // CARI_ID
            // 
            this.CARI_ID.Caption = "Cari ID";
            this.CARI_ID.FieldName = "CARI_ID";
            this.CARI_ID.Name = "CARI_ID";
            this.CARI_ID.Visible = true;
            this.CARI_ID.VisibleIndex = 0;
            // 
            // CARI_AD
            // 
            this.CARI_AD.Caption = "Cari Ünvan";
            this.CARI_AD.FieldName = "CARI_AD";
            this.CARI_AD.Name = "CARI_AD";
            this.CARI_AD.Visible = true;
            this.CARI_AD.VisibleIndex = 1;
            // 
            // VERGI_D
            // 
            this.VERGI_D.Caption = "Vergi Dairesi";
            this.VERGI_D.FieldName = "VERGI_D";
            this.VERGI_D.Name = "VERGI_D";
            this.VERGI_D.Visible = true;
            this.VERGI_D.VisibleIndex = 2;
            // 
            // VERGI_N
            // 
            this.VERGI_N.Caption = "Vergi Numarası";
            this.VERGI_N.FieldName = "VERGI_N";
            this.VERGI_N.Name = "VERGI_N";
            this.VERGI_N.Visible = true;
            this.VERGI_N.VisibleIndex = 3;
            // 
            // TEL1
            // 
            this.TEL1.Caption = "Telefon";
            this.TEL1.FieldName = "TEL1";
            this.TEL1.Name = "TEL1";
            this.TEL1.Visible = true;
            this.TEL1.VisibleIndex = 4;
            // 
            // TEL2
            // 
            this.TEL2.Caption = "Telefon";
            this.TEL2.FieldName = "TEL2";
            this.TEL2.Name = "TEL2";
            this.TEL2.Visible = true;
            this.TEL2.VisibleIndex = 5;
            // 
            // ADRES
            // 
            this.ADRES.Caption = "Adres";
            this.ADRES.FieldName = "ADRES";
            this.ADRES.Name = "ADRES";
            this.ADRES.Visible = true;
            this.ADRES.VisibleIndex = 6;
            // 
            // IL
            // 
            this.IL.Caption = "İl";
            this.IL.FieldName = "IL";
            this.IL.Name = "IL";
            this.IL.Visible = true;
            this.IL.VisibleIndex = 7;
            // 
            // ILCE
            // 
            this.ILCE.Caption = "İlçe";
            this.ILCE.FieldName = "ILCE";
            this.ILCE.Name = "ILCE";
            this.ILCE.Visible = true;
            this.ILCE.VisibleIndex = 8;
            // 
            // GLN
            // 
            this.GLN.Caption = "GLN No";
            this.GLN.FieldName = "GLN";
            this.GLN.Name = "GLN";
            this.GLN.Visible = true;
            this.GLN.VisibleIndex = 9;
            // 
            // TC_KIMLIK
            // 
            this.TC_KIMLIK.Caption = "TC Kimlik No";
            this.TC_KIMLIK.FieldName = "TC_KIMLIK";
            this.TC_KIMLIK.Name = "TC_KIMLIK";
            this.TC_KIMLIK.Visible = true;
            this.TC_KIMLIK.VisibleIndex = 10;
            // 
            // EMAIL
            // 
            this.EMAIL.Caption = "E-Mail";
            this.EMAIL.FieldName = "EMAIL";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Visible = true;
            this.EMAIL.VisibleIndex = 11;
            // 
            // EFATURAMI
            // 
            this.EFATURAMI.Caption = "E-Fatura";
            this.EFATURAMI.FieldName = "EFATURAMI";
            this.EFATURAMI.Name = "EFATURAMI";
            this.EFATURAMI.Visible = true;
            this.EFATURAMI.VisibleIndex = 12;
            // 
            // EFATURA_GB
            // 
            this.EFATURA_GB.Caption = "E-Fatura GB";
            this.EFATURA_GB.FieldName = "EFATURA_GB";
            this.EFATURA_GB.Name = "EFATURA_GB";
            this.EFATURA_GB.Visible = true;
            this.EFATURA_GB.VisibleIndex = 13;
            // 
            // EFATURA_PK
            // 
            this.EFATURA_PK.Caption = "E-Fatura PK";
            this.EFATURA_PK.FieldName = "EFATURA_PK";
            this.EFATURA_PK.Name = "EFATURA_PK";
            this.EFATURA_PK.Visible = true;
            this.EFATURA_PK.VisibleIndex = 14;
            // 
            // YETKILI
            // 
            this.YETKILI.Caption = "Yetkili Kişi";
            this.YETKILI.FieldName = "YETKILI";
            this.YETKILI.Name = "YETKILI";
            this.YETKILI.Visible = true;
            this.YETKILI.VisibleIndex = 15;
            // 
            // GridListe
            // 
            this.GridListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridListe.Location = new System.Drawing.Point(0, 0);
            this.GridListe.MainView = this.gridView1;
            this.GridListe.Name = "GridListe";
            this.GridListe.Size = new System.Drawing.Size(1153, 348);
            this.GridListe.TabIndex = 0;
            this.GridListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // MusteriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 612);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MusteriKayit";
            this.Text = "MusteriKayit";
            this.Load += new System.EventHandler(this.MusteriKayit_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraGrid.GridControl GridListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn CARI_ID;
        private DevExpress.XtraGrid.Columns.GridColumn CARI_AD;
        private DevExpress.XtraGrid.Columns.GridColumn VERGI_D;
        private DevExpress.XtraGrid.Columns.GridColumn VERGI_N;
        private DevExpress.XtraGrid.Columns.GridColumn TEL1;
        private DevExpress.XtraGrid.Columns.GridColumn TEL2;
        private DevExpress.XtraGrid.Columns.GridColumn ADRES;
        private DevExpress.XtraGrid.Columns.GridColumn IL;
        private DevExpress.XtraGrid.Columns.GridColumn ILCE;
        private DevExpress.XtraGrid.Columns.GridColumn GLN;
        private DevExpress.XtraGrid.Columns.GridColumn TC_KIMLIK;
        private DevExpress.XtraGrid.Columns.GridColumn EMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn EFATURAMI;
        private DevExpress.XtraGrid.Columns.GridColumn EFATURA_GB;
        private DevExpress.XtraGrid.Columns.GridColumn EFATURA_PK;
        private DevExpress.XtraGrid.Columns.GridColumn YETKILI;
    }
}