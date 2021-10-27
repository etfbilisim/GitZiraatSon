
namespace ETFZiraat
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.MusteriIslemleriGrup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MusteriKayit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MusteriListesi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SatisIslemleriGrup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SatisIslemleri = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SatisRaporu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.AlisIslemleriGrup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MalAlis = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.AlisRaporu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MalzemeIslemleriGrup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MalzemeKarti = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MalzemeHareketleri = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.MusteriIslemleriGrup,
            this.SatisIslemleriGrup,
            this.AlisIslemleriGrup,
            this.MalzemeIslemleriGrup});
            this.accordionControl1.ExpandElementMode = DevExpress.XtraBars.Navigation.ExpandElementMode.Single;
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(274, 769);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.Text = "accordionControl1";
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // MusteriIslemleriGrup
            // 
            this.MusteriIslemleriGrup.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.MusteriKayit,
            this.MusteriListesi});
            this.MusteriIslemleriGrup.Expanded = true;
            this.MusteriIslemleriGrup.Name = "MusteriIslemleriGrup";
            this.MusteriIslemleriGrup.Text = "MÜŞTERİ İŞLEMLERİ";
            // 
            // MusteriKayit
            // 
            this.MusteriKayit.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.MusteriKayit.Name = "MusteriKayit";
            this.MusteriKayit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.MusteriKayit.Text = "Müşteri Kayıt";
            this.MusteriKayit.Click += new System.EventHandler(this.MusteriKayit_Click);
            // 
            // MusteriListesi
            // 
            this.MusteriListesi.Name = "MusteriListesi";
            this.MusteriListesi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.MusteriListesi.Text = "Müşteri Listesi";
            // 
            // SatisIslemleriGrup
            // 
            this.SatisIslemleriGrup.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.SatisIslemleri,
            this.SatisRaporu});
            this.SatisIslemleriGrup.Name = "SatisIslemleriGrup";
            this.SatisIslemleriGrup.Text = "SATIŞ İŞLEMLERİ";
            // 
            // SatisIslemleri
            // 
            this.SatisIslemleri.Name = "SatisIslemleri";
            this.SatisIslemleri.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SatisIslemleri.Text = "Satış İşlemleri";
            // 
            // SatisRaporu
            // 
            this.SatisRaporu.Name = "SatisRaporu";
            this.SatisRaporu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SatisRaporu.Text = "Satış Raporu";
            // 
            // AlisIslemleriGrup
            // 
            this.AlisIslemleriGrup.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.MalAlis,
            this.AlisRaporu});
            this.AlisIslemleriGrup.Name = "AlisIslemleriGrup";
            this.AlisIslemleriGrup.Text = "ALIŞ İŞLEMLERİ";
            // 
            // MalAlis
            // 
            this.MalAlis.Name = "MalAlis";
            this.MalAlis.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.MalAlis.Text = "Mal Alış";
            // 
            // AlisRaporu
            // 
            this.AlisRaporu.Name = "AlisRaporu";
            this.AlisRaporu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.AlisRaporu.Text = "Alış Raporu";
            // 
            // MalzemeIslemleriGrup
            // 
            this.MalzemeIslemleriGrup.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.MalzemeKarti,
            this.MalzemeHareketleri});
            this.MalzemeIslemleriGrup.Expanded = true;
            this.MalzemeIslemleriGrup.Name = "MalzemeIslemleriGrup";
            this.MalzemeIslemleriGrup.Text = "MALZEME İŞLEMLERİ";
            // 
            // MalzemeKarti
            // 
            this.MalzemeKarti.Name = "MalzemeKarti";
            this.MalzemeKarti.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.MalzemeKarti.Text = "Malzeme Kartı";
            // 
            // MalzemeHareketleri
            // 
            this.MalzemeHareketleri.Name = "MalzemeHareketleri";
            this.MalzemeHareketleri.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.MalzemeHareketleri.Text = "Malzeme Hareketleri";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 769);
            this.Controls.Add(this.accordionControl1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement MusteriIslemleriGrup;
        private DevExpress.XtraBars.Navigation.AccordionControlElement MusteriKayit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement MusteriListesi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SatisIslemleriGrup;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SatisIslemleri;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SatisRaporu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement AlisIslemleriGrup;
        private DevExpress.XtraBars.Navigation.AccordionControlElement MalAlis;
        private DevExpress.XtraBars.Navigation.AccordionControlElement AlisRaporu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement MalzemeIslemleriGrup;
        private DevExpress.XtraBars.Navigation.AccordionControlElement MalzemeKarti;
        private DevExpress.XtraBars.Navigation.AccordionControlElement MalzemeHareketleri;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

