﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sultanlar.DbObj.Internet
{
    public class fiyatTipleri : DbObj
    {
        public int NOSU { get; set; }
        public string ACIKLAMA { get; set; }
        public int GMREF { get; set; }

        public fiyatTipleri() { }
        public fiyatTipleri(int NOSU) { this.NOSU = NOSU; }
        private fiyatTipleri(int NOSU, string ACIKLAMA, int GMREF)
        {
            this.NOSU = NOSU;
            this.ACIKLAMA = ACIKLAMA;
            this.GMREF = GMREF;
        }
        
        public override string ToString() { return ACIKLAMA; }
        /// <summary>
        /// 
        /// </summary>
        public override void DoInsert()
        {
            Dictionary<string, object> param = new Dictionary<string, object>() { { "NOSU", NOSU }, { "ACIKLAMA", ACIKLAMA }, { "GMREF", GMREF } };
            Do(QueryType.Update, "db_sp_fiyatTipiEkle", param, timeout);
        }
        /// <summary>
        /// 
        /// </summary>
        public override void DoUpdate()
        {
            Dictionary<string, object> param = new Dictionary<string, object>() { { "NOSU", NOSU }, { "ACIKLAMA", ACIKLAMA }, { "GMREF", GMREF } };
            Do(QueryType.Update, "db_sp_fiyatTipiGuncelle", param, timeout);
        }
        /// <summary>
        /// 
        /// </summary>
        public override void DoDelete()
        {
            Do(QueryType.Delete, "db_sp_fiyatTipiSil", new Dictionary<string, object>() { { "NOSU", NOSU } }, timeout);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public fiyatTipleri GetObject()
        {
            fiyatTipleri donendeger = new fiyatTipleri();

            Dictionary<int, object> dic = GetObject("db_sp_fiyatTipiGetir", new Dictionary<string, object>() { { "NOSU", NOSU } }, timeout);
            if (dic != null)
                donendeger = new fiyatTipleri(ConvertToInt32(dic[0]), dic[1].ToString(), ConvertToInt32(dic[2]));

            return donendeger;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public fiyatTipleri GetObjectByGMREF(int GMREF)
        {
            fiyatTipleri donendeger = new fiyatTipleri();

            Dictionary<int, object> dic = GetObject("db_sp_fiyatTipiGetirByGMREF", new Dictionary<string, object>() { { "GMREF", GMREF } }, timeout);
            if (dic != null)
                donendeger = new fiyatTipleri(ConvertToInt32(dic[0]), dic[1].ToString(), ConvertToInt32(dic[2]));

            return donendeger;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<fiyatTipleri> GetObjects()
        {
            List<fiyatTipleri> donendeger = new List<fiyatTipleri>();

            Dictionary<int, Dictionary<int, object>> dic = GetObjects("db_sp_fiyatTipleriGetir", timeout);
            if (dic != null)
                for (int i = 0; i < dic.Count; i++)
                    donendeger.Add(new fiyatTipleri(ConvertToInt32(dic[i][0]), dic[i][1].ToString(), ConvertToInt32(dic[i][2])));

            return donendeger;
        }
    }
}
