﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sultanlar.DatabaseObject.Internet;
using Sultanlar.DatabaseObject;

namespace Sultanlar.UI
{
    public partial class frmINTERNETcarihesapz : Form
    {
        public frmINTERNETcarihesapz()
        {
            InitializeComponent();
        }

        private void frmINTERNETcarihesapz_Load(object sender, EventArgs e)
        {
            GetTipler();
            GetIller();
        }

        private void GetIller()
        {
            Iller.GetObject(cmbIl.Items, true);
            Iller.GetObject(cmbBayiIl.Items, true);
            Iller.GetObject(cmbZiyIl.Items, true);
        }

        private void GetMusteri()
        {
            if (((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 2) // sap musteri subeleri
            {
                cmbMusteri.Items.Clear();
                cmbMusteri.Text = string.Empty;
                CariHesaplar.GetMUSTERIs(cmbMusteri.Items, "", true);
            }
            else if (((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 3) // ziy ler
            {

            }
            else if (((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 5) // bayi musteri subeleri
            {
                cmbBayiMusteri.Items.Clear();
                cmbBayiMusteri.Text = string.Empty;
                CariHesaplarTP.GetObjects(cmbBayiMusteri.Items, 0);
            }
        }

        private void GetTipler()
        {
            //CariHesapZTipler.GetObjects(listBox1.Items);
            CariHesapZTipler.GetObjects(cmbTipler.Items);
            cmbTipler.SelectedIndex = 0;
        }

        private void GetMusteriler()
        {
            DataTable dt = new DataTable();
            CariHesapZ.GetObjects(dt, ((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD);
            gridView1.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
            gridControl1.DataSource = dt;

            if (((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 3)
            {
                CariHesaplar.GetMusteriTurler(cmbZiyMusAciklama.Items);
                cmbZiyMusAciklama.SelectedIndex = 0;
                SatisTemsilcileri.GetObjects(cmbZiySatici.Items, true);
                cmbZiySatici.SelectedIndex = -1;
            }
        }

        #region TIP 2
        private void Detay2(int row)
        {
            if (row == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                cmbMusAciklama.Items.Clear();
                cmbSatici.Items.Clear();
                cmbMusteri.SelectedIndex = -1;
                cmbAnaSube.Items.Clear();
                cmbAnaSube.Text = string.Empty;
                //listBox1.SelectedIndex = -1;
                txtSube.Text = string.Empty;
                cbPasif.Checked = false;
                txtAdres.Text = string.Empty;
                cmbIl.SelectedIndex = -1;
                cmbIlce.SelectedIndex = -1;
                txtSemt.Text = string.Empty;
                txtTelefon.Text = string.Empty;

                sbSatici.Enabled = false;
                sbSaticiKopyala.Enabled = false;
                sbEkle.Enabled = false;
                sbGuncelle.Text = "Ekle";
            }
            else
            {
                sbSatici.Enabled = true;
                sbSaticiKopyala.Enabled = true;
                sbEkle.Enabled = true;
                sbGuncelle.Text = "Güncelle";

                txtSube.Text = gridView1.GetRowCellValue(row, "SUBE").ToString();
                cbPasif.Checked = Convert.ToInt32(gridView1.GetRowCellValue(row, "ACTIVE")) == 1;
                txtAdres.Text = gridView1.GetRowCellValue(row, "ADRES").ToString();
                txtSemt.Text = gridView1.GetRowCellValue(row, "SEMT").ToString();
                txtTelefon.Text = gridView1.GetRowCellValue(row, "TEL-1").ToString();
                for (int i = 0; i < cmbMusteri.Items.Count; i++)
                {
                    if (((CariHesaplar)cmbMusteri.Items[i]).GMREF == Convert.ToInt32(gridView1.GetRowCellValue(row, "GMREF")))
                    {
                        cmbMusteri.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < cmbAnaSube.Items.Count; i++)
                {
                    if (((CariHesaplar)cmbAnaSube.Items[i]).SMREF == Convert.ToInt32(gridView1.GetRowCellValue(row, "NETTOP")))
                    {
                        cmbAnaSube.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < cmbMusAciklama.Items.Count; i++)
                {
                    if (((MusteriTurler)cmbMusAciklama.Items[i]).Kod == gridView1.GetRowCellValue(row, "MT KOD").ToString())
                    {
                        cmbMusAciklama.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < cmbSatici.Items.Count; i++)
                {
                    if (((SatisTemsilcileri)cmbSatici.Items[i]).SLSREF == Convert.ToInt32(gridView1.GetRowCellValue(row, "SLSREF")))
                    {
                        cmbSatici.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < cmbIl.Items.Count; i++)
                {
                    if (((Iller)cmbIl.Items[i]).pkIlID == Convert.ToInt32(gridView1.GetRowCellValue(row, "IL KOD")))
                    {
                        cmbIl.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < cmbIlce.Items.Count; i++)
                {
                    if (((Ilceler)cmbIlce.Items[i]).pkIlceID == Convert.ToInt32(gridView1.GetRowCellValue(row, "ILCE KOD")))
                    {
                        cmbIlce.SelectedIndex = i;
                        break;
                    }
                }
                //for (int i = 0; i < listBox1.Items.Count; i++)
                //{
                //    if (((CariHesapZTipler)listBox1.Items[i]).TIP_KOD == Convert.ToInt32(gridView1.GetRowCellValue(row, "TIP")))
                //    {
                //        listBox1.SelectedIndex = i;
                //        break;
                //    }
                //}
            }
        }
        #endregion

        #region TIP 3
        private void Detay3(int row)
        {
            if (row == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                cmbZiyMusAciklama.SelectedIndex = -1;
                cmbZiySatici.SelectedIndex = -1;
                //cmbZiyMusteri.SelectedIndex = -1;
                //cmbZiyAnaSube.Items.Clear();
                //cmbZiyAnaSube.Text = string.Empty;
                //listBox1.SelectedIndex = -1;
                txtZiySube.Text = string.Empty;
                cbZiyPasif.Checked = false;
                txtZiyAdres.Text = string.Empty;
                cmbZiyIl.SelectedIndex = -1;
                cmbZiyIlce.SelectedIndex = -1;
                txtZiySemt.Text = string.Empty;
                txtZiyTelefon.Text = string.Empty;

                sbZiySatici.Enabled = false;
                sbZiySaticiKopyala.Enabled = false;
                sbEkle.Enabled = false;
                sbGuncelle.Text = "Ekle";
            }
            else
            {
                sbZiySatici.Enabled = true;
                sbZiySaticiKopyala.Enabled = true;
                sbEkle.Enabled = true;
                sbGuncelle.Text = "Güncelle";

                txtZiySube.Text = gridView1.GetRowCellValue(row, "SUBE").ToString();
                cbZiyPasif.Checked = Convert.ToInt32(gridView1.GetRowCellValue(row, "ACTIVE")) == 1;
                txtZiyAdres.Text = gridView1.GetRowCellValue(row, "ADRES").ToString();
                txtZiySemt.Text = gridView1.GetRowCellValue(row, "SEMT").ToString();
                txtZiyTelefon.Text = gridView1.GetRowCellValue(row, "TEL-1").ToString();

                for (int i = 0; i < cmbZiyMusteri.Items.Count; i++)
                {
                    if (((CariHesaplarTP)cmbZiyMusteri.Items[i]).GMREF == Convert.ToInt32(gridView1.GetRowCellValue(row, "GMREF")))
                    {
                        cmbZiyMusteri.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < cmbZiyAnaSube.Items.Count; i++)
                {
                    if (((CariHesaplarTP)cmbZiyMusteri.SelectedItem).GMREF != 1001327)
                    {
                        if (((CariHesaplarTP)cmbZiyAnaSube.Items[i]).SMREF == Convert.ToInt32(gridView1.GetRowCellValue(row, "NETTOP")))
                        {
                            cmbZiyAnaSube.SelectedIndex = i;
                            break;
                        }
                    }
                    else
                    {
                        if (((CariHesaplar)cmbZiyAnaSube.Items[i]).GMREF == Convert.ToInt32(gridView1.GetRowCellValue(row, "NETTOP")))
                        {
                            cmbZiyAnaSube.SelectedIndex = i;
                            break;
                        }
                    }
                }
                for (int i = 0; i < cmbZiyMusAciklama.Items.Count; i++)
                {
                    if (((MusteriTurler)cmbZiyMusAciklama.Items[i]).Kod == gridView1.GetRowCellValue(row, "MT KOD").ToString())
                    {
                        cmbZiyMusAciklama.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < cmbZiySatici.Items.Count; i++)
                {
                    if (((SatisTemsilcileri)cmbZiySatici.Items[i]).SLSREF == Convert.ToInt32(gridView1.GetRowCellValue(row, "SLSREF")))
                    {
                        cmbZiySatici.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < cmbZiyIl.Items.Count; i++)
                {
                    if (((Iller)cmbZiyIl.Items[i]).pkIlID == Convert.ToInt32(gridView1.GetRowCellValue(row, "IL KOD")))
                    {
                        cmbZiyIl.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < cmbZiyIlce.Items.Count; i++)
                {
                    if (((Ilceler)cmbZiyIlce.Items[i]).pkIlceID == Convert.ToInt32(gridView1.GetRowCellValue(row, "ILCE KOD")))
                    {
                        cmbZiyIlce.SelectedIndex = i;
                        break;
                    }
                }
                //for (int i = 0; i < listBox1.Items.Count; i++)
                //{
                //    if (((CariHesapZTipler)listBox1.Items[i]).TIP_KOD == Convert.ToInt32(gridView1.GetRowCellValue(row, "TIP")))
                //    {
                //        listBox1.SelectedIndex = i;
                //        break;
                //    }
                //}
            }
        }
        #endregion

        #region TIP 5
        private void Detay5(int row)
        {
            if (row == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                cmbBayiMusAciklama.Items.Clear();
                cmbBayiSatici.Items.Clear();
                cmbBayiMusteri.SelectedIndex = -1;
                cmbBayiAnaSube.Items.Clear();
                cmbBayiAnaSube.Text = string.Empty;
                //listBox1.SelectedIndex = -1;
                txtBayiSube.Text = string.Empty;
                cbBayiPasif.Checked = false;
                txtBayiAdres.Text = string.Empty;
                cmbBayiIl.SelectedIndex = -1;
                cmbBayiIlce.SelectedIndex = -1;
                cmbBayiSemt.Text = string.Empty;
                cmbBayiTelefon.Text = string.Empty;

                sbBayiSatici.Enabled = false;
                sbBayiSaticiKopyala.Enabled = false;
                sbEkle.Enabled = false;
                sbGuncelle.Text = "Ekle";
            }
            else
            {
                sbBayiSatici.Enabled = true;
                sbBayiSaticiKopyala.Enabled = true;
                sbEkle.Enabled = true;
                sbGuncelle.Text = "Güncelle";

                txtBayiSube.Text = gridView1.GetRowCellValue(row, "SUBE").ToString();
                cbBayiPasif.Checked = Convert.ToInt32(gridView1.GetRowCellValue(row, "ACTIVE")) == 1;
                txtBayiAdres.Text = gridView1.GetRowCellValue(row, "ADRES").ToString();
                cmbBayiSemt.Text = gridView1.GetRowCellValue(row, "SEMT").ToString();
                cmbBayiTelefon.Text = gridView1.GetRowCellValue(row, "TEL-1").ToString();
                for (int i = 0; i < cmbBayiMusteri.Items.Count; i++)
                {
                    if (((CariHesaplarTP)cmbBayiMusteri.Items[i]).GMREF == Convert.ToInt32(gridView1.GetRowCellValue(row, "GMREF")))
                    {
                        cmbBayiMusteri.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < cmbBayiAnaSube.Items.Count; i++)
                {
                    if (((CariHesaplarTP)cmbBayiAnaSube.Items[i]).SMREF == Convert.ToInt32(gridView1.GetRowCellValue(row, "NETTOP")))
                    {
                        cmbBayiAnaSube.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < cmbBayiMusAciklama.Items.Count; i++)
                {
                    if (((MusteriTurler)cmbBayiMusAciklama.Items[i]).Kod == gridView1.GetRowCellValue(row, "MT KOD").ToString())
                    {
                        cmbBayiMusAciklama.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < cmbBayiSatici.Items.Count; i++)
                {
                    if (((SatisTemsilcileri)cmbBayiSatici.Items[i]).SLSREF == Convert.ToInt32(gridView1.GetRowCellValue(row, "SLSREF")))
                    {
                        cmbBayiSatici.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < cmbBayiIl.Items.Count; i++)
                {
                    if (((Iller)cmbBayiIl.Items[i]).pkIlID == Convert.ToInt32(gridView1.GetRowCellValue(row, "IL KOD")))
                    {
                        cmbBayiIl.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < cmbBayiIlce.Items.Count; i++)
                {
                    if (((Ilceler)cmbBayiIlce.Items[i]).pkIlceID == Convert.ToInt32(gridView1.GetRowCellValue(row, "ILCE KOD")))
                    {
                        cmbBayiIlce.SelectedIndex = i;
                        break;
                    }
                }
                //for (int i = 0; i < listBox1.Items.Count; i++)
                //{
                //    if (((CariHesapZTipler)listBox1.Items[i]).TIP_KOD == Convert.ToInt32(gridView1.GetRowCellValue(row, "TIP")))
                //    {
                //        listBox1.SelectedIndex = i;
                //        break;
                //    }
                //}
            }
        }
        #endregion

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 2)
                Detay2(e.FocusedRowHandle);
            else if (((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 3)
                Detay3(e.FocusedRowHandle);
            else if (((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 5)
                Detay5(e.FocusedRowHandle);
        }

        private void sbEkle_Click(object sender, EventArgs e)
        {
            if (((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 2 || ((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 3 || ((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 5)
                gridView1.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
        }

        private void sbGuncelle_Click(object sender, EventArgs e)
        {
            if (((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD != 2 && ((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD != 3 && ((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD != 5)
                return;

            bool girdi = false;

            if (((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 2)
            {
                if (cmbAnaSube.SelectedIndex == -1 || cmbMusAciklama.SelectedIndex == -1 || cmbMusteri.SelectedIndex == -1
                    || cmbSatici.SelectedIndex == -1 || cmbIl.SelectedIndex == -1 || cmbIlce.SelectedIndex == -1 || 
                    txtSube.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Eksik seçim yaptınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 3)
            {
                if (cmbZiyMusAciklama.SelectedIndex == -1 || cmbZiySatici.SelectedIndex == -1 || 
                    cmbZiyIl.SelectedIndex == -1 || cmbZiyIlce.SelectedIndex == -1 || txtZiySube.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Eksik seçim yaptınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 5)
            {
                if (cmbBayiAnaSube.SelectedIndex == -1 || cmbBayiMusAciklama.SelectedIndex == -1 || cmbBayiMusteri.SelectedIndex == -1
                    || cmbBayiSatici.SelectedIndex == -1 || cmbBayiIl.SelectedIndex == -1 || cmbBayiIlce.SelectedIndex == -1 || 
                    txtBayiSube.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Eksik seçim yaptınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (sbGuncelle.Text == "Ekle")
            {
                CariHesapZ chz = new CariHesapZ(short.MinValue, "", "", "", "", "", "", "", "", 0, "", "", "", 0, "", "", "", 0, "", "", 0, "", "", "", "", "", "", "", "", "", "", "", "", 0);

                if (((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 2)
                {
                    chz = new CariHesapZ(cbPasif.Checked ? (short)1 : (short)0,
                    "", "", "", "",
                    ((Iller)cmbIl.SelectedItem).pkIlID.ToString(), ((Iller)cmbIl.SelectedItem).strIl, 
                    ((Ilceler)cmbIlce.SelectedItem).pkIlceID.ToString(), ((Ilceler)cmbIlce.SelectedItem).strIlce,
                    ((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD,
                    ((MusteriTurler)cmbMusAciklama.SelectedItem).Kod,
                    ((MusteriTurler)cmbMusAciklama.SelectedItem).Aciklama,
                    "",
                    ((SatisTemsilcileri)cmbSatici.SelectedItem).SLSREF,
                    "", "",
                    ((SatisTemsilcileri)cmbSatici.SelectedItem).SATTEM,
                    ((CariHesaplar)cmbMusteri.SelectedItem).GMREF,
                    "",
                    ((CariHesaplar)cmbMusteri.SelectedItem).MUSTERI,
                    CariHesapZ.GetMaxSMREF(((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD) + 1,
                    "",
                    txtSube.Text.Trim(),
                    txtAdres.Text.Trim(), "", txtSemt.Text.Trim(), "", "", txtTelefon.Text.Trim(), "", "", "", "",
                    ((CariHesaplar)cmbAnaSube.SelectedItem).SMREF);
                }
                else if (((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 3)
                {
                    chz.ACTIVE = cbZiyPasif.Checked ? (short)1 : (short)0;
                    chz.ILKOD = ((Iller)cmbZiyIl.SelectedItem).pkIlID.ToString();
                    chz.IL = ((Iller)cmbZiyIl.SelectedItem).strIl;
                    chz.ILCEKOD = ((Ilceler)cmbZiyIlce.SelectedItem).pkIlceID.ToString();
                    chz.ILCE = ((Ilceler)cmbZiyIlce.SelectedItem).strIlce;
                    chz.TIP = ((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD;
                    chz.MTKOD = ((MusteriTurler)cmbZiyMusAciklama.SelectedItem).Kod;
                    chz.MTACIKLAMA = ((MusteriTurler)cmbZiyMusAciklama.SelectedItem).Aciklama;
                    chz.SLSREF = ((SatisTemsilcileri)cmbZiySatici.SelectedItem).SLSREF;
                    chz.SATTEM = ((SatisTemsilcileri)cmbZiySatici.SelectedItem).SATTEM;
                    chz.GMREF = 1011641;
                    chz.MUSTERI = "ZİYARET MÜŞTERİLERİ";
                    chz.SMREF = CariHesapZ.GetMaxSMREF(((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD) + 1;
                    chz.SUBE = txtZiySube.Text.Trim();
                    chz.ADRES = txtZiyAdres.Text.Trim();
                    chz.SEMT = txtZiySemt.Text.Trim();
                    chz.TEL1 = txtZiyTelefon.Text.Trim();
                    chz.NETTOP = 1011641;
                }
                else if (((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 5)
                {
                    chz.ACTIVE = cbBayiPasif.Checked ? (short)1 : (short)0;
                    chz.ILKOD = ((Iller)cmbBayiIl.SelectedItem).pkIlID.ToString();
                    chz.IL = ((Iller)cmbBayiIl.SelectedItem).strIl;
                    chz.ILCEKOD = ((Ilceler)cmbBayiIlce.SelectedItem).pkIlceID.ToString();
                    chz.ILCE = ((Ilceler)cmbBayiIlce.SelectedItem).strIlce;
                    chz.TIP = ((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD;
                    chz.MTKOD = ((MusteriTurler)cmbBayiMusAciklama.SelectedItem).Kod;
                    chz.MTACIKLAMA = ((MusteriTurler)cmbBayiMusAciklama.SelectedItem).Aciklama;
                    chz.SLSREF = ((SatisTemsilcileri)cmbBayiSatici.SelectedItem).SLSREF;
                    chz.SATTEM = ((SatisTemsilcileri)cmbBayiSatici.SelectedItem).SATTEM;
                    chz.GMREF = ((CariHesaplarTP)cmbBayiMusteri.SelectedItem).GMREF;
                    chz.MUSTERI = ((CariHesaplarTP)cmbBayiMusteri.SelectedItem).MUSTERI;
                    chz.SMREF = CariHesapZ.GetMaxSMREF(((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD) + 1;
                    chz.SUBE = txtBayiSube.Text.Trim();
                    chz.ADRES = txtBayiAdres.Text.Trim();
                    chz.SEMT = cmbBayiSemt.Text.Trim();
                    chz.TEL1 = cmbBayiTelefon.Text.Trim();
                    chz.NETTOP = ((CariHesaplarTP)cmbBayiAnaSube.SelectedItem).SMREF;
                }

                chz.DoInsert();

                MessageBox.Show("Ekleme yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                girdi = true;
            }
            else if (sbGuncelle.Text == "Güncelle")
            {
                short pasif = (short)0;
                string ilkod = string.Empty;
                string il = string.Empty;
                string ilcekod = string.Empty;
                string ilce = string.Empty;
                string mtkod = string.Empty;
                string mtaciklama = string.Empty;
                int gmref = 0;
                string musteri = string.Empty;
                double nettop = 0;
                string sube = string.Empty;
                string adres = string.Empty;
                string semt = string.Empty;
                string telefon = string.Empty;

                if (((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 2)
                {
                    pasif = cbPasif.Checked ? (short)1 : (short)0;
                    ilkod = ((Iller)cmbIl.SelectedItem).pkIlID.ToString();
                    il = ((Iller)cmbIl.SelectedItem).strIl;
                    ilcekod = ((Ilceler)cmbIlce.SelectedItem).pkIlceID.ToString();
                    ilce = ((Ilceler)cmbIlce.SelectedItem).strIlce;
                    mtkod = ((MusteriTurler)cmbMusAciklama.SelectedItem).Kod;
                    mtaciklama = ((MusteriTurler)cmbMusAciklama.SelectedItem).Aciklama;
                    gmref = ((CariHesaplar)cmbMusteri.SelectedItem).GMREF;
                    musteri = ((CariHesaplar)cmbMusteri.SelectedItem).MUSTERI;
                    nettop = ((CariHesaplar)cmbAnaSube.SelectedItem).SMREF;
                    sube = txtSube.Text.Trim();
                    adres = txtAdres.Text.Trim();
                    semt = txtSemt.Text.Trim();
                    telefon = txtTelefon.Text.Trim();
                }
                else if (((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 3)
                {
                    pasif = cbZiyPasif.Checked ? (short)1 : (short)0;
                    ilkod = ((Iller)cmbZiyIl.SelectedItem).pkIlID.ToString();
                    il = ((Iller)cmbZiyIl.SelectedItem).strIl;
                    ilcekod = ((Ilceler)cmbZiyIlce.SelectedItem).pkIlceID.ToString();
                    ilce = ((Ilceler)cmbZiyIlce.SelectedItem).strIlce;
                    mtkod = ((MusteriTurler)cmbZiyMusAciklama.SelectedItem).Kod;
                    mtaciklama = ((MusteriTurler)cmbZiyMusAciklama.SelectedItem).Aciklama;
                    gmref = 1011641;
                    musteri = "ZİYARET MÜŞTERİLERİ";
                    nettop = 1011641;
                    sube = txtZiySube.Text.Trim();
                    adres = txtZiyAdres.Text.Trim();
                    semt = txtZiySemt.Text.Trim();
                    telefon = txtZiyTelefon.Text.Trim();
                }
                else if (((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 5)
                {
                    pasif = cbBayiPasif.Checked ? (short)1 : (short)0;
                    ilkod = ((Iller)cmbBayiIl.SelectedItem).pkIlID.ToString();
                    il = ((Iller)cmbBayiIl.SelectedItem).strIl;
                    ilcekod = ((Ilceler)cmbBayiIlce.SelectedItem).pkIlceID.ToString();
                    ilce = ((Ilceler)cmbBayiIlce.SelectedItem).strIlce;
                    mtkod = ((MusteriTurler)cmbBayiMusAciklama.SelectedItem).Kod;
                    mtaciklama = ((MusteriTurler)cmbBayiMusAciklama.SelectedItem).Aciklama;
                    gmref = ((CariHesaplarTP)cmbBayiMusteri.SelectedItem).GMREF;
                    musteri = ((CariHesaplarTP)cmbBayiMusteri.SelectedItem).MUSTERI;
                    nettop = ((CariHesaplarTP)cmbBayiAnaSube.SelectedItem).SMREF;
                    sube = txtBayiSube.Text.Trim();
                    adres = txtBayiAdres.Text.Trim();
                    semt = cmbBayiSemt.Text.Trim();
                    telefon = cmbBayiTelefon.Text.Trim();
                }

                CariHesapZ.DoUpdateAll(pasif,
                    "", "", "", "",
                    ilkod, il, ilcekod, ilce,
                    ((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD,
                    mtkod,
                    mtaciklama,
                    "", "", "",
                    gmref,
                    "",
                    musteri,
                    Convert.ToInt32(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "SMREF")),
                    "",
                    sube,
                    adres, "", semt, "", "", telefon, "", "", "", "",
                    nettop);

                MessageBox.Show("Güncelleme yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                girdi = true;
            }

            if (girdi)
                btnYenile.PerformClick();
        }

        private void cmbMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMusteri.SelectedIndex > -1)
            {
                CariHesaplar.GetSUBEs(cmbAnaSube.Items, ((CariHesaplar)cmbMusteri.SelectedItem).GMREF);
                cmbAnaSube.SelectedIndex = 0;

                CariHesaplar.GetMusteriTurler(cmbMusAciklama.Items, ((CariHesaplar)cmbMusteri.SelectedItem).GMREF);
                cmbMusAciklama.SelectedIndex = 0;
            }
        }

        private void cmbAnaSube_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMusteri.SelectedIndex > -1)
            {
                CariHesaplar.GetSatTemsBySMREF(cmbSatici.Items, ((CariHesaplar)cmbAnaSube.SelectedItem).SMREF, true);
                cmbSatici.SelectedIndex = 0;
            }
        }

        private void cmbBayiMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBayiMusteri.SelectedIndex > -1)
            {
                CariHesaplarTP.GetSubelerByGMREF(cmbBayiAnaSube.Items, ((CariHesaplarTP)cmbBayiMusteri.SelectedItem).GMREF, true);
                cmbBayiAnaSube.SelectedIndex = 0;

                CariHesaplar.GetMusteriTurler(cmbBayiMusAciklama.Items, ((CariHesaplarTP)cmbBayiMusteri.SelectedItem).GMREF);
                cmbBayiMusAciklama.SelectedIndex = 0;

                CariHesaplar.GetSatTemsByGMREF(cmbBayiSatici.Items, ((CariHesaplarTP)cmbBayiMusteri.SelectedItem).GMREF, true);
                cmbBayiSatici.SelectedIndex = 0;
            }
        }

        private void cmbZiyMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbZiyMusteri.SelectedIndex > -1)
            {
                
            }
        }

        private void sbSatici_Click(object sender, EventArgs e)
        {
            if (cmbSatici.SelectedIndex == -1)
                return;

            //CariHesapZ chz = CariHesapZ.GetObject(Convert.ToInt32(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "SMREF")),
            //    Convert.ToInt32(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "SLSREF")));

            //chz.ACTIVE = cbPasif.Checked ? (short)1 : (short)0;
            //chz.SUBE = txtSube.Text.Trim();
            //chz.TIP = ((CariHesapZTipler)listBox1.SelectedItem).TIP_KOD;
            //chz.NETTOP = ((CariHesaplar)cmbAnaSube.SelectedItem).SMREF;
            //chz.MTKOD = ((MusteriTurler)cmbMusAciklama.SelectedItem).Kod;
            //chz.MTACIKLAMA = ((MusteriTurler)cmbMusAciklama.SelectedItem).Aciklama;
            //chz.GMREF = ((CariHesaplar)cmbMusteri.SelectedItem).GMREF;
            //chz.MUSTERI = ((CariHesaplar)cmbMusteri.SelectedItem).MUSTERI;
            //chz.SLSREF = ((SatisTemsilcileri)cmbSatici.SelectedItem).SLSREF;
            //chz.SATTEM = ((SatisTemsilcileri)cmbSatici.SelectedItem).SATTEM;

            //chz.DoUpdate();

            CariHesapZ.DoUpdateSLS(Convert.ToInt32(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "SLSREF")),
                Convert.ToInt32(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "SMREF")),
                ((SatisTemsilcileri)cmbSatici.SelectedItem).SLSREF, ((SatisTemsilcileri)cmbSatici.SelectedItem).SATTEM);

            MessageBox.Show("Güncelleme yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnYenile.PerformClick();
        }

        private void sbBayiSatici_Click(object sender, EventArgs e)
        {
            CariHesapZ.DoUpdateSLS(Convert.ToInt32(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "SLSREF")),
                Convert.ToInt32(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "SMREF")),
                ((SatisTemsilcileri)cmbBayiSatici.SelectedItem).SLSREF, ((SatisTemsilcileri)cmbBayiSatici.SelectedItem).SATTEM);

            MessageBox.Show("Güncelleme yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnYenile.PerformClick();
        }

        private void sbZiySatici_Click(object sender, EventArgs e)
        {
            CariHesapZ.DoUpdateSLS(Convert.ToInt32(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "SLSREF")),
                Convert.ToInt32(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "SMREF")),
                ((SatisTemsilcileri)cmbZiySatici.SelectedItem).SLSREF, ((SatisTemsilcileri)cmbZiySatici.SelectedItem).SATTEM);

            MessageBox.Show("Güncelleme yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnYenile.PerformClick();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            GetMusteriler();
        }

        private void cmbTipler_SelectedIndexChanged(object sender, EventArgs e)
        {
            grSAP.Visible = ((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 2;
            grBayi.Visible = ((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 5;
            grZiy.Visible = ((CariHesapZTipler)cmbTipler.SelectedItem).TIP_KOD == 3;
            GetMusteri();
            GetMusteriler();
            gridView1.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
        }

        private void sbDetay_Click(object sender, EventArgs e)
        {
            frmINTERNETrutekleme frm = new frmINTERNETrutekleme();
            frm.ShowDialog();
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIl.SelectedIndex > -1)
            {
                Ilceler.GetObject(cmbIlce.Items, ((Iller)cmbIl.SelectedItem).strIlKod, true);
                cmbIlce.SelectedIndex = 0;
            }
        }

        private void cmbZiyIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbZiyIl.SelectedIndex > -1)
            {
                Ilceler.GetObject(cmbZiyIlce.Items, ((Iller)cmbZiyIl.SelectedItem).strIlKod, true);
                cmbZiyIlce.SelectedIndex = 0;
            }
        }

        private void cmbBayiIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBayiIl.SelectedIndex > -1)
            {
                Ilceler.GetObject(cmbBayiIlce.Items, ((Iller)cmbBayiIl.SelectedItem).strIlKod, true);
                cmbBayiIlce.SelectedIndex = 0;
            }
        }

        private void sbSaticiKopyala_Click(object sender, EventArgs e)
        {
            if (cmbAnaSube.SelectedIndex == -1 || cmbMusAciklama.SelectedIndex == -1 || cmbMusteri.SelectedIndex == -1
                || cmbSatici.SelectedIndex == -1 || cmbIl.SelectedIndex == -1 || cmbIlce.SelectedIndex == -1 ||
                txtSube.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Eksik seçim yaptınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int smref = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "SMREF"));

            if (CariHesapZ.GetObject(smref, ((SatisTemsilcileri)cmbSatici.SelectedItem).SLSREF).SMREF > 0)
            {
                MessageBox.Show("Seçilen satış temsilcisi bu müşteride zaten var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CariHesapZ chz = new CariHesapZ(short.MinValue, "", "", "", "", "", "", "", "", 0, "", "", "",
                ((SatisTemsilcileri)cmbSatici.SelectedItem).SLSREF, "", "", "", 0, "", "",
                smref, "", "", "", "", "", "", "", "", "", "", "", "", 0);

            chz.ACTIVE = cbPasif.Checked ? (short)1 : (short)0;
            chz.ILKOD = ((Iller)cmbIl.SelectedItem).pkIlID.ToString();
            chz.IL = ((Iller)cmbIl.SelectedItem).strIl;
            chz.ILCEKOD = ((Ilceler)cmbIlce.SelectedItem).pkIlceID.ToString();
            chz.ILCE = ((Ilceler)cmbIlce.SelectedItem).strIlce;
            chz.TIP = 2;
            chz.MTKOD = ((MusteriTurler)cmbMusAciklama.SelectedItem).Kod;
            chz.MTACIKLAMA = ((MusteriTurler)cmbMusAciklama.SelectedItem).Aciklama;
            chz.SATTEM = ((SatisTemsilcileri)cmbSatici.SelectedItem).SATTEM;
            chz.GMREF = ((CariHesaplar)cmbMusteri.SelectedItem).GMREF;
            chz.MUSTERI = ((CariHesaplar)cmbMusteri.SelectedItem).MUSTERI;
            chz.NETTOP = ((CariHesaplar)cmbAnaSube.SelectedItem).SMREF;
            chz.SUBE = txtSube.Text.Trim();
            chz.ADRES = txtAdres.Text.Trim();
            chz.SEMT = txtSemt.Text.Trim();
            chz.TEL1 = txtTelefon.Text.Trim();

            chz.DoInsert();

            MessageBox.Show("Kopyalama yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sbZiySaticiKopyala_Click(object sender, EventArgs e)
        {
            if (cmbZiyMusAciklama.SelectedIndex == -1 || cmbZiySatici.SelectedIndex == -1 ||
                cmbZiyIl.SelectedIndex == -1 || cmbZiyIlce.SelectedIndex == -1 || txtZiySube.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Eksik seçim yaptınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int smref = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "SMREF"));

            if (CariHesapZ.GetObject(smref, ((SatisTemsilcileri)cmbZiySatici.SelectedItem).SLSREF).SMREF > 0)
            {
                MessageBox.Show("Seçilen satış temsilcisi bu müşteride zaten var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CariHesapZ chz = new CariHesapZ(short.MinValue, "", "", "", "", "", "", "", "", 0, "", "", "",
                ((SatisTemsilcileri)cmbZiySatici.SelectedItem).SLSREF, "", "", "", 0, "", "",
                smref, "", "", "", "", "", "", "", "", "", "", "", "", 0);

            chz.ACTIVE = cbZiyPasif.Checked ? (short)1 : (short)0;
            chz.ILKOD = ((Iller)cmbZiyIl.SelectedItem).pkIlID.ToString();
            chz.IL = ((Iller)cmbZiyIl.SelectedItem).strIl;
            chz.ILCEKOD = ((Ilceler)cmbZiyIlce.SelectedItem).pkIlceID.ToString();
            chz.ILCE = ((Ilceler)cmbZiyIlce.SelectedItem).strIlce;
            chz.TIP = 3;
            chz.MTKOD = ((MusteriTurler)cmbZiyMusAciklama.SelectedItem).Kod;
            chz.MTACIKLAMA = ((MusteriTurler)cmbZiyMusAciklama.SelectedItem).Aciklama;
            chz.SATTEM = ((SatisTemsilcileri)cmbZiySatici.SelectedItem).SATTEM;
            chz.GMREF = 1011641;
            chz.MUSTERI = "ZİYARET MÜŞTERİLERİ";
            chz.NETTOP = 1011641;
            chz.SUBE = txtZiySube.Text.Trim();
            chz.ADRES = txtZiyAdres.Text.Trim();
            chz.SEMT = txtZiySemt.Text.Trim();
            chz.TEL1 = txtZiyTelefon.Text.Trim();

            chz.DoInsert();

            MessageBox.Show("Kopyalama yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sbBayiSaticiKopyala_Click(object sender, EventArgs e)
        {
            if (cmbBayiAnaSube.SelectedIndex == -1 || cmbBayiMusAciklama.SelectedIndex == -1 || cmbBayiMusteri.SelectedIndex == -1
                || cmbBayiSatici.SelectedIndex == -1 || cmbBayiIl.SelectedIndex == -1 || cmbBayiIlce.SelectedIndex == -1 ||
                txtBayiSube.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Eksik seçim yaptınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int smref = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "SMREF"));

            if (CariHesapZ.GetObject(smref, ((SatisTemsilcileri)cmbBayiSatici.SelectedItem).SLSREF).SMREF > 0)
            {
                MessageBox.Show("Seçilen satış temsilcisi bu müşteride zaten var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CariHesapZ chz = new CariHesapZ(short.MinValue, "", "", "", "", "", "", "", "", 0, "", "", "",
                ((SatisTemsilcileri)cmbBayiSatici.SelectedItem).SLSREF, "", "", "", 0, "", "",
                smref, "", "", "", "", "", "", "", "", "", "", "", "", 0);

            chz.ACTIVE = cbBayiPasif.Checked ? (short)1 : (short)0;
            chz.ILKOD = ((Iller)cmbBayiIl.SelectedItem).pkIlID.ToString();
            chz.IL = ((Iller)cmbBayiIl.SelectedItem).strIl;
            chz.ILCEKOD = ((Ilceler)cmbBayiIlce.SelectedItem).pkIlceID.ToString();
            chz.ILCE = ((Ilceler)cmbBayiIlce.SelectedItem).strIlce;
            chz.TIP = 5;
            chz.MTKOD = ((MusteriTurler)cmbBayiMusAciklama.SelectedItem).Kod;
            chz.MTACIKLAMA = ((MusteriTurler)cmbBayiMusAciklama.SelectedItem).Aciklama;
            chz.SATTEM = ((SatisTemsilcileri)cmbBayiSatici.SelectedItem).SATTEM;
            chz.GMREF = ((CariHesaplarTP)cmbBayiMusteri.SelectedItem).GMREF;
            chz.MUSTERI = ((CariHesaplarTP)cmbBayiMusteri.SelectedItem).MUSTERI;
            chz.NETTOP = ((CariHesaplarTP)cmbBayiAnaSube.SelectedItem).SMREF;
            chz.SUBE = txtBayiSube.Text.Trim();
            chz.ADRES = txtBayiAdres.Text.Trim();
            chz.SEMT = cmbBayiSemt.Text.Trim();
            chz.TEL1 = cmbBayiTelefon.Text.Trim();

            chz.DoInsert();

            MessageBox.Show("Kopyalama yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sbRutlar_Click(object sender, EventArgs e)
        {
            frmINTERNETrutnotlar frm = new frmINTERNETrutnotlar();
            frm.ShowDialog();
        }
    }
}