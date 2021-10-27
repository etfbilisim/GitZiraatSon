
namespace ETFZiraat
{
    partial class MusteriListesi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GridListe = new DevExpress.XtraGrid.GridControl();
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 170);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GridListe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 280);
            this.panel2.TabIndex = 1;
            // 
            // GridListe
            // 
            this.GridListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridListe.Location = new System.Drawing.Point(0, 0);
            this.GridListe.MainView = this.gridView1;
            this.GridListe.Name = "GridListe";
            this.GridListe.Size = new System.Drawing.Size(800, 280);
            this.GridListe.TabIndex = 1;
            this.GridListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // MusteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MusteriListesi";
            this.Text = "MusteriListesi";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
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